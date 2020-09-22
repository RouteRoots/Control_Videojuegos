using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace ControldeVideojuegos
{
    public partial class Menu : Form
    {
        
        public Menu()
        {
            InitializeComponent();
            InPanel.Height = btInicio.Height;
            InPanel.Top = btInicio.Top;
            pHome1.BringToFront();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void lbId_Click(object sender, EventArgs e)
        {

        }

        private void btREmpleado_Click(object sender, EventArgs e)
        {
            InPanel.Height = btREmpleado.Height;
            InPanel.Top = btREmpleado.Top;
            FVentanas.FEmpleado tEmpleado = new FVentanas.FEmpleado();
            tEmpleado.ShowDialog();



        }

        private void btInicio_Click(object sender, EventArgs e)
        {
            InPanel.Height = btInicio.Height;
            InPanel.Top = btInicio.Top;
            pHome1.BringToFront();
        }

        private void btRComputadoras_Click(object sender, EventArgs e)
        {
            InPanel.Height = btRComputadoras.Height;
            InPanel.Top = btRComputadoras.Top;
            FVentanas.FComputadoras tEmpleado = new FVentanas.FComputadoras();
            tEmpleado.ShowDialog();



        }

        private void btRConsolas_Click(object sender, EventArgs e)
        {
            InPanel.Height = btRConsolas.Height;
            InPanel.Top = btRConsolas.Top;
            FVentanas.FConsolas tEmpleado = new FVentanas.FConsolas();
            tEmpleado.ShowDialog();

        }

        private void btRCombos_Click(object sender, EventArgs e)
        {
            InPanel.Height = btRCombos.Height;
            InPanel.Top = btRCombos.Top;
            FVentanas.FCombos tEmpleado = new FVentanas.FCombos();
            tEmpleado.ShowDialog();

        }

        private void btRInventarios_Click(object sender, EventArgs e)
        {
           
        }

        private void btCCaja_Click(object sender, EventArgs e)
        {
            InPanel.Height = btCCaja.Height;
            InPanel.Top = btCCaja.Top;
            /* try
             {

                 PruebaConexion c = new PruebaConexion();
                 //c.Open();
                 MessageBox.Show("Conectado!!");
             }
             catch (Exception ex)
             {
                 MessageBox.Show("No se Realizo la conexion !!" + ex.ToString());
             }*/


            try
            {

                SqlConnection cn;

                cn = new SqlConnection("Data Source=DESKTOP-0PCN940\\SQLEXPRESS;Initial Catalog=sisCVid;Integrated Security=True");
                cn.Open();
                MessageBox.Show("Conectado!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se Realizo la conexion !!" + ex.ToString());
            }
        }
        

        private void btRVideojuegos_Click(object sender, EventArgs e)
        {
            InPanel.Height = btRVideojuegos.Height;
            InPanel.Top = btRVideojuegos.Top;
            FVentanas.FVideojuegos tEmpleado = new FVentanas.FVideojuegos();
            tEmpleado.ShowDialog();

        }

        private void InPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pMClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
