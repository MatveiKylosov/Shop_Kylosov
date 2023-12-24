using Shop_Кылосов.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.OleDb;
using System.Text;
using System.Threading.Tasks;


using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace Shop_Кылосов.Classes
{
    public class ShopContext : Models.Shop, Interfaces.IContext
    {
        public ShopContext() { }

        public ShopContext(int Id,string Name, int Price) : base(Id, Name, Price) { }

        public List<object> All()
        {
            List<object> allShop = new List<object>();

            OleDbConnection connection = Common.DBConnection.Connection();
            OleDbDataReader shopData = Common.DBConnection.Query("SELECT * FROM [Товар]", connection);



            while (shopData.Read()) {
                ShopContext newShop = new ShopContext(
                    shopData.GetInt32(0),
                    shopData.GetString(1),
                    (shopData.GetString(3).Contains('%') ? (int)((float)shopData.GetInt32(2) * (float.Parse(shopData.GetString(3).Replace("%", "")) / 100.00))
                                             :
                                                            shopData.GetInt32(2) - int.Parse(shopData.GetString(3)))
                    );

                allShop.Add(newShop);
            }
            Common.DBConnection.CloseConnection(connection);

            return allShop;
        }

        public void Delete()
        {
            throw new System.NotImplementedException();
        }

        public void Save(bool Update = false)
        {
            throw new System.NotImplementedException();
        }
    }
}
