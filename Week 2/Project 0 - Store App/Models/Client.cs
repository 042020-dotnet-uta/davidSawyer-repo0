using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Project0_App
{
    public class Client
    {
		private int _ClientID;
		[Key]
		public int ClientID
		{
			get { return _ClientID; }
			set { _ClientID = value; }
		}

		private string _FName;

		public string FName
		{
			get { return _FName; }
			set { _FName = value; }
		}

		private string _LName;

		public string LName
		{
			get { return _LName; }
			set { _LName = value; }
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
		public virtual ICollection<Order> Orders { get; set; }
		// Add new customer menu

	}
}
