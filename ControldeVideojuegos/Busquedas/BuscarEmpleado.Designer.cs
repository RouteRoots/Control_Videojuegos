namespace ControldeVideojuegos
{
    partial class BuscarEmpleado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarEmpleado));
            this.sisCVidDataSet = new ControldeVideojuegos.sisCVidDataSet();
            this.empleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empleadoTableAdapter = new ControldeVideojuegos.sisCVidDataSetTableAdapters.EmpleadoTableAdapter();
            this.tableAdapterManager = new ControldeVideojuegos.sisCVidDataSetTableAdapters.TableAdapterManager();
            this.tbBEBuscar = new System.Windows.Forms.TextBox();
            this.lbREIdBuscar = new System.Windows.Forms.Label();
            this.pbREIdBuscar = new System.Windows.Forms.PictureBox();
            this.btBEmpleado = new System.Windows.Forms.Button();
            this.btBECancelea = new System.Windows.Forms.Button();
            this.empleadoDataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.sisCVidDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbREIdBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoDataGridView1)).BeginInit();
            this.SuspendLayout();
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
            // tbBEBuscar
            // 
            this.tbBEBuscar.Location = new System.Drawing.Point(228, 41);
            this.tbBEBuscar.Name = "tbBEBuscar";
            this.tbBEBuscar.Size = new System.Drawing.Size(142, 20);
            this.tbBEBuscar.TabIndex = 9;
            // 
            // lbREIdBuscar
            // 
            this.lbREIdBuscar.AutoSize = true;
            this.lbREIdBuscar.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbREIdBuscar.Location = new System.Drawing.Point(105, 42);
            this.lbREIdBuscar.Name = "lbREIdBuscar";
            this.lbREIdBuscar.Size = new System.Drawing.Size(100, 19);
            this.lbREIdBuscar.TabIndex = 8;
            this.lbREIdBuscar.Text = "Id. Empleado:";
            // 
            // pbREIdBuscar
            // 
            this.pbREIdBuscar.Image = ((System.Drawing.Image)(resources.GetObject("pbREIdBuscar.Image")));
            this.pbREIdBuscar.Location = new System.Drawing.Point(448, 30);
            this.pbREIdBuscar.Name = "pbREIdBuscar";
            this.pbREIdBuscar.Size = new System.Drawing.Size(40, 31);
            this.pbREIdBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbREIdBuscar.TabIndex = 15;
            this.pbREIdBuscar.TabStop = false;
            this.pbREIdBuscar.Click += new System.EventHandler(this.pbREIdBuscar_Click);
            // 
            // btBEmpleado
            // 
            this.btBEmpleado.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBEmpleado.Location = new System.Drawing.Point(36, 294);
            this.btBEmpleado.Name = "btBEmpleado";
            this.btBEmpleado.Size = new System.Drawing.Size(75, 23);
            this.btBEmpleado.TabIndex = 16;
            this.btBEmpleado.Text = "Aceptar";
            this.btBEmpleado.UseVisualStyleBackColor = true;
            this.btBEmpleado.Click += new System.EventHandler(this.btBEmpleado_Click);
            // 
            // btBECancelea
            // 
            this.btBECancelea.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBECancelea.Location = new System.Drawing.Point(495, 294);
            this.btBECancelea.Name = "btBECancelea";
            this.btBECancelea.Size = new System.Drawing.Size(75, 23);
            this.btBECancelea.TabIndex = 17;
            this.btBECancelea.Text = "Cancelar";
            this.btBECancelea.UseVisualStyleBackColor = true;
            this.btBECancelea.Click += new System.EventHandler(this.btBECancelea_Click);
            // 
            // empleadoDataGridView1
            // 
            this.empleadoDataGridView1.AutoGenerateColumns = false;
            this.empleadoDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empleadoDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14});
            this.empleadoDataGridView1.DataSource = this.empleadoBindingSource;
            this.empleadoDataGridView1.Location = new System.Drawing.Point(24, 103);
            this.empleadoDataGridView1.Name = "empleadoDataGridView1";
            this.empleadoDataGridView1.Size = new System.Drawing.Size(556, 157);
            this.empleadoDataGridView1.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "IdEmpleado";
            this.dataGridViewTextBoxColumn8.HeaderText = "IdEmpleado";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Rfc";
            this.dataGridViewTextBoxColumn9.HeaderText = "Rfc";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn10.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Edad";
            this.dataGridViewTextBoxColumn11.HeaderText = "Edad";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Direccion";
            this.dataGridViewTextBoxColumn12.HeaderText = "Direccion";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Correo";
            this.dataGridViewTextBoxColumn13.HeaderText = "Correo";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Telefono";
            this.dataGridViewTextBoxColumn14.HeaderText = "Telefono";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // BuscarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 339);
            this.Controls.Add(this.empleadoDataGridView1);
            this.Controls.Add(this.btBECancelea);
            this.Controls.Add(this.btBEmpleado);
            this.Controls.Add(this.pbREIdBuscar);
            this.Controls.Add(this.tbBEBuscar);
            this.Controls.Add(this.lbREIdBuscar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BuscarEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Empleado";
            this.Load += new System.EventHandler(this.BuscarEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sisCVidDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbREIdBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private sisCVidDataSet sisCVidDataSet;
        private System.Windows.Forms.BindingSource empleadoBindingSource;
        private sisCVidDataSetTableAdapters.EmpleadoTableAdapter empleadoTableAdapter;
        private sisCVidDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox tbBEBuscar;
        private System.Windows.Forms.Label lbREIdBuscar;
        private System.Windows.Forms.PictureBox pbREIdBuscar;
        private System.Windows.Forms.Button btBEmpleado;
        private System.Windows.Forms.Button btBECancelea;
        private System.Windows.Forms.DataGridView empleadoDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
    }
}