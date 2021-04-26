using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeworkLinq
{
    class Program
    {
		static void Main(string[] args)
		{
			List<Person> people = new List<Person>()
			{
			new Person("Bill", "Smith", 41, 'M'),
			new Person("Sarah", "Jones", 22, 'F'),
			new Person("Stacy","Baker", 21, 'F'),
			new Person("Vivianne","Dexter", 19, 'F' ),
			new Person("Bob","Smith", 49, 'M' ),
			new Person("Brett","Baker", 51, 'M' ),
			new Person("Mark","Parker", 19, 'M'),
			new Person("Alice","Thompson", 18, 'F'),
			new Person("Evelyn","Thompson", 58, 'F' ),
			new Person("Mort","Martin", 58, 'M'),
			new Person("Eugene","deLauter", 84, 'M' ),
			new Person("Gail","Dawson", 19, 'F' ),
			};

			Console.WriteLine("1.All people aged 50 or more");
			List<string> overAged50 = people
									.Where(x => x.Age >= 50)
									.Select(x => x.FirstName)
									.ToList();
			overAged50.ForEach(x => Console.WriteLine(x));

			Console.WriteLine("2.All people name starts with B");
			List<Person> nameS = people
								.Where(x => x.FirstName.StartsWith("B"))
								.ToList();
			nameS.ForEach(x => Console.WriteLine(x.FirstName));

			Console.WriteLine("3.First person whose surname starts with T");
			Person surnameT = people
							.Where(x => x.LastName.StartsWith("T"))
							.FirstOrDefault();
			Console.WriteLine(surnameT.LastName);
			Console.WriteLine("4.Find youngest and oldest person");
			List <Person> youngestAndOldest = people
											.OrderBy(x => x.Age)
											.ToList();
			Console.WriteLine($"{youngestAndOldest.FirstOrDefault().FirstName} is youngest and {youngestAndOldest.LastOrDefault().FirstName} is oldest");

			Console.WriteLine("5.Find all male people aged 45 or more");
			List<Person> maleOver45 = people
									.Where(x => x.Age > 45 && x.Gender == 'M')
									.ToList();
			maleOver45.ForEach(x => Console.WriteLine(x.FirstName));

			Console.WriteLine("6.find all females whose name starts with v");
			List<Person> femalestartswithV=people
									.Where(x => x.FirstName.StartsWith("V"))
									.ToList();
			femalestartswithV.ForEach(x => Console.WriteLine(x.FirstName));

			Console.WriteLine("7.Find last female person older than 30 whose name starts with p");
			Person femaleolder30 = people
										.Where(x => x.Age > 30)
										.Where(x => x.Gender == 'F')
										.Where(x => x.FirstName.StartsWith("P"))
										.FirstOrDefault();
										
			Console.WriteLine(femaleolder30 == null ? "No such person/female" : $"Female person older than 30 with P {femaleolder30.FirstName}");

			Console.WriteLine("8.Find first male younger than 40");
			Person maleOver40 = people
									.Where(x => x.Age > 40)
									.Where(x => x.Gender == 'M')
									.First();
			Console.WriteLine($"Male over 40first is {maleOver40.FirstName}");

			Console.WriteLine("9.Print the names of the male persons that have firstName longer than lastName");
			List<string> malePersonsLongFirstNames = people
														.Where(x => x.FirstName.Length > x.LastName.Length && x.Gender == 'M')
														.Select(x => x.FirstName)
														.ToList();
			malePersonsLongFirstNames.ForEach(x => Console.WriteLine($"{x}"));

			Console.WriteLine("10.Print the lastNames of the female persons that have odd number of ages");
			List<string> femaleOddAges = people
									.Where(x => x.Age % 2 == 1)
									.Select(x => x.LastName)
									.ToList();
			femaleOddAges.ForEach(x => Console.WriteLine($"{x}"));


			Console.ReadLine();
		}
    }
}
