using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManager
{
    public partial class ViewMember : Form
    {
        public ViewMember()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Eren\Documents\GymDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void populate()
        {
            Con.Open();
            string query = "select * from MemberTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            MemberDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void ViewMember_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }
        private void filterByName()
        {
            Con.Open();
            string query = "select * from MemberTbl where MNameandSurname='" + SearchMember.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter();
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            MemberDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void SearchMember_Click(object sender, EventArgs e)
        {
            filterByName();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
