using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication3.Services;

namespace WebApplication3.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CalcController : ControllerBase
    {
        private readonly CalcService _calcService;
        private readonly ILogger<CalcController> _logger;

        public CalcController(CalcService calcService, ILogger<CalcController> logger)
        {
            _calcService = calcService;
            _logger = logger;
        }

        [HttpGet("add")]
        public ActionResult<int> Add([FromQuery] int a, [FromQuery] int b)
        {
            try
            {
                int result = _calcService.Add(a, b);
                _logger.LogInformation($"Add result: {result}");
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in Add method");
                return BadRequest("An error occurred during calculation.");
            }
        }

        [HttpGet("subtract")]
        public ActionResult<int> Subtract([FromQuery] int a, [FromQuery] int b)
        {
            try
            {
                int result = _calcService.Subtract(a, b);
                _logger.LogInformation($"Subtract result: {result}");
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in Subtract method");
                return BadRequest("An error occurred during calculation.");
            }
        }

        [HttpGet("multiply")]
        public ActionResult<int> Multiply([FromQuery] int a, [FromQuery] int b)
        {
            try
            {
                int result = _calcService.Multiply(a, b);
                _logger.LogInformation($"Multiply result: {result}");
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in Multiply method");
                return BadRequest("An error occurred during calculation.");
            }
        }

        [HttpGet("divide")]
        public ActionResult<double> Divide([FromQuery] int a, [FromQuery] int b)
        {
            try
            {
                double result = _calcService.Divide(a, b);
                _logger.LogInformation($"Divide result: {result}");
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in Divide method");
                return BadRequest("An error occurred during calculation.");
            }
        }
    }
}