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
            tabReportes = new TabPage();
            groupBox2 = new GroupBox();
            dgvReporteActividades = new DataGridView();
            groupBox1 = new GroupBox();
            lblRecaudacionTotal = new Label();
            lblTotalInscriptos = new Label();
            btnConsultarReporte = new Button();
            label1 = new Label();
            cbFiltroActividad = new ComboBox();
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
            tabReportes.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReporteActividades).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabSocios);
            tabControl.Controls.Add(tabCategorias);
            tabControl.Controls.Add(tabActividades);
            tabControl.Controls.Add(tabInscripciones);
            tabControl.Controls.Add(tabReportes);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(984, 497);
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
            tabSocios.Size = new Size(976, 469);
            tabSocios.TabIndex = 0;
            tabSocios.Text = "Socios";
            tabSocios.UseVisualStyleBackColor = true;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(6, 186);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(189, 15);
            lblBuscar.TabIndex = 1;
            lblBuscar.Text = "Buscar por apellido, nombre o DNI";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(221, 182);
            txtBuscar.MaxLength = 50;
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(260, 23);
            txtBuscar.TabIndex = 2;
            txtBuscar.KeyDown += txtBuscar_KeyDown;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(487, 180);
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
            dgvSocios.RowHeadersWidth = 82;
            dgvSocios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSocios.Size = new Size(964, 249);
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
            grpSocio.Location = new Point(6, 6);
            grpSocio.Name = "grpSocio";
            grpSocio.Size = new Size(964, 168);
            grpSocio.TabIndex = 0;
            grpSocio.TabStop = false;
            grpSocio.Text = "Datos del socio";
            // 
            // datosSocioControl1
            // 
            datosSocioControl1.Location = new Point(8, 12);
            datosSocioControl1.Margin = new Padding(1, 0, 1, 0);
            datosSocioControl1.Name = "datosSocioControl1";
            datosSocioControl1.Size = new Size(942, 112);
            datosSocioControl1.TabIndex = 17;
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
            tabCategorias.Size = new Size(976, 469);
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
            dgvCategorias.RowHeadersWidth = 82;
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
            lblCuotaBase.Size = new Size(114, 15);
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
            nudCuotaBase.TextAlign = HorizontalAlignment.Right;
            nudCuotaBase.ThousandsSeparator = true;
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
            tabActividades.Size = new Size(976, 469);
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
            dgvActividades.RowHeadersWidth = 82;
            dgvActividades.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvActividades.Size = new Size(964, 333);
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
            lblArancel.Size = new Size(47, 15);
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
            nudArancel.TextAlign = HorizontalAlignment.Right;
            nudArancel.ThousandsSeparator = true;
            // 
            // lblCupo
            // 
            lblCupo.AutoSize = true;
            lblCupo.Location = new Point(488, 28);
            lblCupo.Name = "lblCupo";
            lblCupo.Size = new Size(36, 15);
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
            tabInscripciones.Size = new Size(976, 469);
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
            grpInscriptos.Location = new Point(332, 6);
            grpInscriptos.Name = "grpInscriptos";
            grpInscriptos.Size = new Size(638, 457);
            grpInscriptos.TabIndex = 1;
            grpInscriptos.TabStop = false;
            grpInscriptos.Text = "Inscriptos por actividad";
            // 
            // lblActividadVer
            // 
            lblActividadVer.AutoSize = true;
            lblActividadVer.Location = new Point(16, 28);
            lblActividadVer.Name = "lblActividadVer";
            lblActividadVer.Size = new Size(57, 15);
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
            lblCupos.Size = new Size(75, 15);
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
            dgvInscriptos.RowHeadersWidth = 82;
            dgvInscriptos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInscriptos.Size = new Size(606, 326);
            dgvInscriptos.TabIndex = 3;
            // 
            // btnDesinscribir
            // 
            btnDesinscribir.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDesinscribir.Location = new Point(16, 418);
            btnDesinscribir.Name = "btnDesinscribir";
            btnDesinscribir.Size = new Size(180, 27);
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
            grpInscribir.Location = new Point(6, 6);
            grpInscribir.Name = "grpInscribir";
            grpInscribir.Size = new Size(320, 457);
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
            clbActividades.Size = new Size(288, 274);
            clbActividades.TabIndex = 3;
            // 
            // btnInscribir
            // 
            btnInscribir.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnInscribir.Location = new Point(16, 418);
            btnInscribir.Name = "btnInscribir";
            btnInscribir.Size = new Size(140, 27);
            btnInscribir.TabIndex = 4;
            btnInscribir.Text = "Inscribir";
            btnInscribir.UseVisualStyleBackColor = true;
            btnInscribir.Click += btnInscribir_Click;
            // 
            // tabReportes
            // 
            tabReportes.Controls.Add(groupBox2);
            tabReportes.Controls.Add(groupBox1);
            tabReportes.Location = new Point(4, 24);
            tabReportes.Margin = new Padding(2, 1, 2, 1);
            tabReportes.Name = "tabReportes";
            tabReportes.Padding = new Padding(2, 1, 2, 1);
            tabReportes.Size = new Size(976, 469);
            tabReportes.TabIndex = 4;
            tabReportes.Text = "Reportes";
            tabReportes.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(dgvReporteActividades);
            groupBox2.Location = new Point(5, 146);
            groupBox2.Margin = new Padding(2, 1, 2, 1);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2, 1, 2, 1);
            groupBox2.Size = new Size(964, 317);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Inscriptos y recaudación por actividad";
            // 
            // dgvReporteActividades
            // 
            dgvReporteActividades.AllowUserToAddRows = false;
            dgvReporteActividades.AllowUserToDeleteRows = false;
            dgvReporteActividades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReporteActividades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReporteActividades.Dock = DockStyle.Fill;
            dgvReporteActividades.Location = new Point(2, 17);
            dgvReporteActividades.Margin = new Padding(2, 1, 2, 1);
            dgvReporteActividades.Name = "dgvReporteActividades";
            dgvReporteActividades.ReadOnly = true;
            dgvReporteActividades.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReporteActividades.Size = new Size(960, 299);
            dgvReporteActividades.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblRecaudacionTotal);
            groupBox1.Controls.Add(lblTotalInscriptos);
            groupBox1.Controls.Add(btnConsultarReporte);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cbFiltroActividad);
            groupBox1.Location = new Point(6, 6);
            groupBox1.Margin = new Padding(2, 1, 2, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(964, 138);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtros y resumen";
            // 
            // lblRecaudacionTotal
            // 
            lblRecaudacionTotal.AutoSize = true;
            lblRecaudacionTotal.Location = new Point(420, 94);
            lblRecaudacionTotal.Margin = new Padding(2, 0, 2, 0);
            lblRecaudacionTotal.Name = "lblRecaudacionTotal";
            lblRecaudacionTotal.Size = new Size(105, 15);
            lblRecaudacionTotal.TabIndex = 4;
            lblRecaudacionTotal.Text = "Recaudación total:";
            // 
            // lblTotalInscriptos
            // 
            lblTotalInscriptos.AutoSize = true;
            lblTotalInscriptos.Location = new Point(107, 94);
            lblTotalInscriptos.Margin = new Padding(2, 0, 2, 0);
            lblTotalInscriptos.Name = "lblTotalInscriptos";
            lblTotalInscriptos.Size = new Size(90, 15);
            lblTotalInscriptos.TabIndex = 3;
            lblTotalInscriptos.Text = "Total inscriptos:";
            // 
            // btnConsultarReporte
            // 
            btnConsultarReporte.Location = new Point(420, 49);
            btnConsultarReporte.Margin = new Padding(2, 1, 2, 1);
            btnConsultarReporte.Name = "btnConsultarReporte";
            btnConsultarReporte.Size = new Size(87, 24);
            btnConsultarReporte.TabIndex = 2;
            btnConsultarReporte.Text = "Consultar";
            btnConsultarReporte.UseVisualStyleBackColor = true;
            btnConsultarReporte.Click += btnConsultarReporte_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 49);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 1;
            label1.Text = "Actividad";
            // 
            // cbFiltroActividad
            // 
            cbFiltroActividad.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFiltroActividad.FormattingEnabled = true;
            cbFiltroActividad.Location = new Point(107, 46);
            cbFiltroActividad.Margin = new Padding(2, 1, 2, 1);
            cbFiltroActividad.Name = "cbFiltroActividad";
            cbFiltroActividad.Size = new Size(265, 23);
            cbFiltroActividad.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 497);
            Controls.Add(tabControl);
            MinimumSize = new Size(742, 357);
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
            tabReportes.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvReporteActividades).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private TabPage tabReportes;
        private GroupBox groupBox2;
        private DataGridView dgvReporteActividades;
        private GroupBox groupBox1;
        private Label label1;
        private ComboBox cbFiltroActividad;
        private Label lblRecaudacionTotal;
        private Label lblTotalInscriptos;
        private Button btnConsultarReporte;
    }
}
