using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControldeVideojuegos.FVentanas
{
    public partial class FComputadoras : Form
    {
        public FComputadoras()
        {
            InitializeComponent();
        }

        

        private void FComputadoras_Load(object sender, EventArgs e)
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

            if (MConputadora.Modificar(pComputadora, ComputadoraActual().IdComputadora) > 0)
            {
                MessageBox.Show("Datos Modificados!!");
                limpiar();


                pbtComBorrar.Enabled = false;
                pbtComNuevo.Enabled = true;
                pbtComGuardar.Enabled = true;
            }
        }

        private void limpiar()
        {
            throw new NotImplementedException();
        }

        private object ComputadoraActual()
        {
            throw new NotImplementedException();
        }
    }
}
