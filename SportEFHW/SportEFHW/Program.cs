using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportEFHW
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var context = new Sportcontext())
            {

                Team team = new Team
                {
                    Name = "PSG"
                };
                context.Teams.Add(team);
                Player playerNeymar = new Player
                {
                    FullName = "Neymar",
                    Number = 4,
                    Team = team
                    
                };
                context.Players.Add(playerNeymar);
                context.SaveChanges();

                var players = from Players in context.Players
                              where Players.FullName == "Neymar"
                              select Players;

                Player player = players.FirstOrDefault();

                Console.WriteLine("Имя: " + player.FullName + "Number: " + player.Number + "Id Team: " + player.TeamId);
                Console.ReadLine();


            }
        }
    }
}
