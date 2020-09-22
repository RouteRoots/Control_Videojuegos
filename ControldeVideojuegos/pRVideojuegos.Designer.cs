namespace ControldeVideojuegos
{
    partial class pRVideojuegos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pRVideojuegos));
            this.tbRVidId = new System.Windows.Forms.TextBox();
            this.tbRComTitulo = new System.Windows.Forms.TextBox();
            this.tbRComGenero = new System.Windows.Forms.TextBox();
            this.tbRComClasificacion = new System.Windows.Forms.TextBox();
            this.lbRVidId = new System.Windows.Forms.Label();
            this.lbRVidTitulo = new System.Windows.Forms.Label();
            this.lbRVidConsola = new System.Windows.Forms.Label();
            this.lbRVidGenero = new System.Windows.Forms.Label();
            this.lbRVidClasificacion = new System.Windows.Forms.Label();
            this.pbRVidModificar = new System.Windows.Forms.PictureBox();
            this.pbRVidBorrar = new System.Windows.Forms.PictureBox();
            this.pbRVidGuardar = new System.Windows.Forms.PictureBox();
            this.pbRVidActualizar = new System.Windows.Forms.PictureBox();
            this.pbRVidBuscar = new System.Windows.Forms.PictureBox();
            this.tbRComConsola = new System.Windows.Forms.ComboBox();
            this.sisCVidDataSet = new ControldeVideojuegos.sisCVidDataSet();
            this.videojuegoBindingSource = new System.Windows.Forms.BindingSource(this.components);
           
            this.tableAdapterManager = new ControldeVideojuegos.sisCVidDataSetTableAdapters.TableAdapterManager();
            this.videojuegoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pbRVidModificar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRVidBorrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRVidGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRVidActualizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRVidBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sisCVidDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videojuegoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videojuegoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tbRVidId
            // 
            this.tbRVidId.Location = new System.Drawing.Point(226, 105);
            this.tbRVidId.Margin = new System.Windows.Forms.Padding(2);
            this.tbRVidId.Name = "tbRVidId";
            this.tbRVidId.Size = new System.Drawing.Size(142, 20);
            this.tbRVidId.TabIndex = 0;
            // 
            // tbRComTitulo
            // 
            this.tbRComTitulo.Location = new System.Drawing.Point(226, 157);
            this.tbRComTitulo.Margin = new System.Windows.Forms.Padding(2);
            this.tbRComTitulo.Name = "tbRComTitulo";
            this.tbRComTitulo.Size = new System.Drawing.Size(142, 20);
            this.tbRComTitulo.TabIndex = 1;
            // 
            // tbRComGenero
            // 
            this.tbRComGenero.Location = new System.Drawing.Point(226, 264);
            this.tbRComGenero.Margin = new System.Windows.Forms.Padding(2);
            this.tbRComGenero.Name = "tbRComGenero";
            this.tbRComGenero.Size = new System.Drawing.Size(142, 20);
            this.tbRComGenero.TabIndex = 3;
            // 
            // tbRComClasificacion
            // 
            this.tbRComClasificacion.Location = new System.Drawing.Point(226, 314);
            this.tbRComClasificacion.Margin = new System.Windows.Forms.Padding(2);
            this.tbRComClasificacion.Name = "tbRComClasificacion";
            this.tbRComClasificacion.Size = new System.Drawing.Size(142, 20);
            this.tbRComClasificacion.TabIndex = 4;
            // 
            // lbRVidId
            // 
            this.lbRVidId.AutoSize = true;
            this.lbRVidId.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRVidId.Location = new System.Drawing.Point(103, 106);
            this.lbRVidId.Name = "lbRVidId";
            this.lbRVidId.Size = new System.Drawing.Size(104, 19);
            this.lbRVidId.TabIndex = 5;
            this.lbRVidId.Text = "ID. Videjuego:";
            // 
            // lbRVidTitulo
            // 
            this.lbRVidTitulo.AutoSize = true;
            this.lbRVidTitulo.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRVidTitulo.Location = new System.Drawing.Point(103, 158);
            this.lbRVidTitulo.Name = "lbRVidTitulo";
            this.lbRVidTitulo.Size = new System.Drawing.Size(52, 19);
            this.lbRVidTitulo.TabIndex = 6;
            this.lbRVidTitulo.Text = "Titulo:";
            // 
            // lbRVidConsola
            // 
            this.lbRVidConsola.AutoSize = true;
            this.lbRVidConsola.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRVidConsola.Location = new System.Drawing.Point(103, 211);
            this.lbRVidConsola.Name = "lbRVidConsola";
            this.lbRVidConsola.Size = new System.Drawing.Size(61, 19);
            this.lbRVidConsola.TabIndex = 7;
            this.lbRVidConsola.Text = "Consola:";
            // 
            // lbRVidGenero
            // 
            this.lbRVidGenero.AutoSize = true;
            this.lbRVidGenero.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRVidGenero.Location = new System.Drawing.Point(103, 265);
            this.lbRVidGenero.Name = "lbRVidGenero";
            this.lbRVidGenero.Size = new System.Drawing.Size(58, 19);
            this.lbRVidGenero.TabIndex = 8;
            this.lbRVidGenero.Text = "Genero:";
            // 
            // lbRVidClasificacion
            // 
            this.lbRVidClasificacion.AutoSize = true;
            this.lbRVidClasificacion.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRVidClasificacion.Location = new System.Drawing.Point(103, 315);
            this.lbRVidClasificacion.Name = "lbRVidClasificacion";
            this.lbRVidClasificacion.Size = new System.Drawing.Size(94, 19);
            this.lbRVidClasificacion.TabIndex = 9;
            this.lbRVidClasificacion.Text = "Clasificación:";
            // 
            // pbRVidModificar
            // 
            this.pbRVidModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbRVidModificar.Image = ((System.Drawing.Image)(resources.GetObject("pbRVidModificar.Image")));
            this.pbRVidModificar.Location = new System.Drawing.Point(465, 366);
            this.pbRVidModificar.Name = "pbRVidModificar";
            this.pbRVidModificar.Size = new System.Drawing.Size(56, 50);
            this.pbRVidModificar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRVidModificar.TabIndex = 10;
            this.pbRVidModificar.TabStop = false;
            // 
            // pbRVidBorrar
            // 
            this.pbRVidBorrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbRVidBorrar.Image = ((System.Drawing.Image)(resources.GetObject("pbRVidBorrar.Image")));
            this.pbRVidBorrar.Location = new System.Drawing.Point(545, 366);
            this.pbRVidBorrar.Name = "pbRVidBorrar";
            this.pbRVidBorrar.Size = new System.Drawing.Size(56, 50);
            this.pbRVidBorrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRVidBorrar.TabIndex = 11;
            this.pbRVidBorrar.TabStop = false;
            // 
            // pbRVidGuardar
            // 
            this.pbRVidGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbRVidGuardar.Image = ((System.Drawing.Image)(resources.GetObject("pbRVidGuardar.Image")));
            this.pbRVidGuardar.Location = new System.Drawing.Point(625, 366);
            this.pbRVidGuardar.Name = "pbRVidGuardar";
            this.pbRVidGuardar.Size = new System.Drawing.Size(56, 50);
            this.pbRVidGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRVidGuardar.TabIndex = 12;
            this.pbRVidGuardar.TabStop = false;
            // 
            // pbRVidActualizar
            // 
            this.pbRVidActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbRVidActualizar.Image = ((System.Drawing.Image)(resources.GetObject("pbRVidActualizar.Image")));
            this.pbRVidActualizar.Location = new System.Drawing.Point(705, 366);
            this.pbRVidActualizar.Name = "pbRVidActualizar";
            this.pbRVidActualizar.Size = new System.Drawing.Size(56, 50);
            this.pbRVidActualizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRVidActualizar.TabIndex = 13;
            this.pbRVidActualizar.TabStop = false;
            // 
            // pbRVidBuscar
            // 
            this.pbRVidBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbRVidBuscar.Image = ((System.Drawing.Image)(resources.GetObject("pbRVidBuscar.Image")));
            this.pbRVidBuscar.Location = new System.Drawing.Point(785, 366);
            this.pbRVidBuscar.Name = "pbRVidBuscar";
            this.pbRVidBuscar.Size = new System.Drawing.Size(56, 50);
            this.pbRVidBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRVidBuscar.TabIndex = 14;
            this.pbRVidBuscar.TabStop = false;
            // 
            // tbRComConsola
            // 
            this.tbRComConsola.FormattingEnabled = true;
            this.tbRComConsola.Location = new System.Drawing.Point(226, 209);
            this.tbRComConsola.Name = "tbRComConsola";
            this.tbRComConsola.Size = new System.Drawing.Size(142, 21);
            this.tbRComConsola.TabIndex = 15;
            // 
            // sisCVidDataSet
            // 
            this.sisCVidDataSet.DataSetName = "sisCVidDataSet";
            this.sisCVidDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // videojuegoBindingSource
            // 
            this.videojuegoBindingSource.DataMember = "Videojuego";
            this.videojuegoBindingSource.DataSource = this.sisCVidDataSet;
            // 
            // videojuegoTableAdapter
            // 
          
            // 
            // videojuegoDataGridView
            // 
            this.videojuegoDataGridView.AutoGenerateColumns = false;
            this.videojuegoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.videojuegoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.videojuegoDataGridView.DataSource = this.videojuegoBindingSource;
            this.videojuegoDataGridView.Location = new System.Drawing.Point(456, 105);
            this.videojuegoDataGridView.Name = "videojuegoDataGridView";
            this.videojuegoDataGridView.Size = new System.Drawing.Size(394, 220);
            this.videojuegoDataGridView.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdVidejuego";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdVidejuego";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Titulo";
            this.dataGridViewTextBoxColumn2.HeaderText = "Titulo";
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
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Genero";
            this.dataGridViewTextBoxColumn4.HeaderText = "Genero";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Clasificacion";
            this.dataGridViewTextBoxColumn5.HeaderText = "Clasificacion";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // pRVideojuegos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.videojuegoDataGridView);
            this.Controls.Add(this.tbRComConsola);
            this.Controls.Add(this.pbRVidBuscar);
            this.Controls.Add(this.pbRVidActualizar);
            this.Controls.Add(this.pbRVidGuardar);
            this.Controls.Add(this.pbRVidBorrar);
            this.Controls.Add(this.pbRVidModificar);
            this.Controls.Add(this.lbRVidClasificacion);
            this.Controls.Add(this.lbRVidGenero);
            this.Controls.Add(this.lbRVidConsola);
            this.Controls.Add(this.lbRVidTitulo);
            this.Controls.Add(this.lbRVidId);
            this.Controls.Add(this.tbRComClasificacion);
            this.Controls.Add(this.tbRComGenero);
            this.Controls.Add(this.tbRComTitulo);
            this.Controls.Add(this.tbRVidId);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "pRVideojuegos";
            this.Size = new System.Drawing.Size(916, 572);
            ((System.ComponentModel.ISupportInitialize)(this.pbRVidModificar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRVidBorrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRVidGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRVidActualizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRVidBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sisCVidDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videojuegoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videojuegoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbRVidId;
        private System.Windows.Forms.TextBox tbRComTitulo;
        private System.Windows.Forms.TextBox tbRComGenero;
        private System.Windows.Forms.TextBox tbRComClasificacion;
        private System.Windows.Forms.Label lbRVidId;
        private System.Windows.Forms.Label lbRVidTitulo;
        private System.Windows.Forms.Label lbRVidConsola;
        private System.Windows.Forms.Label lbRVidGenero;
        private System.Windows.Forms.Label lbRVidClasificacion;
        private System.Windows.Forms.PictureBox pbRVidModificar;
        private System.Windows.Forms.PictureBox pbRVidBorrar;
        private System.Windows.Forms.PictureBox pbRVidGuardar;
        private System.Windows.Forms.PictureBox pbRVidActualizar;
        private System.Windows.Forms.PictureBox pbRVidBuscar;
        private System.Windows.Forms.ComboBox tbRComConsola;
        private sisCVidDataSet sisCVidDataSet;
        private System.Windows.Forms.BindingSource videojuegoBindingSource;
        
        private sisCVidDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView videojuegoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}
