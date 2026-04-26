namespace HospitalAppointmentSystem.views.admin
{
    partial class AdminComments
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            dataGridView1 = new DataGridView();
            richTextBox1 = new RichTextBox();
            btn_sendComment = new Button();
            label1 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.Location = new Point(18, 359);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(615, 344);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(657, 359);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(401, 344);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(610, 79);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(393, 120);
            richTextBox1.TabIndex = 7;
            richTextBox1.Text = "";
            // 
            // btn_sendComment
            // 
            btn_sendComment.Location = new Point(702, 220);
            btn_sendComment.Name = "btn_sendComment";
            btn_sendComment.Size = new Size(185, 47);
            btn_sendComment.TabIndex = 8;
            btn_sendComment.Text = "Send Comment";
            btn_sendComment.UseVisualStyleBackColor = true;
            btn_sendComment.Click += btn_sendComment_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(610, 49);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 9;
            label1.Text = "Comment";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(439, 79);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(439, 61);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 11;
            label2.Text = "Doctor";
            // 
            // AdminComments
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(btn_sendComment);
            Controls.Add(richTextBox1);
            Controls.Add(dataGridView1);
            Controls.Add(flowLayoutPanel1);
            Name = "AdminComments";
            Size = new Size(1080, 720);
            Load += AdminComments_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private DataGridView dataGridView1;
        private RichTextBox richTextBox1;
        private Button btn_sendComment;
        private Label label1;
        private ComboBox comboBox1;
        private Label label2;
    }
}
