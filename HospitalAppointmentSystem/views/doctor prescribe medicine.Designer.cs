namespace HospitalAppointmentSystem.views
{
    partial class doctor_prescribe_medicine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(doctor_prescribe_medicine));
            comboBox1 = new ComboBox();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            label3 = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            label4 = new Label();
            comboBox2 = new ComboBox();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label6 = new Label();
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            panel5 = new Panel();
            panel6 = new Panel();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            panel7 = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(129, 9);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(595, 23);
            comboBox1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 30, 30);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1277, 54);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(558, 9);
            label1.Name = "label1";
            label1.Size = new Size(200, 36);
            label1.TabIndex = 0;
            label1.Text = "YENİ REÇETE";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(30, 30, 30);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(comboBox1);
            panel2.Location = new Point(3, 63);
            panel2.Name = "panel2";
            panel2.Size = new Size(733, 51);
            panel2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.White;
            label2.Location = new Point(317, 10);
            label2.Name = "label2";
            label2.Size = new Size(82, 21);
            label2.TabIndex = 3;
            label2.Text = "İLAÇ EKLE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.White;
            label3.Location = new Point(3, 9);
            label3.Name = "label3";
            label3.Size = new Size(110, 25);
            label3.TabIndex = 0;
            label3.Text = "Hasta Seç  :";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(30, 30, 30);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(richTextBox1);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(dateTimePicker1);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(comboBox2);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(0, 120);
            panel3.Name = "panel3";
            panel3.Size = new Size(736, 308);
            panel3.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Controls.Add(label2);
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(736, 40);
            panel4.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(0, 43);
            label4.Name = "label4";
            label4.Size = new Size(87, 25);
            label4.TabIndex = 5;
            label4.Text = "İlaç Seç :";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(97, 45);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(630, 23);
            comboBox2.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(3, 88);
            label5.Name = "label5";
            label5.Size = new Size(60, 25);
            label5.TabIndex = 7;
            label5.Text = "Gün :";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(97, 90);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(630, 23);
            dateTimePicker1.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.ForeColor = Color.White;
            label6.Location = new Point(3, 137);
            label6.Name = "label6";
            label6.Size = new Size(196, 25);
            label6.TabIndex = 9;
            label6.Text = "Kullanım Talimatları :";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(3, 165);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(724, 93);
            richTextBox1.TabIndex = 10;
            richTextBox1.Text = "";
            // 
            // button1
            // 
            button1.BackColor = Color.DarkRed;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.White;
            button1.Location = new Point(577, 264);
            button1.Name = "button1";
            button1.Size = new Size(150, 41);
            button1.TabIndex = 11;
            button1.Text = "REÇETEYE EKLE";
            button1.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(30, 30, 30);
            panel5.Controls.Add(panel6);
            panel5.Location = new Point(0, 450);
            panel5.Name = "panel5";
            panel5.Size = new Size(736, 236);
            panel5.TabIndex = 5;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Black;
            panel6.Controls.Add(panel7);
            panel6.Controls.Add(label7);
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(736, 96);
            panel6.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label7.ForeColor = Color.White;
            label7.Location = new Point(283, 15);
            label7.Name = "label7";
            label7.Size = new Size(144, 20);
            label7.TabIndex = 0;
            label7.Text = "REÇETEKİ İLAÇLAR";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label8.ForeColor = Color.White;
            label8.Location = new Point(302, 17);
            label8.Name = "label8";
            label8.Size = new Size(110, 17);
            label8.TabIndex = 1;
            label8.Text = "Kullanım Talimatı";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label9.ForeColor = Color.White;
            label9.Location = new Point(33, 15);
            label9.Name = "label9";
            label9.Size = new Size(52, 17);
            label9.TabIndex = 2;
            label9.Text = "İlaç Adı";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label10.ForeColor = Color.White;
            label10.Location = new Point(668, 17);
            label10.Name = "label10";
            label10.Size = new Size(31, 15);
            label10.TabIndex = 3;
            label10.Text = "Süre";
            // 
            // panel7
            // 
            panel7.Controls.Add(label9);
            panel7.Controls.Add(label10);
            panel7.Controls.Add(label8);
            panel7.Location = new Point(0, 50);
            panel7.Name = "panel7";
            panel7.Size = new Size(736, 46);
            panel7.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(742, 63);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(535, 623);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // doctor_prescribe_medicine
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 39, 48);
            Controls.Add(pictureBox1);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "doctor_prescribe_medicine";
            Size = new Size(1280, 720);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBox1;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label3;
        private Label label2;
        private Panel panel3;
        private ComboBox comboBox2;
        private Label label4;
        private Panel panel4;
        private Label label6;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private Button button1;
        private RichTextBox richTextBox1;
        private Panel panel5;
        private Label label10;
        private Label label9;
        private Label label8;
        private Panel panel6;
        private Label label7;
        private Panel panel7;
        private PictureBox pictureBox1;
    }
}
