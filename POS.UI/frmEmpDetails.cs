using POS.BusinessRules;
using POS.Model;

namespace POS.UI
{
    public partial class frmEmpDetails : Form
    {
        ClsEmployeeDataSystem objEmployeeDataSys = new ClsEmployeeDataSystem();

        public frmEmpDetails()
        {
            InitializeComponent();
        }

        public void btnsave_Click(object sender, EventArgs e)
        {
            Employee objEmployee;
            objEmployee = new Employee();
            //objEmployee.Name = txtEmployeeName_TextChanged.Text.Trim();
            //objEmployee.EmployeeId= Convert.ToInt32(txtEmployeeId_TextChanged.Text.Trim());

        }

        //private void txtEmployeeName_TextChanged(object sender, EventArgs e)
        //{

        //}

        //private void textBox1_TextChanged(object sender, EventArgs e)
        //{

        //}

        //private void txtLocation_TextChanged(object sender, EventArgs e)
        //{

        //}

        //private void txtEmployeeId_TextChanged(object sender, EventArgs e)
        //{

        //}

        //private void frmEmployee_Enter(object sender, EventArgs e)
        //{

        //}

        private void btnsave_Click_1(object sender, EventArgs e)
        {
            // Construct the given input after validation

            Employee objemployee;
            objemployee = new Employee();
            objemployee.Name = txtName.Text.Trim();
            //objemployee.EmployeeId = Convert.ToInt32(txtEmployeeId.Text.Trim());
            objemployee.EmployeeId = txtEmployeeId.Text.Trim();
            objemployee.PhoneNumber = txtPhoneNumber.Text.Trim();
            objemployee.Location = txtLocation.Text.Trim();

            bool status = objEmployeeDataSys.AddEmployee(objemployee);
            if (status)
            {

                MessageBox.Show("Record Saved");
                var ans = objEmployeeDataSys.DisplayEmployee();
                dgvdisplay.DataSource = ans;

            }

            // Access Business Class

            // Execute the Insertion

            // Report the result           

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmployeeId_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvdisplay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblemployeeid_Click(object sender, EventArgs e)
        {

        }

        private void lblphonenumber_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Employee objemployee;
            objemployee = new Employee();
            objemployee.Name = txtName.Text.Trim();
            //objemployee.EmployeeId = Convert.ToInt32(txtEmployeeId.Text.Trim());
            objemployee.EmployeeId = txtEmployeeId.Text.Trim();
            objemployee.PhoneNumber = txtPhoneNumber.Text.Trim();
            objemployee.Location = txtLocation.Text.Trim();

            bool status = objEmployeeDataSys.RemoveEmployee(objemployee);
            if (status)
            {

                MessageBox.Show("Record deleted");
                var ans = objEmployeeDataSys.DisplayEmployee();
                dgvdisplay.DataSource = ans;

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Employee objemployee;
            objemployee = new Employee();
            objemployee.Name = txtName.Text.Trim();
            //objemployee.EmployeeId = Convert.ToInt32(txtEmployeeId.Text.Trim());
            objemployee.EmployeeId = txtEmployeeId.Text.Trim();
            objemployee.PhoneNumber = txtPhoneNumber.Text.Trim();
            objemployee.Location = txtLocation.Text.Trim();

            bool status = objEmployeeDataSys.AddAgainEmployee(objemployee);
            if (status)
            {

                MessageBox.Show("Record updated");
                var ans = objEmployeeDataSys.DisplayEmployee();
                dgvdisplay.DataSource = ans;

            }
        }
    }
}