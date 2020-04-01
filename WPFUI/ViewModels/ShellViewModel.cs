using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Text;
using WPFUI.Models;

namespace WPFUI.ViewModels
{
    public class ShellViewModel : Conductor<Object>
    {
		private string _firstName;
		private string _lastName;
		private BindableCollection<PersonModel> _people = new BindableCollection<PersonModel>();
		private PersonModel _selectedPerson;

		public ShellViewModel()
		{
			People.Add(new PersonModel { FirstName = "Vesa-Matti", LastName = "Loiri" });
			People.Add(new PersonModel { FirstName = "Paula", LastName = "Koivuniemi" });
			People.Add(new PersonModel { FirstName = "Pekka", LastName = "Pouta" });
		}

		public string FirstName
		{
			get
			{
				return _firstName;
			}

			set
			{
				_firstName = value;
				NotifyOfPropertyChange(() => FirstName);
				NotifyOfPropertyChange(() => FullName);
			}
		}
		
		public string LastName
		{
			get
			{
				return _lastName;
			}

			set
			{
				_lastName = value;
				NotifyOfPropertyChange(() => LastName);
				NotifyOfPropertyChange(() => FullName);
			}
		}
		
		public string FullName
		{
			get
			{
				return $"{ FirstName } { LastName }";
			}
		}

		public BindableCollection<PersonModel> People
		{
			get
			{
				return _people;
			}

			set
			{
				_people = value;
			}
		}
		
		public PersonModel SelectedPerson
		{
			get
			{
				return _selectedPerson;
			}
			
			set
			{
				_selectedPerson = value;
				NotifyOfPropertyChange(() => SelectedPerson);
			}
		}

		public bool CanClearText(string firstName, string lastName)
		{
			//return !String.IsNullOrWhiteSpace(firstName) && String.IsNullOrWhiteSpace(lastName);

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
			ActivateItemAsync(new FirstChildViewModel(), System.Threading.CancellationToken.None);
		}

		public void LoadPageTwo()
		{
			ActivateItemAsync(new SecondChildViewModel(), System.Threading.CancellationToken.None);
		}
	}
}
