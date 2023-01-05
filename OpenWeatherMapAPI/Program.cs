using Newtonsoft.Json.Linq;

namespace OpenWeatherMapAPI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var APIKey = "cb6db26af206690d6cc36f3b77565f32";
            var cityName = "Fremont";
            var endPointURL = $"https://api.openweathermap.org/data/2.5/weather?q={cityName}&appid={APIKey}";
            var client = new HttpClient();
            var response = client.GetStringAsync(endPointURL).Result;
            var weatherObject = JObject.Parse(response);

            Console.WriteLine($"{weatherObject}");

        }
    }
}