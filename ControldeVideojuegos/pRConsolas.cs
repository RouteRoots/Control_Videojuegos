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
    public partial class pRConsolas : UserControl
    {
        public pRConsolas()
        {
            InitializeComponent();
        }

        private void consolaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.consolaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sisCVidDataSet);

        }
    }
}
