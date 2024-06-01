namespace CONTROL_PASTELERIA_MARGARITA
{
    partial class venta
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxtipopastel = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxsabor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxrelleno = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtleyenda = new System.Windows.Forms.TextBox();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnmenu = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtprecio = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CONTROL_PASTELERIA_MARGARITA.Properties.Resources.FONDOPASTELERIA;
            this.pictureBox1.Location = new System.Drawing.Point(17, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1020, 665);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "TIPO DE PASTEL";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBoxtipopastel
            // 
            this.comboBoxtipopastel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxtipopastel.FormattingEnabled = true;
            this.comboBoxtipopastel.Items.AddRange(new object[] {
            "Ambiente",
            "Crema",
            "Frío",
            "Fondant"});
            this.comboBoxtipopastel.Location = new System.Drawing.Point(394, 43);
            this.comboBoxtipopastel.Name = "comboBoxtipopastel";
            this.comboBoxtipopastel.Size = new System.Drawing.Size(328, 39);
            this.comboBoxtipopastel.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(242, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "SABOR";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboBoxsabor
            // 
            this.comboBoxsabor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxsabor.FormattingEnabled = true;
            this.comboBoxsabor.Items.AddRange(new object[] {
            "Chocolate",
            "Vainilla",
            "Fresa",
            "Moca",
            "Mantequilla",
            "Caramelo"});
            this.comboBoxsabor.Location = new System.Drawing.Point(394, 104);
            this.comboBoxsabor.Name = "comboBoxsabor";
            this.comboBoxsabor.Size = new System.Drawing.Size(328, 39);
            this.comboBoxsabor.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(205, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 36);
            this.label3.TabIndex = 5;
            this.label3.Text = "RELLENO";
            // 
            // comboBoxrelleno
            // 
            this.comboBoxrelleno.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxrelleno.FormattingEnabled = true;
            this.comboBoxrelleno.Items.AddRange(new object[] {
            "Fresa",
            "Manjar",
            "Piña",
            "Dulce de leche"});
            this.comboBoxrelleno.Location = new System.Drawing.Point(394, 162);
            this.comboBoxrelleno.Name = "comboBoxrelleno";
            this.comboBoxrelleno.Size = new System.Drawing.Size(328, 39);
            this.comboBoxrelleno.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(205, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 36);
            this.label4.TabIndex = 7;
            this.label4.Text = "LEYENDA";
            // 
            // txtleyenda
            // 
            this.txtleyenda.Location = new System.Drawing.Point(394, 221);
            this.txtleyenda.Multiline = true;
            this.txtleyenda.Name = "txtleyenda";
            this.txtleyenda.Size = new System.Drawing.Size(328, 54);
            this.txtleyenda.TabIndex = 8;
            this.txtleyenda.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.Color.Cyan;
            this.btnguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.Location = new System.Drawing.Point(484, 445);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(176, 69);
            this.btnguardar.TabIndex = 9;
            this.btnguardar.Text = "GUARDAR";
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btnmenu
            // 
            this.btnmenu.BackColor = System.Drawing.Color.Cyan;
            this.btnmenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmenu.Location = new System.Drawing.Point(96, 445);
            this.btnmenu.Name = "btnmenu";
            this.btnmenu.Size = new System.Drawing.Size(176, 69);
            this.btnmenu.TabIndex = 10;
            this.btnmenu.Text = "MENU";
            this.btnmenu.UseVisualStyleBackColor = false;
            this.btnmenu.Click += new System.EventHandler(this.btnmenu_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(234, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 36);
            this.label5.TabIndex = 11;
            this.label5.Text = "PRECIO";
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(394, 306);
            this.txtprecio.Multiline = true;
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(328, 39);
            this.txtprecio.TabIndex = 12;
            this.txtprecio.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 564);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnmenu);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.txtleyenda);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxrelleno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxsabor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxtipopastel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "venta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ñ-+}/";
            this.Load += new System.EventHandler(this.venta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxtipopastel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxsabor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxrelleno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtleyenda;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btnmenu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtprecio;
    }
}