using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlayerLibrary;

namespace Phase_2___Main_Project
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
                first:
                Console.WriteLine(" Menu \nEnter 1:To Add Player " +
               "2:To Remove Player by Id " +
               "3.Get Player By Id " +
               "4.Get Player by Name" +
               " 5.Get All Players:\"");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                    OneDayTeam team = new OneDayTeam();

                    if (OneDayTeam.onedayteam.Count <= OneDayTeam.onedayteam.Capacity) 
                    {
                        Console.Write("Enter Player Id :");
                        team.PlayerID = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Player Name :");
                        team.PlayerName = Console.ReadLine();
                        Console.Write("Enter Player Age :");
                        team.PlayerAge = Convert.ToInt32(Console.ReadLine());
                        team.Add(team);
                        Console.WriteLine("Player Added Successfully");

                    }
                       
                    else
                    {
                        Console.WriteLine("Cannot add more than 11 Players to the Team");
                    }
                    break;

                case 2:
                        OneDayTeam t1 = new OneDayTeam();
                        Console.WriteLine("Enter Player Id to Remove");
                        int r = Convert.ToInt32(Console.ReadLine());
                        t1.Remove(r);
                        break;
                    case 3:
                        OneDayTeam t2 = new OneDayTeam();
                        Console.WriteLine("Enter PlayerID to Find");
                        int Pid = Convert.ToInt32(Console.ReadLine());
                        Player p = t2.GetPlayerById(Pid);
                        Console.WriteLine("Player Id :" +p.PlayerID);
                        Console.WriteLine("Player Name :" +p.PlayerName);
                        Console.WriteLine("Player Age :" +p.PlayerAge);
                    break;
                    case 4:
                        OneDayTeam t3 = new OneDayTeam();
                        Console.WriteLine("Enter Player Name to Find");
                        string Pname = Console.ReadLine();
                        Player p1 =t3.GetPlayerByName(Pname);
                        Console.WriteLine("Player Id :" + p1.PlayerID);
                        Console.WriteLine("Player Name :" + p1.PlayerName);
                        Console.WriteLine("Player Age :" + p1.PlayerAge);
                    break;
                    case 5:
                        Console.WriteLine("Players List");
                        List<Player> list = new List<Player>();
                        OneDayTeam t4 = new OneDayTeam();
                        list = t4.GetAllPlayers();
                        foreach (var item in list)
                        {
                         Console.WriteLine("Player Id :" + item.PlayerID);
                         Console.WriteLine("Player Name :" + item.PlayerName);
                         Console.WriteLine("Player Age :" + item.PlayerAge);

                        }
                        break;
                    default:
                        Environment.Exit(1);
                        break;
                }
                Console.WriteLine("Do you want to Continue(y/n)?");
                string s = Console.ReadLine();
                if (s=="y")
                {
                goto first;
                }
                else if(s=="n")
                {
                Environment.Exit(1);
                }
            Console.ReadLine();

        }
    }
}
========================================================================


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerLibrary
{
    public class Player
    {
        public int PlayerID { get; set; }

        public string PlayerName { get; set; }

        public int PlayerAge { get; set; }


    }

    interface ITeam
    {
        void Add(Player player);
        void Remove(int playerId);
        Player GetPlayerById(int playerId);
        Player GetPlayerByName(string playerName);
        List<Player> GetAllPlayers();
    }

    public class OneDayTeam : Player, ITeam
    {
        public static List<Player> onedayteam = new List<Player>();

        
        
        public OneDayTeam()
        {
            onedayteam.Capacity = 11;
        }
        public void Add(Player player)
        {
            onedayteam.Add(player);
        }

        public  List<Player> GetAllPlayers()
        {
            return onedayteam;
        }

        public Player GetPlayerById(int playerId)
        {
            Player player = null;

            foreach (var item in onedayteam)
            {
                if (item.PlayerID == playerId)
                {
                    player = item;
                    break;
                }
               
            }
            return player;

        }

        public Player GetPlayerByName(string playerName)
        {
            Player player = null;

            foreach (var item in onedayteam)
            {
                if (item.PlayerName == playerName)
                {
                    player = item;
                    break;
                }
                  
            }
            return player;
        }

        public void Remove(int playerId)
        {
            Player player = null;

            foreach (var item in onedayteam)
            {
                if (item.PlayerID == playerId)
                {
                    Console.WriteLine("Player{0} details is removed successfully", item.PlayerID);
                    player = item;
                }
            }
            onedayteam.Remove(player);


        }
  
    }
}
