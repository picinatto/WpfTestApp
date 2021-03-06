﻿using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Text;
using WpfTestApp.Models;

namespace WpfTestApp.ViewModels
{
	public class ShellViewModel : Conductor<object>
	{
		private string _firstName = "Ricardo";
		private string _lastName;
		private BindableCollection<PersonModel> _people = new BindableCollection<PersonModel>();
		private PersonModel _selectedPerson;

		public ShellViewModel()
		{
			People.Add(new PersonModel { FirstName = "Ricardo", LastName = "Picinatto" });
			People.Add(new PersonModel { FirstName = "Mariana", LastName = "Bazotti" });
			People.Add(new PersonModel { FirstName = "Batman", LastName = "Robin" });
		}

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

		public BindableCollection<PersonModel> People
		{
			get { return _people; }
			set { _people = value; }
		}

		public PersonModel SelectedPerson
		{
			get { return _selectedPerson; }
			set 
			{ 
				_selectedPerson = value;
				NotifyOfPropertyChange(() => SelectedPerson);
			}
		}

		public bool CanClearText(string firstName, string lastName)
		{
			if (String.IsNullOrWhiteSpace(firstName) && String.IsNullOrWhiteSpace(lastName))
			{
				return false;
			}
			else
			{
				return true;
			}
		}
		public void ClearText(string firstName, string lastName)
		{
			FirstName = "";
			LastName = "";
		}
	
		public void LoadPageOne()
		{
			ActivateItem(new FirstChildViewModel());
		}
		public void LoadPageTwo()
		{
			ActivateItem(new SecondChildViewModel());
		}
	}
}
