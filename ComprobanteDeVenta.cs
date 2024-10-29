using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace KialChikenApp
{
    public partial class ComprobanteDeVenta : Form
    {
        int contadorID = 1;
        public ComprobanteDeVenta()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            dtpFecha.Format = DateTimePickerFormat.Short; 
            dtpFecha.Value = DateTime.Now; 
            dtpHora.Format = DateTimePickerFormat.Time; 
            dtpHora.CustomFormat = "hh:mm tt"; 
            dtpHora.ShowUpDown = true; 
            dtpHora.Value = DateTime.Now; 
            cmbTipoDeComprobante.DropDownStyle = ComboBoxStyle.DropDownList;
            txtNombreCliente.MaxLength = 30;
            txtIDComprobante.MaxLength = 7;
            txtNombreCliente.KeyPress += new KeyPressEventHandler(txtNombreCliente_KeyPress);
            txtIDComprobante.KeyPress += new KeyPressEventHandler(txtIDComprobante_KeyPress);
            txtIDComprobante.TextChanged += new EventHandler(txtIDComprobante_TextChanged);
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void txtNombreCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true; 
            }
        }
        private void txtIDComprobante_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true; 
            }
        }
        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComprobanteDeVenta_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreCliente.Text) || cmbTipoDeComprobante.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            // Generar el código de 7 dígitos
            string codigoID = "C" + contadorID.ToString("D6"); // Ejemplo: C000001, C000002, etc.

            string nombreCliente = txtNombreCliente.Text;
            string fechaComprobante = dtpFecha.Value.ToShortDateString(); 
            string horaComprobante = dtpHora.Value.ToString("hh:mm tt"); 
            string tipoComprobante = cmbTipoDeComprobante.SelectedItem.ToString();

            // Agregar datos al DataGridView
            dtgvDatosComprobante.Rows.Add(codigoID, nombreCliente, fechaComprobante, horaComprobante, tipoComprobante);

            // Incrementar el contadorID para el próximo código generado
            contadorID++;

            // Limpiar los campos después de registrar
            txtNombreCliente.Clear();
            cmbTipoDeComprobante.SelectedIndex = -1;
            dtpFecha.Value = DateTime.Now; // Reiniciar a la fecha actual
            dtpHora.Value = DateTime.Now; // Reiniciar a la hora actual
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            // Verificar que el ID ingresado sea válido
            if (!IsValidID(txtIDComprobante.Text))
            {
                MessageBox.Show("El ID de comprobante debe ser de 7 caracteres: una letra seguida de 6 números.");
                return;
            }

            string idComprobante = txtIDComprobante.Text;

            // Buscar el ID en el DataGridView
            foreach (DataGridViewRow row in dtgvDatosComprobante.Rows)
            {
                if (row.Cells[0].Value.ToString() == idComprobante) // Suponiendo que el ID está en la primera columna
                {
                    // Eliminar la fila del DataGridView
                    dtgvDatosComprobante.Rows.Remove(row);
                    MessageBox.Show("Comprobante anulado correctamente.");
                    txtIDComprobante.Clear(); // Limpiar el campo de ID
                    return;
                }
            }

            MessageBox.Show("Comprobante no encontrado.");
        }

        private bool IsValidID(string id)
        {
            // Verifica que el ID tenga exactamente 7 caracteres, el primero sea letra y los demás números
            return Regex.IsMatch(id, @"^[A-Za-z]\d{6}$");
        }

        private void txtIDComprobante_TextChanged(object sender, EventArgs e)
        {
             // Asegurarse de que el ID tenga exactamente 7 caracteres
            if (txtIDComprobante.Text.Length > 7)
            {
                txtIDComprobante.Text = txtIDComprobante.Text.Substring(0, 7); // Limita a 7 caracteres
                txtIDComprobante.SelectionStart = txtIDComprobante.Text.Length; // Mueve el cursor al final
            }
        }
    }
}
