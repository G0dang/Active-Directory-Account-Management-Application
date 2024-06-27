using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.VisualBasic.ApplicationServices;

namespace UserMaker
{
	public partial class addressCSV : Form
	{
		// Declaring a delegate to pass a selected value from the csv to MainForm's AddressBox
		public event EventHandler<string> RowSelected;


		
		public addressCSV()
		{
			InitializeComponent();

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
				string rowData = "";

				foreach (DataGridViewCell cell in selectedRow.Cells)
				{
					rowData += cell.Value != null ? cell.Value.ToString() + "|" : "";
				}
				

				// Raise the RowSelected event with the selected row's data
				RowSelected?.Invoke(this, rowData);

			}
		}

		#region LOAD CSV (Address List) FROM A NEW FORM
		private void addressCSV_Load(object sender, EventArgs e)
		{
			LoadCSV();
		}
		private void LoadCSV()
		{
			try
			{
				// Specify the path to your CSV file

				//file path to be changed to a public network
				string filePath = @"";

				// Read CSV file into a DataTable
				DataTable dt = new DataTable();
				using (StreamReader sr = new StreamReader(filePath))
				{
					string[] headers = sr.ReadLine().Split(',');
					foreach (string header in headers)
					{
						dt.Columns.Add(header);
					}
					while (!sr.EndOfStream)
					{
						string[] rows = sr.ReadLine().Split(';');
						
						dt.Rows.Add(rows);
					}
				}

				// Bind DataTable to DataGridView
				dataGridView1.DataSource = dt;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message);
			}
		}
		//this method will allow the user to refresh the csv file
		private void btn_refresh_Click(object sender, EventArgs e)
		{
			LoadCSV();
		}
		#endregion

		#region Extract the data from the selected row in the DatagridView (AddressForm)
		private void button1_Click(object sender, EventArgs e)
		{
			if (dataGridView1.SelectedRows.Count > 0)
			{
				DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
				string rowData = "";

				//using "|" as a delimiter

				foreach (DataGridViewCell cell in selectedRow.Cells)
				{
					rowData += (cell.Value != null ? cell.Value.ToString() : "") + "|"  ;
				}


				//to ensure there is no comma at the end of the address
				//this method is causing textbox not being populated when the last column is empty/null
				//removed beacuse addressbox is no more in the form
				//if (!string.IsNullOrEmpty(rowData))
				//{
				//	rowData = rowData.TrimEnd('|', ' ');
				//}

				// Raise the RowSelected event with the selected row's data
				RowSelected?.Invoke(this, rowData);
				Close();
			}
			else
			{
				MessageBox.Show("Please select an address first.");
			}
			#endregion
		}
	}
}

