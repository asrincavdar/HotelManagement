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
    public partial class EmployeeData : Form
    {
        public EmployeeData()
        {
            InitializeComponent();

        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-A7LS68L;Initial Catalog=""Hotel Management"";Integrated Security=True");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void link_findEmployee_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BindData();
        }

        void BindData()
        {
            SqlCommand cnn = new SqlCommand("Select * from emptab", conn);

            SqlDataAdapter adapter = new SqlDataAdapter(cnn);

            DataTable table = new DataTable();

            adapter.Fill(table);

            EmployeeList.DataSource = table;

        }

        private void button_addNew_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cnn = new SqlCommand("Insert into emptab(employeename,phone,address,department,hiredate) values(@employeename,@phone,@address, @department, @hiredate)", conn);

            cnn.Parameters.AddWithValue("@EmployeeName", text_empName.Text);
            cnn.Parameters.AddWithValue("@Phone", text_empPhone.Text);
            cnn.Parameters.AddWithValue("@Address", text_empAddress.Text);
            cnn.Parameters.AddWithValue("@Department", text_empDepartment.Text);
            cnn.Parameters.AddWithValue("@HireDate", dateTimePicker1.Value);
            cnn.ExecuteNonQuery();
            conn.Close();
            BindData();
        }


        private void EmployeeList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void text_empName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-A7LS68L;Initial Catalog=""Hotel Management"";Integrated Security=True");

            conn.Open();
            SqlCommand cnn = new SqlCommand("Delete emptab where employeename=@employeename", conn);
            cnn.Parameters.AddWithValue("@EmployeeName", text_empName.Text);



            cnn.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Data Deleted");
        }

        private void EmployeeData_Load(object sender, EventArgs e)
        {
            
        }

    }
}



