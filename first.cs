using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelBooking
{
    public partial class first : Form
    {
      
        public first()
        {
            InitializeComponent();
        }

        private void textBoxUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBoxUserName.Text.ToString();
            string password = textBoxPassword.Text.ToString();
            if (String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password))
            {
                DialogResult dialogResult = MessageBox.Show("No empty fields allowed", "You cannot continue", MessageBoxButtons.OK);
            }
            else if (username == "hotel" && password == "077234")
            {
                this.Hide();
                Login l = new Login();
                l.Show();
            }

            
            else
            {
                MessageBox.Show("Username or Password incorrect!");
            }
                




            }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.Close();
        }

        private void first_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

