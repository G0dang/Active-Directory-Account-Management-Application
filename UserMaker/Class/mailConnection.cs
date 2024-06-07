using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Security;

namespace UserMaker.Class
{
	internal class mailConnection
	{
		public class Exchange
		{
			private readonly bool onPrem;
			private PSCredential credential;
			private Runspace localRunSpace;
			private PowerShell powerShell;

			public Exchange(bool onPrem, string userEmail = "NoEmail", string password = "NoPassword")
			{
				this.onPrem = onPrem;
				if (!this.onPrem)
				{
					if (password == "NoPassword" || userEmail == "NoEmail")
						throw new ArgumentException("If using Online Exchange, you must provide a username and password.");
					CreateCredential(password, userEmail);
				}
			}

			private Runspace LocalRunSpace
			{
				get
				{
					if (localRunSpace == null)
					{
						localRunSpace = RunspaceFactory.CreateRunspace();
						localRunSpace.Open();
					}
					return localRunSpace;
				}
			}

			private void CreateCredential(string password, string emailAddress)
			{
				SecureString securePassword = new SecureString();
				foreach (char c in password)
				{
					securePassword.AppendChar(c);
				}
				credential = new PSCredential(emailAddress, securePassword);
			}

			private PowerShell PowerShellInstance
			{
				get
				{
					if (powerShell == null)
					{
						powerShell = PowerShell.Create();
						powerShell.Runspace = LocalRunSpace;

						if (onPrem)
						{
							string exchangeScript = "$Session = New-PSSession -ConfigurationName Microsoft.Exchange -ConnectionUri 'http://sgmail00.internal.detmold.com.au/powershell' -Authentication Kerberos; Import-PSSession $Session";
							powerShell.AddScript(exchangeScript);
							Collection<PSObject> results = powerShell.Invoke();
							foreach (PSObject result in results)
							{
								Console.WriteLine(result.ToString());
							}
						}
						else
						{
							var newSession = powerShell.AddCommand("New-PSSession")
								.AddParameter("ConfigurationName", "Microsoft.Exchange")
								.AddParameter("ConnectionUri", "http://sgmail00.internal.detmold.com.au/powershell")
								.AddParameter("Credential", credential)
								.AddParameter("Authentication", "Basic")
								.AddParameter("AllowRedirection", true)
								.Invoke();

							if (newSession.Count > 0)
							{
								var session = newSession[0];
								powerShell.Commands.Clear();
								Collection<PSObject> results = powerShell
									.AddCommand("Import-PSSession")
									.AddParameter("Session", session)
									.Invoke();

								foreach (PSObject result in results)
								{
									Console.WriteLine(result.ToString());
								}
							}
						}
					}
					return powerShell;
				}
			}

			public void CreateNewRemoteMailbox(string firstName, string lastName, string domain, string password, string onPremisesOrganizationalUnit)
			{
				string upn;
				if (string.IsNullOrWhiteSpace(lastName))
				{
					upn = $"{firstName}@{domain}";
				}
				else
				{
					upn = $"{firstName}.{lastName}@{domain}".Replace(" ", ".");
				}

				string script = $@"
				 $UPN = '{upn}'
				New-RemoteMailbox -Name '{firstName} {lastName}' -FirstName '{firstName}' -LastName '{lastName}' -Password (ConvertTo-SecureString '{password}' -AsPlainText -Force) -UserPrincipalName $UPN -OnPremisesOrganizationalUnit '{onPremisesOrganizationalUnit}' -PrimarySmtpAddress $UPN >$null
				 Write-Host 'Waiting 30 sec...'
				for ($i = 0; $i -lt 30; $i++)
				 {{
                Start-Sleep -Seconds 1
				 }}";

				PowerShellInstance.AddScript(script).Invoke();
			}

			public string RunCommand(string command)
			{
				try
				{
					PowerShellInstance.Commands.Clear();
					PowerShellInstance.AddScript(command);
					PowerShellInstance.Commands.Commands[0].MergeMyResults(PipelineResultTypes.Error, PipelineResultTypes.Output);
					Collection<PSObject> results;
					try
					{
						results = PowerShellInstance.Invoke();
					}
					catch (System.Threading.ThreadAbortException threadError)
					{
						Console.WriteLine("PowerShell script ran into thread error:\n" + threadError.Message);
						return string.Empty;
					}
					string dataToReturn = string.Empty;
					foreach (PSObject result in results)
						dataToReturn += string.Format(result.ToString(), "; ");
					return dataToReturn;
				}
				catch
				{
					return string.Empty;
				}
			}
		}
	}
}

