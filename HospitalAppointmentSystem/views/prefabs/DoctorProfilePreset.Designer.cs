namespace HospitalAppointmentSystem.views.prefabs
{
    partial class DoctorProfilePreset
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
            pictureBox1 = new PictureBox();
            star5 = new PictureBox();
            star4 = new PictureBox();
            star3 = new PictureBox();
            star2 = new PictureBox();
            star1 = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)star5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)star4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)star3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)star2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)star1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(15, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(157, 147);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // star5
            // 
            star5.Image = Properties.Resources.clipart851004;
            star5.Location = new Point(495, 110);
            star5.Name = "star5";
            star5.Size = new Size(40, 40);
            star5.SizeMode = PictureBoxSizeMode.StretchImage;
            star5.TabIndex = 17;
            star5.TabStop = false;
            // 
            // star4
            // 
            star4.Image = Properties.Resources.clipart851004;
            star4.Location = new Point(421, 110);
            star4.Name = "star4";
            star4.Size = new Size(40, 40);
            star4.SizeMode = PictureBoxSizeMode.StretchImage;
            star4.TabIndex = 16;
            star4.TabStop = false;
            // 
            // star3
            // 
            star3.Image = Properties.Resources.clipart851004;
            star3.Location = new Point(349, 110);
            star3.Name = "star3";
            star3.Size = new Size(40, 40);
            star3.SizeMode = PictureBoxSizeMode.StretchImage;
            star3.TabIndex = 15;
            star3.TabStop = false;
            // 
            // star2
            // 
            star2.Image = Properties.Resources.clipart851004;
            star2.Location = new Point(279, 110);
            star2.Name = "star2";
            star2.Size = new Size(40, 40);
            star2.SizeMode = PictureBoxSizeMode.StretchImage;
            star2.TabIndex = 14;
            star2.TabStop = false;
            // 
            // star1
            // 
            star1.Image = Properties.Resources.clipart851004;
            star1.Location = new Point(209, 110);
            star1.Name = "star1";
            star1.Size = new Size(40, 40);
            star1.SizeMode = PictureBoxSizeMode.StretchImage;
            star1.TabIndex = 13;
            star1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(205, 14);
            label1.Name = "label1";
            label1.Size = new Size(78, 32);
            label1.TabIndex = 18;
            label1.Text = "label1";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(star1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(star5);
            panel1.Controls.Add(star2);
            panel1.Controls.Add(star4);
            panel1.Controls.Add(star3);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(753, 366);
            panel1.TabIndex = 19;
            panel1.Paint += panel1_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(205, 62);
            label2.Name = "label2";
            label2.Size = new Size(78, 32);
            label2.TabIndex = 19;
            label2.Text = "label2";
            // 
            // DoctorProfilePreset
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "DoctorProfilePreset";
            Size = new Size(759, 372);
            Load += DoctorProfilePreset_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)star5).EndInit();
            ((System.ComponentModel.ISupportInitialize)star4).EndInit();
            ((System.ComponentModel.ISupportInitialize)star3).EndInit();
            ((System.ComponentModel.ISupportInitialize)star2).EndInit();
            ((System.ComponentModel.ISupportInitialize)star1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox star5;
        private PictureBox star4;
        private PictureBox star3;
        private PictureBox star2;
        private PictureBox star1;
        private Label label1;
        private Panel panel1;
        private Label label2;
    }
}
