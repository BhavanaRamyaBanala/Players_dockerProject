// See https://aka.ms/new-console-template for more information
using Players_docker;

Console.WriteLine("** Player details!! **");
Console.WriteLine("----------------------");
PlayersManagement playersManagement = new PlayersManagement();

    foreach (var p in playersManagement.allPlayers()) {
        Console.WriteLine("PlayerId: " + p.Id);
        Console.WriteLine("PlayerName: " + p.Name);
        Console.WriteLine("PlayerAge: " + p.Age);
        Console.WriteLine("PlayersGame: " + p.typeOfGame);
        Console.WriteLine("--------------------------------");
    }

Console.WriteLine("Enter playerId to display specific player details!! ");
int pID=int.Parse(Console.ReadLine());
var playerDetails = playersManagement.searchPlayer(pID);

if (playerDetails.Count > 0)
{
    Console.WriteLine("Player found:");
    Console.WriteLine("PlayerId: {0}\nPlayerName: {1}\nPlayerAge: {2}\nPlayersGame: {3}",
                      playerDetails[0].Id, playerDetails[0].Name, playerDetails[0].Age, playerDetails[0].typeOfGame);
}
else
{
    Console.WriteLine("Player not found!!");
}