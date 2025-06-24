namespace Product.Api;

public class WeatherForecast
{
    public DateOnly Date { get; set; }

    public int TemperatureC { get; set; }

    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

    public string? Summary { get; set; }

     public string GetTemperatureCategory()
        {
            if (TemperatureC >= 30)
                return "Hot";
            else if (TemperatureC <= 10)
                return "Cold";
            else
                return "Moderate";
        }
}
