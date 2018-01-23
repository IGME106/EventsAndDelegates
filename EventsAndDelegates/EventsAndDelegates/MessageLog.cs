using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{    
    public class MessageLog
    {
        private List<string> listOfLabels = new List<string>();
        private List<string> listOfMessages = new List<string>();
        
        private string Labels
        {
            set { listOfLabels.Add(value); }
        }

        private string Messages
        {
            set { listOfMessages.Add(value); }
        }

        public void Save(string inputLabel, string inputMessage)
        {
            Labels = inputLabel;
            Messages = inputMessage;
        }

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
