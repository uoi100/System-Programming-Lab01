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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Opens the Dlg_Register dialog box when the user clicks on the "Register Application" button.
        /// If Dlg_Register returns OK then register the application based on the field specified by Dlg_Register
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_RegClick(object sender, EventArgs e)
        {
            Dlg_Register dlg = new Dlg_Register();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                // Do Something Here related to Registry Keys
                string regRoot = Registry.CurrentUser.OpenSubKey("SOFTWARE", true).ToString() + "\\" + "Technical Programming";

                try
                {
                    Registry.SetValue(regRoot, "Application Name", dlg.AppName, RegistryValueKind.String);
                    Registry.SetValue(regRoot, "Name", dlg.YourName, RegistryValueKind.String);
                    Registry.SetValue(regRoot, "Year", dlg.Year, RegistryValueKind.DWord);
                }
                catch (Exception exception)
                {
                    Console.WriteLine("Registry Modification Exception: " + exception.GetBaseException());
                }
            }
        }
        
        /// <summary>
        /// When the Control Panel Button clicked, open up the Color Dialog to change the color of the Control Panel Title Text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_CtlPnlClick(object sender, EventArgs e)
        {
            if (Registry.CurrentUser.OpenSubKey("Control Panel\\Colors", true) != null)
            {
                if (clr_Dialog.ShowDialog() == DialogResult.OK)
                {

                    string str_rgb = "";

                    str_rgb += clr_Dialog.Color.R.ToString() + " ";
                    str_rgb += clr_Dialog.Color.G.ToString() + " ";
                    str_rgb += clr_Dialog.Color.B.ToString();

                    Registry.SetValue(Registry.CurrentUser.OpenSubKey("Control Panel\\Colors", true).ToString(), "TitleText", str_rgb, RegistryValueKind.String);
                }
            }
        }
    }
}
