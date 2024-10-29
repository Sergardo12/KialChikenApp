namespace KialChikenApp
{
    partial class ComprobanteDeVenta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.gbxIngreseDatos = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dtgvDatosComprobante = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtNombreCliente = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbTipoDeComprobante = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtpFecha = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnRegistrar = new Guna.UI2.WinForms.Guna2Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpHora = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.gbxBuscarComprobante = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnAnular = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtIDComprobante = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1.SuspendLayout();
            this.gbxIngreseDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDatosComprobante)).BeginInit();
            this.gbxBuscarComprobante.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.SandyBrown;
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel1.Location = new System.Drawing.Point(-1, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1140, 88);
            this.guna2Panel1.TabIndex = 0;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(24, 32);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(420, 39);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "COMPROBANTE DE VENTA";
            this.guna2HtmlLabel1.Click += new System.EventHandler(this.guna2HtmlLabel1_Click);
            // 
            // gbxIngreseDatos
            // 
            this.gbxIngreseDatos.Controls.Add(this.dtpHora);
            this.gbxIngreseDatos.Controls.Add(this.btnRegistrar);
            this.gbxIngreseDatos.Controls.Add(this.dtpFecha);
            this.gbxIngreseDatos.Controls.Add(this.cmbTipoDeComprobante);
            this.gbxIngreseDatos.Controls.Add(this.txtNombreCliente);
            this.gbxIngreseDatos.Controls.Add(this.guna2HtmlLabel4);
            this.gbxIngreseDatos.Controls.Add(this.guna2HtmlLabel3);
            this.gbxIngreseDatos.Controls.Add(this.guna2HtmlLabel2);
            this.gbxIngreseDatos.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxIngreseDatos.ForeColor = System.Drawing.Color.Black;
            this.gbxIngreseDatos.Location = new System.Drawing.Point(23, 108);
            this.gbxIngreseDatos.Name = "gbxIngreseDatos";
            this.gbxIngreseDatos.Size = new System.Drawing.Size(630, 246);
            this.gbxIngreseDatos.TabIndex = 1;
            this.gbxIngreseDatos.Text = "Ingrese Datos";
            this.gbxIngreseDatos.Click += new System.EventHandler(this.guna2GroupBox1_Click);
            // 
            // dtgvDatosComprobante
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dtgvDatosComprobante.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dtgvDatosComprobante.BackgroundColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvDatosComprobante.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dtgvDatosComprobante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDatosComprobante.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.Fecha,
            this.Hora,
            this.Tipo});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvDatosComprobante.DefaultCellStyle = dataGridViewCellStyle9;
            this.dtgvDatosComprobante.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvDatosComprobante.Location = new System.Drawing.Point(39, 375);
            this.dtgvDatosComprobante.Name = "dtgvDatosComprobante";
            this.dtgvDatosComprobante.RowHeadersVisible = false;
            this.dtgvDatosComprobante.Size = new System.Drawing.Size(1046, 262);
            this.dtgvDatosComprobante.TabIndex = 2;
            this.dtgvDatosComprobante.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvDatosComprobante.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgvDatosComprobante.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgvDatosComprobante.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgvDatosComprobante.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgvDatosComprobante.ThemeStyle.BackColor = System.Drawing.Color.NavajoWhite;
            this.dtgvDatosComprobante.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvDatosComprobante.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtgvDatosComprobante.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgvDatosComprobante.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvDatosComprobante.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgvDatosComprobante.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDatosComprobante.ThemeStyle.HeaderStyle.Height = 15;
            this.dtgvDatosComprobante.ThemeStyle.ReadOnly = false;
            this.dtgvDatosComprobante.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvDatosComprobante.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvDatosComprobante.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvDatosComprobante.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgvDatosComprobante.ThemeStyle.RowsStyle.Height = 22;
            this.dtgvDatosComprobante.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvDatosComprobante.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(60, 54);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(112, 20);
            this.guna2HtmlLabel2.TabIndex = 0;
            this.guna2HtmlLabel2.Text = "Nombre Cliente";
            this.guna2HtmlLabel2.Click += new System.EventHandler(this.guna2HtmlLabel2_Click);
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(16, 102);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(156, 20);
            this.guna2HtmlLabel3.TabIndex = 1;
            this.guna2HtmlLabel3.Text = "Tipo de Comprobante";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(76, 147);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(96, 20);
            this.guna2HtmlLabel4.TabIndex = 2;
            this.guna2HtmlLabel4.Text = "Fecha y Hora";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreCliente.DefaultText = "";
            this.txtNombreCliente.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNombreCliente.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNombreCliente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombreCliente.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombreCliente.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombreCliente.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNombreCliente.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombreCliente.Location = new System.Drawing.Point(190, 54);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.PasswordChar = '\0';
            this.txtNombreCliente.PlaceholderText = "";
            this.txtNombreCliente.SelectedText = "";
            this.txtNombreCliente.Size = new System.Drawing.Size(248, 29);
            this.txtNombreCliente.TabIndex = 3;
            this.txtNombreCliente.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // cmbTipoDeComprobante
            // 
            this.cmbTipoDeComprobante.BackColor = System.Drawing.Color.Transparent;
            this.cmbTipoDeComprobante.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTipoDeComprobante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDeComprobante.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTipoDeComprobante.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTipoDeComprobante.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbTipoDeComprobante.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbTipoDeComprobante.ItemHeight = 30;
            this.cmbTipoDeComprobante.Items.AddRange(new object[] {
            "Boleta",
            "Factura"});
            this.cmbTipoDeComprobante.Location = new System.Drawing.Point(190, 102);
            this.cmbTipoDeComprobante.Name = "cmbTipoDeComprobante";
            this.cmbTipoDeComprobante.Size = new System.Drawing.Size(140, 36);
            this.cmbTipoDeComprobante.TabIndex = 4;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Checked = true;
            this.dtpFecha.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtpFecha.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpFecha.Location = new System.Drawing.Point(190, 147);
            this.dtpFecha.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFecha.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(222, 36);
            this.dtpFecha.TabIndex = 5;
            this.dtpFecha.Value = new System.DateTime(2024, 10, 29, 4, 50, 32, 888);
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.LightSalmon;
            this.btnRegistrar.BorderThickness = 1;
            this.btnRegistrar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRegistrar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRegistrar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRegistrar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRegistrar.FillColor = System.Drawing.Color.SandyBrown;
            this.btnRegistrar.Font = new System.Drawing.Font("Arial", 15.75F);
            this.btnRegistrar.ForeColor = System.Drawing.Color.Black;
            this.btnRegistrar.Location = new System.Drawing.Point(465, 180);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(137, 45);
            this.btnRegistrar.TabIndex = 3;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            // 
            // Hora
            // 
            this.Hora.HeaderText = "Hora";
            this.Hora.Name = "Hora";
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            // 
            // dtpHora
            // 
            this.dtpHora.Checked = true;
            this.dtpHora.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtpHora.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpHora.Location = new System.Drawing.Point(190, 189);
            this.dtpHora.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpHora.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpHora.Name = "dtpHora";
            this.dtpHora.Size = new System.Drawing.Size(222, 36);
            this.dtpHora.TabIndex = 6;
            this.dtpHora.Value = new System.DateTime(2024, 10, 29, 4, 50, 32, 888);
            // 
            // gbxBuscarComprobante
            // 
            this.gbxBuscarComprobante.Controls.Add(this.txtIDComprobante);
            this.gbxBuscarComprobante.Controls.Add(this.guna2HtmlLabel5);
            this.gbxBuscarComprobante.Controls.Add(this.btnAnular);
            this.gbxBuscarComprobante.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxBuscarComprobante.ForeColor = System.Drawing.Color.Black;
            this.gbxBuscarComprobante.Location = new System.Drawing.Point(674, 176);
            this.gbxBuscarComprobante.Name = "gbxBuscarComprobante";
            this.gbxBuscarComprobante.Size = new System.Drawing.Size(411, 178);
            this.gbxBuscarComprobante.TabIndex = 3;
            this.gbxBuscarComprobante.Text = "Buscar Comprobante";
            // 
            // btnAnular
            // 
            this.btnAnular.BackColor = System.Drawing.Color.LightSalmon;
            this.btnAnular.BorderThickness = 1;
            this.btnAnular.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAnular.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAnular.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAnular.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAnular.FillColor = System.Drawing.Color.SandyBrown;
            this.btnAnular.Font = new System.Drawing.Font("Arial", 15.75F);
            this.btnAnular.ForeColor = System.Drawing.Color.Black;
            this.btnAnular.Location = new System.Drawing.Point(136, 112);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(137, 45);
            this.btnAnular.TabIndex = 7;
            this.btnAnular.Text = "Anular";
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(44, 60);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(118, 20);
            this.guna2HtmlLabel5.TabIndex = 7;
            this.guna2HtmlLabel5.Text = "ID Comprobante";
            // 
            // txtIDComprobante
            // 
            this.txtIDComprobante.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIDComprobante.DefaultText = "";
            this.txtIDComprobante.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIDComprobante.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIDComprobante.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDComprobante.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDComprobante.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDComprobante.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIDComprobante.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDComprobante.Location = new System.Drawing.Point(177, 60);
            this.txtIDComprobante.Name = "txtIDComprobante";
            this.txtIDComprobante.PasswordChar = '\0';
            this.txtIDComprobante.PlaceholderText = "";
            this.txtIDComprobante.SelectedText = "";
            this.txtIDComprobante.Size = new System.Drawing.Size(177, 29);
            this.txtIDComprobante.TabIndex = 7;
            this.txtIDComprobante.TextChanged += new System.EventHandler(this.txtIDComprobante_TextChanged);
            // 
            // ComprobanteDeVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 676);
            this.Controls.Add(this.gbxBuscarComprobante);
            this.Controls.Add(this.dtgvDatosComprobante);
            this.Controls.Add(this.gbxIngreseDatos);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ComprobanteDeVenta";
            this.Text = "ComprobanteDeVenta";
            this.Load += new System.EventHandler(this.ComprobanteDeVenta_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.gbxIngreseDatos.ResumeLayout(false);
            this.gbxIngreseDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDatosComprobante)).EndInit();
            this.gbxBuscarComprobante.ResumeLayout(false);
            this.gbxBuscarComprobante.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2GroupBox gbxIngreseDatos;
        private Guna.UI2.WinForms.Guna2DataGridView dtgvDatosComprobante;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2TextBox txtNombreCliente;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2ComboBox cmbTipoDeComprobante;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpFecha;
        private Guna.UI2.WinForms.Guna2Button btnRegistrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpHora;
        private Guna.UI2.WinForms.Guna2GroupBox gbxBuscarComprobante;
        private Guna.UI2.WinForms.Guna2Button btnAnular;
        private Guna.UI2.WinForms.Guna2TextBox txtIDComprobante;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
    }
}