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
            lblBuscar = new Label();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
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
            tabCategorias = new TabPage();
            dgvCategorias = new DataGridView();
            grpCategoria = new GroupBox();
            lblDescripcionCat = new Label();
            txtDescripcionCat = new TextBox();
            lblCuotaBase = new Label();
            nudCuotaBase = new NumericUpDown();
            btnCatAgregar = new Button();
            btnCatModificar = new Button();
            btnCatEliminar = new Button();
            btnCatLimpiar = new Button();
            tabActividades = new TabPage();
            dgvActividades = new DataGridView();
            grpActividad = new GroupBox();
            lblNombreAct = new Label();
            txtNombreAct = new TextBox();
            lblArancel = new Label();
            nudArancel = new NumericUpDown();
            lblCupo = new Label();
            nudCupo = new NumericUpDown();
            btnActAgregar = new Button();
            btnActModificar = new Button();
            btnActEliminar = new Button();
            btnActLimpiar = new Button();
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
            btnDesinscribir = new Button();
            tabControl.SuspendLayout();
            tabSocios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSocios).BeginInit();
            grpSocio.SuspendLayout();
            tabCategorias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            grpCategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCuotaBase).BeginInit();
            tabActividades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvActividades).BeginInit();
            grpActividad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudArancel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCupo).BeginInit();
            tabInscripciones.SuspendLayout();
            grpInscribir.SuspendLayout();
            grpInscriptos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInscriptos).BeginInit();
            SuspendLayout();
            //
            // tabControl
            //
            tabControl.Controls.Add(tabSocios);
            tabControl.Controls.Add(tabCategorias);
            tabControl.Controls.Add(tabActividades);
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
            tabSocios.Controls.Add(lblBuscar);
            tabSocios.Controls.Add(txtBuscar);
            tabSocios.Controls.Add(btnBuscar);
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
            // lblBuscar
            //
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(6, 186);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(190, 15);
            lblBuscar.TabIndex = 1;
            lblBuscar.Text = "Buscar por apellido, nombre o DNI";
            //
            // txtBuscar
            //
            txtBuscar.Location = new Point(202, 182);
            txtBuscar.MaxLength = 50;
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(260, 23);
            txtBuscar.TabIndex = 2;
            txtBuscar.KeyDown += txtBuscar_KeyDown;
            //
            // btnBuscar
            //
            btnBuscar.Location = new Point(468, 180);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(100, 27);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            //
            // dgvSocios
            //
            dgvSocios.AllowUserToAddRows = false;
            dgvSocios.AllowUserToDeleteRows = false;
            dgvSocios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSocios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSocios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSocios.Location = new Point(6, 214);
            dgvSocios.MultiSelect = false;
            dgvSocios.Name = "dgvSocios";
            dgvSocios.ReadOnly = true;
            dgvSocios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSocios.Size = new Size(964, 363);
            dgvSocios.TabIndex = 4;
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
            txtNombre.MaxLength = 50;
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
            txtApellido.MaxLength = 50;
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
            txtEmail.MaxLength = 100;
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
            txtTelefono.MaxLength = 20;
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
            // tabCategorias
            //
            tabCategorias.Controls.Add(dgvCategorias);
            tabCategorias.Controls.Add(grpCategoria);
            tabCategorias.Location = new Point(4, 24);
            tabCategorias.Name = "tabCategorias";
            tabCategorias.Padding = new Padding(3);
            tabCategorias.Size = new Size(976, 583);
            tabCategorias.TabIndex = 1;
            tabCategorias.Text = "Categorías";
            tabCategorias.UseVisualStyleBackColor = true;
            //
            // dgvCategorias
            //
            dgvCategorias.AllowUserToAddRows = false;
            dgvCategorias.AllowUserToDeleteRows = false;
            dgvCategorias.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategorias.Location = new Point(6, 130);
            dgvCategorias.MultiSelect = false;
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.ReadOnly = true;
            dgvCategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategorias.Size = new Size(964, 447);
            dgvCategorias.TabIndex = 1;
            dgvCategorias.CellClick += dgvCategorias_CellClick;
            //
            // grpCategoria
            //
            grpCategoria.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpCategoria.Controls.Add(lblDescripcionCat);
            grpCategoria.Controls.Add(txtDescripcionCat);
            grpCategoria.Controls.Add(lblCuotaBase);
            grpCategoria.Controls.Add(nudCuotaBase);
            grpCategoria.Controls.Add(btnCatAgregar);
            grpCategoria.Controls.Add(btnCatModificar);
            grpCategoria.Controls.Add(btnCatEliminar);
            grpCategoria.Controls.Add(btnCatLimpiar);
            grpCategoria.Location = new Point(6, 6);
            grpCategoria.Name = "grpCategoria";
            grpCategoria.Size = new Size(964, 118);
            grpCategoria.TabIndex = 0;
            grpCategoria.TabStop = false;
            grpCategoria.Text = "Datos de la categoría";
            //
            // lblDescripcionCat
            //
            lblDescripcionCat.AutoSize = true;
            lblDescripcionCat.Location = new Point(16, 28);
            lblDescripcionCat.Name = "lblDescripcionCat";
            lblDescripcionCat.Size = new Size(69, 15);
            lblDescripcionCat.TabIndex = 0;
            lblDescripcionCat.Text = "Descripción";
            //
            // txtDescripcionCat
            //
            txtDescripcionCat.Location = new Point(16, 46);
            txtDescripcionCat.MaxLength = 50;
            txtDescripcionCat.Name = "txtDescripcionCat";
            txtDescripcionCat.Size = new Size(300, 23);
            txtDescripcionCat.TabIndex = 1;
            //
            // lblCuotaBase
            //
            lblCuotaBase.AutoSize = true;
            lblCuotaBase.Location = new Point(332, 28);
            lblCuotaBase.Name = "lblCuotaBase";
            lblCuotaBase.Size = new Size(110, 15);
            lblCuotaBase.TabIndex = 2;
            lblCuotaBase.Text = "Cuota base mensual";
            //
            // nudCuotaBase
            //
            nudCuotaBase.DecimalPlaces = 2;
            nudCuotaBase.Increment = new decimal(new int[] { 500, 0, 0, 0 });
            nudCuotaBase.Location = new Point(332, 46);
            nudCuotaBase.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            nudCuotaBase.Name = "nudCuotaBase";
            nudCuotaBase.Size = new Size(140, 23);
            nudCuotaBase.TabIndex = 3;
            nudCuotaBase.ThousandsSeparator = true;
            nudCuotaBase.TextAlign = HorizontalAlignment.Right;
            //
            // btnCatAgregar
            //
            btnCatAgregar.Location = new Point(16, 82);
            btnCatAgregar.Name = "btnCatAgregar";
            btnCatAgregar.Size = new Size(100, 27);
            btnCatAgregar.TabIndex = 4;
            btnCatAgregar.Text = "Agregar";
            btnCatAgregar.UseVisualStyleBackColor = true;
            btnCatAgregar.Click += btnCatAgregar_Click;
            //
            // btnCatModificar
            //
            btnCatModificar.Location = new Point(122, 82);
            btnCatModificar.Name = "btnCatModificar";
            btnCatModificar.Size = new Size(100, 27);
            btnCatModificar.TabIndex = 5;
            btnCatModificar.Text = "Modificar";
            btnCatModificar.UseVisualStyleBackColor = true;
            btnCatModificar.Click += btnCatModificar_Click;
            //
            // btnCatEliminar
            //
            btnCatEliminar.Location = new Point(228, 82);
            btnCatEliminar.Name = "btnCatEliminar";
            btnCatEliminar.Size = new Size(100, 27);
            btnCatEliminar.TabIndex = 6;
            btnCatEliminar.Text = "Eliminar";
            btnCatEliminar.UseVisualStyleBackColor = true;
            btnCatEliminar.Click += btnCatEliminar_Click;
            //
            // btnCatLimpiar
            //
            btnCatLimpiar.Location = new Point(334, 82);
            btnCatLimpiar.Name = "btnCatLimpiar";
            btnCatLimpiar.Size = new Size(100, 27);
            btnCatLimpiar.TabIndex = 7;
            btnCatLimpiar.Text = "Limpiar";
            btnCatLimpiar.UseVisualStyleBackColor = true;
            btnCatLimpiar.Click += btnCatLimpiar_Click;
            //
            // tabActividades
            //
            tabActividades.Controls.Add(dgvActividades);
            tabActividades.Controls.Add(grpActividad);
            tabActividades.Location = new Point(4, 24);
            tabActividades.Name = "tabActividades";
            tabActividades.Padding = new Padding(3);
            tabActividades.Size = new Size(976, 583);
            tabActividades.TabIndex = 2;
            tabActividades.Text = "Actividades";
            tabActividades.UseVisualStyleBackColor = true;
            //
            // dgvActividades
            //
            dgvActividades.AllowUserToAddRows = false;
            dgvActividades.AllowUserToDeleteRows = false;
            dgvActividades.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvActividades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvActividades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvActividades.Location = new Point(6, 130);
            dgvActividades.MultiSelect = false;
            dgvActividades.Name = "dgvActividades";
            dgvActividades.ReadOnly = true;
            dgvActividades.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvActividades.Size = new Size(964, 447);
            dgvActividades.TabIndex = 1;
            dgvActividades.CellClick += dgvActividades_CellClick;
            //
            // grpActividad
            //
            grpActividad.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpActividad.Controls.Add(lblNombreAct);
            grpActividad.Controls.Add(txtNombreAct);
            grpActividad.Controls.Add(lblArancel);
            grpActividad.Controls.Add(nudArancel);
            grpActividad.Controls.Add(lblCupo);
            grpActividad.Controls.Add(nudCupo);
            grpActividad.Controls.Add(btnActAgregar);
            grpActividad.Controls.Add(btnActModificar);
            grpActividad.Controls.Add(btnActEliminar);
            grpActividad.Controls.Add(btnActLimpiar);
            grpActividad.Location = new Point(6, 6);
            grpActividad.Name = "grpActividad";
            grpActividad.Size = new Size(964, 118);
            grpActividad.TabIndex = 0;
            grpActividad.TabStop = false;
            grpActividad.Text = "Datos de la actividad";
            //
            // lblNombreAct
            //
            lblNombreAct.AutoSize = true;
            lblNombreAct.Location = new Point(16, 28);
            lblNombreAct.Name = "lblNombreAct";
            lblNombreAct.Size = new Size(51, 15);
            lblNombreAct.TabIndex = 0;
            lblNombreAct.Text = "Nombre";
            //
            // txtNombreAct
            //
            txtNombreAct.Location = new Point(16, 46);
            txtNombreAct.MaxLength = 80;
            txtNombreAct.Name = "txtNombreAct";
            txtNombreAct.Size = new Size(300, 23);
            txtNombreAct.TabIndex = 1;
            //
            // lblArancel
            //
            lblArancel.AutoSize = true;
            lblArancel.Location = new Point(332, 28);
            lblArancel.Name = "lblArancel";
            lblArancel.Size = new Size(48, 15);
            lblArancel.TabIndex = 2;
            lblArancel.Text = "Arancel";
            //
            // nudArancel
            //
            nudArancel.DecimalPlaces = 2;
            nudArancel.Increment = new decimal(new int[] { 500, 0, 0, 0 });
            nudArancel.Location = new Point(332, 46);
            nudArancel.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            nudArancel.Name = "nudArancel";
            nudArancel.Size = new Size(140, 23);
            nudArancel.TabIndex = 3;
            nudArancel.ThousandsSeparator = true;
            nudArancel.TextAlign = HorizontalAlignment.Right;
            //
            // lblCupo
            //
            lblCupo.AutoSize = true;
            lblCupo.Location = new Point(488, 28);
            lblCupo.Name = "lblCupo";
            lblCupo.Size = new Size(35, 15);
            lblCupo.TabIndex = 4;
            lblCupo.Text = "Cupo";
            //
            // nudCupo
            //
            nudCupo.Location = new Point(488, 46);
            nudCupo.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            nudCupo.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCupo.Name = "nudCupo";
            nudCupo.Size = new Size(90, 23);
            nudCupo.TabIndex = 5;
            nudCupo.TextAlign = HorizontalAlignment.Right;
            nudCupo.Value = new decimal(new int[] { 10, 0, 0, 0 });
            //
            // btnActAgregar
            //
            btnActAgregar.Location = new Point(16, 82);
            btnActAgregar.Name = "btnActAgregar";
            btnActAgregar.Size = new Size(100, 27);
            btnActAgregar.TabIndex = 6;
            btnActAgregar.Text = "Agregar";
            btnActAgregar.UseVisualStyleBackColor = true;
            btnActAgregar.Click += btnActAgregar_Click;
            //
            // btnActModificar
            //
            btnActModificar.Location = new Point(122, 82);
            btnActModificar.Name = "btnActModificar";
            btnActModificar.Size = new Size(100, 27);
            btnActModificar.TabIndex = 7;
            btnActModificar.Text = "Modificar";
            btnActModificar.UseVisualStyleBackColor = true;
            btnActModificar.Click += btnActModificar_Click;
            //
            // btnActEliminar
            //
            btnActEliminar.Location = new Point(228, 82);
            btnActEliminar.Name = "btnActEliminar";
            btnActEliminar.Size = new Size(100, 27);
            btnActEliminar.TabIndex = 8;
            btnActEliminar.Text = "Eliminar";
            btnActEliminar.UseVisualStyleBackColor = true;
            btnActEliminar.Click += btnActEliminar_Click;
            //
            // btnActLimpiar
            //
            btnActLimpiar.Location = new Point(334, 82);
            btnActLimpiar.Name = "btnActLimpiar";
            btnActLimpiar.Size = new Size(100, 27);
            btnActLimpiar.TabIndex = 9;
            btnActLimpiar.Text = "Limpiar";
            btnActLimpiar.UseVisualStyleBackColor = true;
            btnActLimpiar.Click += btnActLimpiar_Click;
            //
            // tabInscripciones
            //
            tabInscripciones.Controls.Add(grpInscriptos);
            tabInscripciones.Controls.Add(grpInscribir);
            tabInscripciones.Location = new Point(4, 24);
            tabInscripciones.Name = "tabInscripciones";
            tabInscripciones.Padding = new Padding(3);
            tabInscripciones.Size = new Size(976, 583);
            tabInscripciones.TabIndex = 3;
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
            grpInscriptos.Controls.Add(btnDesinscribir);
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
            dgvInscriptos.Size = new Size(606, 440);
            dgvInscriptos.TabIndex = 3;
            //
            // btnDesinscribir
            //
            btnDesinscribir.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDesinscribir.Location = new Point(16, 532);
            btnDesinscribir.Name = "btnDesinscribir";
            btnDesinscribir.Size = new Size(180, 27);
            btnDesinscribir.TabIndex = 4;
            btnDesinscribir.Text = "Dar de baja la inscripción";
            btnDesinscribir.UseVisualStyleBackColor = true;
            btnDesinscribir.Click += btnDesinscribir_Click;
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
            tabSocios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSocios).EndInit();
            grpSocio.ResumeLayout(false);
            grpSocio.PerformLayout();
            tabCategorias.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
            grpCategoria.ResumeLayout(false);
            grpCategoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCuotaBase).EndInit();
            tabActividades.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvActividades).EndInit();
            grpActividad.ResumeLayout(false);
            grpActividad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudArancel).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCupo).EndInit();
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
        private Label lblBuscar;
        private TextBox txtBuscar;
        private Button btnBuscar;
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
        private TabPage tabCategorias;
        private DataGridView dgvCategorias;
        private GroupBox grpCategoria;
        private Label lblDescripcionCat;
        private TextBox txtDescripcionCat;
        private Label lblCuotaBase;
        private NumericUpDown nudCuotaBase;
        private Button btnCatAgregar;
        private Button btnCatModificar;
        private Button btnCatEliminar;
        private Button btnCatLimpiar;
        private TabPage tabActividades;
        private DataGridView dgvActividades;
        private GroupBox grpActividad;
        private Label lblNombreAct;
        private TextBox txtNombreAct;
        private Label lblArancel;
        private NumericUpDown nudArancel;
        private Label lblCupo;
        private NumericUpDown nudCupo;
        private Button btnActAgregar;
        private Button btnActModificar;
        private Button btnActEliminar;
        private Button btnActLimpiar;
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
        private Button btnDesinscribir;
    }
}
