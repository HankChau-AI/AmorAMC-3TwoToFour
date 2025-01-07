
using Microsoft.AspNetCore.Mvc;
using AmorAMC_3TwoToFour.Services;

namespace AmorAMC_3TwoToFour.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GreaterLessThanAPI : Controller
    {
        private readonly GreaterLessThan _greaterLessThan;

        public GreaterLessThanAPI(GreaterLessThan greaterLessThan)
        {
            _greaterLessThan = greaterLessThan;
        }

        [HttpGet]
        [Route("greaterLessThan/{num1}/{num2}")]
        public string greaterLessThan(int num1, int num2)
        {
            return _greaterLessThan.compare(num1, num2);
        }

          
      
    }
}