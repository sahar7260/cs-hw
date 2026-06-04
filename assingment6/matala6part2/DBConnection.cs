using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace matala6part2
{
    internal class DBConnection
    {

        string strCon = @"Data Source=asusiki\SQLEXPRESS;Initial Catalog=TBItem;Integrated Security=True;Trust Server Certificate=True";
        string strCmd;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adtr;
        DataSet ds;
        DataTable dt;

        public DBConnection()
        {
            con = new SqlConnection(strCon);
            ds = new DataSet();
            dt = new DataTable();
        }

        public DataTable ItemsTable()
        {
            strCmd = "SELECT * FROM TBItem";
            cmd = new SqlCommand(strCmd, con);

            adtr = new SqlDataAdapter(cmd);

            dt = new DataTable();

            adtr.Fill(dt);

            return dt;
        }

        public DataTable FilterByAbovePrice(int price)
        {
            strCmd = "P_Item_By_Above_Price";
            cmd = new SqlCommand(strCmd, con);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@price", price);

            adtr = new SqlDataAdapter(cmd);

            DataTable filteredDt = new DataTable();
            adtr.Fill(filteredDt);

            return filteredDt;
        }

        public DataTable InsertItem(Item item)
        {
            try
            {
                DataRow newRow = dt.NewRow();
                newRow["Name"] = item.Name;
                newRow["Description"] = item.Description;
                newRow["Price"] = item.Price;

                dt.Rows.Add(newRow);
                return dt;
            }
            catch
            {
                return null; 
            }
        }

        public DataTable DeleteItem(int code)
        {
            try
            {
                foreach (DataRow row in dt.Rows)
                {
                    if (row.RowState != DataRowState.Deleted && Convert.ToInt32(row["Code"]) == code)
                    {
                        row.Delete(); 
                        return dt;
                    }
                }
                return null; 
            }
            catch
            {
                return null;
            }
        }

        public void UpdateDB(DataTable table)
        {
            SqlCommandBuilder builder = new SqlCommandBuilder(adtr);

            adtr.Update(table);
        }
    }
}
