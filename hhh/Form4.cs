using System;

using System.Data;

using System.Windows.Forms;
using System.Data.SqlClient;

namespace hhh
    
{
    
    public partial class Form4 : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-ONU7173;Initial Catalog=master;Integrated Security=True");
        SqlDataAdapter da;
        DataSet ds;
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string q = textBox1.Text;
            da = new SqlDataAdapter(q, connection);
            ds=new DataSet(); 
            da.Fill(ds);
            connection.Close();
            if (ds.Tables[0].Rows.Count!=0)
            {
                dataGridView1.DataSource = ds.Tables[0];

            }

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
