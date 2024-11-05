using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace KialChikenApp
{
    public partial class MantenedorCliente : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public MantenedorCliente()
        {
            InitializeComponent();
        }

        private void pcbcBotonCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pcbxFondoMadera_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
