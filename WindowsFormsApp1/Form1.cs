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
using Microsoft.Office.Interop.Excel;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public bool autoriz;
        public static Form1 ThisForm { get; set; }

        public Form1()
        {
            InitializeComponent();
            ThisForm = this;

            autoriz = false;
            exitToolStripMenuItem.Enabled = false;
            enterToolStripMenuItem.Enabled = true;
            button14.Enabled = false;
            button15.Enabled = false;
            button7.Enabled = false;
            exportToolStripMenuItem.Enabled = false;
        }
        

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            new Form2(ConnectToDatabase.GetTable("select book.id, book.name_of, author.name_of,genre.name_of, cover.name_of, publising_house.name_of,language_of.name_of, book.cost, book.date_of_release from book inner join cover inner join publising_house inner join language_of inner join genre inner join author on book.author = author.id and book.cover = cover.id and book.genre = genre.id and book.language_of = language_of.id and book.publising_house = publising_house.id"), "book").Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form2(ConnectToDatabase.GetTable("select * from cover"), "cover").Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Form2(ConnectToDatabase.GetTable("select * from  author"), "author").Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Form2(ConnectToDatabase.GetTable("select * from language_of"), "language_of").Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Form2(ConnectToDatabase.GetTable("select seller.last_name,seller.first_name, book.name_of, author.name_of, book_on_stoke.count_of, book_on_stoke.adr_stoke  from orders inner join seller inner join book_on_stoke inner join delivery inner join book inner join author on orders.seller = seller.id and book_on_stoke.delivery_id = delivery.id and book_on_stoke.order_id = orders.id and delivery.book_id = book.id and book.author = author.id"), "book_on_stoke").Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new Form2(ConnectToDatabase.GetTable("select delivery.id, book.name_of, provider.last_name, provider.first_name, delivery.count_of,delivery.date_of, delivery.summ from delivery inner join provider inner join book on delivery.book_id = book.id and delivery.provider_id = provider.id"), "delivery").Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            new Form2(ConnectToDatabase.GetTable("select * from provider"), "provider").Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new Form2(ConnectToDatabase.GetTable("select seller.id, seller.last_name, seller.first_name, position_of.name_of from seller inner join position_of on seller.position_of_id = position_of.id"), "seller").Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new Form2(ConnectToDatabase.GetTable("select * from position_of"), "position_of").Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            new Form2(ConnectToDatabase.GetTable("select * from genre"), "genre").Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            new Form2(ConnectToDatabase.GetTable("select publising_house.id, publising_house.name_of, country.name_of from publising_house inner join country on publising_house.country_id = country.id"), "publising_house").Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            new Form2(ConnectToDatabase.GetTable("select * from country"), "country").Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            new Form2(ConnectToDatabase.GetTable("select orders.id, orders.cost,orders.count_of,orders.date_of,orders.summ, seller.last_name,seller.first_name from orders inner join seller on orders.seller = seller.id"), "orders").Show();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            ///*new*/ Form3().s
        }

        private void button14_Click(object sender, EventArgs e)
        {
            new Form3().Show();

        }

        private void button15_Click(object sender, EventArgs e)
        {
            new Form4().Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            new Form7().Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void exelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application ExelApp = new Microsoft.Office.Interop.Excel.Application();

            ExelApp.Application.Workbooks.Add(Type.Missing);

            System.Data.DataTable[] dt = new System.Data.DataTable[13] {
                ConnectToDatabase.GetTable($"select * from  author"),
                ConnectToDatabase.GetTable($"select book.id, book.name_of, author.name_of as author ,genre.name_of as genre, cover.name_of as cover, publising_house.name_of as publising_house,language_of.name_of as language_of, book.cost, book.date_of_release from book inner join cover inner join publising_house inner join language_of inner join genre inner join author on book.author = author.id and book.cover = cover.id and book.genre = genre.id and book.language_of = language_of.id and book.publising_house = publising_house.id "),
                ConnectToDatabase.GetTable($"select seller.last_name as order_id, book.name_of as delivery_id, book_on_stoke.count_of, book_on_stoke.adr_stoke  from orders inner join seller inner join book_on_stoke inner join delivery inner join book inner join author on orders.seller = seller.id and book_on_stoke.delivery_id = delivery.id and book_on_stoke.order_id = orders.id and delivery.book_id = book.id and book.author = author.id "),
                ConnectToDatabase.GetTable($"select * from country "),
                ConnectToDatabase.GetTable($"select * from cover"),
                ConnectToDatabase.GetTable($"select delivery.id, book.name_of as book_id, provider.last_name as provider_id, delivery.count_of,delivery.date_of, delivery.summ from delivery inner join provider inner join book on delivery.book_id = book.id and delivery.provider_id = provider.id"),
                ConnectToDatabase.GetTable($"select * from genre "),
                ConnectToDatabase.GetTable($"select * from language_of "),
                ConnectToDatabase.GetTable($"select orders.id, orders.cost,orders.count_of,orders.date_of,orders.summ, seller.last_name as seller from orders inner join seller on orders.seller = seller.id"),
                ConnectToDatabase.GetTable($"select * from position_of "),
                ConnectToDatabase.GetTable($"select * from provider"),
                ConnectToDatabase.GetTable($"select publising_house.id, publising_house.name_of, country.name_of as country_id from publising_house inner join country on publising_house.country_id = country.id"),
                ConnectToDatabase.GetTable($"select seller.id, seller.last_name, seller.first_name, position_of.name_of as position_of_id from seller inner join position_of on seller.position_of_id = position_of.id")
            };

            for (int i = 0; i < 13; i++)
                to_exel(dt[i], ExelApp);
            ExelApp.Visible = true;

        }
        void to_exel(System.Data.DataTable dt, Microsoft.Office.Interop.Excel.Application ex)
        {
            ex.Application.Sheets.Add(Type.Missing);
            ex.Cells[1, 1] = dt.ToString();
            for (int i = 0; i < dt.Rows.Count; i++)
                for (int j = 0; j < dt.Columns.Count; j++)
                    ex.Cells[i + 2, j + 1] = dt.Rows[i].ItemArray[j].ToString();
        }

        private void pdfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Data.DataTable[] dt = new System.Data.DataTable[13] {
                ConnectToDatabase.GetTable($"select * from  author"),
                ConnectToDatabase.GetTable($"select book.id, book.name_of, author.name_of as author ,genre.name_of as genre, cover.name_of as cover, publising_house.name_of as publising_house,language_of.name_of as language_of, book.cost, book.date_of_release from book inner join cover inner join publising_house inner join language_of inner join genre inner join author on book.author = author.id and book.cover = cover.id and book.genre = genre.id and book.language_of = language_of.id and book.publising_house = publising_house.id"),
                ConnectToDatabase.GetTable($"select seller.last_name as order_id, book.name_of as delivery_id, book_on_stoke.count_of, book_on_stoke.adr_stoke  from orders inner join seller inner join book_on_stoke inner join delivery inner join book inner join author on orders.seller = seller.id and book_on_stoke.delivery_id = delivery.id and book_on_stoke.order_id = orders.id and delivery.book_id = book.id and book.author = author.id "),
                ConnectToDatabase.GetTable($"select * from country "),
                ConnectToDatabase.GetTable($"select * from cover"),
                ConnectToDatabase.GetTable($"select delivery.id, book.name_of as book_id, provider.last_name as provider_id, delivery.count_of,delivery.date_of, delivery.summ from delivery inner join provider inner join book on delivery.book_id = book.id and delivery.provider_id = provider.id"),
                ConnectToDatabase.GetTable($"select * from genre "),
                ConnectToDatabase.GetTable($"select * from language_of "),
                ConnectToDatabase.GetTable($"select orders.id, orders.cost,orders.count_of,orders.date_of,orders.summ, seller.last_name as seller from orders inner join seller on orders.seller = seller.id"),
                ConnectToDatabase.GetTable($"select * from position_of "),
                ConnectToDatabase.GetTable($"select * from provider"),
                ConnectToDatabase.GetTable($"select publising_house.id, publising_house.name_of, country.name_of as country_id from publising_house inner join country on publising_house.country_id = country.id"),
                ConnectToDatabase.GetTable($"select seller.id, seller.last_name, seller.first_name, position_of.name_of as position_of_id from seller inner join position_of on seller.position_of_id = position_of.id")
            };

            iTextSharp.text.Document doc = new iTextSharp.text.Document();

            PdfWriter.GetInstance(doc, new FileStream("pdftables.pdf", FileMode.OpenOrCreate));
            doc.Open();
            BaseFont basefont = BaseFont.CreateFont(@"C:\Windows\Fonts\arial.ttf", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font fon = new iTextSharp.text.Font(basefont, 9/*iTextSharp.text.Font.DEFAULTSIZE*/, iTextSharp.text.Font.NORMAL);

            for (int i = 0; i<13; i++)
            {
                PdfPTable table  = new PdfPTable(dt[i].Columns.Count);
                PdfPCell cel;

                    cel = new PdfPCell(new Phrase(dt[i].ToString(), fon));
                    cel.Colspan = dt[i].Columns.Count;
                    cel.HorizontalAlignment = 1;
                    cel.Border = 0;
                    table.AddCell(cel);

                    cel = new PdfPCell(new Phrase(" ", fon));
                    cel.Colspan = dt[i].Columns.Count;
                    cel.HorizontalAlignment = 1;
                    cel.Border = 0;
                    table.AddCell(cel);

                for (int j = 0; j < dt[i].Columns.Count; j ++)
                {

                        cel = new PdfPCell(new Phrase(dt[i].Columns[j].ColumnName, fon));
                        table.AddCell(cel);

                
                }
                for (int j = 0; j < dt[i].Rows.Count; j++)
                    for (int k = 0; k<dt[i].Columns.Count; k++)
                    {
                        table.AddCell(new Phrase(dt[i].Rows[j].ItemArray[k].ToString(), fon));
                    }
                doc.Add(table);

            }
            doc.Close();
            MessageBox.Show("Сохранено");
        }

        private void enterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 f = new Form8();
            f.ShowDialog();
            if (autoriz == true)
            {
                exitToolStripMenuItem.Enabled = true;
                enterToolStripMenuItem.Enabled = false;
                button14.Enabled = true;
                button15.Enabled = true;
                button7.Enabled = true;
                exportToolStripMenuItem.Enabled = true;
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            autoriz = false;
            exitToolStripMenuItem.Enabled = false;
            enterToolStripMenuItem.Enabled = true;
            button14.Enabled = false;
            button15.Enabled = false;
            button7.Enabled = false;
            exportToolStripMenuItem.Enabled = false;
        }
    }
}
