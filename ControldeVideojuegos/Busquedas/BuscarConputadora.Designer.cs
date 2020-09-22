namespace ControldeVideojuegos
{
    partial class BuscarConputadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarConputadora));
            this.pbRCompBuscar = new System.Windows.Forms.PictureBox();
            this.tbBCompBuscar = new System.Windows.Forms.TextBox();
            this.lbRCompIdBuscar = new System.Windows.Forms.Label();
            this.btBCompCancelar = new System.Windows.Forms.Button();
            this.btBComp = new System.Windows.Forms.Button();
            this.sisCVidDataSet = new ControldeVideojuegos.sisCVidDataSet();
            this.computadoraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.computadoraDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pbRCompBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sisCVidDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computadoraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computadoraDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pbRCompBuscar
            // 
            this.pbRCompBuscar.Image = ((System.Drawing.Image)(resources.GetObject("pbRCompBuscar.Image")));
            this.pbRCompBuscar.Location = new System.Drawing.Point(448, 30);
            this.pbRCompBuscar.Name = "pbRCompBuscar";
            this.pbRCompBuscar.Size = new System.Drawing.Size(40, 31);
            this.pbRCompBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRCompBuscar.TabIndex = 7;
            this.pbRCompBuscar.TabStop = false;
            this.pbRCompBuscar.Click += new System.EventHandler(this.pbRCompBuscar_Click);
            // 
            // tbBCompBuscar
            // 
            this.tbBCompBuscar.Location = new System.Drawing.Point(228, 41);
            this.tbBCompBuscar.Name = "tbBCompBuscar";
            this.tbBCompBuscar.Size = new System.Drawing.Size(142, 20);
            this.tbBCompBuscar.TabIndex = 6;
            // 
            // lbRCompIdBuscar
            // 
            this.lbRCompIdBuscar.AutoSize = true;
            this.lbRCompIdBuscar.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRCompIdBuscar.Location = new System.Drawing.Point(105, 42);
            this.lbRCompIdBuscar.Name = "lbRCompIdBuscar";
            this.lbRCompIdBuscar.Size = new System.Drawing.Size(123, 19);
            this.lbRCompIdBuscar.TabIndex = 5;
            this.lbRCompIdBuscar.Text = "ID. Computadora:";
            // 
            // btBCompCancelar
            // 
            this.btBCompCancelar.Location = new System.Drawing.Point(499, 280);
            this.btBCompCancelar.Name = "btBCompCancelar";
            this.btBCompCancelar.Size = new System.Drawing.Size(75, 23);
            this.btBCompCancelar.TabIndex = 9;
            this.btBCompCancelar.Text = "Cancelar";
            this.btBCompCancelar.UseVisualStyleBackColor = true;
            // 
            // btBComp
            // 
            this.btBComp.Location = new System.Drawing.Point(40, 280);
            this.btBComp.Name = "btBComp";
            this.btBComp.Size = new System.Drawing.Size(75, 23);
            this.btBComp.TabIndex = 8;
            this.btBComp.Text = "Aceptar";
            this.btBComp.UseVisualStyleBackColor = true;
            this.btBComp.Click += new System.EventHandler(this.btBComp_Click);
            // 
            // sisCVidDataSet
            // 
            this.sisCVidDataSet.DataSetName = "sisCVidDataSet";
            this.sisCVidDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // computadoraBindingSource
            // 
            this.computadoraBindingSource.DataMember = "Computadora";
            this.computadoraBindingSource.DataSource = this.sisCVidDataSet;
            // 
            // computadoraDataGridView
            // 
            this.computadoraDataGridView.AutoGenerateColumns = false;
            this.computadoraDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.computadoraDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.computadoraDataGridView.DataSource = this.computadoraBindingSource;
            this.computadoraDataGridView.Location = new System.Drawing.Point(24, 103);
            this.computadoraDataGridView.Name = "computadoraDataGridView";
            this.computadoraDataGridView.Size = new System.Drawing.Size(556, 157);
            this.computadoraDataGridView.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdComputadora";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdComputadora";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Marca";
            this.dataGridViewTextBoxColumn2.HeaderText = "Marca";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Capasidad";
            this.dataGridViewTextBoxColumn3.HeaderText = "Capasidad";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "MemoriaRam";
            this.dataGridViewTextBoxColumn4.HeaderText = "MemoriaRam";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Procesador";
            this.dataGridViewTextBoxColumn5.HeaderText = "Procesador";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Año";
            this.dataGridViewTextBoxColumn6.HeaderText = "Año";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Estado";
            this.dataGridViewTextBoxColumn7.HeaderText = "Estado";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Disponibilidad";
            this.dataGridViewTextBoxColumn8.HeaderText = "Disponibilidad";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // BuscarConputadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 395);
            this.Controls.Add(this.computadoraDataGridView);
            this.Controls.Add(this.btBCompCancelar);
            this.Controls.Add(this.btBComp);
            this.Controls.Add(this.pbRCompBuscar);
            this.Controls.Add(this.tbBCompBuscar);
            this.Controls.Add(this.lbRCompIdBuscar);
            this.Name = "BuscarConputadora";
            this.Text = "BuscarConputadora";
            this.Load += new System.EventHandler(this.BuscarConputadora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbRCompBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sisCVidDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computadoraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computadoraDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbRCompBuscar;
        private System.Windows.Forms.TextBox tbBCompBuscar;
        private System.Windows.Forms.Label lbRCompIdBuscar;
        private System.Windows.Forms.Button btBCompCancelar;
        private System.Windows.Forms.Button btBComp;
        private sisCVidDataSet sisCVidDataSet;
        private System.Windows.Forms.BindingSource computadoraBindingSource;
        private System.Windows.Forms.DataGridView computadoraDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}