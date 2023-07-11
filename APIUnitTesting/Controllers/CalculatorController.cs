using CalculatorAPIUnitTesting.Services;
using Microsoft.AspNetCore.Mvc;
using static CalculatorAPIUnitTesting.Services.CalculatorRepo;

namespace CalculatorAPIUnitTesting.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        CalculatorRepo _calculatorRepo;

        public CalculatorController(CalculatorRepo calculatorRepo)
        {
            _calculatorRepo = calculatorRepo;
        }

        [HttpGet("add/{a}/{b}")]
        public ActionResult<int> Add(int a, int b)
        {
            return _calculatorRepo.Add(a, b);
        }

        [HttpGet("subtract/{a}/{b}")]
        public ActionResult<int> Subtract(int a, int b)
        {
            return _calculatorRepo.Subtract(a, b);
        }

        [HttpGet("multiply/{a}/{b}")]
        public ActionResult<int> Multiply(int a, int b)
        {
            return _calculatorRepo.Multiply(a, b);
        }

        [HttpGet("divide/{a}/{b}")]
        public ActionResult<double> Divide(int a, int b)
        {
            try
            {
                return _calculatorRepo.Divide(a, b);
            }
            catch (CalculatorException ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
