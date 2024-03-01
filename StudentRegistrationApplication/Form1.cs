using System;
using System.Collections;
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
            
            for(int i = 1900;i <= 2024; i++)
            {
                Year.Items.Add(i);
            }
            ArrayList programs = new ArrayList();
            programs.Add("Bachelor of Science in Computer Science");
            programs.Add("Bachelor of Science in Information Technology");
            programs.Add("Bachelor of Science in Information System");
            programs.Add("Bachelor of Science in Computer Engineering");

            foreach (string program in programs)
            {
                Programbox.Items.Add(program);
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
            else if(Female.Checked)
            {
                Gender = "Female";
            }
            else
            {
                MessageBox.Show("Please select a  gender. ");
                return;
            }




            MessageBox.Show("Name :  " + lastName + " " + firstName + " " + middleName +
                "\n" + "Gender : " + Gender +
                "\n" + "Date of Birth : " + Month.Text + " " + Day.Text +  " " + Year.Text +
                "\n" + "Course/Program : " + Programbox.Text);
                 
                       
                             
        }

        private void Day_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FemaleRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Programbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Selectprogram_Click(object sender, EventArgs e)
        {

        }
    }
}
