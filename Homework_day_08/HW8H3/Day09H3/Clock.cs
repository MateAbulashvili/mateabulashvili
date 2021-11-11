using System;
using System.Collections.Generic;
using System.Text;

namespace Day09H3
{
    class Clock
    {
        private sbyte ClockSecond;
        private sbyte ClockMinute;
        private sbyte ClockHour;

        public sbyte Second
        {
            get
            {
                return ClockSecond;
            }
            set
            {
                if (value >= 0)
                {
                    ClockSecond = value;
                }
                else
                {
                    ClockSecond = -1;
                }
            }
        }
        public sbyte Hour
        {
            get
            {
                return ClockHour;
            }
            set
            {
                if (value >= 0)
                {
                    ClockHour = value;
                }
                else
                {
                    ClockHour = -1;
                }
            }
        }
        public sbyte Minute
        {
            get
            {
                return ClockMinute;
            }
            set
            {
                if (value >= 0)
                {
                    ClockMinute = value;
                }
                else
                {
                    ClockMinute = -1;
                }
            }
        }


        public void AddSecond()
        {
            
            if(ClockSecond == 59)
            {
                ClockSecond = 0;
                AddMinute();
            }
            else
                ClockSecond++;
        }
        public void AddMinute()
        {
            
            if (ClockMinute == 59)
            {
                ClockMinute = 0;
                AddHour();
            }
            else
                ClockMinute++;
        }
        public void AddHour()
        {
            
            if (ClockHour == 23)
            {
                ClockHour = 0;
            }
            else
                ClockHour++;
        }
        public void SubtractSecond()
        {
            
            if (ClockSecond == 0)
            {
                ClockSecond = 59;
                SubtractMinute();
            }
            else
                ClockSecond--;
        }
        public void SubtractMinute()
        {
            
            if (ClockMinute == 0)
            {
                ClockMinute = 59;
                SubtractHour();
            }
            else
            {
                ClockMinute--;
            }
        }
        public void SubtractHour()
        {
            
            if (ClockHour == 0)
            {
                ClockHour = 23;
            }
            else
                ClockHour--;
        }
        public void GetCurrentTime()
        {
            Console.WriteLine("{0}:{1}:{2}", ClockHour, ClockMinute, ClockSecond);
        }
    }
}
