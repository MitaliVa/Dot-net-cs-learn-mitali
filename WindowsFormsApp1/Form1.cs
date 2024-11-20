using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private object dateTimePickerJoiningDate;

        public Form1()
        {
            InitializeComponent();
            InitializePlaceholder();
        }

        private const string FirstNamePlaceholder = "First Name";
        private const string LastNamePlaceholder = "Last Name";


        private void InitializePlaceholder()
        {
            empFirstName.Text = FirstNamePlaceholder;
            empLastName.Text = LastNamePlaceholder;

            empFirstName.Enter += new EventHandler(RemovePlaceholder);
            empFirstName.Leave += new EventHandler(AddPlaceholder);

            empLastName.Enter += new EventHandler(RemovePlaceholder);
            empLastName.Leave += new EventHandler(AddPlaceholder);
        }

        private void RemovePlaceholder(object sender, EventArgs e)
        {
            TextBox currentTextBox = sender as TextBox;

            if (currentTextBox != null)
            {
                if (currentTextBox.Text == FirstNamePlaceholder || currentTextBox.Text == LastNamePlaceholder)
                {
                    currentTextBox.Text = "";
                }
            }
        }

        private void AddPlaceholder(object sender, EventArgs e)
        {
            TextBox currentTextBox = sender as TextBox;

            if (currentTextBox != null)
            {
                if (string.IsNullOrWhiteSpace(currentTextBox.Text))
                {
                    if (currentTextBox == empFirstName)
                    {
                        currentTextBox.Text = FirstNamePlaceholder;
                    }
                    else if (currentTextBox == empLastName)
                    {
                        currentTextBox.Text = LastNamePlaceholder;
                    }

                }
            }
        }


        private void btnFetchAllEmployees_Click(object sender, EventArgs e)
        {
            List<Employee> employees = Employee.GetAllEmployees();

            dgvEmployees.DataSource = employees;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void addEmpData_Click(object sender, EventArgs e)
        {
            string firstName = empFirstName.Text;
            string lastName = empLastName.Text;
            DateTime dateOfJoining = joiningDate.Value;

            bool success = Employee.AddNewEmployeeData(firstName, lastName, dateOfJoining);

            if (success)
            {
                MessageBox.Show("New employee added successfully!");
            }
            else
            {
                MessageBox.Show("Error adding new employee.");
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
