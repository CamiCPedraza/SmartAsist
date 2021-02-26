using Insurance.Web.Model;
using Insurance.Web.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Insurance.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private IReadersRepository _repository;
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IReadersRepository readersRepository)
        {
            _logger = logger;
            _repository = readersRepository;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }

        // POST: ReadersController/Create
        [HttpPost]
        public async Task<string> Create(AditionalServices model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _repository.Add(model);
                    return $"OK :: {model.Id}";
                }
                else
                    return "Model invalid";
            }
            catch(Exception ex)
            {
                //throw new Exception(ex.Message);
                return ex.Message;
            }
        }
    }
}
