
using Microsoft.AspNetCore.Mvc;

using AmorAMC_3TwoToFour.Services;


namespace AmorAMC_3TwoToFour.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TwoInputsAPI : Controller
    {
        private readonly TwoInputsServices _twoInputsServices;

        public TwoInputsAPI(TwoInputsServices twoInputsServices)
        {
            _twoInputsServices = twoInputsServices;
        }

       [HttpGet]
        [Route("greet/{name}/{WakeUpTime}")]
        public string greet(string name, string wakeUpTime)
        {
            return _twoInputsServices.greet(name, wakeUpTime);
        }
    }
}