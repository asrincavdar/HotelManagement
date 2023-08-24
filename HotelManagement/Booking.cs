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
using System.Data.Sql;
namespace HotelManagement
{
    public partial class Booking : Form
    {

        public Booking()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-A7LS68L;Initial Catalog=""Hotel Management"";Integrated Security=True");

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Booking_Load(object sender, EventArgs e)
        {

        }

        private void button_addNew_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Insert into bookingTable(Id,Name,Room,checkin,checkout) values(@Id,@Name,@Room, @checkin, @checkout)", conn);

            cmd.Parameters.AddWithValue("@Id", (text_guestId.Text));
            cmd.Parameters.AddWithValue("@Name", (text_guestName.Text));
            cmd.Parameters.AddWithValue("@Room", int.Parse(text_guestRoom.Text));
            cmd.Parameters.AddWithValue("@checkin", (dateTimePicker1.Value));
            cmd.Parameters.AddWithValue("@checkout", (dateTimePicker2.Value));

            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Data Added");



        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-A7LS68L;Initial Catalog=""Hotel Management"";Integrated Security=True");

            conn.Open();
            SqlCommand cnn = new SqlCommand("Delete bookingTable where Id=@Id", conn);
            cnn.Parameters.AddWithValue("@Id", text_guestId.Text);



            cnn.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Data Deleted");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BindData();
        }

        void BindData()
        {
            SqlCommand cnn = new SqlCommand("Select * from bookingTable", conn);

            SqlDataAdapter adapter = new SqlDataAdapter(cnn);

            DataTable table = new DataTable();

            adapter.Fill(table);

            bookingList.DataSource = table;

        }

        private void text_guestId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

