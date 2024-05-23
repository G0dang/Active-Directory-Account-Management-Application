using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserMaker.Class
{
	internal class ClearFields
	{
		public void ClearControls(Control.ControlCollection controls)
		{
			foreach (Control control in controls)
			{
				if (control is TextBox textBox)
				{
					textBox.Clear();
				}
				else if (control is ComboBox comboBox)
				{
					comboBox.SelectedIndex = -1;
					comboBox.Text = "";
				}
				else if (control is CheckBox checkBox)
				{
					checkBox.Checked = false;
				}

				// Recursively clear nested controls
				if (control.HasChildren)
				{
					ClearControls(control.Controls);
				}
			}
		}
	}
}
