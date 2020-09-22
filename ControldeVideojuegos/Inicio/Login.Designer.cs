namespace ControldeVideojuegos
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pbUser = new System.Windows.Forms.PictureBox();
            this.pbPassword = new System.Windows.Forms.PictureBox();
            this.btLAceptar = new System.Windows.Forms.Button();
            this.pbBLMinimize = new System.Windows.Forms.PictureBox();
            this.pbBLClose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBLMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBLClose)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(80, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 78);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(127, 141);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(142, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(127, 200);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(142, 20);
            this.textBox2.TabIndex = 2;
            // 
            // pbUser
            // 
            this.pbUser.Image = ((System.Drawing.Image)(resources.GetObject("pbUser.Image")));
            this.pbUser.Location = new System.Drawing.Point(73, 134);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(38, 40);
            this.pbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUser.TabIndex = 3;
            this.pbUser.TabStop = false;
            // 
            // pbPassword
            // 
            this.pbPassword.Image = ((System.Drawing.Image)(resources.GetObject("pbPassword.Image")));
            this.pbPassword.Location = new System.Drawing.Point(73, 189);
            this.pbPassword.Name = "pbPassword";
            this.pbPassword.Size = new System.Drawing.Size(38, 40);
            this.pbPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPassword.TabIndex = 4;
            this.pbPassword.TabStop = false;
            // 
            // btLAceptar
            // 
            this.btLAceptar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btLAceptar.Image")));
            this.btLAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLAceptar.Location = new System.Drawing.Point(127, 256);
            this.btLAceptar.Name = "btLAceptar";
            this.btLAceptar.Size = new System.Drawing.Size(136, 48);
            this.btLAceptar.TabIndex = 5;
            this.btLAceptar.Text = "Aceptar";
            this.btLAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btLAceptar.UseVisualStyleBackColor = true;
            this.btLAceptar.Click += new System.EventHandler(this.btLAceptar_Click);
            // 
            // pbBLMinimize
            // 
            this.pbBLMinimize.Image = ((System.Drawing.Image)(resources.GetObject("pbBLMinimize.Image")));
            this.pbBLMinimize.Location = new System.Drawing.Point(293, 12);
            this.pbBLMinimize.Name = "pbBLMinimize";
            this.pbBLMinimize.Size = new System.Drawing.Size(30, 37);
            this.pbBLMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBLMinimize.TabIndex = 6;
            this.pbBLMinimize.TabStop = false;
            this.pbBLMinimize.Click += new System.EventHandler(this.pbBLMinimize_Click);
            // 
            // pbBLClose
            // 
            this.pbBLClose.Image = ((System.Drawing.Image)(resources.GetObject("pbBLClose.Image")));
            this.pbBLClose.Location = new System.Drawing.Point(329, 12);
            this.pbBLClose.Name = "pbBLClose";
            this.pbBLClose.Size = new System.Drawing.Size(30, 37);
            this.pbBLClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBLClose.TabIndex = 7;
            this.pbBLClose.TabStop = false;
            this.pbBLClose.Click += new System.EventHandler(this.pbBLClose_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(366, 367);
            this.Controls.Add(this.pbBLClose);
            this.Controls.Add(this.pbBLMinimize);
            this.Controls.Add(this.btLAceptar);
            this.Controls.Add(this.pbPassword);
            this.Controls.Add(this.pbUser);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBLMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBLClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pbUser;
        private System.Windows.Forms.PictureBox pbPassword;
        private System.Windows.Forms.Button btLAceptar;
        private System.Windows.Forms.PictureBox pbBLMinimize;
        private System.Windows.Forms.PictureBox pbBLClose;
    }
}