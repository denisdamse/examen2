using System;
namespace examen2
{
	public static class PersonProcessor
	{
		public static Person oldest(Person[] p)
		{
			int maximum = p[0].Age;
			int maxindex = -1;
			for (int i = 0; i < p.Length; i++)
			{
				if (maximum > p[0].Age)
				{ maximum = p[i].Age;
				maxindex = i;}

			}
			p[0].FirstName = p[maxindex].FirstName;
			p[0].LastName = p[maxindex].LastName;
			p[0].YearOfBirth = p[maxindex].YearOfBirth;
			return p;
		}
	}
}

