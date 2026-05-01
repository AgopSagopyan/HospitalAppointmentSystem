namespace HospitalAppointmentSystem.views
{
    partial class DoctorPage
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
            label1 = new Label();
            btn_goToPrescriptions = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(126, 106);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(583, 270);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(269, 44);
            label1.Name = "label1";
            label1.Size = new Size(276, 45);
            label1.TabIndex = 1;
            label1.Text = "My Appointments";
            // 
            // btn_goToPrescriptions
            // 
            btn_goToPrescriptions.Location = new Point(817, 129);
            btn_goToPrescriptions.Name = "btn_goToPrescriptions";
            btn_goToPrescriptions.Size = new Size(214, 63);
            btn_goToPrescriptions.TabIndex = 2;
            btn_goToPrescriptions.Text = "Go To Prescriptions";
            btn_goToPrescriptions.UseVisualStyleBackColor = true;
            btn_goToPrescriptions.Click += btn_goToPrescriptions_Click;
            // 
            // button1
            // 
            button1.Location = new Point(26, 646);
            button1.Name = "button1";
            button1.Size = new Size(182, 53);
            button1.TabIndex = 3;
            button1.Text = "Go Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // DoctorPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            Controls.Add(button1);
            Controls.Add(btn_goToPrescriptions);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "DoctorPage";
            Size = new Size(1280, 720);
            Load += DoctorPage_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Button btn_goToPrescriptions;
        private Button button1;
    }
}
