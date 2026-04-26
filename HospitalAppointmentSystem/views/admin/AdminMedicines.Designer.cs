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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(306, 364);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(485, 290);
            dataGridView1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(436, 155);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(202, 23);
            textBox1.TabIndex = 1;
            // 
            // btn_medicineAdd
            // 
            btn_medicineAdd.ImageAlign = ContentAlignment.MiddleRight;
            btn_medicineAdd.Location = new Point(463, 219);
            btn_medicineAdd.Name = "btn_medicineAdd";
            btn_medicineAdd.Size = new Size(146, 61);
            btn_medicineAdd.TabIndex = 2;
            btn_medicineAdd.Text = "Add Medicine";
            btn_medicineAdd.UseVisualStyleBackColor = true;
            btn_medicineAdd.Click += btn_medicineAdd_Click;
            // 
            // AdminMedicines
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            Controls.Add(btn_medicineAdd);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Name = "AdminMedicines";
            Size = new Size(1080, 720);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Button btn_medicineAdd;
    }
}
