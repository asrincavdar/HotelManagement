using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace HotelManagement
{
    public partial class Settings : Form, IDisposable
    {
        public static Settings? instance;
        public Settings()
        {
            InitializeComponent();
            InitializeUI("UIMode");
            instance = this;
        }

        public void InitializeUI(string key)
        {
            try
            {
                var uiMode = ConfigurationManager.AppSettings[key];
                if (uiMode == "light")
                {
                    button_changeMode.Text = "Enable Dark Mode";
                    label1.Text = "Light Mode is Enabled";
                    this.ForeColor = Color.FromArgb(47, 54, 64);
                    this.BackColor = Color.FromArgb(245, 246, 250);
                    ConfigurationManager.AppSettings[key] = "dark";
                }
                else
                {
                    button_changeMode.Text = "Enable Light Mode";
                    label1.Text = "Dark Mode is Enabled";
                    this.ForeColor = Color.FromArgb(245, 246, 250);
                    this.BackColor = Color.FromArgb(47, 54, 64);
                    ConfigurationManager.AppSettings[key] = "light";
                }
            }

            catch
            {

            }

        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }

        public void button_changeMode_Click(object sender, EventArgs e)
        {
            InitializeUI("UIMode");
            Homepage homepage = new Homepage();
            homepage.Show();
            this.Hide();
        }

    }
}
