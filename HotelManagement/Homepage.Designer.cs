namespace HotelManagement
{
    partial class Homepage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label3 = new Label();
            label4 = new Label();
            button_logOut = new Button();
            button_booking = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.LightSlateGray;
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(122, 34);
            label3.TabIndex = 5;
            label3.Text = "VS Hotel";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.LightSlateGray;
            label4.Location = new Point(12, 43);
            label4.Name = "label4";
            label4.Size = new Size(233, 34);
            label4.TabIndex = 6;
            label4.Text = "Management App";
            // 
            // button_logOut
            // 
            button_logOut.BackColor = Color.AliceBlue;
            button_logOut.Cursor = Cursors.Hand;
            button_logOut.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button_logOut.ForeColor = Color.Tomato;
            button_logOut.Location = new Point(338, 351);
            button_logOut.Name = "button_logOut";
            button_logOut.Size = new Size(125, 35);
            button_logOut.TabIndex = 8;
            button_logOut.Text = "Log Out";
            button_logOut.UseVisualStyleBackColor = false;
            button_logOut.Click += button_logOut_Click;
            // 
            // button_booking
            // 
            button_booking.BackColor = Color.AliceBlue;
            button_booking.Cursor = Cursors.Hand;
            button_booking.Font = new Font("Bahnschrift SemiBold Condensed", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button_booking.ForeColor = Color.DarkSlateGray;
            button_booking.Location = new Point(303, 113);
            button_booking.Name = "button_booking";
            button_booking.Size = new Size(195, 43);
            button_booking.TabIndex = 9;
            button_booking.Text = "Booking";
            button_booking.UseVisualStyleBackColor = false;
            button_booking.Click += button5_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.AliceBlue;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Bahnschrift SemiBold Condensed", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.DarkSlateGray;
            button1.Location = new Point(303, 172);
            button1.Name = "button1";
            button1.Size = new Size(195, 43);
            button1.TabIndex = 10;
            button1.Text = "Rooms";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.BackColor = Color.AliceBlue;
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Bahnschrift SemiBold Condensed", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.DarkSlateGray;
            button2.Location = new Point(303, 230);
            button2.Name = "button2";
            button2.Size = new Size(195, 43);
            button2.TabIndex = 11;
            button2.Text = "Guests";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // button3
            // 
            button3.BackColor = Color.AliceBlue;
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Bahnschrift SemiBold Condensed", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.DarkSlateGray;
            button3.Location = new Point(303, 289);
            button3.Name = "button3";
            button3.Size = new Size(195, 43);
            button3.TabIndex = 12;
            button3.Text = "Settings";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Homepage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button_booking);
            Controls.Add(button_logOut);
            Controls.Add(label4);
            Controls.Add(label3);
            Name = "Homepage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VS Hotel | Home";
            Load += Homepage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Label label4;
        private Button button_logOut;
        private Button button_booking;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}