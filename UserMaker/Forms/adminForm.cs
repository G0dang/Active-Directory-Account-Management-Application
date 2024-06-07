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
using System.Threading.Tasks;
using System.Windows.Forms;
using static UserMaker.Class.mailConnection;

namespace UserMaker.Forms
{
	public partial class adminForm : Form
	{
		public adminForm()
		{
			InitializeComponent();
		}

		private void adminBtnOKClick(object sender, EventArgs e)
		{

		}
		private void adminBtnCancelClick(object sender, EventArgs e)
		{
			this.Close();

		}
	}
}
