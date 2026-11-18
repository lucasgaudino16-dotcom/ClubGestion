namespace ClubGestion
{
    partial class DatosSocioControl
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
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
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(41, 42);
            lblNombre.Margin = new Padding(6, 0, 6, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(102, 32);
            lblNombre.TabIndex = 6;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(41, 80);
            txtNombre.Margin = new Padding(6);
            txtNombre.MaxLength = 50;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(368, 39);
            txtNombre.TabIndex = 7;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(442, 42);
            lblApellido.Margin = new Padding(6, 0, 6, 0);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(102, 32);
            lblApellido.TabIndex = 8;
            lblApellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(442, 80);
            txtApellido.Margin = new Padding(6);
            txtApellido.MaxLength = 50;
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(368, 39);
            txtApellido.TabIndex = 9;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(843, 42);
            lblDni.Margin = new Padding(6, 0, 6, 0);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(55, 32);
            lblDni.TabIndex = 10;
            lblDni.Text = "DNI";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(843, 80);
            txtDni.Margin = new Padding(6);
            txtDni.MaxLength = 8;
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(219, 39);
            txtDni.TabIndex = 11;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(41, 139);
            lblEmail.Margin = new Padding(6, 0, 6, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(71, 32);
            lblEmail.TabIndex = 13;
            lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(41, 177);
            txtEmail.Margin = new Padding(6);
            txtEmail.MaxLength = 100;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(479, 39);
            txtEmail.TabIndex = 14;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(553, 139);
            lblTelefono.Margin = new Padding(6, 0, 6, 0);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(107, 32);
            lblTelefono.TabIndex = 15;
            lblTelefono.Text = "Teléfono";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(553, 177);
            txtTelefono.Margin = new Padding(6);
            txtTelefono.MaxLength = 20;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(257, 39);
            txtTelefono.TabIndex = 16;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(843, 139);
            lblCategoria.Margin = new Padding(6, 0, 6, 0);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(116, 32);
            lblCategoria.TabIndex = 17;
            lblCategoria.Text = "Categoría";
            // 
            // cboCategoria
            // 
            cboCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategoria.FormattingEnabled = true;
            cboCategoria.Location = new Point(843, 177);
            cboCategoria.Margin = new Padding(6);
            cboCategoria.Name = "cboCategoria";
            cboCategoria.Size = new Size(294, 40);
            cboCategoria.TabIndex = 18;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Checked = true;
            chkActivo.CheckState = CheckState.Checked;
            chkActivo.Location = new Point(1170, 181);
            chkActivo.Margin = new Padding(6);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(112, 36);
            chkActivo.TabIndex = 19;
            chkActivo.Text = "Activo";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // DatosSocioControl
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(lblTelefono);
            Controls.Add(txtTelefono);
            Controls.Add(lblCategoria);
            Controls.Add(cboCategoria);
            Controls.Add(chkActivo);
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            Controls.Add(lblApellido);
            Controls.Add(txtApellido);
            Controls.Add(lblDni);
            Controls.Add(txtDni);
            Name = "DatosSocioControl";
            Size = new Size(1750, 240);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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
    }
}
