using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataBinding
{
	public class ContactGenerator
	{
		private static List<string> FirstNames = new List<string> {
			"Nicole", "Ellen", "Anne", "Tori", "Mia", "Maria",
			"Asa", "Alexis", "Lexi", "Kayden", "Sunny", "Jenna"
		};

		private static List<string> LastNames = new List<string> {
			"Anderson", "Adarna", "Curtis", "Black", "Khalifa", "Ozawa",
			"Akira", "Texas", "Belle", "Kross", "Leone", "Haze"
		};

		public static async Task<List<Contact>> CreateContacts(){
			var random = new Random ();
			List<Contact> contacts = new List<Contact> ();
			for (int i = 0; i < 11; i++) {
				string first = FirstNames [random.Next (FirstNames.Count - 1)];
				string last = LastNames [random.Next (LastNames.Count - 1)];
				first = InitCap (first);
				last = InitCap (last);
				Contact contact = new Contact ();
				contact.FirstName = first;
				contact.LastName = last;
				contact.Email = string.Format("{0}@gmail.com",first);
				contacts.Add (contact);
			}
			return contacts;
		}

		private static string InitCap(string value) {
			char[] array = value.ToCharArray ();

			for (int i = 1; i < array.Length; i++) {
				array [i] = char.ToLower (array [i]);
			}

			if (array.Length >=1) {
				array [0] = char.ToUpper (array [0]);
			}

			for (int i = 1; i < array.Length; i++) {
				if (array [i - 1] == ' ') {
					array [i] = char.ToUpper (array [i]);
				}
			}
			return new string (array);
		}
	}
}

