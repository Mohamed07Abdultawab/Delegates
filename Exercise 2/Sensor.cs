using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates.Exercise_2
{
    internal class Sensor
    {
        public event EventHandler<TempArgs> SensorChanged;
        private int _CurrentTemperature { get; set; }
        public void ChangeTemperature(int newTemperature)
        {
            _CurrentTemperature = newTemperature;
            SensorChanged.Invoke(this, new TempArgs(newTemperature));
        }
    }
}
