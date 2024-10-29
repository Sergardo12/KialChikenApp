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
    public partial class Insumos : Form
    {
        int posicion;
        public Insumos()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Insumos_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string comestibles = cmbComestibles.SelectedItem.ToString();
            string bebidas = cmbBebidas.SelectedItem.ToString();
            string utencilios = cmbUtencilios.SelectedItem.ToString();
            string produccion = cmbProduccion.SelectedItem.ToString();
            string limpieza = cmbLimpieza.SelectedItem.ToString();
            string unidades = txtUnidades.Text;

            dtgvInsumos.Rows.Add(comestibles, bebidas, utencilios, produccion, limpieza, unidades);

            cmbComestibles.SelectedIndex = -1;
            cmbBebidas.SelectedIndex = -1;
            cmbUtencilios.SelectedIndex = -1;
            cmbProduccion.SelectedIndex = -1;
            cmbLimpieza.SelectedIndex = -1;
            txtUnidades.Clear();
            

        }

        void limpiar()
        {
            cmbComestibles.Text = "";
            cmbBebidas.Text = "";
            cmbUtencilios.Text = "";
            cmbProduccion.Text = "";
            cmbLimpieza.Text = "";
            txtUnidades.Text = "";
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
                foreach(DataGridViewRow row in dtgvInsumos.SelectedRows)
                {
                    dtgvInsumos.Rows.RemoveAt(row.Index);
                }
            
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string comestibles, bebidas, utencilios, produccion, limpieza, unidades;

            comestibles=cmbComestibles.Text;
            bebidas=cmbBebidas.Text;
            utencilios=cmbUtencilios.Text;
            produccion=cmbProduccion.Text;
            limpieza=cmbLimpieza.Text;
            unidades=txtUnidades.Text;

            dtgvInsumos[1, posicion].Value = cmbComestibles.Text;
            dtgvInsumos[2, posicion].Value = cmbBebidas.Text;
            dtgvInsumos[3, posicion].Value = cmbUtencilios.Text;
            dtgvInsumos[4, posicion].Value = cmbProduccion.Text;
            dtgvInsumos[5, posicion].Value = cmbLimpieza.Text;
            dtgvInsumos[6, posicion].Value = txtUnidades.Text;

            limpiar();
            cmbComestibles.Focus();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
