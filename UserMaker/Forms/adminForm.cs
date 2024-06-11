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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace UserMaker.Forms
{
	public partial class adminForm : Form
	{
		public adminForm()
		{
			InitializeComponent();
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
				MailBoxConnect.GetMailboxInfo(userName, password);
			
			
		}
	
		private void adminBtnCancelClick(object sender, EventArgs e)
		{
			this.Close();

		}

	}
}
