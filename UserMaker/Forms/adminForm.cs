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
using System.Windows.Forms;
using UserMaker.Class;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.DirectoryServices;
using System.Threading;
using Newtonsoft.Json.Linq;

namespace UserMaker.Forms
{
	public partial class adminForm : Form
	{
		
		private string firstName;
		private string lastName;
		private string domain;
		private System.Threading.Timer syncTimer;  //kept getting ambigious reference error
		string samName;
		string upnName;
		private System.Windows.Forms.ProgressBar progressBar;
		
		public adminForm(string firstName, string lastName, string domain, System.Windows.Forms.ProgressBar progressBar)
		{
			InitializeComponent();

			
			this.firstName = firstName;
			this.lastName = lastName;
			this.domain = domain;
			this.progressBar = progressBar;
		
			adminPassword.KeyDown += new KeyEventHandler(adminPassword_KeyDown); // used for initiating btn click action after typing password and hitiing 'Enter' key in admin login form.
			
		
		}
		#region ADMIN LOGIN
		private async void adminBtnOKClick(object sender, EventArgs e)
		{
						 // to stop the async process when certain conditions are met
			//string[] propertiesToLoad = { "targetAddress" };

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

			if (string.IsNullOrEmpty(lastName))
			{
				upnName = firstName + "@" + domain;
				samName = firstName;
			}

			else
			{
				upnName = firstName + "." + lastName + "@" + domain;
				samName = firstName + "." + lastName;
			}

			this.Close();

			using (DirectoryEntry entry = new DirectoryEntry("LDAP://com.au"))
			using (DirectorySearcher searcher = new DirectorySearcher(entry))
			{
				searcher.Filter = "(targetAddress=" + "SMTP:" + samName + "@detconnect.mail.onmicrosoft.com)";
				SearchResult routingResult = searcher.FindOne();

				if (routingResult == null)
				{
					MessageBox.Show("Mail box not found");

					bool mailboxCreated = false;


					while (!mailboxCreated)
					{

						try
						{
							mailboxCreated= await MailBoxConnect.GetMailboxInfo(userName, password, firstName, lastName, domain);

							progressBar.Visible = true;
							//progressLabel.Visible = true;


							if (mailboxCreated)
							{
								progressBar.Visible = false;
								//progressLabel.Visible = false;

								MessageBox.Show("Mailbox creation completed or error occured.(ONLY FOR TESTING)");
							}

							if (!mailboxCreated)
							{
								await ShowProgressDuringDelay(10000, progressBar);
								
								await Task.Delay(10000);
							}
						}

						catch (Exception ex)
						{
							MessageBox.Show($"Try again. Unexpected error: {ex.Message}");
							
							progressBar.Visible = false;
							//progressLabel.Visible= false;
							mailboxCreated = true;	

						}

					}
				}
				else 

				{
					MessageBox.Show("MailBox already exists.?? pls check");
				}
			
			}

				progressBar.Visible = false;
	
		}
		#endregion


		#region For progress bar 
		private async Task ShowProgressDuringDelay(int delayMilliseconds, System.Windows.Forms.ProgressBar progressBar)
		{
			int delayIncrement = 100; // Update interval in milliseconds
			int totalSteps = delayMilliseconds / delayIncrement;
			int currentStep = 0;
			
			progressBar.Maximum = totalSteps;
			progressBar.Value = 0;
			
			

			for (int i = 0; i < totalSteps; i++)
			{
				await Task.Delay(delayIncrement);
				currentStep++;
				progressBar.Value = currentStep;
			}

			progressBar.Value = progressBar.Maximum; // Ensure progress bar is full at the end
		}
		#endregion

		#region Various event handlers
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
		#endregion
	}
}
