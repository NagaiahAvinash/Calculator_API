using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CalculatorLib;

namespace CalController
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        private readonly CalculatorService _calculatorService;

        public CalculatorController()
        {
            _calculatorService = new CalculatorService();
        }

        [HttpGet("Addition")]
        public ActionResult<int> Addition(int x, int y)
        {
            var sum = _calculatorService.Addition(x, y);
            return Ok(sum);
        }

        [HttpGet("Subtraction")]
        public ActionResult<int> Subtraction(int x, int y)
        {
            var difference = _calculatorService.Subtraction(x, y);
            return Ok(difference);
        }

        [HttpGet("Multiplication")]
        public ActionResult<int> Multiplication(int x, int y)
        {
            var product = _calculatorService.Multiplication(x, y);
            return Ok(product);
        }

        [HttpGet("Division")]
        public ActionResult<int> Division(int x, int y)
        {
            try
            {
                var quotient = _calculatorService.Division(x, y);
                return Ok(quotient);
            }
            catch (DivideByZeroException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("Modulus")]
        public ActionResult<int> Modulus(int x, int y)
        {
            try
            {
                var remainder = _calculatorService.Modulus(x, y);
                return Ok(remainder);
            }
            catch (DivideByZeroException ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}