using System;

using System.Windows.Forms;

namespace hhh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //new customerForm2().ShowDialog();
            customerForm2 f=new customerForm2();
            f.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            AdminForm2 f= new AdminForm2();
            f.Show();
            this.Hide();

            //new AdminForm2().Sh
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
