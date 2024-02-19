using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Players_docker
{
    public class PlayersManagement
    {
        static List<Players> plist = new List<Players>() {
            new Players(){Id=1,Name="Rohit",Age=26,typeOfGame="Baseball" }, 
            new Players(){Id=2,Name="Krishna",Age=28,typeOfGame="Cricket" },
            new Players(){Id=3,Name="Sudheer",Age=22,typeOfGame="Football" },
            new Players(){Id=4,Name="Jagadeesh",Age=25,typeOfGame="Football" },
            new Players(){Id=5,Name="Meena",Age=24,typeOfGame="Tennis" }
        };

        public List<Players> allPlayers() { 
            return plist;
        }
        public List<Players> searchPlayer(int id) {
            List<Players> searchlist = plist.FindAll(p=>p.Id==id);
            return searchlist;
        }
    }
}
