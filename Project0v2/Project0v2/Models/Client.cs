using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Project0v2.Models
{
    public class Client
    {
		private int _ClientID;

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

		private string _UserName;

		public string UserName
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
		// add a new customer
		/*public static AddCustomer() { }
		public AddCustomer(string Fname, string Lname, string UserName, string Password) 
		{
			this.FName = FName;
			this.LName = LName;
			this.UserName = UserName;
			this.Password = Password;
		}*/
	}
}
