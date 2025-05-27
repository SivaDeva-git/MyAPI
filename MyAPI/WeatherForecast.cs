namespace MyAPI
{
    public class WeatherForecast
    {
        //These are properties.
        //THis is New.
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }


    }
}