using System;

using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace hhh
{
    public partial class OptianAdminForm2 : Form
    {
        SqlConnection cc = new SqlConnection("Data Source=DESKTOP-ONU7173;Initial Catalog=master;Integrated Security=True");
        SqlDataAdapter da;
        DataSet ds;
        public OptianAdminForm2()
        {
           
            InitializeComponent();
        }

        private void OptianAdminForm2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masterDataSet.Customer_Product' table. You can move, or remove it, as needed.
            //this.customer_ProductTableAdapter.Fill(this.masterDataSet.Customer_Product);
            // TODO: This line of code loads data into the 'super_marketDataSet1.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.masterDataSet.Category);
            this.productTableAdapter.Fill(this.masterDataSet.Product);
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-ONU7173;Initial Catalog=master;Integrated Security=True");
            
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            //new OptianCustomerForm2().ShowDialog();
            Form3 fff = new Form3();
            fff.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Button9_Click(object sender, EventArgs e)
        {
            new AddCatugryForm2().ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = 
                new SqlConnection
                ("Data Source=DESKTOP-ONU7173;Initial Catalog=master;Integrated Security=True");

            SqlCommand sqlCommand = connection.CreateCommand();
            sqlCommand.Connection = connection;
            connection.Open();
            sqlCommand.CommandText = " insert into PRODUCT values(" +catID.Text+ ",'" + prName.Text +"',"+ price.Text + "," + quantity.Text+ ") ";
            sqlCommand.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("success");
            //insert into products values('',,'')


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.productTableAdapter.Fill(this.masterDataSet.Product);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection connection =
                new SqlConnection
                ("Data Source=DESKTOP-ONU7173;Initial Catalog=master;Integrated Security=True");

            SqlCommand sqlCommand = connection.CreateCommand();
            sqlCommand.Connection = connection;
            connection.Open();
            sqlCommand.CommandText = "update PRODUCT set PRODNAME='" + prName.Text + "', PRODPRICE=" + price.Text + " , PRODQUANTITY=" + quantity.Text + ", CATEID=" + catID.Text + " where PRODID=" + prodID.Text + ";";
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
            sqlCommand.CommandText = "delete from PRODUCT where PRODID=" + prodID.Text + ";";
            sqlCommand.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("success");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string q = "select  CUSTID, count(PRODID) as s from CUSTOMER_PRODUCT group by CUSTID order by s DESC";
            da = new SqlDataAdapter(q, cc);
            ds = new DataSet();
            da.Fill(ds);
            cc.Close();
            if (ds.Tables[0].Rows.Count != 0)
            {
                dataGridView4.DataSource = ds.Tables[0];

            }

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string q = "select PRODID,PRODNAME,PRODQUANTITY from PRODUCT where PRODQUANTITY<50";
            da = new SqlDataAdapter(q, cc);
            ds = new DataSet();
            da.Fill(ds);
            cc.Close();
            if (ds.Tables[0].Rows.Count != 0)
            {
                dataGridView3.DataSource = ds.Tables[0];

            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string n = textBox6.Text;
            SqlConnection Sqlconnection =
                new SqlConnection
                ("Data Source=DESKTOP-ONU7173;Initial Catalog=master;Integrated Security=True");
            int rr;
            SqlCommand Command = Sqlconnection.CreateCommand();
            Command.Connection = Sqlconnection;
            Sqlconnection.Open();
            Command.CommandText = "select PRODID from PRODUCT where PRODNAME= '" + n + "'";
            SqlDataReader r = Command.ExecuteReader();
            //Command.ExecuteNonQuery();
            if (r.Read())
            {
                /*int q;
                q = int.Parse(qunatity.Text);*/
                string s = r["PRODID"].ToString();
                //rr = int.Parse(s) - q;
                //if (rr < 0)
                //{
                MessageBox.Show("id is:" + s);
                //return;
                //}

                //MessageBox.Show("success");


                // rr = int.Parse( r["PRODQUANTITY"].ToString );

            }

            Sqlconnection.Close();
        }
    }
}
