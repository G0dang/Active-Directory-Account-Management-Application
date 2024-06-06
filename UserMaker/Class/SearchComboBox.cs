using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserMaker.Class
{
	internal class SearchComboBox
	{
		public void SelectComboBoxItemContains(ComboBox comboBox, string searchMe)
		{
			// Loop through all items in the ComboBox
			for (int i = 0; i < comboBox.Items.Count; i++)
			{
				// Get the current item as a string
				string currentItem = comboBox.GetItemText(comboBox.Items[i]);

				// Check if the current item contains the target substring
				if (currentItem.Contains(searchMe, StringComparison.OrdinalIgnoreCase))
				{
					// Select the item if it contains the substring
					comboBox.SelectedIndex = i;
					return;
				}
			}

			MessageBox.Show($"Item containing '{searchMe}' not found in the ComboBox.");
		}
	}
}
