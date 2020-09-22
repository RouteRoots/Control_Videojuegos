namespace ControldeVideojuegos
{
    partial class pRConsolas
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pRConsolas));
            this.tbRConId = new System.Windows.Forms.TextBox();
            this.tbRConNombre = new System.Windows.Forms.TextBox();
            this.tbRConMarca = new System.Windows.Forms.TextBox();
            this.tbRConEstado = new System.Windows.Forms.TextBox();
            this.tbRConVersion = new System.Windows.Forms.TextBox();
            this.lbRConId = new System.Windows.Forms.Label();
            this.lbRConMArca = new System.Windows.Forms.Label();
            this.lbRConNombre = new System.Windows.Forms.Label();
            this.Capasidad = new System.Windows.Forms.Label();
            this.lbRConVersion = new System.Windows.Forms.Label();
            this.lbRConanio = new System.Windows.Forms.Label();
            this.pbRConModificar = new System.Windows.Forms.PictureBox();
            this.pbRConGuardar = new System.Windows.Forms.PictureBox();
            this.pbRConBorrar = new System.Windows.Forms.PictureBox();
            this.pbRConActualizar = new System.Windows.Forms.PictureBox();
            this.pbRConBuscar = new System.Windows.Forms.PictureBox();
            this.tbRConCapasidad = new System.Windows.Forms.ComboBox();
            this.sisCVidDataSet = new ControldeVideojuegos.sisCVidDataSet();
            this.consolaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            
            this.tableAdapterManager = new ControldeVideojuegos.sisCVidDataSetTableAdapters.TableAdapterManager();
            this.consolaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pbRConModificar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRConGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRConBorrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRConActualizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRConBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sisCVidDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consolaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consolaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tbRConId
            // 
            this.tbRConId.Location = new System.Drawing.Point(226, 105);
            this.tbRConId.Margin = new System.Windows.Forms.Padding(2);
            this.tbRConId.Name = "tbRConId";
            this.tbRConId.Size = new System.Drawing.Size(142, 20);
            this.tbRConId.TabIndex = 0;
            // 
            // tbRConNombre
            // 
            this.tbRConNombre.Location = new System.Drawing.Point(226, 157);
            this.tbRConNombre.Margin = new System.Windows.Forms.Padding(2);
            this.tbRConNombre.Name = "tbRConNombre";
            this.tbRConNombre.Size = new System.Drawing.Size(142, 20);
            this.tbRConNombre.TabIndex = 2;
            // 
            // tbRConMarca
            // 
            this.tbRConMarca.Location = new System.Drawing.Point(226, 212);
            this.tbRConMarca.Margin = new System.Windows.Forms.Padding(2);
            this.tbRConMarca.Name = "tbRConMarca";
            this.tbRConMarca.Size = new System.Drawing.Size(142, 20);
            this.tbRConMarca.TabIndex = 3;
            // 
            // tbRConEstado
            // 
            this.tbRConEstado.Location = new System.Drawing.Point(226, 368);
            this.tbRConEstado.Margin = new System.Windows.Forms.Padding(2);
            this.tbRConEstado.Name = "tbRConEstado";
            this.tbRConEstado.Size = new System.Drawing.Size(142, 20);
            this.tbRConEstado.TabIndex = 4;
            // 
            // tbRConVersion
            // 
            this.tbRConVersion.Location = new System.Drawing.Point(226, 314);
            this.tbRConVersion.Margin = new System.Windows.Forms.Padding(2);
            this.tbRConVersion.Name = "tbRConVersion";
            this.tbRConVersion.Size = new System.Drawing.Size(142, 20);
            this.tbRConVersion.TabIndex = 5;
            // 
            // lbRConId
            // 
            this.lbRConId.AutoSize = true;
            this.lbRConId.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRConId.Location = new System.Drawing.Point(103, 106);
            this.lbRConId.Name = "lbRConId";
            this.lbRConId.Size = new System.Drawing.Size(89, 19);
            this.lbRConId.TabIndex = 8;
            this.lbRConId.Text = "ID. Consola:";
            // 
            // lbRConMArca
            // 
            this.lbRConMArca.AutoSize = true;
            this.lbRConMArca.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRConMArca.Location = new System.Drawing.Point(103, 158);
            this.lbRConMArca.Name = "lbRConMArca";
            this.lbRConMArca.Size = new System.Drawing.Size(64, 19);
            this.lbRConMArca.TabIndex = 9;
            this.lbRConMArca.Text = "Nombre:";
            // 
            // lbRConNombre
            // 
            this.lbRConNombre.AutoSize = true;
            this.lbRConNombre.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRConNombre.Location = new System.Drawing.Point(103, 211);
            this.lbRConNombre.Name = "lbRConNombre";
            this.lbRConNombre.Size = new System.Drawing.Size(47, 19);
            this.lbRConNombre.TabIndex = 10;
            this.lbRConNombre.Text = "Marca";
            // 
            // Capasidad
            // 
            this.Capasidad.AutoSize = true;
            this.Capasidad.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Capasidad.Location = new System.Drawing.Point(103, 265);
            this.Capasidad.Name = "Capasidad";
            this.Capasidad.Size = new System.Drawing.Size(77, 19);
            this.Capasidad.TabIndex = 11;
            this.Capasidad.Text = "Capasidad:";
            // 
            // lbRConVersion
            // 
            this.lbRConVersion.AutoSize = true;
            this.lbRConVersion.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRConVersion.Location = new System.Drawing.Point(103, 315);
            this.lbRConVersion.Name = "lbRConVersion";
            this.lbRConVersion.Size = new System.Drawing.Size(61, 19);
            this.lbRConVersion.TabIndex = 12;
            this.lbRConVersion.Text = "Version:";
            // 
            // lbRConanio
            // 
            this.lbRConanio.AutoSize = true;
            this.lbRConanio.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRConanio.Location = new System.Drawing.Point(103, 367);
            this.lbRConanio.Name = "lbRConanio";
            this.lbRConanio.Size = new System.Drawing.Size(57, 19);
            this.lbRConanio.TabIndex = 13;
            this.lbRConanio.Text = "Estado:";
            // 
            // pbRConModificar
            // 
            this.pbRConModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbRConModificar.Image = ((System.Drawing.Image)(resources.GetObject("pbRConModificar.Image")));
            this.pbRConModificar.Location = new System.Drawing.Point(465, 366);
            this.pbRConModificar.Name = "pbRConModificar";
            this.pbRConModificar.Size = new System.Drawing.Size(56, 50);
            this.pbRConModificar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRConModificar.TabIndex = 14;
            this.pbRConModificar.TabStop = false;
            // 
            // pbRConGuardar
            // 
            this.pbRConGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbRConGuardar.Image = ((System.Drawing.Image)(resources.GetObject("pbRConGuardar.Image")));
            this.pbRConGuardar.Location = new System.Drawing.Point(625, 366);
            this.pbRConGuardar.Name = "pbRConGuardar";
            this.pbRConGuardar.Size = new System.Drawing.Size(56, 50);
            this.pbRConGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRConGuardar.TabIndex = 15;
            this.pbRConGuardar.TabStop = false;
            // 
            // pbRConBorrar
            // 
            this.pbRConBorrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbRConBorrar.Image = ((System.Drawing.Image)(resources.GetObject("pbRConBorrar.Image")));
            this.pbRConBorrar.Location = new System.Drawing.Point(545, 366);
            this.pbRConBorrar.Name = "pbRConBorrar";
            this.pbRConBorrar.Size = new System.Drawing.Size(56, 50);
            this.pbRConBorrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRConBorrar.TabIndex = 16;
            this.pbRConBorrar.TabStop = false;
            // 
            // pbRConActualizar
            // 
            this.pbRConActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbRConActualizar.Image = ((System.Drawing.Image)(resources.GetObject("pbRConActualizar.Image")));
            this.pbRConActualizar.Location = new System.Drawing.Point(705, 366);
            this.pbRConActualizar.Name = "pbRConActualizar";
            this.pbRConActualizar.Size = new System.Drawing.Size(56, 50);
            this.pbRConActualizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRConActualizar.TabIndex = 17;
            this.pbRConActualizar.TabStop = false;
            // 
            // pbRConBuscar
            // 
            this.pbRConBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbRConBuscar.Image = ((System.Drawing.Image)(resources.GetObject("pbRConBuscar.Image")));
            this.pbRConBuscar.Location = new System.Drawing.Point(785, 366);
            this.pbRConBuscar.Name = "pbRConBuscar";
            this.pbRConBuscar.Size = new System.Drawing.Size(56, 50);
            this.pbRConBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRConBuscar.TabIndex = 18;
            this.pbRConBuscar.TabStop = false;
            // 
            // tbRConCapasidad
            // 
            this.tbRConCapasidad.FormattingEnabled = true;
            this.tbRConCapasidad.Location = new System.Drawing.Point(226, 264);
            this.tbRConCapasidad.Name = "tbRConCapasidad";
            this.tbRConCapasidad.Size = new System.Drawing.Size(142, 21);
            this.tbRConCapasidad.TabIndex = 19;
            // 
            // sisCVidDataSet
            // 
            this.sisCVidDataSet.DataSetName = "sisCVidDataSet";
            this.sisCVidDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // consolaBindingSource
            // 
            this.consolaBindingSource.DataMember = "Consola";
            this.consolaBindingSource.DataSource = this.sisCVidDataSet;
            // 
            // consolaTableAdapter
            // 
          
            // 
            // consolaDataGridView
            // 
            this.consolaDataGridView.AutoGenerateColumns = false;
            this.consolaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.consolaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.consolaDataGridView.DataSource = this.consolaBindingSource;
            this.consolaDataGridView.Location = new System.Drawing.Point(456, 105);
            this.consolaDataGridView.Name = "consolaDataGridView";
            this.consolaDataGridView.Size = new System.Drawing.Size(394, 220);
            this.consolaDataGridView.TabIndex = 20;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdConsolas";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdConsolas";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Marca";
            this.dataGridViewTextBoxColumn3.HeaderText = "Marca";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Capasidad";
            this.dataGridViewTextBoxColumn4.HeaderText = "Capasidad";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Version";
            this.dataGridViewTextBoxColumn5.HeaderText = "Version";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Estado";
            this.dataGridViewTextBoxColumn6.HeaderText = "Estado";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // pRConsolas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.consolaDataGridView);
            this.Controls.Add(this.tbRConCapasidad);
            this.Controls.Add(this.pbRConBuscar);
            this.Controls.Add(this.pbRConActualizar);
            this.Controls.Add(this.pbRConBorrar);
            this.Controls.Add(this.pbRConGuardar);
            this.Controls.Add(this.pbRConModificar);
            this.Controls.Add(this.lbRConanio);
            this.Controls.Add(this.lbRConVersion);
            this.Controls.Add(this.Capasidad);
            this.Controls.Add(this.lbRConNombre);
            this.Controls.Add(this.lbRConMArca);
            this.Controls.Add(this.lbRConId);
            this.Controls.Add(this.tbRConVersion);
            this.Controls.Add(this.tbRConEstado);
            this.Controls.Add(this.tbRConMarca);
            this.Controls.Add(this.tbRConNombre);
            this.Controls.Add(this.tbRConId);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "pRConsolas";
            this.Size = new System.Drawing.Size(916, 572);
            ((System.ComponentModel.ISupportInitialize)(this.pbRConModificar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRConGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRConBorrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRConActualizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRConBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sisCVidDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consolaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consolaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbRConId;
        private System.Windows.Forms.TextBox tbRConNombre;
        private System.Windows.Forms.TextBox tbRConMarca;
        private System.Windows.Forms.TextBox tbRConEstado;
        private System.Windows.Forms.TextBox tbRConVersion;
        private System.Windows.Forms.Label lbRConId;
        private System.Windows.Forms.Label lbRConMArca;
        private System.Windows.Forms.Label lbRConNombre;
        private System.Windows.Forms.Label Capasidad;
        private System.Windows.Forms.Label lbRConVersion;
        private System.Windows.Forms.Label lbRConanio;
        private System.Windows.Forms.PictureBox pbRConModificar;
        private System.Windows.Forms.PictureBox pbRConGuardar;
        private System.Windows.Forms.PictureBox pbRConBorrar;
        private System.Windows.Forms.PictureBox pbRConActualizar;
        private System.Windows.Forms.PictureBox pbRConBuscar;
        private System.Windows.Forms.ComboBox tbRConCapasidad;
        private sisCVidDataSet sisCVidDataSet;
        private System.Windows.Forms.BindingSource consolaBindingSource;
        
        private sisCVidDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView consolaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}
