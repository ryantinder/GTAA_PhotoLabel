using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTAA_PhotoLabel.Classes
{
    [Serializable]
    public class Roster
    {
        public string sport;
        public List<Player> players;

        private void addPlayer(Player player)
        {
            players.Add(player);
        }
        public void addPlayer(int number, string firstName, string lastName)
        {
            addPlayer(new Player(number, firstName, lastName));
        }
        public void addPlayer(int number, string lastName)
        {
            addPlayer(new Player(number, "", lastName));
        }

        private void removePlayerByNumber(int number)
        {
            for (int i = 0; i < players.Count; i++)
            {
                if (players[i].number == number)
                {
                    players.RemoveAt(i);
                }
            }
        }

        private void removePlayerByName(string firstName, string lastName)
        {
            var nums = from player in players where player.firstName == firstName where player.lastName == lastName select player.number;
            foreach(int number in nums)
            {
                removePlayerByNumber(number);
            }
        }


    }
}
