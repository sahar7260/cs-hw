using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace matala6
{
    internal class DBConnection
    {
        string strCon = @"Data Source=asusiki\SQLEXPRESS;Initial Catalog=TBItem;Integrated Security=True;Trust Server Certificate=True";
        string strCmd;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader rdr;

        public DBConnection()
        {
            con = new SqlConnection(strCon);
        }

        public string ReadItemsTable()
        {
            strCmd = "SELECT * FROM TBItem";
            cmd = new SqlCommand(strCmd, con);
            string result = "";
            try
            {
                con.Open();
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    result += $"Code: {rdr["Code"]} Name: {rdr["Name"]}, Description: {rdr["Description"]}, Price: {rdr["Price"]}\n";
                }

                rdr.Close();
            }

            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

            if (result == "")
            {
                return "No Items\n";
            }

            return result;

        }
        public int AddItemToDB( Item item)
        {
            int rows = 0;
            strCmd = $"INSERT INTO TBItem (Name, Description, Price) VALUES ('{item.Name}', '{item.Description}', {item.Price})";
            cmd = new SqlCommand(strCmd, con);

            try
            {
                con.Open();
                rows = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

            return rows;
        }

        public int DeleteItemFromDB(int code)
        {
            // משתנה שישמור כמה שורות הושפעו (נמחקו)
            int rowsAffected = 0;


            strCmd = $"DELETE FROM TBItem WHERE Code = {code}";

            cmd = new SqlCommand(strCmd, con);

            try
            {
                con.Open();

                rowsAffected = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

            return rowsAffected;
        }

    }
}
