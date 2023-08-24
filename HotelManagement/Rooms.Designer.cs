namespace HotelManagement
{
    partial class Rooms
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
            button_view = new Button();
            button_Delete = new Button();
            button_addNew = new Button();
            text_roomType = new TextBox();
            text_roomNo = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label6 = new Label();
            label7 = new Label();
            roomsList = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)roomsList).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SlateGray;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button_view);
            panel1.Controls.Add(button_Delete);
            panel1.Controls.Add(button_addNew);
            panel1.Controls.Add(text_roomType);
            panel1.Controls.Add(text_roomNo);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.ForeColor = Color.DarkSlateGray;
            panel1.Location = new Point(189, 110);
            panel1.Name = "panel1";
            panel1.Size = new Size(518, 175);
            panel1.TabIndex = 2;
            // 
            // button_view
            // 
            button_view.Font = new Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button_view.ForeColor = Color.SlateGray;
            button_view.Location = new Point(374, 126);
            button_view.Name = "button_view";
            button_view.Size = new Size(125, 29);
            button_view.TabIndex = 11;
            button_view.Text = "View Rooms";
            button_view.UseVisualStyleBackColor = true;
            button_view.Click += button_view_Click;
            // 
            // button_Delete
            // 
            button_Delete.Font = new Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button_Delete.ForeColor = Color.Salmon;
            button_Delete.Location = new Point(198, 126);
            button_Delete.Name = "button_Delete";
            button_Delete.Size = new Size(125, 29);
            button_Delete.TabIndex = 10;
            button_Delete.Text = "Delete Room";
            button_Delete.UseVisualStyleBackColor = true;
            button_Delete.Click += button_Delete_Click;
            // 
            // button_addNew
            // 
            button_addNew.Font = new Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button_addNew.ForeColor = Color.SlateGray;
            button_addNew.Location = new Point(21, 126);
            button_addNew.Name = "button_addNew";
            button_addNew.Size = new Size(125, 29);
            button_addNew.TabIndex = 9;
            button_addNew.Text = "Add Room";
            button_addNew.UseVisualStyleBackColor = true;
            button_addNew.Click += button_addNew_Click;
            // 
            // text_roomType
            // 
            text_roomType.Location = new Point(163, 73);
            text_roomType.Name = "text_roomType";
            text_roomType.Size = new Size(318, 27);
            text_roomType.TabIndex = 6;
            // 
            // text_roomNo
            // 
            text_roomNo.Location = new Point(163, 24);
            text_roomNo.Name = "text_roomNo";
            text_roomNo.Size = new Size(318, 27);
            text_roomNo.TabIndex = 5;
            text_roomNo.TextChanged += text_roomNo_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiBold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(26, 74);
            label2.Name = "label2";
            label2.Size = new Size(99, 22);
            label2.TabIndex = 1;
            label2.Text = "Room Type";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiBold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(26, 25);
            label1.Name = "label1";
            label1.Size = new Size(85, 22);
            label1.TabIndex = 0;
            label1.Text = "Room No";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bahnschrift", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.AliceBlue;
            label6.Location = new Point(12, 43);
            label6.Name = "label6";
            label6.Size = new Size(343, 34);
            label6.TabIndex = 30;
            label6.Text = "Management App | Rooms";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Bahnschrift", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.AliceBlue;
            label7.Location = new Point(12, 9);
            label7.Name = "label7";
            label7.Size = new Size(122, 34);
            label7.TabIndex = 29;
            label7.Text = "VS Hotel";
            // 
            // roomsList
            // 
            roomsList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            roomsList.BackgroundColor = Color.SlateGray;
            roomsList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            roomsList.Location = new Point(283, 321);
            roomsList.Name = "roomsList";
            roomsList.RowHeadersWidth = 51;
            roomsList.RowTemplate.Height = 29;
            roomsList.Size = new Size(339, 334);
            roomsList.TabIndex = 31;
            // 
            // Rooms
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            ClientSize = new Size(917, 699);
            Controls.Add(roomsList);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(panel1);
            Name = "Rooms";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rooms";
            Load += Rooms_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)roomsList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button_view;
        private Button button_Delete;
        private Button button_addNew;
        private TextBox text_roomType;
        private TextBox text_roomNo;
        private Label label2;
        private Label label1;
        private Label label6;
        private Label label7;
        private DataGridView roomsList;
    }
}