using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
//using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace HotelBooking
{
    public partial class Search : Form
    {
        DataClasses1DataContext searchconnection = new DataClasses1DataContext();
        Table users = new Table();
        
        public Search()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            
            
           

        }

        private void Search_Load(object sender, EventArgs e)
        {
            dataGridViewSearchResult.DataSource = users;
        }

        private void linkLabelHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Home g = new Home();
            g.Show();
        }

      

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            List<Table> tableData = searchconnection.Tables.ToList();

            dataGridViewSearchResult.DataSource =tableData ;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home f = new Home();
            f.Show();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            List<Table> tableData = searchconnection.Tables.Where(se => se.CustName.Contains(textBoxSearch.Text)||se.CustID.Contains(textBoxSearch.Text)).ToList();
            dataGridViewSearchResult.DataSource = tableData;
        }     

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButtonID.Checked)
            {
                List<Table> tableData = searchconnection.Tables.Where(se => se.CustID.Contains(textBoxSearch.Text)).ToList();
                dataGridViewSearchResult.DataSource = tableData;
            }
            if (radioButtonName.Checked)
            {
                List<Table> tableData = searchconnection.Tables.Where(se => se.CustName.Contains(textBoxSearch.Text)).ToList();
                dataGridViewSearchResult.DataSource = tableData;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var remove = from details in searchconnection.Tables where details.CustID == textBoxSearch.Text select details;
            foreach(var details in remove)
            {
                searchconnection.Tables.DeleteOnSubmit(details);
                searchconnection.SubmitChanges();
                MessageBox.Show(textBoxSearch.Text + "user was already deleted..!");
            }
            List<Table> tableData = searchconnection.Tables.ToList();

            dataGridViewSearchResult.DataSource = tableData;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
