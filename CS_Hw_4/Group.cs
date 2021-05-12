using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Hw_4
{
    class Group : IEnumerable
    {
        #region Fields and Properties

        private Team[] teams;
        public int NumberOfTeams{ get; set; }

        #endregion



        #region Constructer

        public Group()
        {
            teams = new Team[4];
            NumberOfTeams = 0;
        }

        #endregion



        #region Manage Group


        public void AddTeam(Team team)
        {
            if (NumberOfTeams < 4)
            {
                try
                {
                    Team newTeam = new Team(team.TeamName, team.GamesPlayed, team.Wins, team.Draws, team.Loses, team.GoalsFor, team.GoalsAgainst);
                    newTeam.CalculatePoints();

                    teams[NumberOfTeams] = newTeam;

                    NumberOfTeams++;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    throw;
                }
            }

            else Console.WriteLine("Maximum number of teams reached");

        }


        public void SortGroup()
        {
            if (NumberOfTeams == 4) 
                Array.Sort(teams, new PointsCompare());


            else Console.WriteLine("Not enough teams");
        }


        #endregion



        #region Print Group


        public void PrintGroup()
        {
            Console.WriteLine("Pos\tTeam name\tGP\tW\tD\tL\tGF\tGA\tGD\tPts");

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"{i + 1}\t{teams[i]}");
            }
        }


        #endregion


        public IEnumerator GetEnumerator()
        {
            return teams.GetEnumerator();
        }
    }
}
