using BLL;
using Entity;

namespace ClubGestion
{
    public partial class Form1 : Form
    {
        private readonly CategoriaBLL _categoriaBll = new CategoriaBLL();
        private readonly SocioBLL _socioBll = new SocioBLL();
        private readonly ActividadBLL _actividadBll = new ActividadBLL();
        private readonly InscripcionBLL _inscripcionBll = new InscripcionBLL();
        private int _idSeleccionado;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                cboCategoria.DataSource = _categoriaBll.ObtenerTodas();
                cboCategoria.DisplayMember = "Descripcion";
                cboCategoria.ValueMember = "Id";

                clbActividades.DataSource = _actividadBll.ObtenerTodas();
                clbActividades.DisplayMember = "Nombre";

                cboModificarActividad.DataSource = _actividadBll.ObtenerTodas();
                cboModificarActividad.DisplayMember = "Nombre";
                cboModificarActividad.ValueMember = "Id";
                cboModificarActividad.SelectedIndex = -1;

                cboActividadVer.DataSource = _actividadBll.ObtenerTodas();
                cboActividadVer.DisplayMember = "Nombre";
                cboActividadVer.ValueMember = "Id";

                CargarSocios();
                CargarInscriptos();
            }
            catch (Exception ex)
            {
                MostrarError(ex);
            }
        }

        private void CargarSocios()
        {
            var socios = _socioBll.ObtenerTodos();
            dgvSocios.DataSource = null;
            dgvSocios.DataSource = socios;
            if (dgvSocios.Columns["Id"] != null) dgvSocios.Columns["Id"].Visible = false;

            cboSocio.DataSource = socios.Where(s => s.Activo).ToList();
            cboSocio.DisplayMember = "Apellido";
            cboSocio.ValueMember = "Id";
        }

        private void CargarInscriptos()
        {
            if (cboActividadVer.SelectedItem is not Actividad actividad) return;
            dgvInscriptos.DataSource = null;
            dgvInscriptos.DataSource = _inscripcionBll.ObtenerPorActividad(actividad.Id);
            lblCupos.Text = "Cupos libres: " + _actividadBll.CuposLibres(actividad) + " de " + actividad.Cupo;
        }

        private Socio LeerSocio()
        {
            return new Socio
            {
                Id = _idSeleccionado,
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Dni = txtDni.Text,
                Email = txtEmail.Text,
                Telefono = txtTelefono.Text,
                Activo = chkActivo.Checked,
                Categoria = cboCategoria.SelectedItem as Categoria ?? new Categoria()
            };
        }

        private void Limpiar()
        {
            _idSeleccionado = 0;
            txtNombre.Clear();
            txtApellido.Clear();
            txtDni.Clear();
            txtEmail.Clear();
            txtTelefono.Clear();
            chkActivo.Checked = true;
            if (cboCategoria.Items.Count > 0) cboCategoria.SelectedIndex = 0;
            dgvSocios.ClearSelection();
            txtNombre.Focus();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                var socio = LeerSocio();
                socio.Id = 0;
                _socioBll.Insertar(socio);
                MessageBox.Show("Socio registrado.", "Club", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarSocios();
                Limpiar();
            }
            catch (ReglaNegocioException ex)
            {
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MostrarError(ex);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (_idSeleccionado == 0)
                    throw new ReglaNegocioException("Elegí un socio de la grilla.");
                _socioBll.Modificar(LeerSocio());
                MessageBox.Show("Socio modificado.", "Club", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarSocios();
                Limpiar();
            }
            catch (ReglaNegocioException ex)
            {
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MostrarError(ex);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (_idSeleccionado == 0)
                    throw new ReglaNegocioException("Elegí un socio de la grilla.");
                if (MessageBox.Show("¿Eliminar el socio seleccionado?", "Club", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;
                _socioBll.Eliminar(_idSeleccionado);
                MessageBox.Show("Socio eliminado.", "Club", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarSocios();
                Limpiar();
            }
            catch (ReglaNegocioException ex)
            {
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MostrarError(ex);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void dgvSocios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0) return;
                if (dgvSocios.Rows[e.RowIndex].DataBoundItem is not Socio socio) return;
                _idSeleccionado = socio.Id;
                txtNombre.Text = socio.Nombre;
                txtApellido.Text = socio.Apellido;
                txtDni.Text = socio.Dni;
                txtEmail.Text = socio.Email;
                txtTelefono.Text = socio.Telefono ?? string.Empty;
                chkActivo.Checked = socio.Activo;
                cboCategoria.SelectedValue = socio.Categoria.Id;
            }
            catch (Exception ex)
            {
                MostrarError(ex);
            }
        }

        private void btnInscribir_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboSocio.SelectedItem is not Socio socio)
                    throw new ReglaNegocioException("Elegí un socio.");
                var actividades = clbActividades.CheckedItems.Cast<Actividad>().ToList();
                _inscripcionBll.Inscribir(socio, actividades);
                MessageBox.Show("Inscripción registrada.", "Club", MessageBoxButtons.OK, MessageBoxIcon.Information);
                for (int i = 0; i < clbActividades.Items.Count; i++) clbActividades.SetItemChecked(i, false);
                CargarInscriptos();
            }
            catch (ReglaNegocioException ex)
            {
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MostrarError(ex);
            }
        }

        private void cboActividadVer_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CargarInscriptos();
            }
            catch (Exception ex)
            {
                MostrarError(ex);
            }
        }

        private void MostrarError(Exception ex)
        {
            var detalle = ex.InnerException != null ? Environment.NewLine + Environment.NewLine + "Detalle: " + ex.InnerException.Message : string.Empty;
            MessageBox.Show(ex.Message + detalle, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                var socios = _socioBll.Buscar(txtBuscar.Text);

                dgvSocios.DataSource = null;
                dgvSocios.DataSource = socios;

                if (dgvSocios.Columns["Id"] != null)
                    dgvSocios.Columns["Id"].Visible = false;

                if (socios.Count == 0)
                {
                    MessageBox.Show(
                        "No se encontraron socios.",
                        "Búsqueda",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MostrarError(ex);
            }
        }

        private void btnNuevaActividad_Click(object sender, EventArgs e)
        {
            try
            {
                using (Agregar formulario = new Agregar())
                {
                    if (formulario.ShowDialog(this) == DialogResult.OK)
                    {
                        MessageBox.Show(
                            "La actividad se agregó correctamente.",
                            "ClubGestion",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        clbActividades.DataSource = null;
                        clbActividades.DataSource = _actividadBll.ObtenerTodas();
                        clbActividades.DisplayMember = "Nombre";
                    }
                }
            }
            catch (Exception ex)
            {
                MostrarError(ex);
            }
        }

        private void btnModificarActividad_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboModificarActividad.SelectedItem is not Actividad actividad)
                {
                    MessageBox.Show(
                        "Seleccione una actividad para modificar.",
                        "ClubGestion",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                using (Agregar formulario = new Agregar(actividad))
                {
                    if (formulario.ShowDialog(this) == DialogResult.OK)
                    {
                        ActualizarActividades();
                    }
                }
            }
            catch (Exception ex)
            {
                MostrarError(ex);
            }
        }
        private void ActualizarActividades()
        {
            try
            {
                var actividades = _actividadBll.ObtenerTodas();

                clbActividades.DataSource = null;
                clbActividades.DataSource = actividades;
                clbActividades.DisplayMember = "Nombre";

                cboModificarActividad.DataSource = null;
                cboModificarActividad.DataSource = actividades;
                cboModificarActividad.DisplayMember = "Nombre";
                cboModificarActividad.ValueMember = "Id";
                cboModificarActividad.SelectedIndex = -1;

                cboActividadVer.DataSource = null;
                cboActividadVer.DataSource = _actividadBll.ObtenerTodas();
                cboActividadVer.DisplayMember = "Nombre";
                cboActividadVer.ValueMember = "Id";
                cboActividadVer.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MostrarError(ex);
            }
        }

        private void btnEliminarActividad_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboModificarActividad.SelectedItem is not Actividad actividad)
                {
                    MessageBox.Show(
                        "Seleccione una actividad para eliminar.",
                        "ClubGestion",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                DialogResult respuesta = MessageBox.Show(
                    $"¿Está seguro de eliminar la actividad '{actividad.Nombre}'?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (respuesta != DialogResult.Yes)
                    return;

                _actividadBll.Eliminar(actividad.Id);

                MessageBox.Show(
                    "Actividad eliminada correctamente.",
                    "ClubGestion",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                ActualizarActividades();
            }
            catch (ReglaNegocioException ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MostrarError(ex);
            }
        }
    }
}
