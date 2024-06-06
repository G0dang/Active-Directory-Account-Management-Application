namespace UserMaker
{
	partial class addressCSV
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
			dataGridView1 = new DataGridView();
			btn_refresh = new Button();
			label1 = new Label();
			button1 = new Button();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(8, 33);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.Size = new Size(742, 483);
			dataGridView1.TabIndex = 0;
			dataGridView1.CellContentClick += dataGridView1_CellContentClick;
			// 
			// btn_refresh
			// 
			btn_refresh.BackColor = Color.WhiteSmoke;
			btn_refresh.Location = new Point(93, 524);
			btn_refresh.Name = "btn_refresh";
			btn_refresh.Size = new Size(75, 23);
			btn_refresh.TabIndex = 1;
			btn_refresh.Text = "Refresh";
			btn_refresh.UseVisualStyleBackColor = false;
			btn_refresh.Click += btn_refresh_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
			label1.Location = new Point(22, 11);
			label1.Name = "label1";
			label1.Size = new Size(117, 20);
			label1.TabIndex = 2;
			label1.Text = "ADDRESS LIST";
			// 
			// button1
			// 
			button1.BackColor = Color.WhiteSmoke;
			button1.Location = new Point(12, 524);
			button1.Name = "button1";
			button1.Size = new Size(75, 23);
			button1.TabIndex = 3;
			button1.Text = "Select";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// addressCSV
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(762, 559);
			Controls.Add(button1);
			Controls.Add(label1);
			Controls.Add(btn_refresh);
			Controls.Add(dataGridView1);
			Name = "addressCSV";
			Text = "addressCSV";
			Load += addressCSV_Load;
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView dataGridView1;
		private Button btn_refresh;
		private Label label1;
		private Button button1;
	}
}