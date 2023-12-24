﻿using Shop_Кылосов.Models;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Кылосов.Classes
{
    public class SportContext : Sport, Interfaces.IContext
    {
        public SportContext() { }

        public SportContext(string Name, int Price, string Size, int IdShop, string Photo) : base(Name, Price, Size, IdShop, Photo) { }

        public List<object> All()
        {
            List<object> allShop = new ShopContext().All();
            List<object> allSport = new List<object>();
            OleDbConnection connection = Common.DBConnection.Connection();
            OleDbDataReader sportData = Common.DBConnection.Query("SELECT * FROM [Спорт]", connection);
            while (sportData.Read())
            {
                ShopContext shopElement = allShop.Find(x => (x as ShopContext).Id == sportData.GetInt32(2)) as ShopContext;
                SportContext newSport = new SportContext(                   
                    shopElement.Name,                    
                    shopElement.Price,
                    sportData.GetString(1),
                    shopElement.Id,
                    shopElement.Photo);
                allSport.Add(newSport);
            }
            Common.DBConnection.CloseConnection(connection);
            return allSport;
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

