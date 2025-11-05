using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
	internal class Teacher : Human
	{
		public string Speciality { get; set; }
		public int Experience { get; set; }

		public Teacher
			(
			string lastName, string firstName, int age,
            string speciality, int experience
			):base (lastName, firstName, age)
		{
			Speciality = speciality;
			Experience = experience;
			Console.WriteLine($"TConstructor:\t{GetHashCode()}");
		}

		public Teacher(Human human, string speciality, int experience) : base(human)
		{
			Speciality=speciality;
			Experience = experience;
		}
		~Teacher ()
		{
			Console.WriteLine($"TDestructor:\t{GetHashCode()}");
		}

		public void Info()
		{
			base.Info();
			Console.WriteLine($"{Speciality} {Experience}");
		}

		public override string ToString()
		{
			return base.ToString() + $"{Speciality.PadRight(25)}{Experience}";
		}

		public override string ToStringCSV()
		{
			return base.ToStringCSV() +
				$",{Speciality}, {Experience}";
		}

	}
}
