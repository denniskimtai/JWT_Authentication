using JWTPractice.EndPoints;
using JWTPractice.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JWTPractice.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly JWTOptions _jwtOptions;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, JWTOptions jwtOptions)
        {
            _logger = logger;
            _jwtOptions = jwtOptions;
        }

        [Authorize]
        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpPost("token")]
        public Task<IResult> AccessToken()
        {

            var result = TokenEndpoint.Connect(HttpContext, _jwtOptions);

            return result; 


        }
    }
}