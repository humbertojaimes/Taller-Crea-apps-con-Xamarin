using System;
namespace TallerXamarin1
{
	public class Contact 
	{

		private string id;

		public string ID
		{
			get { return id.Trim(); }
			set { id = value.Trim();  }
		}


		private string fullName;

		public string FullName
		{
			get { return fullName; }
			set { fullName = value;  }
		}

		private string email;

		public string Email
		{
			get { return email; }
			set { email = value;  }
		}


		private string phoneNumber;

		public string PhoneNumber
		{
			get { return phoneNumber; }
			set { phoneNumber = value;  }
		}

	}
}
