using System;
namespace Hillel_Lesson26_HW.Models
{
	public class ContactsModel
	{
		private string _phoneNumber;
		private string _email;
		private string _telegram;
		private string _linkedin;

		public string PhoneNumber
		{
			get
			{
				return _phoneNumber;
			}
			set
			{
				_phoneNumber = value;
			}
		}

        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
            }
        }

        public string Telegram
        {
            get
            {
                return _telegram;
            }
            set
            {
                _telegram = value;
            }
        }

        public string Linkedin
        {
            get
            {
                return _linkedin;
            }
            set
            {
                _linkedin = value;
            }
        }
    }
}

