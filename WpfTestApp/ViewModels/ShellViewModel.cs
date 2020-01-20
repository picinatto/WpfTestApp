using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Text;

namespace WpfTestApp.ViewModels
{
    public class ShellViewModel : Screen
    {
		private string _firstName;

		public string FirstName
		{
			get { return _firstName; }
			set { _firstName = value; }
		}

	}
}
