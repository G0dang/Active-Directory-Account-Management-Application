﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserMaker.Class
{
	internal class UserInformation
	{
		public string DisplayName { get; set; }
		public string SamAccountName { get; set; }	
		public string DistinguishedName { get; set; }

		public override string ToString()
		{
			return DisplayName; // Display only the DisplayName in ComboBox
		}

		
	}
}
