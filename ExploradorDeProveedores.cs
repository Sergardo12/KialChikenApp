using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KialChikenApp
{
    public partial class Form1 : Form
    {
        // Variable global para almacenar el último ID generado
        private int Códigos = 1;
   
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Centrar el formulario
            dtgvDatosProveedor.ReadOnly = true; // Hacer el DataGridView solo lectura

            // Establece que el ComboBox no permite escribir
            cmbServicio.DropDownStyle = ComboBoxStyle.DropDownList;

            // Suscribir eventos
            txtNombre.KeyPress += new KeyPressEventHandler(txtNombre_KeyPress);
            txtNombre.TextChanged += new EventHandler(txtNombre_TextChanged);
            txtApellidos.KeyPress += new KeyPressEventHandler(txtApellidos_KeyPress);
            txtApellidos.TextChanged += new EventHandler(txtApellidos_TextChanged);
            txtTeléfono.KeyPress += new KeyPressEventHandler(txtTeléfono_KeyPress);
            txtTeléfono.TextChanged += new EventHandler(txtTeléfono_TextChanged);
            txtDirección.KeyPress += new KeyPressEventHandler(txtDirección_KeyPress);
            txtDirección.TextChanged += new EventHandler(txtDirección_TextChanged);
        }

        private void btnAGREGAR_Click_1(object sender, EventArgs e)
        {
            // Verifica que todos los campos estén llenos
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellidos.Text) ||
                string.IsNullOrWhiteSpace(txtTeléfono.Text) ||
                string.IsNullOrWhiteSpace(txtDirección.Text) ||
                cmbServicio.SelectedIndex == -1) // Verifica que se haya seleccionado un servicio
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            // Verifica que el teléfono tenga exactamente 9 dígitos
            if (txtTeléfono.Text.Length != 9)
            {
                MessageBox.Show("El número de teléfono debe ser de 9 dígitos.");
                return;
            }

            // Generar el ID secuencial
            if (Códigos < 99999)// Verifica que el ID no sobrepase 99999

            {
                string Código = Códigos.ToString("D5"); // Convierte el número a un formato de 5 dígitos

                // Obtener los datos de los textboxes y combobox
                string nombre = txtNombre.Text;
                string apellidos = txtApellidos.Text;
                string telefono = txtTeléfono.Text;
                string direccion = txtDirección.Text;
                string servicio = cmbServicio.SelectedItem.ToString();


                // Validar que los campos no estén vacíos
                if (!string.IsNullOrWhiteSpace(nombre) && !string.IsNullOrWhiteSpace(apellidos) &&
                    !string.IsNullOrWhiteSpace(telefono) && !string.IsNullOrWhiteSpace(direccion) &&
                    !string.IsNullOrEmpty(servicio))

                // Agregar los datos al DataGridView
                dtgvDatosProveedor.Rows.Add(Código, nombre, apellidos, telefono, direccion, servicio);

                Códigos++;

                // Limpiar los campos después de agregar
                txtNombre.Clear();
                txtApellidos.Clear();
                txtTeléfono.Clear();
                txtDirección.Clear();
                cmbServicio.SelectedIndex = -1; 
            }
            else
            {
                MessageBox.Show("El ID máximo (00999) ha sido alcanzado.");
            }
        }

        private void btnMODIFICAR_Click(object sender, EventArgs e)
        {
            string idProveedorBuscar = txtCódigo.Text;

            // Validar que el ID ingresado tenga exactamente 5 dígitos
            if (idProveedorBuscar.Length != 5)
            {
                MessageBox.Show("Por favor, ingrese un ID de proveedor válido de 5 dígitos.");
                return;
            }

            // Buscar el proveedor en el DataGridView
            foreach (DataGridViewRow row in dtgvDatosProveedor.Rows)
            {
                if (row.Cells[0].Value?.ToString() == idProveedorBuscar) // Compara con el código del proveedor
                {
                    txtNombre.Text = row.Cells[1].Value.ToString();
                    txtApellidos.Text = row.Cells[2].Value.ToString();
                    txtTeléfono.Text = row.Cells[3].Value.ToString();
                    txtDirección.Text = row.Cells[4].Value.ToString();
                    cmbServicio.SelectedItem = row.Cells[5].Value.ToString();
                    return;
                }
            }

            MessageBox.Show("Proveedor no encontrado.");
        }

        private void dtgvDatosProveedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtTeléfono_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números y controlar que no se ingresen más de 9 dígitos
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            // Evitar que se ingresen más de 9 dígitos
            if (txtTeléfono.Text.Length >= 9 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTeléfono_TextChanged(object sender, EventArgs e)
        {
            // Verifica que el texto tenga solo 9 dígitos y elimina cualquier espacio
            txtTeléfono.Text = txtTeléfono.Text.Trim(); // Elimina cualquier espacio accidental
            if (txtTeléfono.Text.Length > 9)
            {
                txtTeléfono.Text = txtTeléfono.Text.Substring(9); // Limita a 9 caracteres
                txtTeléfono.SelectionStart = txtTeléfono.Text.Length; // Mantiene el cursor al final del texto
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo letras, espacios y el retroceso
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true; 
            }
        }
        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text.Length > 30)
            {
                txtNombre.Text = txtNombre.Text.Substring(0, 30); 
                txtNombre.SelectionStart = txtNombre.Text.Length; 
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo letras, espacios y el retroceso
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true; 
            }
        }

        private void txtApellidos_TextChanged(object sender, EventArgs e)
        {
            if (txtApellidos.Text.Length > 30)
            {
                txtApellidos.Text = txtApellidos.Text.Substring(0, 30); 
                txtApellidos.SelectionStart = txtApellidos.Text.Length; 
            }
        }

        private void txtDirección_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir letras, dígitos y el retroceso
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true; 
            }
        }

        private void txtDirección_TextChanged(object sender, EventArgs e)
        {
            if (txtDirección.Text.Length > 50)
            {
                txtDirección.Text = txtDirección.Text.Substring(0, 50); 
                txtDirección.SelectionStart = txtDirección.Text.Length; 
            }
        }

        private void btnModificarProveedor_Click(object sender, EventArgs e)
        {
            string idProveedorModificar = txtCódigo.Text;

            // Validar que el ID ingresado tenga exactamente 5 dígitos
            if (idProveedorModificar.Length != 5)
            {
                MessageBox.Show("Por favor, ingrese un ID de proveedor válido de 5 dígitos.");
                return;
            }

            // Buscar el proveedor en el DataGridView
            foreach (DataGridViewRow row in dtgvDatosProveedor.Rows)
            {
                if (row.Cells[0].Value?.ToString() == idProveedorModificar) // Compara con el código del proveedor
                {
                    // Actualizar los datos en el DataGridView sin modificar el código
                    row.Cells[1].Value = txtNombre.Text; // Actualiza nombre
                    row.Cells[2].Value = txtApellidos.Text; // Actualiza apellidos
                    row.Cells[3].Value = txtTeléfono.Text; // Actualiza teléfono
                    row.Cells[4].Value = txtDirección.Text; // Actualiza dirección
                    row.Cells[5].Value = cmbServicio.SelectedItem.ToString(); // Actualiza servicio
                    MessageBox.Show("Datos del proveedor modificados con éxito.");
                    return;
                }
            }

            MessageBox.Show("Proveedor no encontrado.");
        }

        private void txtCódigo_TextChanged(object sender, EventArgs e)
        {
            // Limitar a 5 dígitos y evitar espacios
            if (txtCódigo.Text.Length > 5)
            {
                txtCódigo.Text = txtCódigo.Text.Substring(0, 5);
            }
            txtCódigo.Text = txtCódigo.Text.Trim(); // Elimina espacios en blanco
        }

        private void btnEliminarProveedor_Click(object sender, EventArgs e)
        {
            string idProveedorEliminar = txtCódigo.Text;

            // Validar que el ID ingresado tenga exactamente 5 dígitos
            if (idProveedorEliminar.Length != 5)
            {
                MessageBox.Show("Por favor, ingrese un ID de proveedor válido de 5 dígitos.");
                return;
            }

            // Buscar el proveedor en el DataGridView
            foreach (DataGridViewRow row in dtgvDatosProveedor.Rows)
            {
                if (row.Cells[0].Value?.ToString() == idProveedorEliminar) // Compara con el código del proveedor
                {
                    dtgvDatosProveedor.Rows.Remove(row); // Elimina la fila del proveedor
                    MessageBox.Show("Proveedor eliminado con éxito.");
                    return;
                }
            }

            MessageBox.Show("Proveedor no encontrado.");
        }
    }
}