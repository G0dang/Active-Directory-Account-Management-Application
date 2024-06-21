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
		private CancellationTokenSource stopAsync;

		public adminForm(string firstName, string lastName, string domain, System.Windows.Forms.ProgressBar progressBar)
		{
			InitializeComponent();


			this.firstName = firstName;
			this.lastName = lastName;
			this.domain = domain;
			this.progressBar = progressBar;

			adminPassword.KeyDown += new KeyEventHandler(adminPassword_KeyDown); // used for initiating btn click action after typing password and hitiing 'Enter' key in admin login form.
			
		
		}


		private async void adminBtnOKClick(object sender, EventArgs e)
		{

			var stopAsync = new CancellationTokenSource(); // to stop the async process when certain conditions are met
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

			using (DirectoryEntry entry = new DirectoryEntry("LDAP://internal.detmold.com.au"))
			using (DirectorySearcher searcher = new DirectorySearcher(entry))
			{
					searcher.Filter = "(targetAddress=" + "SMTP:" + samName + "@detconnect.mail.onmicrosoft.com)";
					SearchResult routingResult = searcher.FindOne();
					if (routingResult == null)
					{
					MessageBox.Show("MailBox not found. Next step: Creating Mailbox...");
						try
						{
							syncTimer = new System.Threading.Timer(async _ =>
							
							{
								if (stopAsync.Token.IsCancellationRequested)
								{
									return;
								}
								try
								{
									await MailBoxConnect.GetMailboxInfo(userName, password, firstName, lastName, domain, stopAsync.Token);
								}
								catch ( OperationCanceledException)
								{
									MessageBox.Show("Task was cancelled.");
								}
								catch (Exception ex)
								{
									MessageBox.Show($"Unexpected error: {ex.Message}");
								}
								finally
								{
									progressBar.Invoke((MethodInvoker)(() => progressBar.Visible = false));
									
									if (!stopAsync.IsCancellationRequested)
									{
										stopAsync.Cancel();
									}
								}
							}, null, 0, 10000);

							progressBar.Visible = true;
						}

						catch (Exception ex)
						{ 
							MessageBox.Show($"Unexpected error: {ex.Message}");
							progressBar.Visible = false;
						}

					}

								
					else
					{
						MessageBox.Show($"User: {samName.Replace("."," ")} already has a mailbox");

					}

				

				this.Close();
			}
		}

		private void OnFormClosing(object sender, FormClosingEventArgs e)
		{
			if (syncTimer != null)
			{
				syncTimer.Dispose();
			}
			if (stopAsync != null)
			{
				stopAsync.Cancel();
				stopAsync.Dispose();
			}
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
