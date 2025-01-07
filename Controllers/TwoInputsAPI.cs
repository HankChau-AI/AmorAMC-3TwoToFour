
using Microsoft.AspNetCore.Mvc;
using AmorAMC_3TwoToFour.Services;


namespace AmorAMC_3TwoToFour.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TwoInputsAPI : Controller
    {
        private readonly TwoInputs _twoInputs;

        public TwoInputsAPI(TwoInputs twoInputs)
        {
            _twoInputs = twoInputs;
        }

       [HttpGet]
        [Route("greet/{name}/{WakeUpTime}")]
        public string greet(string name, string wakeUpTime)
        {
            return _twoInputs.greet(name, wakeUpTime);
        }
    }
}