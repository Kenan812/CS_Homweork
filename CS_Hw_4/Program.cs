using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Hw_4
{
    class Program
    {
        static void AddGroup(ref Group[] groups)
        {
            Console.Clear();
            try
            {
                Group[] newGroups = new Group[groups.Length + 1];
                Group group = new Group();


                for (int i = 0; i < groups.Length + 1; i++)
                {
                    newGroups[i] = new Group();
                }

                Array.Copy(groups, newGroups, groups.Length);


                // Adding teams
                for (int i = 0; i < 4; i++)
                {
                    Console.WriteLine($"Team # {i + 1}");

                    Console.Write("Enter name: ");
                    string name = Console.ReadLine();

                    Console.Write("Enter # of played games: ");
                    int gamesPlayed = Int32.Parse(Console.ReadLine());

                    Console.Write("Enter # of wins: ");
                    int wins = Int32.Parse(Console.ReadLine());

                    Console.Write("Enter # of draws: ");
                    int draws = Int32.Parse(Console.ReadLine());

                    Console.Write("Enter # of loses: ");
                    int loses = Int32.Parse(Console.ReadLine());

                    Console.Write("Enter # of goals for: ");
                    int goalsFor = Int32.Parse(Console.ReadLine());

                    Console.Write("Enter # of goals against: ");
                    int goalsAgainst = Int32.Parse(Console.ReadLine());

                    group.AddTeam(new Team( name, gamesPlayed, wins, draws, loses, goalsFor, goalsAgainst));
                    Console.WriteLine();
                }


                newGroups[newGroups.Length - 1] = group;

                groups = newGroups;

            }

            catch (FormatException e)
            {
                Console.WriteLine("Not correct format provided!!!");
                Console.WriteLine("\n" + e.Message);
                throw;
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }


        }

        static void SortAllGroups(ref Group[] groups)
        {
            for (int i = 0; i < groups.Length; i++)
            {
                groups[i].SortGroup();
            }
        }

        static void PrintAllGroups(Group[] groups)
        {
            for (int i = 0; i < groups.Length; i++)
            {
                Console.WriteLine($"Group # {i + 1}");
                groups[i].PrintGroup();
                Console.WriteLine();
            }

            Console.WriteLine();
        }




        static void Main(string[] args)
        {
            #region Task 1

            try
            {
                Group[] groups = new Group[4];
                
                for (int i = 0; i < groups.Length; i++)
                {
                    groups[i] = new Group();
                }


                groups[0].AddTeam(new Team("team 1", 5, 3, 7, 8, 5, 14));
                groups[0].AddTeam(new Team("team 2", 3, 2, 2, 1, 3, 5));
                groups[0].AddTeam(new Team("team 3", 9, 5, 6, 91, 8, 3));
                groups[0].AddTeam(new Team("team 4", 23, 3, 7, 45, 75, 87));
                
                
                groups[1].AddTeam(new Team("team 1", 8, 4, 4, 8, 4, 6));
                groups[1].AddTeam(new Team("team 2", 3, 8, 1, 1, 5, 2));
                groups[1].AddTeam(new Team("team 3", 2, 6, 4, 1, 2, 3));
                groups[1].AddTeam(new Team("team 4", 3, 3, 7, 4, 7, 8));
                
                groups[2].AddTeam(new Team("team 1", 5, 3, 7, 8, 5, 4));
                groups[2].AddTeam(new Team("team 2", 3, 3, 6, 4, 3, 3));
                groups[2].AddTeam(new Team("team 3", 1, 2, 6, 1, 2, 3));
                groups[2].AddTeam(new Team("team 4", 2, 3, 7, 5, 5, 7));
                
                groups[3].AddTeam(new Team("team 1", 3, 6, 2, 2, 6, 3));
                groups[3].AddTeam(new Team("team 2", 4, 5, 6, 3, 3, 5));
                groups[3].AddTeam(new Team("team 3", 5, 2, 4, 9, 4, 3));
                groups[3].AddTeam(new Team("team 4", 3, 2, 2, 4, 7, 7));

                for (int i = 0; i < 4; i++)
                {
                    groups[i].SortGroup();
                }


                while(true)
                {
                    Console.WriteLine("Enter choice:\n(1) Add New Group\n(2) See All Groups\n(3) Exit");
                    int c = Int32.Parse(Console.ReadLine());


                    switch (c)
                    {
                        case 1:
                            AddGroup(ref groups);
                            SortAllGroups(ref groups);
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                            Console.Clear();
                            break;

                        case 2:
                            Console.Clear();
                            PrintAllGroups(groups);
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                            Console.Clear();
                            break;

                        case 3:
                            System.Environment.Exit(0);
                            break;

                        default:
                            break;
                    }


                }
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("Null Reference Exception\n" + e.Message);
                Console.WriteLine("Source: " + e.Source);
                throw;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            

            #endregion



            #region Task 2


            /*
            while (true)
            {
                int f;
                int c;
                Figure figure = null;

                try
                {
                    Console.WriteLine("Choose figure:\n(1) Rectangle\n(2) Triangle\n(3) Rhombus\n(4) Trapezoid\n(0) Exit");
                    f = Int32.Parse(Console.ReadLine());
                    Console.Clear();

                    if (f == 0) break;
                    else if (f == 1) figure = new Rectangle();
                    else if (f == 2) figure = new Triangle();
                    else if (f == 3) figure = new Rhombus();
                    else if (f == 4) figure = new Trapezoid();
                    else Console.WriteLine("No such figure\n");

                    Console.WriteLine("Choose color:\n(1) Red\n(2) Blue\n(3) Green\n(4) White\n(5) Yellow\n(6) Cyan\n(7) Gray");
                    c = Int32.Parse(Console.ReadLine());
                    Console.Clear();

                    switch (c)
                    {
                        case 1:
                            Console.ForegroundColor = ConsoleColor.Red;
                            break;


                        case 2:
                            Console.ForegroundColor = ConsoleColor.Blue;
                            break;


                        case 3:
                            Console.ForegroundColor = ConsoleColor.Green;
                            break;


                        case 4:
                            Console.ForegroundColor = ConsoleColor.White;
                            break;


                        case 5:
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            break;


                        case 6:
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            break;


                        case 7:
                            Console.ForegroundColor = ConsoleColor.Gray;
                            break;


                        default:
                            Console.WriteLine("No such color");
                            break;
                    }

                    figure.Print();


                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    throw;
                }
            }
            */


            #endregion



        }
    }
}
