using System.Text.Json;
using Allure.NUnit;

namespace DemoTest;

[AllureNUnit]
[TestFixture]
public class Tests
{
    ApiDemoInfra api = new ApiDemoInfra();
    string apiUrl = "http://localhost/demo/WeatherForecast/";

    [Test]
    public void WeatherForecastTest([Range(1, 12)] int value)
    {
        var res = api.GetWebApi($"{apiUrl}{value}");
    }
}