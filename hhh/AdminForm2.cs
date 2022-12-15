using System;

using System.Windows.Forms;

namespace hhh
{
    public partial class AdminForm2 : Form
    {
        public AdminForm2()
        {
            InitializeComponent();
        }
        public string conString = "Data Source=DESKTOP-ONU7173;Initial Catalog=master;Integrated Security=True";
        private void Button1_Click(object sender, EventArgs e)
        {
           
            if (textBox1.Text=="ahmed" &&textBox2.Text=="1234" )
            {
                OptianAdminForm2 f=new OptianAdminForm2();
                f.Show();
                this.Hide();
                //new OptianAdminForm2().ShowDialog();
                
            }
            else
            {
                MessageBox.Show("incorrect data  user: ahmed  pass: 1234");
            }
        }

        private void AdminForm2_Load(object sender, EventArgs e)
        {

        }
    }
}
