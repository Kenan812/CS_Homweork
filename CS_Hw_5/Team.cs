using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Hw_5
{
    class Team
    {
        public Worker Worker { get; set; }
        public TeamLeader TeamLeader { get; set; }

        public Team()
        {
            Worker = new Worker();
            TeamLeader = new TeamLeader();
        }

    }
}
