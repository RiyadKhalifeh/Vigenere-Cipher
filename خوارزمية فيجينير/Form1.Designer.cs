namespace خوارزمية_فيجينير
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxKey = new System.Windows.Forms.GroupBox();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxDecipher = new System.Windows.Forms.GroupBox();
            this.textBoxDecipher = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.groupBoxCipher = new System.Windows.Forms.GroupBox();
            this.textBoxCipher = new System.Windows.Forms.TextBox();
            this.groupBoxPlain = new System.Windows.Forms.GroupBox();
            this.textBoxPlain = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxKey.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBoxDecipher.SuspendLayout();
            this.groupBoxCipher.SuspendLayout();
            this.groupBoxPlain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1152, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBoxKey
            // 
            this.groupBoxKey.Controls.Add(this.textBoxKey);
            this.groupBoxKey.Location = new System.Drawing.Point(5, 101);
            this.groupBoxKey.Name = "groupBoxKey";
            this.groupBoxKey.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBoxKey.Size = new System.Drawing.Size(1135, 67);
            this.groupBoxKey.TabIndex = 1;
            this.groupBoxKey.TabStop = false;
            this.groupBoxKey.Text = "مفتاح التشفير";
            // 
            // textBoxKey
            // 
            this.textBoxKey.Location = new System.Drawing.Point(19, 24);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxKey.Size = new System.Drawing.Size(1074, 24);
            this.textBoxKey.TabIndex = 0;
            this.textBoxKey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxKey_KeyDown);
            this.textBoxKey.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxKey_KeyPress);
            this.textBoxKey.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBoxKey_MouseDown);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.groupBoxDecipher);
            this.panel1.Controls.Add(this.buttonClear);
            this.panel1.Controls.Add(this.buttonDecrypt);
            this.panel1.Controls.Add(this.buttonEncrypt);
            this.panel1.Controls.Add(this.groupBoxCipher);
            this.panel1.Controls.Add(this.groupBoxPlain);
            this.panel1.Location = new System.Drawing.Point(5, 174);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1135, 253);
            this.panel1.TabIndex = 2;
            // 
            // groupBoxDecipher
            // 
            this.groupBoxDecipher.Controls.Add(this.textBoxDecipher);
            this.groupBoxDecipher.Location = new System.Drawing.Point(11, 16);
            this.groupBoxDecipher.Name = "groupBoxDecipher";
            this.groupBoxDecipher.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBoxDecipher.Size = new System.Drawing.Size(292, 208);
            this.groupBoxDecipher.TabIndex = 9;
            this.groupBoxDecipher.TabStop = false;
            this.groupBoxDecipher.Text = "النص مفكوك التشفير";
            // 
            // textBoxDecipher
            // 
            this.textBoxDecipher.Location = new System.Drawing.Point(6, 23);
            this.textBoxDecipher.Multiline = true;
            this.textBoxDecipher.Name = "textBoxDecipher";
            this.textBoxDecipher.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxDecipher.Size = new System.Drawing.Size(280, 176);
            this.textBoxDecipher.TabIndex = 1;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(314, 117);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(87, 31);
            this.buttonClear.TabIndex = 8;
            this.buttonClear.Text = "مسح";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Location = new System.Drawing.Point(314, 80);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(87, 31);
            this.buttonDecrypt.TabIndex = 7;
            this.buttonDecrypt.Text = "فك تشفير";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click);
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Location = new System.Drawing.Point(708, 87);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(87, 52);
            this.buttonEncrypt.TabIndex = 4;
            this.buttonEncrypt.Text = "تشفير";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
            // 
            // groupBoxCipher
            // 
            this.groupBoxCipher.Controls.Add(this.textBoxCipher);
            this.groupBoxCipher.Location = new System.Drawing.Point(408, 16);
            this.groupBoxCipher.Name = "groupBoxCipher";
            this.groupBoxCipher.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBoxCipher.Size = new System.Drawing.Size(292, 208);
            this.groupBoxCipher.TabIndex = 3;
            this.groupBoxCipher.TabStop = false;
            this.groupBoxCipher.Text = "النص المشفر";
            // 
            // textBoxCipher
            // 
            this.textBoxCipher.Location = new System.Drawing.Point(6, 20);
            this.textBoxCipher.Multiline = true;
            this.textBoxCipher.Name = "textBoxCipher";
            this.textBoxCipher.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxCipher.Size = new System.Drawing.Size(280, 179);
            this.textBoxCipher.TabIndex = 1;
            // 
            // groupBoxPlain
            // 
            this.groupBoxPlain.Controls.Add(this.textBoxPlain);
            this.groupBoxPlain.Location = new System.Drawing.Point(805, 16);
            this.groupBoxPlain.Name = "groupBoxPlain";
            this.groupBoxPlain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBoxPlain.Size = new System.Drawing.Size(292, 208);
            this.groupBoxPlain.TabIndex = 2;
            this.groupBoxPlain.TabStop = false;
            this.groupBoxPlain.Text = "النص الأصلي";
            // 
            // textBoxPlain
            // 
            this.textBoxPlain.Location = new System.Drawing.Point(6, 23);
            this.textBoxPlain.Multiline = true;
            this.textBoxPlain.Name = "textBoxPlain";
            this.textBoxPlain.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxPlain.Size = new System.Drawing.Size(280, 179);
            this.textBoxPlain.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1152, 478);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBoxKey);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "خوارزمية فيجينير";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxKey.ResumeLayout(false);
            this.groupBoxKey.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBoxDecipher.ResumeLayout(false);
            this.groupBoxDecipher.PerformLayout();
            this.groupBoxCipher.ResumeLayout(false);
            this.groupBoxCipher.PerformLayout();
            this.groupBoxPlain.ResumeLayout(false);
            this.groupBoxPlain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBoxKey;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.GroupBox groupBoxCipher;
        private System.Windows.Forms.GroupBox groupBoxPlain;
        private System.Windows.Forms.GroupBox groupBoxDecipher;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.TextBox textBoxDecipher;
        private System.Windows.Forms.TextBox textBoxCipher;
        private System.Windows.Forms.TextBox textBoxPlain;
    }
}

