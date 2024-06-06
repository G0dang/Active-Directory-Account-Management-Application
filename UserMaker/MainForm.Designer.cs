

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
			costCenter = new Label();
			passWord = new Label();
			discSuffix = new Label();
			domainList = new ComboBox();
			verify = new Button();
			btnClearForm = new Button();
			btnCreateUser = new Button();
			btnAdminLogin = new Button();
			disclaimerSuffix = new ComboBox();
			cCenter = new ComboBox();
			passwordBox = new TextBox();
			jTitle = new TextBox();
			payrollID = new TextBox();
			passwordCheckBox = new CheckBox();
			button1 = new Button();
			countryBox = new TextBox();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			inputFNAME = new TextBox();
			fName = new Label();
			materialExpansionPanel1 = new MaterialSkin.Controls.MaterialExpansionPanel();
			ticketID_btn = new Button();
			label6 = new Label();
			ticketID_textbox = new TextBox();
			materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
			materialExpansionPanel2 = new MaterialSkin.Controls.MaterialExpansionPanel();
			tempBox = new TextBox();
			progressBar_RM = new ProgressBar();
			streetBox = new TextBox();
			button4 = new Button();
			userAddress = new Label();
			button2 = new Button();
			RMBox = new ComboBox();
			cityBox = new TextBox();
			OUBox = new ComboBox();
			stateBox = new TextBox();
			zipBox = new TextBox();
			orgUnit = new Label();
			materialExpansionPanel1.SuspendLayout();
			materialExpansionPanel2.SuspendLayout();
			SuspendLayout();
			// 
			// lName
			// 
			lName.AutoSize = true;
			lName.BackColor = Color.Lavender;
			lName.Font = new Font("Times New Roman", 15.75F);
			lName.ForeColor = Color.Black;
			lName.Location = new Point(21, 145);
			lName.Name = "lName";
			lName.Size = new Size(99, 23);
			lName.TabIndex = 2;
			lName.Text = "Last Name";
			lName.Click += label2_Click;
			// 
			// inputLNAME
			// 
			inputLNAME.BorderStyle = BorderStyle.FixedSingle;
			inputLNAME.Cursor = Cursors.IBeam;
			inputLNAME.Font = new Font("Microsoft Sans Serif", 12F);
			inputLNAME.Location = new Point(225, 141);
			inputLNAME.Name = "inputLNAME";
			inputLNAME.Size = new Size(185, 26);
			inputLNAME.TabIndex = 2;
			inputLNAME.TextChanged += lastname_TextChanged;
			// 
			// dMain
			// 
			dMain.AutoSize = true;
			dMain.BackColor = Color.Lavender;
			dMain.Font = new Font("Times New Roman", 15.75F);
			dMain.ForeColor = Color.Black;
			dMain.Location = new Point(19, 188);
			dMain.Name = "dMain";
			dMain.Size = new Size(97, 23);
			dMain.TabIndex = 4;
			dMain.Text = "Domain * ";
			// 
			// jobTitle
			// 
			jobTitle.AutoSize = true;
			jobTitle.BackColor = Color.Lavender;
			jobTitle.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			jobTitle.ForeColor = Color.Black;
			jobTitle.Location = new Point(461, 146);
			jobTitle.Name = "jobTitle";
			jobTitle.Size = new Size(82, 23);
			jobTitle.TabIndex = 5;
			jobTitle.Text = "Job Title";
			// 
			// reportingManager
			// 
			reportingManager.AutoSize = true;
			reportingManager.BackColor = Color.Lavender;
			reportingManager.Font = new Font("Times New Roman", 15.75F);
			reportingManager.ForeColor = Color.Black;
			reportingManager.Location = new Point(17, 94);
			reportingManager.Name = "reportingManager";
			reportingManager.Size = new Size(185, 23);
			reportingManager.TabIndex = 6;
			reportingManager.Text = "Reporting Manager *";
			// 
			// payID
			// 
			payID.AutoSize = true;
			payID.BackColor = Color.Lavender;
			payID.Font = new Font("Times New Roman", 15.75F);
			payID.ForeColor = Color.Black;
			payID.Location = new Point(17, 277);
			payID.Name = "payID";
			payID.Size = new Size(96, 23);
			payID.TabIndex = 7;
			payID.Text = "Payroll ID";
			// 
			// costCenter
			// 
			costCenter.AutoSize = true;
			costCenter.BackColor = Color.Lavender;
			costCenter.Font = new Font("Times New Roman", 15.75F);
			costCenter.ForeColor = Color.Black;
			costCenter.Location = new Point(17, 49);
			costCenter.Name = "costCenter";
			costCenter.Size = new Size(124, 23);
			costCenter.TabIndex = 11;
			costCenter.Text = "Cost Center *";
			// 
			// passWord
			// 
			passWord.AutoSize = true;
			passWord.BackColor = Color.Lavender;
			passWord.Font = new Font("Times New Roman", 15.75F);
			passWord.ForeColor = Color.Black;
			passWord.Location = new Point(461, 188);
			passWord.Name = "passWord";
			passWord.Size = new Size(105, 23);
			passWord.TabIndex = 13;
			passWord.Text = "Password *";
			// 
			// discSuffix
			// 
			discSuffix.AutoSize = true;
			discSuffix.BackColor = Color.Lavender;
			discSuffix.Font = new Font("Times New Roman", 15.75F);
			discSuffix.ForeColor = Color.Black;
			discSuffix.Location = new Point(461, 96);
			discSuffix.Name = "discSuffix";
			discSuffix.Size = new Size(173, 23);
			discSuffix.TabIndex = 14;
			discSuffix.Text = "Disclaimer Suffix *";
			// 
			// domainList
			// 
			domainList.AllowDrop = true;
			domainList.DropDownHeight = 150;
			domainList.Font = new Font("Microsoft Sans Serif", 12F);
			domainList.FormattingEnabled = true;
			domainList.IntegralHeight = false;
			domainList.Items.AddRange(new object[] { "cupandcarry.com.au", "customcartons.com.au", "detconnect.com", "detmold.com.au", "detmoldgroup.com", "detmoldmedical.com", "detmoldpackaging.com", "detmoldspecialty.com", "detpak.com", "henleyhk.com", "internal.detmold.com.au", "ljmhodder.com.au", "paper-pak.net", "paperpak.co" });
			domainList.Location = new Point(225, 183);
			domainList.Name = "domainList";
			domainList.Size = new Size(185, 28);
			domainList.TabIndex = 3;
			domainList.SelectedIndexChanged += domainList_SelectedIndexChanged;
			// 
			// verify
			// 
			verify.BackColor = SystemColors.ActiveCaption;
			verify.Cursor = Cursors.Hand;
			verify.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			verify.Location = new Point(225, 217);
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
			btnClearForm.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnClearForm.Location = new Point(767, 420);
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
			btnCreateUser.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnCreateUser.Location = new Point(547, 421);
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
			btnAdminLogin.Location = new Point(18, 421);
			btnAdminLogin.Name = "btnAdminLogin";
			btnAdminLogin.Size = new Size(126, 39);
			btnAdminLogin.TabIndex = 20;
			btnAdminLogin.Text = "Admin Login";
			btnAdminLogin.UseVisualStyleBackColor = false;
			// 
			// disclaimerSuffix
			// 
			disclaimerSuffix.AllowDrop = true;
			disclaimerSuffix.DropDownHeight = 150;
			disclaimerSuffix.Font = new Font("Microsoft Sans Serif", 12F);
			disclaimerSuffix.FormattingEnabled = true;
			disclaimerSuffix.IntegralHeight = false;
			disclaimerSuffix.Items.AddRange(new object[] { "EN", "CC", "CN", "ID", "VN" });
			disclaimerSuffix.Location = new Point(654, 96);
			disclaimerSuffix.Name = "disclaimerSuffix";
			disclaimerSuffix.Size = new Size(185, 28);
			disclaimerSuffix.TabIndex = 5;
			disclaimerSuffix.Text = "EN";
			// 
			// cCenter
			// 
			cCenter.AllowDrop = true;
			cCenter.DropDownHeight = 150;
			cCenter.Font = new Font("Microsoft Sans Serif", 8F);
			cCenter.FormattingEnabled = true;
			cCenter.IntegralHeight = false;
			cCenter.Items.AddRange(new object[] { "CB-A,0060 CORPORATE BRANDS AUSTRALIA", "CB-NZ,0070 CORPORATE BRANDS NZ", "CC-A,0770 CUSTOM CARTONS AUSTRALIA", "CORP-A,0820 CORPORATE - AUSTRALIA", "CORP-NZ,0830 NEW ZEALAND FINANCE", "CORP-S,0840 CORPORATE - SINGAPORE", "DP-A,0010 DETMOLD AUST - PAPER", "DP-HSW,0210 DETMOLD HESHAN WENHUA - PAPER", "DP-HSX,0215 DETMOLD HESHAN XINGLONG - PAPER", "DP-I,0350 DETMOLD INDONESIA - PAPER", "DP-IN,0815 DETMOLD INDIA", "DP-P,0320 DETMOLD PHILIPPINES - PAPER", "DP-V,0310 DETMOLD VIETNAM - PAPER", "DPB-HS,0220 DETMOLD HESHAN - BOARD", "DPB-I,0360 DETMOLD INDONESIA - BOARD", "DPB-V,0315 DETMOLD VIETNAM - BOARD", "DPE-A,0750 ENGINEERING AUSTRALIA", "DPE-C,0760 ENGINEERING CHINA", "DPK-A,0020 DETPAK AUSTRALIA", "DPK-C,0510 DETPAK CHINA", "DPK-CL,0498 DETPAK CHILE", "DPK-EU,0490 DETPAK EUROPE", "DPK-HK,0530 DETPAK HONG KONG", "DPK-I,0460 DETPAK INDONESIA", "DPK-IN,0497 DETPAK INDIA", "DPK-K,0550 DETPAK KOREA", "DPK-M,0440 DETPAK MALAYSIA", "DPK-ME,0480 DETPAK MIDDLE EAST", "DPK-NA,0030 DETPAK NATIONAL ACCOUNTS", "DPK-NZ,0050 DETPAK NEW ZEALAND", "DPK-P,0450 DETPAK PHILIPPINES", "DPK-S,0410 DETPAK SINGAPORE", "DPK-SA,0810 SOUTH AFRICA", "DPK-T,0560 DETPAK TAIWAN", "DPK-TH,0430 DETPAK THAILAND", "DPK-US,0495 DETPAK NORTH AMERICA", "DPK-V,0470 DETPAK VIETNAM", "DPS-I,0370 DETMOLD INDONESIA - SACKS", "DS-A,0080 DETMOLD PACKAGING SALES AUST", "DS-C,0660 DETMOLD PACKAGING SALES - CHINA", "DS-I,0630 DETMOLD PACKAGING SALES - INDO", "DS-M,0650 DETMOLD PACKAGING SALES - MALAY", "DS-P,0620 DETMOLD PACKAGING SALES - PHIL", "DS-S,0610 DETMOLD PACKAGING SALES - SING", "DS-V,0640 DETMOLD PACKAGING SALES - VIET", "DSP-A,0970 DETMOLD SPECIALTY PACKAGING COMBINED", "DV-C+C,0973 Cup + Carry", "DV-MED,0974 Detmold Medical", "DV-QM,0972 QLD MEDICAL", "EC-A,0025 E COMMERCE AUSTRALIA", "GB-C,0590 GLOBAL BRANDS CHINA", "GB-HK,0592 GLOBAL BRANDS HONG KONG", "GB-I,0582 GLOBAL BRANDS INDONESIA", "GB-K,0594 GLOBAL BRANDS KOREA", "GB-M,0574 GLOBAL BRANDS MALAYSIA", "GB-P,0580 GLOBAL BRANDS PHILIPPINES", "GB-S,0570 GLOBAL BRANDS SINGAPORE", "GB-T,0596 GLOBAL BRANDS TAIWAN", "GB-TH,0572 GLOBAL BRANDS THAILAND", "GB-V,0584 GLOBAL BRANDS VIETNAM", "GSS-A,0710 GROUP SERVICES - AUSTRALIA", "GSS-S,0715 GROUP SERVICES - SINGAPORE", "HT-HK,0950 HENLEY TRADING - HONG KONG", "HT-QP,0951 Q PAK", "PPK-A,0040 PAPERPAK AUSTRALIA", "SALES HQ,0095 DETPAK GROUP AUS/NZ", "WH-A,0098 GROUP WAREHOUSE" });
			cCenter.Location = new Point(241, 47);
			cCenter.Name = "cCenter";
			cCenter.Size = new Size(185, 28);
			cCenter.TabIndex = 6;
			cCenter.SelectedIndexChanged += cCenter_SelectedIndexChanged;
			// 
			// passwordBox
			// 
			passwordBox.BorderStyle = BorderStyle.FixedSingle;
			passwordBox.Font = new Font("Microsoft Sans Serif", 12F);
			passwordBox.Location = new Point(654, 186);
			passwordBox.Name = "passwordBox";
			passwordBox.PasswordChar = '*';
			passwordBox.Size = new Size(185, 26);
			passwordBox.TabIndex = 7;
			passwordBox.TextChanged += textBox3_TextChanged;
			// 
			// jTitle
			// 
			jTitle.BorderStyle = BorderStyle.FixedSingle;
			jTitle.Font = new Font("Microsoft Sans Serif", 12F);
			jTitle.Location = new Point(654, 143);
			jTitle.Name = "jTitle";
			jTitle.Size = new Size(185, 26);
			jTitle.TabIndex = 9;
			// 
			// payrollID
			// 
			payrollID.BorderStyle = BorderStyle.FixedSingle;
			payrollID.Cursor = Cursors.IBeam;
			payrollID.Font = new Font("Microsoft Sans Serif", 12F);
			payrollID.Location = new Point(242, 277);
			payrollID.Name = "payrollID";
			payrollID.Size = new Size(185, 26);
			payrollID.TabIndex = 12;
			payrollID.TextChanged += payrollID_TextChanged;
			// 
			// passwordCheckBox
			// 
			passwordCheckBox.AutoSize = true;
			passwordCheckBox.Font = new Font("Segoe UI", 11F);
			passwordCheckBox.Location = new Point(654, 239);
			passwordCheckBox.Name = "passwordCheckBox";
			passwordCheckBox.Size = new Size(189, 24);
			passwordCheckBox.TabIndex = 8;
			passwordCheckBox.Text = "Auto Generate Password";
			passwordCheckBox.UseVisualStyleBackColor = true;
			passwordCheckBox.CheckedChanged += checkBox1_CheckedChanged;
			// 
			// button1
			// 
			button1.BackColor = Color.LightBlue;
			button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
			button1.BackgroundImageLayout = ImageLayout.Center;
			button1.Location = new Point(849, 182);
			button1.Name = "button1";
			button1.Size = new Size(28, 27);
			button1.TabIndex = 33;
			button1.UseVisualStyleBackColor = false;
			button1.Click += copy_btnClick;
			// 
			// countryBox
			// 
			countryBox.BorderStyle = BorderStyle.FixedSingle;
			countryBox.Font = new Font("Microsoft Sans Serif", 12F);
			countryBox.Location = new Point(672, 172);
			countryBox.Name = "countryBox";
			countryBox.Size = new Size(147, 26);
			countryBox.TabIndex = 17;
			countryBox.TextChanged += Country_TextBox;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Times New Roman", 14.25F);
			label1.ForeColor = Color.Black;
			label1.Location = new Point(508, 85);
			label1.Name = "label1";
			label1.Size = new Size(53, 21);
			label1.TabIndex = 42;
			label1.Text = "Street";
			label1.Click += label1_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Times New Roman", 14.25F);
			label2.ForeColor = Color.Black;
			label2.Location = new Point(508, 114);
			label2.Name = "label2";
			label2.Size = new Size(41, 21);
			label2.TabIndex = 43;
			label2.Text = "City";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Times New Roman", 14.25F);
			label3.ForeColor = Color.Black;
			label3.Location = new Point(508, 143);
			label3.Name = "label3";
			label3.Size = new Size(47, 21);
			label3.TabIndex = 44;
			label3.Text = "State";
			label3.Click += label3_Click;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Times New Roman", 14.25F);
			label4.ForeColor = Color.Black;
			label4.Location = new Point(508, 172);
			label4.Name = "label4";
			label4.Size = new Size(71, 21);
			label4.TabIndex = 45;
			label4.Text = "Country";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Times New Roman", 14.25F);
			label5.ForeColor = Color.Black;
			label5.Location = new Point(508, 201);
			label5.Name = "label5";
			label5.Size = new Size(90, 21);
			label5.TabIndex = 46;
			label5.Text = "Post Code";
			// 
			// inputFNAME
			// 
			inputFNAME.BorderStyle = BorderStyle.FixedSingle;
			inputFNAME.Cursor = Cursors.IBeam;
			inputFNAME.Font = new Font("Microsoft Sans Serif", 12F);
			inputFNAME.Location = new Point(225, 96);
			inputFNAME.Name = "inputFNAME";
			inputFNAME.Size = new Size(185, 26);
			inputFNAME.TabIndex = 1;
			inputFNAME.TextChanged += inputFNAME_TextChanged;
			// 
			// fName
			// 
			fName.AutoSize = true;
			fName.BackColor = Color.Lavender;
			fName.Font = new Font("Times New Roman", 15.75F);
			fName.ForeColor = Color.Black;
			fName.Location = new Point(19, 96);
			fName.Name = "fName";
			fName.Size = new Size(118, 23);
			fName.TabIndex = 1;
			fName.Text = "First Name *";
			fName.Click += label1_Click_1;
			// 
			// materialExpansionPanel1
			// 
			materialExpansionPanel1.BackColor = Color.FromArgb(255, 255, 255);
			materialExpansionPanel1.BackgroundImageLayout = ImageLayout.Center;
			materialExpansionPanel1.BorderStyle = BorderStyle.Fixed3D;
			materialExpansionPanel1.CancelButtonText = "";
			materialExpansionPanel1.Controls.Add(ticketID_btn);
			materialExpansionPanel1.Controls.Add(label6);
			materialExpansionPanel1.Controls.Add(ticketID_textbox);
			materialExpansionPanel1.Controls.Add(materialLabel1);
			materialExpansionPanel1.Controls.Add(domainList);
			materialExpansionPanel1.Controls.Add(inputFNAME);
			materialExpansionPanel1.Controls.Add(inputLNAME);
			materialExpansionPanel1.Controls.Add(fName);
			materialExpansionPanel1.Controls.Add(lName);
			materialExpansionPanel1.Controls.Add(dMain);
			materialExpansionPanel1.Controls.Add(verify);
			materialExpansionPanel1.Controls.Add(button1);
			materialExpansionPanel1.Controls.Add(passWord);
			materialExpansionPanel1.Controls.Add(passwordBox);
			materialExpansionPanel1.Controls.Add(jTitle);
			materialExpansionPanel1.Controls.Add(passwordCheckBox);
			materialExpansionPanel1.Controls.Add(discSuffix);
			materialExpansionPanel1.Controls.Add(disclaimerSuffix);
			materialExpansionPanel1.Controls.Add(jobTitle);
			materialExpansionPanel1.Depth = 0;
			materialExpansionPanel1.Description = "";
			materialExpansionPanel1.ExpandHeight = 331;
			materialExpansionPanel1.Font = new Font("Times New Roman", 15.75F);
			materialExpansionPanel1.ForeColor = Color.FromArgb(222, 0, 0, 0);
			materialExpansionPanel1.Location = new Point(11, 8);
			materialExpansionPanel1.Margin = new Padding(16);
			materialExpansionPanel1.MouseState = MaterialSkin.MouseState.HOVER;
			materialExpansionPanel1.Name = "materialExpansionPanel1";
			materialExpansionPanel1.Padding = new Padding(24, 64, 24, 16);
			materialExpansionPanel1.Size = new Size(895, 331);
			materialExpansionPanel1.TabIndex = 52;
			materialExpansionPanel1.Title = "Verification";
			materialExpansionPanel1.UseAccentColor = true;
			materialExpansionPanel1.ValidationButtonEnable = true;
			materialExpansionPanel1.ValidationButtonText = "Next";
			materialExpansionPanel1.SaveClick += materialExpansionPanel1_ValidationButton_Click;
			materialExpansionPanel1.Click += materialExpansionPanel1_panelClick;
			materialExpansionPanel1.Paint += materialExpansionPanel_Step1;
			// 
			// ticketID_btn
			// 
			ticketID_btn.BackColor = SystemColors.ActiveCaption;
			ticketID_btn.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			ticketID_btn.Location = new Point(416, 55);
			ticketID_btn.Name = "ticketID_btn";
			ticketID_btn.Size = new Size(75, 22);
			ticketID_btn.TabIndex = 38;
			ticketID_btn.Text = "Search";
			ticketID_btn.UseVisualStyleBackColor = false;
			ticketID_btn.Click += searchTicket_btnClick;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.BackColor = Color.Lavender;
			label6.Location = new Point(19, 54);
			label6.Name = "label6";
			label6.Size = new Size(184, 23);
			label6.TabIndex = 37;
			label6.Text = "Search with ticket ID";
			label6.Click += label6_Click;
			// 
			// ticketID_textbox
			// 
			ticketID_textbox.BorderStyle = BorderStyle.FixedSingle;
			ticketID_textbox.Font = new Font("Microsoft Sans Serif", 12F);
			ticketID_textbox.Location = new Point(225, 54);
			ticketID_textbox.Name = "ticketID_textbox";
			ticketID_textbox.Size = new Size(185, 26);
			ticketID_textbox.TabIndex = 36;
			ticketID_textbox.TextChanged += ticketID_textbox_TextChanged;
			// 
			// materialLabel1
			// 
			materialLabel1.AutoSize = true;
			materialLabel1.Depth = 0;
			materialLabel1.Enabled = false;
			materialLabel1.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
			materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
			materialLabel1.ForeColor = Color.Black;
			materialLabel1.HighEmphasis = true;
			materialLabel1.Location = new Point(20, 296);
			materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
			materialLabel1.Name = "materialLabel1";
			materialLabel1.Size = new Size(283, 14);
			materialLabel1.TabIndex = 34;
			materialLabel1.Text = "Note:  * indicates the fields that are mandatory to fill";
			materialLabel1.Click += materialLabel1_Click;
			// 
			// materialExpansionPanel2
			// 
			materialExpansionPanel2.BackColor = Color.FromArgb(255, 255, 255);
			materialExpansionPanel2.BackgroundImageLayout = ImageLayout.Center;
			materialExpansionPanel2.BorderStyle = BorderStyle.Fixed3D;
			materialExpansionPanel2.CancelButtonText = "";
			materialExpansionPanel2.Collapse = true;
			materialExpansionPanel2.Controls.Add(tempBox);
			materialExpansionPanel2.Controls.Add(progressBar_RM);
			materialExpansionPanel2.Controls.Add(streetBox);
			materialExpansionPanel2.Controls.Add(button4);
			materialExpansionPanel2.Controls.Add(userAddress);
			materialExpansionPanel2.Controls.Add(button2);
			materialExpansionPanel2.Controls.Add(RMBox);
			materialExpansionPanel2.Controls.Add(cityBox);
			materialExpansionPanel2.Controls.Add(OUBox);
			materialExpansionPanel2.Controls.Add(stateBox);
			materialExpansionPanel2.Controls.Add(payrollID);
			materialExpansionPanel2.Controls.Add(label5);
			materialExpansionPanel2.Controls.Add(costCenter);
			materialExpansionPanel2.Controls.Add(countryBox);
			materialExpansionPanel2.Controls.Add(label4);
			materialExpansionPanel2.Controls.Add(zipBox);
			materialExpansionPanel2.Controls.Add(cCenter);
			materialExpansionPanel2.Controls.Add(orgUnit);
			materialExpansionPanel2.Controls.Add(label3);
			materialExpansionPanel2.Controls.Add(payID);
			materialExpansionPanel2.Controls.Add(label1);
			materialExpansionPanel2.Controls.Add(reportingManager);
			materialExpansionPanel2.Controls.Add(label2);
			materialExpansionPanel2.Depth = 0;
			materialExpansionPanel2.Description = "";
			materialExpansionPanel2.ExpandHeight = 338;
			materialExpansionPanel2.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
			materialExpansionPanel2.ForeColor = Color.FromArgb(222, 0, 0, 0);
			materialExpansionPanel2.Location = new Point(14, 346);
			materialExpansionPanel2.Margin = new Padding(16, 1, 16, 0);
			materialExpansionPanel2.MouseState = MaterialSkin.MouseState.HOVER;
			materialExpansionPanel2.Name = "materialExpansionPanel2";
			materialExpansionPanel2.Padding = new Padding(24, 64, 24, 16);
			materialExpansionPanel2.Size = new Size(892, 48);
			materialExpansionPanel2.TabIndex = 53;
			materialExpansionPanel2.Title = "Create User";
			materialExpansionPanel2.UseAccentColor = true;
			materialExpansionPanel2.ValidationButtonText = "";
			materialExpansionPanel2.SaveClick += materialExpansionPanel2_SaveClick;
			materialExpansionPanel2.Click += materialExpansionPanel2_panelClick;
			materialExpansionPanel2.Paint += materialExpansionPanel_Step2;
			// 
			// tempBox
			// 
			tempBox.BorderStyle = BorderStyle.FixedSingle;
			tempBox.Cursor = Cursors.IBeam;
			tempBox.Font = new Font("Microsoft Sans Serif", 12F);
			tempBox.Location = new Point(241, 123);
			tempBox.Name = "tempBox";
			tempBox.Size = new Size(185, 26);
			tempBox.TabIndex = 52;
			tempBox.Tag = "";
			// 
			// progressBar_RM
			// 
			progressBar_RM.Location = new Point(242, 168);
			progressBar_RM.Name = "progressBar_RM";
			progressBar_RM.Size = new Size(184, 10);
			progressBar_RM.TabIndex = 51;
			progressBar_RM.Click += progressBar1_Click;
			// 
			// streetBox
			// 
			streetBox.BorderStyle = BorderStyle.FixedSingle;
			streetBox.Font = new Font("Microsoft Sans Serif", 12F);
			streetBox.Location = new Point(672, 85);
			streetBox.Name = "streetBox";
			streetBox.Size = new Size(147, 26);
			streetBox.TabIndex = 14;
			streetBox.TextChanged += street_Textbox;
			// 
			// button4
			// 
			button4.Location = new Point(259, 226);
			button4.Name = "button4";
			button4.Size = new Size(148, 28);
			button4.TabIndex = 11;
			button4.Text = "Load Org. unit";
			button4.UseVisualStyleBackColor = true;
			button4.Click += ou_BtnClick;
			// 
			// userAddress
			// 
			userAddress.AutoSize = true;
			userAddress.BackColor = Color.Lavender;
			userAddress.FlatStyle = FlatStyle.Popup;
			userAddress.Font = new Font("Times New Roman", 15.75F);
			userAddress.ForeColor = Color.Black;
			userAddress.Location = new Point(509, 47);
			userAddress.Name = "userAddress";
			userAddress.Size = new Size(91, 23);
			userAddress.TabIndex = 12;
			userAddress.Text = "Address *";
			// 
			// button2
			// 
			button2.BackColor = SystemColors.GradientActiveCaption;
			button2.BackgroundImageLayout = ImageLayout.None;
			button2.FlatAppearance.BorderColor = Color.White;
			button2.Location = new Point(508, 238);
			button2.Name = "button2";
			button2.Size = new Size(116, 30);
			button2.TabIndex = 13;
			button2.Text = "Select Address";
			button2.UseVisualStyleBackColor = false;
			button2.Click += addressList_BtnClick;
			// 
			// RMBox
			// 
			RMBox.Font = new Font("Microsoft Sans Serif", 12F);
			RMBox.FormattingEnabled = true;
			RMBox.Location = new Point(241, 94);
			RMBox.Name = "RMBox";
			RMBox.Size = new Size(185, 28);
			RMBox.TabIndex = 6;
			RMBox.SelectedIndexChanged += RMBox_SelectedIndexChanged;
			// 
			// cityBox
			// 
			cityBox.BorderStyle = BorderStyle.FixedSingle;
			cityBox.Font = new Font("Microsoft Sans Serif", 12F);
			cityBox.Location = new Point(672, 114);
			cityBox.Name = "cityBox";
			cityBox.Size = new Size(147, 26);
			cityBox.TabIndex = 15;
			cityBox.TextChanged += city_TextBox;
			// 
			// OUBox
			// 
			OUBox.Font = new Font("Microsoft Sans Serif", 12F);
			OUBox.FormattingEnabled = true;
			OUBox.Location = new Point(242, 195);
			OUBox.Name = "OUBox";
			OUBox.Size = new Size(186, 28);
			OUBox.TabIndex = 7;
			OUBox.SelectedIndexChanged += organisationalUnit_comboBox;
			OUBox.Click += ouList_Click;
			// 
			// stateBox
			// 
			stateBox.BorderStyle = BorderStyle.FixedSingle;
			stateBox.Font = new Font("Microsoft Sans Serif", 12F);
			stateBox.Location = new Point(672, 143);
			stateBox.Name = "stateBox";
			stateBox.Size = new Size(147, 26);
			stateBox.TabIndex = 16;
			stateBox.TextChanged += state_TextBox;
			// 
			// zipBox
			// 
			zipBox.BorderStyle = BorderStyle.FixedSingle;
			zipBox.Font = new Font("Microsoft Sans Serif", 12F);
			zipBox.Location = new Point(672, 201);
			zipBox.Name = "zipBox";
			zipBox.Size = new Size(147, 26);
			zipBox.TabIndex = 18;
			zipBox.TextChanged += ZIP_TextBox;
			// 
			// orgUnit
			// 
			orgUnit.AutoSize = true;
			orgUnit.BackColor = Color.Lavender;
			orgUnit.Font = new Font("Times New Roman", 15.75F);
			orgUnit.ForeColor = Color.Black;
			orgUnit.Location = new Point(17, 197);
			orgUnit.Name = "orgUnit";
			orgUnit.Size = new Size(174, 23);
			orgUnit.TabIndex = 8;
			orgUnit.Text = "Organisation Unit *";
			// 
			// adminLogin
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			AutoScroll = true;
			BackColor = Color.MintCream;
			ClientSize = new Size(927, 665);
			Controls.Add(materialExpansionPanel2);
			Controls.Add(btnCreateUser);
			Controls.Add(btnClearForm);
			Controls.Add(btnAdminLogin);
			Controls.Add(materialExpansionPanel1);
			ForeColor = Color.Black;
			Margin = new Padding(3, 2, 3, 2);
			Name = "adminLogin";
			Text = "User Creation Tool (Detmold Group)";
			Load += MainForm_Load;
			materialExpansionPanel1.ResumeLayout(false);
			materialExpansionPanel1.PerformLayout();
			materialExpansionPanel2.ResumeLayout(false);
			materialExpansionPanel2.PerformLayout();
			ResumeLayout(false);
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
		private Label costCenter;
		private Label passWord;
		private Label discSuffix;
		private ComboBox domainList;
		private Button verify;
		private Button btnClearForm;
		private Button btnCreateUser;
		private Button btnAdminLogin;
		private ComboBox disclaimerSuffix;
		private ComboBox cCenter;
		private TextBox passwordBox;
		private TextBox jTitle;
		private TextBox payrollID;
		private CheckBox passwordCheckBox;
		private Button button1;
		private TextBox countryBox;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private TextBox inputFNAME;
		private Label fName;
		private MaterialSkin.Controls.MaterialExpansionPanel materialExpansionPanel1;
		private MaterialSkin.Controls.MaterialExpansionPanel materialExpansionPanel2;
		private MaterialSkin.Controls.MaterialLabel materialLabel1;
		private ProgressBar progressBar_RM;
		private TextBox streetBox;
		private Button button4;
		private Label userAddress;
		private Button button2;
		private ComboBox RMBox;
		private TextBox cityBox;
		private ComboBox OUBox;
		private TextBox stateBox;
		private TextBox zipBox;
		private Label orgUnit;
		private Label label6;
		private TextBox ticketID_textbox;
		private Button ticketID_btn;
		private TextBox tempBox;
	}
}
