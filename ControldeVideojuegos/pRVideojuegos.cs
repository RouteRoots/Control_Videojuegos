using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControldeVideojuegos
{
    public partial class pRVideojuegos : UserControl
    {
        public pRVideojuegos()
        {
            InitializeComponent();
        }

        private void videojuegoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.videojuegoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sisCVidDataSet);

        }
    }
}
