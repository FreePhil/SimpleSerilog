using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace SimpleLog.Controllers
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

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            try
            {
                var rng = new Random();
                var error = rng.Next(10);

                _logger.LogDebug("Random generator creates {RandomNumber}", error);

                if (error >= 6)
                {
                    _logger.LogWarning("Error should not exceed 5, current value: {ErrorCode}", error);

                    error = 0;
                }
                
                if (error == 2)
                {
                    throw new ArgumentException("Fatal weather");
                }

                if (error == 1)
                {
                    throw new ApplicationException("Stop operation");
                }

                var fiveDayWeathers = Enumerable.Range(1, 5).Select(index => new WeatherForecast
                    {
                        Date = DateTime.Now.AddDays(index),
                        TemperatureC = rng.Next(-20, 55),
                        Summary = Summaries[rng.Next(Summaries.Length)]
                    })
                    .ToArray();
                _logger.LogInformation("Get weather forecast, the first day: {@FirstDayWeathers}", fiveDayWeathers[0]);
                return fiveDayWeathers;
            }
            catch (ArgumentException e)
            {
                _logger.LogCritical(e, "Fatal weather warning");
                throw;
            }
            catch (ApplicationException e)
            {
                _logger.LogError(e, "Radar in maintenance");
                return null;
            }
        }
    }
}