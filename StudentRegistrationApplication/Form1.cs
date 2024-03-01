using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistrationApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] NameMonths = { "January", "Febuary", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            for (int i = 0; i < 12; i++)
            {
                Month.Items.Add(NameMonths[i]);
            }
            for (int i = 1; i <= 31; i++)
            {
               Day.Items.Add(i);
            }
            
            for(int i = 1500;i <= 2024; i++)
            {
                Year.Items.Add(i);
            }
           
           
        }

        private void LastNameTextbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lastname_Click(object sender, EventArgs e)
        {

        }

        private void RegisterStudentButton_Click(object sender, EventArgs e)
        {
            string lastName = LastNameBox.Text;
            string firstName = FirstNameBox.Text;
            string middleName = MiddleNameBox.Text;
            string Gender;
            if (Male.Checked == true)
            {
                Gender = "Male";
            }
            else
            {
                Gender = "Female";
            }
            MessageBox.Show("Name :  " + lastName + " " + firstName + " " + middleName +
                "\n" + "Gender : " + Gender +
                "\n" + "Date of Birth : " + Month.Text + " " + Day.Text +  " " + Year.Text);
                       
                             
        }

        private void Day_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FemaleRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
