namespace CONTROL_PASTELERIA_MARGARITA
{
    partial class menu
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
            this.btnventa = new System.Windows.Forms.Button();
            this.btnhistorial = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnventa
            // 
            this.btnventa.BackColor = System.Drawing.Color.Cyan;
            this.btnventa.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnventa.Location = new System.Drawing.Point(121, 255);
            this.btnventa.Name = "btnventa";
            this.btnventa.Size = new System.Drawing.Size(200, 96);
            this.btnventa.TabIndex = 2;
            this.btnventa.Text = "VENTA";
            this.btnventa.UseVisualStyleBackColor = false;
            this.btnventa.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnhistorial
            // 
            this.btnhistorial.BackColor = System.Drawing.Color.Cyan;
            this.btnhistorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhistorial.Location = new System.Drawing.Point(461, 255);
            this.btnhistorial.Name = "btnhistorial";
            this.btnhistorial.Size = new System.Drawing.Size(206, 96);
            this.btnhistorial.TabIndex = 5;
            this.btnhistorial.Text = "HISTORIAL";
            this.btnhistorial.UseVisualStyleBackColor = false;
            this.btnhistorial.Click += new System.EventHandler(this.btnhistorial_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.Cyan;
            this.btnsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.Location = new System.Drawing.Point(813, 255);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(190, 96);
            this.btnsalir.TabIndex = 7;
            this.btnsalir.Text = "SALIR";
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.button6_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CONTROL_PASTELERIA_MARGARITA.Properties.Resources.FONDOPASTELERIA;
            this.pictureBox1.Location = new System.Drawing.Point(24, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1037, 472);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
           // this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Cyan;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(407, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 91);
            this.label1.TabIndex = 8;
            this.label1.Text = "MENU";
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 476);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnhistorial);
            this.Controls.Add(this.btnventa);
            this.Controls.Add(this.pictureBox1);
            this.Name = "menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnventa;
        private System.Windows.Forms.Button btnhistorial;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Label label1;
    }
}