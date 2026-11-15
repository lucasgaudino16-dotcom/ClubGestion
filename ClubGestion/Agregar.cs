using System;
using BLL;
using Entity;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubGestion
{
    public partial class Agregar : Form
    {
        private int _idActividad = 0;
        public Agregar()
        {
            InitializeComponent();
        }

        public Agregar(Actividad actividad) : this()
        {
            _idActividad = actividad.Id;

            txtNombre.Text = actividad.Nombre;
            txtArancel.Text = actividad.Arancel.ToString();
            nudCupo.Value = actividad.Cupo;

            this.Text = "Modificar actividad";
            btnGuardar.Text = "Guardar cambios";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!decimal.TryParse(txtArancel.Text, out decimal arancel))
                {
                    MessageBox.Show("Ingrese un arancel válido.");
                    return;
                }

                Actividad actividad = new Actividad
                {
                    Id = _idActividad,
                    Nombre = txtNombre.Text.Trim(),
                    Arancel = arancel,
                    Cupo = (int)nudCupo.Value
                };

                ActividadBLL actividadBLL = new ActividadBLL();

                if (_idActividad == 0)
                {
                    actividadBLL.Insertar(actividad);

                    MessageBox.Show(
                        "Actividad registrada correctamente.",
                        "ClubGestion",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    actividadBLL.Modificar(actividad);

                    MessageBox.Show(
                        "Actividad modificada correctamente.",
                        "ClubGestion",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
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
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
