namespace HospitalAppointmentSystem.views.admin
{
    partial class AdminMedicines
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
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            btn_medicineAdd = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btn_imagePicker = new Button();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(299, 408);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(485, 290);
            dataGridView1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(444, 57);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(202, 23);
            textBox1.TabIndex = 1;
            // 
            // btn_medicineAdd
            // 
            btn_medicineAdd.ImageAlign = ContentAlignment.MiddleRight;
            btn_medicineAdd.Location = new Point(318, 324);
            btn_medicineAdd.Name = "btn_medicineAdd";
            btn_medicineAdd.Size = new Size(146, 61);
            btn_medicineAdd.TabIndex = 2;
            btn_medicineAdd.Text = "Add Medicine";
            btn_medicineAdd.UseVisualStyleBackColor = true;
            btn_medicineAdd.Click += btn_medicineAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(444, 28);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 3;
            label1.Text = "Medicine Name";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.social_media_chatting_online_default_male_blank_profile_picture_head_and_body_icon_people_standing_icon_grey_background_free_vector;
            pictureBox1.Location = new Point(648, 180);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(136, 106);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // btn_imagePicker
            // 
            btn_imagePicker.Location = new Point(648, 323);
            btn_imagePicker.Name = "btn_imagePicker";
            btn_imagePicker.Size = new Size(127, 28);
            btn_imagePicker.TabIndex = 13;
            btn_imagePicker.Text = "Choose an Image";
            btn_imagePicker.UseVisualStyleBackColor = true;
            btn_imagePicker.Click += btn_imagePicker_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(646, 299);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 12;
            label4.Text = "Image";
            // 
            // AdminMedicines
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            Controls.Add(pictureBox1);
            Controls.Add(btn_imagePicker);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(btn_medicineAdd);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Name = "AdminMedicines";
            Size = new Size(1080, 720);
            Load += AdminMedicines_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Button btn_medicineAdd;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btn_imagePicker;
        private Label label4;
    }
}
