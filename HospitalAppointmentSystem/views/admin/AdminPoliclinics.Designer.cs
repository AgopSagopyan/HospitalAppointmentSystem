namespace HospitalAppointmentSystem.views.admin
{
    partial class AdminPoliclinics
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
            panel1 = new Panel();
            btn_deletePatient = new Button();
            button2 = new Button();
            label2 = new Label();
            txt_policlinicName = new TextBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(45, 45, 45);
            panel1.Controls.Add(btn_deletePatient);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txt_policlinicName);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(276, 71);
            panel1.Name = "panel1";
            panel1.Size = new Size(602, 347);
            panel1.TabIndex = 16;
            // 
            // btn_deletePatient
            // 
            btn_deletePatient.BackColor = Color.Maroon;
            btn_deletePatient.FlatStyle = FlatStyle.Popup;
            btn_deletePatient.ForeColor = Color.White;
            btn_deletePatient.Location = new Point(353, 214);
            btn_deletePatient.Name = "btn_deletePatient";
            btn_deletePatient.Size = new Size(222, 66);
            btn_deletePatient.TabIndex = 14;
            btn_deletePatient.Text = "Delete Policlinic";
            btn_deletePatient.UseVisualStyleBackColor = false;
            btn_deletePatient.Click += btn_deletePatient_Click;
            // 
            // button2
            // 
            button2.Location = new Point(353, 126);
            button2.Name = "button2";
            button2.Size = new Size(222, 66);
            button2.TabIndex = 13;
            button2.Text = "Update Policlinic";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(36, 58);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 10;
            label2.Text = "Policlinic Name";
            // 
            // txt_policlinicName
            // 
            txt_policlinicName.Location = new Point(36, 80);
            txt_policlinicName.Name = "txt_policlinicName";
            txt_policlinicName.Size = new Size(247, 23);
            txt_policlinicName.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(353, 32);
            button1.Name = "button1";
            button1.Size = new Size(222, 66);
            button1.TabIndex = 8;
            button1.Text = "Add Policlinic";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(17, 440);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1048, 265);
            dataGridView1.TabIndex = 15;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(430, 13);
            label1.Name = "label1";
            label1.Size = new Size(276, 45);
            label1.TabIndex = 14;
            label1.Text = "Policlinics Admin";
            // 
            // AdminPoliclinics
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "AdminPoliclinics";
            Size = new Size(1080, 720);
            Load += AdminPoliclinics_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btn_deletePatient;
        private Button button2;
        private Label label2;
        private Label label4;
        private TextBox txt_policlinicName;
        private Label label3;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private DataGridView dataGridView1;
        private Label label1;
    }
}
