namespace HastaneRandevuSistemi.Views.Pages
{
    partial class AnaSayfa2
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaSayfa2));
            panelUst = new Panel();
            button9 = new Button();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            pictureHastane = new PictureBox();
            panelRandevu = new Panel();
            button4 = new Button();
            comboSaat = new ComboBox();
            label5 = new Label();
            dateTarih = new DateTimePicker();
            label4 = new Label();
            comboDoktor = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label6 = new Label();
            panelDoktorlar = new Panel();
            panel4 = new Panel();
            button8 = new Button();
            label13 = new Label();
            label14 = new Label();
            pictureBox4 = new PictureBox();
            panel3 = new Panel();
            button7 = new Button();
            label11 = new Label();
            label12 = new Label();
            pictureBox3 = new PictureBox();
            panel2 = new Panel();
            button6 = new Button();
            label9 = new Label();
            label10 = new Label();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            button5 = new Button();
            label8 = new Label();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            panelUst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureHastane).BeginInit();
            panelRandevu.SuspendLayout();
            panelDoktorlar.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelUst
            // 
            panelUst.BackColor = Color.FromArgb(45, 45, 45);
            panelUst.Controls.Add(button9);
            panelUst.Dock = DockStyle.Top;
            panelUst.Location = new Point(0, 0);
            panelUst.Name = "panelUst";
            panelUst.Size = new Size(1200, 80);
            panelUst.TabIndex = 0;
            panelUst.Paint += panelUst_Paint;
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(0, 120, 215);
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button9.ForeColor = Color.White;
            button9.Location = new Point(565, 20);
            button9.Name = "button9";
            button9.Size = new Size(140, 40);
            button9.TabIndex = 3;
            button9.Text = "Admin Paneli";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(45, 45, 45);
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(20, 22);
            label1.Name = "label1";
            label1.Size = new Size(355, 32);
            label1.TabIndex = 1;
            label1.Text = "Hospital Appointment System";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 120, 215);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.White;
            button1.Location = new Point(718, 20);
            button1.Name = "button1";
            button1.Size = new Size(140, 40);
            button1.TabIndex = 2;
            button1.Text = "Randevularım";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(60, 60, 60);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(868, 20);
            button2.Name = "button2";
            button2.Size = new Size(120, 40);
            button2.TabIndex = 3;
            button2.Text = "Profil";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(200, 60, 60);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Location = new Point(998, 20);
            button3.Name = "button3";
            button3.Size = new Size(120, 40);
            button3.TabIndex = 4;
            button3.Text = "Çıkış";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // pictureHastane
            // 
            pictureHastane.BorderStyle = BorderStyle.FixedSingle;
            pictureHastane.Image = (Image)resources.GetObject("pictureHastane.Image");
            pictureHastane.Location = new Point(30, 120);
            pictureHastane.Name = "pictureHastane";
            pictureHastane.Size = new Size(520, 250);
            pictureHastane.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureHastane.TabIndex = 5;
            pictureHastane.TabStop = false;
            // 
            // panelRandevu
            // 
            panelRandevu.BackColor = Color.FromArgb(45, 45, 45);
            panelRandevu.Controls.Add(button4);
            panelRandevu.Controls.Add(comboSaat);
            panelRandevu.Controls.Add(label5);
            panelRandevu.Controls.Add(dateTarih);
            panelRandevu.Controls.Add(label4);
            panelRandevu.Controls.Add(comboDoktor);
            panelRandevu.Controls.Add(label3);
            panelRandevu.Controls.Add(label2);
            panelRandevu.Location = new Point(580, 120);
            panelRandevu.Name = "panelRandevu";
            panelRandevu.Size = new Size(560, 250);
            panelRandevu.TabIndex = 6;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(0, 120, 215);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button4.ForeColor = Color.White;
            button4.Location = new Point(200, 190);
            button4.Name = "button4";
            button4.Size = new Size(180, 40);
            button4.TabIndex = 14;
            button4.Text = "Randevu Oluştur";
            button4.UseVisualStyleBackColor = false;
            // 
            // comboSaat
            // 
            comboSaat.FormattingEnabled = true;
            comboSaat.Location = new Point(150, 145);
            comboSaat.Name = "comboSaat";
            comboSaat.Size = new Size(250, 23);
            comboSaat.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(20, 150);
            label5.Name = "label5";
            label5.Size = new Size(29, 15);
            label5.TabIndex = 12;
            label5.Text = "Saat";
            // 
            // dateTarih
            // 
            dateTarih.Location = new Point(150, 105);
            dateTarih.Name = "dateTarih";
            dateTarih.Size = new Size(250, 23);
            dateTarih.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(20, 110);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 10;
            label4.Text = "Tarih";
            // 
            // comboDoktor
            // 
            comboDoktor.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            comboDoktor.FormattingEnabled = true;
            comboDoktor.Location = new Point(150, 65);
            comboDoktor.Name = "comboDoktor";
            comboDoktor.Size = new Size(250, 25);
            comboDoktor.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(20, 70);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 8;
            label3.Text = "Doktor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.White;
            label2.Location = new Point(20, 15);
            label2.Name = "label2";
            label2.Size = new Size(157, 25);
            label2.TabIndex = 7;
            label2.Text = "Hızlı Randevu Al";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.ForeColor = Color.White;
            label6.Location = new Point(30, 400);
            label6.Name = "label6";
            label6.Size = new Size(189, 30);
            label6.TabIndex = 7;
            label6.Text = "Popüler Doktorlar";
            // 
            // panelDoktorlar
            // 
            panelDoktorlar.BackColor = Color.FromArgb(35, 35, 35);
            panelDoktorlar.Controls.Add(panel4);
            panelDoktorlar.Controls.Add(panel3);
            panelDoktorlar.Controls.Add(panel2);
            panelDoktorlar.Controls.Add(panel1);
            panelDoktorlar.Location = new Point(30, 450);
            panelDoktorlar.Name = "panelDoktorlar";
            panelDoktorlar.Size = new Size(1100, 200);
            panelDoktorlar.TabIndex = 8;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(50, 50, 50);
            panel4.Controls.Add(button8);
            panel4.Controls.Add(label13);
            panel4.Controls.Add(label14);
            panel4.Controls.Add(pictureBox4);
            panel4.Location = new Point(720, 15);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 170);
            panel4.TabIndex = 3;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(0, 120, 215);
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button8.ForeColor = Color.White;
            button8.Location = new Point(50, 145);
            button8.Name = "button8";
            button8.Size = new Size(100, 25);
            button8.TabIndex = 3;
            button8.Text = "Randevu";
            button8.UseVisualStyleBackColor = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = Color.LightGray;
            label13.Location = new Point(60, 125);
            label13.Name = "label13";
            label13.Size = new Size(63, 15);
            label13.TabIndex = 2;
            label13.Text = "Kardiyoloji";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label14.ForeColor = Color.White;
            label14.Location = new Point(35, 105);
            label14.Name = "label14";
            label14.Size = new Size(116, 15);
            label14.TabIndex = 1;
            label14.Text = "Dr.Davut Efe AYBEY";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(40, 10);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(120, 90);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(50, 50, 50);
            panel3.Controls.Add(button7);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(pictureBox3);
            panel3.Location = new Point(490, 15);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 170);
            panel3.TabIndex = 2;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(0, 120, 215);
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button7.ForeColor = Color.White;
            button7.Location = new Point(50, 145);
            button7.Name = "button7";
            button7.Size = new Size(100, 25);
            button7.TabIndex = 3;
            button7.Text = "Randevu";
            button7.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.LightGray;
            label11.Location = new Point(60, 125);
            label11.Name = "label11";
            label11.Size = new Size(63, 15);
            label11.TabIndex = 2;
            label11.Text = "Kardiyoloji";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label12.ForeColor = Color.White;
            label12.Location = new Point(35, 105);
            label12.Name = "label12";
            label12.Size = new Size(116, 15);
            label12.TabIndex = 1;
            label12.Text = "Dr.Davut Efe AYBEY";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(40, 10);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(120, 90);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(50, 50, 50);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(260, 15);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 170);
            panel2.TabIndex = 1;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(0, 120, 215);
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button6.ForeColor = Color.White;
            button6.Location = new Point(50, 145);
            button6.Name = "button6";
            button6.Size = new Size(100, 25);
            button6.TabIndex = 3;
            button6.Text = "Randevu";
            button6.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.LightGray;
            label9.Location = new Point(60, 125);
            label9.Name = "label9";
            label9.Size = new Size(63, 15);
            label9.TabIndex = 2;
            label9.Text = "Kardiyoloji";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label10.ForeColor = Color.White;
            label10.Location = new Point(35, 105);
            label10.Name = "label10";
            label10.Size = new Size(116, 15);
            label10.TabIndex = 1;
            label10.Text = "Dr.Davut Efe AYBEY";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(40, 10);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(120, 90);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(50, 50, 50);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(30, 15);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 170);
            panel1.TabIndex = 0;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(0, 120, 215);
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button5.ForeColor = Color.White;
            button5.Location = new Point(50, 145);
            button5.Name = "button5";
            button5.Size = new Size(100, 25);
            button5.TabIndex = 3;
            button5.Text = "Randevu";
            button5.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.LightGray;
            label8.Location = new Point(60, 125);
            label8.Name = "label8";
            label8.Size = new Size(63, 15);
            label8.TabIndex = 2;
            label8.Text = "Kardiyoloji";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.ForeColor = Color.White;
            label7.Location = new Point(35, 105);
            label7.Name = "label7";
            label7.Size = new Size(116, 15);
            label7.TabIndex = 1;
            label7.Text = "Dr.Davut Efe AYBEY";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(40, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 90);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // AnaSayfa2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 39, 46);
            Controls.Add(panelDoktorlar);
            Controls.Add(label6);
            Controls.Add(panelRandevu);
            Controls.Add(pictureHastane);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(panelUst);
            Name = "AnaSayfa2";
            Size = new Size(1200, 700);
            Load += AnaSayfa2_Load;
            panelUst.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureHastane).EndInit();
            panelRandevu.ResumeLayout(false);
            panelRandevu.PerformLayout();
            panelDoktorlar.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelUst;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private PictureBox pictureHastane;
        private Panel panelRandevu;
        private Button button4;
        private ComboBox comboSaat;
        private Label label5;
        private DateTimePicker dateTarih;
        private Label label4;
        private ComboBox comboDoktor;
        private Label label3;
        private Label label2;
        private Label label6;
        private Panel panelDoktorlar;
        private Panel panel1;
        private Button button5;
        private Label label8;
        private Label label7;
        private PictureBox pictureBox1;
        private Panel panel4;
        private Button button8;
        private Label label13;
        private Label label14;
        private PictureBox pictureBox4;
        private Panel panel3;
        private Button button7;
        private Label label11;
        private Label label12;
        private PictureBox pictureBox3;
        private Panel panel2;
        private Button button6;
        private Label label9;
        private Label label10;
        private PictureBox pictureBox2;
        private Button button9;
    }
}
