using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TallerXamarin1
{
	public partial class TallerXamarin1Page : ContentPage
	{
		public TallerXamarin1Page()
		{
			InitializeComponent();
			Button btn = new Button();

		}

		async void Handle_Clicked(object sender, System.EventArgs e)
		{
			var contacts = await GetContacts();
			lvContacts.ItemsSource = contacts;
		}

		const string uri = "http://adventureservicedemo.azurewebsites.net/Api/Contacts";

		public async Task<List<Contact>> GetContacts()
		{
			List<Contact> result = null;

			HttpRequestMessage getContactsRequest =
				new HttpRequestMessage();
			getContactsRequest.RequestUri = new Uri(uri);
			getContactsRequest.Headers.Add("Accept", "application/json");
			getContactsRequest.Method = HttpMethod.Get;

			HttpClient client = new HttpClient();

			HttpResponseMessage getContactsResponse =
				 await client.SendAsync(getContactsRequest);
			if (getContactsResponse.StatusCode == HttpStatusCode.OK)
			{
				result =
					Newtonsoft.Json.JsonConvert.DeserializeObject<List<Contact>>
							  (await getContactsResponse.Content.ReadAsStringAsync());
			}

			return result;
		}
	}
}
