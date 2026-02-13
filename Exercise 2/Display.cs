using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates.Exercise_2
{
    internal class Display
    {
        public void ShowTemperature(object sender, TempArgs e)
        {
            Console.WriteLine($"Current temperature is {e.Temperature}");
        }
    }
}
