using System;
using System.Linq;
using System.Linq.Expressions;
using MonoTouch.UIKit;
using System.Drawing;
using System.Collections.Generic;

namespace TechBreakfastiPhone
{
	public class MainController : UIViewController
	{
		private IList<Person> _personList;

		public MainController ()
		{
			this.View = new LoginView(this);

			_personList = new List<Person> ();
			_personList.Add (new Person{ FirstName = "Bob", LastName = "Smith" });
			_personList.Add (new Person{ FirstName = "Jane", LastName = "Doe" });
			_personList.Add (new Person{ FirstName = "Cindy", LastName = "White" });
			_personList.Add (new Person{ FirstName = "Robert", LastName = "Long" });
			_personList.Add (new Person{ FirstName = "William", LastName = "Jackson" });
		}

		public bool IsValidLogin(string username, string password)
		{
			return username == "admin" && password == "test";
		}

		public void ShowMainScreen()
		{
			this.View = new MainView (this);
		}

		public string[] GetNames()
		{
			return _personList.Where (x => x.LastName.Length > 3).OrderBy (x => x.FirstName)
					.Select (x => x.FirstName).ToArray();
		}

		private class Person
		{
			public string FirstName { get; set; }
			public string LastName { get; set; }
		}
	}
}

