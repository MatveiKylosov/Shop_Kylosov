using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Кылосов.Classes
{
    public class RepoItems
    {
        public static List<object> AllItems()
        {
            List<object> allItems = new List<object>();
            allItems.Add(new Children("Игрушка интерактивная", 2200, 3));
            allItems.Add(new Children("Какус танцующий", 894, 6));
            allItems.Add(new Children("Мягкая игрушка кошка подушка", 1754, 6));
            allItems.Add(new Sport("Спортиный мужской костюм", 4913, "S"));
            allItems.Add(new Sport("Мяч для водного поло", 812, "61-63 см"));
            allItems.Add(new Sport("Набор для гольфа Partida", 3950, "600*800 мм"));
            allItems.Add(new Electronics("Скибиди ускоритель", 9999, 55.1));
            allItems.Add(new Electronics("Тесла самокат", 19999, "1 км/ч"));
            allItems.Add(new Electronics("Ноутбук IRBIS NB144 серый", 12299, 5.1));
            return allItems;
        }
    }
}
