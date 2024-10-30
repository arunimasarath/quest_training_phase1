using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCricketGame
{
    enum DeliveryType
    {
        NoBall,
        Runs,
        Wicket
    }
    
        class Player
        {
            public string Name { get; set; }
            public int Runs { get; set; }
            public int Wickets { get;  set; }

            public Player(string name)
            {
                Name = name;
                Runs = 0;
                Wickets = 0;
            }

            public void ScoreRuns(int runs)
            {
                Runs += runs;
            }

            public void TakeWicket()
            {
                Wickets++;
            }

            public void DisplayScore()
            {
                Console.WriteLine($"{Name}'s Score - Runs: {Runs}, Wickets: {Wickets}");
            }
        }
        class Game
        {
            private Player player;
            private Random random;

            public Game(string playerName)
            {
                player = new Player(playerName);
                random = new Random();
            }

            public void Start()
            {
                Console.WriteLine($"Welcome to the Cricket Game, {player.Name}!");

                for (int over = 1; over <= 6; over++) 
                {
                    Console.WriteLine($"Over {over}:");
                    SimulateOver();
                }

                player.DisplayScore();
            }

            private void SimulateOver()
            {
                for (int ball = 1; ball <= 6; ball++) 
                {
                    DeliveryType delivery = (DeliveryType)random.Next(0, 3); 

                    switch (delivery)
                    {
                        case DeliveryType.NoBall:
                            Console.WriteLine("No Ball! Extra run awarded.");
                            player.ScoreRuns(1); 
                            break;

                        case DeliveryType.Runs:
                            int runs = random.Next(0, 7); 
                            player.ScoreRuns(runs);
                            Console.WriteLine($"Player scored {runs} runs.");
                            break;

                        case DeliveryType.Wicket:
                            Console.WriteLine("Wicket! The player is out.");
                            player.TakeWicket();
                            break;
                    }
                }
            }
        }
    }

