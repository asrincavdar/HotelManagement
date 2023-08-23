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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label3 = new Label();
            label4 = new Label();
            button4 = new Button();
            button_logOut = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Font = new Font("Bahnschrift SemiCondensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.DarkSlateGray;
            button1.Location = new Point(311, 125);
            button1.Name = "button1";
            button1.Size = new Size(175, 32);
            button1.TabIndex = 0;
            button1.Text = "Rooms";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Bahnschrift SemiCondensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.DarkSlateGray;
            button2.Location = new Point(311, 181);
            button2.Name = "button2";
            button2.Size = new Size(175, 32);
            button2.TabIndex = 1;
            button2.Text = "Employees";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Bahnschrift SemiCondensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.DarkSlateGray;
            button3.Location = new Point(311, 240);
            button3.Name = "button3";
            button3.Size = new Size(175, 32);
            button3.TabIndex = 2;
            button3.Text = "Customers";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.AliceBlue;
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(122, 34);
            label3.TabIndex = 5;
            label3.Text = "VS Hotel";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.AliceBlue;
            label4.Location = new Point(12, 43);
            label4.Name = "label4";
            label4.Size = new Size(233, 34);
            label4.TabIndex = 6;
            label4.Text = "Management App";
            // 
            // button4
            // 
            button4.Font = new Font("Bahnschrift SemiCondensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.DarkSlateGray;
            button4.Location = new Point(311, 297);
            button4.Name = "button4";
            button4.Size = new Size(175, 32);
            button4.TabIndex = 7;
            button4.Text = "Settings";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button_logOut
            // 
            button_logOut.Font = new Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button_logOut.ForeColor = Color.Salmon;
            button_logOut.Location = new Point(351, 350);
            button_logOut.Name = "button_logOut";
            button_logOut.Size = new Size(94, 29);
            button_logOut.TabIndex = 8;
            button_logOut.Text = "Log Out";
            button_logOut.UseVisualStyleBackColor = true;
            button_logOut.Click += button_logOut_Click;
            // 
            // Homepage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            ClientSize = new Size(800, 450);
            Controls.Add(button_logOut);
            Controls.Add(button4);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Homepage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VS Hotel | Home";
            Load += Homepage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Label label3;
        private Label label4;
        private Button button4;
        private Button button_logOut;
    }
}