namespace ClubGestion
{
    partial class Agregar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtNombre = new TextBox();
            txtArancel = new TextBox();
            label2 = new Label();
            label3 = new Label();
            nudCupo = new NumericUpDown();
            btnCancelar = new Button();
            btnGuardar = new Button();
            ((System.ComponentModel.ISupportInitialize)nudCupo).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 68);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(52, 91);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(291, 27);
            txtNombre.TabIndex = 1;
            // 
            // txtArancel
            // 
            txtArancel.Location = new Point(52, 151);
            txtArancel.Name = "txtArancel";
            txtArancel.Size = new Size(291, 27);
            txtArancel.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 128);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 2;
            label2.Text = "Arancel:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 181);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 4;
            label3.Text = "Cupo:";
            // 
            // nudCupo
            // 
            nudCupo.Location = new Point(52, 204);
            nudCupo.Name = "nudCupo";
            nudCupo.Size = new Size(291, 27);
            nudCupo.TabIndex = 5;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(148, 237);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(249, 237);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // Agregar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 361);
            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);
            Controls.Add(nudCupo);
            Controls.Add(label3);
            Controls.Add(txtArancel);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Agregar";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Nueva actividad";
            ((System.ComponentModel.ISupportInitialize)nudCupo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private TextBox txtArancel;
        private Label label2;
        private Label label3;
        private NumericUpDown nudCupo;
        private Button btnCancelar;
        private Button btnGuardar;
    }
}