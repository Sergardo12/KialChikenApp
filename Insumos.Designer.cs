namespace KialChikenApp
{
    partial class Insumos
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvInsumos = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbComestibles = new System.Windows.Forms.ComboBox();
            this.cmbUtencilios = new System.Windows.Forms.ComboBox();
            this.cmbBebidas = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbProduccion = new System.Windows.Forms.ComboBox();
            this.cmbLimpieza = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtUnidades = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Comestibles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bebidas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Utencilios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Limpieza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unidades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvInsumos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(421, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insumos";
            // 
            // dtgvInsumos
            // 
            this.dtgvInsumos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvInsumos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Comestibles,
            this.Bebidas,
            this.Utencilios,
            this.Produccion,
            this.Limpieza,
            this.Unidades});
            this.dtgvInsumos.Location = new System.Drawing.Point(21, 351);
            this.dtgvInsumos.Name = "dtgvInsumos";
            this.dtgvInsumos.RowHeadersWidth = 51;
            this.dtgvInsumos.RowTemplate.Height = 24;
            this.dtgvInsumos.Size = new System.Drawing.Size(979, 274);
            this.dtgvInsumos.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(204, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Bebidas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Comestibles";
            // 
            // cmbComestibles
            // 
            this.cmbComestibles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbComestibles.FormattingEnabled = true;
            this.cmbComestibles.Items.AddRange(new object[] {
            "Pollo",
            "Papa",
            "Lechuga",
            "Tomate",
            "Vinagreta",
            "Limón",
            "Beterraga",
            "Palta",
            "Zanahoria",
            "Pepinillo",
            "Sal",
            "Aceite",
            "Mayonesa Procesada"});
            this.cmbComestibles.Location = new System.Drawing.Point(21, 84);
            this.cmbComestibles.Name = "cmbComestibles";
            this.cmbComestibles.Size = new System.Drawing.Size(144, 33);
            this.cmbComestibles.TabIndex = 12;
            // 
            // cmbUtencilios
            // 
            this.cmbUtencilios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUtencilios.FormattingEnabled = true;
            this.cmbUtencilios.Items.AddRange(new object[] {
            "Cuchara",
            "Tenedor",
            "Cuchillo",
            "Plato Fuente",
            "Plato Personal",
            "Tarrito",
            "Vaso",
            "Tazón",
            "Jarra",
            "Dispensador Servilletas"});
            this.cmbUtencilios.Location = new System.Drawing.Point(408, 84);
            this.cmbUtencilios.Name = "cmbUtencilios";
            this.cmbUtencilios.Size = new System.Drawing.Size(144, 33);
            this.cmbUtencilios.TabIndex = 13;
            // 
            // cmbBebidas
            // 
            this.cmbBebidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBebidas.FormattingEnabled = true;
            this.cmbBebidas.Items.AddRange(new object[] {
            "Coca Cola",
            "Inca Cola",
            "Fanta",
            "Chicha",
            "Sprite",
            "Limonada",
            "Maracuyá",
            "Agua"});
            this.cmbBebidas.Location = new System.Drawing.Point(209, 84);
            this.cmbBebidas.Name = "cmbBebidas";
            this.cmbBebidas.Size = new System.Drawing.Size(144, 33);
            this.cmbBebidas.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(403, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Utencilios";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "Produccion";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // cmbProduccion
            // 
            this.cmbProduccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProduccion.FormattingEnabled = true;
            this.cmbProduccion.Items.AddRange(new object[] {
            "Balón De Gas",
            "Carbón"});
            this.cmbProduccion.Location = new System.Drawing.Point(21, 196);
            this.cmbProduccion.Name = "cmbProduccion";
            this.cmbProduccion.Size = new System.Drawing.Size(144, 33);
            this.cmbProduccion.TabIndex = 17;
            this.cmbProduccion.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // cmbLimpieza
            // 
            this.cmbLimpieza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLimpieza.FormattingEnabled = true;
            this.cmbLimpieza.Items.AddRange(new object[] {
            "Balón De Gas",
            "Carbón",
            "Lavavajilla",
            "Esponja",
            "Insecticida",
            "Detergente",
            "Limpio Vidrio",
            "Lejía",
            "Limpiador De Acero Inoxidable",
            "Desinfectante"});
            this.cmbLimpieza.Location = new System.Drawing.Point(209, 196);
            this.cmbLimpieza.Name = "cmbLimpieza";
            this.cmbLimpieza.Size = new System.Drawing.Size(144, 33);
            this.cmbLimpieza.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(204, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 25);
            this.label7.TabIndex = 19;
            this.label7.Text = "Limpieza";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbLimpieza);
            this.groupBox1.Controls.Add(this.cmbComestibles);
            this.groupBox1.Controls.Add(this.cmbProduccion);
            this.groupBox1.Controls.Add(this.cmbUtencilios);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbBebidas);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(71, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(577, 243);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo De Insumos";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtUnidades);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(667, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(283, 154);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cantidad";
            // 
            // txtUnidades
            // 
            this.txtUnidades.Location = new System.Drawing.Point(24, 87);
            this.txtUnidades.Name = "txtUnidades";
            this.txtUnidades.Size = new System.Drawing.Size(144, 30);
            this.txtUnidades.TabIndex = 15;
            this.txtUnidades.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Unidades";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(691, 251);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(114, 34);
            this.btnGuardar.TabIndex = 22;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(754, 291);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(114, 34);
            this.btnEliminar.TabIndex = 23;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(811, 251);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(114, 34);
            this.btnModificar.TabIndex = 24;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SandyBrown;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-4, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1057, 75);
            this.panel1.TabIndex = 25;
            // 
            // Comestibles
            // 
            this.Comestibles.HeaderText = "Comestibles";
            this.Comestibles.MinimumWidth = 6;
            this.Comestibles.Name = "Comestibles";
            this.Comestibles.Width = 125;
            // 
            // Bebidas
            // 
            this.Bebidas.HeaderText = "Bebidas";
            this.Bebidas.MinimumWidth = 6;
            this.Bebidas.Name = "Bebidas";
            this.Bebidas.Width = 125;
            // 
            // Utencilios
            // 
            this.Utencilios.HeaderText = "Utencilios";
            this.Utencilios.MinimumWidth = 6;
            this.Utencilios.Name = "Utencilios";
            this.Utencilios.Width = 125;
            // 
            // Produccion
            // 
            this.Produccion.HeaderText = "Produccion";
            this.Produccion.MinimumWidth = 6;
            this.Produccion.Name = "Produccion";
            this.Produccion.Width = 125;
            // 
            // Limpieza
            // 
            this.Limpieza.HeaderText = "Limpieza";
            this.Limpieza.MinimumWidth = 6;
            this.Limpieza.Name = "Limpieza";
            this.Limpieza.Width = 125;
            // 
            // Unidades
            // 
            this.Unidades.HeaderText = "Unidades";
            this.Unidades.MinimumWidth = 6;
            this.Unidades.Name = "Unidades";
            this.Unidades.Width = 125;
            // 
            // Insumos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 677);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtgvInsumos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Insumos";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Insumos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvInsumos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvInsumos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbComestibles;
        private System.Windows.Forms.ComboBox cmbUtencilios;
        private System.Windows.Forms.ComboBox cmbBebidas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbProduccion;
        private System.Windows.Forms.ComboBox cmbLimpieza;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUnidades;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comestibles;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bebidas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Utencilios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Limpieza;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidades;
    }
}