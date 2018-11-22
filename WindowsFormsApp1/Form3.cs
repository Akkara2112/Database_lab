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
    public partial class Form3 : Form
    {

        string var_tb1 = null;
        string var_tb2 = null;
        string var_tb3 = null;
        string var_tb4 = null;



        string vaк_datetime = null;

        string choise_select;
        



        public Form3()
        {
            InitializeComponent();


            var dt = ConnectToDatabase.GetTable("Show Tables");
            for (int i = 0; i<dt.Rows.Count; i ++)
            {
                cbNameTb.Items.Add(dt.Rows[i].ItemArray[0]);
            }
            //cbNameTb.Text 
        }

        private void cbNameTb_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((sender as ComboBox).Text)
            {
                case "author":
                    choise_select = "author";

                    cb1.Items.Clear();
                    cb2.Items.Clear();
                    cb3.Items.Clear();
                    cb4.Items.Clear();
                    cb5.Items.Clear();
                    cb6.Items.Clear();


                    label1.Visible = false;
                    label2.Visible = true;
                    label3.Visible = false;

                    tb1.Visible = true;
                    label4.Text = "name_of";
                    tb2.Visible = false;
                    tb3.Visible = false;
                    tb4.Visible = false;

                    cb1.Visible = false;
                    cb2.Visible = false;
                    cb3.Visible = false;
                    cb4.Visible = false;
                    cb5.Visible = false;
                    cb6.Visible = false;

                    datetime.Visible = false;
                    break;
                case "book":
                    choise_select = "book";

                    cb1.Items.Clear();
                    cb2.Items.Clear();
                    cb3.Items.Clear();
                    cb4.Items.Clear();
                    cb5.Items.Clear();
                    cb6.Items.Clear();

                    label1.Visible = true;
                    label2.Visible = false;
                    label3.Visible = false;

                    tb1.Visible = true;
                    label4.Text = "name_of";
                    tb2.Visible = true;
                    label5.Text = "cost";
                    tb3.Visible = false;
                    tb4.Visible = true;
                    label7.Text = "date_of_realise";

                    cb1.Visible = true;
                    var dt1 = ConnectToDatabase.GetTable("select name_of,id from author");
                    for (int i = 0; i < dt1.Rows.Count; i++)
                    {
                        cb1.Items.Add(dt1.Rows[i].ItemArray[0]);
                    }
                    cb2.Visible = true;
                    var dt2 = ConnectToDatabase.GetTable("select name_of,id from genre");
                    for (int i = 0; i < dt2.Rows.Count; i++)
                    {
                        cb2.Items.Add(dt2.Rows[i].ItemArray[0]);
                    }
                    cb3.Visible = true;
                    var dt3 = ConnectToDatabase.GetTable("select name_of,id from language_of");
                    for (int i = 0; i < dt3.Rows.Count; i++)
                    {
                        cb3.Items.Add(dt3.Rows[i].ItemArray[0]);
                    }
                    cb4.Visible = true;
                    var dt4 = ConnectToDatabase.GetTable("select name_of,id from publising_house");
                    for (int i = 0; i < dt4.Rows.Count; i++)
                    {
                        cb4.Items.Add(dt4.Rows[i].ItemArray[0]);
                    }
                    cb5.Visible = true;
                    var dt5 = ConnectToDatabase.GetTable("select name_of,id from cover");
                    for (int i = 0; i < dt5.Rows.Count; i++)
                    {
                        cb5.Items.Add(dt5.Rows[i].ItemArray[0]);
                    }
                    cb6.Visible = false;

                    datetime.Visible = false;
                    break;
                case "book_on_stoke":
                    choise_select = "book_on_stoke";

                    cb1.Items.Clear();
                    cb2.Items.Clear();
                    cb3.Items.Clear();
                    cb4.Items.Clear();
                    cb5.Items.Clear();
                    cb6.Items.Clear();

                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = false;

                    tb1.Visible = false;
                    tb2.Visible = false;
                    tb3.Visible = true;
                    label6.Text = "count_of";
                    tb4.Visible = true;
                    label7.Text = "adr_stoke";

                    cb1.Visible = true;
                    var dt6 = ConnectToDatabase.GetTable("select last_name,id from provider");
                    for (int i = 0; i < dt6.Rows.Count; i++)
                    {
                        cb1.Items.Add(dt6.Rows[i].ItemArray[0]);
                    }
                    cb2.Visible = true;
                    var dt7 = ConnectToDatabase.GetTable("select last_name,id from seller");
                    for (int i = 0; i < dt7.Rows.Count; i++)
                    {
                        cb2.Items.Add(dt7.Rows[i].ItemArray[0]);
                    }
                    cb3.Visible = false;
                    cb4.Visible = false;
                    cb5.Visible = false;
                    cb6.Visible = false;

                    datetime.Visible = false;
                    break;
                case "country":
                    choise_select = "country";

                    cb1.Items.Clear();
                    cb2.Items.Clear();
                    cb3.Items.Clear();
                    cb4.Items.Clear();
                    cb5.Items.Clear();
                    cb6.Items.Clear();

                    label1.Visible = false;
                    label2.Visible = true;
                    label3.Visible = false;

                    tb1.Visible = true;
                    label4.Text = "name_of";
                    tb2.Visible = false;
                    tb3.Visible = false;
                    tb4.Visible = false;

                    cb1.Visible = false;
                    cb2.Visible = false;
                    cb3.Visible = false;
                    cb4.Visible = false;
                    cb5.Visible = false;
                    cb6.Visible = false;

                    datetime.Visible = false;
                    break;
                case "cover":
                    choise_select = "cover";

                    cb1.Items.Clear();
                    cb2.Items.Clear();
                    cb3.Items.Clear();
                    cb4.Items.Clear();
                    cb5.Items.Clear();
                    cb6.Items.Clear();

                    label1.Visible = false;
                    label2.Visible = true;
                    label3.Visible = false;

                    tb1.Visible = true;
                    label4.Text = "name_of";
                    tb2.Visible = false;
                    tb3.Visible = false;
                    tb4.Visible = false;

                    cb1.Visible = false;
                    cb2.Visible = false;
                    cb3.Visible = false;
                    cb4.Visible = false;
                    cb5.Visible = false;
                    cb6.Visible = false;

                    datetime.Visible = false;
                    break;
                case "delivery":
                    choise_select = "delivery";

                    cb1.Items.Clear();
                    cb2.Items.Clear();
                    cb3.Items.Clear();
                    cb4.Items.Clear();
                    cb5.Items.Clear();
                    cb6.Items.Clear();

                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;

                    tb1.Visible = false;
                    tb2.Visible = false;
                    tb3.Visible = true;
                    label6.Text = "count_of";
                    tb4.Visible = true;
                    label7.Text = "summ";

                    cb1.Visible = true;
                    var dt8 = ConnectToDatabase.GetTable("select name_of,id from book");
                    for (int i = 0; i < dt8.Rows.Count; i++)
                    {
                        cb1.Items.Add(dt8.Rows[i].ItemArray[0]);
                    }
                    cb2.Visible = true;
                    var dt9 = ConnectToDatabase.GetTable("select last_name,id from provider");
                    for (int i = 0; i < dt9.Rows.Count; i++)
                    {
                        cb2.Items.Add(dt9.Rows[i].ItemArray[0]);
                    }
                    cb3.Visible = false;
                    cb4.Visible = false;
                    cb5.Visible = false;
                    cb6.Visible = false;

                    datetime.Visible = true;
                    break;
                case "genre":
                    choise_select = "genre";

                    cb1.Items.Clear();
                    cb2.Items.Clear();
                    cb3.Items.Clear();
                    cb4.Items.Clear();
                    cb5.Items.Clear();
                    cb6.Items.Clear();

                    label1.Visible = false;
                    label2.Visible = true;
                    label3.Visible = false;

                    tb1.Visible = true;
                    label4.Text = "name_of";
                    tb2.Visible = false;
                    tb3.Visible = false;
                    tb4.Visible = false;

                    cb1.Visible = false;
                    cb2.Visible = false;
                    cb3.Visible = false;
                    cb4.Visible = false;
                    cb5.Visible = false;
                    cb6.Visible = false;

                    datetime.Visible = false;
                    break;
                case "language_of":
                    choise_select = "language_of";

                    cb1.Items.Clear();
                    cb2.Items.Clear();
                    cb3.Items.Clear();
                    cb4.Items.Clear();
                    cb5.Items.Clear();
                    cb6.Items.Clear();

                    label1.Visible = false;
                    label2.Visible = true;
                    label3.Visible = false;

                    tb1.Visible = true;
                    label4.Text = "name_of";
                    tb2.Visible = false;
                    tb3.Visible = false;
                    tb4.Visible = false;

                    cb1.Visible = false;
                    cb2.Visible = false;
                    cb3.Visible = false;
                    cb4.Visible = false;
                    cb5.Visible = false;
                    cb6.Visible = false;

                    datetime.Visible = false;
                    break;
                case "orders":
                    choise_select = "orders";

                    cb1.Items.Clear();
                    cb2.Items.Clear();
                    cb3.Items.Clear();
                    cb4.Items.Clear();
                    cb5.Items.Clear();
                    cb6.Items.Clear();

                    label1.Visible = false;
                    label2.Visible = true;
                    label3.Visible = false;

                    tb1.Visible = false;
                    
                    tb2.Visible = true;
                    label5.Text = "cost";
                    tb3.Visible = true;
                    label6.Text = "count_of";
                    tb4.Visible = true;
                    label7.Text = "summ";

                    cb1.Visible = true;
                    var dt11 = ConnectToDatabase.GetTable("select last_name,id from seller");
                    for (int i = 0; i < dt11.Rows.Count; i++)
                    {
                        cb1.Items.Add(dt11.Rows[i].ItemArray[0]);
                    }
                    cb2.Visible = false;
                    cb3.Visible = false;
                    cb4.Visible = false;
                    cb5.Visible = false;
                    cb6.Visible = false;

                    datetime.Visible = true;
                    break;
                case "position_of":
                    choise_select = "position_of";

                    cb1.Items.Clear();
                    cb2.Items.Clear();
                    cb3.Items.Clear();
                    cb4.Items.Clear();
                    cb5.Items.Clear();
                    cb6.Items.Clear();

                    label1.Visible = false;
                    label2.Visible = true;
                    label3.Visible = false;

                    tb1.Visible = true;
                    label4.Text = "name_of";
                    tb2.Visible = false;
                    tb3.Visible = false;
                    tb4.Visible = false;

                    cb1.Visible = false;
                    cb2.Visible = false;
                    cb3.Visible = false;
                    cb4.Visible = false;
                    cb5.Visible = false;
                    cb6.Visible = false;

                    datetime.Visible = false;
                    break;
                case "provider":
                    choise_select = "provider";

                    cb1.Items.Clear();
                    cb2.Items.Clear();
                    cb3.Items.Clear();
                    cb4.Items.Clear();
                    cb5.Items.Clear();
                    cb6.Items.Clear();

                    label1.Visible = false;
                    label2.Visible = true;
                    label3.Visible = false;

                    tb1.Visible = true;
                    label4.Text = "last_name";
                    tb2.Visible = true;
                    label5.Text = "first_name";
                    tb3.Visible = true;
                    label6.Text = "telephone";
                    tb4.Visible = true;
                    label7.Text = "adr_office";

                    cb1.Visible = false;
                    cb2.Visible = false;
                    cb3.Visible = false;
                    cb4.Visible = false;
                    cb5.Visible = false;
                    cb6.Visible = false;

                    datetime.Visible = false;
                    break;
                case "publising_house":
                    cb1.Items.Clear();
                    cb2.Items.Clear();
                    cb3.Items.Clear();
                    cb4.Items.Clear();
                    cb5.Items.Clear();
                    cb6.Items.Clear();

                    label1.Visible = true;
                    label4.Text = "name_of";
                    label2.Visible = false;
                    label3.Visible = false;

                    tb1.Visible = true;
                    tb2.Visible = false;
                    tb3.Visible = false;
                    tb4.Visible = false;

                    cb1.Visible = true;
                    var dt12 = ConnectToDatabase.GetTable("select name_of,id from country");
                    for (int i = 0; i < dt12.Rows.Count; i++)
                    {
                        cb1.Items.Add(dt12.Rows[i].ItemArray[0]);
                    }

                    cb2.Visible = false;
                    cb3.Visible = false;
                    cb4.Visible = false;
                    cb5.Visible = false;
                    cb6.Visible = false;

                    datetime.Visible = false;
                    break;
                case "seller":
                    cb1.Items.Clear();
                    cb2.Items.Clear();
                    cb3.Items.Clear();
                    cb4.Items.Clear();
                    cb5.Items.Clear();
                    cb6.Items.Clear();

                    label1.Visible = false;
                    label2.Visible = true;
                    label3.Visible = false;

                    tb1.Visible = true;
                    label4.Text = "last_name";
                    tb2.Visible = true;
                    label5.Text = "first_name";
                    tb3.Visible = false;
                    tb4.Visible = false;

                    cb1.Visible = true;
                    var dt10 = ConnectToDatabase.GetTable("select name_of from position_of");
                    for (int i = 0; i < dt10.Rows.Count; i++)
                    {
                        cb1.Items.Add(dt10.Rows[i].ItemArray[0]);
                    }
                    cb2.Visible = false;
                    cb3.Visible = false;
                    cb4.Visible = false;
                    cb5.Visible = false;
                    cb6.Visible = false;

                    datetime.Visible = false;
                    break;

                default:
                    break;
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string var_cb1 = null;
            string var_cb2 = null;
            string var_cb3 = null;
            string var_cb4 = null;
            string var_cb5 = null;

            switch (choise_select)
           // switch ((sender as ComboBox).Text)
            {
                case "author":

                   if (tb1.Text == string.Empty)
                    {
                        MessageBox.Show("I havent information!");
                    }
                   else
                    {
                        try
                        {
                            Convert.ToInt32(tb1.Text);
                            
                            MessageBox.Show("Введено число в поле имени!");
                        }
                        catch (FormatException)
                        {
                            //MessageBox.Show("Введено не число!");
                            ConnectToDatabase.InsertData($"insert into {choise_select}(name_of) values ('{tb1.Text}')", 1);
                        }
                        
                    }

                    break;
                case "book":
                    if ((tb1.Text == string.Empty)||(tb2.Text == string.Empty)|| (tb4.Text == string.Empty)||(cb1.Text == string.Empty) || (cb1.Text == string.Empty) || (cb2.Text == string.Empty) || (cb3.Text == string.Empty) || (cb4.Text == string.Empty) || (cb5.Text == string.Empty))
                    {
                        
                        MessageBox.Show("I havent information!");
                    }
                    else
                    {
                        //if ((tb2.Text == string.Empty) || (tb4.Text == string.Empty))
                        //{
                            try
                            {
                                Convert.ToInt32(tb2.Text); tb2.Text.ToString();
                                Convert.ToInt32(tb4.Text); tb4.Text.ToString();
                                 var_cb1 = Convert.ToString(ConnectToDatabase.GetTable($"select id from author where name_of like '{cb1.Text}'").Rows[0].ItemArray[0]);
                                var_cb2 = Convert.ToString(ConnectToDatabase.GetTable($"select id from genre where name_of like '{cb2.Text}'").Rows[0].ItemArray[0]);
                                var_cb3 = Convert.ToString(ConnectToDatabase.GetTable($"select id from language_of where name_of like '{cb3.Text}'").Rows[0].ItemArray[0]);
                                var_cb4 = Convert.ToString(ConnectToDatabase.GetTable($"select id from publising_house where name_of like '{cb4.Text}'").Rows[0].ItemArray[0]);
                                var_cb5 = Convert.ToString(ConnectToDatabase.GetTable($"select id from cover where name_of like '{cb5.Text}'").Rows[0].ItemArray[0]);
                                ConnectToDatabase.InsertData($"insert into {choise_select}(name_of, cost, date_of_release,author,genre,language_of,publising_house,cover) values ('{tb1.Text}','{tb2.Text}','{tb4.Text}',{var_cb1},{var_cb2},{var_cb3},{var_cb4},{var_cb5})", 1);
                                //MessageBox.Show("Введено число в поле имени!");
                            }
                            catch (FormatException)
                            {
                                MessageBox.Show("Введено не число в одно из полей даты выхода/стоимости!");
                            }
                        //}

                        
                        
                    }

                    var_cb1 = null;
                    var_cb2 = null;
                    var_cb3 = null;
                    var_cb4 = null;
                    var_cb5 = null;

                    break;
                case "book_on_stoke":
                    if ((tb3.Text == string.Empty) || (tb4.Text == string.Empty) || (cb1.Text == string.Empty) || (cb2.Text == string.Empty))
                    {
                        MessageBox.Show("I havent information!");
                    }
                    else
                    {
                        try
                        {
                            Convert.ToInt32(tb3.Text); tb3.Text.ToString();
                            var_cb1 = Convert.ToString(ConnectToDatabase.GetTable($"select delivery.id from delivery, provider where delivery.provider_id= provider.id and provider.last_name like'{cb1.Text}'").Rows[0].ItemArray[0]);
                            var_cb2 = Convert.ToString(ConnectToDatabase.GetTable($"select orders.id from orders,seller where orders.seller = seller.id and seller.last_name like'{cb2.Text}'").Rows[0].ItemArray[0]);
                            ConnectToDatabase.InsertData($"insert into {choise_select}( delivery_id,order_id,count_of,adr_stoke) values ({var_cb1},{var_cb2},'{tb3.Text}','{tb4.Text}')", 1);

                            //MessageBox.Show("Введено число в поле имени!");
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("Введено не число в поле количества!");
                        }
                        //!!!!!!!!!!!Я ТУУУУУУУУУУУУУУУУУУУУУУУУУУУУУУУУУУТ!!!!!!!!!!!!!!!!!!!!!
                        
                    }
                    var_cb1 = null;
                    var_cb2 = null;
                    var_cb3 = null;
                    var_cb4 = null;
                    var_cb5 = null;

                    break;
                case "country":
                    if ((tb1.Text == string.Empty))
                    {
                        MessageBox.Show("I havent information!");
                    }
                    else
                    {

                        try
                        {
                            Convert.ToInt32(tb1.Text);

                            MessageBox.Show("Введено число в поле имени!");
                        }
                        catch (FormatException)
                        {
                            //MessageBox.Show("Введено не число!");
                            ConnectToDatabase.InsertData($"insert into {choise_select}(name_of) values ('{tb1.Text}')", 1);
                        }
                    }

                    break;
                case "cover":
                    if (tb1.TextLength == 0)
                    {
                        MessageBox.Show("I havent information!");
                    }
                    else
                    {
                        try
                        {
                            Convert.ToInt32(tb1.Text);

                            MessageBox.Show("Введено число в поле имени!");
                        }
                        catch (FormatException)
                        {
                            //MessageBox.Show("Введено не число!");
                            ConnectToDatabase.InsertData($"insert into {choise_select}(name_of) values ('{tb1.Text}')", 1);
                        }
                    }
                    break;
                case "delivery":// проверка
                    if ((tb3.Text == string.Empty) || (tb4.Text == string.Empty) || (cb1.Text == string.Empty) || (cb2.Text == string.Empty))
                    {
                        MessageBox.Show("I havent information!");
                    }
                    else
                    {
                        var_cb1 = Convert.ToString(ConnectToDatabase.GetTable($"select id from book where name_of like'{cb1.Text}'").Rows[0].ItemArray[0]);
                        var_cb2 = Convert.ToString(ConnectToDatabase.GetTable($"select id from provider where last_name like'{cb2.Text}'").Rows[0].ItemArray[0]);
                        ConnectToDatabase.InsertData($"insert into {choise_select}(book_id,provider_id,count_of, summ,date_of) values ({var_cb1},{var_cb2},'{tb3.Text}','{tb4.Text}','{datetime.Text}')", 1);
                        
                    }
                    var_cb1 = null;
                    var_cb2 = null;
                    var_cb3 = null;
                    var_cb4 = null;
                    var_cb5 = null;

                    break;
                case "genre":
                    if (tb1.TextLength == 0)
                    {
                        MessageBox.Show("I havent information!");
                    }
                    else
                    {
                        try
                        {
                            Convert.ToInt32(tb1.Text);

                            MessageBox.Show("Введено число в поле имени!");
                        }
                        catch (FormatException)
                        {
                            //MessageBox.Show("Введено не число!");
                            ConnectToDatabase.InsertData($"insert into {choise_select}(name_of) values ('{tb1.Text}')", 1);
                        }
                    }

                    break;
                case "language_of":
                    if (tb1.TextLength == 0)
                    {
                        MessageBox.Show("I havent information!");
                    }
                    else
                    {
                        try
                        {
                            Convert.ToInt32(tb1.Text);

                            MessageBox.Show("Введено число в поле имени!");
                        }
                        catch (FormatException)
                        {
                            //MessageBox.Show("Введено не число!");
                            ConnectToDatabase.InsertData($"insert into {choise_select}(name_of) values ('{tb1.Text}')", 1);
                        }
                    }

                    break;
                case "orders":
                    if ((tb3.Text == string.Empty) || (tb4.Text == string.Empty) || (tb2.Text == string.Empty) || (cb1.Text == string.Empty))
                    {
                        MessageBox.Show("I havent information!");
                    }
                    else
                    {
                        try
                        {
                            Convert.ToInt32(tb2.Text); tb2.Text.ToString();
                            Convert.ToInt32(tb3.Text); tb3.Text.ToString();
                            Convert.ToInt32(tb4.Text); tb4.Text.ToString();
                            var_cb1 = Convert.ToString(ConnectToDatabase.GetTable($"select id from seller where last_name like'{cb1.Text}'").Rows[0].ItemArray[0]);
                            ConnectToDatabase.InsertData($"insert into {choise_select}(seller,cost,count_of, summ,date_of) values ({var_cb1},'{tb2.Text}','{tb3.Text}','{tb4.Text}','{datetime.Text}')", 1);
                            //MessageBox.Show("Введено число в поле имени!");
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("Введено не число в поля колчества суммы и свтоимости!");
                            //ConnectToDatabase.InsertData($"insert into {choise_select}(name_of) values ('{tb1.Text}')", 1);
                        }
                        

                    }
                    var_cb1 = null;
                    var_cb2 = null;
                    var_cb3 = null;
                    var_cb4 = null;
                    var_cb5 = null;


                    break;
                case "position_of":
                    if (tb1.TextLength == 0)
                    {
                        MessageBox.Show("I havent information!");
                    }
                    else
                    {
                        try
                        {
                            Convert.ToInt32(tb1.Text);

                            MessageBox.Show("Введено число в поле имени!");
                        }
                        catch (FormatException)
                        {
                            //MessageBox.Show("Введено не число!");
                            ConnectToDatabase.InsertData($"insert into {choise_select}(name_of) values ('{tb1.Text}')", 1);
                        }
                    }

                    break;
                case "provider":

                    if ((tb3.Text == string.Empty) || (tb4.Text == string.Empty) || (tb2.Text == string.Empty) || (tb1.Text == string.Empty))
                    {
                        MessageBox.Show("I havent information!");
                    }
                    else
                    {
                        try
                        {
                            Convert.ToInt32(tb3.Text); tb3.Text.ToString();
                            try
                            {
                                Convert.ToInt32(tb1.Text); tb1.Text.ToString();
                                Convert.ToInt32(tb2.Text); tb2.Text.ToString();
                                
                                MessageBox.Show("Введено число в поле имен!");
                            }
                            catch (FormatException)
                            {
                                ConnectToDatabase.InsertData($"insert into {choise_select}(last_name,first_name,telephone,adr_office) values ('{tb1.Text}','{tb2.Text}','{tb3.Text}','{tb4.Text}')", 1);
                                //MessageBox.Show("Введено не число!");

                            }
                            //MessageBox.Show("Введено число в поле имени!");
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("Введено не число в поле телефона!");
                            
                        }
                        

                    }
                    var_cb1 = null;
                    var_cb2 = null;
                    var_cb3 = null;
                    var_cb4 = null;
                    var_cb5 = null;

                    break;
                case "publising_house":
                    if ((tb1.Text == string.Empty) ||  (cb1.Text == string.Empty))
                    {
                        MessageBox.Show("I havent information!");
                    }
                    else
                    {
                        var_cb1 = Convert.ToString(ConnectToDatabase.GetTable($"select id from country where name_of like'{cb1.Text}')").Rows[0].ItemArray[0]);
                        ConnectToDatabase.InsertData($"insert into {choise_select}(country_id,name_of) values ({var_cb1},'{tb1.Text}'", 1);

                    }
                    var_cb1 = null;
                    var_cb2 = null;
                    var_cb3 = null;
                    var_cb4 = null;
                    var_cb5 = null;

                    break;
                case "seller":
                    if ((tb1.Text == string.Empty) || (cb1.Text == string.Empty)|| (tb2.Text == string.Empty))
                    {
                        MessageBox.Show("I havent information!");
                    }
                    else
                    {
                        try
                        {
                            Convert.ToInt32(tb1.Text);
                            Convert.ToInt32(tb2.Text);

                            MessageBox.Show("Введено число в поле имен!");
                        }
                        catch (FormatException)
                        {
                            //MessageBox.Show("Введено не число!");
                            var_cb1 = Convert.ToString(ConnectToDatabase.GetTable($"select id from position_of where name_of like'{cb1.Text}')").Rows[0].ItemArray[0]);
                            ConnectToDatabase.InsertData($"insert into {choise_select}(position_of_id,last_name,first_name) values ({var_cb1},'{tb1.Text}','{tb2.Text}'", 1);
                        }
                        

                    }
                    var_cb1 = null;
                    var_cb2 = null;
                    var_cb3 = null;
                    var_cb4 = null;
                    var_cb5 = null;

                    break;

                default:
                    break;
             }
            this.Close();
        }

        private void tb1_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*if (choise_select == "seller"|| choise_select == "provider")
                if (Char.IsDigit(e.KeyChar))
                    e.Handled = true;*/
            
            
        }
    }
}
