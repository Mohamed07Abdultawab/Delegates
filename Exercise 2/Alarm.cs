using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Delegates.Exercise_2
{
    internal class Alarm
    {
        private int AlarmValue { get; set; }

        public void SetAlarmVAlue(int alarmValue)
        {
            AlarmValue = alarmValue;
        }

        public Alarm(int alarmValue)
        {
            AlarmValue = alarmValue;
        }

        public void FireAlarm(object sender, TempArgs e)
        {
            if (e.Temperature >= AlarmValue)
            {
                Console.WriteLine("Alarm! Temperature is too high!");
            }
        }
    }
}
