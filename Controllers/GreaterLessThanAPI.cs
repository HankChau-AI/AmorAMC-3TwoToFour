
using Microsoft.AspNetCore.Mvc;

using AmorAMC_3TwoToFour.Services;

namespace AmorAMC_3TwoToFour.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GreaterLessThanAPI : Controller
    {
        private readonly GreaterLessThanServices _greaterLessThanServices;

        public GreaterLessThanAPI(GreaterLessThanServices greaterLessThanServices)
        {
            _greaterLessThanServices = greaterLessThanServices;
        }

        [HttpGet]
        [Route("compare/{num1}/{num2}")]
        public string compare(int num1, int num2)
        {
            return _greaterLessThanServices.compare(num1, num2);
        }



    }
}