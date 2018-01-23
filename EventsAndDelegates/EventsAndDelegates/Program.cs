using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    public delegate void MessageDelegate(string label, string message);
    
    public class Program
    {
        const int NUMBERoFrOLLS = 20;

        static void Main(string[] args)
        {            
            MessageLog messageLog = new MessageLog();
            Die die = new Die();

            die.RolledATwenty += messageLog.Save;

            Console.WriteLine("Rolling lots of dice:");

            for (int i = 0; i < 20; i++)
            {
                int rolledValue = die.Roll();

                PrintRoll(rolledValue);
            }

            Console.WriteLine();
            if (messageLog.IsEmpty)
            {
                Console.WriteLine("The number 20 was not rolled");
            }
            else
            {
                Console.WriteLine("Printing message log:");
            }
            
            messageLog.Print();

            Console.ReadKey();
        }

        public static void PrintRoll(int rolledValue)
        {
            Console.WriteLine("Rolling..." + rolledValue);            
        }
    }
}
