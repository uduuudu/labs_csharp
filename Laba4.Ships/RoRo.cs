using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
    public class RoRo : CargoShip // корабль для транспортировки машин
    {
        public int costTheMostExpensiveCar {get;set;} // стоиость самой дорогой машины на судне

        public int countTranferPassangers  {get;set;}// некоторые корабли данного типа могут перевозить и пассажиров, 
        //а некоторые возят только машинки 

    public RoRo() : base()
        {
            costTheMostExpensiveCar = 0;
            countTranferPassangers = 0;
        }
        public override string ToString()
        {
            return " Название " + name.ToString() + " Грузоподъемность " + loadСapacity.ToString() + " Водоизмещение " + displacement
                + " Количество плаваний " + countSails.ToString() + " Стоимость самой дорогой машины на судне : " + costTheMostExpensiveCar.ToString()
                + " Наличие возможности перевозки пассажиров " +
                countTranferPassangers.ToString();
        }

        public override string showInfo()
        {
            return "Информация о корабле: " + this.ToString();
        }

        public string loadMachine()
        {
            Random random = new Random();
            int price = random.Next(1, 100000);
            if (price > costTheMostExpensiveCar)
                costTheMostExpensiveCar = price;
            return "Погрузка завершена!";
        }

        public string qualityCargo()
        {
            if (costTheMostExpensiveCar > 50000)
                return "Перевозится дорогой груз!";
            else
                return "Перевозится не очень дорогой груз!";
        }


        public string checkPass() => countTranferPassangers > 0 ? "корабль может принимать пассажиров" : "корабль не может принимать пассажиров";
                                    

    }
}
