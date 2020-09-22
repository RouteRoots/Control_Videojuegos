namespace ControldeVideojuegos
{
    partial class Menu
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.pMenu = new System.Windows.Forms.Panel();
            this.btRVideojuegos = new System.Windows.Forms.Button();
            this.InPanel = new System.Windows.Forms.Panel();
            this.pLogo = new System.Windows.Forms.Panel();
            this.lbNsala = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btCCaja = new System.Windows.Forms.Button();
            this.btRCombos = new System.Windows.Forms.Button();
            this.btRConsolas = new System.Windows.Forms.Button();
            this.btRComputadoras = new System.Windows.Forms.Button();
            this.btREmpleado = new System.Windows.Forms.Button();
            this.btInicio = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pMClose = new System.Windows.Forms.PictureBox();
            this.pMMinimize = new System.Windows.Forms.PictureBox();
            this.pHome1 = new ControldeVideojuegos.pHome();
            this.pMenu.SuspendLayout();
            this.pLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pMClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMMinimize)).BeginInit();
            this.SuspendLayout();
            // 
            // pMenu
            // 
            this.pMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pMenu.Controls.Add(this.btRVideojuegos);
            this.pMenu.Controls.Add(this.InPanel);
            this.pMenu.Controls.Add(this.pLogo);
            this.pMenu.Controls.Add(this.btCCaja);
            this.pMenu.Controls.Add(this.btRCombos);
            this.pMenu.Controls.Add(this.btRConsolas);
            this.pMenu.Controls.Add(this.btRComputadoras);
            this.pMenu.Controls.Add(this.btREmpleado);
            this.pMenu.Controls.Add(this.btInicio);
            this.pMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pMenu.Location = new System.Drawing.Point(0, 0);
            this.pMenu.Margin = new System.Windows.Forms.Padding(2);
            this.pMenu.Name = "pMenu";
            this.pMenu.Size = new System.Drawing.Size(240, 741);
            this.pMenu.TabIndex = 0;
            this.pMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.pMenu_Paint);
            // 
            // btRVideojuegos
            // 
            this.btRVideojuegos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btRVideojuegos.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRVideojuegos.ForeColor = System.Drawing.Color.Black;
            this.btRVideojuegos.Image = ((System.Drawing.Image)(resources.GetObject("btRVideojuegos.Image")));
            this.btRVideojuegos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btRVideojuegos.Location = new System.Drawing.Point(10, 427);
            this.btRVideojuegos.Margin = new System.Windows.Forms.Padding(2);
            this.btRVideojuegos.Name = "btRVideojuegos";
            this.btRVideojuegos.Size = new System.Drawing.Size(228, 58);
            this.btRVideojuegos.TabIndex = 3;
            this.btRVideojuegos.Text = "Registro de Videojuegos";
            this.btRVideojuegos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btRVideojuegos.UseVisualStyleBackColor = true;
            this.btRVideojuegos.Click += new System.EventHandler(this.btRVideojuegos_Click);
            // 
            // InPanel
            // 
            this.InPanel.BackColor = System.Drawing.Color.DarkRed;
            this.InPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.InPanel.Location = new System.Drawing.Point(2, 232);
            this.InPanel.Margin = new System.Windows.Forms.Padding(2);
            this.InPanel.Name = "InPanel";
            this.InPanel.Size = new System.Drawing.Size(8, 59);
            this.InPanel.TabIndex = 16;
            this.InPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.InPanel_Paint);
            // 
            // pLogo
            // 
            this.pLogo.BackColor = System.Drawing.Color.DarkRed;
            this.pLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pLogo.Controls.Add(this.lbNsala);
            this.pLogo.Controls.Add(this.pbLogo);
            this.pLogo.Location = new System.Drawing.Point(38, 10);
            this.pLogo.Margin = new System.Windows.Forms.Padding(2);
            this.pLogo.Name = "pLogo";
            this.pLogo.Size = new System.Drawing.Size(167, 111);
            this.pLogo.TabIndex = 0;
            // 
            // lbNsala
            // 
            this.lbNsala.AutoSize = true;
            this.lbNsala.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNsala.ForeColor = System.Drawing.Color.White;
            this.lbNsala.Location = new System.Drawing.Point(15, 75);
            this.lbNsala.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNsala.Name = "lbNsala";
            this.lbNsala.Size = new System.Drawing.Size(145, 19);
            this.lbNsala.TabIndex = 1;
            this.lbNsala.Text = "Sala de Videojuegos";
            this.lbNsala.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbNsala.Click += new System.EventHandler(this.label1_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.DarkRed;
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(18, 11);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(2);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(130, 61);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // btCCaja
            // 
            this.btCCaja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCCaja.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCCaja.ForeColor = System.Drawing.Color.Black;
            this.btCCaja.Image = ((System.Drawing.Image)(resources.GetObject("btCCaja.Image")));
            this.btCCaja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCCaja.Location = new System.Drawing.Point(22, 670);
            this.btCCaja.Margin = new System.Windows.Forms.Padding(2);
            this.btCCaja.Name = "btCCaja";
            this.btCCaja.Size = new System.Drawing.Size(195, 58);
            this.btCCaja.TabIndex = 6;
            this.btCCaja.Text = "Probar Conexión";
            this.btCCaja.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btCCaja.UseVisualStyleBackColor = true;
            this.btCCaja.Click += new System.EventHandler(this.btCCaja_Click);
            // 
            // btRCombos
            // 
            this.btRCombos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btRCombos.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRCombos.ForeColor = System.Drawing.Color.Black;
            this.btRCombos.Image = ((System.Drawing.Image)(resources.GetObject("btRCombos.Image")));
            this.btRCombos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btRCombos.Location = new System.Drawing.Point(10, 492);
            this.btRCombos.Margin = new System.Windows.Forms.Padding(2);
            this.btRCombos.Name = "btRCombos";
            this.btRCombos.Size = new System.Drawing.Size(228, 58);
            this.btRCombos.TabIndex = 4;
            this.btRCombos.Text = "Registro de Combos";
            this.btRCombos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btRCombos.UseVisualStyleBackColor = true;
            this.btRCombos.Click += new System.EventHandler(this.btRCombos_Click);
            // 
            // btRConsolas
            // 
            this.btRConsolas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btRConsolas.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRConsolas.ForeColor = System.Drawing.Color.Black;
            this.btRConsolas.Image = ((System.Drawing.Image)(resources.GetObject("btRConsolas.Image")));
            this.btRConsolas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btRConsolas.Location = new System.Drawing.Point(10, 362);
            this.btRConsolas.Margin = new System.Windows.Forms.Padding(2);
            this.btRConsolas.Name = "btRConsolas";
            this.btRConsolas.Size = new System.Drawing.Size(228, 58);
            this.btRConsolas.TabIndex = 3;
            this.btRConsolas.Text = "Registro de Consolas";
            this.btRConsolas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btRConsolas.UseVisualStyleBackColor = true;
            this.btRConsolas.Click += new System.EventHandler(this.btRConsolas_Click);
            // 
            // btRComputadoras
            // 
            this.btRComputadoras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btRComputadoras.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRComputadoras.ForeColor = System.Drawing.Color.Black;
            this.btRComputadoras.Image = ((System.Drawing.Image)(resources.GetObject("btRComputadoras.Image")));
            this.btRComputadoras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btRComputadoras.Location = new System.Drawing.Point(10, 297);
            this.btRComputadoras.Margin = new System.Windows.Forms.Padding(2);
            this.btRComputadoras.Name = "btRComputadoras";
            this.btRComputadoras.Size = new System.Drawing.Size(228, 58);
            this.btRComputadoras.TabIndex = 2;
            this.btRComputadoras.Text = "Registro de computadoras";
            this.btRComputadoras.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btRComputadoras.UseVisualStyleBackColor = true;
            this.btRComputadoras.Click += new System.EventHandler(this.btRComputadoras_Click);
            // 
            // btREmpleado
            // 
            this.btREmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btREmpleado.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btREmpleado.ForeColor = System.Drawing.Color.Black;
            this.btREmpleado.Image = ((System.Drawing.Image)(resources.GetObject("btREmpleado.Image")));
            this.btREmpleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btREmpleado.Location = new System.Drawing.Point(10, 232);
            this.btREmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.btREmpleado.Name = "btREmpleado";
            this.btREmpleado.Size = new System.Drawing.Size(228, 58);
            this.btREmpleado.TabIndex = 1;
            this.btREmpleado.Text = "Registro de Empleados";
            this.btREmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btREmpleado.UseVisualStyleBackColor = true;
            this.btREmpleado.Click += new System.EventHandler(this.btREmpleado_Click);
            // 
            // btInicio
            // 
            this.btInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btInicio.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInicio.ForeColor = System.Drawing.Color.Black;
            this.btInicio.Image = ((System.Drawing.Image)(resources.GetObject("btInicio.Image")));
            this.btInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btInicio.Location = new System.Drawing.Point(10, 167);
            this.btInicio.Margin = new System.Windows.Forms.Padding(2);
            this.btInicio.Name = "btInicio";
            this.btInicio.Size = new System.Drawing.Size(228, 58);
            this.btInicio.TabIndex = 0;
            this.btInicio.Text = "Inicio";
            this.btInicio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btInicio.UseVisualStyleBackColor = true;
            this.btInicio.Click += new System.EventHandler(this.btInicio_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(39, 741);
            this.panel2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(240, 687);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 54);
            this.panel1.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkRed;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Controls.Add(this.pMClose);
            this.panel3.Controls.Add(this.pMMinimize);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(240, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(960, 72);
            this.panel3.TabIndex = 5;
            // 
            // pMClose
            // 
            this.pMClose.Image = ((System.Drawing.Image)(resources.GetObject("pMClose.Image")));
            this.pMClose.Location = new System.Drawing.Point(924, 3);
            this.pMClose.Name = "pMClose";
            this.pMClose.Size = new System.Drawing.Size(30, 37);
            this.pMClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pMClose.TabIndex = 1;
            this.pMClose.TabStop = false;
            this.pMClose.Click += new System.EventHandler(this.pMClose_Click);
            // 
            // pMMinimize
            // 
            this.pMMinimize.Image = ((System.Drawing.Image)(resources.GetObject("pMMinimize.Image")));
            this.pMMinimize.Location = new System.Drawing.Point(888, 3);
            this.pMMinimize.Name = "pMMinimize";
            this.pMMinimize.Size = new System.Drawing.Size(30, 37);
            this.pMMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pMMinimize.TabIndex = 0;
            this.pMMinimize.TabStop = false;
            this.pMMinimize.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pHome1
            // 
            this.pHome1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pHome1.Location = new System.Drawing.Point(263, 89);
            this.pHome1.Name = "pHome1";
            this.pHome1.Size = new System.Drawing.Size(916, 572);
            this.pHome1.TabIndex = 9;
            // 
            // Menu
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1239, 741);
            this.Controls.Add(this.pHome1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                        ";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.pMenu.ResumeLayout(false);
            this.pLogo.ResumeLayout(false);
            this.pLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pMClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMMinimize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pMenu;
        private System.Windows.Forms.Button btCCaja;
        private System.Windows.Forms.Button btRCombos;
        private System.Windows.Forms.Button btRConsolas;
        private System.Windows.Forms.Button btRComputadoras;
        private System.Windows.Forms.Button btREmpleado;
        private System.Windows.Forms.Button btInicio;
        private System.Windows.Forms.Panel pLogo;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lbNsala;
        private System.Windows.Forms.Panel InPanel;
        private System.Windows.Forms.Button btRVideojuegos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private pHome pHome1;
        private System.Windows.Forms.PictureBox pMClose;
        private System.Windows.Forms.PictureBox pMMinimize;
    }
}

