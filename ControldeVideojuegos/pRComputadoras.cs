using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace ControldeVideojuegos
{
    public partial class pRComputadoras : UserControl
    {
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;

        public pRComputadoras()
        {
            InitializeComponent();
        }
        

        private void pRComputadoras_Load(object sender, EventArgs e)
        {
            
        }

        private void pbtComNuevo_Click(object sender, EventArgs e)
        {
            Computadora pComputadora = new Computadora();
            pComputadora.IdComputadora = Convert.ToInt32(tbRComId.Text);
            pComputadora.Marca = tbRComMarca.Text;
            pComputadora.Capasidad = tbRComCapasidad.Text;
            pComputadora.MemoriaRam = tbRComMRam.Text;
            pComputadora.Procesador = tbRComProsesador.Text;
            pComputadora.Año = tbRComAnio.Text;
            pComputadora.Estado = tbRComEstado.Text;
            pComputadora.Disponibilidad = tbRComDisponibilidad.Text;

            if (MConputadora.Modificar(pComputadora, ComputadoraActual.IdComputadora) > 0)
            {
                MessageBox.Show("Datos Modificados!!");
                limpiar();
               

                pbtComBorrar.Enabled = false;
                pbtComNuevo.Enabled = true;
                pbtComGuardar.Enabled = true;
            }
        }

        void limpiar()
        {
            tbRComId.Clear();
            tbRComMarca.Clear();
            tbRComCapasidad.Clear();
            tbRComMRam.Clear();
            tbRComProsesador.Clear();
            tbRComAnio.Clear();
            tbRComEstado.Clear();
            tbRComDisponibilidad.Clear();
        }

        private void pbtComBorrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea eliminar el Cliente??", "Esta seguro?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                object ComputadoraActual = null;
                int resultado = MConputadora.Eliminar(ComputadoraActual.IdComputadora);

                if (resultado > 0)
                {

                    MessageBox.Show("Computadora Eliminado Correctamente", "Computadora Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();
                   
                    pbtComBorrar.Enabled = false;
                    pbtComNuevo.Enabled = false;
                    pbtComGuardar.Enabled = true;
                }

                else
                {
                    MessageBox.Show("No se pudo Eliminar el Computadora", "Ocurrio un error!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            else
                MessageBox.Show("Se cancelo la eliminacion", "Cancelado");
        }

        private void pbtComGuardar_Click(object sender, EventArgs e)
        {
            Computadora pComputadora = new Computadora();
            pComputadora.IdComputadora = Convert.ToInt32(tbRComId.Text);
            pComputadora.Marca = tbRComMarca.Text;
            pComputadora.Capasidad = tbRComCapasidad.Text;
            pComputadora.MemoriaRam = tbRComMRam.Text;
            pComputadora.Procesador = tbRComProsesador.Text;
            pComputadora.Año = tbRComAnio.Text;
            pComputadora.Estado = tbRComEstado.Text;
            pComputadora.Disponibilidad = tbRComDisponibilidad.Text;

            if (MConputadora.Agregar(pComputadora) > 0)
            {
                MessageBox.Show("Computadora agregado", "Guardado!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();
            }
        }

        private void pbtComBuscar_Click(object sender, EventArgs e)
        {

        }

        private void pbtComActualizar_Click(object sender, EventArgs e)
        {
            SqlConnection cm;

            cm = new SqlConnection("Data Source=DESKTOP-0PCN940\\SQLEXPRESS;Initial Catalog=sisCVid;Integrated Security=True");
            sda = new SqlDataAdapter("Select IdComputadora , Marca , Capasidad , MemoriaRam, Procesador, Año, Estado, Disponibilidad from Computadora ", cm);
            dt = new DataTable();
            sda.Fill(dt);
            computadoraDataGridView1.DataSource = dt;
            scb = new SqlCommandBuilder(sda);
            sda.Update(dt);
        }

        private void computadoraBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.computadoraBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sisCVidDataSet);

        }
    }
}
