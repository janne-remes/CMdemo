using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Text;

namespace WPFUI.ViewModels
{
    public class ShellViewModel : Screen
    {
		private string _firstName;
		private string _lastName;

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
	}
}
