namespace ClubGestion
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            tabControl = new TabControl();
            tabSocios = new TabPage();
            dgvSocios = new DataGridView();
            grpSocio = new GroupBox();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblApellido = new Label();
            txtApellido = new TextBox();
            lblDni = new Label();
            txtDni = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblTelefono = new Label();
            txtTelefono = new TextBox();
            lblCategoria = new Label();
            cboCategoria = new ComboBox();
            chkActivo = new CheckBox();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            tabInscripciones = new TabPage();
            grpInscribir = new GroupBox();
            lblSocio = new Label();
            cboSocio = new ComboBox();
            lblActividades = new Label();
            clbActividades = new CheckedListBox();
            btnInscribir = new Button();
            grpInscriptos = new GroupBox();
            lblActividadVer = new Label();
            cboActividadVer = new ComboBox();
            lblCupos = new Label();
            dgvInscriptos = new DataGridView();
            tabControl.SuspendLayout();
            tabSocios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSocios).BeginInit();
            grpSocio.SuspendLayout();
            tabInscripciones.SuspendLayout();
            grpInscribir.SuspendLayout();
            grpInscriptos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInscriptos).BeginInit();
            SuspendLayout();
            //
            // tabControl
            //
            tabControl.Controls.Add(tabSocios);
            tabControl.Controls.Add(tabInscripciones);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(984, 611);
            tabControl.TabIndex = 0;
            //
            // tabSocios
            //
            tabSocios.Controls.Add(dgvSocios);
            tabSocios.Controls.Add(grpSocio);
            tabSocios.Location = new Point(4, 24);
            tabSocios.Name = "tabSocios";
            tabSocios.Padding = new Padding(3);
            tabSocios.Size = new Size(976, 583);
            tabSocios.TabIndex = 0;
            tabSocios.Text = "Socios";
            tabSocios.UseVisualStyleBackColor = true;
            //
            // dgvSocios
            //
            dgvSocios.AllowUserToAddRows = false;
            dgvSocios.AllowUserToDeleteRows = false;
            dgvSocios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSocios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSocios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSocios.Location = new Point(6, 180);
            dgvSocios.MultiSelect = false;
            dgvSocios.Name = "dgvSocios";
            dgvSocios.ReadOnly = true;
            dgvSocios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSocios.Size = new Size(964, 397);
            dgvSocios.TabIndex = 1;
            dgvSocios.CellClick += dgvSocios_CellClick;
            //
            // grpSocio
            //
            grpSocio.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpSocio.Controls.Add(lblNombre);
            grpSocio.Controls.Add(txtNombre);
            grpSocio.Controls.Add(lblApellido);
            grpSocio.Controls.Add(txtApellido);
            grpSocio.Controls.Add(lblDni);
            grpSocio.Controls.Add(txtDni);
            grpSocio.Controls.Add(lblEmail);
            grpSocio.Controls.Add(txtEmail);
            grpSocio.Controls.Add(lblTelefono);
            grpSocio.Controls.Add(txtTelefono);
            grpSocio.Controls.Add(lblCategoria);
            grpSocio.Controls.Add(cboCategoria);
            grpSocio.Controls.Add(chkActivo);
            grpSocio.Controls.Add(btnAgregar);
            grpSocio.Controls.Add(btnModificar);
            grpSocio.Controls.Add(btnEliminar);
            grpSocio.Controls.Add(btnLimpiar);
            grpSocio.Location = new Point(6, 6);
            grpSocio.Name = "grpSocio";
            grpSocio.Size = new Size(964, 168);
            grpSocio.TabIndex = 0;
            grpSocio.TabStop = false;
            grpSocio.Text = "Datos del socio";
            //
            // lblNombre
            //
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(16, 28);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            //
            // txtNombre
            //
            txtNombre.Location = new Point(16, 46);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(200, 23);
            txtNombre.TabIndex = 1;
            //
            // lblApellido
            //
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(232, 28);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 2;
            lblApellido.Text = "Apellido";
            //
            // txtApellido
            //
            txtApellido.Location = new Point(232, 46);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(200, 23);
            txtApellido.TabIndex = 3;
            //
            // lblDni
            //
            lblDni.AutoSize = true;
            lblDni.Location = new Point(448, 28);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(27, 15);
            lblDni.TabIndex = 4;
            lblDni.Text = "DNI";
            //
            // txtDni
            //
            txtDni.Location = new Point(448, 46);
            txtDni.MaxLength = 8;
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(120, 23);
            txtDni.TabIndex = 5;
            //
            // lblEmail
            //
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(16, 80);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email";
            //
            // txtEmail
            //
            txtEmail.Location = new Point(16, 98);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(260, 23);
            txtEmail.TabIndex = 7;
            //
            // lblTelefono
            //
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(292, 80);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(52, 15);
            lblTelefono.TabIndex = 8;
            lblTelefono.Text = "Teléfono";
            //
            // txtTelefono
            //
            txtTelefono.Location = new Point(292, 98);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(140, 23);
            txtTelefono.TabIndex = 9;
            //
            // lblCategoria
            //
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(448, 80);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(58, 15);
            lblCategoria.TabIndex = 10;
            lblCategoria.Text = "Categoría";
            //
            // cboCategoria
            //
            cboCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategoria.FormattingEnabled = true;
            cboCategoria.Location = new Point(448, 98);
            cboCategoria.Name = "cboCategoria";
            cboCategoria.Size = new Size(160, 23);
            cboCategoria.TabIndex = 11;
            //
            // chkActivo
            //
            chkActivo.AutoSize = true;
            chkActivo.Checked = true;
            chkActivo.CheckState = CheckState.Checked;
            chkActivo.Location = new Point(624, 100);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(60, 19);
            chkActivo.TabIndex = 12;
            chkActivo.Text = "Activo";
            chkActivo.UseVisualStyleBackColor = true;
            //
            // btnAgregar
            //
            btnAgregar.Location = new Point(16, 132);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(100, 27);
            btnAgregar.TabIndex = 13;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            //
            // btnModificar
            //
            btnModificar.Location = new Point(122, 132);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(100, 27);
            btnModificar.TabIndex = 14;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            //
            // btnEliminar
            //
            btnEliminar.Location = new Point(228, 132);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(100, 27);
            btnEliminar.TabIndex = 15;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            //
            // btnLimpiar
            //
            btnLimpiar.Location = new Point(334, 132);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(100, 27);
            btnLimpiar.TabIndex = 16;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            //
            // tabInscripciones
            //
            tabInscripciones.Controls.Add(grpInscriptos);
            tabInscripciones.Controls.Add(grpInscribir);
            tabInscripciones.Location = new Point(4, 24);
            tabInscripciones.Name = "tabInscripciones";
            tabInscripciones.Padding = new Padding(3);
            tabInscripciones.Size = new Size(976, 583);
            tabInscripciones.TabIndex = 1;
            tabInscripciones.Text = "Inscripciones";
            tabInscripciones.UseVisualStyleBackColor = true;
            //
            // grpInscribir
            //
            grpInscribir.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            grpInscribir.Controls.Add(lblSocio);
            grpInscribir.Controls.Add(cboSocio);
            grpInscribir.Controls.Add(lblActividades);
            grpInscribir.Controls.Add(clbActividades);
            grpInscribir.Controls.Add(btnInscribir);
            grpInscribir.Location = new Point(6, 6);
            grpInscribir.Name = "grpInscribir";
            grpInscribir.Size = new Size(320, 571);
            grpInscribir.TabIndex = 0;
            grpInscribir.TabStop = false;
            grpInscribir.Text = "Inscribir a actividades";
            //
            // lblSocio
            //
            lblSocio.AutoSize = true;
            lblSocio.Location = new Point(16, 28);
            lblSocio.Name = "lblSocio";
            lblSocio.Size = new Size(36, 15);
            lblSocio.TabIndex = 0;
            lblSocio.Text = "Socio";
            //
            // cboSocio
            //
            cboSocio.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSocio.FormattingEnabled = true;
            cboSocio.Location = new Point(16, 46);
            cboSocio.Name = "cboSocio";
            cboSocio.Size = new Size(288, 23);
            cboSocio.TabIndex = 1;
            //
            // lblActividades
            //
            lblActividades.AutoSize = true;
            lblActividades.Location = new Point(16, 84);
            lblActividades.Name = "lblActividades";
            lblActividades.Size = new Size(68, 15);
            lblActividades.TabIndex = 2;
            lblActividades.Text = "Actividades";
            //
            // clbActividades
            //
            clbActividades.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            clbActividades.CheckOnClick = true;
            clbActividades.FormattingEnabled = true;
            clbActividades.Location = new Point(16, 102);
            clbActividades.Name = "clbActividades";
            clbActividades.Size = new Size(288, 418);
            clbActividades.TabIndex = 3;
            //
            // btnInscribir
            //
            btnInscribir.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnInscribir.Location = new Point(16, 532);
            btnInscribir.Name = "btnInscribir";
            btnInscribir.Size = new Size(140, 27);
            btnInscribir.TabIndex = 4;
            btnInscribir.Text = "Inscribir";
            btnInscribir.UseVisualStyleBackColor = true;
            btnInscribir.Click += btnInscribir_Click;
            //
            // grpInscriptos
            //
            grpInscriptos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpInscriptos.Controls.Add(lblActividadVer);
            grpInscriptos.Controls.Add(cboActividadVer);
            grpInscriptos.Controls.Add(lblCupos);
            grpInscriptos.Controls.Add(dgvInscriptos);
            grpInscriptos.Location = new Point(332, 6);
            grpInscriptos.Name = "grpInscriptos";
            grpInscriptos.Size = new Size(638, 571);
            grpInscriptos.TabIndex = 1;
            grpInscriptos.TabStop = false;
            grpInscriptos.Text = "Inscriptos por actividad";
            //
            // lblActividadVer
            //
            lblActividadVer.AutoSize = true;
            lblActividadVer.Location = new Point(16, 28);
            lblActividadVer.Name = "lblActividadVer";
            lblActividadVer.Size = new Size(58, 15);
            lblActividadVer.TabIndex = 0;
            lblActividadVer.Text = "Actividad";
            //
            // cboActividadVer
            //
            cboActividadVer.DropDownStyle = ComboBoxStyle.DropDownList;
            cboActividadVer.FormattingEnabled = true;
            cboActividadVer.Location = new Point(16, 46);
            cboActividadVer.Name = "cboActividadVer";
            cboActividadVer.Size = new Size(260, 23);
            cboActividadVer.TabIndex = 1;
            cboActividadVer.SelectedIndexChanged += cboActividadVer_SelectedIndexChanged;
            //
            // lblCupos
            //
            lblCupos.AutoSize = true;
            lblCupos.Location = new Point(292, 50);
            lblCupos.Name = "lblCupos";
            lblCupos.Size = new Size(74, 15);
            lblCupos.TabIndex = 2;
            lblCupos.Text = "Cupos libres:";
            //
            // dgvInscriptos
            //
            dgvInscriptos.AllowUserToAddRows = false;
            dgvInscriptos.AllowUserToDeleteRows = false;
            dgvInscriptos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvInscriptos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInscriptos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInscriptos.Location = new Point(16, 84);
            dgvInscriptos.MultiSelect = false;
            dgvInscriptos.Name = "dgvInscriptos";
            dgvInscriptos.ReadOnly = true;
            dgvInscriptos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInscriptos.Size = new Size(606, 475);
            dgvInscriptos.TabIndex = 3;
            //
            // Form1
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 611);
            Controls.Add(tabControl);
            MinimumSize = new Size(900, 600);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ClubGestion";
            Load += Form1_Load;
            tabControl.ResumeLayout(false);
            tabSocios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSocios).EndInit();
            grpSocio.ResumeLayout(false);
            grpSocio.PerformLayout();
            tabInscripciones.ResumeLayout(false);
            grpInscribir.ResumeLayout(false);
            grpInscribir.PerformLayout();
            grpInscriptos.ResumeLayout(false);
            grpInscriptos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInscriptos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage tabSocios;
        private DataGridView dgvSocios;
        private GroupBox grpSocio;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblApellido;
        private TextBox txtApellido;
        private Label lblDni;
        private TextBox txtDni;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblTelefono;
        private TextBox txtTelefono;
        private Label lblCategoria;
        private ComboBox cboCategoria;
        private CheckBox chkActivo;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private TabPage tabInscripciones;
        private GroupBox grpInscribir;
        private Label lblSocio;
        private ComboBox cboSocio;
        private Label lblActividades;
        private CheckedListBox clbActividades;
        private Button btnInscribir;
        private GroupBox grpInscriptos;
        private Label lblActividadVer;
        private ComboBox cboActividadVer;
        private Label lblCupos;
        private DataGridView dgvInscriptos;
    }
}
