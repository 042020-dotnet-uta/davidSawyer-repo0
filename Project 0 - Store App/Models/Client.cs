using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Project_0___Store_App
{
    public class Client
    {
		private int _ClientId;
		[Key]
		public int ClientId
		{
			get { return _ClientId; }
			set { _ClientId = value; }
		}

		private string _Name;

		public string Name
		{
			get { return _Name; }
			set { _Name = value; }
		}

		private int _UserName;

		public int UserName
		{
			get { return _UserName; }
			set { _UserName = value; }
		}

		private string _Password;

		public string Password
		{
			get { return _Password; }
			set { _Password = value; }
		}

		// Add new customer menu

	}
}
