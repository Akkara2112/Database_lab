using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        string choise_select;
        string name_of_atr;
        string[] cb = new string[5];

        public Form2(DataTable dataTable)
        {
            InitializeComponent();
        }

        public Form2(DataTable dt, string choise)
        {
            InitializeComponent();
            dataGridView1.DataSource = dt;
            choise_select = choise;
            for (int i = 0; i < 5; i++)
                cb[i] = "";
            switch (choise_select)
            {
                case "author":
                    comboBox1.Visible = false;
                    comboBox2.Visible = false;
                    comboBox3.Visible = false;
                    comboBox4.Visible = false;
                    comboBox5.Visible = false;
                    button1.Visible = false;
                    break;
                case "book":
                    comboBox1.Visible = true;
                    var dt1 = ConnectToDatabase.GetTable("select name_of,id from author");
                    for (int i = 0; i < dt1.Rows.Count; i++)
                    {
                        comboBox1.Items.Add(dt1.Rows[i].ItemArray[0]);
                    }
                    comboBox2.Visible = true;
                    var dt2 = ConnectToDatabase.GetTable("select name_of,id from genre");
                    for (int i = 0; i < dt2.Rows.Count; i++)
                    {
                        comboBox2.Items.Add(dt2.Rows[i].ItemArray[0]);
                    }
                    comboBox3.Visible = true;
                    var dt3 = ConnectToDatabase.GetTable("select name_of,id from language_of");
                    for (int i = 0; i < dt3.Rows.Count; i++)
                    {
                        comboBox3.Items.Add(dt3.Rows[i].ItemArray[0]);
                    }
                    comboBox4.Visible = true;
                    var dt4 = ConnectToDatabase.GetTable("select name_of,id from publising_house");
                    for (int i = 0; i < dt4.Rows.Count; i++)
                    {
                        comboBox4.Items.Add(dt4.Rows[i].ItemArray[0]);
                    }
                    comboBox5.Visible = true;
                    var dt5 = ConnectToDatabase.GetTable("select name_of,id from cover");
                    for (int i = 0; i < dt5.Rows.Count; i++)
                    {
                        comboBox5.Items.Add(dt5.Rows[i].ItemArray[0]);
                    }
                    button1.Visible = true;
                    break;
                case "book_on_stoke":
                    comboBox1.Visible = false;
                    comboBox2.Visible = false;
                    comboBox3.Visible = false;
                    comboBox4.Visible = false;
                    comboBox5.Visible = false;
                    button1.Visible = false;
                    break;
                case "country":
                    comboBox1.Visible = false;
                    comboBox2.Visible = false;
                    comboBox3.Visible = false;
                    comboBox4.Visible = false;
                    comboBox5.Visible = false;
                    button1.Visible = false;
                    break;
                case "cover":
                    comboBox1.Visible = false;
                    comboBox2.Visible = false;
                    comboBox3.Visible = false;
                    comboBox4.Visible = false;
                    comboBox5.Visible = false;
                    button1.Visible = false;
                    break;
                case "delivery":
                    comboBox1.Visible = false;
                    comboBox2.Visible = false;
                    comboBox3.Visible = false;
                    comboBox4.Visible = false;
                    comboBox5.Visible = false;
                    button1.Visible = false;
                    break;
                case "genre":
                    comboBox1.Visible = false;
                    comboBox2.Visible = false;
                    comboBox3.Visible = false;
                    comboBox4.Visible = false;
                    comboBox5.Visible = false;
                    button1.Visible = false;
                    break;
                case "language_of":
                    comboBox1.Visible = false;
                    comboBox2.Visible = false;
                    comboBox3.Visible = false;
                    comboBox4.Visible = false;
                    comboBox5.Visible = false;
                    button1.Visible = false;
                    break;
                case "orders":
                    comboBox1.Visible = false;
                    comboBox2.Visible = false;
                    comboBox3.Visible = false;
                    comboBox4.Visible = false;
                    comboBox5.Visible = false;
                    button1.Visible = false;
                    break;
                case "position_of":
                    comboBox1.Visible = false;
                    comboBox2.Visible = false;
                    comboBox3.Visible = false;
                    comboBox4.Visible = false;
                    comboBox5.Visible = false;
                    button1.Visible = false;
                    break;
                case "provider":
                    comboBox1.Visible = false;
                    comboBox2.Visible = false;
                    comboBox3.Visible = false;
                    comboBox4.Visible = false;
                    comboBox5.Visible = false;
                    button1.Visible = false;
                    break;
                case "publising_house":
                    comboBox1.Visible = true;
                    var dt12 = ConnectToDatabase.GetTable("select name_of,id from country");
                    for (int i = 0; i < dt12.Rows.Count; i++)
                    {
                        comboBox1.Items.Add(dt12.Rows[i].ItemArray[0]);
                    }
                    comboBox2.Visible = false;
                    comboBox3.Visible = false;
                    comboBox4.Visible = false;
                    comboBox5.Visible = false;
                    button1.Visible = true;
                    break;
                case "seller":
                    comboBox1.Visible = true;
                    var dt10 = ConnectToDatabase.GetTable("select name_of from position_of");
                    for (int i = 0; i < dt10.Rows.Count; i++)
                    {
                        comboBox1.Items.Add(dt10.Rows[i].ItemArray[0]);
                    }
                    comboBox2.Visible = false;
                    comboBox3.Visible = false;
                    comboBox4.Visible = false;
                    comboBox5.Visible = false;
                    button1.Visible = true;
                    break;

                default:
                    break;
            }

        }

        void selected(string text, string name_of, string vari)
        {
            switch (text)
            {
                case "author":
                    dataGridView1.DataSource = ConnectToDatabase.GetTable($"select * from  author order by {name_of} {vari}");
                    break;
                case "book":
                    dataGridView1.DataSource = ConnectToDatabase.GetTable($"select book.id, book.name_of, author.name_of as author ,genre.name_of as genre, cover.name_of as cover, publising_house.name_of as publising_house,language_of.name_of as language_of, book.cost, book.date_of_release from book inner join cover inner join publising_house inner join language_of inner join genre inner join author on book.author = author.id and book.cover = cover.id and book.genre = genre.id and book.language_of = language_of.id and book.publising_house = publising_house.id  order by {choise_select}.{name_of} {vari}");
                    break;
                case "book_on_stoke":
                    dataGridView1.DataSource = ConnectToDatabase.GetTable($"select seller.last_name as order_id, book.name_of as delivery_id, book_on_stoke.count_of, book_on_stoke.adr_stoke  from orders inner join seller inner join book_on_stoke inner join delivery inner join book inner join author on orders.seller = seller.id and book_on_stoke.delivery_id = delivery.id and book_on_stoke.order_id = orders.id and delivery.book_id = book.id and book.author = author.id  order by {choise_select}.{name_of} {vari}");
                    break;
                case "country":
                    dataGridView1.DataSource = ConnectToDatabase.GetTable($"select * from country  order by {name_of} {vari}");
                    break;
                case "cover":
                    dataGridView1.DataSource = ConnectToDatabase.GetTable($"select * from cover  order by {name_of} {vari}");
                    break;
                case "delivery":
                    dataGridView1.DataSource = ConnectToDatabase.GetTable($"select delivery.id, book.name_of as book_id, provider.last_name as provider_id, delivery.count_of,delivery.date_of, delivery.summ from delivery inner join provider inner join book on delivery.book_id = book.id and delivery.provider_id = provider.id order by {choise_select}.{name_of} {vari}");
                    break;
                case "genre":
                    dataGridView1.DataSource = ConnectToDatabase.GetTable($"select * from genre  order by {name_of} {vari}");
                    break;
                case "language_of":
                    dataGridView1.DataSource = ConnectToDatabase.GetTable($"select * from language_of  order by {name_of} {vari}");
                    break;
                case "orders":
                    dataGridView1.DataSource = ConnectToDatabase.GetTable($"select orders.id, orders.cost,orders.count_of,orders.date_of,orders.summ, seller.last_name as seller from orders inner join seller on orders.seller = seller.id  order by {choise_select}.{name_of} {vari}");
                    break;
                case "position_of":
                    dataGridView1.DataSource = ConnectToDatabase.GetTable($"select * from position_of  order by {name_of} {vari}");
                    break;
                case "provider":
                    dataGridView1.DataSource = ConnectToDatabase.GetTable($"select * from provider order by {name_of} {vari}");
                    break;
                case "publising_house":
                    dataGridView1.DataSource = ConnectToDatabase.GetTable($"select publising_house.id, publising_house.name_of, country.name_of as country_id from publising_house inner join country on publising_house.country_id = country.id order by {choise_select}.{name_of} {vari}");
                    break;
                case "seller":
                    dataGridView1.DataSource = ConnectToDatabase.GetTable($"select seller.id, seller.last_name, seller.first_name, position_of.name_of as position_of_id from seller inner join position_of on seller.position_of_id = position_of.id  order by {choise_select}.{name_of} {vari}");
                    break;

                default:
                    break;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            name_of_atr = dataGridView1.Columns[e.ColumnIndex].Name;
        }

        private void asc_Click(object sender, EventArgs e)
        {
            if (name_of_atr != null)
            {
                selected(choise_select, name_of_atr,"asc");
            }
        }

        private void desc_Click(object sender, EventArgs e)
        {
            selected(choise_select, name_of_atr, "desc");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb[0] = (sender as ComboBox).Text;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb[1] = (sender as ComboBox).Text;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb[2] = (sender as ComboBox).Text;
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb[3] = (sender as ComboBox).Text;
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb[4] = (sender as ComboBox).Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (choise_select)
            {
                case "book":
                    dataGridView1.DataSource = ConnectToDatabase.GetTable($"select book.id, book.name_of, author.name_of as author ,genre.name_of as genre, cover.name_of as cover, publising_house.name_of as publising_house,language_of.name_of as language_of, book.cost, book.date_of_release from book inner join cover inner join publising_house inner join language_of inner join genre inner join author on book.author = author.id and book.cover = cover.id and book.genre = genre.id and book.language_of = language_of.id and book.publising_house = publising_house.id where author.name_of like '%{cb[0]}%' and genre.name_of like '%{cb[1]}%' and language_of.name_of like '%{cb[2]}%' and publising_house.name_of like '%{cb[3]}%' and cover.name_of like '%{cb[4]}%' ");
                    for (int i = 0; i < 5; i++)
                        cb[i] = "";
                    break;
                case "publising_house":
                    if (comboBox1.Text == string.Empty)
                        MessageBox.Show("no information for filtr");
                    else
                        dataGridView1.DataSource = ConnectToDatabase.GetTable($"select publising_house.id, publising_house.name_of, country.name_of as country_id from publising_house inner join country on publising_house.country_id = country.id where country.name_of = '{cb[0]}'");
                    for (int i = 0; i < 5; i++)
                        cb[i] = "";
                    break;
                case "seller":
                    if (comboBox1.Text == string.Empty)
                        MessageBox.Show("no information for filtr");
                    else
                        dataGridView1.DataSource = ConnectToDatabase.GetTable($"select seller.id, seller.last_name, seller.first_name, position_of.name_of as position_of_id from seller inner join position_of on seller.position_of_id = position_of.id  where position_of.name_of = '{cb[0]}'");
                    for (int i = 0; i < 5; i++)
                        cb[i] = "";
                    break;
                default:
                    break;


            }
        }
        void selected_cb(string text)
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

        private void button2_Click(object sender, EventArgs e)
        {
            selected_cb(choise_select);
        }
    }
}
