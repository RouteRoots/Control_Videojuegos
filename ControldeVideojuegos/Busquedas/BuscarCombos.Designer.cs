namespace ControldeVideojuegos
{
    partial class BuscarCombos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarCombos));
            this.sisCVidDataSet = new ControldeVideojuegos.sisCVidDataSet();
            this.comboBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new ControldeVideojuegos.sisCVidDataSetTableAdapters.TableAdapterManager();
            this.comboDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbRComIdBuscar = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btBCombo = new System.Windows.Forms.Button();
            this.btBCCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sisCVidDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sisCVidDataSet
            // 
            this.sisCVidDataSet.DataSetName = "sisCVidDataSet";
            this.sisCVidDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBindingSource
            // 
            this.comboBindingSource.DataMember = "Combo";
            this.comboBindingSource.DataSource = this.sisCVidDataSet;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.EmpleadoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ControldeVideojuegos.sisCVidDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // comboDataGridView
            // 
            this.comboDataGridView.AutoGenerateColumns = false;
            this.comboDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.comboDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.comboDataGridView.DataSource = this.comboBindingSource;
            this.comboDataGridView.Location = new System.Drawing.Point(24, 103);
            this.comboDataGridView.Name = "comboDataGridView";
            this.comboDataGridView.Size = new System.Drawing.Size(556, 157);
            this.comboDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdCombo";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdCombo";
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
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NoControles";
            this.dataGridViewTextBoxColumn3.HeaderText = "NoControles";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "RefAg";
            this.dataGridViewTextBoxColumn4.HeaderText = "RefAg";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PalPas";
            this.dataGridViewTextBoxColumn5.HeaderText = "PalPas";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "NoHoras";
            this.dataGridViewTextBoxColumn6.HeaderText = "NoHoras";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Costo";
            this.dataGridViewTextBoxColumn7.HeaderText = "Costo";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // lbRComIdBuscar
            // 
            this.lbRComIdBuscar.AutoSize = true;
            this.lbRComIdBuscar.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRComIdBuscar.Location = new System.Drawing.Point(105, 42);
            this.lbRComIdBuscar.Name = "lbRComIdBuscar";
            this.lbRComIdBuscar.Size = new System.Drawing.Size(83, 19);
            this.lbRComIdBuscar.TabIndex = 2;
            this.lbRComIdBuscar.Text = "ID. Combo:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(228, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(142, 20);
            this.textBox1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(448, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btBCombo
            // 
            this.btBCombo.Location = new System.Drawing.Point(36, 294);
            this.btBCombo.Name = "btBCombo";
            this.btBCombo.Size = new System.Drawing.Size(75, 23);
            this.btBCombo.TabIndex = 5;
            this.btBCombo.Text = "Aceptar";
            this.btBCombo.UseVisualStyleBackColor = true;
            this.btBCombo.Click += new System.EventHandler(this.btBCombo_Click);
            // 
            // btBCCancelar
            // 
            this.btBCCancelar.Location = new System.Drawing.Point(495, 294);
            this.btBCCancelar.Name = "btBCCancelar";
            this.btBCCancelar.Size = new System.Drawing.Size(75, 23);
            this.btBCCancelar.TabIndex = 6;
            this.btBCCancelar.Text = "Cancelar";
            this.btBCCancelar.UseVisualStyleBackColor = true;
            // 
            // BuscarCombos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 343);
            this.Controls.Add(this.btBCCancelar);
            this.Controls.Add(this.btBCombo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbRComIdBuscar);
            this.Controls.Add(this.comboDataGridView);
            this.Name = "BuscarCombos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Empleado";
            this.Load += new System.EventHandler(this.BuscarCombos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sisCVidDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private sisCVidDataSet sisCVidDataSet;
        private System.Windows.Forms.BindingSource comboBindingSource;
        
        private sisCVidDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView comboDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Label lbRComIdBuscar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btBCombo;
        private System.Windows.Forms.Button btBCCancelar;
    }
}