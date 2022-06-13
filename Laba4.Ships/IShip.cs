using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
    public interface IShip
    {
        string name { get; set; }

        int loadСapacity { get; set; }

        string transportCargo(int cargo);

        bool checkCondition();
        string showInfo();
    }
}
