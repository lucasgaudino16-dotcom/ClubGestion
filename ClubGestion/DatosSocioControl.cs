using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;

namespace ClubGestion
{
    public partial class DatosSocioControl : UserControl
    {
        public DatosSocioControl()
        {
            InitializeComponent();
        }

        public Socio ObtenerDatos()
        {
            return new Socio
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Dni = txtDni.Text,
                Email = txtEmail.Text,
                Telefono = txtTelefono.Text,
                Activo = chkActivo.Checked,
                Categoria = cboCategoria.SelectedItem as Categoria ?? new Categoria()
            };
        }

        public void CargarDatos(Socio socio)
        {
            if (socio == null)
                return;

            txtNombre.Text = socio.Nombre;
            txtApellido.Text = socio.Apellido;
            txtDni.Text = socio.Dni;
            txtEmail.Text = socio.Email;
            txtTelefono.Text = socio.Telefono;
            chkActivo.Checked = socio.Activo;

            if (socio.Categoria != null)
                cboCategoria.SelectedValue = socio.Categoria.Id;
        }

        public void Limpiar()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtDni.Clear();
            txtEmail.Clear();
            txtTelefono.Clear();

            if (cboCategoria.Items.Count > 0)
                cboCategoria.SelectedIndex = 0;

            chkActivo.Checked = true;
            txtNombre.Focus();
        }

        public void CargarCategorias(List<Categoria> categorias)
        {
            int idSeleccionado = cboCategoria.SelectedItem is Categoria c ? c.Id : 0;
            
            cboCategoria.DataSource = null;
            cboCategoria.DataSource = categorias.ToList();
            cboCategoria.DisplayMember = "Descripcion";
            cboCategoria.ValueMember = "Id";

            if (idSeleccionado > 0 && categorias.Any(x => x.Id == idSeleccionado))
                cboCategoria.SelectedValue = idSeleccionado;
        }



    }
}
