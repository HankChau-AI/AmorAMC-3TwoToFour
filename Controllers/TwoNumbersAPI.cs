
using Microsoft.AspNetCore.Mvc;
using AmorAMC_3TwoToFour.Services;


namespace AmorAMC_3TwoToFour
{
    [ApiController]
    [Route("[controller]")]
    public class TwoNumbersAPI : Controller
    {
        private readonly TwoNumbers _twoNumbers;

        public TwoNumbersAPI(TwoNumbers twoNumbers)
        {
            _twoNumbers = twoNumbers;
        }

         [HttpGet]
        [Route("add/{num1}/{num2}")]
        public int add(int num1, int num2)
        {
            return _twoNumbers.add(num1, num2);
        }
    }
}