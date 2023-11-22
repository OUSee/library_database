using Lib_database.LIB_DBDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lib_database
{
    public class DB
    {
        static string connection_string = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=LIB_DB;Integrated Security=True";
        public static SqlConnection con = new SqlConnection(connection_string);

        
        public static void InsertInto(string tablename, string name, string author, string publisher, string genre, int year, int quantity)
        { 
            SqlConnection con = new SqlConnection(connection_string);
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"INSERT NewTable (Name, Author, Publisher, Genre, Year, Quantity) VALUES ('{name}', '{author}', '{publisher}', '{genre}', {year}, {quantity})";
            cmd.Connection = con;

            Variables.MessageText = $"You shure u want to create instanse with info:\n Name: {name}, Author:{author}...etc. ?";
            Form form = new Y_N_Form();
            form.ShowDialog();
            if (Variables.ShureForm)
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public static void UpdateEntry(string tablename, string name, string author, string publisher, string genre, int year, int quantity,int ID)
        {
            SqlConnection con = new SqlConnection(connection_string);
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"UPDATE NewTable SET Name = '{name}', Author = '{author}', Publisher = '{publisher}', Genre = '{genre}', Year = {year}, Quantity = {quantity} WHERE ID = {ID}";
            cmd.Connection = con;

            Variables.MessageText = $"You shure u want to update instanse with info:\n ID:{ID}, Name: {name}...etc. ?";
            Form form = new Y_N_Form();
            form.ShowDialog();
            if (Variables.ShureForm)
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public static void DeleteEntry()
        {
            SqlConnection con = new SqlConnection(connection_string);
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"DELETE FROM NewTable WHERE ID = {Variables.B_ID}";
            cmd.Connection = con;
            Variables.MessageText = $"You shure u want to delete instanse with ID:{Variables.B_ID}?";
            Form form = new Y_N_Form();
            form.ShowDialog();
            if (Variables.ShureForm)
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public static DataTable SelectFrom() 
        {
            
            SqlConnection sqlConn = new SqlConnection(connection_string);
            sqlConn.Open();
            //выполняем запрос
            SqlCommand sqlCom = new SqlCommand($"SELECT * FROM NewTable WHERE Name LIKE '{Variables.SearchString}' OR Author LIKE '{Variables.SearchString}' OR Publisher LIKE '{Variables.SearchString}' OR Genre LIKE '{Variables.SearchString}' OR Year = '{MainForm.TryInt(Variables.SearchString)}' OR Quantity = {MainForm.TryInt(Variables.SearchString)}", sqlConn);
            SqlDataReader dr = sqlCom.ExecuteReader();
            //результат запроса суем в таблицу
            DataTable dt = new DataTable();
            dt.Load(dr);
            //заполняем datagridview - (поле данных...где выводится результат поиска)
            return dt;
        }


    }
    public class Variables
    {
        public static string MessageText { get; set; }
        public static bool ShureForm { get; set; }
        public static string B_Name { get; set; }
        public static string B_Author { get; set; }
        public static string B_Publisher { get; set; }
        public static string B_Genre { get; set; }
        public static int B_Year { get; set; }
        public static int B_Quantity { get; set; }
        public static int B_ID { get; set; }
        public static string SearchString { get; set; }
        public static bool IsFound { get; set;}
        
    }
}
