namespace adisyonUygulamasi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox_adisyon = new GroupBox();
            btn_giris = new Button();
            textBox_sifre = new TextBox();
            lbl_sifre = new Label();
            textBox_giris = new TextBox();
            lbl_giris = new Label();
            pictureBox1 = new PictureBox();
            groupBox_adisyon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox_adisyon
            // 
            groupBox_adisyon.Controls.Add(btn_giris);
            groupBox_adisyon.Controls.Add(textBox_sifre);
            groupBox_adisyon.Controls.Add(lbl_sifre);
            groupBox_adisyon.Controls.Add(textBox_giris);
            groupBox_adisyon.Controls.Add(lbl_giris);
            groupBox_adisyon.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupBox_adisyon.Location = new Point(245, 38);
            groupBox_adisyon.Name = "groupBox_adisyon";
            groupBox_adisyon.Size = new Size(502, 324);
            groupBox_adisyon.TabIndex = 0;
            groupBox_adisyon.TabStop = false;
            groupBox_adisyon.Text = "Adisyon Uygulaması";
            // 
            // btn_giris
            // 
            btn_giris.BackColor = Color.Orange;
            btn_giris.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn_giris.Image = (Image)resources.GetObject("btn_giris.Image");
            btn_giris.ImageAlign = ContentAlignment.MiddleRight;
            btn_giris.Location = new Point(254, 237);
            btn_giris.Name = "btn_giris";
            btn_giris.Size = new Size(172, 59);
            btn_giris.TabIndex = 2;
            btn_giris.Text = "GİRİŞ";
            btn_giris.UseVisualStyleBackColor = false;
            btn_giris.Click += btn_giris_Click;
            // 
            // textBox_sifre
            // 
            textBox_sifre.BackColor = Color.YellowGreen;
            textBox_sifre.Location = new Point(200, 152);
            textBox_sifre.Multiline = true;
            textBox_sifre.Name = "textBox_sifre";
            textBox_sifre.PasswordChar = '*';
            textBox_sifre.Size = new Size(268, 52);
            textBox_sifre.TabIndex = 1;
            // 
            // lbl_sifre
            // 
            lbl_sifre.AutoSize = true;
            lbl_sifre.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_sifre.Location = new Point(6, 152);
            lbl_sifre.Name = "lbl_sifre";
            lbl_sifre.Size = new Size(68, 31);
            lbl_sifre.TabIndex = 0;
            lbl_sifre.Text = "Şifre:";
            // 
            // textBox_giris
            // 
            textBox_giris.BackColor = Color.YellowGreen;
            textBox_giris.Location = new Point(200, 69);
            textBox_giris.Multiline = true;
            textBox_giris.Name = "textBox_giris";
            textBox_giris.Size = new Size(268, 52);
            textBox_giris.TabIndex = 0;
            // 
            // lbl_giris
            // 
            lbl_giris.AutoSize = true;
            lbl_giris.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_giris.Location = new Point(6, 78);
            lbl_giris.Name = "lbl_giris";
            lbl_giris.Size = new Size(172, 31);
            lbl_giris.TabIndex = 0;
            lbl_giris.Text = "Kullanıcı Girişi: ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(49, 107);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(173, 167);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(795, 396);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox_adisyon);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            groupBox_adisyon.ResumeLayout(false);
            groupBox_adisyon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox_adisyon;
        private TextBox textBox_sifre;
        private Label lbl_sifre;
        private TextBox textBox_giris;
        private Label lbl_giris;
        private Button btn_giris;
        private PictureBox pictureBox1;
    }
}
