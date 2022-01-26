using ModelLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FluentValidationDemo
{
    public partial class Form1 : Form
    {
        BindingList<string> errors = new BindingList<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            errorListBox.Clear();

            if (!decimal.TryParse(txtAccountBalance.Text, out decimal accountBalance))
            {
                errors.Add("Account.Balance: Invalid Amount");
                return;
            }

            PersonModel person = new PersonModel();
            person.FirstName = txtFirstName.Text;
            person.LastName = txtLastName.Text;
            person.AccountBalance = decimal.Parse(txtAccountBalance.Text);
            person.DateOfBirth = DTPDateOfBirth.Value;

            // Insert into DB

            MessageBox.Show("Operation Complete");
        }
    }
}
