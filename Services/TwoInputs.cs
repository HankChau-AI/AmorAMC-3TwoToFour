
namespace AmorAMC_3TwoToFour.Services
{
    public class TwoInputsServices
    {
        public string greet(string name, string wakeUpTime)
        {
            return $"Hello {name}, you woke up at {wakeUpTime}.";
        }
    }
}