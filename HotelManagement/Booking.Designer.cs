namespace HotelManagement
{
    partial class Booking
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
            panel1 = new Panel();
            button1 = new Button();
            button_Delete = new Button();
            button_addNew = new Button();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            text_guestRoom = new TextBox();
            text_guestName = new TextBox();
            text_guestId = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            bookingList = new DataGridView();
            label6 = new Label();
            label7 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bookingList).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SlateGray;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button_Delete);
            panel1.Controls.Add(button_addNew);
            panel1.Controls.Add(dateTimePicker2);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(text_guestRoom);
            panel1.Controls.Add(text_guestName);
            panel1.Controls.Add(text_guestId);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.ForeColor = Color.DarkSlateGray;
            panel1.Location = new Point(213, 120);
            panel1.Name = "panel1";
            panel1.Size = new Size(518, 280);
            panel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.SlateGray;
            button1.Location = new Point(379, 235);
            button1.Name = "button1";
            button1.Size = new Size(125, 29);
            button1.TabIndex = 11;
            button1.Text = "View Guests";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button_Delete
            // 
            button_Delete.Font = new Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button_Delete.ForeColor = Color.Salmon;
            button_Delete.Location = new Point(203, 235);
            button_Delete.Name = "button_Delete";
            button_Delete.Size = new Size(125, 29);
            button_Delete.TabIndex = 10;
            button_Delete.Text = "Delete Guest";
            button_Delete.UseVisualStyleBackColor = true;
            button_Delete.Click += button_Delete_Click;
            // 
            // button_addNew
            // 
            button_addNew.Font = new Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button_addNew.ForeColor = Color.SlateGray;
            button_addNew.Location = new Point(26, 235);
            button_addNew.Name = "button_addNew";
            button_addNew.Size = new Size(125, 29);
            button_addNew.TabIndex = 9;
            button_addNew.Text = "Add Guest";
            button_addNew.UseVisualStyleBackColor = true;
            button_addNew.Click += button_addNew_Click;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(379, 179);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(127, 27);
            dateTimePicker2.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(379, 132);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(127, 27);
            dateTimePicker1.TabIndex = 8;
            // 
            // text_guestRoom
            // 
            text_guestRoom.Location = new Point(103, 154);
            text_guestRoom.Name = "text_guestRoom";
            text_guestRoom.Size = new Size(154, 27);
            text_guestRoom.TabIndex = 7;
            // 
            // text_guestName
            // 
            text_guestName.Location = new Point(163, 73);
            text_guestName.Name = "text_guestName";
            text_guestName.Size = new Size(283, 27);
            text_guestName.TabIndex = 6;
            // 
            // text_guestId
            // 
            text_guestId.Location = new Point(163, 24);
            text_guestId.Name = "text_guestId";
            text_guestId.Size = new Size(283, 27);
            text_guestId.TabIndex = 5;
            text_guestId.TextChanged += text_guestId_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift SemiBold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(279, 182);
            label5.Name = "label5";
            label5.Size = new Size(97, 22);
            label5.TabIndex = 4;
            label5.Text = "Check-Out";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift SemiBold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(279, 137);
            label4.Name = "label4";
            label4.Size = new Size(84, 22);
            label4.TabIndex = 3;
            label4.Text = "Check-In";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift SemiBold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(26, 155);
            label3.Name = "label3";
            label3.Size = new Size(57, 22);
            label3.TabIndex = 2;
            label3.Text = "Room";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiBold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(26, 74);
            label2.Name = "label2";
            label2.Size = new Size(110, 22);
            label2.TabIndex = 1;
            label2.Text = "Guest Name";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiBold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(26, 25);
            label1.Name = "label1";
            label1.Size = new Size(79, 22);
            label1.TabIndex = 0;
            label1.Text = "Guest ID";
            // 
            // bookingList
            // 
            bookingList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            bookingList.BackgroundColor = Color.SlateGray;
            bookingList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            bookingList.Location = new Point(59, 432);
            bookingList.Name = "bookingList";
            bookingList.RowHeadersWidth = 51;
            bookingList.RowTemplate.Height = 29;
            bookingList.Size = new Size(800, 308);
            bookingList.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bahnschrift", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.AliceBlue;
            label6.Location = new Point(12, 43);
            label6.Name = "label6";
            label6.Size = new Size(433, 34);
            label6.TabIndex = 28;
            label6.Text = "Management App | Booking Form";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Bahnschrift", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.AliceBlue;
            label7.Location = new Point(12, 9);
            label7.Name = "label7";
            label7.Size = new Size(122, 34);
            label7.TabIndex = 27;
            label7.Text = "VS Hotel";
            // 
            // Booking
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            ClientSize = new Size(914, 794);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(bookingList);
            Controls.Add(panel1);
            Name = "Booking";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Booking";
            Load += Booking_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bookingList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private TextBox text_guestRoom;
        private TextBox text_guestName;
        private TextBox text_guestId;
        private Button button_addNew;
        private Button button_Delete;
        private Button button1;
        private DataGridView bookingList;
        private Label label6;
        private Label label7;
    }
}