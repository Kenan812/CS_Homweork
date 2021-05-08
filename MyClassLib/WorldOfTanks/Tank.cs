using System;

namespace MyClassLib.WorldOfTanks
{
    public class Tank
    {
        #region Properties


        public string TankName { get; set; }

        public int AmmunitionLevel { get; set; }

        public int ArmorLevel { get; set; }

        public int ManeuverabilityLevel { get; set; }


        #endregion


        #region Constructer

        public Tank(string tankName)
        {
            Random random = new Random();
            TankName = tankName;
            System.Threading.Thread.Sleep(50);
            try
            {
                AmmunitionLevel = random.Next(101);
                ArmorLevel = random.Next(101);
                ManeuverabilityLevel = random.Next(101);
            }
            catch (Exception)
            {
                Console.WriteLine("An exception occured");
                throw;
            }
            
        }


        #endregion


        #region Operator Overloading


        // 
        // Takes 2 tanks as parameters
        // Returns name of the victorious tank or "Draw"
        public static string operator *(Tank t1, Tank t2)
        {
            int t1Score = 0;
            int t2Score = 0;

            try
            {
                if (t1.AmmunitionLevel > t2.AmmunitionLevel)
                    t1Score++;
                else if (t1.AmmunitionLevel < t2.AmmunitionLevel)
                    t2Score++;

                if (t1.ArmorLevel > t2.ArmorLevel)
                    t1Score++;
                else if (t1.ArmorLevel < t2.ArmorLevel)
                    t2Score++;

                if (t1.ManeuverabilityLevel > t2.ManeuverabilityLevel)
                    t1Score++;
                else if (t1.ManeuverabilityLevel < t2.ManeuverabilityLevel)
                    t2Score++;

            }
            catch (Exception)
            {
                Console.WriteLine("An error occured while battle");
                throw;
            }


            if (t1Score > t2Score) return t1.TankName;
            else if (t1Score < t2Score) return t2.TankName;

            return "Draw";
        }


        #endregion



        public override string ToString()
        {
            return $"Name: {TankName}\nAmmunition level: {AmmunitionLevel}\nArmor Level: {ArmorLevel}\nManeuverability Level: {ManeuverabilityLevel}\n";
        }
    }
}
