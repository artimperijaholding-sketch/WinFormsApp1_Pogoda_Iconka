using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace WinFormsApp1_Pogoda;



internal class WeatherManager
{
    private const string API_KEY = "b12ac118ea5cc902407fa31066cf1c90"; // Replace with your API key
    private HttpClient httpClient = new HttpClient();

    public WeatherManager()
    {

    }
    public async Task<WeatherResponse> GetWeatherAsync(string city)
    {
        try
        {
            string url = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={API_KEY}&units=metric";
           string data= await httpClient.GetStringAsync(url);
            if(!string.IsNullOrEmpty(data))
            {
                WeatherResponse weather= JsonConvert.DeserializeObject<WeatherResponse>(data);
                return weather;
            }
        }
        catch(HttpRequestException ex)
        {
            Debug.WriteLine($"Error Type: {ex.GetType().Name}\nMessage: {ex.StatusCode}");
        }
        catch(Exception ex)
        {
            Debug.WriteLine($"Network Error: {ex.Message}\nStatus: {ex.Message}");
        }
        return null;
    }
    public async Task<WeatherForecastResponce> GetForecastAsync(string city)
    {
        try
        {
            string url = $"https://api.openweathermap.org/data/2.5/forecast?q={city}&appid={API_KEY}&units=metric";
           string data= await httpClient.GetStringAsync(url);
            if(!string.IsNullOrEmpty(data))
            {
                WeatherForecastResponce weatherResponce= JsonConvert.DeserializeObject<WeatherForecastResponce>(data);
                return weatherResponce;
            }
        }
        catch(HttpRequestException ex)
        {
            Debug.WriteLine($"Error Type: {ex.GetType().Name}\nMessage: {ex.StatusCode}");
        }
        catch(Exception ex)
        {
            Debug.WriteLine($"Network Error: {ex.Message}\nStatus: {ex.Message}");
        }
        return null;
    }
}
