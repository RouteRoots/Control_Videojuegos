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

namespace ControldeVideojuegos.FVentanas
{
    public partial class FEmpleado : Form
    {
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;

        public FEmpleado()
        {
            InitializeComponent();
        }

        public Empleado EmpleadoActual { get; set; }

        private void empleadoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.empleadoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sisCVidDataSet);

        }

        private void FEmpleado_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sisCVidDataSet.Empleado' Puede moverla o quitarla según sea necesario.
            this.empleadoTableAdapter.Fill(this.sisCVidDataSet.Empleado);

        }

        void limpiar()
        {
            tbREId.Clear();
            tbRERfc.Clear();
            tbRENombre.Clear();
            tbREEdad.Clear();
            tbREDireccion.Clear();
            tbRECorreo.Clear();
            tbRETelefono.Clear();

        }

        private void pbREModificar_Click(object sender, EventArgs e)
        {
            Empleado pEmpleado = new Empleado();
            pEmpleado.IdEmpleado = Convert.ToInt32(tbREId.Text);
            pEmpleado.Rfc = tbRERfc.Text;
            pEmpleado.Nombre = tbRENombre.Text;
            pEmpleado.Edad = tbREEdad.Text;
            pEmpleado.Direccion = tbREDireccion.Text;
            pEmpleado.Correo = tbRECorreo.Text;
            pEmpleado.Telefono = tbRETelefono.Text;

            if (MEmpleado.Modificar(pEmpleado, EmpleadoActual.IdEmpleado) > 0)
            {
                MessageBox.Show("Datos Modificados!!");
                limpiar();
                pbREBorrar.Enabled = false;
                pbREModificar.Enabled = true;
                pbREGuardar.Enabled = true;
            }
        }

        private void pbREBorrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea eliminar el Cliente??", "Esta seguro?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                int resultado = MEmpleado.Eliminar(EmpleadoActual.IdEmpleado);

                if (resultado > 0)
                {

                    MessageBox.Show("Cliente Eliminado Correctamente", "Cliente Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();
                    pbREBorrar.Enabled = false;
                    pbREModificar.Enabled = false;
                    pbREGuardar.Enabled = true;
                }

                else
                {
                    MessageBox.Show("No se pudo Eliminar el Cliente", "Ocurrio un error!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            else
                MessageBox.Show("Se cancelo la eliminacion", "Cancelado");
        }

        private void pbREGuardar_Click(object sender, EventArgs e)
        {
            Empleado pEmpleado = new Empleado();
            pEmpleado.IdEmpleado = Convert.ToInt32(tbREId.Text);
            pEmpleado.Rfc = tbRERfc.Text;
            pEmpleado.Nombre = tbRENombre.Text;
            pEmpleado.Edad = tbREEdad.Text;
            pEmpleado.Direccion = tbREDireccion.Text;
            pEmpleado.Correo = tbRECorreo.Text;
            pEmpleado.Telefono = tbRETelefono.Text;

            if (MEmpleado.Agregar(pEmpleado) > 0)
            {
                MessageBox.Show("Cliente agregado", "Guardado!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();
            }
        }

        private void pbREActualizar_Click(object sender, EventArgs e)
        {
            SqlConnection cm;

            cm = new SqlConnection("Data Source=DESKTOP-0PCN940\\SQLEXPRESS;Initial Catalog=sisCVid;Integrated Security=True");
            sda = new SqlDataAdapter("Select IdEmpleado, Rfc, Nombre, Edad, Direccion, Correo, Telefono from Empleado ", cm);
            dt = new DataTable();
            sda.Fill(dt);
            empleadoDataGridView.DataSource = dt;
            scb = new SqlCommandBuilder(sda);
            sda.Update(dt);
        }

        private void pbREBuscar_Click(object sender, EventArgs e)
        {
            BuscarEmpleado pBuscar = new BuscarEmpleado();
            pBuscar.ShowDialog();

            if (pBuscar.EmpleadoSeleccionado != null) // si cliente seleccionado no esta nulo entrara en la condicion
            {
                EmpleadoActual = pBuscar.EmpleadoSeleccionado;

                tbREId.Text = pBuscar.EmpleadoSeleccionado.IdEmpleado.ToString();
                tbRERfc.Text = pBuscar.EmpleadoSeleccionado.Rfc;
                tbRENombre.Text = pBuscar.EmpleadoSeleccionado.Nombre;
                tbREEdad.Text = pBuscar.EmpleadoSeleccionado.Edad;
                tbREDireccion.Text = pBuscar.EmpleadoSeleccionado.Direccion;
                tbRECorreo.Text = pBuscar.EmpleadoSeleccionado.Correo;
                tbRETelefono.Text = pBuscar.EmpleadoSeleccionado.Telefono;

                pbREGuardar.Enabled = false;
                pbREBorrar.Enabled = true;
                pbREGuardar.Enabled = true;
            }
        }
    }
}
