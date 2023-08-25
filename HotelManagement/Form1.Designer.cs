namespace HotelManagement
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            text_id = new TextBox();
            text_pass = new TextBox();
            label3 = new Label();
            label4 = new Label();
            button_exit = new Button();
            button_login = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiBold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(231, 188);
            label1.Name = "label1";
            label1.Size = new Size(88, 28);
            label1.TabIndex = 0;
            label1.Text = "User ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiBold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkSlateGray;
            label2.Location = new Point(231, 244);
            label2.Name = "label2";
            label2.Size = new Size(114, 28);
            label2.TabIndex = 1;
            label2.Text = "Password";
            label2.Click += label2_Click;
            // 
            // text_id
            // 
            text_id.BorderStyle = BorderStyle.FixedSingle;
            text_id.Location = new Point(355, 189);
            text_id.Name = "text_id";
            text_id.Size = new Size(157, 27);
            text_id.TabIndex = 2;
            // 
            // text_pass
            // 
            text_pass.BorderStyle = BorderStyle.FixedSingle;
            text_pass.Location = new Point(355, 245);
            text_pass.Name = "text_pass";
            text_pass.Size = new Size(157, 27);
            text_pass.TabIndex = 3;
            text_pass.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.LightSlateGray;
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(122, 34);
            label3.TabIndex = 4;
            label3.Text = "VS Hotel";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.LightSlateGray;
            label4.Location = new Point(12, 43);
            label4.Name = "label4";
            label4.Size = new Size(233, 34);
            label4.TabIndex = 5;
            label4.Text = "Management App";
            // 
            // button_exit
            // 
            button_exit.Cursor = Cursors.Hand;
            button_exit.Font = new Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button_exit.ForeColor = Color.Tomato;
            button_exit.Location = new Point(231, 291);
            button_exit.Name = "button_exit";
            button_exit.Size = new Size(94, 29);
            button_exit.TabIndex = 6;
            button_exit.Text = "Exit";
            button_exit.UseVisualStyleBackColor = true;
            button_exit.Click += button_exit_Click;
            // 
            // button_login
            // 
            button_login.Cursor = Cursors.Hand;
            button_login.Font = new Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button_login.ForeColor = Color.DarkSlateGray;
            button_login.Location = new Point(418, 291);
            button_login.Name = "button_login";
            button_login.Size = new Size(94, 29);
            button_login.TabIndex = 7;
            button_login.Text = "Log In";
            button_login.UseVisualStyleBackColor = true;
            button_login.Click += button_login_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(763, 515);
            Controls.Add(button_login);
            Controls.Add(button_exit);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(text_pass);
            Controls.Add(text_id);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " VSHotel | Login";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox text_id;
        private TextBox text_pass;
        private Label label3;
        private Label label4;
        private Button button_exit;
        private Button button_login;
    }
}