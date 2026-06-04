using System;
using System.Collections.Generic;
using System.Text;

namespace matala6
{
    internal class Store
    {
        Item[] items;
        int count;
        DBConnection db;

        public Store()
        {
            items = new Item[0]; 
            count = 0;           
            db = new DBConnection(); 
        }
        public void AddItem(Item item)
        {
            int result = db.AddItemToDB(item);
            if (result > 0)
            {
                Console.WriteLine($"{result} new item added!");
            }
        }

        public void DeleteItem(int code)
        {
            int result = db.DeleteItemFromDB(code);
            if (result > 0)
            {
                Console.WriteLine($"{result} item deleted!");
            }
        }

        public override string ToString()
        {
            return db.ReadItemsTable();
        }
    }
}

