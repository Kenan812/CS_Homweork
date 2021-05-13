using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Hw_5.Interfaces
{
    interface IWorker
    {
        //
        // returns true is construction is finished, false otherwise
        bool Work(ref House house);


    }
}
