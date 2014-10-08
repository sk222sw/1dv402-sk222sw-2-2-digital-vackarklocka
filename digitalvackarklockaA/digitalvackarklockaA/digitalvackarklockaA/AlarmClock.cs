﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace digitalvackarklockaA
{
    class AlarmClock
    {
        private int _alarmHour;
        private int _alarmMinute;
        private int _hour;
        private int _minute;

        public int AlarmHour
        {
            get { return _alarmHour; }
            set
            {
                if (value < 0 || value > 23)
                {
                    throw new ArgumentException();
                }
                _alarmHour = value;

            }
        }         //get set klar

        public int AlarmMinute
        {
            get { return _alarmMinute; }
            set
            {
                if (value < 0 || value > 59)
                {
                    throw new ArgumentException();
                }
                _alarmMinute = value;
            }
        }       //get set klar

        public int Hour
        {
            get { return _hour; }
            set
            {
                if (value < 0 || value > 23)
                {
                    throw new ArgumentException();
                }
                _hour = value;
            }
        }              //get set klar

        public int Minute
        {
            get { return _minute; }
            set
            {
                if (value < 0 || value > 59)
                {
                    throw new ArgumentException();
                }
                _minute = value;
            }
        }            //get set klar

        public AlarmClock()             //ärver från den AlarmClock-konstruktor som har 2 parametrar.
            : this(0, 0)
        {}

        public AlarmClock(int hour, int minute)     //ärver från den AlarmClock-konstruktor som har 4 parametrar.
            : this(hour, minute, 0, 0)
        {}

        public AlarmClock(int hour, int minute, int alarmHour, int alarmMinute)
        {
            AlarmHour = alarmHour;
            AlarmMinute = alarmMinute;
            Hour = hour;
            Minute = minute;
        }

        public bool TickTock()
        {
            Minute++;
            if (Minute > 59)
            {
                Minute = 0;
                Hour++;
                if (Hour > 23)
                {
                    Hour = 0;
                }
            }

            if (Hour == AlarmHour && Minute == AlarmMinute)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public override string ToString()
        {
            if (Minute < 10)
            {
                return string.Format("{0}:0{}", Hour, Minute);
            }
            else
            {
                return string.Format("{0}:0{}", Hour, Minute);
            }


        }

    }
}
