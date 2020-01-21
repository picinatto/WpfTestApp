using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Text;

namespace WpfTestApp.ViewModels
{
    public class ShellViewModel : Screen
    {
		private string _firstName = "Ricardo";

		public string FirstName
		{
			get { return _firstName; }
			set 
			{ 
				_firstName = value;
				NotifyOfPropertyChange(() => FirstName);
				NotifyOfPropertyChange(() => FullName);
			}
		}

		private string _lastName = "Picinatto";

		public string LastName
		{
			get { return _lastName; }
			set 
			{ 
				_lastName = value;
				NotifyOfPropertyChange(() => LastName);
				NotifyOfPropertyChange(() => FullName);
			}
		}

		public string FullName
		{
			get { return $"{FirstName} {LastName}"; }
		}

	}
}
