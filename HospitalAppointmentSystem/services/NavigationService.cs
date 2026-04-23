using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlyWorks.services
{
    public static class NavigationService
    {
        public static Panel MainPanel { get; set; }

        public static void NavigateTo(UserControl page)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(page);
        }
    }

}
