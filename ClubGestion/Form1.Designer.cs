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
            datosSocioControl1 = new DatosSocioControl();
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
            grpInscriptos = new GroupBox();
            lblActividadVer = new Label();
            cboActividadVer = new ComboBox();
            lblCupos = new Label();
            dgvInscriptos = new DataGridView();
            btnDesinscribir = new Button();
            grpInscribir = new GroupBox();
            lblSocio = new Label();
            cboSocio = new ComboBox();
            lblActividades = new Label();
            clbActividades = new CheckedListBox();
            btnInscribir = new Button();
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
            grpInscriptos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInscriptos).BeginInit();
            grpInscribir.SuspendLayout();
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
            tabControl.Margin = new Padding(6);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1827, 1303);
            tabControl.TabIndex = 0;
            // 
            // tabSocios
            // 
            tabSocios.Controls.Add(lblBuscar);
            tabSocios.Controls.Add(txtBuscar);
            tabSocios.Controls.Add(btnBuscar);
            tabSocios.Controls.Add(dgvSocios);
            tabSocios.Controls.Add(grpSocio);
            tabSocios.Location = new Point(8, 46);
            tabSocios.Margin = new Padding(6);
            tabSocios.Name = "tabSocios";
            tabSocios.Padding = new Padding(6);
            tabSocios.Size = new Size(1811, 1249);
            tabSocios.TabIndex = 0;
            tabSocios.Text = "Socios";
            tabSocios.UseVisualStyleBackColor = true;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(11, 397);
            lblBuscar.Margin = new Padding(6, 0, 6, 0);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(383, 32);
            lblBuscar.TabIndex = 1;
            lblBuscar.Text = "Buscar por apellido, nombre o DNI";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(410, 388);
            txtBuscar.Margin = new Padding(6);
            txtBuscar.MaxLength = 50;
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(479, 39);
            txtBuscar.TabIndex = 2;
            txtBuscar.KeyDown += txtBuscar_KeyDown;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(904, 384);
            btnBuscar.Margin = new Padding(6);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(186, 58);
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
            dgvSocios.Location = new Point(11, 457);
            dgvSocios.Margin = new Padding(6);
            dgvSocios.MultiSelect = false;
            dgvSocios.Name = "dgvSocios";
            dgvSocios.ReadOnly = true;
            dgvSocios.RowHeadersWidth = 82;
            dgvSocios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSocios.Size = new Size(1790, 774);
            dgvSocios.TabIndex = 4;
            dgvSocios.CellClick += dgvSocios_CellClick;
            // 
            // grpSocio
            // 
            grpSocio.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpSocio.Controls.Add(datosSocioControl1);
            grpSocio.Controls.Add(btnAgregar);
            grpSocio.Controls.Add(btnModificar);
            grpSocio.Controls.Add(btnEliminar);
            grpSocio.Controls.Add(btnLimpiar);
            grpSocio.Location = new Point(11, 13);
            grpSocio.Margin = new Padding(6);
            grpSocio.Name = "grpSocio";
            grpSocio.Padding = new Padding(6);
            grpSocio.Size = new Size(1790, 358);
            grpSocio.TabIndex = 0;
            grpSocio.TabStop = false;
            grpSocio.Text = "Datos del socio";
            // 
            // datosSocioControl1
            // 
            datosSocioControl1.Location = new Point(15, 25);
            datosSocioControl1.Name = "datosSocioControl1";
            datosSocioControl1.Size = new Size(1750, 240);
            datosSocioControl1.TabIndex = 17;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(30, 282);
            btnAgregar.Margin = new Padding(6);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(186, 58);
            btnAgregar.TabIndex = 13;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(227, 282);
            btnModificar.Margin = new Padding(6);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(186, 58);
            btnModificar.TabIndex = 14;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(423, 282);
            btnEliminar.Margin = new Padding(6);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(186, 58);
            btnEliminar.TabIndex = 15;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(620, 282);
            btnLimpiar.Margin = new Padding(6);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(186, 58);
            btnLimpiar.TabIndex = 16;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // tabCategorias
            // 
            tabCategorias.Controls.Add(dgvCategorias);
            tabCategorias.Controls.Add(grpCategoria);
            tabCategorias.Location = new Point(8, 46);
            tabCategorias.Margin = new Padding(6);
            tabCategorias.Name = "tabCategorias";
            tabCategorias.Padding = new Padding(6);
            tabCategorias.Size = new Size(1811, 1249);
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
            dgvCategorias.Location = new Point(11, 277);
            dgvCategorias.Margin = new Padding(6);
            dgvCategorias.MultiSelect = false;
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.ReadOnly = true;
            dgvCategorias.RowHeadersWidth = 82;
            dgvCategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategorias.Size = new Size(1790, 954);
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
            grpCategoria.Location = new Point(11, 13);
            grpCategoria.Margin = new Padding(6);
            grpCategoria.Name = "grpCategoria";
            grpCategoria.Padding = new Padding(6);
            grpCategoria.Size = new Size(1790, 252);
            grpCategoria.TabIndex = 0;
            grpCategoria.TabStop = false;
            grpCategoria.Text = "Datos de la categoría";
            // 
            // lblDescripcionCat
            // 
            lblDescripcionCat.AutoSize = true;
            lblDescripcionCat.Location = new Point(30, 60);
            lblDescripcionCat.Margin = new Padding(6, 0, 6, 0);
            lblDescripcionCat.Name = "lblDescripcionCat";
            lblDescripcionCat.Size = new Size(138, 32);
            lblDescripcionCat.TabIndex = 0;
            lblDescripcionCat.Text = "Descripción";
            // 
            // txtDescripcionCat
            // 
            txtDescripcionCat.Location = new Point(30, 98);
            txtDescripcionCat.Margin = new Padding(6);
            txtDescripcionCat.MaxLength = 50;
            txtDescripcionCat.Name = "txtDescripcionCat";
            txtDescripcionCat.Size = new Size(554, 39);
            txtDescripcionCat.TabIndex = 1;
            // 
            // lblCuotaBase
            // 
            lblCuotaBase.AutoSize = true;
            lblCuotaBase.Location = new Point(617, 60);
            lblCuotaBase.Margin = new Padding(6, 0, 6, 0);
            lblCuotaBase.Name = "lblCuotaBase";
            lblCuotaBase.Size = new Size(230, 32);
            lblCuotaBase.TabIndex = 2;
            lblCuotaBase.Text = "Cuota base mensual";
            // 
            // nudCuotaBase
            // 
            nudCuotaBase.DecimalPlaces = 2;
            nudCuotaBase.Increment = new decimal(new int[] { 500, 0, 0, 0 });
            nudCuotaBase.Location = new Point(617, 98);
            nudCuotaBase.Margin = new Padding(6);
            nudCuotaBase.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            nudCuotaBase.Name = "nudCuotaBase";
            nudCuotaBase.Size = new Size(260, 39);
            nudCuotaBase.TabIndex = 3;
            nudCuotaBase.TextAlign = HorizontalAlignment.Right;
            nudCuotaBase.ThousandsSeparator = true;
            // 
            // btnCatAgregar
            // 
            btnCatAgregar.Location = new Point(30, 175);
            btnCatAgregar.Margin = new Padding(6);
            btnCatAgregar.Name = "btnCatAgregar";
            btnCatAgregar.Size = new Size(186, 58);
            btnCatAgregar.TabIndex = 4;
            btnCatAgregar.Text = "Agregar";
            btnCatAgregar.UseVisualStyleBackColor = true;
            btnCatAgregar.Click += btnCatAgregar_Click;
            // 
            // btnCatModificar
            // 
            btnCatModificar.Location = new Point(227, 175);
            btnCatModificar.Margin = new Padding(6);
            btnCatModificar.Name = "btnCatModificar";
            btnCatModificar.Size = new Size(186, 58);
            btnCatModificar.TabIndex = 5;
            btnCatModificar.Text = "Modificar";
            btnCatModificar.UseVisualStyleBackColor = true;
            btnCatModificar.Click += btnCatModificar_Click;
            // 
            // btnCatEliminar
            // 
            btnCatEliminar.Location = new Point(423, 175);
            btnCatEliminar.Margin = new Padding(6);
            btnCatEliminar.Name = "btnCatEliminar";
            btnCatEliminar.Size = new Size(186, 58);
            btnCatEliminar.TabIndex = 6;
            btnCatEliminar.Text = "Eliminar";
            btnCatEliminar.UseVisualStyleBackColor = true;
            btnCatEliminar.Click += btnCatEliminar_Click;
            // 
            // btnCatLimpiar
            // 
            btnCatLimpiar.Location = new Point(620, 175);
            btnCatLimpiar.Margin = new Padding(6);
            btnCatLimpiar.Name = "btnCatLimpiar";
            btnCatLimpiar.Size = new Size(186, 58);
            btnCatLimpiar.TabIndex = 7;
            btnCatLimpiar.Text = "Limpiar";
            btnCatLimpiar.UseVisualStyleBackColor = true;
            btnCatLimpiar.Click += btnCatLimpiar_Click;
            // 
            // tabActividades
            // 
            tabActividades.Controls.Add(dgvActividades);
            tabActividades.Controls.Add(grpActividad);
            tabActividades.Location = new Point(8, 46);
            tabActividades.Margin = new Padding(6);
            tabActividades.Name = "tabActividades";
            tabActividades.Padding = new Padding(6);
            tabActividades.Size = new Size(1811, 1249);
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
            dgvActividades.Location = new Point(11, 277);
            dgvActividades.Margin = new Padding(6);
            dgvActividades.MultiSelect = false;
            dgvActividades.Name = "dgvActividades";
            dgvActividades.ReadOnly = true;
            dgvActividades.RowHeadersWidth = 82;
            dgvActividades.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvActividades.Size = new Size(1790, 954);
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
            grpActividad.Location = new Point(11, 13);
            grpActividad.Margin = new Padding(6);
            grpActividad.Name = "grpActividad";
            grpActividad.Padding = new Padding(6);
            grpActividad.Size = new Size(1790, 252);
            grpActividad.TabIndex = 0;
            grpActividad.TabStop = false;
            grpActividad.Text = "Datos de la actividad";
            // 
            // lblNombreAct
            // 
            lblNombreAct.AutoSize = true;
            lblNombreAct.Location = new Point(30, 60);
            lblNombreAct.Margin = new Padding(6, 0, 6, 0);
            lblNombreAct.Name = "lblNombreAct";
            lblNombreAct.Size = new Size(102, 32);
            lblNombreAct.TabIndex = 0;
            lblNombreAct.Text = "Nombre";
            // 
            // txtNombreAct
            // 
            txtNombreAct.Location = new Point(30, 98);
            txtNombreAct.Margin = new Padding(6);
            txtNombreAct.MaxLength = 80;
            txtNombreAct.Name = "txtNombreAct";
            txtNombreAct.Size = new Size(554, 39);
            txtNombreAct.TabIndex = 1;
            // 
            // lblArancel
            // 
            lblArancel.AutoSize = true;
            lblArancel.Location = new Point(617, 60);
            lblArancel.Margin = new Padding(6, 0, 6, 0);
            lblArancel.Name = "lblArancel";
            lblArancel.Size = new Size(93, 32);
            lblArancel.TabIndex = 2;
            lblArancel.Text = "Arancel";
            // 
            // nudArancel
            // 
            nudArancel.DecimalPlaces = 2;
            nudArancel.Increment = new decimal(new int[] { 500, 0, 0, 0 });
            nudArancel.Location = new Point(617, 98);
            nudArancel.Margin = new Padding(6);
            nudArancel.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            nudArancel.Name = "nudArancel";
            nudArancel.Size = new Size(260, 39);
            nudArancel.TabIndex = 3;
            nudArancel.TextAlign = HorizontalAlignment.Right;
            nudArancel.ThousandsSeparator = true;
            // 
            // lblCupo
            // 
            lblCupo.AutoSize = true;
            lblCupo.Location = new Point(906, 60);
            lblCupo.Margin = new Padding(6, 0, 6, 0);
            lblCupo.Name = "lblCupo";
            lblCupo.Size = new Size(71, 32);
            lblCupo.TabIndex = 4;
            lblCupo.Text = "Cupo";
            // 
            // nudCupo
            // 
            nudCupo.Location = new Point(906, 98);
            nudCupo.Margin = new Padding(6);
            nudCupo.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            nudCupo.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCupo.Name = "nudCupo";
            nudCupo.Size = new Size(167, 39);
            nudCupo.TabIndex = 5;
            nudCupo.TextAlign = HorizontalAlignment.Right;
            nudCupo.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // btnActAgregar
            // 
            btnActAgregar.Location = new Point(30, 175);
            btnActAgregar.Margin = new Padding(6);
            btnActAgregar.Name = "btnActAgregar";
            btnActAgregar.Size = new Size(186, 58);
            btnActAgregar.TabIndex = 6;
            btnActAgregar.Text = "Agregar";
            btnActAgregar.UseVisualStyleBackColor = true;
            btnActAgregar.Click += btnActAgregar_Click;
            // 
            // btnActModificar
            // 
            btnActModificar.Location = new Point(227, 175);
            btnActModificar.Margin = new Padding(6);
            btnActModificar.Name = "btnActModificar";
            btnActModificar.Size = new Size(186, 58);
            btnActModificar.TabIndex = 7;
            btnActModificar.Text = "Modificar";
            btnActModificar.UseVisualStyleBackColor = true;
            btnActModificar.Click += btnActModificar_Click;
            // 
            // btnActEliminar
            // 
            btnActEliminar.Location = new Point(423, 175);
            btnActEliminar.Margin = new Padding(6);
            btnActEliminar.Name = "btnActEliminar";
            btnActEliminar.Size = new Size(186, 58);
            btnActEliminar.TabIndex = 8;
            btnActEliminar.Text = "Eliminar";
            btnActEliminar.UseVisualStyleBackColor = true;
            btnActEliminar.Click += btnActEliminar_Click;
            // 
            // btnActLimpiar
            // 
            btnActLimpiar.Location = new Point(620, 175);
            btnActLimpiar.Margin = new Padding(6);
            btnActLimpiar.Name = "btnActLimpiar";
            btnActLimpiar.Size = new Size(186, 58);
            btnActLimpiar.TabIndex = 9;
            btnActLimpiar.Text = "Limpiar";
            btnActLimpiar.UseVisualStyleBackColor = true;
            btnActLimpiar.Click += btnActLimpiar_Click;
            // 
            // tabInscripciones
            // 
            tabInscripciones.Controls.Add(grpInscriptos);
            tabInscripciones.Controls.Add(grpInscribir);
            tabInscripciones.Location = new Point(8, 46);
            tabInscripciones.Margin = new Padding(6);
            tabInscripciones.Name = "tabInscripciones";
            tabInscripciones.Padding = new Padding(6);
            tabInscripciones.Size = new Size(1811, 1249);
            tabInscripciones.TabIndex = 3;
            tabInscripciones.Text = "Inscripciones";
            tabInscripciones.UseVisualStyleBackColor = true;
            // 
            // grpInscriptos
            // 
            grpInscriptos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpInscriptos.Controls.Add(lblActividadVer);
            grpInscriptos.Controls.Add(cboActividadVer);
            grpInscriptos.Controls.Add(lblCupos);
            grpInscriptos.Controls.Add(dgvInscriptos);
            grpInscriptos.Controls.Add(btnDesinscribir);
            grpInscriptos.Location = new Point(617, 13);
            grpInscriptos.Margin = new Padding(6);
            grpInscriptos.Name = "grpInscriptos";
            grpInscriptos.Padding = new Padding(6);
            grpInscriptos.Size = new Size(1185, 1218);
            grpInscriptos.TabIndex = 1;
            grpInscriptos.TabStop = false;
            grpInscriptos.Text = "Inscriptos por actividad";
            // 
            // lblActividadVer
            // 
            lblActividadVer.AutoSize = true;
            lblActividadVer.Location = new Point(30, 60);
            lblActividadVer.Margin = new Padding(6, 0, 6, 0);
            lblActividadVer.Name = "lblActividadVer";
            lblActividadVer.Size = new Size(112, 32);
            lblActividadVer.TabIndex = 0;
            lblActividadVer.Text = "Actividad";
            // 
            // cboActividadVer
            // 
            cboActividadVer.DropDownStyle = ComboBoxStyle.DropDownList;
            cboActividadVer.FormattingEnabled = true;
            cboActividadVer.Location = new Point(30, 98);
            cboActividadVer.Margin = new Padding(6);
            cboActividadVer.Name = "cboActividadVer";
            cboActividadVer.Size = new Size(479, 40);
            cboActividadVer.TabIndex = 1;
            cboActividadVer.SelectedIndexChanged += cboActividadVer_SelectedIndexChanged;
            // 
            // lblCupos
            // 
            lblCupos.AutoSize = true;
            lblCupos.Location = new Point(542, 107);
            lblCupos.Margin = new Padding(6, 0, 6, 0);
            lblCupos.Name = "lblCupos";
            lblCupos.Size = new Size(150, 32);
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
            dgvInscriptos.Location = new Point(30, 179);
            dgvInscriptos.Margin = new Padding(6);
            dgvInscriptos.MultiSelect = false;
            dgvInscriptos.Name = "dgvInscriptos";
            dgvInscriptos.ReadOnly = true;
            dgvInscriptos.RowHeadersWidth = 82;
            dgvInscriptos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInscriptos.Size = new Size(1125, 939);
            dgvInscriptos.TabIndex = 3;
            // 
            // btnDesinscribir
            // 
            btnDesinscribir.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDesinscribir.Location = new Point(30, 1135);
            btnDesinscribir.Margin = new Padding(6);
            btnDesinscribir.Name = "btnDesinscribir";
            btnDesinscribir.Size = new Size(334, 58);
            btnDesinscribir.TabIndex = 4;
            btnDesinscribir.Text = "Dar de baja la inscripción";
            btnDesinscribir.UseVisualStyleBackColor = true;
            btnDesinscribir.Click += btnDesinscribir_Click;
            // 
            // grpInscribir
            // 
            grpInscribir.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            grpInscribir.Controls.Add(lblSocio);
            grpInscribir.Controls.Add(cboSocio);
            grpInscribir.Controls.Add(lblActividades);
            grpInscribir.Controls.Add(clbActividades);
            grpInscribir.Controls.Add(btnInscribir);
            grpInscribir.Location = new Point(11, 13);
            grpInscribir.Margin = new Padding(6);
            grpInscribir.Name = "grpInscribir";
            grpInscribir.Padding = new Padding(6);
            grpInscribir.Size = new Size(594, 1218);
            grpInscribir.TabIndex = 0;
            grpInscribir.TabStop = false;
            grpInscribir.Text = "Inscribir a actividades";
            // 
            // lblSocio
            // 
            lblSocio.AutoSize = true;
            lblSocio.Location = new Point(30, 60);
            lblSocio.Margin = new Padding(6, 0, 6, 0);
            lblSocio.Name = "lblSocio";
            lblSocio.Size = new Size(72, 32);
            lblSocio.TabIndex = 0;
            lblSocio.Text = "Socio";
            // 
            // cboSocio
            // 
            cboSocio.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSocio.FormattingEnabled = true;
            cboSocio.Location = new Point(30, 98);
            cboSocio.Margin = new Padding(6);
            cboSocio.Name = "cboSocio";
            cboSocio.Size = new Size(531, 40);
            cboSocio.TabIndex = 1;
            // 
            // lblActividades
            // 
            lblActividades.AutoSize = true;
            lblActividades.Location = new Point(30, 179);
            lblActividades.Margin = new Padding(6, 0, 6, 0);
            lblActividades.Name = "lblActividades";
            lblActividades.Size = new Size(135, 32);
            lblActividades.TabIndex = 2;
            lblActividades.Text = "Actividades";
            // 
            // clbActividades
            // 
            clbActividades.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            clbActividades.CheckOnClick = true;
            clbActividades.FormattingEnabled = true;
            clbActividades.Location = new Point(30, 218);
            clbActividades.Margin = new Padding(6);
            clbActividades.Name = "clbActividades";
            clbActividades.Size = new Size(531, 868);
            clbActividades.TabIndex = 3;
            // 
            // btnInscribir
            // 
            btnInscribir.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnInscribir.Location = new Point(30, 1135);
            btnInscribir.Margin = new Padding(6);
            btnInscribir.Name = "btnInscribir";
            btnInscribir.Size = new Size(260, 58);
            btnInscribir.TabIndex = 4;
            btnInscribir.Text = "Inscribir";
            btnInscribir.UseVisualStyleBackColor = true;
            btnInscribir.Click += btnInscribir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1827, 1303);
            Controls.Add(tabControl);
            Margin = new Padding(6);
            MinimumSize = new Size(1649, 1200);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ClubGestion";
            Load += Form1_Load;
            tabControl.ResumeLayout(false);
            tabSocios.ResumeLayout(false);
            tabSocios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSocios).EndInit();
            grpSocio.ResumeLayout(false);
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
        private Label lblBuscar;
        private TextBox txtBuscar;
        private Button btnBuscar;
        private DataGridView dgvSocios;
        private GroupBox grpSocio;
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
        private DatosSocioControl datosSocioControl1;
        private Button btnAgregar;
    }
}
