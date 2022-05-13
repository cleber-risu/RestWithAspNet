using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace RestCore5.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
        
        private readonly ILogger<CalculatorController> _logger;

        public CalculatorController(ILogger<CalculatorController> logger)
        {
            _logger = logger;
        }

        [HttpGet("sum/{firstNumber}/{secondNumber}")]
        public IActionResult Sum(string firstNumber, string secondNumber)
        {
            if (isNumeric(firstNumber) && isNumeric(secondNumber)) 
            {
                var n = ConvertToDecimal(firstNumber) + ConvertToDecimal(secondNumber);
                return Ok(n.ToString());
            }
            return BadRequest("Invalid input");
        }

        [HttpGet("subtraction/{firstNumber}/{secondNumber}")]
        public IActionResult Subtraction(string firstNumber, string secondNumber)
        {
            if (isNumeric(firstNumber) && isNumeric(secondNumber)) 
            {
                var n = ConvertToDecimal(firstNumber) - ConvertToDecimal(secondNumber);
                return Ok(n.ToString());
            }
            return BadRequest("Invalid input");
        }

        [HttpGet("multiplication/{firstNumber}/{secondNumber}")]
        public IActionResult Multiplication(string firstNumber, string secondNumber)
        {
            if (isNumeric(firstNumber) && isNumeric(secondNumber)) 
            {
                var n = ConvertToDecimal(firstNumber) * ConvertToDecimal(secondNumber);
                return Ok(n.ToString());
            }
            return BadRequest("Invalid input");
        }

        [HttpGet("division/{firstNumber}/{secondNumber}")]
        public IActionResult Division(string firstNumber, string secondNumber)
        {
            if (isNumeric(firstNumber) && isNumeric(secondNumber)) 
            {
                var n = ConvertToDecimal(firstNumber) / ConvertToDecimal(secondNumber);
                return Ok(n.ToString());
            }
            return BadRequest("Invalid input");
        }

        [HttpGet("mean/{firstNumber}/{secondNumber}")]
        public IActionResult Mean(string firstNumber, string secondNumber)
        {
            if (isNumeric(firstNumber) && isNumeric(secondNumber)) 
            {
                var n = (ConvertToDecimal(firstNumber) + ConvertToDecimal(secondNumber)) / 2;
                return Ok(n.ToString());
            }
            return BadRequest("Invalid input");
        }

        [HttpGet("square-root/{firstNumber}")]
        public IActionResult SquareRoot(string firstNumber)
        {
            if (isNumeric(firstNumber)) 
            {
                var n = Math.Sqrt((double)ConvertToDecimal(firstNumber));
                return Ok(n.ToString());
            }
            return BadRequest("Invalid input");
        }

        private decimal ConvertToDecimal(string strNumber)
        {
            decimal decimalValue;
            return decimal.TryParse(strNumber, out decimalValue) ? decimalValue : 0; 
        }

        private bool isNumeric(string strNumber)
        {
            double number;
            return double.TryParse(
                strNumber, 
                System.Globalization.NumberStyles.Any, 
                System.Globalization.NumberFormatInfo.InvariantInfo, 
                out number);
        }
    }
}
