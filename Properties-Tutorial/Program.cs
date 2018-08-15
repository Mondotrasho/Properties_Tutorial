using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties_Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            TimePeriod time = new TimePeriod();
            Console.WriteLine(time.Days);
            time.Days += 4;
            Console.WriteLine(time.Days);
            time.Weeks += 4;
            Console.WriteLine(time.Days);
            Console.WriteLine(time.Weeks);

            Money money = new Money();
            Console.WriteLine(money.AUD);
            Console.WriteLine(money.USD);
            Console.WriteLine(money.GBP);
            money.GBP += 100;
            Console.WriteLine(money.USD);
            money.GBP *= 4;
            Console.WriteLine(money.ToString());
            Console.ReadLine();
        }
    }
}
