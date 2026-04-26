using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OnlyWorks.repositories;

namespace HospitalAppointmentSystem.views.flowLayoutPanel
{
    public partial class CommentPreset : UserControl
    {
        private Comment _comment;

        public CommentPreset(Comment comment)
        {
            InitializeComponent();

            _comment = comment;
        }

        private void Comment_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = _comment.Content;

            label1.Text = _comment.Sender;
        }
    }
}
