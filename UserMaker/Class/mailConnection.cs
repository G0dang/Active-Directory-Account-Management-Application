using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Security;

namespace UserMaker
{
	public class MailBoxConnect()
	{
		public static void GetMailboxInfo(string userName, string password)
		{
			// Configuration variables
			string exchangeServer = "sgmail00.internal.detmold.com.au"; // Replace with your Exchange Server name
			//string userName = ""; // Replace with your username
			//string password = ""; // Replace with your password

			// Create a secure password
			SecureString securePassword = new SecureString();
			foreach (char c in password)
			{
				securePassword.AppendChar(c);
			}

			// Create credential object
			PSCredential credential = new PSCredential($"{userName}", securePassword);

			// Create WSMan connection info
			Uri connectionUri = new Uri($"http://{exchangeServer}/PowerShell/");

			WSManConnectionInfo connectionInfo = new WSManConnectionInfo(connectionUri, "http://schemas.microsoft.com/powershell/Microsoft.Exchange", credential);
			connectionInfo.AuthenticationMechanism = AuthenticationMechanism.Kerberos;

			// Create runspace
			using (Runspace runspace = RunspaceFactory.CreateRunspace(connectionInfo))
			{
				runspace.Open();
				
				// Create PowerShell instance
				using (PowerShell powershell = PowerShell.Create())
				{
					powershell.Runspace = runspace;

					// Add cmdlet to the pipeline
					powershell.AddCommand("Get-Mailbox");

					// Invoke the command and get the results
					var results = powershell.Invoke();

					// Check for errors
					if (powershell.HadErrors)
					{
						foreach (var errorRecord in powershell.Streams.Error)
						{
							MessageBox.Show($"Error: {errorRecord.ToString()}");
						}
					}
					else
					{
						string resultInfo = $"Details of the output:\n\n";
						// Display the results
						foreach (var result in results)
						{
							
							resultInfo += $"{result}\n";
							
						}
					MessageBox.Show(resultInfo.ToString());
					}
				}

				// Close the runspace
				runspace.Close();
			}
		}
	}
}

