using System;

/// <summary>
/// IGME-106 - Game Development and Algorithmic Problem Solving
/// Practice Exercise 2 - Events & Delegates
/// Class Description   : This is the Die class for Practice Exercise 2
/// Author              : Benjamin Kleynhans
/// Modified By         : Benjamin Kleynhans
/// Date                : January 23, 2018
/// Filename            : Die.cs
/// </summary>

namespace EventsAndDelegates
{
    /// <summary>
    /// The Die class instantiates a random number generator and rolls the die
    ///     the indicated number of times.  If the number 20 is cast, an event is
    ///     triggered
    /// </summary>
    public class Die
    {
        private int rollCounter = 0;                                // Counts the number of times the die is cast
        private Random random = new Random();                       // Instantiate a random number generator

        public event MessageDelegate RolledATwenty;                 // Create the event

        /// <summary>
        /// Roll the die
        /// </summary>
        /// <returns>The value that was cast on the die</returns>
        public int Roll()
        {
            int returnValue = 0;            
            int randomNumber = random.Next(1, 21);

            if (randomNumber == 20)
            {
                if (RolledATwenty != null)                          // If a handler is attached, throw the event
                {
                    RolledATwenty("Rolled a 20", "This was roll number " + (rollCounter + 1));
                }
            }

            rollCounter++;
            returnValue = randomNumber;

            return returnValue;
        }
    }
}
