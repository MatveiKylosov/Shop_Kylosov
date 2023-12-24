using Shop_Кылосов.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.OleDb;
using System.Text;
using System.Threading.Tasks;

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
                    shopData.GetInt32(2));

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
