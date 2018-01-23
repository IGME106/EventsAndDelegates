using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    public class Die
    {
        private int rollCounter = 0;
        private Random random = new Random();

        public event MessageDelegate RolledATwenty;

        public int Roll()
        {
            int returnValue = 0;            
            int randomNumber = random.Next(1, 21);

            if (randomNumber == 20)
            {
                if (RolledATwenty != null)
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
