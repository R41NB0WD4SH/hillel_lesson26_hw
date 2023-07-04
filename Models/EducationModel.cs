using System;
namespace Hillel_Lesson26_HW.Models
{
	public class EducationModel
	{

		private string _universityName;
		private string _specialization;
		private string _degree;
		private string _studyingPeriod;
        private List<EducationModel> _educationModels = new List<EducationModel>();

		public string UniversityName
		{
			get
			{
				return _universityName;
			}
			set
			{
				_universityName = value;
			}
		}

        public string Specialization
        {
            get
            {
                return _specialization;
            }
            set
            {
                _specialization = value;
            }
        }

        public string Degree
        {
            get
            {
                return _degree;
            }
            set
            {
                _degree = value;
            }
        }

        public string StydingPeriod
        {
            get
            {
                return _studyingPeriod;
            }
            set
            {
                _studyingPeriod = value;
            }
        }

        public List<EducationModel> EducationModels
        {
            get
            {
                return _educationModels;
            }
            set
            {
                _educationModels = value;
            }
        }

    }
}

