using System;
namespace Hillel_Lesson26_HW.Models
{
	public class AboutMeModel
	{

		private string _firstName = string.Empty;
		private string _lastName = string.Empty;
		private List<string> _hardSkills = new List<string>();
		private List<string> _softSkills = new List<string>();
		


        public string FirstName
		{
			get
			{
				return _firstName;
			}
			set
			{
				_firstName = value;
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
			}
		}

		public List<string> HardSkills
		{
			get
			{
				return _hardSkills;
			}
			set
			{
				_hardSkills = value;
			}
		}

		public List<string> SoftSkills
		{
			get
			{
				return _softSkills;
			}
			set
			{
				_softSkills = value;
			}
		}

	}
}

