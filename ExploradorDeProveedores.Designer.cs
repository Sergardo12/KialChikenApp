namespace KialChikenApp
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pcbxFondoMadera = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDniProveedor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxProveedor = new System.Windows.Forms.ComboBox();
            this.txtDireccionProveedor = new System.Windows.Forms.TextBox();
            this.txtTelefonoProveedor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpkFechaProveedor = new System.Windows.Forms.DateTimePicker();
            this.txtNombreProveedor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvProveedores = new System.Windows.Forms.DataGridView();
            this.btnModificarProveedor = new System.Windows.Forms.Button();
            this.btnAgregarProveedor = new System.Windows.Forms.Button();
            this.btnEditarProveedor = new System.Windows.Forms.Button();
            this.btnNuevoProveedor = new System.Windows.Forms.Button();
            this.btnListoProveedor = new System.Windows.Forms.Button();
            this.btnCancelarProveedor = new System.Windows.Forms.Button();
            this.btnRegresarProveedor = new System.Windows.Forms.Button();
            this.pcbcBotonCerrar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxFondoMadera)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbcBotonCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbxFondoMadera
            // 
            this.pcbxFondoMadera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcbxFondoMadera.Image = ((System.Drawing.Image)(resources.GetObject("pcbxFondoMadera.Image")));
            this.pcbxFondoMadera.Location = new System.Drawing.Point(0, 0);
            this.pcbxFondoMadera.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.pcbxFondoMadera.Name = "pcbxFondoMadera";
            this.pcbxFondoMadera.Size = new System.Drawing.Size(1200, 1102);
            this.pcbxFondoMadera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbxFondoMadera.TabIndex = 29;
            this.pcbxFondoMadera.TabStop = false;
            this.pcbxFondoMadera.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pcbxFondoMadera_MouseDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDniProveedor);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbxProveedor);
            this.groupBox1.Controls.Add(this.txtDireccionProveedor);
            this.groupBox1.Controls.Add(this.txtTelefonoProveedor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpkFechaProveedor);
            this.groupBox1.Controls.Add(this.txtNombreProveedor);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(53, 119);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(660, 395);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de insumos:";
            // 
            // txtDniProveedor
            // 
            this.txtDniProveedor.Location = new System.Drawing.Point(153, 153);
            this.txtDniProveedor.Name = "txtDniProveedor";
            this.txtDniProveedor.Size = new System.Drawing.Size(255, 28);
            this.txtDniProveedor.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 21);
            this.label7.TabIndex = 12;
            this.label7.Text = "DNI:";
            // 
            // cbxProveedor
            // 
            this.cbxProveedor.FormattingEnabled = true;
            this.cbxProveedor.Location = new System.Drawing.Point(153, 205);
            this.cbxProveedor.Name = "cbxProveedor";
            this.cbxProveedor.Size = new System.Drawing.Size(255, 29);
            this.cbxProveedor.TabIndex = 11;
            // 
            // txtDireccionProveedor
            // 
            this.txtDireccionProveedor.Location = new System.Drawing.Point(153, 254);
            this.txtDireccionProveedor.Name = "txtDireccionProveedor";
            this.txtDireccionProveedor.Size = new System.Drawing.Size(255, 28);
            this.txtDireccionProveedor.TabIndex = 10;
            // 
            // txtTelefonoProveedor
            // 
            this.txtTelefonoProveedor.Location = new System.Drawing.Point(153, 107);
            this.txtTelefonoProveedor.Name = "txtTelefonoProveedor";
            this.txtTelefonoProveedor.Size = new System.Drawing.Size(255, 28);
            this.txtTelefonoProveedor.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Direccion:";
            // 
            // dtpkFechaProveedor
            // 
            this.dtpkFechaProveedor.Location = new System.Drawing.Point(153, 301);
            this.dtpkFechaProveedor.Name = "dtpkFechaProveedor";
            this.dtpkFechaProveedor.Size = new System.Drawing.Size(255, 28);
            this.dtpkFechaProveedor.TabIndex = 7;
            // 
            // txtNombreProveedor
            // 
            this.txtNombreProveedor.Location = new System.Drawing.Point(153, 58);
            this.txtNombreProveedor.Name = "txtNombreProveedor";
            this.txtNombreProveedor.Size = new System.Drawing.Size(255, 28);
            this.txtNombreProveedor.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 21);
            this.label6.TabIndex = 3;
            this.label6.Text = "Fecha:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "Servicio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Teléfono:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(398, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(454, 40);
            this.label1.TabIndex = 33;
            this.label1.Text = "Explorador de Proveedores";
            // 
            // dtgvProveedores
            // 
            this.dtgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvProveedores.Location = new System.Drawing.Point(53, 561);
            this.dtgvProveedores.Name = "dtgvProveedores";
            this.dtgvProveedores.RowHeadersWidth = 51;
            this.dtgvProveedores.RowTemplate.Height = 24;
            this.dtgvProveedores.Size = new System.Drawing.Size(660, 386);
            this.dtgvProveedores.TabIndex = 34;
            // 
            // btnModificarProveedor
            // 
            this.btnModificarProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(61)))), ((int)(((byte)(20)))));
            this.btnModificarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarProveedor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModificarProveedor.Location = new System.Drawing.Point(1004, 295);
            this.btnModificarProveedor.Name = "btnModificarProveedor";
            this.btnModificarProveedor.Size = new System.Drawing.Size(124, 46);
            this.btnModificarProveedor.TabIndex = 39;
            this.btnModificarProveedor.Text = "Modificar";
            this.btnModificarProveedor.UseVisualStyleBackColor = false;
            // 
            // btnAgregarProveedor
            // 
            this.btnAgregarProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(61)))), ((int)(((byte)(20)))));
            this.btnAgregarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProveedor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregarProveedor.Location = new System.Drawing.Point(1004, 216);
            this.btnAgregarProveedor.Name = "btnAgregarProveedor";
            this.btnAgregarProveedor.Size = new System.Drawing.Size(124, 46);
            this.btnAgregarProveedor.TabIndex = 38;
            this.btnAgregarProveedor.Text = "Agregar";
            this.btnAgregarProveedor.UseVisualStyleBackColor = false;
            // 
            // btnEditarProveedor
            // 
            this.btnEditarProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(61)))), ((int)(((byte)(20)))));
            this.btnEditarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarProveedor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarProveedor.Location = new System.Drawing.Point(799, 295);
            this.btnEditarProveedor.Name = "btnEditarProveedor";
            this.btnEditarProveedor.Size = new System.Drawing.Size(124, 46);
            this.btnEditarProveedor.TabIndex = 37;
            this.btnEditarProveedor.Text = "Editar";
            this.btnEditarProveedor.UseVisualStyleBackColor = false;
            // 
            // btnNuevoProveedor
            // 
            this.btnNuevoProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(147)))), ((int)(((byte)(54)))));
            this.btnNuevoProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoProveedor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevoProveedor.Location = new System.Drawing.Point(799, 216);
            this.btnNuevoProveedor.Name = "btnNuevoProveedor";
            this.btnNuevoProveedor.Size = new System.Drawing.Size(124, 46);
            this.btnNuevoProveedor.TabIndex = 36;
            this.btnNuevoProveedor.Text = "Nuevo";
            this.btnNuevoProveedor.UseVisualStyleBackColor = false;
            // 
            // btnListoProveedor
            // 
            this.btnListoProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(147)))), ((int)(((byte)(54)))));
            this.btnListoProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListoProveedor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnListoProveedor.Location = new System.Drawing.Point(1048, 1001);
            this.btnListoProveedor.Name = "btnListoProveedor";
            this.btnListoProveedor.Size = new System.Drawing.Size(124, 46);
            this.btnListoProveedor.TabIndex = 41;
            this.btnListoProveedor.Text = "Listo";
            this.btnListoProveedor.UseVisualStyleBackColor = false;
            // 
            // btnCancelarProveedor
            // 
            this.btnCancelarProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.btnCancelarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarProveedor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelarProveedor.Location = new System.Drawing.Point(852, 1001);
            this.btnCancelarProveedor.Name = "btnCancelarProveedor";
            this.btnCancelarProveedor.Size = new System.Drawing.Size(124, 46);
            this.btnCancelarProveedor.TabIndex = 40;
            this.btnCancelarProveedor.Text = "Cancelar";
            this.btnCancelarProveedor.UseVisualStyleBackColor = false;
            // 
            // btnRegresarProveedor
            // 
            this.btnRegresarProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(147)))), ((int)(((byte)(54)))));
            this.btnRegresarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresarProveedor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegresarProveedor.Location = new System.Drawing.Point(12, 1021);
            this.btnRegresarProveedor.Name = "btnRegresarProveedor";
            this.btnRegresarProveedor.Size = new System.Drawing.Size(124, 46);
            this.btnRegresarProveedor.TabIndex = 42;
            this.btnRegresarProveedor.Text = "Regresar";
            this.btnRegresarProveedor.UseVisualStyleBackColor = false;
            // 
            // pcbcBotonCerrar
            // 
            this.pcbcBotonCerrar.BackColor = System.Drawing.Color.Transparent;
            this.pcbcBotonCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbcBotonCerrar.Image = ((System.Drawing.Image)(resources.GetObject("pcbcBotonCerrar.Image")));
            this.pcbcBotonCerrar.Location = new System.Drawing.Point(1175, 0);
            this.pcbcBotonCerrar.Name = "pcbcBotonCerrar";
            this.pcbcBotonCerrar.Size = new System.Drawing.Size(25, 25);
            this.pcbcBotonCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbcBotonCerrar.TabIndex = 43;
            this.pcbcBotonCerrar.TabStop = false;
            this.pcbcBotonCerrar.Click += new System.EventHandler(this.pcbcBotonCerrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 1102);
            this.Controls.Add(this.pcbcBotonCerrar);
            this.Controls.Add(this.btnRegresarProveedor);
            this.Controls.Add(this.btnListoProveedor);
            this.Controls.Add(this.btnCancelarProveedor);
            this.Controls.Add(this.btnModificarProveedor);
            this.Controls.Add(this.btnAgregarProveedor);
            this.Controls.Add(this.btnEditarProveedor);
            this.Controls.Add(this.btnNuevoProveedor);
            this.Controls.Add(this.dtgvProveedores);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pcbxFondoMadera);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "A";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbxFondoMadera)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbcBotonCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pcbxFondoMadera;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxProveedor;
        private System.Windows.Forms.TextBox txtDireccionProveedor;
        private System.Windows.Forms.TextBox txtTelefonoProveedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpkFechaProveedor;
        private System.Windows.Forms.TextBox txtNombreProveedor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvProveedores;
        private System.Windows.Forms.Button btnModificarProveedor;
        private System.Windows.Forms.Button btnAgregarProveedor;
        private System.Windows.Forms.Button btnEditarProveedor;
        private System.Windows.Forms.Button btnNuevoProveedor;
        private System.Windows.Forms.Button btnListoProveedor;
        private System.Windows.Forms.Button btnCancelarProveedor;
        private System.Windows.Forms.Button btnRegresarProveedor;
        private System.Windows.Forms.PictureBox pcbcBotonCerrar;
        private System.Windows.Forms.TextBox txtDniProveedor;
        private System.Windows.Forms.Label label7;
    }
}

