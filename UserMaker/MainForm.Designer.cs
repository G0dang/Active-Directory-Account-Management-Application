

namespace UserMaker
{
	partial class adminLogin
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminLogin));
			lName = new Label();
			inputLNAME = new TextBox();
			dMain = new Label();
			jobTitle = new Label();
			reportingManager = new Label();
			payID = new Label();
			orgUnit = new Label();
			countryCode = new Label();
			costCenter = new Label();
			userAddress = new Label();
			passWord = new Label();
			discSuffix = new Label();
			domainList = new ComboBox();
			verify = new Button();
			btnClearForm = new Button();
			btnCreateUser = new Button();
			btnAdminLogin = new Button();
			cCode = new ComboBox();
			disclaimerSuffix = new ComboBox();
			cCenter = new ComboBox();
			passwordBox = new TextBox();
			jTitle = new TextBox();
			payrollID = new TextBox();
			reportManager = new TextBox();
			passwordCheckBox = new CheckBox();
			button1 = new Button();
			button2 = new Button();
			streetBox = new TextBox();
			cityBox = new TextBox();
			stateBox = new TextBox();
			countryBox = new TextBox();
			zipBox = new TextBox();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			inputFNAME = new TextBox();
			fName = new Label();
			OUBox = new ComboBox();
			SuspendLayout();
			// 
			// lName
			// 
			lName.AutoSize = true;
			lName.BackColor = Color.LightBlue;
			lName.Font = new Font("Segoe UI", 14.25F);
			lName.Location = new Point(12, 61);
			lName.Name = "lName";
			lName.Size = new Size(100, 25);
			lName.TabIndex = 2;
			lName.Text = "Last Name";
			lName.Click += label2_Click;
			// 
			// inputLNAME
			// 
			inputLNAME.BorderStyle = BorderStyle.FixedSingle;
			inputLNAME.Cursor = Cursors.IBeam;
			inputLNAME.Font = new Font("Segoe UI", 10F);
			inputLNAME.Location = new Point(217, 61);
			inputLNAME.Name = "inputLNAME";
			inputLNAME.Size = new Size(185, 25);
			inputLNAME.TabIndex = 3;
			inputLNAME.TextChanged += lastname_TextChanged;
			// 
			// dMain
			// 
			dMain.AutoSize = true;
			dMain.BackColor = Color.LightBlue;
			dMain.Font = new Font("Segoe UI", 14.25F);
			dMain.Location = new Point(12, 106);
			dMain.Name = "dMain";
			dMain.Size = new Size(96, 25);
			dMain.TabIndex = 4;
			dMain.Text = "Domain * ";
			// 
			// jobTitle
			// 
			jobTitle.AutoSize = true;
			jobTitle.BackColor = Color.LightBlue;
			jobTitle.Font = new Font("Segoe UI", 14.25F);
			jobTitle.Location = new Point(12, 277);
			jobTitle.Name = "jobTitle";
			jobTitle.Size = new Size(82, 25);
			jobTitle.TabIndex = 5;
			jobTitle.Text = "Job Title";
			// 
			// reportingManager
			// 
			reportingManager.AutoSize = true;
			reportingManager.BackColor = Color.LightBlue;
			reportingManager.Font = new Font("Segoe UI", 14.25F);
			reportingManager.Location = new Point(12, 320);
			reportingManager.Name = "reportingManager";
			reportingManager.Size = new Size(188, 25);
			reportingManager.TabIndex = 6;
			reportingManager.Text = "Reporting Manager *";
			// 
			// payID
			// 
			payID.AutoSize = true;
			payID.BackColor = Color.LightBlue;
			payID.Font = new Font("Segoe UI", 14.25F);
			payID.Location = new Point(12, 366);
			payID.Name = "payID";
			payID.Size = new Size(92, 25);
			payID.TabIndex = 7;
			payID.Text = "Payroll ID";
			// 
			// orgUnit
			// 
			orgUnit.AutoSize = true;
			orgUnit.BackColor = Color.LightBlue;
			orgUnit.Font = new Font("Segoe UI", 14.25F);
			orgUnit.Location = new Point(12, 409);
			orgUnit.Name = "orgUnit";
			orgUnit.Size = new Size(174, 25);
			orgUnit.TabIndex = 8;
			orgUnit.Text = "Organisation Unit *";
			// 
			// countryCode
			// 
			countryCode.AutoSize = true;
			countryCode.BackColor = Color.LightBlue;
			countryCode.Font = new Font("Segoe UI", 14.25F);
			countryCode.Location = new Point(456, 21);
			countryCode.Name = "countryCode";
			countryCode.Size = new Size(141, 25);
			countryCode.TabIndex = 9;
			countryCode.Text = "Country Code *";
			// 
			// costCenter
			// 
			costCenter.AutoSize = true;
			costCenter.BackColor = Color.LightBlue;
			costCenter.Font = new Font("Segoe UI", 14.25F);
			costCenter.Location = new Point(456, 109);
			costCenter.Name = "costCenter";
			costCenter.Size = new Size(123, 25);
			costCenter.TabIndex = 11;
			costCenter.Text = "Cost Center *";
			// 
			// userAddress
			// 
			userAddress.AutoSize = true;
			userAddress.BackColor = Color.LightBlue;
			userAddress.FlatStyle = FlatStyle.Popup;
			userAddress.Font = new Font("Segoe UI", 14.25F);
			userAddress.ForeColor = SystemColors.ActiveCaptionText;
			userAddress.Location = new Point(456, 164);
			userAddress.Name = "userAddress";
			userAddress.Size = new Size(92, 25);
			userAddress.TabIndex = 12;
			userAddress.Text = "Address *";
			// 
			// passWord
			// 
			passWord.AutoSize = true;
			passWord.BackColor = Color.LightBlue;
			passWord.Font = new Font("Segoe UI", 14.25F);
			passWord.Location = new Point(12, 209);
			passWord.Name = "passWord";
			passWord.Size = new Size(104, 25);
			passWord.TabIndex = 13;
			passWord.Text = "Password *";
			// 
			// discSuffix
			// 
			discSuffix.AutoSize = true;
			discSuffix.BackColor = Color.LightBlue;
			discSuffix.Font = new Font("Segoe UI", 14.25F);
			discSuffix.Location = new Point(456, 63);
			discSuffix.Name = "discSuffix";
			discSuffix.Size = new Size(165, 25);
			discSuffix.TabIndex = 14;
			discSuffix.Text = "Disclaimer Suffix *";
			// 
			// domainList
			// 
			domainList.AllowDrop = true;
			domainList.DropDownHeight = 150;
			domainList.FormattingEnabled = true;
			domainList.IntegralHeight = false;
			domainList.Items.AddRange(new object[] { "internal.detmold.com.au", "detmoldspecialty.com", "paperpak.co", "customcartons.com.au", "detmold.com.au", "ljmhodder.com.au", "henleyhk.com", "detmoldpackaging.com", "detpak.com", "paper-pak.net", "detconnect.com", "detmoldgroup.com", "detmoldmedical.com", "cupandcarry.com.au" });
			domainList.Location = new Point(217, 106);
			domainList.Name = "domainList";
			domainList.Size = new Size(185, 23);
			domainList.TabIndex = 15;
			domainList.SelectedIndexChanged += domainList_SelectedIndexChanged;
			// 
			// verify
			// 
			verify.BackColor = SystemColors.ActiveCaption;
			verify.Cursor = Cursors.Hand;
			verify.Font = new Font("Segoe UI", 10F);
			verify.Location = new Point(217, 150);
			verify.Name = "verify";
			verify.Size = new Size(185, 39);
			verify.TabIndex = 17;
			verify.Text = "Verify";
			verify.UseVisualStyleBackColor = false;
			verify.Click += verifyUser_btnClick;
			// 
			// btnClearForm
			// 
			btnClearForm.BackColor = SystemColors.ActiveCaption;
			btnClearForm.Cursor = Cursors.Hand;
			btnClearForm.Font = new Font("Segoe UI", 10F);
			btnClearForm.Location = new Point(650, 467);
			btnClearForm.Name = "btnClearForm";
			btnClearForm.Size = new Size(128, 39);
			btnClearForm.TabIndex = 18;
			btnClearForm.Text = "Clear";
			btnClearForm.UseVisualStyleBackColor = false;
			btnClearForm.Click += btnClearForm_Click;
			// 
			// btnCreateUser
			// 
			btnCreateUser.BackColor = SystemColors.ActiveCaption;
			btnCreateUser.Cursor = Cursors.Hand;
			btnCreateUser.Font = new Font("Segoe UI", 10F);
			btnCreateUser.Location = new Point(334, 467);
			btnCreateUser.Name = "btnCreateUser";
			btnCreateUser.Size = new Size(162, 39);
			btnCreateUser.TabIndex = 19;
			btnCreateUser.Text = "Create User";
			btnCreateUser.UseVisualStyleBackColor = false;
			btnCreateUser.Click += btnCreateUser_Click;
			// 
			// btnAdminLogin
			// 
			btnAdminLogin.BackColor = Color.CornflowerBlue;
			btnAdminLogin.Cursor = Cursors.Hand;
			btnAdminLogin.Font = new Font("Segoe UI", 10F);
			btnAdminLogin.Location = new Point(15, 467);
			btnAdminLogin.Name = "btnAdminLogin";
			btnAdminLogin.Size = new Size(126, 39);
			btnAdminLogin.TabIndex = 20;
			btnAdminLogin.Text = "Admin Login";
			btnAdminLogin.UseVisualStyleBackColor = false;
			// 
			// cCode
			// 
			cCode.AllowDrop = true;
			cCode.DropDownHeight = 150;
			cCode.FormattingEnabled = true;
			cCode.IntegralHeight = false;
			cCode.Items.AddRange(new object[] { "(AU)", "(CN) ", "(HK)", "(IN) ", "(ID) ", "(KR) ", "(MY)", "(AE) ", "(NL) ", "(NZ) ", "(PH)", "(SG) ", "(ZA) ", "(US) ", "(VN) " });
			cCode.Location = new Point(620, 21);
			cCode.Name = "cCode";
			cCode.Size = new Size(185, 23);
			cCode.TabIndex = 21;
			cCode.SelectedIndexChanged += cCode_SelectedIndexChanged;
			// 
			// disclaimerSuffix
			// 
			disclaimerSuffix.AllowDrop = true;
			disclaimerSuffix.DropDownHeight = 150;
			disclaimerSuffix.FormattingEnabled = true;
			disclaimerSuffix.IntegralHeight = false;
			disclaimerSuffix.Items.AddRange(new object[] { "EN", "CC", "CN", "ID", "VN" });
			disclaimerSuffix.Location = new Point(620, 64);
			disclaimerSuffix.Name = "disclaimerSuffix";
			disclaimerSuffix.Size = new Size(185, 23);
			disclaimerSuffix.TabIndex = 22;
			// 
			// cCenter
			// 
			cCenter.AllowDrop = true;
			cCenter.DropDownHeight = 150;
			cCenter.FormattingEnabled = true;
			cCenter.IntegralHeight = false;
			cCenter.Items.AddRange(new object[] { "DP-A,0010 DETMOLD AUST - PAPER", "DPK-A,0020 DETPAK AUSTRALIA", "EC-A,0025 E COMMERCE AUSTRALIA", "DPK-NA,0030 DETPAK NATIONAL ACCOUNTS", "PPK-A,0040 PAPERPAK AUSTRALIA", "DPK-NZ,0050 DETPAK NEW ZEALAND", "CB-A,0060 CORPORATE BRANDS AUSTRALIA", "CB-NZ,0070 CORPORATE BRANDS NZ", "DS-A,0080 DETMOLD PACKAGING SALES AUST", "SALES HQ,0095 DETPAK GROUP AUS/NZ", "WH-A,0098 GROUP WAREHOUSE", "DP-HSW,0210 DETMOLD HESHAN WENHUA - PAPER", "DP-HSX,0215 DETMOLD HESHAN XINGLONG - PAPER", "DPB-HS,0220 DETMOLD HESHAN - BOARD", "DP-V,0310 DETMOLD VIETNAM - PAPER", "DPB-V,0315 DETMOLD VIETNAM - BOARD", "DP-P,0320 DETMOLD PHILIPPINES - PAPER", "DP-I,0350 DETMOLD INDONESIA - PAPER", "DPB-I,0360 DETMOLD INDONESIA - BOARD", "DPS-I,0370 DETMOLD INDONESIA - SACKS", "DPK-S,0410 DETPAK SINGAPORE", "DPK-TH,0430 DETPAK THAILAND", "DPK-M,0440 DETPAK MALAYSIA", "DPK-P,0450 DETPAK PHILIPPINES", "DPK-I,0460 DETPAK INDONESIA", "DPK-V,0470 DETPAK VIETNAM", "DPK-ME,0480 DETPAK MIDDLE EAST", "DPK-EU,0490 DETPAK EUROPE", "DPK-US,0495 DETPAK NORTH AMERICA", "DPK-IN,0497 DETPAK INDIA", "DPK-CL,0498 DETPAK CHILE", "DPK-C,0510 DETPAK CHINA", "DPK-HK,0530 DETPAK HONG KONG", "DPK-K,0550 DETPAK KOREA", "DPK-T,0560 DETPAK TAIWAN", "GB-S,0570 GLOBAL BRANDS SINGAPORE", "GB-TH,0572 GLOBAL BRANDS THAILAND", "GB-M,0574 GLOBAL BRANDS MALAYSIA", "GB-P,0580 GLOBAL BRANDS PHILIPPINES", "GB-I,0582 GLOBAL BRANDS INDONESIA", "GB-V,0584 GLOBAL BRANDS VIETNAM", "GB-C,0590 GLOBAL BRANDS CHINA", "GB-HK,0592 GLOBAL BRANDS HONG KONG", "GB-K,0594 GLOBAL BRANDS KOREA", "GB-T,0596 GLOBAL BRANDS TAIWAN", "CC-A,0770 CUSTOM CARTONS AUSTRALIA", "DS-S,0610 DETMOLD PACKAGING SALES - SING", "DS-P,0620 DETMOLD PACKAGING SALES - PHIL", "DS-I,0630 DETMOLD PACKAGING SALES - INDO", "DS-V,0640 DETMOLD PACKAGING SALES - VIET", "DS-M,0650 DETMOLD PACKAGING SALES - MALAY", "DS-C,0660 DETMOLD PACKAGING SALES - CHINA", "GSS-A,0710 GROUP SERVICES - AUSTRALIA", "GSS-S,0715 GROUP SERVICES - SINGAPORE", "DPE-A,0750 ENGINEERING AUSTRALIA", "DPE-C,0760 ENGINEERING CHINA", "DPK-SA,0810 SOUTH AFRICA", "DP-IN,0815 DETMOLD INDIA", "CORP-A,0820 CORPORATE - AUSTRALIA", "CORP-NZ,0830 NEW ZEALAND FINANCE", "CORP-S,0840 CORPORATE - SINGAPORE", "HT-HK,0950 HENLEY TRADING - HONG KONG", "HT-QP,0951 Q PAK", "DSP-A,0970 DETMOLD SPECIALTY PACKAGING COMBINED", "DV-QM,0972 QLD MEDICAL", "DV-C+C,0973 Cup + Carry", "DV-MED,0974 Detmold Medical" });
			cCenter.Location = new Point(620, 111);
			cCenter.Name = "cCenter";
			cCenter.Size = new Size(185, 23);
			cCenter.TabIndex = 23;
			cCenter.SelectedIndexChanged += cCenter_SelectedIndexChanged;
			// 
			// passwordBox
			// 
			passwordBox.BorderStyle = BorderStyle.FixedSingle;
			passwordBox.Location = new Point(217, 209);
			passwordBox.Name = "passwordBox";
			passwordBox.PasswordChar = '*';
			passwordBox.Size = new Size(185, 23);
			passwordBox.TabIndex = 24;
			passwordBox.TextChanged += textBox3_TextChanged;
			// 
			// jTitle
			// 
			jTitle.BorderStyle = BorderStyle.FixedSingle;
			jTitle.Location = new Point(217, 277);
			jTitle.Name = "jTitle";
			jTitle.Size = new Size(185, 23);
			jTitle.TabIndex = 25;
			// 
			// payrollID
			// 
			payrollID.BorderStyle = BorderStyle.FixedSingle;
			payrollID.Cursor = Cursors.IBeam;
			payrollID.Location = new Point(218, 366);
			payrollID.Name = "payrollID";
			payrollID.Size = new Size(185, 23);
			payrollID.TabIndex = 27;
			payrollID.TextChanged += payrollID_TextChanged;
			// 
			// reportManager
			// 
			reportManager.BorderStyle = BorderStyle.FixedSingle;
			reportManager.Location = new Point(217, 320);
			reportManager.Name = "reportManager";
			reportManager.Size = new Size(185, 23);
			reportManager.TabIndex = 26;
			reportManager.TextChanged += textBox5_TextChanged;
			// 
			// passwordCheckBox
			// 
			passwordCheckBox.AutoSize = true;
			passwordCheckBox.Font = new Font("Segoe UI", 11F);
			passwordCheckBox.Location = new Point(218, 238);
			passwordCheckBox.Name = "passwordCheckBox";
			passwordCheckBox.Size = new Size(189, 24);
			passwordCheckBox.TabIndex = 32;
			passwordCheckBox.Text = "Auto Generate Password";
			passwordCheckBox.UseVisualStyleBackColor = true;
			passwordCheckBox.CheckedChanged += checkBox1_CheckedChanged;
			// 
			// button1
			// 
			button1.BackColor = Color.LightBlue;
			button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
			button1.BackgroundImageLayout = ImageLayout.Center;
			button1.Location = new Point(408, 207);
			button1.Name = "button1";
			button1.Size = new Size(28, 27);
			button1.TabIndex = 33;
			button1.UseVisualStyleBackColor = false;
			button1.Click += copy_btnClick;
			// 
			// button2
			// 
			button2.BackColor = SystemColors.GradientActiveCaption;
			button2.BackgroundImageLayout = ImageLayout.None;
			button2.FlatAppearance.BorderColor = Color.White;
			button2.Location = new Point(456, 411);
			button2.Name = "button2";
			button2.Size = new Size(116, 23);
			button2.TabIndex = 35;
			button2.Text = "Address List";
			button2.UseVisualStyleBackColor = false;
			button2.Click += addressList_BtnClick;
			// 
			// streetBox
			// 
			streetBox.BorderStyle = BorderStyle.FixedSingle;
			streetBox.Location = new Point(620, 215);
			streetBox.Name = "streetBox";
			streetBox.Size = new Size(100, 23);
			streetBox.TabIndex = 37;
			streetBox.TextChanged += street_Textbox;
			// 
			// cityBox
			// 
			cityBox.BorderStyle = BorderStyle.FixedSingle;
			cityBox.Location = new Point(620, 254);
			cityBox.Name = "cityBox";
			cityBox.Size = new Size(100, 23);
			cityBox.TabIndex = 38;
			cityBox.TextChanged += city_TextBox;
			// 
			// stateBox
			// 
			stateBox.BorderStyle = BorderStyle.FixedSingle;
			stateBox.Location = new Point(620, 297);
			stateBox.Name = "stateBox";
			stateBox.Size = new Size(100, 23);
			stateBox.TabIndex = 39;
			stateBox.TextChanged += state_TextBox;
			// 
			// countryBox
			// 
			countryBox.BorderStyle = BorderStyle.FixedSingle;
			countryBox.Location = new Point(620, 337);
			countryBox.Name = "countryBox";
			countryBox.Size = new Size(100, 23);
			countryBox.TabIndex = 40;
			countryBox.TextChanged += Country_TextBox;
			// 
			// zipBox
			// 
			zipBox.BorderStyle = BorderStyle.FixedSingle;
			zipBox.Location = new Point(620, 378);
			zipBox.Name = "zipBox";
			zipBox.Size = new Size(100, 23);
			zipBox.TabIndex = 41;
			zipBox.TextChanged += ZIP_TextBox;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 14.25F);
			label1.Location = new Point(456, 215);
			label1.Name = "label1";
			label1.Size = new Size(60, 25);
			label1.TabIndex = 42;
			label1.Text = "Street";
			label1.Click += label1_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 14.25F);
			label2.Location = new Point(456, 254);
			label2.Name = "label2";
			label2.Size = new Size(44, 25);
			label2.TabIndex = 43;
			label2.Text = "City";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 14.25F);
			label3.Location = new Point(456, 297);
			label3.Name = "label3";
			label3.Size = new Size(53, 25);
			label3.TabIndex = 44;
			label3.Text = "State";
			label3.Click += label3_Click;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 14.25F);
			label4.Location = new Point(456, 337);
			label4.Name = "label4";
			label4.Size = new Size(79, 25);
			label4.TabIndex = 45;
			label4.Text = "Country";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI", 14.25F);
			label5.Location = new Point(456, 372);
			label5.Name = "label5";
			label5.Size = new Size(96, 25);
			label5.TabIndex = 46;
			label5.Text = "Post Code";
			// 
			// inputFNAME
			// 
			inputFNAME.BorderStyle = BorderStyle.FixedSingle;
			inputFNAME.Cursor = Cursors.IBeam;
			inputFNAME.Font = new Font("Segoe UI", 10F);
			inputFNAME.Location = new Point(217, 21);
			inputFNAME.Name = "inputFNAME";
			inputFNAME.Size = new Size(185, 25);
			inputFNAME.TabIndex = 30;
			inputFNAME.TextChanged += inputFNAME_TextChanged;
			// 
			// fName
			// 
			fName.AutoSize = true;
			fName.BackColor = Color.LightBlue;
			fName.Font = new Font("Segoe UI", 14.25F);
			fName.Location = new Point(12, 21);
			fName.Name = "fName";
			fName.Size = new Size(115, 25);
			fName.TabIndex = 1;
			fName.Text = "First Name *";
			fName.Click += label1_Click_1;
			// 
			// OUBox
			// 
			OUBox.FormattingEnabled = true;
			OUBox.Location = new Point(217, 409);
			OUBox.Name = "OUBox";
			OUBox.Size = new Size(186, 23);
			OUBox.TabIndex = 47;
			OUBox.SelectedIndexChanged += organisationalUnit_comboBox;
			OUBox.Click += ouList_Click;
			// 
			// adminLogin
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			AutoScroll = true;
			BackColor = Color.LightBlue;
			ClientSize = new Size(817, 547);
			Controls.Add(OUBox);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(zipBox);
			Controls.Add(countryBox);
			Controls.Add(stateBox);
			Controls.Add(cityBox);
			Controls.Add(streetBox);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(passwordCheckBox);
			Controls.Add(inputFNAME);
			Controls.Add(payrollID);
			Controls.Add(reportManager);
			Controls.Add(jTitle);
			Controls.Add(passwordBox);
			Controls.Add(cCenter);
			Controls.Add(disclaimerSuffix);
			Controls.Add(cCode);
			Controls.Add(btnAdminLogin);
			Controls.Add(btnCreateUser);
			Controls.Add(btnClearForm);
			Controls.Add(verify);
			Controls.Add(domainList);
			Controls.Add(discSuffix);
			Controls.Add(passWord);
			Controls.Add(userAddress);
			Controls.Add(costCenter);
			Controls.Add(countryCode);
			Controls.Add(orgUnit);
			Controls.Add(payID);
			Controls.Add(reportingManager);
			Controls.Add(jobTitle);
			Controls.Add(dMain);
			Controls.Add(inputLNAME);
			Controls.Add(lName);
			Controls.Add(fName);
			Margin = new Padding(3, 2, 3, 2);
			Name = "adminLogin";
			Text = "User Creation Tool (Detmold Group)";
			Load += Form1_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

#endregion
		private Label lName;
		private TextBox inputLNAME;
		private Label dMain;
		private Label jobTitle;
		private Label reportingManager;
		private Label payID;
		private Label orgUnit;
		private Label countryCode;
		private Label costCenter;
		private Label userAddress;
		private Label passWord;
		private Label discSuffix;
		private ComboBox domainList;
		private Button verify;
		private Button btnClearForm;
		private Button btnCreateUser;
		private Button btnAdminLogin;
		private ComboBox cCode;
		private ComboBox disclaimerSuffix;
		private ComboBox cCenter;
		private TextBox passwordBox;
		private TextBox jTitle;
		private TextBox payrollID;
		private TextBox reportManager;
		private CheckBox passwordCheckBox;
		private Button button1;
		private Button button2;
		private TextBox streetBox;
		private TextBox cityBox;
		private TextBox stateBox;
		private TextBox countryBox;
		private TextBox zipBox;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private TextBox inputFNAME;
		private Label fName;
		private ComboBox OUBox;
	}
}
