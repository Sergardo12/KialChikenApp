namespace KialChikenApp
{
    partial class CompraInsumos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompraInsumos));
            this.pcbxFondoMadera = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRegistrarProveedor = new System.Windows.Forms.Button();
            this.btnAnularCompra = new System.Windows.Forms.Button();
            this.btnRegistrarCompra = new System.Windows.Forms.Button();
            this.btnNuevoCompra = new System.Windows.Forms.Button();
            this.txtIdCompra = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMontoCompra = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpkFechCompra = new System.Windows.Forms.DateTimePicker();
            this.txtNombreAdmCompra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumeroRequerimientoCompra = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtgvCompraInsumos = new System.Windows.Forms.DataGridView();
            this.btnRegresarCompra = new System.Windows.Forms.Button();
            this.btnListoCompra = new System.Windows.Forms.Button();
            this.btnCancelarCompra = new System.Windows.Forms.Button();
            this.pcbcBotonCerrar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxFondoMadera)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCompraInsumos)).BeginInit();
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
            this.pcbxFondoMadera.Size = new System.Drawing.Size(1000, 900);
            this.pcbxFondoMadera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbxFondoMadera.TabIndex = 29;
            this.pcbxFondoMadera.TabStop = false;
            this.pcbxFondoMadera.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pcbxFondoMadera_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(302, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 40);
            this.label1.TabIndex = 30;
            this.label1.Text = "Compra de Insumos";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRegistrarProveedor);
            this.groupBox1.Controls.Add(this.btnAnularCompra);
            this.groupBox1.Controls.Add(this.btnRegistrarCompra);
            this.groupBox1.Controls.Add(this.btnNuevoCompra);
            this.groupBox1.Controls.Add(this.txtIdCompra);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtMontoCompra);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpkFechCompra);
            this.groupBox1.Controls.Add(this.txtNombreAdmCompra);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNumeroRequerimientoCompra);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(60, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(838, 377);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de compra:";
            // 
            // btnRegistrarProveedor
            // 
            this.btnRegistrarProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(147)))), ((int)(((byte)(54)))));
            this.btnRegistrarProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarProveedor.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarProveedor.Location = new System.Drawing.Point(636, 131);
            this.btnRegistrarProveedor.Name = "btnRegistrarProveedor";
            this.btnRegistrarProveedor.Size = new System.Drawing.Size(169, 67);
            this.btnRegistrarProveedor.TabIndex = 19;
            this.btnRegistrarProveedor.Text = "Registrar Proveedor";
            this.btnRegistrarProveedor.UseVisualStyleBackColor = false;
            // 
            // btnAnularCompra
            // 
            this.btnAnularCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.btnAnularCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnularCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnularCompra.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAnularCompra.Location = new System.Drawing.Point(636, 289);
            this.btnAnularCompra.Name = "btnAnularCompra";
            this.btnAnularCompra.Size = new System.Drawing.Size(169, 48);
            this.btnAnularCompra.TabIndex = 18;
            this.btnAnularCompra.Text = "Anular Compra";
            this.btnAnularCompra.UseVisualStyleBackColor = false;
            // 
            // btnRegistrarCompra
            // 
            this.btnRegistrarCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(55)))), ((int)(((byte)(6)))));
            this.btnRegistrarCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarCompra.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegistrarCompra.Location = new System.Drawing.Point(636, 213);
            this.btnRegistrarCompra.Name = "btnRegistrarCompra";
            this.btnRegistrarCompra.Size = new System.Drawing.Size(169, 48);
            this.btnRegistrarCompra.TabIndex = 17;
            this.btnRegistrarCompra.Text = "Registrar Compra";
            this.btnRegistrarCompra.UseVisualStyleBackColor = false;
            // 
            // btnNuevoCompra
            // 
            this.btnNuevoCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(147)))), ((int)(((byte)(54)))));
            this.btnNuevoCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoCompra.ForeColor = System.Drawing.Color.White;
            this.btnNuevoCompra.Location = new System.Drawing.Point(636, 58);
            this.btnNuevoCompra.Name = "btnNuevoCompra";
            this.btnNuevoCompra.Size = new System.Drawing.Size(169, 48);
            this.btnNuevoCompra.TabIndex = 16;
            this.btnNuevoCompra.Text = "Nuevo Compra";
            this.btnNuevoCompra.UseVisualStyleBackColor = false;
            // 
            // txtIdCompra
            // 
            this.txtIdCompra.Location = new System.Drawing.Point(290, 58);
            this.txtIdCompra.Name = "txtIdCompra";
            this.txtIdCompra.Size = new System.Drawing.Size(224, 28);
            this.txtIdCompra.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 21);
            this.label6.TabIndex = 14;
            this.label6.Text = "Id Compra:";
            // 
            // txtMontoCompra
            // 
            this.txtMontoCompra.Location = new System.Drawing.Point(290, 237);
            this.txtMontoCompra.Name = "txtMontoCompra";
            this.txtMontoCompra.Size = new System.Drawing.Size(224, 28);
            this.txtMontoCompra.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 21);
            this.label5.TabIndex = 12;
            this.label5.Text = "Monto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "Fecha de Pago:";
            // 
            // dtpkFechCompra
            // 
            this.dtpkFechCompra.Location = new System.Drawing.Point(290, 296);
            this.dtpkFechCompra.Name = "dtpkFechCompra";
            this.dtpkFechCompra.Size = new System.Drawing.Size(254, 28);
            this.dtpkFechCompra.TabIndex = 10;
            // 
            // txtNombreAdmCompra
            // 
            this.txtNombreAdmCompra.Location = new System.Drawing.Point(290, 170);
            this.txtNombreAdmCompra.Name = "txtNombreAdmCompra";
            this.txtNombreAdmCompra.Size = new System.Drawing.Size(224, 28);
            this.txtNombreAdmCompra.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nombre del Administrador:";
            // 
            // txtNumeroRequerimientoCompra
            // 
            this.txtNumeroRequerimientoCompra.Location = new System.Drawing.Point(290, 109);
            this.txtNumeroRequerimientoCompra.Name = "txtNumeroRequerimientoCompra";
            this.txtNumeroRequerimientoCompra.Size = new System.Drawing.Size(224, 28);
            this.txtNumeroRequerimientoCompra.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "N° Requerimiento:";
            // 
            // dtgvCompraInsumos
            // 
            this.dtgvCompraInsumos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCompraInsumos.Location = new System.Drawing.Point(60, 517);
            this.dtgvCompraInsumos.Name = "dtgvCompraInsumos";
            this.dtgvCompraInsumos.RowHeadersWidth = 51;
            this.dtgvCompraInsumos.RowTemplate.Height = 24;
            this.dtgvCompraInsumos.Size = new System.Drawing.Size(838, 301);
            this.dtgvCompraInsumos.TabIndex = 32;
            // 
            // btnRegresarCompra
            // 
            this.btnRegresarCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(147)))), ((int)(((byte)(54)))));
            this.btnRegresarCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegresarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresarCompra.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegresarCompra.Location = new System.Drawing.Point(12, 842);
            this.btnRegresarCompra.Name = "btnRegresarCompra";
            this.btnRegresarCompra.Size = new System.Drawing.Size(124, 46);
            this.btnRegresarCompra.TabIndex = 43;
            this.btnRegresarCompra.Text = "Regresar";
            this.btnRegresarCompra.UseVisualStyleBackColor = false;
            // 
            // btnListoCompra
            // 
            this.btnListoCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(147)))), ((int)(((byte)(54)))));
            this.btnListoCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListoCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListoCompra.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnListoCompra.Location = new System.Drawing.Point(868, 842);
            this.btnListoCompra.Name = "btnListoCompra";
            this.btnListoCompra.Size = new System.Drawing.Size(124, 46);
            this.btnListoCompra.TabIndex = 45;
            this.btnListoCompra.Text = "Listo";
            this.btnListoCompra.UseVisualStyleBackColor = false;
            // 
            // btnCancelarCompra
            // 
            this.btnCancelarCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.btnCancelarCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarCompra.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelarCompra.Location = new System.Drawing.Point(672, 842);
            this.btnCancelarCompra.Name = "btnCancelarCompra";
            this.btnCancelarCompra.Size = new System.Drawing.Size(124, 46);
            this.btnCancelarCompra.TabIndex = 44;
            this.btnCancelarCompra.Text = "Cancelar";
            this.btnCancelarCompra.UseVisualStyleBackColor = false;
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
            this.pcbcBotonCerrar.TabIndex = 46;
            this.pcbcBotonCerrar.TabStop = false;
            this.pcbcBotonCerrar.Click += new System.EventHandler(this.pcbcBotonCerrar_Click);
            // 
            // CompraInsumos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 900);
            this.Controls.Add(this.pcbcBotonCerrar);
            this.Controls.Add(this.btnListoCompra);
            this.Controls.Add(this.btnCancelarCompra);
            this.Controls.Add(this.btnRegresarCompra);
            this.Controls.Add(this.dtgvCompraInsumos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pcbxFondoMadera);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CompraInsumos";
            this.Text = "CompraInsumos";
            ((System.ComponentModel.ISupportInitialize)(this.pcbxFondoMadera)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCompraInsumos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbcBotonCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbxFondoMadera;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpkFechCompra;
        private System.Windows.Forms.TextBox txtNombreAdmCompra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumeroRequerimientoCompra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdCompra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMontoCompra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dtgvCompraInsumos;
        private System.Windows.Forms.Button btnRegistrarProveedor;
        private System.Windows.Forms.Button btnAnularCompra;
        private System.Windows.Forms.Button btnRegistrarCompra;
        private System.Windows.Forms.Button btnNuevoCompra;
        private System.Windows.Forms.Button btnRegresarCompra;
        private System.Windows.Forms.Button btnListoCompra;
        private System.Windows.Forms.Button btnCancelarCompra;
        private System.Windows.Forms.PictureBox pcbcBotonCerrar;
    }
}