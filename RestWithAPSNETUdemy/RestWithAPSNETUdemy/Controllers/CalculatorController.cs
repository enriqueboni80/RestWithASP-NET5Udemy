using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace RestWithAPSNETUdemy.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;

        public CalculatorController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet("sum/{firstNumber}/{secondNumber}")]
        public IActionResult Sum(double firstNumber, double secondNumber)
        {
            double result = firstNumber + secondNumber;
            return Ok(result.ToString());
        }

        [HttpGet("subtraction/{firstNumber}/{secondNumber}")]
        public IActionResult Subtraction(double firstNumber, double secondNumber)
        {
            double result = firstNumber - secondNumber;
            return Ok(result.ToString());
        }

        [HttpGet("multiplication/{firstNumber}/{secondNumber}")]
        public IActionResult Multiplication(double firstNumber, double secondNumber)
        {
            double result = firstNumber * secondNumber;
            return Ok(result.ToString());
        }

        [HttpGet("division/{firstNumber}/{secondNumber}")]
        public IActionResult Division(double firstNumber, double secondNumber)
        {
            double result = firstNumber / secondNumber;
            return Ok(result.ToString());
        }
    }
}
