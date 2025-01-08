
using Microsoft.AspNetCore.Mvc;
using AmorAMC_3TwoToFour.Services;


namespace AmorAMC_3TwoToFour
{
    [ApiController]
    [Route("[controller]")]
    public class TwoNumbersAPI : Controller
    {
        private readonly TwoNumbersServices _twoNumbersServices;

        public TwoNumbersAPI(TwoNumbersServices twoNumbersServices)
        {
            _twoNumbersServices = twoNumbersServices;
        }

         [HttpGet]
        [Route("add/{num1}/{num2}")]
        public int add(int num1, int num2)
        {
            return _twoNumbersServices.add(num1, num2);
        }
    }
}