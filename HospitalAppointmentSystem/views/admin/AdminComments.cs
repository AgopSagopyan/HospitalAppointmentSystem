using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accessibility;
using HospitalAppointmentSystem.views.flowLayoutPanel;
using OnlyWorks.controllers;
using OnlyWorks.repositories;

namespace HospitalAppointmentSystem.views.admin
{
    public partial class AdminComments : UserControl
    {
        private readonly MainRepository _repo;

        public AdminComments()
        {
            InitializeComponent();
            _repo = new MainRepository();
        }

        private void AdminComments_Load(object sender, EventArgs e)
        {
            List<Comment> commentList = _repo.GetAllComments();

            foreach (Comment comment in commentList) {
                flowLayoutPanel1.Controls.Add(new CommentPreset(comment));
            }

            //flowLayoutPanel1.Controls.Add();
        }
    }
}
