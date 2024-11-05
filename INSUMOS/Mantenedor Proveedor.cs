﻿using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace KialChikenApp
{
    public partial class Form1 : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public Form1()
        {
            InitializeComponent();

        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }




        private void pcbcBotonCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void pcbxFondoMadera_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pcbxFondoMadera_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}