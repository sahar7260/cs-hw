using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace matala6part2
{
    internal class Store
    {
        DBConnection db;

        public Store()
        {
            db = new DBConnection();
        }

        public DataTable ItemsTable() // מביא את הטבלה ההתחלתית
        {
            return db.ItemsTable();
        }

        public DataTable FilterByAbovePrice(int price) // סינון לפי מחיר
        {
            return db.FilterByAbovePrice(price);
        }

        public DataTable InsertItem(Item item) // הוספה
        {
            return db.InsertItem(item);
        }

        public DataTable DeleteItem(int code) // מחיקה
        {
            return db.DeleteItem(code);
        }

        public void Update(DataTable table) // שמירה ל-SQL
        {
            db.UpdateDB(table);
        }
    }
}
