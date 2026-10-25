using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Runtime.InteropServices.Marshalling.IIUnknownCacheStrategy;

namespace WinFormsApp1_Pogoda
{
    public partial class UserControlForecast : UserControl
    {
        private ForecastItem ForecastItem;
        public UserControlForecast()
        {
            InitializeComponent();
            SetBackColor();
        }
        
        public UserControlForecast(ForecastItem forecastItem)
        {
            InitializeComponent();
            this.ForecastItem = forecastItem;
            SetBackColor();
            ShowItemData();
        }

        private void ShowItemData()
        {
            if (ForecastItem != null)
            {
                DateTime date = DateTime.Parse(ForecastItem.DateTxt);
                labelData.Text = date.ToString("dddd",new System.Globalization.CultureInfo("ua-Ua"));
                labelTemp.Text = $"{(int)ForecastItem.Main.Temp}°C"; ;
                try
                {
                    string iconUrl = $"http://openweathermap.org/img/w/{ForecastItem.Weather[0].Icon}.png";
                    pictureBox1.LoadAsync(iconUrl);
                }
                catch (Exception ex)
                { }
            }
        }
        private void SetBackColor()
        {
            this.BackColor = Color.Transparent;
        }
    }
}
