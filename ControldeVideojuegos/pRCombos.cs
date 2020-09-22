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
    public partial class pRCombos : UserControl

        
    {
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;

        public pRCombos()
        {
            InitializeComponent();
        }

        private Combos ComboActual { get; set; }
        private Combos ComboSeleccionado { get; set; }

        private void comboBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.comboBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sisCVidDataSet);

        }

        private void pRCombos_Load(object sender, EventArgs e)
        {
            
        }

        private void pbRCombModificar_Click(object sender, EventArgs e)
        {
            Combos pCombo = new Combos();
            pCombo.IdCombo = Convert.ToInt32(tbRCombId.Text);
            pCombo.Nombre = tbRCombNombre.Text;
            pCombo.NoControles = tbRCombNControles.Text;
            pCombo.RefAg = tbRCombRA.Text;
            pCombo.PalPas = tbRCombPP.Text;
            pCombo.NoHoras = tbRCombHoras.Text;
            pCombo.Costo = tbRCombCosto.Text;

            if (MCombo.Modificar(pCombo, ComboActual.IdCombo) > 0)
            {
                MessageBox.Show("Datos Modificados!!");
                limpiar();
                pbRCombBorrar.Enabled = false;
                pbRCombModificar.Enabled = true;
                pbRCombGuardar.Enabled = true;
            }
        }
        void limpiar()
        {
            tbRCombId.Clear();
            tbRCombNombre.Clear();
            tbRCombNControles.Clear();
            tbRCombRA.Clear();
            tbRCombPP.Clear();
            tbRCombHoras.Clear();
            tbRCombCosto.Clear();

        }

        private void pbRCombBorrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea eliminar el Cliente??", "Esta seguro?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                int resultado = MCombo.Eliminar(ComboActual.IdCombo);

                if (resultado > 0)
                {

                    MessageBox.Show("Cliente Eliminado Correctamente", "Cliente Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();
                    pbRCombBorrar.Enabled = false;
                    pbRCombModificar.Enabled = false;
                    pbRCombGuardar.Enabled = true;
                }

                else
                {
                    MessageBox.Show("No se pudo Eliminar el Cliente", "Ocurrio un error!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            else
                MessageBox.Show("Se cancelo la eliminacion", "Cancelado");
        }

        private void pbRCombGuardar_Click(object sender, EventArgs e)
        {
            Combos pCombo = new Combos();
            pCombo.IdCombo = Convert.ToInt32(tbRCombId.Text);
            pCombo.Nombre = tbRCombNombre.Text;
            pCombo.NoControles = tbRCombNControles.Text;
            pCombo.RefAg = tbRCombRA.Text;
            pCombo.PalPas = tbRCombPP.Text;
            pCombo.NoHoras = tbRCombHoras.Text;
            pCombo.Costo = tbRCombCosto.Text;

            if (MCombo.Agregar(pCombo) > 0)
            {
                MessageBox.Show("Cliente agregado", "Guardado!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();
            }
        }

        private void pbRComdActualizar_Click(object sender, EventArgs e)
        {
            SqlConnection cm;

            cm = new SqlConnection("Data Source=DESKTOP-0PCN940\\SQLEXPRESS;Initial Catalog=sisCVid;Integrated Security=True");
            sda = new SqlDataAdapter("Select IdCombo, Nombre, NoControles , RefAg, PalPas, NoHoras, Costo from Combo ", cm);
            dt = new DataTable();
            sda.Fill(dt);
            comboDataGridView.DataSource = dt;
            scb = new SqlCommandBuilder(sda);
            sda.Update(dt);
        }

        private void pbRCombBuscar_Click(object sender, EventArgs e)
        {
            pRCombos pBuscar = new pRCombos();
           

            if (pBuscar.ComboSeleccionado != null) // si cliente seleccionado no esta nulo entrara en la condicion
            {
                ComboActual = pBuscar.ComboActual;

                tbRCombId.Text = pBuscar.ComboSeleccionado.IdCombo.ToString();
                tbRCombNombre.Text = pBuscar.ComboSeleccionado.Nombre;
                tbRCombNControles.Text = pBuscar.ComboSeleccionado.NoControles;
                tbRCombRA.Text = pBuscar.ComboSeleccionado.RefAg;
                tbRCombPP.Text = pBuscar.ComboSeleccionado.PalPas;
                tbRCombHoras.Text = pBuscar.ComboSeleccionado.NoHoras;
                tbRCombCosto.Text = pBuscar.ComboSeleccionado.Costo;

                pbRCombGuardar.Enabled = false;
                pbRCombBorrar.Enabled = true;
                pbRCombGuardar.Enabled = true;
            }
            //llenamos el data con los datos obtenidos 
                                                                                               //de la busqueda por el NumCliente digitado
        }

        private void btBCombo_Click(object sender, EventArgs e)
        {
            if (comboDataGridView.SelectedRows.Count == 1) // si selecciona un fila
            {
                Int32 IdCombo = Convert.ToInt32(comboDataGridView.CurrentRow.Cells[0].Value); //asignamos el NumCliente seleccionado en el data
                ComboSeleccionado = MCombo.ObtenerCombo(IdCombo);//llenamos clienteseleccionado con el qe se ha buscado en la BD por el numcliente qe eligio
                
            }
            else
            {
                MessageBox.Show("Aun no ha seleccionado Ningun Combo");
            }
        }

        private void btBCCancelar_Click(object sender, EventArgs e)
        {
            limp();
        }
        void limp()
        {
        
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
