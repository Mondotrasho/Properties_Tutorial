using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties_Tutorial
{
    class Money
    {
        private double dollerydoos;

       public double AUD
        {
            get
            {
                return dollerydoos;
            }
            set
            {
                dollerydoos = value;
            }
        }
        public double USD
        {
            get
            {
                return (dollerydoos / 1.38);
            }
            set
            {
                dollerydoos = value / 1.38;
            }
        }
        public double GBP
        {
            get
            {
                return (dollerydoos / 1.76);
            }
            set
            {
                dollerydoos = value / 1.76;
            }
        }
        public static double operator +(Money c1, Money c2)
        {
            var temp = new Money();
            var addition = (c1.AUD + c2.AUD);
            return temp.AUD = addition;
        }
        public static double operator -(Money c1, Money c2)
        {
            var temp = new Money();
            var subtraction = (c1.AUD - c2.AUD);
            return temp.AUD = subtraction;
        }
        public static double operator /(Money c1, Money c2)
        {
            var temp = new Money();
            var division = (c1.AUD / c2.AUD);
            return temp.AUD = division;
        }
        public static double operator *(Money c1, Money c2)
        {
            var temp = new Money();
            var multiplication = (c1.AUD * c2.AUD);
            return temp.AUD = multiplication;
        }
        public override string ToString()
        {
            return "USD: " + USD + " AUD " + AUD + " GBP " + GBP;
        }
    }
}
