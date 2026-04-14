namespace OnlyWorks.views
{
    partial class AppointmentPage
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
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            combo_timePicker = new ComboBox();
            panel1 = new Panel();
            combo_clinic = new ComboBox();
            label4 = new Label();
            combo_doctorName = new ComboBox();
            btn_getAppointment = new Button();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label6 = new Label();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(112, 125);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(623, 119);
            button1.Name = "button1";
            button1.Size = new Size(192, 56);
            button1.TabIndex = 2;
            button1.Text = "List Appointments";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(623, 194);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(634, 421);
            dataGridView1.TabIndex = 3;
            // 
            // combo_timePicker
            // 
            combo_timePicker.FormattingEnabled = true;
            combo_timePicker.Items.AddRange(new object[] { "09:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00" });
            combo_timePicker.Location = new Point(112, 301);
            combo_timePicker.Name = "combo_timePicker";
            combo_timePicker.Size = new Size(200, 23);
            combo_timePicker.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 39, 46);
            panel1.Controls.Add(combo_clinic);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(combo_doctorName);
            panel1.Controls.Add(btn_getAppointment);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(combo_timePicker);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Location = new Point(161, 119);
            panel1.Name = "panel1";
            panel1.Size = new Size(422, 496);
            panel1.TabIndex = 10;
            // 
            // combo_clinic
            // 
            combo_clinic.FormattingEnabled = true;
            combo_clinic.Location = new Point(112, 179);
            combo_clinic.Name = "combo_clinic";
            combo_clinic.Size = new Size(200, 23);
            combo_clinic.TabIndex = 13;
            combo_clinic.SelectedIndexChanged += combo_clinic_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(112, 222);
            label4.Name = "label4";
            label4.Size = new Size(78, 15);
            label4.TabIndex = 12;
            label4.Text = "Doctor Name";
            // 
            // combo_doctorName
            // 
            combo_doctorName.FormattingEnabled = true;
            combo_doctorName.Location = new Point(112, 240);
            combo_doctorName.Name = "combo_doctorName";
            combo_doctorName.Size = new Size(200, 23);
            combo_doctorName.TabIndex = 11;
            // 
            // btn_getAppointment
            // 
            btn_getAppointment.BackColor = SystemColors.Highlight;
            btn_getAppointment.FlatStyle = FlatStyle.Popup;
            btn_getAppointment.ForeColor = Color.White;
            btn_getAppointment.Location = new Point(112, 353);
            btn_getAppointment.Name = "btn_getAppointment";
            btn_getAppointment.Size = new Size(200, 47);
            btn_getAppointment.TabIndex = 10;
            btn_getAppointment.Text = "Get Appointment";
            btn_getAppointment.UseVisualStyleBackColor = false;
            btn_getAppointment.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(112, 283);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 9;
            label2.Text = "Time";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(112, 161);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 8;
            label1.Text = "Clinic";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(112, 105);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 7;
            label3.Text = "Date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(65, 27);
            label6.Name = "label6";
            label6.Size = new Size(281, 45);
            label6.TabIndex = 3;
            label6.Text = "Get Appointment";
            // 
            // button4
            // 
            button4.Location = new Point(16, 658);
            button4.Name = "button4";
            button4.Size = new Size(107, 45);
            button4.TabIndex = 12;
            button4.Text = "Back";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // AppointmentPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            Controls.Add(button4);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Name = "AppointmentPage";
            Size = new Size(1280, 720);
            Load += AppointmentPage_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Button button1;
        private DataGridView dataGridView1;
        private ComboBox combo_timePicker;
        private Panel panel1;
        private Label label6;
        private Label label2;
        private Label label1;
        private Label label3;
        private Button btn_getAppointment;
        private Button button4;
        private ComboBox combo_clinic;
        private Label label4;
        private ComboBox combo_doctorName;
    }
}
