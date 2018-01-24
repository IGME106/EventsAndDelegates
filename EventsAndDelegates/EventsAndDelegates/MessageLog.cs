using System;
using System.Collections.Generic;

/// <summary>
/// IGME-106 - Game Development and Algorithmic Problem Solving
/// Practice Exercise 2 - Events & Delegates
/// Class Description   : This is the MessageLog class for Practice Exercise 2
/// Author              : Benjamin Kleynhans
/// Modified By         : Benjamin Kleynhans
/// Date                : January 23, 2018
/// Filename            : MessageLog.cs
/// </summary>

namespace EventsAndDelegates
{    
    /// <summary>
    /// Adds a log entry into the two lists every time the number 20 is cast
    /// </summary>
    public class MessageLog
    {
        private List<string> listOfLabels = new List<string>();
        private List<string> listOfMessages = new List<string>();
        
        private string Labels
        {
            set { listOfLabels.Add(value); }                        // Add a label to the list
        }

        private string Messages
        {
            set { listOfMessages.Add(value); }                      // Add the appropriate message to the list
        }

        /// <summary>
        /// Sets the values for both the label and message
        /// </summary>
        /// <param name="inputLabel">Label for the specified event</param>
        /// <param name="inputMessage">Message for the specified event</param>
        public void Save(string inputLabel, string inputMessage)
        {
            Labels = inputLabel;
            Messages = inputMessage;
        }

        /// <summary>
        /// Determines whether the lists contain any data
        /// </summary>
        /// <returns>True if the list is empty, alternatively return false</returns>
        public bool IsEmpty
        {
            get
            {
                bool returnValue = false;

                if (listOfLabels.Count == 0)
                {
                    returnValue = true;
                }

                return returnValue;
            }
        }

        /// <summary>
        /// Format the output and print the lists to console
        /// </summary>
        public void Print()
        {
            for (int i = 0; i < listOfLabels.Count; i++)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write(listOfLabels[i] + ": ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(listOfMessages[i]);
            }
        }
    }
}
