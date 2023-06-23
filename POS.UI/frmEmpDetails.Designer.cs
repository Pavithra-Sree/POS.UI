namespace POS.UI
{
    partial class frmEmpDetails
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
            frmEmployee = new GroupBox();
            btnAdd = new Button();
            btnDelete = new Button();
            txtName = new TextBox();
            txtPhoneNumber = new TextBox();
            btnsave = new Button();
            txtLocation = new TextBox();
            txtEmployeeId = new TextBox();
            lbllocation = new Label();
            lblphonenumber = new Label();
            lblemployeeid = new Label();
            lblname = new Label();
            dgvdisplay = new DataGridView();
            groupBox1 = new GroupBox();
            frmEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvdisplay).BeginInit();
            SuspendLayout();
            // 
            // frmEmployee
            // 
            frmEmployee.BackColor = SystemColors.ActiveCaption;
            frmEmployee.Controls.Add(btnAdd);
            frmEmployee.Controls.Add(btnDelete);
            frmEmployee.Controls.Add(txtName);
            frmEmployee.Controls.Add(txtPhoneNumber);
            frmEmployee.Controls.Add(btnsave);
            frmEmployee.Controls.Add(txtLocation);
            frmEmployee.Controls.Add(txtEmployeeId);
            frmEmployee.Controls.Add(lbllocation);
            frmEmployee.Controls.Add(lblphonenumber);
            frmEmployee.Controls.Add(lblemployeeid);
            frmEmployee.Controls.Add(lblname);
            frmEmployee.Location = new Point(20, 22);
            frmEmployee.Name = "frmEmployee";
            frmEmployee.Size = new Size(565, 332);
            frmEmployee.TabIndex = 0;
            frmEmployee.TabStop = false;
            frmEmployee.Text = "Employee Form";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(146, 262);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 43);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(276, 262);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 43);
            btnDelete.TabIndex = 0;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(204, 46);
            txtName.Name = "txtName";
            txtName.Size = new Size(243, 27);
            txtName.TabIndex = 11;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(204, 141);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(243, 27);
            txtPhoneNumber.TabIndex = 10;
            // 
            // btnsave
            // 
            btnsave.Location = new Point(406, 262);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(96, 43);
            btnsave.TabIndex = 8;
            btnsave.Text = "save";
            btnsave.UseVisualStyleBackColor = true;
            btnsave.Click += btnsave_Click_1;
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(204, 186);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(243, 27);
            txtLocation.TabIndex = 7;
            // 
            // txtEmployeeId
            // 
            txtEmployeeId.Location = new Point(204, 95);
            txtEmployeeId.Name = "txtEmployeeId";
            txtEmployeeId.Size = new Size(243, 27);
            txtEmployeeId.TabIndex = 9;
            txtEmployeeId.TextChanged += txtEmployeeId_TextChanged;
            // 
            // lbllocation
            // 
            lbllocation.AutoSize = true;
            lbllocation.Location = new Point(74, 186);
            lbllocation.Name = "lbllocation";
            lbllocation.Size = new Size(73, 20);
            lbllocation.TabIndex = 3;
            lbllocation.Text = "Location :";
            // 
            // lblphonenumber
            // 
            lblphonenumber.AutoSize = true;
            lblphonenumber.Location = new Point(74, 141);
            lblphonenumber.Name = "lblphonenumber";
            lblphonenumber.Size = new Size(111, 20);
            lblphonenumber.TabIndex = 2;
            lblphonenumber.Text = "PhoneNumber :";
            lblphonenumber.Click += lblphonenumber_Click;
            // 
            // lblemployeeid
            // 
            lblemployeeid.AutoSize = true;
            lblemployeeid.Location = new Point(74, 95);
            lblemployeeid.Name = "lblemployeeid";
            lblemployeeid.Size = new Size(91, 20);
            lblemployeeid.TabIndex = 1;
            lblemployeeid.Text = "EmployeeId:";
            lblemployeeid.Click += lblemployeeid_Click;
            // 
            // lblname
            // 
            lblname.AutoSize = true;
            lblname.Location = new Point(74, 46);
            lblname.Name = "lblname";
            lblname.Size = new Size(52, 20);
            lblname.TabIndex = 0;
            lblname.Text = "Name:";
            // 
            // dgvdisplay
            // 
            dgvdisplay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdisplay.Location = new Point(720, 22);
            dgvdisplay.Name = "dgvdisplay";
            dgvdisplay.RowHeadersWidth = 51;
            dgvdisplay.RowTemplate.Height = 29;
            dgvdisplay.Size = new Size(603, 332);
            dgvdisplay.TabIndex = 1;
            dgvdisplay.CellContentClick += dgvdisplay_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Location = new Point(20, 411);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(502, 191);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // frmEmpDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1384, 782);
            Controls.Add(groupBox1);
            Controls.Add(dgvdisplay);
            Controls.Add(frmEmployee);
            Name = "frmEmpDetails";
            Text = "Form1";
            frmEmployee.ResumeLayout(false);
            frmEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvdisplay).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox frmEmployee;
        private Label lbllocation;
        private Label lblphonenumber;
        private Label lblemployeeid;
        private Label lblname;
        private TextBox txtLocation;
        private TextBox txtEmployeeName;
        //private TextBoxtxtId;
        private TextBox txtEmployeeId;
        private Button btnsave;
        private TextBox txtPhoneNumber;
        private TextBox txtName;
        private DataGridView dataGridView1;
        private DataGridView dgvdisplay;
        private GroupBox groupBox1;
        private Button btnAdd;
        private Button btnDelete;
    }
}