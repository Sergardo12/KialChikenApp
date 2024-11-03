namespace KialChikenApp
{
    partial class RegistroAlmacen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroAlmacen));
            this.pcbxFondoMadera = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpkFechaRegistroIngresoInsumo = new System.Windows.Forms.DateTimePicker();
            this.txtNombreRegistroIngresoInsumo = new System.Windows.Forms.TextBox();
            this.txtIdRegistroIngresoInsumo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAnularRegistroIngresoInsumo = new System.Windows.Forms.Button();
            this.btnRegistrarRegistroIngresoInsumo = new System.Windows.Forms.Button();
            this.btnNuevoRegistroIngresoInsumo = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dtgvRegistroIngresoInsumo = new System.Windows.Forms.DataGridView();
            this.btnListoRegistroIngresoInsumo = new System.Windows.Forms.Button();
            this.btnCancelarRegistroIngresoInsumo = new System.Windows.Forms.Button();
            this.btnRegresarRegistroInsumoInsumo = new System.Windows.Forms.Button();
            this.pcbcBotonCerrar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxFondoMadera)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRegistroIngresoInsumo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbcBotonCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbxFondoMadera
            // 
            this.pcbxFondoMadera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcbxFondoMadera.Image = ((System.Drawing.Image)(resources.GetObject("pcbxFondoMadera.Image")));
            this.pcbxFondoMadera.Location = new System.Drawing.Point(0, 0);
            this.pcbxFondoMadera.Margin = new System.Windows.Forms.Padding(5);
            this.pcbxFondoMadera.Name = "pcbxFondoMadera";
            this.pcbxFondoMadera.Size = new System.Drawing.Size(1000, 791);
            this.pcbxFondoMadera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbxFondoMadera.TabIndex = 29;
            this.pcbxFondoMadera.TabStop = false;
            this.pcbxFondoMadera.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pcbxFondoMadera_MouseDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpkFechaRegistroIngresoInsumo);
            this.groupBox1.Controls.Add(this.txtNombreRegistroIngresoInsumo);
            this.groupBox1.Controls.Add(this.txtIdRegistroIngresoInsumo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(37, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(541, 251);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // dtpkFechaRegistroIngresoInsumo
            // 
            this.dtpkFechaRegistroIngresoInsumo.Location = new System.Drawing.Point(263, 145);
            this.dtpkFechaRegistroIngresoInsumo.Name = "dtpkFechaRegistroIngresoInsumo";
            this.dtpkFechaRegistroIngresoInsumo.Size = new System.Drawing.Size(232, 28);
            this.dtpkFechaRegistroIngresoInsumo.TabIndex = 5;
            // 
            // txtNombreRegistroIngresoInsumo
            // 
            this.txtNombreRegistroIngresoInsumo.Location = new System.Drawing.Point(263, 101);
            this.txtNombreRegistroIngresoInsumo.Name = "txtNombreRegistroIngresoInsumo";
            this.txtNombreRegistroIngresoInsumo.Size = new System.Drawing.Size(232, 28);
            this.txtNombreRegistroIngresoInsumo.TabIndex = 4;
            // 
            // txtIdRegistroIngresoInsumo
            // 
            this.txtIdRegistroIngresoInsumo.Location = new System.Drawing.Point(263, 54);
            this.txtIdRegistroIngresoInsumo.Name = "txtIdRegistroIngresoInsumo";
            this.txtIdRegistroIngresoInsumo.Size = new System.Drawing.Size(232, 28);
            this.txtIdRegistroIngresoInsumo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre del Almacenista:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Registro:";
            // 
            // btnAnularRegistroIngresoInsumo
            // 
            this.btnAnularRegistroIngresoInsumo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.btnAnularRegistroIngresoInsumo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnularRegistroIngresoInsumo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnularRegistroIngresoInsumo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAnularRegistroIngresoInsumo.Location = new System.Drawing.Point(722, 287);
            this.btnAnularRegistroIngresoInsumo.Name = "btnAnularRegistroIngresoInsumo";
            this.btnAnularRegistroIngresoInsumo.Size = new System.Drawing.Size(138, 48);
            this.btnAnularRegistroIngresoInsumo.TabIndex = 38;
            this.btnAnularRegistroIngresoInsumo.Text = "Anular";
            this.btnAnularRegistroIngresoInsumo.UseVisualStyleBackColor = false;
            // 
            // btnRegistrarRegistroIngresoInsumo
            // 
            this.btnRegistrarRegistroIngresoInsumo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(55)))), ((int)(((byte)(6)))));
            this.btnRegistrarRegistroIngresoInsumo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarRegistroIngresoInsumo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarRegistroIngresoInsumo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegistrarRegistroIngresoInsumo.Location = new System.Drawing.Point(722, 212);
            this.btnRegistrarRegistroIngresoInsumo.Name = "btnRegistrarRegistroIngresoInsumo";
            this.btnRegistrarRegistroIngresoInsumo.Size = new System.Drawing.Size(138, 48);
            this.btnRegistrarRegistroIngresoInsumo.TabIndex = 37;
            this.btnRegistrarRegistroIngresoInsumo.Text = "Registrar";
            this.btnRegistrarRegistroIngresoInsumo.UseVisualStyleBackColor = false;
            // 
            // btnNuevoRegistroIngresoInsumo
            // 
            this.btnNuevoRegistroIngresoInsumo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(147)))), ((int)(((byte)(54)))));
            this.btnNuevoRegistroIngresoInsumo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoRegistroIngresoInsumo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoRegistroIngresoInsumo.ForeColor = System.Drawing.Color.White;
            this.btnNuevoRegistroIngresoInsumo.Location = new System.Drawing.Point(722, 138);
            this.btnNuevoRegistroIngresoInsumo.Name = "btnNuevoRegistroIngresoInsumo";
            this.btnNuevoRegistroIngresoInsumo.Size = new System.Drawing.Size(138, 48);
            this.btnNuevoRegistroIngresoInsumo.TabIndex = 36;
            this.btnNuevoRegistroIngresoInsumo.Text = "Nuevo";
            this.btnNuevoRegistroIngresoInsumo.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(239, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(507, 40);
            this.label7.TabIndex = 39;
            this.label7.Text = "Registro de Ingreso de insumos";
            // 
            // dtgvRegistroIngresoInsumo
            // 
            this.dtgvRegistroIngresoInsumo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvRegistroIngresoInsumo.Location = new System.Drawing.Point(37, 382);
            this.dtgvRegistroIngresoInsumo.Name = "dtgvRegistroIngresoInsumo";
            this.dtgvRegistroIngresoInsumo.RowHeadersWidth = 51;
            this.dtgvRegistroIngresoInsumo.RowTemplate.Height = 24;
            this.dtgvRegistroIngresoInsumo.Size = new System.Drawing.Size(541, 299);
            this.dtgvRegistroIngresoInsumo.TabIndex = 40;
            // 
            // btnListoRegistroIngresoInsumo
            // 
            this.btnListoRegistroIngresoInsumo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(147)))), ((int)(((byte)(54)))));
            this.btnListoRegistroIngresoInsumo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListoRegistroIngresoInsumo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnListoRegistroIngresoInsumo.Location = new System.Drawing.Point(864, 723);
            this.btnListoRegistroIngresoInsumo.Name = "btnListoRegistroIngresoInsumo";
            this.btnListoRegistroIngresoInsumo.Size = new System.Drawing.Size(124, 46);
            this.btnListoRegistroIngresoInsumo.TabIndex = 42;
            this.btnListoRegistroIngresoInsumo.Text = "Listo";
            this.btnListoRegistroIngresoInsumo.UseVisualStyleBackColor = false;
            // 
            // btnCancelarRegistroIngresoInsumo
            // 
            this.btnCancelarRegistroIngresoInsumo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.btnCancelarRegistroIngresoInsumo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarRegistroIngresoInsumo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelarRegistroIngresoInsumo.Location = new System.Drawing.Point(682, 723);
            this.btnCancelarRegistroIngresoInsumo.Name = "btnCancelarRegistroIngresoInsumo";
            this.btnCancelarRegistroIngresoInsumo.Size = new System.Drawing.Size(124, 46);
            this.btnCancelarRegistroIngresoInsumo.TabIndex = 41;
            this.btnCancelarRegistroIngresoInsumo.Text = "Cancelar";
            this.btnCancelarRegistroIngresoInsumo.UseVisualStyleBackColor = false;
            // 
            // btnRegresarRegistroInsumoInsumo
            // 
            this.btnRegresarRegistroInsumoInsumo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(147)))), ((int)(((byte)(54)))));
            this.btnRegresarRegistroInsumoInsumo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresarRegistroInsumoInsumo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegresarRegistroInsumoInsumo.Location = new System.Drawing.Point(26, 723);
            this.btnRegresarRegistroInsumoInsumo.Name = "btnRegresarRegistroInsumoInsumo";
            this.btnRegresarRegistroInsumoInsumo.Size = new System.Drawing.Size(124, 46);
            this.btnRegresarRegistroInsumoInsumo.TabIndex = 47;
            this.btnRegresarRegistroInsumoInsumo.Text = "Regresar";
            this.btnRegresarRegistroInsumoInsumo.UseVisualStyleBackColor = false;
            // 
            // pcbcBotonCerrar
            // 
            this.pcbcBotonCerrar.BackColor = System.Drawing.Color.Transparent;
            this.pcbcBotonCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbcBotonCerrar.Image = ((System.Drawing.Image)(resources.GetObject("pcbcBotonCerrar.Image")));
            this.pcbcBotonCerrar.Location = new System.Drawing.Point(975, 0);
            this.pcbcBotonCerrar.Name = "pcbcBotonCerrar";
            this.pcbcBotonCerrar.Size = new System.Drawing.Size(25, 25);
            this.pcbcBotonCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbcBotonCerrar.TabIndex = 48;
            this.pcbcBotonCerrar.TabStop = false;
            this.pcbcBotonCerrar.Click += new System.EventHandler(this.pcbcBotonCerrar_Click);
            // 
            // RegistroAlmacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 791);
            this.Controls.Add(this.pcbcBotonCerrar);
            this.Controls.Add(this.btnRegresarRegistroInsumoInsumo);
            this.Controls.Add(this.btnListoRegistroIngresoInsumo);
            this.Controls.Add(this.btnCancelarRegistroIngresoInsumo);
            this.Controls.Add(this.dtgvRegistroIngresoInsumo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnAnularRegistroIngresoInsumo);
            this.Controls.Add(this.btnRegistrarRegistroIngresoInsumo);
            this.Controls.Add(this.btnNuevoRegistroIngresoInsumo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pcbxFondoMadera);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RegistroAlmacen";
            this.Text = "RegistroAlmacen";
            ((System.ComponentModel.ISupportInitialize)(this.pcbxFondoMadera)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRegistroIngresoInsumo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbcBotonCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbxFondoMadera;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAnularRegistroIngresoInsumo;
        private System.Windows.Forms.Button btnRegistrarRegistroIngresoInsumo;
        private System.Windows.Forms.Button btnNuevoRegistroIngresoInsumo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpkFechaRegistroIngresoInsumo;
        private System.Windows.Forms.TextBox txtNombreRegistroIngresoInsumo;
        private System.Windows.Forms.TextBox txtIdRegistroIngresoInsumo;
        private System.Windows.Forms.DataGridView dtgvRegistroIngresoInsumo;
        private System.Windows.Forms.Button btnListoRegistroIngresoInsumo;
        private System.Windows.Forms.Button btnCancelarRegistroIngresoInsumo;
        private System.Windows.Forms.Button btnRegresarRegistroInsumoInsumo;
        private System.Windows.Forms.PictureBox pcbcBotonCerrar;
    }
}