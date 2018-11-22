using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Нужно сделать запрос на вытаскивание id (выборка через вложенный запрос (для деливери select delivery.id from delivery, book where delivery.book_id = book.id and book.name_of = '{vo}' (возможно нужно брать доп параметры из book_on_stoke, например дату)) для vo и уже допиливаем 
 */

namespace WindowsFormsApp1
{
    public partial class Form6 : Form
    {
        string id_for_up, vo, name_of, v1, v2;
        public Form6(string value_old, string name_of_atr, string v_a, string v_c)
        {
            InitializeComponent();
            vo = value_old;
            v1 = v_a;
            v2 = v_c;
            label2.Text = vo;

            name_of = name_of_atr;
            switch (name_of)
            {
                case "order_id":
                    dataGridView1.DataSource = ConnectToDatabase.GetTable("select orders.id, orders.cost,orders.count_of,orders.date_of,orders.summ, seller.last_name as seller from orders inner join seller on orders.seller = seller.id");
                    break;
                case "delivery_id":
                    dataGridView1.DataSource = ConnectToDatabase.GetTable("select delivery.id, book.name_of as book_id, provider.last_name as provider_id, delivery.count_of,delivery.date_of, delivery.summ from delivery inner join provider inner join book on delivery.book_id = book.id and delivery.provider_id = provider.id");
                  //  var dt5 = ConnectToDatabase.GetTable($"select id from book");
                    break;
                default:
                    break;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            switch (name_of)
            {
                case "order_id":
                    ConnectToDatabase.InsertData($"update book_on_stoke set  order_id = {id_for_up} where  count_of = {v2} and adr_stoke = '{v1}'", 1);
                    //ConnectToDatabase.InsertData("");
                    break;
                case "delivery_id":
                    ConnectToDatabase.InsertData($"update book_on_stoke set  delivery_id = {id_for_up} where count_of = {v2} and adr_stoke = '{v1}'",1);
                    //  var dt5 = ConnectToDatabase.GetTable($"select id from book");
                    break;
                default:
                    break;
            }
            //ConnectToDatabase.InsertData();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_for_up = (dataGridView1[0, e.RowIndex].Value.ToString());
        }
    }
}
