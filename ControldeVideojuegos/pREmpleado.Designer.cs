namespace ControldeVideojuegos
{
    partial class pREmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pREmpleado));
            this.lbREId = new System.Windows.Forms.Label();
            this.lbRERfc = new System.Windows.Forms.Label();
            this.lbRENom = new System.Windows.Forms.Label();
            this.lbREEd = new System.Windows.Forms.Label();
            this.lbREDir = new System.Windows.Forms.Label();
            this.lbRECor = new System.Windows.Forms.Label();
            this.lbRETel = new System.Windows.Forms.Label();
            this.tbREId = new System.Windows.Forms.TextBox();
            this.tbRERfc = new System.Windows.Forms.TextBox();
            this.tbRENombre = new System.Windows.Forms.TextBox();
            this.tbREEdad = new System.Windows.Forms.TextBox();
            this.tbREDireccion = new System.Windows.Forms.TextBox();
            this.tbRECorreo = new System.Windows.Forms.TextBox();
            this.tbRETelefono = new System.Windows.Forms.TextBox();
            this.pbREBuscar = new System.Windows.Forms.PictureBox();
            this.pbREModificar = new System.Windows.Forms.PictureBox();
            this.pbREBorrar = new System.Windows.Forms.PictureBox();
            this.pbREGuardar = new System.Windows.Forms.PictureBox();
            this.sisCVidDataSet = new ControldeVideojuegos.sisCVidDataSet();
            this.empleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empleadoTableAdapter = new ControldeVideojuegos.sisCVidDataSetTableAdapters.EmpleadoTableAdapter();
            this.tableAdapterManager = new ControldeVideojuegos.sisCVidDataSetTableAdapters.TableAdapterManager();
            this.empleadoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pbREActualizar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbREBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbREModificar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbREBorrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbREGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sisCVidDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbREActualizar)).BeginInit();
            this.SuspendLayout();
            // 
            // lbREId
            // 
            this.lbREId.AutoSize = true;
            this.lbREId.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbREId.Location = new System.Drawing.Point(103, 106);
            this.lbREId.Name = "lbREId";
            this.lbREId.Size = new System.Drawing.Size(101, 19);
            this.lbREId.TabIndex = 0;
            this.lbREId.Text = "ID. Empleado:";
            // 
            // lbRERfc
            // 
            this.lbRERfc.AutoSize = true;
            this.lbRERfc.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRERfc.Location = new System.Drawing.Point(103, 158);
            this.lbRERfc.Name = "lbRERfc";
            this.lbRERfc.Size = new System.Drawing.Size(39, 19);
            this.lbRERfc.TabIndex = 1;
            this.lbRERfc.Text = "RFC:";
            // 
            // lbRENom
            // 
            this.lbRENom.AutoSize = true;
            this.lbRENom.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRENom.Location = new System.Drawing.Point(103, 211);
            this.lbRENom.Name = "lbRENom";
            this.lbRENom.Size = new System.Drawing.Size(64, 19);
            this.lbRENom.TabIndex = 2;
            this.lbRENom.Text = "Nombre:";
            // 
            // lbREEd
            // 
            this.lbREEd.AutoSize = true;
            this.lbREEd.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbREEd.Location = new System.Drawing.Point(103, 265);
            this.lbREEd.Name = "lbREEd";
            this.lbREEd.Size = new System.Drawing.Size(46, 19);
            this.lbREEd.TabIndex = 3;
            this.lbREEd.Text = "Edad:";
            // 
            // lbREDir
            // 
            this.lbREDir.AutoSize = true;
            this.lbREDir.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbREDir.Location = new System.Drawing.Point(103, 315);
            this.lbREDir.Name = "lbREDir";
            this.lbREDir.Size = new System.Drawing.Size(73, 19);
            this.lbREDir.TabIndex = 4;
            this.lbREDir.Text = "Dirección:";
            // 
            // lbRECor
            // 
            this.lbRECor.AutoSize = true;
            this.lbRECor.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRECor.Location = new System.Drawing.Point(103, 367);
            this.lbRECor.Name = "lbRECor";
            this.lbRECor.Size = new System.Drawing.Size(56, 19);
            this.lbRECor.TabIndex = 5;
            this.lbRECor.Text = "Correo:";
            // 
            // lbRETel
            // 
            this.lbRETel.AutoSize = true;
            this.lbRETel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRETel.Location = new System.Drawing.Point(103, 414);
            this.lbRETel.Name = "lbRETel";
            this.lbRETel.Size = new System.Drawing.Size(70, 19);
            this.lbRETel.TabIndex = 6;
            this.lbRETel.Text = "Telefono:";
            // 
            // tbREId
            // 
            this.tbREId.Location = new System.Drawing.Point(226, 105);
            this.tbREId.Name = "tbREId";
            this.tbREId.Size = new System.Drawing.Size(142, 20);
            this.tbREId.TabIndex = 7;
            // 
            // tbRERfc
            // 
            this.tbRERfc.Location = new System.Drawing.Point(226, 157);
            this.tbRERfc.Name = "tbRERfc";
            this.tbRERfc.Size = new System.Drawing.Size(142, 20);
            this.tbRERfc.TabIndex = 8;
            // 
            // tbRENombre
            // 
            this.tbRENombre.Location = new System.Drawing.Point(226, 210);
            this.tbRENombre.Name = "tbRENombre";
            this.tbRENombre.Size = new System.Drawing.Size(142, 20);
            this.tbRENombre.TabIndex = 9;
            // 
            // tbREEdad
            // 
            this.tbREEdad.Location = new System.Drawing.Point(226, 264);
            this.tbREEdad.Name = "tbREEdad";
            this.tbREEdad.Size = new System.Drawing.Size(142, 20);
            this.tbREEdad.TabIndex = 10;
            // 
            // tbREDireccion
            // 
            this.tbREDireccion.Location = new System.Drawing.Point(226, 314);
            this.tbREDireccion.Name = "tbREDireccion";
            this.tbREDireccion.Size = new System.Drawing.Size(142, 20);
            this.tbREDireccion.TabIndex = 11;
            // 
            // tbRECorreo
            // 
            this.tbRECorreo.Location = new System.Drawing.Point(226, 366);
            this.tbRECorreo.Name = "tbRECorreo";
            this.tbRECorreo.Size = new System.Drawing.Size(142, 20);
            this.tbRECorreo.TabIndex = 12;
            // 
            // tbRETelefono
            // 
            this.tbRETelefono.Location = new System.Drawing.Point(226, 413);
            this.tbRETelefono.Name = "tbRETelefono";
            this.tbRETelefono.Size = new System.Drawing.Size(142, 20);
            this.tbRETelefono.TabIndex = 13;
            // 
            // pbREBuscar
            // 
            this.pbREBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbREBuscar.Image = ((System.Drawing.Image)(resources.GetObject("pbREBuscar.Image")));
            this.pbREBuscar.Location = new System.Drawing.Point(785, 366);
            this.pbREBuscar.Name = "pbREBuscar";
            this.pbREBuscar.Size = new System.Drawing.Size(56, 50);
            this.pbREBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbREBuscar.TabIndex = 14;
            this.pbREBuscar.TabStop = false;
            this.pbREBuscar.Click += new System.EventHandler(this.pbREBuscar_Click);
            // 
            // pbREModificar
            // 
            this.pbREModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbREModificar.Image = ((System.Drawing.Image)(resources.GetObject("pbREModificar.Image")));
            this.pbREModificar.Location = new System.Drawing.Point(465, 366);
            this.pbREModificar.Name = "pbREModificar";
            this.pbREModificar.Size = new System.Drawing.Size(56, 50);
            this.pbREModificar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbREModificar.TabIndex = 15;
            this.pbREModificar.TabStop = false;
            this.pbREModificar.Click += new System.EventHandler(this.pbREModificar_Click);
            // 
            // pbREBorrar
            // 
            this.pbREBorrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbREBorrar.Image = ((System.Drawing.Image)(resources.GetObject("pbREBorrar.Image")));
            this.pbREBorrar.Location = new System.Drawing.Point(545, 366);
            this.pbREBorrar.Name = "pbREBorrar";
            this.pbREBorrar.Size = new System.Drawing.Size(56, 50);
            this.pbREBorrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbREBorrar.TabIndex = 16;
            this.pbREBorrar.TabStop = false;
            this.pbREBorrar.Click += new System.EventHandler(this.pbREBorrar_Click);
            // 
            // pbREGuardar
            // 
            this.pbREGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbREGuardar.Image = ((System.Drawing.Image)(resources.GetObject("pbREGuardar.Image")));
            this.pbREGuardar.Location = new System.Drawing.Point(625, 366);
            this.pbREGuardar.Name = "pbREGuardar";
            this.pbREGuardar.Size = new System.Drawing.Size(56, 50);
            this.pbREGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbREGuardar.TabIndex = 17;
            this.pbREGuardar.TabStop = false;
            this.pbREGuardar.Click += new System.EventHandler(this.pbREGuardar_Click);
            // 
            // sisCVidDataSet
            // 
            this.sisCVidDataSet.DataSetName = "sisCVidDataSet";
            this.sisCVidDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empleadoBindingSource
            // 
            this.empleadoBindingSource.DataMember = "Empleado";
            this.empleadoBindingSource.DataSource = this.sisCVidDataSet;
            // 
            // empleadoTableAdapter
            // 
            this.empleadoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EmpleadoTableAdapter = this.empleadoTableAdapter;
            this.tableAdapterManager.UpdateOrder = ControldeVideojuegos.sisCVidDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // empleadoDataGridView
            // 
            this.empleadoDataGridView.AllowUserToAddRows = false;
            this.empleadoDataGridView.AllowUserToDeleteRows = false;
            this.empleadoDataGridView.AllowUserToResizeColumns = false;
            this.empleadoDataGridView.AllowUserToResizeRows = false;
            this.empleadoDataGridView.AutoGenerateColumns = false;
            this.empleadoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empleadoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.empleadoDataGridView.DataSource = this.empleadoBindingSource;
            this.empleadoDataGridView.Location = new System.Drawing.Point(456, 105);
            this.empleadoDataGridView.Name = "empleadoDataGridView";
            this.empleadoDataGridView.RowHeadersVisible = false;
            this.empleadoDataGridView.Size = new System.Drawing.Size(394, 220);
            this.empleadoDataGridView.TabIndex = 22;
            this.empleadoDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.empleadoDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdEmpleado";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdEmpleado";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Rfc";
            this.dataGridViewTextBoxColumn2.HeaderText = "Rfc";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Edad";
            this.dataGridViewTextBoxColumn4.HeaderText = "Edad";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Direccion";
            this.dataGridViewTextBoxColumn5.HeaderText = "Direccion";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Correo";
            this.dataGridViewTextBoxColumn6.HeaderText = "Correo";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Telefono";
            this.dataGridViewTextBoxColumn7.HeaderText = "Telefono";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // pbREActualizar
            // 
            this.pbREActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbREActualizar.Image = ((System.Drawing.Image)(resources.GetObject("pbREActualizar.Image")));
            this.pbREActualizar.Location = new System.Drawing.Point(705, 366);
            this.pbREActualizar.Name = "pbREActualizar";
            this.pbREActualizar.Size = new System.Drawing.Size(56, 50);
            this.pbREActualizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbREActualizar.TabIndex = 22;
            this.pbREActualizar.TabStop = false;
            this.pbREActualizar.Click += new System.EventHandler(this.pbREActualizar_Click);
            // 
            // pREmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.empleadoDataGridView);
            this.Controls.Add(this.pbREActualizar);
            this.Controls.Add(this.pbREGuardar);
            this.Controls.Add(this.pbREBorrar);
            this.Controls.Add(this.pbREModificar);
            this.Controls.Add(this.pbREBuscar);
            this.Controls.Add(this.tbRETelefono);
            this.Controls.Add(this.tbRECorreo);
            this.Controls.Add(this.tbREDireccion);
            this.Controls.Add(this.tbREEdad);
            this.Controls.Add(this.tbRENombre);
            this.Controls.Add(this.tbRERfc);
            this.Controls.Add(this.tbREId);
            this.Controls.Add(this.lbRETel);
            this.Controls.Add(this.lbRECor);
            this.Controls.Add(this.lbREDir);
            this.Controls.Add(this.lbREEd);
            this.Controls.Add(this.lbRENom);
            this.Controls.Add(this.lbRERfc);
            this.Controls.Add(this.lbREId);
            this.Name = "pREmpleado";
            this.Size = new System.Drawing.Size(916, 572);
            this.Load += new System.EventHandler(this.pREmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbREBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbREModificar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbREBorrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbREGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sisCVidDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbREActualizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbREId;
        private System.Windows.Forms.Label lbRERfc;
        private System.Windows.Forms.Label lbRENom;
        private System.Windows.Forms.Label lbREEd;
        private System.Windows.Forms.Label lbREDir;
        private System.Windows.Forms.Label lbRECor;
        private System.Windows.Forms.Label lbRETel;
        private System.Windows.Forms.TextBox tbREId;
        private System.Windows.Forms.TextBox tbRERfc;
        private System.Windows.Forms.TextBox tbRENombre;
        private System.Windows.Forms.TextBox tbREEdad;
        private System.Windows.Forms.TextBox tbREDireccion;
        private System.Windows.Forms.TextBox tbRECorreo;
        private System.Windows.Forms.TextBox tbRETelefono;
        private System.Windows.Forms.PictureBox pbREBuscar;
        private System.Windows.Forms.PictureBox pbREModificar;
        private System.Windows.Forms.PictureBox pbREBorrar;
        private System.Windows.Forms.PictureBox pbREGuardar;
        private sisCVidDataSet sisCVidDataSet;
        private System.Windows.Forms.BindingSource empleadoBindingSource;
        private sisCVidDataSetTableAdapters.EmpleadoTableAdapter empleadoTableAdapter;
        private sisCVidDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView empleadoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.PictureBox pbREActualizar;
    }
}
