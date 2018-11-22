using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
// этот класс нужен для подключения к бд и загрузке и получении данных из нее
namespace WindowsFormsApp1
{
    public static class ConnectToDatabase
    {
        // с помощью этого метода мы подклчаемся к ней
        public static MySqlConnectionStringBuilder connect()
        {
            return new MySqlConnectionStringBuilder
            {
                Server = "localhost",
                Database = "arm_bookhouse",
                UserID = "root",
                Password = "4122",
                Port = 3307
            };
        }
        // через этот метод мы можем и добавлять и удалять записи
        public static void InsertData(string str, int o)
        {
            MySqlConnectionStringBuilder connection = connect();

            using (MySqlConnection con = new MySqlConnection(connection.ConnectionString))
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(str, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    if (o == 1)
                        MessageBox.Show("Данные успешно добавлены!");
                    else if (o == 0)
                        MessageBox.Show("Данные успешно удалены!");
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        // с помощью этого метода мы получаем из бд таблицу с данными
        public static  DataTable GetTable(string str)
        {
            DataTable dt = new DataTable();
            MySqlConnectionStringBuilder connection = connect();

            using (MySqlConnection con = new MySqlConnection(connection.ConnectionString))
            {
                MySqlCommand cmd = new MySqlCommand(str, con);

                try
                {
                    con.Open();
                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        dt.Load(dr);
                        con.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return dt;
        }
    }
}
