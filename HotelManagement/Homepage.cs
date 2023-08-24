using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement
{
    public partial class Homepage : Form
    {


        public Homepage()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            EmployeeData form4 = new EmployeeData();
            form4.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
            this.Close();
        }

        private void Homepage_Load(object sender, EventArgs e)
        {

        }

        private void button_logOut_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Do you want to Log Out?", "LogOut", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                Form1 form1 = new Form1();
                form1.Show();
                this.Close();
            }
            else
            {
                this.Show();
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Booking booking = new Booking();
            booking.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Rooms form3 = new Rooms();
            form3.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            EmployeeData form4 = new EmployeeData();
            form4.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
            this.Close();
        }
    }

}


