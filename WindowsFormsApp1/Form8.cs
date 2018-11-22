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
    public partial class Form8 : Form
    {
        
        public Form8()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty || textBox2.Text == string.Empty)
            {
                MessageBox.Show("No information!");
            }
            else
            {
                var dt = ConnectToDatabase.GetTable("select last_name,pass from seller");
                for (int i = 0; i<dt.Rows.Count; i++)
                {
                    if (textBox1.Text == dt.Rows[i].ItemArray[0].ToString())
                        if (textBox2.Text == dt.Rows[i].ItemArray[1].ToString())
                        {
                            Form1.ThisForm.autoriz = true;
                            MessageBox.Show("You entered");
                            break;
                            
                        }
                        else
                            MessageBox.Show("Not true pass");
                    else
                        MessageBox.Show("Not true Last Name");
                    
                }
                this.Close();
            }
        }
    }
}
