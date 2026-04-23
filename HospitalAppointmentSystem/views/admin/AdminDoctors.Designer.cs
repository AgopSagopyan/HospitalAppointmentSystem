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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            txt_doctorName.Location = new Point(378, 116);
            txt_doctorName.Name = "txt_doctorName";
            txt_doctorName.Size = new Size(247, 23);
            txt_doctorName.TabIndex = 1;
            // 
            // btn_addDoctor
            // 
            btn_addDoctor.Location = new Point(378, 239);
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
            dataGridView1.Location = new Point(138, 319);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(739, 344);
            dataGridView1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(378, 96);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 6;
            label2.Text = "Doctor Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(378, 161);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 7;
            label3.Text = "Profession";
            // 
            // combo_profession
            // 
            combo_profession.FormattingEnabled = true;
            combo_profession.Location = new Point(378, 182);
            combo_profession.Name = "combo_profession";
            combo_profession.Size = new Size(247, 23);
            combo_profession.TabIndex = 8;
            // 
            // AdminDoctors
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
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
    }
}
