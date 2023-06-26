﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RegistrationValidation
{
    public partial class RegistrationPage : System.Web.UI.Page

    {

        protected System.Web.UI.HtmlControls.HtmlInputFile File1;

        protected System.Web.UI.HtmlControls.HtmlInputButton Submit1;

        protected void Page_Load(object sender, EventArgs e)

        {

        }

        protected void Button1_Click(object sender, EventArgs e)

        {

            message.Text = "Hello " + username.Text + " ! ";

            message.Text = message.Text + " <br/> You have successfuly Registered with the following details.";

            ShowUsername.Text = username.Text;

            ShowEmail.Text = email.Text;

            if (RadioButton1.Checked)

            {

                ShowGender.Text = RadioButton1.Text;

            }

            else ShowGender.Text = RadioButton2.Text;

            var courses = "";

            if (CheckBox1.Checked)

            {

                courses = CheckBox1.Text + " ";

            }

            if (CheckBox2.Checked)

            {

                courses += CheckBox2.Text + " ";

            }

            if (CheckBox3.Checked)

            {

                courses += CheckBox3.Text;

            }

            ShowCourse.Text = courses;

            ShowUsernameLabel.Text = "User Name";

            ShowEmailLabel.Text = "Email ID";

            ShowGenderLabel.Text = "Gender";

            ShowCourseLabel.Text = "Courses";

            username.Text = "";

            email.Text = "";

            RadioButton1.Checked = false;

            RadioButton2.Checked = false;

            CheckBox1.Checked = false;

            CheckBox2.Checked = false;

            CheckBox3.Checked = false;

        }

    }

}