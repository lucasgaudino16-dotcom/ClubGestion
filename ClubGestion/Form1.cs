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
        private int _idActividadSeleccionada;
        private int _idCategoriaSeleccionada;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                CargarCategorias();
                CargarActividades();
                CargarSocios();
                CargarInscriptos();
            }
            catch (Exception ex)
            {
                MostrarError(ex);
            }
        }

        private void CargarCategorias()
        {
            var categorias = _categoriaBll.ObtenerTodas();
            var elegida = cboCategoria.SelectedItem is Categoria c ? c.Id : 0;

            dgvCategorias.DataSource = null;
            dgvCategorias.DataSource = categorias;
            if (dgvCategorias.Columns["Id"] != null) dgvCategorias.Columns["Id"].Visible = false;
            if (dgvCategorias.Columns["CuotaBase"] != null)
            {
                dgvCategorias.Columns["CuotaBase"].HeaderText = "Cuota base";
                dgvCategorias.Columns["CuotaBase"].DefaultCellStyle.Format = "N2";
            }

            cboCategoria.DataSource = null;
            cboCategoria.DataSource = categorias.ToList();
            cboCategoria.DisplayMember = "Descripcion";
            cboCategoria.ValueMember = "Id";

            if (elegida > 0 && categorias.Any(x => x.Id == elegida))
                cboCategoria.SelectedValue = elegida;
        }

        private void CargarSocios()
        {
            var socios = _socioBll.ObtenerTodos();
            MostrarSocios(socios);

            cboSocio.DataSource = socios.Where(s => s.Activo).ToList();
            cboSocio.ValueMember = "Id";
        }

        private void MostrarSocios(List<Socio> socios)
        {
            dgvSocios.DataSource = null;
            dgvSocios.DataSource = socios;
            if (dgvSocios.Columns["Id"] != null) dgvSocios.Columns["Id"].Visible = false;
        }

        private void CargarActividades()
        {
            var actividades = _actividadBll.ObtenerTodas();
            var elegida = cboActividadVer.SelectedItem is Actividad a ? a.Id : 0;

            dgvActividades.DataSource = null;
            dgvActividades.DataSource = actividades;
            if (dgvActividades.Columns["Id"] != null) dgvActividades.Columns["Id"].Visible = false;

            clbActividades.DataSource = null;
            clbActividades.DataSource = actividades;
            clbActividades.DisplayMember = "Nombre";

            cboActividadVer.DataSource = null;
            cboActividadVer.DataSource = actividades.ToList();
            cboActividadVer.DisplayMember = "Nombre";
            cboActividadVer.ValueMember = "Id";

            if (elegida > 0 && actividades.Any(x => x.Id == elegida))
                cboActividadVer.SelectedValue = elegida;
        }

        private void CargarInscriptos()
        {
            if (cboActividadVer.SelectedItem is not Actividad actividad)
            {
                dgvInscriptos.DataSource = null;
                lblCupos.Text = "Cupos libres:";
                return;
            }
            dgvInscriptos.DataSource = null;
            dgvInscriptos.DataSource = _inscripcionBll.ObtenerPorActividad(actividad.Id);
            if (dgvInscriptos.Columns["IdSocio"] != null) dgvInscriptos.Columns["IdSocio"].Visible = false;
            if (dgvInscriptos.Columns["IdActividad"] != null) dgvInscriptos.Columns["IdActividad"].Visible = false;
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                var socios = _socioBll.Buscar(txtBuscar.Text);
                MostrarSocios(socios);
                if (socios.Count == 0)
                    MessageBox.Show("No se encontraron socios con ese apellido, nombre o DNI.", "Club", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MostrarError(ex);
            }
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            e.SuppressKeyPress = true;
            btnBuscar_Click(sender, e);
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

        private Categoria LeerCategoria()
        {
            return new Categoria
            {
                Id = _idCategoriaSeleccionada,
                Descripcion = txtDescripcionCat.Text,
                CuotaBase = nudCuotaBase.Value
            };
        }

        private void LimpiarCategoria()
        {
            _idCategoriaSeleccionada = 0;
            txtDescripcionCat.Clear();
            nudCuotaBase.Value = 0;
            dgvCategorias.ClearSelection();
            txtDescripcionCat.Focus();
        }

        private void btnCatAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                var categoria = LeerCategoria();
                categoria.Id = 0;
                _categoriaBll.Insertar(categoria);
                MessageBox.Show("Categoría registrada.", "Club", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarCategorias();
                LimpiarCategoria();
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

        private void btnCatModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (_idCategoriaSeleccionada == 0)
                    throw new ReglaNegocioException("Elegí una categoría de la grilla.");
                _categoriaBll.Modificar(LeerCategoria());
                MessageBox.Show("Categoría modificada.", "Club", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarCategorias();
                CargarSocios();
                LimpiarCategoria();
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

        private void btnCatEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (_idCategoriaSeleccionada == 0)
                    throw new ReglaNegocioException("Elegí una categoría de la grilla.");
                if (MessageBox.Show("¿Eliminar la categoría seleccionada?", "Club", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;
                _categoriaBll.Eliminar(_idCategoriaSeleccionada);
                MessageBox.Show("Categoría eliminada.", "Club", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarCategorias();
                LimpiarCategoria();
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

        private void btnCatLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCategoria();
        }

        private void dgvCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0) return;
                if (dgvCategorias.Rows[e.RowIndex].DataBoundItem is not Categoria categoria) return;
                _idCategoriaSeleccionada = categoria.Id;
                txtDescripcionCat.Text = categoria.Descripcion;
                nudCuotaBase.Value = Math.Min(categoria.CuotaBase, nudCuotaBase.Maximum);
            }
            catch (Exception ex)
            {
                MostrarError(ex);
            }
        }

        private Actividad LeerActividad()
        {
            return new Actividad
            {
                Id = _idActividadSeleccionada,
                Nombre = txtNombreAct.Text,
                Arancel = nudArancel.Value,
                Cupo = (int)nudCupo.Value
            };
        }

        private void LimpiarActividad()
        {
            _idActividadSeleccionada = 0;
            txtNombreAct.Clear();
            nudArancel.Value = 0;
            nudCupo.Value = 10;
            dgvActividades.ClearSelection();
            txtNombreAct.Focus();
        }

        private void btnActAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                var actividad = LeerActividad();
                actividad.Id = 0;
                _actividadBll.Insertar(actividad);
                MessageBox.Show("Actividad registrada.", "Club", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarActividades();
                CargarInscriptos();
                LimpiarActividad();
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

        private void btnActModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (_idActividadSeleccionada == 0)
                    throw new ReglaNegocioException("Elegí una actividad de la grilla.");
                _actividadBll.Modificar(LeerActividad());
                MessageBox.Show("Actividad modificada.", "Club", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarActividades();
                CargarInscriptos();
                LimpiarActividad();
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

        private void btnActEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (_idActividadSeleccionada == 0)
                    throw new ReglaNegocioException("Elegí una actividad de la grilla.");
                if (MessageBox.Show("¿Eliminar la actividad seleccionada?", "Club", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;
                _actividadBll.Eliminar(_idActividadSeleccionada);
                MessageBox.Show("Actividad eliminada.", "Club", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarActividades();
                CargarInscriptos();
                LimpiarActividad();
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

        private void btnActLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarActividad();
        }

        private void dgvActividades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0) return;
                if (dgvActividades.Rows[e.RowIndex].DataBoundItem is not Actividad actividad) return;
                _idActividadSeleccionada = actividad.Id;
                txtNombreAct.Text = actividad.Nombre;
                nudArancel.Value = Math.Min(actividad.Arancel, nudArancel.Maximum);
                nudCupo.Value = Math.Min(actividad.Cupo, nudCupo.Maximum);
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

        private void btnDesinscribir_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvInscriptos.CurrentRow == null || dgvInscriptos.CurrentRow.DataBoundItem is not InscripcionDTO inscripcion)
                    throw new ReglaNegocioException("Elegí una inscripción de la grilla.");
                if (MessageBox.Show("¿Dar de baja a " + inscripcion.Socio + " de " + inscripcion.Actividad + "?", "Club", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;
                _inscripcionBll.Desinscribir(inscripcion.IdSocio, inscripcion.IdActividad);
                MessageBox.Show("Inscripción dada de baja.", "Club", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
