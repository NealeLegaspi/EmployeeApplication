using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string department = txtDepartment.Text;
            string jobTitle = txtJobTitle.Text;
            double basicSalary = Convert.ToDouble(txtBasicSalary.Text);
            int hoursWorked = Convert.ToInt32(txtHoursWorked.Text);
            double ratePerHour = Convert.ToDouble(txtRatePerHour.Text);

            EmployeeNamespace.PartTimeEmployee employee = new EmployeeNamespace.PartTimeEmployee(firstName, lastName, department, jobTitle, basicSalary);
            txtFirstNamee.Text = employee.FirstName;
            txtLastNamee.Text = employee.LastName;
            
            double basiccSalary = ratePerHour * hoursWorked;
            txtBasicSalary.Text = basiccSalary.ToString();
        }
    }
}
