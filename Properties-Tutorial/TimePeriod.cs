using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties_Tutorial
{
    class TimePeriod
    {
        private int days;

        public int Days
        {
            get
            {
                return days;
            }
            set
            {
                days = value;
            }
        }
        public int Weeks
        {
            get
            {
                return (days * 7);
            }
            set
            {
                days = value * 7;
            }
        }
    }

    
}