namespace UserMaker.Forms
{
	partial class adminForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminForm));
			usernameBox = new ComboBox();
			adminPassword = new TextBox();
			label_username = new Label();
			label_password = new Label();
			btnAdminLogin = new Button();
			btnAdminCancel = new Button();
			progressBar_mail = new MaterialSkin.Controls.MaterialProgressBar();
			SuspendLayout();
			// 
			// usernameBox
			// 
			usernameBox.FormattingEnabled = true;
			usernameBox.Items.AddRange(new object[] { "aayush.gurung@detmoldgroup.com" });
			usernameBox.Location = new Point(125, 35);
			usernameBox.Name = "usernameBox";
			usernameBox.Size = new Size(121, 23);
			usernameBox.TabIndex = 0;
			// 
			// adminPassword
			// 
			adminPassword.BorderStyle = BorderStyle.FixedSingle;
			adminPassword.Location = new Point(125, 82);
			adminPassword.Name = "adminPassword";
			adminPassword.PasswordChar = '*';
			adminPassword.Size = new Size(121, 23);
			adminPassword.TabIndex = 1;
			adminPassword.TextChanged += adminPassword_TextChanged;
			// 
			// label_username
			// 
			label_username.AutoSize = true;
			label_username.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label_username.Location = new Point(34, 43);
			label_username.Name = "label_username";
			label_username.Size = new Size(60, 15);
			label_username.TabIndex = 2;
			label_username.Text = "Username";
			// 
			// label_password
			// 
			label_password.AutoSize = true;
			label_password.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label_password.Location = new Point(34, 84);
			label_password.Name = "label_password";
			label_password.Size = new Size(55, 15);
			label_password.TabIndex = 3;
			label_password.Text = "Password";
			// 
			// btnAdminLogin
			// 
			btnAdminLogin.FlatStyle = FlatStyle.System;
			btnAdminLogin.Location = new Point(34, 124);
			btnAdminLogin.Name = "btnAdminLogin";
			btnAdminLogin.Size = new Size(75, 23);
			btnAdminLogin.TabIndex = 4;
			btnAdminLogin.Text = "OK";
			btnAdminLogin.UseVisualStyleBackColor = true;
			btnAdminLogin.Click += adminBtnOKClick;
			// 
			// btnAdminCancel
			// 
			btnAdminCancel.Location = new Point(171, 124);
			btnAdminCancel.Name = "btnAdminCancel";
			btnAdminCancel.Size = new Size(75, 23);
			btnAdminCancel.TabIndex = 5;
			btnAdminCancel.Text = "Cancel";
			btnAdminCancel.UseVisualStyleBackColor = true;
			btnAdminCancel.Click += adminBtnCancelClick;
			// 
			// progressBar_mail
			// 
			progressBar_mail.Depth = 0;
			progressBar_mail.Location = new Point(63, 153);
			progressBar_mail.MouseState = MaterialSkin.MouseState.HOVER;
			progressBar_mail.Name = "progressBar_mail";
			progressBar_mail.Size = new Size(173, 5);
			progressBar_mail.TabIndex = 6;
			progressBar_mail.Click += materialProgressBar1_Click;
			// 
			// adminForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(302, 168);
			Controls.Add(progressBar_mail);
			Controls.Add(btnAdminCancel);
			Controls.Add(btnAdminLogin);
			Controls.Add(label_password);
			Controls.Add(label_username);
			Controls.Add(adminPassword);
			Controls.Add(usernameBox);
			Icon = (Icon)resources.GetObject("$this.Icon");
			MaximizeBox = false;
			Name = "adminForm";
			Text = "Windows PowerShell Credential Request";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ComboBox usernameBox;
		private TextBox adminPassword;
		private Label label_username;
		private Label label_password;
		private Button btnAdminLogin;
		private Button btnAdminCancel;
		private MaterialSkin.Controls.MaterialProgressBar progressBar_mail;
	}
}