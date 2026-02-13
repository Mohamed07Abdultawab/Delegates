using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates.Exercise_2
{
    internal class TempArgs:EventArgs
    {
        public int Temperature { get; set; }
        public TempArgs(int temperature)
        {
            Temperature = temperature;
        }
    }
}
