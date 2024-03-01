namespace StudentRegistrationApplication
{
    partial class Form1
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
            this.LastNameBox = new System.Windows.Forms.TextBox();
            this.MiddleNameBox = new System.Windows.Forms.TextBox();
            this.FirstNameBox = new System.Windows.Forms.TextBox();
            this.Male = new System.Windows.Forms.RadioButton();
            this.Female = new System.Windows.Forms.RadioButton();
            this.Month = new System.Windows.Forms.ComboBox();
            this.Day = new System.Windows.Forms.ComboBox();
            this.Year = new System.Windows.Forms.ComboBox();
            this.StudentRegForm = new System.Windows.Forms.Label();
            this.Lastname = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.Label();
            this.MiddleName = new System.Windows.Forms.Label();
            this.RegisterStudentButton = new System.Windows.Forms.Button();
            this.Gender = new System.Windows.Forms.Label();
            this.DateofBirth = new System.Windows.Forms.Label();
            this.Programbox = new System.Windows.Forms.ComboBox();
            this.Selectprogram = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LastNameBox
            // 
            this.LastNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameBox.Location = new System.Drawing.Point(56, 88);
            this.LastNameBox.Name = "LastNameBox";
            this.LastNameBox.Size = new System.Drawing.Size(172, 26);
            this.LastNameBox.TabIndex = 0;
            this.LastNameBox.Text = "S";
            this.LastNameBox.TextChanged += new System.EventHandler(this.LastNameTextbx_TextChanged);
            // 
            // MiddleNameBox
            // 
            this.MiddleNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MiddleNameBox.Location = new System.Drawing.Point(56, 238);
            this.MiddleNameBox.Name = "MiddleNameBox";
            this.MiddleNameBox.Size = new System.Drawing.Size(172, 26);
            this.MiddleNameBox.TabIndex = 0;
            this.MiddleNameBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // FirstNameBox
            // 
            this.FirstNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameBox.Location = new System.Drawing.Point(56, 161);
            this.FirstNameBox.Name = "FirstNameBox";
            this.FirstNameBox.Size = new System.Drawing.Size(172, 26);
            this.FirstNameBox.TabIndex = 1;
            this.FirstNameBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Male
            // 
            this.Male.AutoSize = true;
            this.Male.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Male.Location = new System.Drawing.Point(149, 287);
            this.Male.Name = "Male";
            this.Male.Size = new System.Drawing.Size(61, 24);
            this.Male.TabIndex = 2;
            this.Male.TabStop = true;
            this.Male.Text = "Male";
            this.Male.UseVisualStyleBackColor = true;
            this.Male.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Female
            // 
            this.Female.AutoSize = true;
            this.Female.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Female.Location = new System.Drawing.Point(220, 287);
            this.Female.Name = "Female";
            this.Female.Size = new System.Drawing.Size(80, 24);
            this.Female.TabIndex = 3;
            this.Female.TabStop = true;
            this.Female.Text = "Female";
            this.Female.UseVisualStyleBackColor = true;
            this.Female.CheckedChanged += new System.EventHandler(this.FemaleRadioButton_CheckedChanged);
            // 
            // Month
            // 
            this.Month.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Month.FormattingEnabled = true;
            this.Month.Location = new System.Drawing.Point(167, 354);
            this.Month.Name = "Month";
            this.Month.Size = new System.Drawing.Size(94, 28);
            this.Month.TabIndex = 4;
            this.Month.Text = "Month";
            // 
            // Day
            // 
            this.Day.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Day.FormattingEnabled = true;
            this.Day.Location = new System.Drawing.Point(56, 354);
            this.Day.Name = "Day";
            this.Day.Size = new System.Drawing.Size(94, 28);
            this.Day.TabIndex = 5;
            this.Day.Text = "Day";
            this.Day.SelectedIndexChanged += new System.EventHandler(this.Day_SelectedIndexChanged);
            // 
            // Year
            // 
            this.Year.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Year.FormattingEnabled = true;
            this.Year.Location = new System.Drawing.Point(276, 354);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(90, 28);
            this.Year.TabIndex = 6;
            this.Year.Text = "Year";
            // 
            // StudentRegForm
            // 
            this.StudentRegForm.AutoSize = true;
            this.StudentRegForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentRegForm.Location = new System.Drawing.Point(262, 28);
            this.StudentRegForm.Name = "StudentRegForm";
            this.StudentRegForm.Size = new System.Drawing.Size(222, 20);
            this.StudentRegForm.TabIndex = 7;
            this.StudentRegForm.Text = "Student Registration Form";
            this.StudentRegForm.Click += new System.EventHandler(this.label1_Click);
            // 
            // Lastname
            // 
            this.Lastname.AutoSize = true;
            this.Lastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lastname.Location = new System.Drawing.Point(52, 55);
            this.Lastname.Name = "Lastname";
            this.Lastname.Size = new System.Drawing.Size(100, 20);
            this.Lastname.TabIndex = 8;
            this.Lastname.Text = "Last name*";
            this.Lastname.Click += new System.EventHandler(this.Lastname_Click);
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstName.Location = new System.Drawing.Point(52, 129);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(106, 20);
            this.FirstName.TabIndex = 9;
            this.FirstName.Text = "First  name*";
            // 
            // MiddleName
            // 
            this.MiddleName.AutoSize = true;
            this.MiddleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MiddleName.Location = new System.Drawing.Point(52, 203);
            this.MiddleName.Name = "MiddleName";
            this.MiddleName.Size = new System.Drawing.Size(117, 20);
            this.MiddleName.TabIndex = 10;
            this.MiddleName.Text = "Middle name*";
            // 
            // RegisterStudentButton
            // 
            this.RegisterStudentButton.BackColor = System.Drawing.Color.Crimson;
            this.RegisterStudentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterStudentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterStudentButton.ForeColor = System.Drawing.Color.White;
            this.RegisterStudentButton.Location = new System.Drawing.Point(127, 487);
            this.RegisterStudentButton.Name = "RegisterStudentButton";
            this.RegisterStudentButton.Size = new System.Drawing.Size(153, 32);
            this.RegisterStudentButton.TabIndex = 11;
            this.RegisterStudentButton.Text = "Register Student";
            this.RegisterStudentButton.UseVisualStyleBackColor = false;
            this.RegisterStudentButton.Click += new System.EventHandler(this.RegisterStudentButton_Click);
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gender.Location = new System.Drawing.Point(52, 287);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(76, 20);
            this.Gender.TabIndex = 12;
            this.Gender.Text = "Gender*";
            this.Gender.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // DateofBirth
            // 
            this.DateofBirth.AutoSize = true;
            this.DateofBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateofBirth.Location = new System.Drawing.Point(52, 324);
            this.DateofBirth.Name = "DateofBirth";
            this.DateofBirth.Size = new System.Drawing.Size(119, 20);
            this.DateofBirth.TabIndex = 13;
            this.DateofBirth.Text = "Date of Birth*";
            this.DateofBirth.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // Programbox
            // 
            this.Programbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Programbox.FormattingEnabled = true;
            this.Programbox.Location = new System.Drawing.Point(56, 436);
            this.Programbox.Name = "Programbox";
            this.Programbox.Size = new System.Drawing.Size(341, 28);
            this.Programbox.TabIndex = 14;
            this.Programbox.Text = "Select Program";
            this.Programbox.SelectedIndexChanged += new System.EventHandler(this.Programbox_SelectedIndexChanged);
            // 
            // Selectprogram
            // 
            this.Selectprogram.AutoSize = true;
            this.Selectprogram.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Selectprogram.Location = new System.Drawing.Point(52, 403);
            this.Selectprogram.Name = "Selectprogram";
            this.Selectprogram.Size = new System.Drawing.Size(151, 20);
            this.Selectprogram.TabIndex = 15;
            this.Selectprogram.Text = "Program to apply*";
            this.Selectprogram.Click += new System.EventHandler(this.Selectprogram_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(860, 558);
            this.Controls.Add(this.Selectprogram);
            this.Controls.Add(this.Programbox);
            this.Controls.Add(this.DateofBirth);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.RegisterStudentButton);
            this.Controls.Add(this.MiddleName);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.Lastname);
            this.Controls.Add(this.StudentRegForm);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.Day);
            this.Controls.Add(this.Month);
            this.Controls.Add(this.Female);
            this.Controls.Add(this.Male);
            this.Controls.Add(this.FirstNameBox);
            this.Controls.Add(this.MiddleNameBox);
            this.Controls.Add(this.LastNameBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LastNameBox;
        private System.Windows.Forms.TextBox MiddleNameBox;
        private System.Windows.Forms.TextBox FirstNameBox;
        private System.Windows.Forms.RadioButton Male;
        private System.Windows.Forms.RadioButton Female;
        private System.Windows.Forms.ComboBox Month;
        private System.Windows.Forms.ComboBox Day;
        private System.Windows.Forms.ComboBox Year;
        private System.Windows.Forms.Label StudentRegForm;
        private System.Windows.Forms.Label Lastname;
        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.Label MiddleName;
        private System.Windows.Forms.Button RegisterStudentButton;
        private System.Windows.Forms.Label Gender;
        private System.Windows.Forms.Label DateofBirth;
        private System.Windows.Forms.ComboBox Programbox;
        private System.Windows.Forms.Label Selectprogram;
    }
}

