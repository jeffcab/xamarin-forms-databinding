using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Threading.Tasks;

namespace DataBinding
{
	public partial class MainPage : ContentPage
	{
//		public Contact TheContact { get; set; }
		public List<Contact> Contacts {get; set;}

		public MainPage ()
		{
//			var TheContact = new Contact();
//			TheContact.FirstName = "Jepoy";
//			TheContact.LastName = "Apoy";
//			TheContact.Email = "jepoyapoy@gmail.com";
//			BindingContext = TheContact;
			Init();
			InitializeComponent ();
		}

		private async Task Init() {
			Contacts = new List<Contact> ();
			var listOfContacts = new List<Contact> ();
			listOfContacts = await ContactGenerator.CreateContacts ();
			Contacts = listOfContacts;
			BindingContext = this;
		}

		public void OnItemTapped(object o, ItemTappedEventArgs e){
			var contact = e.Item as Contact;
			if (e != null) {
				DisplayAlert("Contact", String.Format("You Selected {0} {1}",
					contact.FirstName, contact.LastName), "Ok");
			}
		}
	}
}

