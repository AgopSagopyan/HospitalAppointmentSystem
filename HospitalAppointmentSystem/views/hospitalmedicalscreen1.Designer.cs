namespace HospitalAppointmentSystem.views
{
    partial class hospitalmedicalscreen1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hospitalmedicalscreen1));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label2 = new Label();
            label3 = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            panel5 = new Panel();
            panel6 = new Panel();
            pictureBox2 = new PictureBox();
            panel7 = new Panel();
            pictureBox3 = new PictureBox();
            label8 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1277, 59);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(549, 16);
            label1.Name = "label1";
            label1.Size = new Size(144, 32);
            label1.TabIndex = 1;
            label1.Text = "İLAÇLARIM";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(103, 78);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(12, 445);
            panel2.Name = "panel2";
            panel2.Size = new Size(1249, 72);
            panel2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 18.75F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(119, 19);
            label2.Name = "label2";
            label2.Size = new Size(788, 35);
            label2.TabIndex = 2;
            label2.Text = "Herhangi bir ilacı doktorunuzun talimatına uymadan kullanmayınız.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 18.75F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(116, 26);
            label3.Name = "label3";
            label3.Size = new Size(703, 35);
            label3.TabIndex = 3;
            label3.Text = "Doktorunuza danışmadan ilaç almayınız veya kullanmayınız.";
            // 
            // panel3
            // 
            panel3.BackColor = Color.AntiqueWhite;
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(12, 95);
            panel3.Name = "panel3";
            panel3.Size = new Size(1249, 329);
            panel3.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Controls.Add(label4);
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1249, 63);
            panel4.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.White;
            label4.Location = new Point(500, 20);
            label4.Name = "label4";
            label4.Size = new Size(268, 25);
            label4.TabIndex = 0;
            label4.Text = "REÇETENİZDEKİ İLAÇLARINIZ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.Location = new Point(26, 16);
            label5.Name = "label5";
            label5.Size = new Size(71, 21);
            label5.TabIndex = 1;
            label5.Text = "İlaç Adı ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.Location = new Point(546, 16);
            label6.Name = "label6";
            label6.Size = new Size(163, 21);
            label6.TabIndex = 2;
            label6.Text = "Kullanıcı Talimatları";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.Location = new Point(1159, 16);
            label7.Name = "label7";
            label7.Size = new Size(44, 21);
            label7.TabIndex = 3;
            label7.Text = "Süre";
            // 
            // panel5
            // 
            panel5.Controls.Add(label6);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(label7);
            panel5.Location = new Point(3, 71);
            panel5.Name = "panel5";
            panel5.Size = new Size(1243, 46);
            panel5.TabIndex = 4;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Black;
            panel6.Controls.Add(label3);
            panel6.Controls.Add(pictureBox2);
            panel6.Location = new Point(12, 523);
            panel6.Name = "panel6";
            panel6.Size = new Size(1249, 73);
            panel6.TabIndex = 4;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(103, 73);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Black;
            panel7.Controls.Add(label8);
            panel7.Controls.Add(pictureBox3);
            panel7.Location = new Point(12, 604);
            panel7.Name = "panel7";
            panel7.Size = new Size(1249, 72);
            panel7.TabIndex = 5;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(103, 78);
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label8.ForeColor = Color.White;
            label8.Location = new Point(116, 22);
            label8.Name = "label8";
            label8.Size = new Size(879, 32);
            label8.TabIndex = 1;
            label8.Text = "Reçetede yazan ilaç evinizde bulunuyor ise son kullanma tarihine dikkat ediniz.";
            // 
            // hospitalmedicalscreen1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 39, 46);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "hospitalmedicalscreen1";
            Size = new Size(1280, 720);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label3;
        private Label label2;
        private Panel panel3;
        private Label label7;
        private Label label6;
        private Label label5;
        private Panel panel4;
        private Label label4;
        private Panel panel5;
        private Panel panel6;
        private PictureBox pictureBox2;
        private Panel panel7;
        private PictureBox pictureBox3;
        private Label label8;
    }
}
