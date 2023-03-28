using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L11
{
    internal class Program
    {
        delegate void CurentDay();

        static int counter = 0;

        static void Main(string[] args)
        {
            CurentDay curentDay = () =>
            {
                if (counter == 7)
                {
                    counter = 0;
                }

                switch (counter)
                {
                    case 0:
                        Console.WriteLine(DaysOfWeek.Monday);
                        break;
                    case 1:
                        Console.WriteLine(DaysOfWeek.Tuesday);
                        break;
                    case 2:
                        Console.WriteLine(DaysOfWeek.Wednesday);
                        break;
                    case 3:
                        Console.WriteLine(DaysOfWeek.Thursday);
                        break;
                    case 4:
                        Console.WriteLine(DaysOfWeek.Friday);
                        break;
                    case 5:
                        Console.WriteLine(DaysOfWeek.Saturday);
                        break;
                    case 6:
                        Console.WriteLine(DaysOfWeek.Sunday);
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;
                }

                counter++;

            };

            curentDay();
            curentDay();
            curentDay();
            curentDay();

            curentDay();
            curentDay();
            curentDay();
            curentDay();
        }
    }
}
