namespace HospitalAppointmentSystem.views
{
    partial class MainPageTest
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
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            label1 = new Label();
            panelTopbar = new Panel();
            button6 = new Button();
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            panelTopbar.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button4.ForeColor = Color.White;
            button4.Location = new Point(1048, 12);
            button4.Name = "button4";
            button4.Size = new Size(78, 50);
            button4.TabIndex = 5;
            button4.Text = "Profil";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button3.ForeColor = Color.White;
            button3.Location = new Point(348, 12);
            button3.Name = "button3";
            button3.Size = new Size(80, 50);
            button3.TabIndex = 4;
            button3.Text = "İlaçlarım";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button2.ForeColor = Color.White;
            button2.Location = new Point(230, 12);
            button2.Name = "button2";
            button2.Size = new Size(98, 50);
            button2.TabIndex = 3;
            button2.Text = "Randevu Al";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(20, 18);
            label1.Name = "label1";
            label1.Size = new Size(195, 32);
            label1.TabIndex = 2;
            label1.Text = "Hastane Sistemi";
            // 
            // panelTopbar
            // 
            panelTopbar.BackColor = Color.FromArgb(30, 41, 59);
            panelTopbar.Controls.Add(label1);
            panelTopbar.Controls.Add(button4);
            panelTopbar.Controls.Add(button3);
            panelTopbar.Controls.Add(button6);
            panelTopbar.Controls.Add(button2);
            panelTopbar.Dock = DockStyle.Top;
            panelTopbar.Location = new Point(0, 0);
            panelTopbar.Name = "panelTopbar";
            panelTopbar.Size = new Size(1280, 70);
            panelTopbar.TabIndex = 1;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(239, 68, 68);
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.ForeColor = Color.White;
            button6.Location = new Point(1141, 18);
            button6.Name = "button6";
            button6.Size = new Size(120, 35);
            button6.TabIndex = 2;
            button6.Text = "Çıkış";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 41, 59);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(444, 106);
            panel1.Name = "panel1";
            panel1.Size = new Size(359, 220);
            panel1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.White;
            label3.Location = new Point(70, 82);
            label3.Name = "label3";
            label3.Size = new Size(221, 90);
            label3.TabIndex = 1;
            label3.Text = "Hızlı ve kolay randevu \r\nalmak için sistemimizi \r\nkullanın.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.White;
            label2.Location = new Point(84, 18);
            label2.Name = "label2";
            label2.Size = new Size(182, 32);
            label2.TabIndex = 0;
            label2.Text = "Hoş Geldiniz!!!";
            // 
            // MainPageTest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            Controls.Add(panel1);
            Controls.Add(panelTopbar);
            Name = "MainPageTest";
            Size = new Size(1280, 720);
            panelTopbar.ResumeLayout(false);
            panelTopbar.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelTopbar;
        private Label label1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button6;
        private Panel panel1;
        private Label label3;
        private Label label2;
    }
}
