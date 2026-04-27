




namespace HospitalAppointmentSystem.services
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
