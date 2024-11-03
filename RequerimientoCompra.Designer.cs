namespace KialChikenApp
{
    partial class RequerimientoCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RequerimientoCompra));
            this.pcbxFondoMadera = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRegistrarRequerimientoCompra = new System.Windows.Forms.Button();
            this.btnAnularRequerimientoCompra = new System.Windows.Forms.Button();
            this.btnNuevoRequerimientoCompra = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pcbcBotonCerrar = new System.Windows.Forms.PictureBox();
            this.btnRegresarRequrimientoCompra = new System.Windows.Forms.Button();
            this.btnListoRequerimientoCompra = new System.Windows.Forms.Button();
            this.btnCancelarRequerimientoCompra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxFondoMadera)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbcBotonCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbxFondoMadera
            // 
            this.pcbxFondoMadera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcbxFondoMadera.Image = ((System.Drawing.Image)(resources.GetObject("pcbxFondoMadera.Image")));
            this.pcbxFondoMadera.Location = new System.Drawing.Point(0, 0);
            this.pcbxFondoMadera.Name = "pcbxFondoMadera";
            this.pcbxFondoMadera.Size = new System.Drawing.Size(1000, 800);
            this.pcbxFondoMadera.TabIndex = 0;
            this.pcbxFondoMadera.TabStop = false;
            this.pcbxFondoMadera.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pcbxFondoMadera_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(255, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(488, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Requerimientos para compra";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(25, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(611, 323);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de los insumos:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(248, 189);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(224, 28);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(248, 114);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(224, 28);
            this.textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(248, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(224, 28);
            this.textBox1.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "Fecha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "N° Requerimiento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre del encargado:";
            // 
            // btnRegistrarRequerimientoCompra
            // 
            this.btnRegistrarRequerimientoCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(147)))), ((int)(((byte)(54)))));
            this.btnRegistrarRequerimientoCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarRequerimientoCompra.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegistrarRequerimientoCompra.Location = new System.Drawing.Point(676, 226);
            this.btnRegistrarRequerimientoCompra.Name = "btnRegistrarRequerimientoCompra";
            this.btnRegistrarRequerimientoCompra.Size = new System.Drawing.Size(168, 48);
            this.btnRegistrarRequerimientoCompra.TabIndex = 3;
            this.btnRegistrarRequerimientoCompra.Text = "Registrar";
            this.btnRegistrarRequerimientoCompra.UseVisualStyleBackColor = false;
            // 
            // btnAnularRequerimientoCompra
            // 
            this.btnAnularRequerimientoCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.btnAnularRequerimientoCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnularRequerimientoCompra.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAnularRequerimientoCompra.Location = new System.Drawing.Point(676, 311);
            this.btnAnularRequerimientoCompra.Name = "btnAnularRequerimientoCompra";
            this.btnAnularRequerimientoCompra.Size = new System.Drawing.Size(168, 48);
            this.btnAnularRequerimientoCompra.TabIndex = 4;
            this.btnAnularRequerimientoCompra.Text = "Anular";
            this.btnAnularRequerimientoCompra.UseVisualStyleBackColor = false;
            // 
            // btnNuevoRequerimientoCompra
            // 
            this.btnNuevoRequerimientoCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(147)))), ((int)(((byte)(54)))));
            this.btnNuevoRequerimientoCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoRequerimientoCompra.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevoRequerimientoCompra.Location = new System.Drawing.Point(676, 138);
            this.btnNuevoRequerimientoCompra.Name = "btnNuevoRequerimientoCompra";
            this.btnNuevoRequerimientoCompra.Size = new System.Drawing.Size(168, 48);
            this.btnNuevoRequerimientoCompra.TabIndex = 5;
            this.btnNuevoRequerimientoCompra.Text = "Nuevo";
            this.btnNuevoRequerimientoCompra.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 452);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(611, 249);
            this.dataGridView1.TabIndex = 6;
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
            this.pcbcBotonCerrar.TabIndex = 32;
            this.pcbcBotonCerrar.TabStop = false;
            this.pcbcBotonCerrar.Click += new System.EventHandler(this.pcbcBotonCerrar_Click);
            // 
            // btnRegresarRequrimientoCompra
            // 
            this.btnRegresarRequrimientoCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(147)))), ((int)(((byte)(54)))));
            this.btnRegresarRequrimientoCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresarRequrimientoCompra.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegresarRequrimientoCompra.Location = new System.Drawing.Point(25, 742);
            this.btnRegresarRequrimientoCompra.Name = "btnRegresarRequrimientoCompra";
            this.btnRegresarRequrimientoCompra.Size = new System.Drawing.Size(124, 46);
            this.btnRegresarRequrimientoCompra.TabIndex = 50;
            this.btnRegresarRequrimientoCompra.Text = "Regresar";
            this.btnRegresarRequrimientoCompra.UseVisualStyleBackColor = false;
            // 
            // btnListoRequerimientoCompra
            // 
            this.btnListoRequerimientoCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(147)))), ((int)(((byte)(54)))));
            this.btnListoRequerimientoCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListoRequerimientoCompra.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnListoRequerimientoCompra.Location = new System.Drawing.Point(858, 742);
            this.btnListoRequerimientoCompra.Name = "btnListoRequerimientoCompra";
            this.btnListoRequerimientoCompra.Size = new System.Drawing.Size(124, 46);
            this.btnListoRequerimientoCompra.TabIndex = 49;
            this.btnListoRequerimientoCompra.Text = "Listo";
            this.btnListoRequerimientoCompra.UseVisualStyleBackColor = false;
            // 
            // btnCancelarRequerimientoCompra
            // 
            this.btnCancelarRequerimientoCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.btnCancelarRequerimientoCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarRequerimientoCompra.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelarRequerimientoCompra.Location = new System.Drawing.Point(676, 742);
            this.btnCancelarRequerimientoCompra.Name = "btnCancelarRequerimientoCompra";
            this.btnCancelarRequerimientoCompra.Size = new System.Drawing.Size(124, 46);
            this.btnCancelarRequerimientoCompra.TabIndex = 48;
            this.btnCancelarRequerimientoCompra.Text = "Cancelar";
            this.btnCancelarRequerimientoCompra.UseVisualStyleBackColor = false;
            // 
            // RequerimientoCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 800);
            this.Controls.Add(this.btnRegresarRequrimientoCompra);
            this.Controls.Add(this.btnListoRequerimientoCompra);
            this.Controls.Add(this.btnCancelarRequerimientoCompra);
            this.Controls.Add(this.pcbcBotonCerrar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnNuevoRequerimientoCompra);
            this.Controls.Add(this.btnAnularRequerimientoCompra);
            this.Controls.Add(this.btnRegistrarRequerimientoCompra);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pcbxFondoMadera);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RequerimientoCompra";
            this.Text = "RequerimientoCompra";
            ((System.ComponentModel.ISupportInitialize)(this.pcbxFondoMadera)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbcBotonCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
 
        private System.Windows.Forms.PictureBox pcbxFondoMadera;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRegistrarRequerimientoCompra;
        private System.Windows.Forms.Button btnAnularRequerimientoCompra;
        private System.Windows.Forms.Button btnNuevoRequerimientoCompra;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pcbcBotonCerrar;
        private System.Windows.Forms.Button btnRegresarRequrimientoCompra;
        private System.Windows.Forms.Button btnListoRequerimientoCompra;
        private System.Windows.Forms.Button btnCancelarRequerimientoCompra;
    }
}