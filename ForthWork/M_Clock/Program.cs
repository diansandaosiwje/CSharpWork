using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace M_Clock
{
    class Program
    {
        static void Main(string[] args)
        {
            var clock = new Clock();

            clock.Alarm += Clock_Alarm;//注册事件

            clock.SetCurrentTime(19, 58, 47);           
            clock.SetAlarmClockTime(19, 59, 0);

            clock.StartTimer();

            while (clock.tmr != null)
                Thread.Sleep(0);
        }

        private static void Clock_Alarm(Clock clock)
        {
            Console.WriteLine("It's time to "+clock.ToString());
        }
    }
}
