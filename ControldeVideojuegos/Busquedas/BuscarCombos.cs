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
    public partial class BuscarCombos : Form
    {
        public BuscarCombos()
        {
            InitializeComponent();
        }

        //public Combos ComboSeleccionado { get; set; }

        private void BuscarCombos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sisCVidDataSet.Combo' Puede moverla o quitarla según sea necesario.
            

        }

        

        private void comboBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.comboBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sisCVidDataSet);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btBCombo_Click(object sender, EventArgs e)
        {

        }
    }
}
