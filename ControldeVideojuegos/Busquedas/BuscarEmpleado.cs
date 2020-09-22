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
    public partial class BuscarEmpleado : Form
    {
        public BuscarEmpleado()
        {
            InitializeComponent();
        }

        public Empleado EmpleadoSeleccionado { get; set; }

        private void empleadoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.empleadoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sisCVidDataSet);

        }

        private void BuscarEmpleado_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sisCVidDataSet.Empleado' Puede moverla o quitarla según sea necesario.
            //this.empleadoTableAdapter.Fill(this.sisCVidDataSet.Empleado);

        }

        private void pbREIdBuscar_Click(object sender, EventArgs e)
        {
            empleadoDataGridView1.DataSource = MEmpleado.BuscarEmpleado(Convert.ToInt32(tbBEBuscar.Text)); //llenamos el data con los datos obtenidos 
                                                                                                          //de la busqueda por el NumCliente digitado
        }

        private void btBEmpleado_Click(object sender, EventArgs e)
        {
            if (empleadoDataGridView1.SelectedRows.Count == 1) // si selecciona un fila
            {
                Int32 IdEmpleado = Convert.ToInt32(empleadoDataGridView1.CurrentRow.Cells[0].Value); //asignamos el NumCliente seleccionado en el data
                EmpleadoSeleccionado = MEmpleado.ObtenerEmpleado(IdEmpleado);//llenamos clienteseleccionado con el qe se ha buscado en la BD por el numcliente qe eligio
                this.Close();
            }
            else
            {
                MessageBox.Show("Aun no ha seleccionado Ningun Empleado");
            }
        }

        private void btBECancelea_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void empleadoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
