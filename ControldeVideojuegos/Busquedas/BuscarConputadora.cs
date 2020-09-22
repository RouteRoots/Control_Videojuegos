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
    public partial class BuscarConputadora : Form
    {
        public BuscarConputadora()
        {
            InitializeComponent();
        }

        private void BuscarConputadora_Load(object sender, EventArgs e)
        {

        }

        private Computadora computadoraSeleccionada;

        public Empleado ComputadoraSeleccionada { get; private set; }

        private void pbRCompBuscar_Click(object sender, EventArgs e)
        {
            computadoraDataGridView.DataSource = MConputadora.BuscarComputadora(Convert.ToInt32(tbBCompBuscar.Text)); //llenamos el data con los datos obtenidos 
                                                                                                                      //de la busqueda por el NumCliente digitado
        }

        private void btBComp_Click(object sender, EventArgs e)
        {
            if (computadoraDataGridView.SelectedRows.Count == 1) // si selecciona un fila
            {
                Int32 IdComputadora = Convert.ToInt32(computadoraDataGridView.CurrentRow.Cells[0].Value); //asignamos el NumCliente seleccionado en el data
                ComputadoraSeleccionada = MEmpleado.ObtenerEmpleado(IdComputadora);//llenamos clienteseleccionado con el qe se ha buscado en la BD por el numcliente qe eligio
                this.Close();
            }
            else
            {
                MessageBox.Show("Aun no ha seleccionado Ningun Empleado");
            }
        }
    }
}
