using System;

using System.Windows.Forms;
using System.Data.SqlClient;
namespace hhh
{
    public partial class AddCatugryForm2 : Form
    {
        public AddCatugryForm2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection =
                new SqlConnection
                ("Data Source=DESKTOP-ONU7173;Initial Catalog=master;Integrated Security=True");

            SqlCommand sqlCommand = connection.CreateCommand();
            sqlCommand.Connection = connection;
            connection.Open();
            sqlCommand.CommandText = " insert into CATEGORY values('" + textBox1.Text + "') ";
            sqlCommand.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("success");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection connection =
               new SqlConnection
               ("Data Source=DESKTOP-ONU7173;Initial Catalog=master;Integrated Security=True");

            SqlCommand sqlCommand = connection.CreateCommand();
            sqlCommand.Connection = connection;
            connection.Open();
            sqlCommand.CommandText = " delete from CATEGORY where  CATENAME='" + textBox1.Text + "' ";
            sqlCommand.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("success");
        }

        private void AddCatugryForm2_Load(object sender, EventArgs e)
        {

        }
    }
}
