using Microsoft.AspNetCore.Mvc;

namespace BinaryConverterAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BinaryConverterController : ControllerBase
    {
        [HttpGet]
        [Route("decimal-to-binary/{number}")]
        public ActionResult<string> ConvertToBinary(int number)
        {
            if (number < 0)
            {
                return BadRequest("Input must be a non-negative integer.");
            }

            string binary = ToBinary(number);
            return Ok(binary);
        }

        private string ToBinary(int n)
        {
            if (n == 0)
            {
                return "0";
            }

            string binary = "";
            while (n > 0)
            {
                int rem = n % 2;
                binary = rem + binary;
                n = n / 2;
            }

            return binary;
        }
    }
}
