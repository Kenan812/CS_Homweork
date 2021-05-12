using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Hw_4
{
    class Team : IComparable
    {

        #region Properties

        public string TeamName { get; set; }
        public int GamesPlayed { get; set; }
        public int Wins { get; set; }
        public int Draws { get; set; }
        public int Loses { get; set; }
        public int GoalsFor { get; set; }
        public int GoalsAgainst { get; set; }
        public int GoalDifference { get; set; }
        public int Points { get; set; }

        #endregion


        #region Constructers

        public Team(string teamName, int gamesPlayed, int wins, int draws, int loses, int goalsFor, int goalsAgainst)
        {
            TeamName = teamName;
            GamesPlayed = gamesPlayed;
            Wins = wins;
            Draws = draws;
            Loses = loses;
            GoalsFor = goalsFor;
            GoalsAgainst = goalsAgainst;

            if (goalsFor > goalsAgainst)
                GoalDifference = goalsFor - goalsAgainst;
            else
                GoalDifference = goalsAgainst - goalsFor;

            Points = 0;
        }

        public Team()
        {
            TeamName = "";
            GamesPlayed = 0;
            Wins = 0;
            Draws = 0;
            Loses = 0;
            GoalsFor = 0;
            GoalsAgainst = 0;
            GoalDifference = 0;
            Points = 0;
        }


        #endregion


        #region Help Methods


        public void CalculatePoints()
        {
            Points = Wins * 3 + Draws;
        }


        #endregion



        #region Prints


        public void PrintTeam()
        {
            Console.WriteLine($"Team name: {TeamName}\n" +
                $"Games Played: {GamesPlayed}\n" +
                $"Wins: {Wins}\nDraws: {Draws}\n" +
                $"Loses: {Loses}\n" +
                $"Goals For: {GoalsFor}\n" +
                $"Goals Against: {GoalsAgainst}\n" +
                $"Goal Difference: {GoalDifference}\n" +
                $"Points: {Points}");
        }


        public override string ToString()
        {
            return $"{TeamName}\t\t{GamesPlayed}\t{Wins}\t{Draws}\t{Loses}\t{GoalsFor}\t{GoalsAgainst}\t{GoalDifference}\t{Points}";
        }



        #endregion



        public int CompareTo(object obj)
        {
            if (obj is Team) 
                return Points.CompareTo((obj as Team).Points);

            throw new NotImplementedException();
        }



    }

    class PointsCompare : IComparer
    {
        public int Compare(object x, object y)
        {
            if ((x as Team).Points > (y as Team).Points)
                return -1;

            if ((x as Team).Points < (y as Team).Points)
                return 1;


            // When # of points are equal
            if ((x as Team).GoalsFor > (y as Team).GoalsFor)
                return -1;

            if((x as Team).GoalsFor < (y as Team).GoalsFor)
                return 1;

            return 0;
        }
    }



}
