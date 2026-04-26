namespace OnlyWorks.views.admin
{
    partial class AdminDoctors
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txt_doctorName = new TextBox();
            btn_addDoctor = new Button();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            combo_profession = new ComboBox();
            openFileDialog1 = new OpenFileDialog();
            label4 = new Label();
            btn_imagePicker = new Button();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(388, 14);
            label1.Name = "label1";
            label1.Size = new Size(247, 45);
            label1.TabIndex = 0;
            label1.Text = "Doctors Admin";
            // 
            // txt_doctorName
            // 
            txt_doctorName.Location = new Point(99, 150);
            txt_doctorName.Name = "txt_doctorName";
            txt_doctorName.Size = new Size(247, 23);
            txt_doctorName.TabIndex = 1;
            // 
            // btn_addDoctor
            // 
            btn_addDoctor.Location = new Point(97, 498);
            btn_addDoctor.Name = "btn_addDoctor";
            btn_addDoctor.Size = new Size(247, 53);
            btn_addDoctor.TabIndex = 4;
            btn_addDoctor.Text = "Add Doctor";
            btn_addDoctor.UseVisualStyleBackColor = true;
            btn_addDoctor.Click += btn_addDoctor_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(398, 137);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(642, 532);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(99, 130);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 6;
            label2.Text = "Doctor Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(99, 195);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 7;
            label3.Text = "Profession";
            // 
            // combo_profession
            // 
            combo_profession.FormattingEnabled = true;
            combo_profession.Location = new Point(99, 216);
            combo_profession.Name = "combo_profession";
            combo_profession.Size = new Size(247, 23);
            combo_profession.TabIndex = 8;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(97, 389);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 9;
            label4.Text = "Image";
            // 
            // btn_imagePicker
            // 
            btn_imagePicker.Location = new Point(99, 413);
            btn_imagePicker.Name = "btn_imagePicker";
            btn_imagePicker.Size = new Size(127, 28);
            btn_imagePicker.TabIndex = 10;
            btn_imagePicker.Text = "Choose an Image";
            btn_imagePicker.UseVisualStyleBackColor = true;
            btn_imagePicker.Click += btn_imagePicker_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = HospitalAppointmentSystem.Properties.Resources.social_media_chatting_online_default_male_blank_profile_picture_head_and_body_icon_people_standing_icon_grey_background_free_vector;
            pictureBox1.Location = new Point(99, 262);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(136, 106);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(97, 557);
            button1.Name = "button1";
            button1.Size = new Size(247, 53);
            button1.TabIndex = 12;
            button1.Text = "Update Doctor";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.FlatStyle = FlatStyle.Popup;
            button2.ForeColor = Color.White;
            button2.Location = new Point(97, 616);
            button2.Name = "button2";
            button2.Size = new Size(247, 53);
            button2.TabIndex = 13;
            button2.Text = "Delete Doctor";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // AdminDoctors
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(btn_imagePicker);
            Controls.Add(label4);
            Controls.Add(combo_profession);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(btn_addDoctor);
            Controls.Add(txt_doctorName);
            Controls.Add(label1);
            ForeColor = Color.Black;
            Name = "AdminDoctors";
            Size = new Size(1080, 720);
            Load += AdminDoctors_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_doctorName;
        private Button btn_addDoctor;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label3;
        private ComboBox combo_profession;
        private OpenFileDialog openFileDialog1;
        private Label label4;
        private Button btn_imagePicker;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
    }
}
