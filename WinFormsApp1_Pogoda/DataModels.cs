using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1_Pogoda;

public class WeatherResponse
{
    public Coord Coord { get; set; } = new();
    public List<Weather> Weather { get; set; } = new();
    public string Base { get; set; } = string.Empty;
    public Main Main { get; set; } = new();
    public int Visibility { get; set; }
    public Wind Wind { get; set; } = new();
    public Clouds Clouds { get; set; } = new();
    public long Dt { get; set; }
    public Sys Sys { get; set; } = new();
    public int Timezone { get; set; }
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int Cod { get; set; }
}

public class Coord
{
    public double Lon { get; set; }
    public double Lat { get; set; }
}

public class Weather
{
    public int Id { get; set; }
    public string Main { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Icon { get; set; } = string.Empty;
}

public class Main
{
    public double Temp { get; set; }
    public double Feels_Like { get; set; }
    public double Temp_Min { get; set; }
    public double Temp_Max { get; set; }
    public int Pressure { get; set; }
    public int Humidity { get; set; }
    public int Sea_Level { get; set; }
    public int Grnd_Level { get; set; }
}

public class Wind
{
    public double Speed { get; set; }
    public int Deg { get; set; }
    public double Gust { get; set; }
}

public class Clouds
{
    public int All { get; set; }
}

public class Sys
{
    public string Country { get; set; } = string.Empty;
    public long Sunrise { get; set; }
    public long Sunset { get; set; }
}
public class DetectedLocation
{
    public string City { get; set; } = string.Empty;
    public double Latitude { get; set; }
    public double Longitude { get; set; }
}
public class WeatherForecastResponce
{
    public List<ForecastItem> List { get; set; } = new();
}
public class ForecastItem
{
    [JsonProperty("dt_txt")]
    public string DateTxt { get; set; } = string.Empty;
    public Main Main { get; set; } = new();
    public List<Weather> Weather { get; set; } = new();
    public Wind Wind { get; set; } = new();
}
public enum WeatherItemType
{
    Unset,
    Wind,
    Humidity,
    Pressure,
    Clouds,
    Visibility,
    Sunset
}
public class WeatherItemData
{
    public WeatherItemType Type { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Data { get; set; } = string.Empty;
    public Image Icon { get; set; }
    public WeatherItemData(WeatherItemType type,  string data)
    {
        Type = type;
        Title = GetTitleByType(type);
        Data = data;
        Icon = Image.FromFile(GetIconByType(type));
    }
    private static string GetTitleByType(WeatherItemType type)
    {
        return type switch
        {
            WeatherItemType.Wind => "Wind",
            WeatherItemType.Humidity => "Humidity",
            WeatherItemType.Pressure => "Pressure",
            WeatherItemType.Clouds => "Clouds",
            WeatherItemType.Visibility => "Visibility",
            WeatherItemType.Sunset => "Sunset",

            _ => "Unknown"
        };
    }
    private static string GetIconByType(WeatherItemType type)
    {
        return type switch
        {
            WeatherItemType.Wind => "Backgrounds/cold-wind_80384.png",
            WeatherItemType.Humidity => "Backgrounds/humidity_7925310.png",
            WeatherItemType.Pressure => "Backgrounds/barometer_8427008.png",
            WeatherItemType.Clouds => "Backgrounds/internet_15139829.png",
            WeatherItemType.Visibility => "Backgrounds/eye_13101960.png",
            WeatherItemType.Sunset => "Backgrounds/sunset_15197044.png",

            _ => "Backgrounds/cold-wind_80384.png"
        };
    }

    
}