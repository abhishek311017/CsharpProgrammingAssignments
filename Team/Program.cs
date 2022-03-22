using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team
{
     public class Player
    {
        readonly string PlayerName;
        readonly int RunScored;

        public Player(string PlayerName ,int RunScored)
        {
            this.PlayerName = PlayerName;
            this.RunScored = RunScored;
        }

        public override string ToString()
        {
            return string.Format("Name Of the Player : " + PlayerName + "\t Run Scored By {0} : {1}" ,PlayerName, RunScored);
        }

    }

    public class Team : IEnumerable
    {
        readonly ArrayList list = new ArrayList();
        public Team()
        {
            list.Add(new Player("Virat",122));
            list.Add(new Player("Rohit", 264));
            list.Add(new Player("Dhoni", 183));
            list.Add(new Player("Sachin", 200));
            list.Add(new Player("Rahul", 134));
            list.Add(new Player("Lord Shardul", 92));

        }

        public IEnumerator GetEnumerator()
        {
            return list.GetEnumerator();
        }
    }

    class Program
    {

        public static IEnumerable<string> GetPlayer()
        {
            Team India = new Team();
            
            foreach (var player in India)
            {
                yield return player.ToString(); 
            }
        }
        public static void Main()
        {
            Team India = new Team();  

            foreach (var t in India)
            {
                Console.WriteLine(t);
            }

            Console.WriteLine("Using Iterator");
            IEnumerable<string> Players = GetPlayer();
            //Console.WriteLine(Players);
            foreach (var Player in Players) // Iterating returned elements  
            {
                Console.WriteLine(Player);
            }
            Console.ReadLine();
        }
    }
}
