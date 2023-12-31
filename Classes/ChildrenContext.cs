﻿using Shop_Кылосов.Models;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Shop_Кылосов.Classes
{
    public class ChildrenContext : Children, Interfaces.IContext
    {
        public ChildrenContext() { }

        public ChildrenContext(int Id, string Name, int Price, int Age, int IdShop, string Photo) : base(Name, Price, Age, IdShop, Photo) { }

        public List<object> All()
        {
            List<object> allChildren = new List<object>();
            List<object> allShop = new ShopContext().All();

            OleDbConnection connection = Common.DBConnection.Connection();
            OleDbDataReader childrenData = Common.DBConnection.Query("SELECT * FROM [Детские товары]", connection);

            while (childrenData.Read())
            {
                ShopContext shopElement = allShop.Find(
                    x => (x as ShopContext).Id == childrenData.GetInt32(2)) as ShopContext;

                ChildrenContext newChildren = new ChildrenContext(
                    shopElement.Id,
                    shopElement.Name,
                    shopElement.Price,
                    childrenData.GetInt32(1),
                    childrenData.GetInt32(2),
                    shopElement.Photo
                    );
                allChildren.Add(newChildren);
            }
            Common.DBConnection.CloseConnection(connection);

            return allChildren;
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
