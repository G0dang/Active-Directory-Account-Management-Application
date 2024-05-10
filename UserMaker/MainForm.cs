using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing.Text;
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

namespace UserMaker
{
	public partial class adminLogin : Form
	{
		//establich connection to the Active Directory Folder in the domain
		private const string OUDN = "OU=Aayush Test,OU=Accounts,DC=internal,DC=detmold,DC=com,DC=au";

		//check if the addressBox is empty so "close' button in AddressForm can call this method
		public adminLogin()
		{
			InitializeComponent();
			passwordCheckBox.CheckedChanged += checkBox1_CheckedChanged;

			// -= operator below helped stop verifyUser_btnClick method from executing twice when verifying a user's existence in the active directory
			verify.Click -= verifyUser_btnClick;
			verify.Click += verifyUser_btnClick;

		}
		//UNDERCONTRUCTION!!!
		//ISSUE: The address list does not close after selecting an address
		//Update1: Addedd a 'Close' button in the address Form
		//Update2: Added Close() function in the 'select' button
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


		#region VARIOUS Event Handlers
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

		private void Form1_Load(object sender, EventArgs e)
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


		#region CODE FOR THE 'CREATE USER' BUTTON
		private void btnCreateUser_Click(object sender, EventArgs e)
		{

			#region check empty field where input is required
			if (string.IsNullOrWhiteSpace(inputFNAME.Text))
			{
				//highlight the text field
				inputFNAME.BackColor = Color.OrangeRed;
				MessageBox.Show("Please fill the highlighted field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
				// Exit the method to prevent further processing
			}
			inputFNAME.BackColor = SystemColors.Window;

			if (string.IsNullOrWhiteSpace(domainList.Text))
			{
				domainList.BackColor = Color.OrangeRed;
				MessageBox.Show("Please fill the highlighted field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			domainList.BackColor = SystemColors.Window;


			if (string.IsNullOrWhiteSpace(passwordBox.Text))
			{
				passwordBox.BackColor = Color.OrangeRed;
				MessageBox.Show("Please create a unique password from the the password generater or create your own", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			passwordBox.BackColor = SystemColors.Window;


			if (string.IsNullOrWhiteSpace(reportManager.Text))
			{
				reportManager.BackColor = Color.OrangeRed;
				MessageBox.Show("Please fill the highlighted field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			reportManager.BackColor = SystemColors.Window;

			if (string.IsNullOrWhiteSpace(cCode.Text))
			{
				cCode.BackColor = Color.OrangeRed;
				MessageBox.Show("Please select a country code for the user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			cCode.BackColor = SystemColors.Window;


			if (string.IsNullOrWhiteSpace(disclaimerSuffix.Text))
			{
				disclaimerSuffix.BackColor = Color.OrangeRed;
				MessageBox.Show("Please select a Disclaimer Suffix for the user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			disclaimerSuffix.BackColor = SystemColors.Window;


			if (string.IsNullOrWhiteSpace(cCenter.Text))
			{
				cCenter.BackColor = Color.OrangeRed;
				MessageBox.Show("Please select a Cost Center for the user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			cCenter.BackColor = SystemColors.Window;
			#endregion


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

			#region update the users attributes in the active directory
			try
			{
				// Create a DirectoryEntry object for the OU
				DirectoryEntry ou = new DirectoryEntry("LDAP://" + OUDN);

				// Creating a new user object in the Organisational Unit (OU)
				DirectoryEntry newUser = ou.Children.Add("CN=" + inputFNAME.Text + " " + inputLNAME.Text, "user");

				// Set user attributes //Unknown user attributes 
				newUser.Properties["givenName"].Value = inputFNAME.Text;

				
				// When a user does not have a last name. Do not update the attributes
				// ! inverts the function of the statement.
				if (!String.IsNullOrEmpty(inputLNAME.Text)) 
				{
					newUser.Properties["sn"].Value = inputLNAME.Text;
					newUser.Properties["displayName"].Value = inputFNAME.Text + " " + inputLNAME.Text;
					
				}
				

				newUser.Properties["mail"].Value = UPN;
				newUser.Properties["userPrincipalName"].Value = UPN;
				newUser.Properties["samAccountName"].Value = Pre2000;

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
				//newUser.Properties["Job Title"].Value = jTitle.Text;

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


		#region Methods for various text boxes
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


		#region CODE FOR 'CLEAR' BUTTON
		private void btnClearForm_Click(object sender, EventArgs e)
		{
			foreach (Control control in Controls)
			{
				if (control is System.Windows.Forms.TextBox)
				{
					System.Windows.Forms.TextBox textBox = (System.Windows.Forms.TextBox)control;
					textBox.Clear();
				}
				else if (control is System.Windows.Forms.ComboBox)
				{
					System.Windows.Forms.ComboBox comboBox = (System.Windows.Forms.ComboBox)control;
					comboBox.SelectedIndex = -1; // Clears selection

					comboBox.Text = "";  //to clear the text as well
				}
				//the 'clear' button will uncheck the check box for the Auto Password Generater checkbox
				else if (control is System.Windows.Forms.CheckBox)
				{
					System.Windows.Forms.CheckBox comboBox = (System.Windows.Forms.CheckBox)control;
					passwordCheckBox.Checked = false;
				}
			}
			// clear button will also clear the highlights showing the missing field
			inputFNAME.BackColor = SystemColors.Window;

			domainList.BackColor = SystemColors.Window;

			passwordBox.BackColor = SystemColors.Window;

			reportManager.BackColor = SystemColors.Window;

			



			cCode.BackColor = SystemColors.Window;

			disclaimerSuffix.BackColor = SystemColors.Window;

			cCenter.BackColor = SystemColors.Window;

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
		private void address_textBox(object sender, EventArgs e)
		{

		}

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
		#endregion

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void organisationalUnit_Click(object sender, EventArgs e)
		{
			
		}
	}
}
