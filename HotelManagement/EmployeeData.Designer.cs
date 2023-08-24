namespace HotelManagement
{
    partial class EmployeeData
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            text_empName = new TextBox();
            text_empPhone = new TextBox();
            text_empAddress = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            button_addNew = new Button();
            button_delete = new Button();
            button_close = new Button();
            label5 = new Label();
            link_findEmployee = new LinkLabel();
            EmployeeList = new DataGridView();
            text_empDepartment = new TextBox();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)EmployeeList).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(62, 155);
            label1.Name = "label1";
            label1.Size = new Size(143, 22);
            label1.TabIndex = 0;
            label1.Text = "Employee Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(62, 206);
            label2.Name = "label2";
            label2.Size = new Size(61, 22);
            label2.TabIndex = 1;
            label2.Text = "Phone";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(62, 269);
            label3.Name = "label3";
            label3.Size = new Size(78, 22);
            label3.TabIndex = 2;
            label3.Text = "Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(491, 207);
            label4.Name = "label4";
            label4.Size = new Size(88, 22);
            label4.TabIndex = 3;
            label4.Text = "Hire Date";
            // 
            // text_empName
            // 
            text_empName.Location = new Point(228, 152);
            text_empName.Name = "text_empName";
            text_empName.Size = new Size(481, 27);
            text_empName.TabIndex = 4;
            text_empName.TextChanged += text_empName_TextChanged;
            // 
            // text_empPhone
            // 
            text_empPhone.Location = new Point(228, 206);
            text_empPhone.Name = "text_empPhone";
            text_empPhone.Size = new Size(245, 27);
            text_empPhone.TabIndex = 5;
            // 
            // text_empAddress
            // 
            text_empAddress.Location = new Point(228, 262);
            text_empAddress.Multiline = true;
            text_empAddress.Name = "text_empAddress";
            text_empAddress.Size = new Size(481, 73);
            text_empAddress.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(585, 206);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(124, 27);
            dateTimePicker1.TabIndex = 7;
            // 
            // button_addNew
            // 
            button_addNew.Font = new Font("Bahnschrift SemiBold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button_addNew.ForeColor = Color.DarkSlateGray;
            button_addNew.Location = new Point(228, 412);
            button_addNew.Name = "button_addNew";
            button_addNew.Size = new Size(124, 29);
            button_addNew.TabIndex = 8;
            button_addNew.Text = "Add New";
            button_addNew.UseVisualStyleBackColor = true;
            button_addNew.Click += button_addNew_Click;
            // 
            // button_delete
            // 
            button_delete.Font = new Font("Bahnschrift SemiBold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button_delete.ForeColor = Color.LightCoral;
            button_delete.Location = new Point(410, 412);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(124, 29);
            button_delete.TabIndex = 9;
            button_delete.Text = "Delete";
            button_delete.UseVisualStyleBackColor = true;
            button_delete.Click += button_delete_Click;
            // 
            // button_close
            // 
            button_close.Font = new Font("Bahnschrift SemiBold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button_close.ForeColor = Color.DarkSlateGray;
            button_close.Location = new Point(585, 412);
            button_close.Name = "button_close";
            button_close.Size = new Size(124, 29);
            button_close.TabIndex = 10;
            button_close.Text = "Close";
            button_close.UseVisualStyleBackColor = true;
            button_close.Click += button_close_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(62, 365);
            label5.Name = "label5";
            label5.Size = new Size(107, 22);
            label5.TabIndex = 13;
            label5.Text = "Department";
            // 
            // link_findEmployee
            // 
            link_findEmployee.AutoSize = true;
            link_findEmployee.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            link_findEmployee.LinkColor = Color.Blue;
            link_findEmployee.Location = new Point(630, 457);
            link_findEmployee.Name = "link_findEmployee";
            link_findEmployee.Size = new Size(121, 23);
            link_findEmployee.TabIndex = 15;
            link_findEmployee.TabStop = true;
            link_findEmployee.Text = "Find Employee";
            link_findEmployee.LinkClicked += link_findEmployee_LinkClicked;
            // 
            // EmployeeList
            // 
            EmployeeList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            EmployeeList.BackgroundColor = Color.LightSteelBlue;
            EmployeeList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EmployeeList.Location = new Point(12, 501);
            EmployeeList.Name = "EmployeeList";
            EmployeeList.RowHeadersWidth = 51;
            EmployeeList.RowTemplate.Height = 29;
            EmployeeList.Size = new Size(763, 289);
            EmployeeList.TabIndex = 23;
            EmployeeList.CellContentClick += EmployeeList_CellContentClick;
            // 
            // text_empDepartment
            // 
            text_empDepartment.Location = new Point(228, 364);
            text_empDepartment.Name = "text_empDepartment";
            text_empDepartment.Size = new Size(481, 27);
            text_empDepartment.TabIndex = 24;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bahnschrift", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.AliceBlue;
            label6.Location = new Point(12, 43);
            label6.Name = "label6";
            label6.Size = new Size(519, 34);
            label6.TabIndex = 26;
            label6.Text = "Management App | Employee Data Form";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Bahnschrift", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.AliceBlue;
            label7.Location = new Point(12, 9);
            label7.Name = "label7";
            label7.Size = new Size(122, 34);
            label7.TabIndex = 25;
            label7.Text = "VS Hotel";
            // 
            // EmployeeData
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            ClientSize = new Size(787, 821);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(text_empDepartment);
            Controls.Add(EmployeeList);
            Controls.Add(link_findEmployee);
            Controls.Add(label5);
            Controls.Add(button_close);
            Controls.Add(button_delete);
            Controls.Add(button_addNew);
            Controls.Add(dateTimePicker1);
            Controls.Add(text_empAddress);
            Controls.Add(text_empPhone);
            Controls.Add(text_empName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EmployeeData";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employee Data Form";
            Load += EmployeeData_Load;
            ((System.ComponentModel.ISupportInitialize)EmployeeList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox text_empName;
        private TextBox text_empPhone;
        private TextBox text_empAddress;
        private DateTimePicker dateTimePicker1;
        private Button button_addNew;
        private Button button_delete;
        private Button button_close;
        private Label label5;
        private LinkLabel link_findEmployee;
        private DataGridView EmployeeList;
        private TextBox text_empDepartment;
        private Label label6;
        private Label label7;
    }
}