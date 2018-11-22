using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {

        string choise_select = null;
        string id_for_delete = null;
        string value_for_up = null;
        string name_of_atr = null;
        string v1 = null, v2;
        
        //string mass_order, mass_deli

        int row_for_up, count_for_up;

        public Form4()
        {
            InitializeComponent();

            var dt = ConnectToDatabase.GetTable("Show Tables");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbNameTb.Items.Add(dt.Rows[i].ItemArray[0]);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (choise_select == "book_on_stoke")
            {
                v1 = (dataGridView1[3, e.RowIndex].Value.ToString());
                v2 = (dataGridView1[2, e.RowIndex].Value.ToString());
            }
            name_of_atr = dataGridView1.Columns[e.ColumnIndex].Name;
            label1.Text = name_of_atr;
            id_for_delete = (dataGridView1[0, e.RowIndex].Value.ToString());
            row_for_up = e.RowIndex;
            count_for_up = e.ColumnIndex;
            value_for_up = (dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString());
        }

        private void cbNameTb_SelectedIndexChanged(object sender, EventArgs e)
        {
            choise_select = (sender as ComboBox).Text;
            label1.Text = choise_select;
            selected_cb(choise_select);            
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (choise_select == "book_on_stoke")
                ConnectToDatabase.InsertData($"delete from {choise_select} where adr_stoke = '{v1}'", 0);
            else
                ConnectToDatabase.InsertData($"delete from {choise_select} where id = {id_for_delete}", 0);
            selected_cb(choise_select);
        }

        void selected_cb (string text)
        {
           switch (text)
            {
                case "author":
                    choise_select = "author";
                    dataGridView1.DataSource = ConnectToDatabase.GetTable("select * from  author");
                    break;
                case "book":
                    choise_select = "book";
                    dataGridView1.DataSource = ConnectToDatabase.GetTable("select book.id, book.name_of, author.name_of as author ,genre.name_of as genre, cover.name_of as cover, publising_house.name_of as publising_house,language_of.name_of as language_of, book.cost, book.date_of_release from book inner join cover inner join publising_house inner join language_of inner join genre inner join author on book.author = author.id and book.cover = cover.id and book.genre = genre.id and book.language_of = language_of.id and book.publising_house = publising_house.id");
                    break;
                case "book_on_stoke":
                    choise_select = "book_on_stoke";
                    dataGridView1.DataSource = ConnectToDatabase.GetTable("select seller.last_name as order_id, book.name_of as delivery_id, book_on_stoke.count_of, book_on_stoke.adr_stoke  from orders inner join seller inner join book_on_stoke inner join delivery inner join book inner join author on orders.seller = seller.id and book_on_stoke.delivery_id = delivery.id and book_on_stoke.order_id = orders.id and delivery.book_id = book.id and book.author = author.id");
                    break;
                case "country":
                    choise_select = "country";
                    dataGridView1.DataSource = ConnectToDatabase.GetTable("select * from country");
                    break;
                case "cover":
                    choise_select = "cover";
                    dataGridView1.DataSource = ConnectToDatabase.GetTable("select * from cover");
                    break;
                case "delivery":
                    choise_select = "delivery";
                    dataGridView1.DataSource = ConnectToDatabase.GetTable("select delivery.id, book.name_of as book_id, provider.last_name as provider_id, delivery.count_of,delivery.date_of, delivery.summ from delivery inner join provider inner join book on delivery.book_id = book.id and delivery.provider_id = provider.id");
                    break;
                case "genre":
                    choise_select = "genre";
                    dataGridView1.DataSource = ConnectToDatabase.GetTable("select * from genre");
                    break;
                case "language_of":
                    choise_select = "language_of";
                    dataGridView1.DataSource = ConnectToDatabase.GetTable("select * from language_of");
                    break;
                case "orders":
                    choise_select = "orders";
                    dataGridView1.DataSource = ConnectToDatabase.GetTable("select orders.id, orders.cost,orders.count_of,orders.date_of,orders.summ, seller.last_name as seller from orders inner join seller on orders.seller = seller.id");
                    break;
                case "position_of":
                    choise_select = "position_of";
                    dataGridView1.DataSource = ConnectToDatabase.GetTable("select * from position_of");
                    break;
                case "provider":
                    choise_select = "provider";
                    dataGridView1.DataSource = ConnectToDatabase.GetTable("select * from provider");
                    break;
                case "publising_house":
                    choise_select = "publising_house";
                    dataGridView1.DataSource = ConnectToDatabase.GetTable("select publising_house.id, publising_house.name_of, country.name_of as country_id from publising_house inner join country on publising_house.country_id = country.id");
                    break;
                case "seller":
                    choise_select = "seller";
                    dataGridView1.DataSource = ConnectToDatabase.GetTable("select seller.id, seller.last_name, seller.first_name, position_of.name_of as position_of_id from seller inner join position_of on seller.position_of_id = position_of.id");
                    break;

                default:
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //    var dat = ConnectToDatabase.GetTable($"select * from {choise_select} where id = {id_for_delete}");
            /*карочи. тут сделать проверку выборки. если была выбрана определенная ячейка с 
             * внешним ключем, то отправляем значение ячейки, айди этого значения*/

            if (name_of_atr == "id")
            {
                MessageBox.Show("НЕЛЬЗЯ МЕНЯТЬ ID!");
            }
            else
            new Form5(value_for_up, choise_select,name_of_atr, v1,v2).Show();

        }
    }
}