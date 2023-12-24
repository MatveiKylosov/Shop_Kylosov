using Shop_Кылосов.Models;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Кылосов.Classes
{
    public class ElectronicsContext : Electronics, Interfaces.IContext
    {
        public ElectronicsContext() { }

        public ElectronicsContext(string Name, int Price, int Id, string DrivingSpeed) : base(Name, Price, Id, DrivingSpeed) { }

        public List<object> All()
        {
            List<object> allShop = new ShopContext().All();
            List<object> allElectronics = new List<object>();

            OleDbConnection connection = Common.DBConnection.Connection();
            OleDbDataReader electronicsData = Common.DBConnection.Query("SELECT * FROM [Электроника]", connection);

            while (electronicsData.Read())
            {
                ShopContext shopElement = allShop.Find(x => (x as ShopContext).Id == electronicsData.GetInt32(2)) as ShopContext;
                ElectronicsContext newElectronics = new ElectronicsContext(
                    shopElement.Name,
                    shopElement.Price,
                    shopElement.Id,
                    electronicsData.GetString(1));
                    allElectronics.Add(newElectronics);
            }
            Common.DBConnection.CloseConnection(connection);
            return allElectronics;
        }

        public void Save(bool Update = false)
        {
            throw new System.NotImplementedException();
        }

        public void Delete()
        {
            throw new System.NotImplementedException();
        }
    }
}
