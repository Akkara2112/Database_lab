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
    public partial class Form5 : Form
    {
        // value_old - для set
        //id - для изменения внешнего ключа!!!
        // colmn - для выборки для внешнего ключа
        // choise - для выборки

        string vo; // value_old
        string choise_select;
        string name_of;
        string new_value;
        string vo_id, v1, v2;

        
        public Form5(string value_old,/* string id, int colmn, */string choise, string name_of_atr,string v_a, string v_c)
        {
            InitializeComponent();
            vo = value_old;
            choise_select = choise;
            name_of = name_of_atr;
            comboBox1.Visible = true;
            textBox1.Visible = true;
            v1 = v_a;
            v2 = v_c;
            selected_cb(choise_select);


        }



        private void Form5_Load(object sender, EventArgs e)
        {
            
        }



        private void button1_Click(object sender, EventArgs e)
        {
            ConnectToDatabase.InsertData($"update {choise_select} set {name_of} = '{textBox1.Text}' where {name_of} = '{vo}'", 1);
            this.Close();
        }




        void selected_cb(string text)
        {

            switch (text)
            {
                case "book":
                    switch (name_of)
                    {
                        case "author":
                            var dt1 = ConnectToDatabase.GetTable($"select name_of,id from author ");
                            for (int i = 0; i < dt1.Rows.Count; i++)
                            {
                                comboBox1.Items.Add(dt1.Rows[i].ItemArray[0]);
                            }
                            break;
                        case "genre":
                            var dt2 = ConnectToDatabase.GetTable($"select name_of,id from genre");
                            for (int i = 0; i < dt2.Rows.Count; i++)
                            {
                                comboBox1.Items.Add(dt2.Rows[i].ItemArray[0]);
                            }
                            break;
                        case "publising_house":
                            var dt3 = ConnectToDatabase.GetTable($"select name_of,id from publising_house");
                            for (int i = 0; i < dt3.Rows.Count; i++)
                            {
                                comboBox1.Items.Add(dt3.Rows[i].ItemArray[0]);
                            }
                            break;
                        case "language_of":
                            var dt4 = ConnectToDatabase.GetTable($"select name_of,id from language_of");
                            for (int i = 0; i < dt4.Rows.Count; i++)
                            {
                                comboBox1.Items.Add(dt4.Rows[i].ItemArray[0]);
                            }
                            break;

                        default:
                            break;
                    }
                    break;
                case "book_on_stoke":
                    if (name_of == "delivery_id"|| name_of == "order_id")
                    {
                        new Form6(vo, name_of, v1, v2).Show();
                        this.Enabled = false;
                    }
                    
                    
                    /*switch (name_of) {
                        case "delivery_id":
                            var dt5 = ConnectToDatabase.GetTable($"select name_of,id from book");
                            for (int i = 0; i < dt5.Rows.Count; i++)
                            {
                                comboBox1.Items.Add(dt5.Rows[i].ItemArray[0]);
                            }
                            break;
                        case "order_id":
                            var dt6 = ConnectToDatabase.GetTable($"select last_name,id from seller");
                            for (int i = 0; i < dt6.Rows.Count; i++)
                            {
                                comboBox1.Items.Add(dt6.Rows[i].ItemArray[0]);
                            }
                            break;

                        default:
                            break;
                    }*/
                    break;
                case "delivery":
                    switch (name_of)
                    {
                        case "book_id":
                            var dt7 = ConnectToDatabase.GetTable($"select name_of,id from book");
                            for (int i = 0; i < dt7.Rows.Count; i++)
                            {
                                comboBox1.Items.Add(dt7.Rows[i].ItemArray[0]);
                            }
                            break;
                        case "provider_id":
                            var dt8 = ConnectToDatabase.GetTable($"select last_name,id from provider");
                            for (int i = 0; i < dt8.Rows.Count; i++)
                            {
                                comboBox1.Items.Add(dt8.Rows[i].ItemArray[0]);
                            }
                            break;
                        default:
                            break;

                    }
                    break;
                case "orders":
                    if (name_of == "seller")
                    {
                        var dt9 = ConnectToDatabase.GetTable($"select last_name,id from seller");
                        for (int i = 0; i < dt9.Rows.Count; i++)
                        {
                            comboBox1.Items.Add(dt9.Rows[i].ItemArray[0]);
                        }
                    }
                    break;
                case "publising_house":
                    if (name_of == "country_id")
                    {
                        var dt10 = ConnectToDatabase.GetTable($"select name_of,id from country");
                        for (int i = 0; i < dt10.Rows.Count; i++)
                        {
                            comboBox1.Items.Add(dt10.Rows[i].ItemArray[0]);
                        }
                    }
                    break;
                case "seller":
                    if (name_of == "position_of_id")
                    {
                        var dt11 = ConnectToDatabase.GetTable($"select name_of,id from position_of");
                        for (int i = 0; i < dt11.Rows.Count; i++)
                        {
                            comboBox1.Items.Add(dt11.Rows[i].ItemArray[0]);
                        }
                    }
                    break;

                default:
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConnectToDatabase.InsertData($"update {choise_select} set {name_of} = {new_value} where {name_of} = {vo}", 1);
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (choise_select)
            {
               
                 case "book":
                    switch (name_of)
                    {
                        case "author":
                            var dt1 = ConnectToDatabase.GetTable($"select id from author where name_of = '{(sender as ComboBox).Text}' ");
                            new_value = dt1.Rows[0].ItemArray[0].ToString();
                            dt1 = ConnectToDatabase.GetTable($"select id from author where name_of = '{vo}' ");
                            vo = dt1.Rows[0].ItemArray[0].ToString();
                            break;
                        case "genre":
                            var dt2 = ConnectToDatabase.GetTable($"select id from genre where name_of = '{(sender as ComboBox).Text}' ");
                            new_value = dt2.Rows[0].ItemArray[0].ToString();
                            dt2 = ConnectToDatabase.GetTable($"select id from genre where name_of = '{vo}' ");
                            vo = dt2.Rows[0].ItemArray[0].ToString();

                            break;
                        case "publising_house":
                            var dt3 = ConnectToDatabase.GetTable($"select id from publising_house where name_of = '{(sender as ComboBox).Text}' ");
                            new_value = dt3.Rows[0].ItemArray[0].ToString();
                            dt3 = ConnectToDatabase.GetTable($"select id from publising_house where name_of = '{vo}' ");
                            vo = dt3.Rows[0].ItemArray[0].ToString();

                            break;
                        case "language_of":
                            var dt4 = ConnectToDatabase.GetTable($"select id from language_of where name_of = '{(sender as ComboBox).Text}'  ");
                            new_value = dt4.Rows[0].ItemArray[0].ToString();
                            dt4 = ConnectToDatabase.GetTable($"select id from language_of where name_of = '{vo}'  ");
                            vo = dt4.Rows[0].ItemArray[0].ToString();

                            break;

                        default:
                            break;
                    }
                    break;
                     case "book_on_stoke":

                    new Form6(vo, name_of,v1,v2).Show();
                    this.Close();
                    /*      switch (name_of)
                          {
                              case "delivery_id":
                                  var dt5 = ConnectToDatabase.GetTable($"select id from book where name_of = {(sender as ComboBox).Text} ");
                                  new_value = dt5.Rows[0].ItemArray[0].ToString();

                                  break;
                              case "order_id":
                                  var dt6 = ConnectToDatabase.GetTable($"select id from seller where last_name = {(sender as ComboBox).Text}");
                                  new_value = dt6.Rows[0].ItemArray[0].ToString();
                                  break;

                              default:
                                  break;
                          */
                    break; 
                case "delivery":
                    switch (name_of)
                    {
                        case "book_id":
                            var dt7 = ConnectToDatabase.GetTable($"select id from book where name_of ='{(sender as ComboBox).Text}' ");
                            new_value = dt7.Rows[0].ItemArray[0].ToString();
                            dt7 = ConnectToDatabase.GetTable($"select id from book where name_of ='{vo}' ");
                            vo = dt7.Rows[0].ItemArray[0].ToString();
                            break;
                        case "provider_id":
                            var dt8 = ConnectToDatabase.GetTable($"select last_name,id from provider where last_name '{(sender as ComboBox).Text}'");
                            new_value = dt8.Rows[0].ItemArray[0].ToString();
                            dt8 = ConnectToDatabase.GetTable($"select last_name,id from provider where last_name '{vo}'");
                            vo = dt8.Rows[0].ItemArray[0].ToString();
                            break;
                        default:
                            break;

                    }
                    break;
                case "orders":
                    if (name_of == "seller")
                    {
                        var dt9 = ConnectToDatabase.GetTable($"select id from seller where last_name = '{(sender as ComboBox).Text}'");
                        new_value = dt9.Rows[0].ItemArray[0].ToString();
                        dt9 = ConnectToDatabase.GetTable($"select id from seller where last_name = '{vo}'");
                        vo = dt9.Rows[0].ItemArray[0].ToString();

                    }
                    break;
                case "publising_house":
                    if (name_of == "country_id")
                    {
                        var dt10 = ConnectToDatabase.GetTable($"select id from country where name_of = '{(sender as ComboBox).Text}'");
                        new_value = dt10.Rows[0].ItemArray[0].ToString();
                        dt10 = ConnectToDatabase.GetTable($"select id from country where name_of = '{vo}'");
                        vo = dt10.Rows[0].ItemArray[0].ToString();
                    }
                    break;
                case "seller":
                    if (name_of == "position_of_id")
                    {
                        var dt11 = ConnectToDatabase.GetTable($"select id from position_of where name_of = '{(sender as ComboBox).Text}'");
                        new_value = dt11.Rows[0].ItemArray[0].ToString();
                        dt11 = ConnectToDatabase.GetTable($"select id from position_of where name_of = '{vo}'");
                        vo = dt11.Rows[0].ItemArray[0].ToString();
                    }
                    break;

                default:
                    break;
            }



            //new_value = ConnectToDatabase.GetTable($"select id from {choise_select} where ")
        }
    }
}
