using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
	internal class Graduate : Student
	{
		public string Subject { get; set; }

		public Graduate
			(
			string lastName, string firstName, int age,
			string speciality, string group, double rating, double attendance,string subject
			) : base(lastName, firstName, age, speciality, group, rating, attendance)
		{
			Subject=subject;
		}

		public Graduate(Student student, string subject) : base(student)
		{
			Subject = subject;
		}

		~Graduate()
		{
			Console.WriteLine($"GDestructor:\t{GetHashCode()}");
		}

		public void Info()
		{
			base.Info();
			Console.WriteLine(Subject);
		}

		public override string ToString()
		{
			return base.ToString() + Subject;
		}

		public override string ToStringCSV()
		{
			return base.ToStringCSV() + $",{Subject}";
		}

		public override Human Init(string[] values)
		{
			base.Init(values);
			Subject = values[8];
			return this;
		}

	}
}
