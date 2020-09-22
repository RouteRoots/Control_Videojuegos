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
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

       
        


        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (panel2.Width < 324)
            {
                panel2.Width = panel2.Width + 4;
            }
            else
            {
                timer1.Stop();
                this.Hide();
                Login pr = new Login();
                pr.Show();
            }
        }

        private void Splash_Load(object sender, EventArgs e)
        {

        }
    }
}
