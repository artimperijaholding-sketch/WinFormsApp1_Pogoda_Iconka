namespace WinFormsApp1_Pogoda
{
    internal class WeatherForecastItemControl : Control
    {
        private DateTime date;
        private double temp;
        private string icon;

        public WeatherForecastItemControl(DateTime date, double temp, string icon)
        {
            this.date = date;
            this.temp = temp;
            this.icon = icon;
        }
    }
}