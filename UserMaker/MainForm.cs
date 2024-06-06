using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Text;
using System;
using System.DirectoryServices;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data;
using Microsoft.VisualBasic.ApplicationServices;
using System.Security.AccessControl;
using UserMaker.Class;
using System.Linq.Expressions;
using System.IO;
using MaterialSkin.Controls;
using Newtonsoft.Json;
using RestSharp;
using CsvHelper;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Globalization;
using System.Threading.Tasks;
using System.Net.Security;


//practice for Azure dev ops

namespace UserMaker
{
	public partial class adminLogin : Form
	{
		//establich connection to the Active Directory Folder in the domain
		private const string OUDN = "OU=Aayush Test,OU=Accounts,DC=internal,DC=detmold,DC=com,DC=au";

		//For future purpose
		//OUDN = $"OU={CountryProperty},OU=Users,OU=Accounts,DC=internal,DC=detmold,DC=com,DC=au";

		//this declarations are all the credentials needed for the detmold uat api authentication
		private static readonly string apiBaseUrl = "https://detmoldgroupuat.haloitsm.com";
		
		private static string username = "Aayush Gurung";
		private static string password = "DetmoldGroupUAT2024!";
		private static string clientID = "2c45fe93-3daa-40b2-9533-e2fd19df7dc3";

		private DNFinder dnFinder;
		private SearchComboBox domainFinder;
		private string managerDistinguishedName;
		private string CompanyName;

		public adminLogin()
		{
			InitializeComponent();
			passwordCheckBox.CheckedChanged += checkBox1_CheckedChanged;

			// -= operator below helped stop verifyUser_btnClick method from executing twice when verifying a user's existence in the active directory
			verify.Click -= verifyUser_btnClick;
			verify.Click += verifyUser_btnClick;

			//initially the progressbar is hidden
			progressBar_RM.Visible = false;

			btnClearForm.Click += btnClearForm_Click;

			dnFinder = new DNFinder();

			domainFinder = new SearchComboBox();

		}

		#region MAIN FORM | METHOD/s HERE LOADs ON RUN
		private async void MainForm_Load(object sender, EventArgs e)
		{
			#region Calling Load_RM method and set up asynchronous Task for regional manager loading 
			//using try catch statement to show the progress bar when loading regional manager
			try
			{
				// Show the progress bar
				progressBar_RM.Visible = true;
				progressBar_RM.Style = ProgressBarStyle.Marquee;
				progressBar_RM.MarqueeAnimationSpeed = 30;

				UserInformation[] userInformations = await LoadRegionalManagersAsync();
				UserInformation[] users = userInformations;

				if (users != null && users.Length > 0)
				{
					//sort the list in an alphabetical order
					//using LINQ method to order it alphabetically before binding it to the RMBox.
					users = users.OrderBy(u => u.DisplayName).ToArray();

					RMBox.DisplayMember = "DisplayName";
					RMBox.ValueMember = "DistinguishedName";
					RMBox.DataSource = users;
				}
				else
				{
					MessageBox.Show("Failed to retrieve regional managers data.");
				}
			}
			catch (Exception ex)
			{

				MessageBox.Show($"An error occurred: {ex.Message}");
			}
			finally
			{
				// Hide the progress bar when loading is complete
				progressBar_RM.Visible = false;
				

			}
			#endregion
		}
		#endregion


		#region method will load the regional  manager list
		private void RMBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (RMBox.SelectedItem != null)
			{
				UserInformation selectedUser = (UserInformation)RMBox.SelectedItem;
				string displayName = selectedUser.DisplayName;
				string distinguishedName = selectedUser.DistinguishedName;
				
				
			}
		}
		#endregion


		#region  load the selected item from the addressCSV

		public void UpdateAddressTextBox(string column1, string column2, string column3, string column4, string column5)
		{
			//updating selected address into different fields
			streetBox.Text = column1 ?? "";
			cityBox.Text = column2 ?? "";
			stateBox.Text = column3 ?? "";
			countryBox.Text = column4 ?? "";
			zipBox.Text = column5 ?? "";
		}
		private void addressList_BtnClick(object sender, EventArgs e)
		{

			// Create an instance of addressCSV form
			addressCSV addressCSVForm = new addressCSV();

			// Subscribe to the RowSelected event of the addressCSV form
			addressCSVForm.RowSelected += AddressCSVForm_RowSelected;

			// Show the addressCSV form
			addressCSVForm.Show();
		}

		private void AddressCSVForm_RowSelected(object sender, string rowData)
		{
			//using "|" as a delimiter because the address contains comma's and other characters

			string[] columns = rowData.Split(new string[] { "|" }, StringSplitOptions.None);

			// Update the TextBox with the selected row's data
			try
			{
				string column1 = columns.Length > 0 ? columns[0] : "";
				string column2 = columns.Length > 1 ? columns[1] : "";
				string column3 = columns.Length > 2 ? columns[2] : "";
				string column4 = columns.Length > 3 ? columns[3] : "";
				string column5 = columns.Length > 4 ? columns[4] : "";

				// Update the TextBoxes with the selected row's data
				UpdateAddressTextBox(columns[0], columns[1], columns[2], columns[3], columns[4]);
			}
			catch
			{
				MessageBox.Show("Error");
			}
		}
		#endregion


		#region creating a task for regional manager so that it does not block the UI while loading the data from the database
		private async Task<UserInformation[]> LoadRegionalManagersAsync()
		{
			For_RegionalManager regionalManagerLoader = new For_RegionalManager();
			return await Task.Run(() => regionalManagerLoader.Load_RM());
		}
		#endregion


		#region VARIOUS Event Handlers
		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}
		private void organisationalUnit_comboBox(object sender, EventArgs e)
		{

		}

		private void ouList_Click(object sender, EventArgs e)
		{
		}

		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click_1(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void domainList_SelectedIndexChanged(object sender, EventArgs e)
		{
		}


		#endregion


		#region CODE TO VERIFY IF THE USER IS IN THE DIRECTORY
		private void verifyUser_btnClick(object sender, EventArgs e)
		{
			// Determine user identity based on first name and last name
			string UPN, Pre2000;
			if (string.IsNullOrEmpty(inputLNAME.Text))
			{
				UPN = inputFNAME.Text + "@" + domainList.Text;
				Pre2000 = inputFNAME.Text;
			}
			else
			{
				UPN = inputFNAME.Text + "." + inputLNAME.Text + "@" + domainList.Text;
				Pre2000 = inputFNAME.Text + "." + inputLNAME.Text;
			}

			// Initialize DirectoryEntry and DirectorySearcher objects
			using (DirectoryEntry entry = new DirectoryEntry("LDAP://internal.detmold.com.au"))
			using (DirectorySearcher searcher = new DirectorySearcher(entry))
			{
				// Set the filter to search for user with the provided UPN
				searcher.Filter = "(userPrincipalName=" + UPN + ")";
				SearchResult result = searcher.FindOne();
				if (result != null)
				{
					MessageBox.Show("UPN/Email already exists");
					return;
				}

				// Set the filter to search for user with the provided pre-Windows 2000 account name
				searcher.Filter = "(sAMAccountName=" + Pre2000 + ")";
				result = searcher.FindOne();
				if (result != null)
				{
					MessageBox.Show("Username already Exists");
					return;
				}
			}

			MessageBox.Show("User not found. Continue to create new user");
		}
		#endregion


		#region For TICKET SEARCH button click event
		private async void searchTicket_btnClick(object sender, EventArgs e)
		{
			string ticketID = ticketID_textbox.Text;
			if (string.IsNullOrEmpty(ticketID))
			{
				MessageBox.Show("Enter the ticket ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			string accessToken = await AuthenticateAsync(username, password, clientID);

			if (accessToken != null)
			{
				var ticket = await GetTicketAsync(ticketID, accessToken);
				
				
				if (ticket != null)
				{
					string ticketInfo = $"Ticket ID: {ticket.id}\nTicket Summary: {ticket.summary}\nDetails:\n";

					bool isNewUserRequest = false;


					var cityDict = new CityDictionary();
					string postcode = string.Empty;
					string city = string.Empty;

					#region for separating employee addressssss
					//compare the string of the name in the customfields. If the string matches, display and fill the values accordingly.
					foreach (var field in ticket.customfields)
					{

						if (field.name == "CFEmployeeAddress")
						{
							string address = field.display;
							//checking if the address in the ticket contains a city name as well as the post code
							city = cityDict.Cities.Keys.FirstOrDefault(c => address.Contains(c)) ?? ""; //c=>address.Contains(c) is used as a predicate

							if (!string.IsNullOrEmpty(city))
							{
								ticketInfo += $"City: {city}\n";
								cityBox.Text = city;

								// Find the postcode in the address
								if (cityDict.Cities.TryGetValue(city, out var postcodes))
								{
									postcode = postcodes.FirstOrDefault(pc => address.Contains(pc)) ?? "";

									if (!string.IsNullOrEmpty(postcode))
									{
										ticketInfo += $"Postcode: {postcode}\n";
										zipBox.Text = postcode;

										// Remove city and postcode from address
										address = address.Replace(city, "").Replace(postcode, "").Trim();
									}
								}
													
							}
							else
							{
								// Check for empty string key (where the address does not copntain city name but has post code)
								if (cityDict.Cities.TryGetValue("", out var postcodes))
								{
									postcode = postcodes.FirstOrDefault(pc => address.Contains(pc)) ?? "";

									if (!string.IsNullOrEmpty(postcode))
									{
										ticketInfo += $"Postcode: {postcode}\n";
										zipBox.Text = postcode;

										// Remove postcode from address
										address = address.Replace(postcode, "").Trim();
									}

									cityBox.Text = ""; // No specific city found
								}
								else
								{
									cityBox.Text = "";
									zipBox.Text = "";
								}
							}
							// Update the street address
							streetBox.Text = address.Trim();
						}
						#endregion

						#region Populating textboxes with the information from the ticket
						//populating text boxes here by grabbing the details from the ticket
						if (field.name == "CFfirstName")
						{
							inputFNAME.Text = field.display.Trim();
						}
						if (field.name == "CFlastName")
						{
							inputLNAME.Text = field.display.Trim();
						}
						if (field.name == "CFJobTitle")
						{
							jTitle.Text = field.display.Trim();

						}
						if (field.name == "CFEmployeeCountry")
						{
							countryBox.Text = field.display.Trim();
							OUBox.Text = field.display.Trim();
						}
						if (field.name == "CFEmployeeState")
						{
							stateBox.Text = field.display.Trim();
						}
						#endregion

						#region searching the DN of the manager name we got from the ticket.

						if (field.name == "CFEmployeeManager")
						{
							if (!string.IsNullOrEmpty(field.display))
							{
								RMBox.Enabled = false; //disable the reginal manager combobox.
								string managerName = field.display;

								// Find the distinguished name of the manager
								managerDistinguishedName = dnFinder.FindUserDistinguishedName(managerName);

								// Check if the distinguished name was found
								if (managerDistinguishedName != null)
								{
									// Set the display manager name in the box but the Dn will be supplied to update the user attribute
									tempBox.Text = managerName;
									ticketInfo += $"{field.name}: {managerDistinguishedName}\n";

								}
							}
							else
							{
								// Handle the case where the manager was not found
								MessageBox.Show("Manager not found. Select manager name from the list manually", "Note", MessageBoxButtons.OK, MessageBoxIcon.Error);
							}
						}

						#endregion

						#region To use company name for the searching the domain 
						if (field.name=="CFEmployeeCompany")
						{
							
							CompanyName = field.display;
							ticketInfo += $"{field.name}: {field.display}\n";
							string compName = CompanyName;

							compName = compName.Replace(" ", "");
							domainFinder.SelectComboBoxItemContains(domainList,compName);
						}
						#endregion

						if (field.name == "CFEmployeeAddress")
						{
							ticketInfo += $"{field.name}: {field.display}\n";
							isNewUserRequest = true;
						}
					}

					if (!isNewUserRequest)
					{
						ticketInfo += "This ticket is not a new user request";
					}

					MessageBox.Show(ticketInfo, "Ticket Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
		}
		#endregion


		#region CODE FOR THE 'CREATE USER' BUTTON
		private void btnCreateUser_Click(object sender, EventArgs e)
		{

			#region check empty field where input is required
			if (string.IsNullOrWhiteSpace(inputFNAME.Text))
			{
				//highlight the text field
				fName.ForeColor = Color.OrangeRed;
				MessageBox.Show("Please fill the highlighted field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
				// Exit the method to prevent further processing
			}
			fName.ForeColor = Color.Black;

			if (string.IsNullOrWhiteSpace(domainList.Text))
			{
				dMain.ForeColor = Color.OrangeRed;
				MessageBox.Show("Please select a domain from the list", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			dMain.ForeColor = Color.Black;


			if (string.IsNullOrWhiteSpace(passwordBox.Text))
			{
				passWord.ForeColor = Color.OrangeRed;
				MessageBox.Show("Please create a unique password from the the password generater or create your unique own", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			passWord.ForeColor = Color.Black;


			if (string.IsNullOrWhiteSpace(OUBox.Text))
			{
				orgUnit.ForeColor = Color.OrangeRed;
				MessageBox.Show("Please select a organisational unit from the list", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			orgUnit.ForeColor = Color.Black;


			//if (string.IsNullOrWhiteSpace(RMBox.Text))
			//{
			//	reportingManager.ForeColor = Color.OrangeRed;
			//	MessageBox.Show("Please select a reporting manager from the list", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			//	return;
			//}
			//reportingManager.ForeColor = Color.Black;

			if (string.IsNullOrWhiteSpace(disclaimerSuffix.Text))
			{
				discSuffix.ForeColor = Color.OrangeRed;
				MessageBox.Show("Please select a Disclaimer Suffix for the user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			discSuffix.ForeColor = Color.Black;


			if (string.IsNullOrWhiteSpace(cCenter.Text))
			{
				costCenter.ForeColor = Color.OrangeRed;
				MessageBox.Show("Please select a Cost Center for the user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			costCenter.ForeColor = Color.Black;

			if (string.IsNullOrWhiteSpace(streetBox.Text) &&
				string.IsNullOrWhiteSpace(cityBox.Text) &&
				string.IsNullOrWhiteSpace(stateBox.Text) &&
				string.IsNullOrWhiteSpace(countryBox.Text) &&
				string.IsNullOrWhiteSpace(zipBox.Text))
			{
				userAddress.ForeColor = Color.OrangeRed;
				MessageBox.Show("Please select an address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			userAddress.ForeColor = Color.Black;
			#endregion

			#region creating UPN,sAMAccount Name, directory path and so on....
			string UPN, Pre2000;
			if (string.IsNullOrEmpty(inputLNAME.Text))
			{
				UPN = inputFNAME.Text + "@" + domainList.Text;
				Pre2000 = inputFNAME.Text;
			}
			else
			{
				UPN = inputFNAME.Text + "." + inputLNAME.Text + "@" + domainList.Text;
				Pre2000 = inputFNAME.Text + "." + inputLNAME.Text;
			}
			using (DirectoryEntry entry = new DirectoryEntry("LDAP://internal.detmold.com.au"))
			using (DirectorySearcher searcher = new DirectorySearcher(entry))
			{
				// Set the filter to search for user with the provided UPN
				searcher.Filter = "(userPrincipalName=" + UPN + ")";
				SearchResult result = searcher.FindOne();
				if (result != null)
				{
					MessageBox.Show("User already Exists. Unable to create duplicate user");
					return;
				}

				// Set the filter to search for user with the provided pre-Windows 2000 account name
				searcher.Filter = "(sAMAccountName=" + Pre2000 + ")";
				result = searcher.FindOne();
				if (result != null)
				{
					MessageBox.Show("User already Exists. Unable to create duplicate user");
					return;
				}
			}
			#endregion

			#region update the users attribute values in the active directory
			try
			{
				// Create a DirectoryEntry object for the OU
				DirectoryEntry ou = new DirectoryEntry("LDAP://" + OUDN);

				// Creating a new user object in the Organisational Unit (OU)
				DirectoryEntry newUser = ou.Children.Add("CN=" + inputFNAME.Text + " " + inputLNAME.Text, "user");


				// Set user attributes //Unknown user attributes 
				newUser.Properties["givenName"].Value = inputFNAME.Text;
				newUser.Properties["mail"].Value = UPN;
				newUser.Properties["userPrincipalName"].Value = UPN;
				newUser.Properties["samAccountName"].Value = Pre2000;


				// When a user does not have a last name. Do not update the attributes
				// ! inverts the function of the statement.
				if (!String.IsNullOrEmpty(inputLNAME.Text))
				{
					newUser.Properties["sn"].Value = inputLNAME.Text;
					newUser.Properties["displayName"].Value = inputFNAME.Text + " " + inputLNAME.Text;

				}

				//newUser.Properties["countryCode"].Value = cCode.Text; //getting error here because the attribute only accepts numeric values

				if (!String.IsNullOrEmpty(streetBox.Text))
				{
					newUser.Properties["streetAddress"].Value = streetBox.Text;
				}
				if (!String.IsNullOrEmpty(cityBox.Text))
				{
					newUser.Properties["l"].Value = cityBox.Text;
				}
				if (!String.IsNullOrEmpty(stateBox.Text))
				{
					newUser.Properties["st"].Value = stateBox.Text;
				}
				if (!String.IsNullOrEmpty(countryBox.Text))
				{
					newUser.Properties["co"].Value = countryBox.Text;
				}
				if (!String.IsNullOrEmpty(zipBox.Text))
				{
					newUser.Properties["postalCode"].Value = zipBox.Text;
				}

				if (!String.IsNullOrEmpty("disclaimerSuffix"))
				{
					newUser.Properties["scriptPath"].Value = $"Disclaimer.exe {disclaimerSuffix.Text}";
				}

				newUser.Properties["company"].Value = CompanyName;
				newUser.Properties["ou"].Value = OUBox.Text;
				newUser.Properties["title"].Value = jTitle.Text;

				if (!String.IsNullOrEmpty(tempBox.Text))
				{
					newUser.Properties["manager"].Value = managerDistinguishedName;
				}
				else
				{
					#region [REGIONAL MANAGER ATTRIBUTE] Previously selected regional manager from the list and updated the attribute 
					//but now this may not be need as we have loaded the manager name from the ticket and have created generated the DN name.
					//We have retrieved the DN of the manager from the reginal manager class.
					//update 1: regional manager will be supplied through the regional manager list selection if the ticket returns empty manager name

					if (RMBox.SelectedItem != null)
					{
						UserInformation selectedUser = (UserInformation)RMBox.SelectedItem;
						string distinguishedNameOfManager = selectedUser.DistinguishedName;
						newUser.Properties["manager"].Value = distinguishedNameOfManager;
					}
					#endregion
}
				//calling CountryCode Class in here. 

				UserMaker.Class.CountryCode countryCodeUpdater = new UserMaker.Class.CountryCode();
				countryCodeUpdater.UpdateCountryCodeInActiveDirectory(countryBox, newUser);

				


				// Save the user object to Active Directory

				newUser.CommitChanges();

				MessageBox.Show("User created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			#endregion

		}
		#endregion


		#region MaterialSkin event handlers, NEXT BUTTON IN PANEL 1
		private void materialExpansionPanel1_ValidationButton_Click(object sender, EventArgs e) //this is the next button in panel 1
		{
			#region Checking if the required fields are empty before moving into the next step.
			if (string.IsNullOrWhiteSpace(inputFNAME.Text))
			{
				//highlight the text field
				fName.ForeColor = Color.OrangeRed;
				MessageBox.Show("Please fill the highlighted field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

				MessageBox.Show("inside if");

				return;


				// Exit the method to prevent further processing
			}
			fName.ForeColor = Color.Black; //to reset the font color to black if it was highlighted previously.
			materialExpansionPanel1.Collapse = false;
			

			if (string.IsNullOrWhiteSpace(domainList.Text))
			{
				dMain.ForeColor = Color.OrangeRed;
				MessageBox.Show("Please select a domain from the list", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				materialExpansionPanel1.Collapse = false;
				materialExpansionPanel2.Collapse = true;
				return;
			}
			dMain.ForeColor = Color.Black;


			if (string.IsNullOrWhiteSpace(passwordBox.Text))
			{
				passWord.ForeColor = Color.OrangeRed;
				MessageBox.Show("Please create a unique password from the the password generater or create your unique own", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				materialExpansionPanel1.Collapse = false;
				return;
			}
			passWord.ForeColor = Color.Black;


			if (string.IsNullOrWhiteSpace(disclaimerSuffix.Text))
			{
				discSuffix.ForeColor = Color.OrangeRed;
				MessageBox.Show("Please select a Disclaimer Suffix for the user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				materialExpansionPanel1.Collapse = false;
				return;
			}
			discSuffix.ForeColor = Color.Black;


			#endregion



			materialExpansionPanel2.Location = new Point(11, 64);
			materialExpansionPanel2.Size = new Size(895, 689);
			materialExpansionPanel1.Collapse = true;
			materialExpansionPanel2.Collapse = false;

			btnAdminLogin.Location = new Point(33, 476);
			btnCreateUser.Location = new Point(542, 476);
			btnClearForm.Location = new Point(767, 420);
			



		}
		private void materialExpansionPanel2_SaveClick(object sender, EventArgs e) //this is 
		{

		}
		private void materialExpansionPanel2_Click(object sender, EventArgs e)
		{

		}

		//click event on the first panel.
		//the following will expand or collapse the two panels in the form resepectively. 
		//If one form is expanded, the other form will collapse and relocate and resize to an appropriate dimensions.

		#endregion


		#region CODE FOR 'CLEAR' BUTTON


		private void btnClearForm_Click(object sender, EventArgs e)
		{

			ClearFields wipeAll = new ClearFields();

			wipeAll.ClearControls(Controls);

			if (materialExpansionPanel2.Collapse == false)
			{
				materialExpansionPanel2.Collapse = false;
			}
			else
			{
				materialExpansionPanel2.Collapse = true;
			}
			materialExpansionPanel1.Collapse = false;

			// clear button will also clear the highlights showing the missing field
			fName.ForeColor = Color.Black;
			dMain.ForeColor = Color.Black;
			passWord.ForeColor = Color.Black;
			orgUnit.ForeColor = Color.Black;
			discSuffix.ForeColor = Color.Black;
			costCenter.ForeColor = Color.Black;
			reportingManager.ForeColor = Color.Black;
		}



		#endregion


		#region Generating unique passsword and code for the checkbox
		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			//clear passwordtextbox when the check box is unchecked

			if (!passwordCheckBox.Checked)
			{
				// Clear the text of the passwordBox
				passwordBox.Text = "";
			}
			//same if statement is also written after the password generater code below



			// Set the desired length of the password
			int length = 12; // Example length

			// Generate the password
			string password = CreatePassword(length);

			passwordBox.Text = password;   //filling the password text box with the newly generated password

			string CreatePassword(int length) //random password generator
			{
				const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890~!@#$%^&*()_+";
				StringBuilder res = new StringBuilder(); // Changed StringBuilder declaration
				Random rnd = new Random();
				while (0 < length--)
				{
					res.Append(valid[rnd.Next(valid.Length)]);
				}
				return res.ToString();
			}
			//clear passwordtextbox when the check box is unchecked
			if (!passwordCheckBox.Checked)
			{
				// Clear the text of the passwordBox
				passwordBox.Text = "";
			}
		}

		#endregion


		#region textbox event handlers

		private void copy_btnClick(object sender, EventArgs e)
		{
			Clipboard.SetText(passwordBox.Text);
			//this copies the content in the 'passwordBox' text box
		}


		private void street_Textbox(object sender, EventArgs e)
		{

		}

		private void city_TextBox(object sender, EventArgs e)
		{

		}

		private void state_TextBox(object sender, EventArgs e)
		{

		}

		private void Country_TextBox(object sender, EventArgs e)
		{

		}

		private void ZIP_TextBox(object sender, EventArgs e)
		{

		}


		private void lastname_TextChanged(object sender, EventArgs e)
		{

		}
		#region some more Event Handlers for various text boxes
		private void progressBar1_Click(object sender, EventArgs e)
		{

		}
		private void ticketID_textbox_TextChanged(object sender, EventArgs e)
		{

		}
		private void materialExpansionPanel_Step1(object sender, PaintEventArgs e)
		{

		}

		private void materialExpansionPanel_Step2(object sender, PaintEventArgs e)
		{

		}

		private void materialLabel1_Click(object sender, EventArgs e)
		{

		}


		private void textBox3_TextChanged(object sender, EventArgs e)
		{


		}

		private void inputFNAME_TextChanged(object sender, EventArgs e)
		{


		}

		private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
		{

		}

		private void payrollID_TextChanged(object sender, EventArgs e)
		{


		}

		private void textBox5_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox7_TextChanged(object sender, EventArgs e)
		{

		}
		private void cCode_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void cCenter_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
		#endregion

		#endregion


		#region Button click event for organisational units.


		private void ou_BtnClick(object sender, EventArgs e)
		{
			#region DIRECTLY SEARCH FOR THE ORGANISATIONAL UNITS FROM THE DIRECTORY
			// Instantiate the class to retrieve organizational units
			For_Organisational_unit extractOU = new For_Organisational_unit();

			// Retrieve the organizational units
			string[] organizationalUnits = extractOU.Load_OU();

			// Populate the ComboBox with the retrieved organizational units
			if (organizationalUnits != null)
			{

				OUBox.Items.AddRange(organizationalUnits);
				//MessageBox.Show(organizationalUnits);
			}
			else
			{
				MessageBox.Show("Failed to retrieve organizational units data.");
			}
			#endregion

		}

		#endregion


		#region some code to collapse and expand the materaialSKIN expansion panels.
		private void materialExpansionPanel1_panelClick(object sender, EventArgs e)
		{
			if (materialExpansionPanel1.Collapse == false)
			{
				materialExpansionPanel2.Location = new Point(14, 351);
				materialExpansionPanel2.Size = new Size(892, 403);

				materialExpansionPanel2.Collapse = true;
				btnAdminLogin.Location = new Point(11, 415);
				btnCreateUser.Location = new Point(547, 421);
				btnClearForm.Location = new Point(767, 420);
			}
			else
			{
				//when panel2 is expanded, we move the location of three buttons so that it is not overshadowed by it (expansionpanel)
				materialExpansionPanel2.Location = new Point(11, 64);
				materialExpansionPanel2.Size = new Size(892, 338);

				materialExpansionPanel2.Collapse = false;

				btnAdminLogin.Location = new Point(33, 476);
				btnCreateUser.Location = new Point(542, 476);
				btnClearForm.Location = new Point(753, 476);
			}
		}

		private void materialExpansionPanel2_panelClick(object sender, EventArgs e)
		{
			if (materialExpansionPanel1.Collapse == false)
			{
				materialExpansionPanel2.Location = new Point(11, 64);
				materialExpansionPanel2.Size = new Size(895, 689);

				materialExpansionPanel1.Collapse = true;
				materialExpansionPanel2.Collapse = false;

				btnAdminLogin.Location = new Point(33, 476);
				btnCreateUser.Location = new Point(542, 476);
				btnClearForm.Location = new Point(753, 476);
			}
			else if (materialExpansionPanel1.Collapse == true)
			{
				materialExpansionPanel2.Location = new Point(11, 64);
				materialExpansionPanel2.Size = new Size(892, 338);

				materialExpansionPanel2.Collapse = false;

				btnAdminLogin.Location = new Point(33, 476);
				btnCreateUser.Location = new Point(542, 476);
				btnClearForm.Location = new Point(753, 476);
			}
		}
		#endregion




		private void label6_Click(object sender, EventArgs e)
		{

		}

		//Generate token
		#region Generate Token
		private static async Task<string> AuthenticateAsync(string username, string password, string clientID)
		{
			using (var client = new HttpClient { BaseAddress = new Uri(apiBaseUrl) })
			{
				var content = new FormUrlEncodedContent(new[]
				{
					new KeyValuePair<string, string>("grant_type", "password"),
					new KeyValuePair<string, string>("client_id", clientID),
					new KeyValuePair<string, string>("username", username),
					new KeyValuePair<string, string>("password", password),
					new KeyValuePair<string, string>("scope", "all")
				});

				var response = await client.PostAsync("/auth/token", content);

				if (response.IsSuccessStatusCode)
				{
					var jsonResponse = await response.Content.ReadAsStringAsync();
					var authResult = JsonConvert.DeserializeObject<AuthenticationRoot>(jsonResponse);
					return authResult.access_token;
				}
				else
				{
					MessageBox.Show($"Authentication failed with status code: {response.StatusCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return null;
				}
			}
		}
		#endregion

		//search for tickets

		#region search for the ticket provided and return data
		private static async Task<Request> GetTicketAsync(string ticketID, string accessToken)
		{
			using (var client = new HttpClient { BaseAddress = new Uri(apiBaseUrl) })
			{
				client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
				var response = await client.GetAsync($"/api/tickets/{ticketID}");

				if (response.IsSuccessStatusCode)
				{
					var jsonResponse = await response.Content.ReadAsStringAsync();
					return JsonConvert.DeserializeObject<Request>(jsonResponse);
				}
				else
				{
					MessageBox.Show($"Failed to retrieve ticket with status code: {response.StatusCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return null;
				}
			}
		}
		#endregion
	}

	#region classes for ticket information retireval from the Halo API
	public class AuthenticationRoot
	{
		public string access_token { get; set; }
	}

	public class Customfield
	{
		public int id { get; set; }
		public string name { get; set; }
		public string label { get; set; }
		public object value { get; set; }
		public string display { get; set; }
	}

	public class Request
	{
		public string id { get; set; }
		public string summary { get; set; }
		public List<Customfield> customfields { get; set; }
	}
	#endregion


}


