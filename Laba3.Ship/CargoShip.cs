using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp3
{
    public abstract class CargoShip : IShip
    {
        public string name { get; set; }
        public int loadСapacity { get; set; }
       

        public int displacement { get; set; } // водоизмещение
        public int countSails { get; set; } // кол-во плаваний

        public CargoShip()
        {
            name = "";
            displacement = 0;
            loadСapacity = 0;
            countSails = 0;
        }

        public bool checkCondition() => countSails <= 10;

        public string transportCargo(int cargo)
        {
            if (cargo > loadСapacity)
                return "Не хватает грузоподъемности для такого груза!!!";
            else
            {
                countSails++;
                return "Груз переправлен!";
            }

        }

        public string repair()
        {
            if (checkCondition())
                return "Ремонт не требуется!";
            else
            {
                countSails = 0;
                return "Ремонт завершен!";
            }    
        }

        public abstract string showInfo();

    }
}
