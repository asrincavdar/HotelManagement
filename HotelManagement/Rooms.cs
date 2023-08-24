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

namespace HotelManagement
{
    public partial class Rooms : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-A7LS68L;Initial Catalog=""Hotel Management"";Integrated Security=True");

        public Rooms()
        {
            InitializeComponent();
        }

        private void text_roomNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_addNew_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Insert into rooms(roomno, roomtype) values(@roomno,@roomtype)", conn);

            cmd.Parameters.AddWithValue("@roomno", int.Parse(text_roomNo.Text));
            cmd.Parameters.AddWithValue("@roomtype", (text_roomType.Text));


            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Data Added");
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-A7LS68L;Initial Catalog=""Hotel Management"";Integrated Security=True");

            conn.Open();
            SqlCommand cnn = new SqlCommand("Delete rooms where RoomNumber=@RoomNumber", conn);
            cnn.Parameters.AddWithValue("@RoomNumber", text_roomNo.Text);



            cnn.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Data Deleted");
        }

        private void button_view_Click(object sender, EventArgs e)
        {
            BindData();
        }

        void BindData()
        {
            SqlCommand cnn = new SqlCommand("Select * from rooms", conn);

            SqlDataAdapter adapter = new SqlDataAdapter(cnn);

            DataTable table = new DataTable();

            adapter.Fill(table);

            roomsList.DataSource = table;

        }

        private void Rooms_Load(object sender, EventArgs e)
        {

        }
    }
}
