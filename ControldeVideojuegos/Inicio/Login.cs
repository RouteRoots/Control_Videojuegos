using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControldeVideojuegos
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pbBLClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbBLMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btLAceptar_Click(object sender, EventArgs e)
        {
            Menu pr = new Menu();
            pr.Show();
            Login c = new Login();
            c.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
