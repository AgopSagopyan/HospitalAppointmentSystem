namespace OnlyWorks.views.admin
{
    partial class AdminPatients
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
            button1 = new Button();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            btn_deletePatient = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(427, 16);
            label1.Name = "label1";
            label1.Size = new Size(248, 45);
            label1.TabIndex = 0;
            label1.Text = "Patients Admin";
            // 
            // button1
            // 
            button1.Location = new Point(353, 32);
            button1.Name = "button1";
            button1.Size = new Size(222, 66);
            button1.TabIndex = 8;
            button1.Text = "Add Patient";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(36, 214);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(247, 23);
            textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(36, 144);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(247, 23);
            textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(36, 80);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(247, 23);
            textBox1.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 443);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1048, 265);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(36, 58);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 10;
            label2.Text = "Patient Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(36, 126);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 11;
            label3.Text = "Patient Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(36, 196);
            label4.Name = "label4";
            label4.Size = new Size(97, 15);
            label4.TabIndex = 12;
            label4.Text = "Patient Password";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(45, 45, 45);
            panel1.Controls.Add(btn_deletePatient);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(273, 74);
            panel1.Name = "panel1";
            panel1.Size = new Size(602, 347);
            panel1.TabIndex = 13;
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
            btn_deletePatient.Text = "Delete Patient";
            btn_deletePatient.UseVisualStyleBackColor = false;
            btn_deletePatient.Click += btn_deletePatient_Click;
            // 
            // button2
            // 
            button2.Location = new Point(353, 126);
            button2.Name = "button2";
            button2.Size = new Size(222, 66);
            button2.TabIndex = 13;
            button2.Text = "Update Patient";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // AdminPatients
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "AdminPatients";
            Size = new Size(1080, 720);
            Load += AdminPatients_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel panel1;
        private Button btn_deletePatient;
        private Button button2;
    }
}
