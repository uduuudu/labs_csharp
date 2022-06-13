using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp3
{
    public class Tanker : CargoShip
    {
        public Tanker() : base()
        {
            typeOfCargo = "";
            yearStartOperation = 0;
        }
        public string typeOfCargo { get; set; }
        public int yearStartOperation { get; set; } // год введения в эксплуатацию


        public string throwAnchor() => "Якорь опущен";
        public string upSails() => "Паруса подняты";

        public override string ToString()
        {
            return "Название: " + name.ToString() + " Грузоподъемность: " + loadСapacity.ToString() + " Водоизмещение: " + displacement
                + " Количество плаваний: " + countSails.ToString() + " Тип груза: " + typeOfCargo.ToString() + " Год введения в эксплуатацию: " +
                yearStartOperation.ToString();
        }

        public override string showInfo()
        {
            return "Информация о корабле: " + this.ToString();
        }

    }
}
