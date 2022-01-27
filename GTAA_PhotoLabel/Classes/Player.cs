using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTAA_PhotoLabel.Classes
{
    [Serializable]
    public class Player
    {
        public int number;
        public string firstName;
        public string lastName;
        private string FormattedName
        {
            get { return lastName + firstName[0]; }
        }

        public Player(int number, string firstName, string lastName)
        {
            this.number = number;
            this.firstName = firstName;
            this.lastName = lastName;
        }
    }
}
