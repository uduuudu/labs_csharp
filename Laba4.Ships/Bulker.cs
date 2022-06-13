using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
    public class Bulker : CargoShip // судно для перевозки сыпучих грузов
    {
        public Bulker() : base()
        {
            BulkTypeCargo = "";
            NumOfCompartmenst = 0;
        }
        public string BulkTypeCargo { get; set; }
        public int NumOfCompartmenst { get; set; } // количество отсеков

        public override string ToString()
        {
            return "Название " + name.ToString() + " Грузоподъемность " + loadСapacity.ToString() + " Водоизмещение " + displacement
                + " Количество плаваний " + countSails.ToString() + " Тип груза: " + BulkTypeCargo.ToString() + " Количество отсеков" +
                NumOfCompartmenst.ToString();
        }

        public override string showInfo()
        {
            return "Информация о корабле: " + this.ToString();
        }

        public string TryDumpCargo() //попытаемся высыпать груз
        {
            Random random = new Random();
            return (random.Next(0, 100) < 50) ? "Во время высыпания груза произошла ошибка." : "Груз высыплен!";
        }

        public string closeCompartmenst()
        {
            if (NumOfCompartmenst > 1)
            {
                NumOfCompartmenst--;
                return "Отсек закрыт!";
            }
            else
            {
                return "Остался только один отсек, откройте новый!";
            }
        }



        public string makeRedevelopment()
        {
            Random random = new Random();
            NumOfCompartmenst = random.Next(1, 10);
            return "Перепланировка завершена!";
        }

    }
}
