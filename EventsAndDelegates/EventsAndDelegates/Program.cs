using System;

/// <summary>
/// IGME-106 - Game Development and Algorithmic Problem Solving
/// Practice Exercise 2 - Events & Delegates
/// Class Description   : This is the driver class for Practice Exercise 2
/// Author              : Benjamin Kleynhans
/// Modified By         : Benjamin Kleynhans
/// Date                : January 23, 2018
/// Filename            : Program.cs
/// </summary>

namespace EventsAndDelegates
{
    /// <summary>
    /// Creates a delegate for event management from the die class
    /// </summary>
    /// <param name="label">The label stating that a 20 was rolled</param>
    /// <param name="message">The message of which line the 20 was rolled at</param>
    public delegate void MessageDelegate(string label, string message);
    
    /// <summary>
    /// The main program instantiates the Die and MessageLog objects and then rolls
    ///     the die the number of times stipulated in the NumberOfRolls constant.  Output
    ///     is produced after each roll with a summary of which rolls ended in a 20.
    /// </summary>
    public class Program
    {
        const int NumberOfRolls = 100;                              // Constant stipulating the number of rolls required

        static void Main(string[] args)
        {            
            MessageLog messageLog = new MessageLog();
            Die die = new Die();

            die.RolledATwenty += messageLog.Save;                   // Add the messageLog event handler to the RolledATwenty event

            Console.WriteLine("Rolling lots of dice:");

            for (int i = 0; i < NumberOfRolls; i++)                 // Roll the die the specified number of times
            {
                int rolledValue = die.Roll();

                PrintRoll(rolledValue);
            }

            Console.WriteLine();
            if (messageLog.IsEmpty)                                 // Test if a 20 was rolled or not and provide the
            {                                                           // appropriate heading
                Console.WriteLine("The number 20 was not rolled");
            }
            else
            {
                Console.WriteLine("Printing message log:");
            }
            
            messageLog.Print();

            Console.ReadKey();
        }

        /// <summary>
        /// Prints the result of each die roll to the screen
        /// </summary>
        /// <param name="rolledValue">The value that was rolled</param>

        public static void PrintRoll(int rolledValue)
        {
            Console.WriteLine("Rolling..." + rolledValue);            
        }
    }
}
