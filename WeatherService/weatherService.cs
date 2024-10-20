using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

public class weatherService
{
    private static readonly HttpClient client = new HttpClient();
    private string apiKey = "af76bcaeefa710d3d8c0709f1b6e7bbc"; // Replace with your actual API key

    public async Task<WeatherData> GetWeatherAsync(string city)
    {
        string url = $"http://api.weatherstack.com/current?access_key={apiKey}&query={city}";
        var response = await client.GetStringAsync(url);
        return JsonConvert.DeserializeObject<WeatherData>(response);
    }
}

public class WeatherData
{
    public CurrentData Current { get; set; }

    public class CurrentData
    {
        [JsonProperty("temperature")]
        public float Temp { get; set; }

        [JsonProperty("weather_descriptions")]
        public string[] WeatherDescription { get; set; }

        public int Humidity { get; set; }

        [JsonProperty("wind_speed")]
        public float WindSpeed { get; set; }
    }
}
