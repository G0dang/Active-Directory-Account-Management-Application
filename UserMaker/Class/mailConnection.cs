using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Security;
using System.DirectoryServices.ActiveDirectory;
using PowerShell = System.Management.Automation.PowerShell;
using static System.Resources.ResXFileRef;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Page;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Spin;
using System.Drawing.Text;
using System.DirectoryServices;
using UserMaker.Forms;
using System.Threading;

namespace UserMaker
{
	public class MailBoxConnect
	{
		//private ProgressBar pb = Application.OpenForms["detmoldApp"].Controls["progressBar_Mail"] as ProgressBar;
		
		
		
		public static async Task GetMailboxInfo(string userName, string password, string firstName, string lastName, string domain, CancellationToken cancelAsync)
		{
			// Configuration variables
			string exchangeServer = "sgmail00.internal.detmold.com.au";
			string strUserPrincipalName, strSamAccountName;
			// Create a secure password

			SecureString securePassword = new SecureString();
			foreach (char c in password) //password is user credential password
			{
				securePassword.AppendChar(c);
			}

			// Create credential object
			PSCredential credential = new PSCredential($"{userName}", securePassword);

			// Create WSMan connection info
			Uri connectionUri = new Uri($"http://{exchangeServer}/PowerShell/");

			WSManConnectionInfo connectionInfo = new WSManConnectionInfo(connectionUri, "http://schemas.microsoft.com/powershell/Microsoft.Exchange", credential);


			connectionInfo.AuthenticationMechanism = AuthenticationMechanism.Kerberos;
			

			if (string.IsNullOrEmpty(lastName))
			{
				strUserPrincipalName = firstName + "@" + domain;
				strSamAccountName = firstName;
			}

			else
			{
				strUserPrincipalName = firstName + "." + lastName + "@" + domain;
				strSamAccountName = firstName + "." + lastName;
			}

			// Create runspace
			using (Runspace rs = RunspaceFactory.CreateRunspace(connectionInfo))
			{
				try
				{
					MessageBox.Show("Connection Established");

					await Task.Run(() => rs.Open(), cancelAsync);

					MessageBox.Show("Mailbox creation started");

					using (DirectoryEntry entry = new DirectoryEntry("LDAP://internal.detmold.com.au"))
					using (DirectorySearcher searcher = new DirectorySearcher(entry))
					{
						// Initialize DirectoryEntry and DirectorySearcher objects
						searcher.Filter = "(userPrincipalName=" + strUserPrincipalName + ")";
						SearchResult result = searcher.FindOne();

						if (result != null)
						{
							MessageBox.Show("User Found");

							PowerShell powershell = PowerShell.Create();
							powershell.Runspace = rs;

							powershell.AddCommand("Enable-RemoteMailbox")
									  .AddParameter("Identity", strUserPrincipalName)
									  .AddParameter("RemoteRoutingAddress", $"{strSamAccountName}@detconnect.mail.onmicrosoft.com");


							var results = await Task.Run(() =>
							{
								var invokeResults = powershell.Invoke();
								if (cancelAsync.IsCancellationRequested)
								{
									cancelAsync.ThrowIfCancellationRequested();
								}
								return invokeResults;
							}, cancelAsync);

							if (powershell.HadErrors)
							{
								foreach (var errorRecord in powershell.Streams.Error)
								{
									MessageBox.Show($"Error: {errorRecord.ToString()}");
								}
								if (!cancelAsync.IsCancellationRequested)
								{
									MessageBox.Show("Errors occurred during mailbox creation. Stopping task.");
									return;
								}
							}

							MessageBox.Show($"Mail for the user: {strSamAccountName} created succesfully");
							
							if (powershell.HadErrors)
							{
								foreach (var errorRecord in results)
								{
									MessageBox.Show($"Error: {errorRecord.ToString()}");
								}

								if (!cancelAsync.IsCancellationRequested) //will stop the asyn task 
								{
									MessageBox.Show("Errors occurred during mailbox creation. Stopping task.");
									return;
								}
															
							}

							if (!cancelAsync.IsCancellationRequested) //will stop the async task when user is found and the mailbox is created.
							{
								cancelAsync.ThrowIfCancellationRequested();
							}
						}

						else

						{
							MessageBox.Show($"User: {strSamAccountName.Replace("."," ")} not found. Will try again in 30 seconds...");

						}

						rs.Close();
						
					}
				}

				catch (OperationCanceledException)
				{
					MessageBox.Show("Task was cancelled.");
				}

				catch (Exception ex)
				{

					MessageBox.Show($"Unexpected error: {ex.Message}");
					rs.Close();
				}

				finally
				{
					rs.Close();
					rs.Dispose();
					
				}

			}
				
			
		}
	}
}

