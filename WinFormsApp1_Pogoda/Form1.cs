using Newtonsoft.Json;
using System.Diagnostics;

namespace WinFormsApp1_Pogoda
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer weatherTimer;
        public WeatherResponse currentWeather;
        public WeatherForecastResponce currentForecast;
        private WeatherManager weatherManager = new();
        public Form1()
        {
            InitializeComponent();
            textBoxCityName.KeyDown += TextBoxCityName_KeyDown;
        }

        private void TextBoxCityName_KeyDown(object? sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                buttonGetData.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            
            RefreshWeatherData(await AutoDetectLocation());
            SetBackground();
            weatherTimer = new System.Windows.Forms.Timer();
            weatherTimer.Interval = 10000*5;
            weatherTimer.Tick += WeatherTimer_Tick;
            weatherTimer.Start();
        }

        private async void WeatherTimer_Tick(object? sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxCityName.Text))
            {
                RefreshWeatherData(await AutoDetectLocation());
            }
            else
            {
                RefreshWeatherData(textBoxCityName.Text);
            }
        }

        private void SetBackground()
        {
            this.BackgroundImage = Image.FromFile("Backgrounds/clouds_bg.jpg");
        }
        private void ShowWeatherData(WeatherResponse weather)
        {

            if (weather != null)
            {
                labelCity.Text = $"{weather.Name}, {weather.Sys.Country}";
                labelTemperature.Text = $"{(int)weather.Main.Temp}°C";
                labelSummary.Text = $"Feels like {Math.Round(weather.Main.Feels_Like)}°C, " +
                    $"{WeatherDataConverter.GetCloudinessDescription(weather.Clouds.All)}, " +
                    $"{WeatherDataConverter.WindSpeedToDescription(weather.Wind.Speed)}";
                try
                {
                    string iconUrl = $"http://openweathermap.org/img/w/{weather.Weather[0].Icon}.png";
                    pictureBoxIcon.LoadAsync(iconUrl);
                }
                catch (Exception ex)
                { }
            }
            else
            {
                labelCity.Text = "Error occurred";
                labelTemperature.Text = "?°C";
                labelSummary.Text = "Unknown info";
            }
        }

        private async Task<WeatherResponse> GetWeatherData(string city)
        {
            WeatherResponse weather = await weatherManager.GetWeatherAsync(city);
            return weather;
        }
        

        private async void buttonGetData_Click(object sender, EventArgs e)
        {
            RefreshWeatherData(textBoxCityName.Text);
            
        }
        private List<WeatherItemData> FillDataItems(WeatherResponse weather)
        {


            var items = new List<WeatherItemData>();
            if (weather == null)
            {
                return items;
            }


            items.Add(new WeatherItemData(WeatherItemType.Wind,
                 $"{Math.Round(weather.Wind.Speed)} m/s {WeatherDataConverter.WindDirectionToCompass(weather.Wind.Deg, true)}"));
            items.Add(new WeatherItemData(WeatherItemType.Humidity,
                 $"{weather.Main.Humidity} %"));
            items.Add(new WeatherItemData(WeatherItemType.Pressure,
                 $"{weather.Main.Pressure} hPa"));
            items.Add(new WeatherItemData(WeatherItemType.Clouds,
                 $"{WeatherDataConverter.GetCloudinessDescription(weather.Clouds.All)}"));
            items.Add(new WeatherItemData(WeatherItemType.Visibility,
                $"{weather.Visibility / 1000} km"));
            items.Add(new WeatherItemData(WeatherItemType.Sunset,
                 $"{WeatherDataConverter.ConvertUnixTimestampToDateTime(weather.Sys.Sunset, weather.Timezone).ToShortTimeString()}"));


            return items;
        }
        
        private async Task<string> AutoDetectLocation()
        {
            string city;
            try
            {
                using HttpClient client = new HttpClient();
                string url = "https://ipapi.co/json/";
                string data = await client.GetStringAsync(url);
                var location = JsonConvert.DeserializeObject<DetectedLocation>(data);
                return city= location.City;
            }
            catch(Exception ex)
            {
                Debug.WriteLine($"Error Type: {ex.GetType().Name}\nMessage: {ex.Message}");
                return  "Kyiv";
            }
            
            
        }
        private async void RefreshWeatherData(string city)
        {
            currentWeather = await GetWeatherData(city);
            currentForecast= await weatherManager.GetForecastAsync(city);
            ShowWeatherData(currentWeather);
            if(currentWeather!= null)
            {
                weatherItemsPanel.Controls.Clear();
                List<WeatherItemData> items = FillDataItems(currentWeather);
                for (int i = 0; i < items.Count; i++)
                {
                    weatherItemsPanel.Controls.Add(new WeatherItemControl(items[i]));
                }
            }
            if(currentForecast!=null)
            {
                flowLayoutPanelForecast.Controls.Clear();
                var dailyForecast = currentForecast.List
                    .Where(f=> f.DateTxt.Contains("12:00:00"))
                    .ToList();
                foreach (var item in dailyForecast)
                {
                    DateTime date=DateTime.Parse(item.DateTxt);
                    
                    flowLayoutPanelForecast.Controls.Add(new UserControlForecast(item));
                }
            }
            
        }
    }
}
