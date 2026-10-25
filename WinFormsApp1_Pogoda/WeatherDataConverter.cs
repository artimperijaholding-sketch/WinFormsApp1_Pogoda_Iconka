using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1_Pogoda;

internal static class WeatherDataConverter
{
    private readonly static string[] directions =
    {
    "North", "North-Northeast", "Northeast", "East-Northeast",
    "East", "East-Southeast", "Southeast", "South-Southeast",
    "South", "South-Southwest", "Southwest", "West-Southwest",
    "West", "West-Northwest", "Northwest", "North-Northwest"
    };
    private readonly static string[] directionsShort =
    {
    "N", "N-NE", "N-E", "E-NE",
    "E", "E-SE", "S-E", "S-SE",
    "S", "S-SE", "S-E", "W-SW",
    "W", "W-NW", "N-W", "N-NW"
    };

    public static DateTime ConvertUnixTimestampToDateTime(long unixTime, int timezoneOffsetSeconds = 0)
    {
        DateTime utcDateTime = DateTimeOffset.FromUnixTimeSeconds(unixTime).UtcDateTime;
        return utcDateTime.AddSeconds(timezoneOffsetSeconds); // Local time based on offset
    }

    public static string WindDirectionToCompass(double degrees,bool isShort)
    {
        int index = (int)((degrees + 11.25) / 22.5) % 16;

        return isShort ? directionsShort[index] : directions[index];
    }

    public static string GetCloudinessDescription(int cloudiness)
    {
        if (cloudiness == 0)
            return "Clear sky";
        else if (cloudiness <= 25)
            return "Mostly clear";
        else if (cloudiness <= 50)
            return "Partly cloudy";
        else if (cloudiness <= 75)
            return "Mostly cloudy";
        else
            return "Overcast";
    }

    public static string WindSpeedToDescription(double speed)
    {
        if (speed < 0.3)
            return "Calm";
        else if (speed < 1.6)
            return "Light air";
        else if (speed < 3.4)
            return "Light breeze";
        else if (speed < 5.5)
            return "Gentle breeze";
        else if (speed < 7.9)
            return "Moderate breeze";
        else if (speed < 10.8)
            return "Fresh breeze";
        else if (speed < 13.9)
            return "Strong breeze";
        else if (speed < 17.2)
            return "Near gale";
        else if (speed < 20.8)
            return "Gale";
        else if (speed < 24.5)
            return "Severe gale";
        else if (speed < 28.5)
            return "Strong storm";
        else if (speed < 32.7)
            return "Violent storm";
        else
            return "Hurricane force";
    }
}
