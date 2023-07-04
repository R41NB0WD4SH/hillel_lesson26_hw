using System;
namespace Hillel_Lesson26_HW.Models
{
	public class ProjectsModel
	{

		private List<string> _projectsUrls = new List<string>();

		public List<string> ProjectsUrls
		{
			get
			{
				return _projectsUrls;
			}
			set
			{
				_projectsUrls = value;
			}
		}
	}
}

