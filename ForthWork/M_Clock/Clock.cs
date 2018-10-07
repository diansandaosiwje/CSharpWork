using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace M_Clock
{
    public delegate void alarmEventArg(Clock clock);


    public class Clock
    {
        public event alarmEventArg Alarm;

        private int curH, curM, curS, alarmH, alarmM, alarmS;

        public Timer tmr;

        public Clock(int H,int M,int S)
        {
            this.curH= H;
            this.curM = M;
            this.curS = S;
        }
        public Clock()
        {
           
        }
        private int CurrentHour
        {
            set
            {
                if (value < 24 && value >= 0) this.curH = value;               
            }
            get
            {
                return curH;
            }
        }

        private int CurrentMinute
        {
            set
            {
                if (value < 60 && value >= 0) this.curM = value;
            }
            get
            {
                return curM;
            }
        }

        private int CurrentSecond
        {
            set
            {
                if (value < 60 && value >= 0) this.curS = value;             
            }
            get
            {
                return curS;
            }
        }

        private int AlarmHour
        {
            set
            {
                if (value < 24 && value >= 0) this.alarmH= value;
            }
            get
            {
                return alarmH;
            }
        }

        private int AlarmMinute
        {
            set
            {
                if (value < 60 && value >= 0) this.alarmM = value;
            }
            get
            {
                return alarmM;
            }
        }

        private int AlarmSecond
        {
            set
            {
                if (value < 60 && value >= 0) this.alarmS = value;
            }
            get
            {
                return alarmS;
            }
        }

        public void SetCurrentTime(int h,int m,int s)
        {
            CurrentHour = h;
            CurrentMinute = m;
            CurrentSecond = s;
        }

        public void SetAlarmClockTime(int h, int m, int s)
        {
            AlarmHour = h;
            AlarmMinute = m;
            AlarmSecond = s;
        }

        public void StartTimer()
        {

             tmr = new Timer(ChangeClock,this,1000,1000);
           
          
        }

        private void ChangeClock(Object status)
        {
            if (CurrentSecond + 1 >= 60)
            {
                CurrentSecond = (CurrentSecond + 1) % 60;

                if (CurrentMinute + 1 >= 60)
                {
                    CurrentMinute = (CurrentMinute + 1) % 60;

                    if (CurrentHour + 1 >= 24)
                    {
                        CurrentHour = (CurrentHour + 1) % 24;
                    }
                    else
                    {
                        CurrentHour += 1;
                    }

                }
                else
                {
                    this.CurrentMinute += 1;
                }

            }
            else
            {
                this.CurrentSecond += 1;
            }  
            
            if(CurrentHour==AlarmHour && CurrentMinute==AlarmMinute && CurrentSecond==AlarmSecond)
            {
                Alarm(this);
                tmr = null;
            }
        }

        public override string ToString()
        {
            return CurrentHour + " : " + CurrentMinute + " : " + CurrentSecond;
        }     


    }
}
