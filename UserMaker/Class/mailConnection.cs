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

namespace UserMaker
{
	public class MailBoxConnect
	{
		public static void GetMailboxInfo(string userName, string password, string newPassword, string firstName, string lastName, string domain,string orgUnit)
		{
			// Configuration variables
			string exchangeServer = "sgmail00.internal.detmold.com.au";
																		
			string fullName = $"{firstName} {lastName}";

			

			string exOUDN = "OU=Aayush Test,OU=Accounts,DC=internal,DC=detmold,DC=com,DC=au"; 
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
				
			
			
			
			// Create runspace
			using (Runspace rs = RunspaceFactory.CreateRunspace(connectionInfo))
			{

				rs.Open();
				MessageBox.Show("Connection Established");

				// Create PowerShell instance
				PowerShell powershell = PowerShell.Create();
				powershell.Runspace = rs;
				
				//string upn = string.IsNullOrEmpty(lastName) ? $"{firstName}@{domain}" : $"{firstName}.{lastName}@{domain}".Replace(" ", ".");
				//if no lastname fname@domain, else fname.lname@domain
				
				//powershell.AddCommand(File.ReadAllText(@"C:\Users\Aayush.Gurung\OneDrive - Detmold Group\Desktop\script.ps1")).Invoke();

				if (string.IsNullOrEmpty(lastName))
				{
					string upn = $"{firstName}@{domain}";
					string script = "New-RemoteMailbox";
					powershell.AddCommand(script);
					powershell.AddParameter("Name", fullName);
					powershell.AddParameter("FirstName", firstName);
					powershell.AddParameter("$Password", newPassword); //newPassword is the password for new user mail
					powershell.AddParameter("$Domain", domain);
					powershell.AddParameter("$upn", upn);
					powershell.AddParameter("OnPremisesOrganizationalUnit", exOUDN);
					powershell.AddParameter("PrimarySmtpAddress", upn);
				}
				else
				{
					string upn = $"{firstName} {lastName}@{domain}".Replace (" ",".");
					string script = "New-RemoteMailbox";
					powershell.AddCommand(script);
					powershell.AddParameter("Name", fullName);
					powershell.AddParameter("FirstName", firstName);
					powershell.AddParameter("LastName", lastName);
					powershell.AddParameter("Password", securePassword);
					powershell.AddParameter("Domain", domain);
					powershell.AddParameter("UserPrincipalName", upn);
					powershell.AddParameter("OnPremisesOrganizationalUnit", exOUDN);
					powershell.AddParameter("PrimarySmtpAddress", upn);
				}
				//powershell.AddParameter("Anr", "Pay");

				var results = powershell.Invoke();

					//string outResult = $"Script executed successfully.\n\nHere is the list of result \n";
					// Check for errors
					if (powershell.HadErrors)
					{
						foreach (var errorRecord in results)
						{

							MessageBox.Show($"Error: {errorRecord.ToString()}");
						}
					}
					rs.Close();
					// Close the runspace
				
			}
		}
	}
}

