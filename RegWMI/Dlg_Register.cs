using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace RegWMI
{
    public partial class Dlg_Register : Form
    {
        /// <summary>
        /// When the form is created, check the registry to see if there are values already filled in for the fields. If not then set
        /// the fields to their default values.
        /// </summary>
        public Dlg_Register()
        {
            InitializeComponent();

            if(Registry.CurrentUser.OpenSubKey("SOFTWARE\\Technical Programming", false) != null)
            {
                string regRoot = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Technical Programming", false).ToString();

                try
                {
                    txt_AppName.Text = (string)Microsoft.Win32.Registry.GetValue(regRoot, "Application Name", string.Empty);
                    txt_Name.Text = (string)Microsoft.Win32.Registry.GetValue(regRoot, "Name", string.Empty);

                    num_Year.Value = (int)(Microsoft.Win32.Registry.GetValue(regRoot, "Year", 2015));
                }
                catch (Exception regException)
                {
                    Console.WriteLine("Dialog Registry Exception: " + regException.GetBaseException());
                }
            }
        }

        public string AppName
        {
            get { return txt_AppName.Text; }
        }

        public string YourName
        {
            get { return txt_Name.Text; }
        }

        public int Year
        {
            get { return (int)num_Year.Value; }
        }

        /// <summary>
        /// Validates input of the fields: txt_AppName, txt_Name, num_Year
        /// Changes lbl_DialogTxt if there is an error, if there is no error then the form will close
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_confirm_Click(object sender, EventArgs e)
        {
            lbl_DialogTxt.Text = "";
            lbl_DialogTxt.ForeColor = Color.Red;

            bool error = false;

            if (string.IsNullOrWhiteSpace(txt_AppName.Text))
            {
                lbl_DialogTxt.Text += "Application Name is Empty\n";
                error = true;
            }

            if (string.IsNullOrWhiteSpace(txt_Name.Text))
            {
                lbl_DialogTxt.Text += "Name is Empty\n";
                error = true;
            }

            if (!error)
                Close();
            else
                DialogResult = DialogResult.None;
        }

        private void btn_CancelClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
