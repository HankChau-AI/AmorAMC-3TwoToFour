using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmorAMC_3TwoToFour.Services
{
    public class TwoInputs
    {
        public string greet(string name, string wakeUpTime)
        {
            return $"Hello {name}, you woke up at {wakeUpTime}.";
        }
    }
}