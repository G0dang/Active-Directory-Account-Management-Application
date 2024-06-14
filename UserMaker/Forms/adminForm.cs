using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserMaker.Class;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace UserMaker.Forms
{
	public partial class adminForm : Form
	{
		private string firstName;
		private string lastName;
		private string domain;
		private string orgUnit;
		private string password;
		private string newPassword;

		public adminForm(string newPassword, string firstName, string lastName, string domain, string orgUNit)
		{
			InitializeComponent();
			this.firstName = firstName;
			this.lastName = lastName;

			this.domain = domain;
			this.orgUnit = orgUnit;

			adminPassword.KeyDown += new KeyEventHandler(adminPassword_KeyDown); // used for initiating btn click action after typing password and hitiing 'Enter' key in admin login form.



		}

		
		private void adminBtnOKClick(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(usernameBox.Text))
			{
				label_username.ForeColor = Color.OrangeRed;

				MessageBox.Show("Fill the required fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			label_username.ForeColor = Color.Black;

			if (string.IsNullOrEmpty(adminPassword.Text))
			{
				label_password.ForeColor = Color.OrangeRed;
				MessageBox.Show("Fill the required fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			label_password.ForeColor = Color.Black;

			string userName = usernameBox.Text;
			string password = adminPassword.Text;


			MailBoxConnect.GetMailboxInfo(userName, password, newPassword, firstName, lastName, domain, orgUnit);


		}

		private void adminBtnCancelClick(object sender, EventArgs e)
		{
			this.Close();
		}

		private void adminPassword_TextChanged(object sender, EventArgs e)
		{

		}

		private void adminPassword_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				// Trigger the search button click event
				adminBtnOKClick(this, new EventArgs());

				// Prevent the beep sound on Enter key press
				e.Handled = true;
				e.SuppressKeyPress = true;
				
			}
		}

		private void materialProgressBar1_Click(object sender, EventArgs e)
		{

		}
	}
}
