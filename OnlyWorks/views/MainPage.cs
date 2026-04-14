using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OnlyWorks.services;

namespace OnlyWorks.views
{
    public partial class MainPage : UserControl
    {

        public MainPage()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            NavigationService.NavigateTo(new LoginPage());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NavigationService.NavigateTo(new SignupPage());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NavigationService.NavigateTo(new AppointmentPage());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NavigationService.NavigateTo(new LoginPage());
        }
    }
}
