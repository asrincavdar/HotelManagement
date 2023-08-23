using System;
using System.Data.SqlClient;
using System.Data;
namespace HotelManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-A7LS68L;Initial Catalog=""Hotel Management"";Integrated Security=True");

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_login_Click(object sender, EventArgs e)
        {
            String user_id, user_password;

            user_id = text_id.Text;
            user_password = text_pass.Text;

            try
            {
                String querry = "SELECT * FROM Login WHERE user_id = '" + text_id.Text + "' AND password = '" + text_pass.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);
                DataTable dt = new DataTable();

                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    user_id = text_id.Text;
                    user_password = text_pass.Text;
                    Homepage form2 = new Homepage();
                    form2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid User ID or Password", "Error", MessageBoxButtons.OK);
                    text_id.Clear();
                    text_pass.Clear();

                }
            }
            catch
            {
                MessageBox.Show("ERROR");
            }
            finally
            {
                conn.Close();
            }


        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Do you want to Exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }
    }
}