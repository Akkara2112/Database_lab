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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dt1 = ConnectToDatabase.GetTable($"select * from author where id like  '{textBox1.Text.ToString()}' or name_of like '%{textBox1.Text.ToString()}%'");
            var dt2 = ConnectToDatabase.GetTable($" select * from country where id like '{textBox1.Text.ToString()}' or name_of like '%{textBox1.Text.ToString()}%'");
            var dt3 = ConnectToDatabase.GetTable($" select * from cover where id like '{textBox1.Text.ToString()}' or name_of like '%{textBox1.Text.ToString()}%'");
            var dt4 = ConnectToDatabase.GetTable($" select * from genre where id like '{textBox1.Text.ToString()}' or name_of like '%{textBox1.Text.ToString()}%'");
            var dt5 = ConnectToDatabase.GetTable($" select * from language_of where id like '{textBox1.Text.ToString()}' or name_of like '%{textBox1.Text.ToString()}%'");
            var dt6 = ConnectToDatabase.GetTable($" select * from position_of where id like '{textBox1.Text.ToString()}' or name_of like'%{textBox1.Text.ToString()}%'");
            var dt7 = ConnectToDatabase.GetTable($" select publising_house.id, publising_house.name_of, country.name_of from publising_house inner join country on publising_house.country_id = country.id  where publising_house.id like '{textBox1.Text.ToString()}' or publising_house.name_of like '%{textBox1.Text.ToString()}%' or country.name_of like '%{textBox1.Text.ToString()}%'");
            var dt8 = ConnectToDatabase.GetTable($"select book.id, book.name_of, author.name_of as author ,genre.name_of as genre, cover.name_of as cover, publising_house.name_of as publising_house,language_of.name_of as language_of, book.cost, book.date_of_release from book inner join cover inner join publising_house inner join language_of inner join genre inner join author on book.author = author.id and book.cover = cover.id and book.genre = genre.id and book.language_of = language_of.id and book.publising_house = publising_house.id where book.id like '{textBox1.Text.ToString()}' or book.name_of like '%{textBox1.Text.ToString()}%' or author.name_of like '%{textBox1.Text.ToString()}%' or genre.name_of like '%{textBox1.Text.ToString()}%' or publising_house.name_of like '%{textBox1.Text.ToString()}%' or book.date_of_release like '%{textBox1.Text.ToString()}%' or book.cost like '%%' or language_of.name_of like '%{textBox1.Text.ToString()}%' or cover.name_of like '%{textBox1.Text.ToString()}%';");
            var dt9 = ConnectToDatabase.GetTable($"select seller.last_name as order_id, book.name_of as delivery_id, book_on_stoke.count_of, book_on_stoke.adr_stoke  from orders inner join seller inner join book_on_stoke inner join delivery inner join book inner join author on orders.seller = seller.id and book_on_stoke.delivery_id = delivery.id and book_on_stoke.order_id = orders.id and delivery.book_id = book.id and book.author = author.id where seller.last_name like '%{textBox1.Text.ToString()}%' or book.name_of like '%{textBox1.Text.ToString()}%' or book_on_stoke.count_of like '{textBox1.Text.ToString()}' or book_on_stoke.adr_stoke like '%{textBox1.Text.ToString()}%'");
            var dt10 = ConnectToDatabase.GetTable($"select delivery.id, book.name_of as book_id, provider.last_name as provider_id, delivery.count_of,delivery.date_of, delivery.summ from delivery inner join provider inner join book on delivery.book_id = book.id and delivery.provider_id = provider.id where delivery.id like '{textBox1.Text.ToString()}' or book.name_of like '%{textBox1.Text.ToString()}%' or  provider.last_name like '%{textBox1.Text.ToString()}%' or delivery.count_of like '{textBox1.Text.ToString()}' or delivery.date_of like '%{textBox1.Text.ToString()}%' or delivery.summ like '{textBox1.Text.ToString()}'");
            var dt11 = ConnectToDatabase.GetTable($"select orders.id, orders.cost,orders.count_of,orders.date_of,orders.summ, seller.last_name as seller from orders inner join seller on orders.seller = seller.id where orders.id like '{textBox1.Text.ToString()}' or orders.cost like '{textBox1.Text.ToString()}' or orders.count_of like '{textBox1.Text.ToString()}' or orders.date_of like '%{textBox1.Text.ToString()}%' or orders.summ like '{textBox1.Text.ToString()}' or seller.last_name like '%{textBox1.Text.ToString()}%'");
            var dt12 = ConnectToDatabase.GetTable($"select seller.id, seller.last_name, seller.first_name, position_of.name_of as position_of_id from seller inner join position_of on seller.position_of_id = position_of.id where seller.id like '{textBox1.Text.ToString()}' or seller.last_name like '%{textBox1.Text.ToString()}%' or seller.first_name like '%{textBox1.Text.ToString()}%' or position_of.name_of like '%{textBox1.Text.ToString()}%'");
            var dt13 = ConnectToDatabase.GetTable($"select * from provider where first_name like '%{textBox1.Text.ToString()}%' or last_name like '%{textBox1.Text.ToString()}%' or telephone like '%{textBox1.Text.ToString()}%' or adr_office like '%{textBox1.Text.ToString()}%'");

            if (dt1.Rows.Count != 0)
            {
                listBox1.Items.Add("   Author");
                for (int i = 0; i < dt1.Rows.Count; i++)
                {
                    listBox1.Items.Add(dt1.Rows[i].ItemArray[0]+ " " + dt1.Rows[i].ItemArray[1]);                
                }
            }
            if (dt2.Rows.Count != 0)
            {
                listBox1.Items.Add("   Country");
                for (int i = 0; i < dt2.Rows.Count; i++)
                {
                    listBox1.Items.Add(dt2.Rows[i].ItemArray[0] + " " + dt2.Rows[i].ItemArray[1]);
                }
            }
            if (dt3.Rows.Count != 0)
            {
                listBox1.Items.Add("   Cover");
                for (int i = 0; i < dt3.Rows.Count; i++)
                {
                    listBox1.Items.Add(dt3.Rows[i].ItemArray[0] + " " + dt3.Rows[i].ItemArray[1]);
                }
            }
            if (dt4.Rows.Count != 0)
            {
                listBox1.Items.Add("   Genre");
                for (int i = 0; i < dt4.Rows.Count; i++)
                {
                    listBox1.Items.Add(dt4.Rows[i].ItemArray[0] + " " + dt4.Rows[i].ItemArray[1]);
                }
            }
            if (dt5.Rows.Count != 0)
            {
                listBox1.Items.Add("   Language_of");
                for (int i = 0; i < dt5.Rows.Count; i++)
                {
                    listBox1.Items.Add(dt5.Rows[i].ItemArray[0] + " " + dt5.Rows[i].ItemArray[1]);
                }
            }
            if (dt6.Rows.Count != 0)
            {
                listBox1.Items.Add("   Position_of");
                for (int i = 0; i < dt6.Rows.Count; i++)
                {
                    listBox1.Items.Add(dt6.Rows[i].ItemArray[0] + " " + dt6.Rows[i].ItemArray[1]);
                }
            }
            if (dt7.Rows.Count != 0)
            {
                listBox1.Items.Add("   Publising_house");
                for (int i = 0; i < dt7.Rows.Count; i++)
                {
                    listBox1.Items.Add(dt7.Rows[i].ItemArray[0] + " " + dt7.Rows[i].ItemArray[1] + " " + dt7.Rows[i].ItemArray[2]);
                }
            }
            if (dt8.Rows.Count != 0)
            {
                listBox1.Items.Add("   Book");
                for (int i = 0; i < dt8.Rows.Count; i++)
                {
                    listBox1.Items.Add(dt8.Rows[i].ItemArray[0] + " " + dt8.Rows[i].ItemArray[1] + " " + dt8.Rows[i].ItemArray[2]+" " + dt8.Rows[i].ItemArray[3]+" " + dt8.Rows[i].ItemArray[4]+" " + dt8.Rows[i].ItemArray[5]+ " " + dt8.Rows[i].ItemArray[6]+" " + dt8.Rows[i].ItemArray[7]+" " + dt8.Rows[i].ItemArray[8]);
                }
            }
            if (dt9.Rows.Count != 0)
            {
                listBox1.Items.Add("   Book_on_stoke");
                for (int i = 0; i < dt9.Rows.Count; i++)
                {
                    listBox1.Items.Add(dt9.Rows[i].ItemArray[0] + " " + dt9.Rows[i].ItemArray[1] + " " + dt9.Rows[i].ItemArray[2] + " " + dt9.Rows[i].ItemArray[3]);
                }
            }
            if (dt10.Rows.Count != 0)
            {
                listBox1.Items.Add("   Delivery");
                for (int i = 0; i < dt10.Rows.Count; i++)
                {
                    listBox1.Items.Add(dt10.Rows[i].ItemArray[0] + " " + dt10.Rows[i].ItemArray[1] + " " + dt10.Rows[i].ItemArray[2] + " " + dt10.Rows[i].ItemArray[3] + " " + dt10.Rows[i].ItemArray[4]);
                }
            }
            if (dt11.Rows.Count != 0)
            {
                listBox1.Items.Add("   Orders");
                for (int i = 0; i < dt11.Rows.Count; i++)
                {
                    listBox1.Items.Add(dt11.Rows[i].ItemArray[0] + " " + dt11.Rows[i].ItemArray[1] + " " + dt11.Rows[i].ItemArray[2] + " " + dt11.Rows[i].ItemArray[3] + " " + dt11.Rows[i].ItemArray[4] + " " + dt11.Rows[i].ItemArray[5]);
                }
            }
            if (dt12.Rows.Count != 0)
            {
                listBox1.Items.Add("   Seller");
                for (int i = 0; i < dt12.Rows.Count; i++)
                {
                    listBox1.Items.Add(dt12.Rows[i].ItemArray[0] + " " + dt12.Rows[i].ItemArray[1] + " " + dt12.Rows[i].ItemArray[2] + " " + dt12.Rows[i].ItemArray[3]);
                }
            }
            if (dt13.Rows.Count != 0)
            {
                listBox1.Items.Add("   Provider");
                for (int i = 0; i < dt13.Rows.Count; i++)
                {
                    listBox1.Items.Add(dt13.Rows[i].ItemArray[0] + " " + dt13.Rows[i].ItemArray[1] + " " + dt13.Rows[i].ItemArray[2] + " " + dt13.Rows[i].ItemArray[3]);
                }
            }



        }
    }
}
