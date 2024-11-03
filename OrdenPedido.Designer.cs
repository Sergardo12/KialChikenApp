namespace KialChikenApp
{
    partial class OrdenPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdenPedido));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpkFechaTomaPedidos = new System.Windows.Forms.DateTimePicker();
            this.txtNumeroOrden = new System.Windows.Forms.TextBox();
            this.cbxNumeroMesa = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgvTomaPedidos = new System.Windows.Forms.DataGridView();
            this.btnNuevoTomaPedidos = new System.Windows.Forms.Button();
            this.btnRegistrarTomaPedidos = new System.Windows.Forms.Button();
            this.btnAnularTomaPedidos = new System.Windows.Forms.Button();
            this.pcbcBotonCerrar = new System.Windows.Forms.PictureBox();
            this.btnListoTomaPedidos = new System.Windows.Forms.Button();
            this.btnCancelarTomaPedidos = new System.Windows.Forms.Button();
            this.btnRegresarTomaPedidos = new System.Windows.Forms.Button();
            this.pcbxFondoMadera = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTomaPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbcBotonCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxFondoMadera)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(289, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Toma de Pedidos";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.dtpkFechaTomaPedidos);
            this.groupBox1.Controls.Add(this.txtNumeroOrden);
            this.groupBox1.Controls.Add(this.cbxNumeroMesa);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(32, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(558, 269);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del pedido:";
            // 
            // dtpkFechaTomaPedidos
            // 
            this.dtpkFechaTomaPedidos.Location = new System.Drawing.Point(157, 176);
            this.dtpkFechaTomaPedidos.Name = "dtpkFechaTomaPedidos";
            this.dtpkFechaTomaPedidos.Size = new System.Drawing.Size(257, 28);
            this.dtpkFechaTomaPedidos.TabIndex = 5;
            // 
            // txtNumeroOrden
            // 
            this.txtNumeroOrden.Location = new System.Drawing.Point(157, 114);
            this.txtNumeroOrden.Name = "txtNumeroOrden";
            this.txtNumeroOrden.Size = new System.Drawing.Size(257, 28);
            this.txtNumeroOrden.TabIndex = 4;
            // 
            // cbxNumeroMesa
            // 
            this.cbxNumeroMesa.FormattingEnabled = true;
            this.cbxNumeroMesa.Location = new System.Drawing.Point(157, 53);
            this.cbxNumeroMesa.Name = "cbxNumeroMesa";
            this.cbxNumeroMesa.Size = new System.Drawing.Size(257, 29);
            this.cbxNumeroMesa.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Fecha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "N° Orden:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "N° Mesa:";
            // 
            // dtgvTomaPedidos
            // 
            this.dtgvTomaPedidos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgvTomaPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTomaPedidos.Location = new System.Drawing.Point(32, 417);
            this.dtgvTomaPedidos.Name = "dtgvTomaPedidos";
            this.dtgvTomaPedidos.RowHeadersWidth = 51;
            this.dtgvTomaPedidos.RowTemplate.Height = 24;
            this.dtgvTomaPedidos.Size = new System.Drawing.Size(558, 208);
            this.dtgvTomaPedidos.TabIndex = 2;
            // 
            // btnNuevoTomaPedidos
            // 
            this.btnNuevoTomaPedidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(147)))), ((int)(((byte)(54)))));
            this.btnNuevoTomaPedidos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoTomaPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoTomaPedidos.ForeColor = System.Drawing.Color.White;
            this.btnNuevoTomaPedidos.Location = new System.Drawing.Point(668, 109);
            this.btnNuevoTomaPedidos.Name = "btnNuevoTomaPedidos";
            this.btnNuevoTomaPedidos.Size = new System.Drawing.Size(138, 48);
            this.btnNuevoTomaPedidos.TabIndex = 3;
            this.btnNuevoTomaPedidos.Text = "Nuevo";
            this.btnNuevoTomaPedidos.UseVisualStyleBackColor = false;
            // 
            // btnRegistrarTomaPedidos
            // 
            this.btnRegistrarTomaPedidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(55)))), ((int)(((byte)(6)))));
            this.btnRegistrarTomaPedidos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarTomaPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarTomaPedidos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegistrarTomaPedidos.Location = new System.Drawing.Point(668, 183);
            this.btnRegistrarTomaPedidos.Name = "btnRegistrarTomaPedidos";
            this.btnRegistrarTomaPedidos.Size = new System.Drawing.Size(138, 48);
            this.btnRegistrarTomaPedidos.TabIndex = 4;
            this.btnRegistrarTomaPedidos.Text = "Registrar";
            this.btnRegistrarTomaPedidos.UseVisualStyleBackColor = false;
            // 
            // btnAnularTomaPedidos
            // 
            this.btnAnularTomaPedidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.btnAnularTomaPedidos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnularTomaPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnularTomaPedidos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAnularTomaPedidos.Location = new System.Drawing.Point(668, 258);
            this.btnAnularTomaPedidos.Name = "btnAnularTomaPedidos";
            this.btnAnularTomaPedidos.Size = new System.Drawing.Size(138, 48);
            this.btnAnularTomaPedidos.TabIndex = 5;
            this.btnAnularTomaPedidos.Text = "Anular";
            this.btnAnularTomaPedidos.UseVisualStyleBackColor = false;
            // 
            // pcbcBotonCerrar
            // 
            this.pcbcBotonCerrar.BackColor = System.Drawing.Color.Transparent;
            this.pcbcBotonCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbcBotonCerrar.Image = ((System.Drawing.Image)(resources.GetObject("pcbcBotonCerrar.Image")));
            this.pcbcBotonCerrar.Location = new System.Drawing.Point(874, 3);
            this.pcbcBotonCerrar.Name = "pcbcBotonCerrar";
            this.pcbcBotonCerrar.Size = new System.Drawing.Size(25, 25);
            this.pcbcBotonCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbcBotonCerrar.TabIndex = 6;
            this.pcbcBotonCerrar.TabStop = false;
            this.pcbcBotonCerrar.Click += new System.EventHandler(this.pcbcBotonCerrar_Click);
            // 
            // btnListoTomaPedidos
            // 
            this.btnListoTomaPedidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(147)))), ((int)(((byte)(54)))));
            this.btnListoTomaPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListoTomaPedidos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnListoTomaPedidos.Location = new System.Drawing.Point(764, 642);
            this.btnListoTomaPedidos.Name = "btnListoTomaPedidos";
            this.btnListoTomaPedidos.Size = new System.Drawing.Size(124, 46);
            this.btnListoTomaPedidos.TabIndex = 48;
            this.btnListoTomaPedidos.Text = "Listo";
            this.btnListoTomaPedidos.UseVisualStyleBackColor = false;
            // 
            // btnCancelarTomaPedidos
            // 
            this.btnCancelarTomaPedidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.btnCancelarTomaPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarTomaPedidos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelarTomaPedidos.Location = new System.Drawing.Point(611, 642);
            this.btnCancelarTomaPedidos.Name = "btnCancelarTomaPedidos";
            this.btnCancelarTomaPedidos.Size = new System.Drawing.Size(124, 46);
            this.btnCancelarTomaPedidos.TabIndex = 47;
            this.btnCancelarTomaPedidos.Text = "Cancelar";
            this.btnCancelarTomaPedidos.UseVisualStyleBackColor = false;
            // 
            // btnRegresarTomaPedidos
            // 
            this.btnRegresarTomaPedidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(147)))), ((int)(((byte)(54)))));
            this.btnRegresarTomaPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresarTomaPedidos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegresarTomaPedidos.Location = new System.Drawing.Point(12, 642);
            this.btnRegresarTomaPedidos.Name = "btnRegresarTomaPedidos";
            this.btnRegresarTomaPedidos.Size = new System.Drawing.Size(124, 46);
            this.btnRegresarTomaPedidos.TabIndex = 46;
            this.btnRegresarTomaPedidos.Text = "Regresar";
            this.btnRegresarTomaPedidos.UseVisualStyleBackColor = false;
            // 
            // pcbxFondoMadera
            // 
            this.pcbxFondoMadera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcbxFondoMadera.Image = ((System.Drawing.Image)(resources.GetObject("pcbxFondoMadera.Image")));
            this.pcbxFondoMadera.Location = new System.Drawing.Point(0, 0);
            this.pcbxFondoMadera.Margin = new System.Windows.Forms.Padding(5);
            this.pcbxFondoMadera.Name = "pcbxFondoMadera";
            this.pcbxFondoMadera.Size = new System.Drawing.Size(900, 700);
            this.pcbxFondoMadera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbxFondoMadera.TabIndex = 49;
            this.pcbxFondoMadera.TabStop = false;
            this.pcbxFondoMadera.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pcbxFondoMadera_MouseDown);
            // 
            // OrdenPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(900, 700);
            this.Controls.Add(this.btnListoTomaPedidos);
            this.Controls.Add(this.btnCancelarTomaPedidos);
            this.Controls.Add(this.btnRegresarTomaPedidos);
            this.Controls.Add(this.pcbcBotonCerrar);
            this.Controls.Add(this.btnAnularTomaPedidos);
            this.Controls.Add(this.btnRegistrarTomaPedidos);
            this.Controls.Add(this.btnNuevoTomaPedidos);
            this.Controls.Add(this.dtgvTomaPedidos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pcbxFondoMadera);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OrdenPedido";
            this.Text = "OrdenPedido";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTomaPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbcBotonCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxFondoMadera)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpkFechaTomaPedidos;
        private System.Windows.Forms.TextBox txtNumeroOrden;
        private System.Windows.Forms.ComboBox cbxNumeroMesa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgvTomaPedidos;
        private System.Windows.Forms.Button btnNuevoTomaPedidos;
        private System.Windows.Forms.Button btnRegistrarTomaPedidos;
        private System.Windows.Forms.Button btnAnularTomaPedidos;
        private System.Windows.Forms.PictureBox pcbcBotonCerrar;
        private System.Windows.Forms.Button btnListoTomaPedidos;
        private System.Windows.Forms.Button btnCancelarTomaPedidos;
        private System.Windows.Forms.Button btnRegresarTomaPedidos;
        private System.Windows.Forms.PictureBox pcbxFondoMadera;
    }
}