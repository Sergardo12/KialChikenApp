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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            guna2HtmlLabel2.Parent = guna2PictureBox1;
            guna2HtmlLabel2.BackColor = Color.Transparent;

            guna2HtmlLabel3.Parent = guna2PictureBox1;
            guna2HtmlLabel3.BackColor = Color.Transparent;
        }
    }
    
    
}
