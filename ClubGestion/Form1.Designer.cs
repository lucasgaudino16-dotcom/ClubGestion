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
            label1 = new Label();
            btnBuscar = new Button();
            txtBuscar = new TextBox();
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
            cboModificarActividad = new ComboBox();
            btnModificarActividad = new Button();
            grpInscriptos = new GroupBox();
            lblActividadVer = new Label();
            cboActividadVer = new ComboBox();
            lblCupos = new Label();
            dgvInscriptos = new DataGridView();
            btnNuevaActividad = new Button();
            grpInscribir = new GroupBox();
            lblSocio = new Label();
            cboSocio = new ComboBox();
            lblActividades = new Label();
            clbActividades = new CheckedListBox();
            btnInscribir = new Button();
            btnEliminarActividad = new Button();
            tabControl.SuspendLayout();
            tabSocios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSocios).BeginInit();
            grpSocio.SuspendLayout();
            tabInscripciones.SuspendLayout();
            grpInscriptos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInscriptos).BeginInit();
            grpInscribir.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabSocios);
            tabControl.Controls.Add(tabInscripciones);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 0);
            tabControl.Margin = new Padding(3, 4, 3, 4);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1208, 903);
            tabControl.TabIndex = 0;
            // 
            // tabSocios
            // 
            tabSocios.Controls.Add(label1);
            tabSocios.Controls.Add(btnBuscar);
            tabSocios.Controls.Add(txtBuscar);
            tabSocios.Controls.Add(dgvSocios);
            tabSocios.Controls.Add(grpSocio);
            tabSocios.Location = new Point(4, 29);
            tabSocios.Margin = new Padding(3, 4, 3, 4);
            tabSocios.Name = "tabSocios";
            tabSocios.Padding = new Padding(3, 4, 3, 4);
            tabSocios.Size = new Size(1200, 870);
            tabSocios.TabIndex = 0;
            tabSocios.Text = "Socios";
            tabSocios.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 253);
            label1.Name = "label1";
            label1.Size = new Size(141, 20);
            label1.TabIndex = 17;
            label1.Text = "Buscar por apellido:";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(165, 276);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(114, 27);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(18, 276);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(125, 27);
            txtBuscar.TabIndex = 2;
            // 
            // dgvSocios
            // 
            dgvSocios.AllowUserToAddRows = false;
            dgvSocios.AllowUserToDeleteRows = false;
            dgvSocios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSocios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSocios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSocios.Location = new Point(0, 306);
            dgvSocios.Margin = new Padding(3, 4, 3, 4);
            dgvSocios.MultiSelect = false;
            dgvSocios.Name = "dgvSocios";
            dgvSocios.ReadOnly = true;
            dgvSocios.RowHeadersWidth = 51;
            dgvSocios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSocios.Size = new Size(1157, 551);
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
            grpSocio.Location = new Point(7, 8);
            grpSocio.Margin = new Padding(3, 4, 3, 4);
            grpSocio.Name = "grpSocio";
            grpSocio.Padding = new Padding(3, 4, 3, 4);
            grpSocio.Size = new Size(1157, 224);
            grpSocio.TabIndex = 0;
            grpSocio.TabStop = false;
            grpSocio.Text = "Datos del socio";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(18, 37);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(18, 61);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(228, 27);
            txtNombre.TabIndex = 1;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(265, 37);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(66, 20);
            lblApellido.TabIndex = 2;
            lblApellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(265, 61);
            txtApellido.Margin = new Padding(3, 4, 3, 4);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(228, 27);
            txtApellido.TabIndex = 3;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(512, 37);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(35, 20);
            lblDni.TabIndex = 4;
            lblDni.Text = "DNI";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(512, 61);
            txtDni.Margin = new Padding(3, 4, 3, 4);
            txtDni.MaxLength = 8;
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(137, 27);
            txtDni.TabIndex = 5;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(18, 107);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(18, 131);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(297, 27);
            txtEmail.TabIndex = 7;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(334, 107);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(67, 20);
            lblTelefono.TabIndex = 8;
            lblTelefono.Text = "Teléfono";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(334, 131);
            txtTelefono.Margin = new Padding(3, 4, 3, 4);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(159, 27);
            txtTelefono.TabIndex = 9;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(512, 107);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(74, 20);
            lblCategoria.TabIndex = 10;
            lblCategoria.Text = "Categoría";
            // 
            // cboCategoria
            // 
            cboCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategoria.FormattingEnabled = true;
            cboCategoria.Location = new Point(512, 131);
            cboCategoria.Margin = new Padding(3, 4, 3, 4);
            cboCategoria.Name = "cboCategoria";
            cboCategoria.Size = new Size(182, 28);
            cboCategoria.TabIndex = 11;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Checked = true;
            chkActivo.CheckState = CheckState.Checked;
            chkActivo.Location = new Point(713, 133);
            chkActivo.Margin = new Padding(3, 4, 3, 4);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(73, 24);
            chkActivo.TabIndex = 12;
            chkActivo.Text = "Activo";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(18, 176);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(114, 36);
            btnAgregar.TabIndex = 13;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(139, 176);
            btnModificar.Margin = new Padding(3, 4, 3, 4);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(114, 36);
            btnModificar.TabIndex = 14;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(261, 176);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(114, 36);
            btnEliminar.TabIndex = 15;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(382, 176);
            btnLimpiar.Margin = new Padding(3, 4, 3, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(114, 36);
            btnLimpiar.TabIndex = 16;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // tabInscripciones
            // 
            tabInscripciones.Controls.Add(btnEliminarActividad);
            tabInscripciones.Controls.Add(cboModificarActividad);
            tabInscripciones.Controls.Add(btnModificarActividad);
            tabInscripciones.Controls.Add(grpInscriptos);
            tabInscripciones.Controls.Add(btnNuevaActividad);
            tabInscripciones.Controls.Add(grpInscribir);
            tabInscripciones.Location = new Point(4, 29);
            tabInscripciones.Margin = new Padding(3, 4, 3, 4);
            tabInscripciones.Name = "tabInscripciones";
            tabInscripciones.Padding = new Padding(3, 4, 3, 4);
            tabInscripciones.Size = new Size(1200, 870);
            tabInscripciones.TabIndex = 1;
            tabInscripciones.Text = "Inscripciones";
            tabInscripciones.UseVisualStyleBackColor = true;
            // 
            // cboModificarActividad
            // 
            cboModificarActividad.FormattingEnabled = true;
            cboModificarActividad.Location = new Point(379, 776);
            cboModificarActividad.Name = "cboModificarActividad";
            cboModificarActividad.Size = new Size(151, 28);
            cboModificarActividad.TabIndex = 4;
            // 
            // btnModificarActividad
            // 
            btnModificarActividad.Location = new Point(379, 816);
            btnModificarActividad.Name = "btnModificarActividad";
            btnModificarActividad.Size = new Size(191, 51);
            btnModificarActividad.TabIndex = 20;
            btnModificarActividad.Text = "Modificar actividad";
            btnModificarActividad.UseVisualStyleBackColor = true;
            btnModificarActividad.Click += btnModificarActividad_Click;
            // 
            // grpInscriptos
            // 
            grpInscriptos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpInscriptos.Controls.Add(lblActividadVer);
            grpInscriptos.Controls.Add(cboActividadVer);
            grpInscriptos.Controls.Add(lblCupos);
            grpInscriptos.Controls.Add(dgvInscriptos);
            grpInscriptos.Location = new Point(379, 8);
            grpInscriptos.Margin = new Padding(3, 4, 3, 4);
            grpInscriptos.Name = "grpInscriptos";
            grpInscriptos.Padding = new Padding(3, 4, 3, 4);
            grpInscriptos.Size = new Size(757, 761);
            grpInscriptos.TabIndex = 1;
            grpInscriptos.TabStop = false;
            grpInscriptos.Text = "Inscriptos por actividad";
            // 
            // lblActividadVer
            // 
            lblActividadVer.AutoSize = true;
            lblActividadVer.Location = new Point(18, 37);
            lblActividadVer.Name = "lblActividadVer";
            lblActividadVer.Size = new Size(72, 20);
            lblActividadVer.TabIndex = 0;
            lblActividadVer.Text = "Actividad";
            // 
            // cboActividadVer
            // 
            cboActividadVer.DropDownStyle = ComboBoxStyle.DropDownList;
            cboActividadVer.FormattingEnabled = true;
            cboActividadVer.Location = new Point(18, 61);
            cboActividadVer.Margin = new Padding(3, 4, 3, 4);
            cboActividadVer.Name = "cboActividadVer";
            cboActividadVer.Size = new Size(297, 28);
            cboActividadVer.TabIndex = 1;
            cboActividadVer.SelectedIndexChanged += cboActividadVer_SelectedIndexChanged;
            // 
            // lblCupos
            // 
            lblCupos.AutoSize = true;
            lblCupos.Location = new Point(334, 67);
            lblCupos.Name = "lblCupos";
            lblCupos.Size = new Size(93, 20);
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
            dgvInscriptos.Location = new Point(18, 112);
            dgvInscriptos.Margin = new Padding(3, 4, 3, 4);
            dgvInscriptos.MultiSelect = false;
            dgvInscriptos.Name = "dgvInscriptos";
            dgvInscriptos.ReadOnly = true;
            dgvInscriptos.RowHeadersWidth = 51;
            dgvInscriptos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInscriptos.Size = new Size(721, 633);
            dgvInscriptos.TabIndex = 3;
            // 
            // btnNuevaActividad
            // 
            btnNuevaActividad.Location = new Point(25, 801);
            btnNuevaActividad.Name = "btnNuevaActividad";
            btnNuevaActividad.Size = new Size(191, 51);
            btnNuevaActividad.TabIndex = 19;
            btnNuevaActividad.Text = "Agregar actividad";
            btnNuevaActividad.UseVisualStyleBackColor = true;
            btnNuevaActividad.Click += btnNuevaActividad_Click;
            // 
            // grpInscribir
            // 
            grpInscribir.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            grpInscribir.Controls.Add(lblSocio);
            grpInscribir.Controls.Add(cboSocio);
            grpInscribir.Controls.Add(lblActividades);
            grpInscribir.Controls.Add(clbActividades);
            grpInscribir.Controls.Add(btnInscribir);
            grpInscribir.Location = new Point(7, 8);
            grpInscribir.Margin = new Padding(3, 4, 3, 4);
            grpInscribir.Name = "grpInscribir";
            grpInscribir.Padding = new Padding(3, 4, 3, 4);
            grpInscribir.Size = new Size(366, 761);
            grpInscribir.TabIndex = 0;
            grpInscribir.TabStop = false;
            grpInscribir.Text = "Inscribir a actividades";
            // 
            // lblSocio
            // 
            lblSocio.AutoSize = true;
            lblSocio.Location = new Point(18, 37);
            lblSocio.Name = "lblSocio";
            lblSocio.Size = new Size(46, 20);
            lblSocio.TabIndex = 0;
            lblSocio.Text = "Socio";
            // 
            // cboSocio
            // 
            cboSocio.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSocio.FormattingEnabled = true;
            cboSocio.Location = new Point(18, 61);
            cboSocio.Margin = new Padding(3, 4, 3, 4);
            cboSocio.Name = "cboSocio";
            cboSocio.Size = new Size(329, 28);
            cboSocio.TabIndex = 1;
            // 
            // lblActividades
            // 
            lblActividades.AutoSize = true;
            lblActividades.Location = new Point(18, 112);
            lblActividades.Name = "lblActividades";
            lblActividades.Size = new Size(86, 20);
            lblActividades.TabIndex = 2;
            lblActividades.Text = "Actividades";
            // 
            // clbActividades
            // 
            clbActividades.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            clbActividades.CheckOnClick = true;
            clbActividades.FormattingEnabled = true;
            clbActividades.Location = new Point(18, 136);
            clbActividades.Margin = new Padding(3, 4, 3, 4);
            clbActividades.Name = "clbActividades";
            clbActividades.Size = new Size(329, 554);
            clbActividades.TabIndex = 3;
            // 
            // btnInscribir
            // 
            btnInscribir.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnInscribir.Location = new Point(18, 709);
            btnInscribir.Margin = new Padding(3, 4, 3, 4);
            btnInscribir.Name = "btnInscribir";
            btnInscribir.Size = new Size(160, 36);
            btnInscribir.TabIndex = 4;
            btnInscribir.Text = "Inscribir";
            btnInscribir.UseVisualStyleBackColor = true;
            btnInscribir.Click += btnInscribir_Click;
            // 
            // btnEliminarActividad
            // 
            btnEliminarActividad.Location = new Point(586, 816);
            btnEliminarActividad.Name = "btnEliminarActividad";
            btnEliminarActividad.Size = new Size(191, 51);
            btnEliminarActividad.TabIndex = 21;
            btnEliminarActividad.Text = "Eliminar actividad";
            btnEliminarActividad.UseVisualStyleBackColor = true;
            btnEliminarActividad.Click += btnEliminarActividad_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1208, 903);
            Controls.Add(tabControl);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1026, 784);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ClubGestion";
            Load += Form1_Load;
            tabControl.ResumeLayout(false);
            tabSocios.ResumeLayout(false);
            tabSocios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSocios).EndInit();
            grpSocio.ResumeLayout(false);
            grpSocio.PerformLayout();
            tabInscripciones.ResumeLayout(false);
            grpInscriptos.ResumeLayout(false);
            grpInscriptos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInscriptos).EndInit();
            grpInscribir.ResumeLayout(false);
            grpInscribir.PerformLayout();
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
        private Button btnBuscar;
        private TextBox txtBuscar;
        private Label label1;
        private Button btnModificarActividad;
        private Button btnNuevaActividad;
        private ComboBox cboModificarActividad;
        private Button btnEliminarActividad;
    }
}
