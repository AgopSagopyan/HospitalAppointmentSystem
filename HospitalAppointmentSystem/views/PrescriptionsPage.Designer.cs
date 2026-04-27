namespace HospitalAppointmentSystem.views
{
    partial class PrescriptionPage
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
            comboBox1 = new ComboBox();
            panel1 = new Panel();
            label1 = new Label();
            label3 = new Label();
            button1 = new Button();
            richTextBox1 = new RichTextBox();
            label6 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            comboBox2 = new ComboBox();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(57, 113);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(266, 23);
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.White;
            label3.Location = new Point(57, 85);
            label3.Name = "label3";
            label3.Size = new Size(72, 25);
            label3.TabIndex = 0;
            label3.Text = "Patient";
            // 
            // button1
            // 
            button1.BackColor = Color.Gray;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.White;
            button1.Location = new Point(57, 580);
            button1.Name = "button1";
            button1.Size = new Size(159, 57);
            button1.TabIndex = 11;
            button1.Text = "REÇETEYE EKLE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(57, 354);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(411, 191);
            richTextBox1.TabIndex = 10;
            richTextBox1.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.ForeColor = Color.White;
            label6.Location = new Point(57, 326);
            label6.Name = "label6";
            label6.Size = new Size(196, 25);
            label6.TabIndex = 9;
            label6.Text = "Kullanım Talimatları :";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(57, 276);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(266, 23);
            dateTimePicker1.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(57, 248);
            label5.Name = "label5";
            label5.Size = new Size(121, 25);
            label5.TabIndex = 7;
            label5.Text = "Ending Date";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(57, 190);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(266, 23);
            comboBox2.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(57, 157);
            label4.Name = "label4";
            label4.Size = new Size(93, 25);
            label4.TabIndex = 5;
            label4.Text = "Medicine";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(590, 553);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(381, 145);
            dataGridView1.TabIndex = 12;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(496, 127);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(753, 360);
            flowLayoutPanel1.TabIndex = 13;
            // 
            // PrescriptionPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(richTextBox1);
            Controls.Add(label6);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(dateTimePicker1);
            Controls.Add(label4);
            Controls.Add(comboBox2);
            Controls.Add(panel1);
            Name = "PrescriptionPage";
            Size = new Size(1280, 720);
            Load += doctor_prescribe_medicine_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Panel panel1;
        private Label label1;
        private Label label3;
        private ComboBox comboBox2;
        private Label label4;
        private Label label6;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private Button button1;
        private RichTextBox richTextBox1;
        private DataGridView dataGridView1;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
