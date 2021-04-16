using HomeMovieRent.Models;
using System;


namespace HomeMovieRent
{
    class Program
    {
 
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Member user01 = new Member();

            Employee employee01 = new Employee();

            User user001 = new User();

            Movie movie01 = new Movie();

            while (true)
            {
                Console.WriteLine("******WELCOME TO VASKO'S MOVIE STORE****");
                Console.WriteLine("========>MENU<========");
                Console.WriteLine("++++++++++++++++++");
                Console.WriteLine("1.For User: ");
                Console.WriteLine("++++++++++++++++++");
                Console.WriteLine("2.For Employee: ");
                Console.WriteLine("++++++++++++++++++");
                Console.WriteLine("3.For renting movie :)");
                Console.WriteLine("++++++++++++++++++");


                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:

                        Console.WriteLine("Sign in to register ");
                        Console.WriteLine("Enter a name: ");
                        user01.FirstName = Console.ReadLine();

                        Console.WriteLine("Enter a last name: ");
                        user01.LastName = Console.ReadLine();

                        Console.WriteLine("Enter your age");
                        user01.Age = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter your user name");
                        user01.UserName = Console.ReadLine();

                        Console.WriteLine("Enter your password");
                        user01.Password = Console.ReadLine();

                        Console.WriteLine("Enter your phone number");
                        user01.PhoneNumber = int.Parse(Console.ReadLine());

                        Console.WriteLine("-------------------------------");

                        Console.WriteLine("Rent a movie for the night");
                        Console.WriteLine("1.Fast and Furious");
                        Console.WriteLine("2.Fast and Furious 2");
                        Console.WriteLine("3.Fast and Furious 3");
                        Console.WriteLine("4.Fast and Furious 4");
                        Console.WriteLine("5.Fast and Furious 5");
                        movie01.Rent();
                        movie01.Info();



                        user01.DisplayInfo();



                        Console.WriteLine("-------------------------------");



                        break;
                    case 2:
                        Console.WriteLine("Sign to see your personal Employee Info");
                        Console.WriteLine("Enter a name: ");
                        employee01.FirstName = Console.ReadLine();

                        Console.WriteLine("Enter a last name: ");
                        employee01.LastName = Console.ReadLine();

                        Console.WriteLine("Enter your user name");
                        employee01.UserName = Console.ReadLine();

                        Console.WriteLine("Enter your password");
                        employee01.Password = Console.ReadLine();

                        Console.WriteLine("Enter your monthly hours: ");

                        employee01.HoursPermonth = int.Parse(Console.ReadLine());
                        employee01.SetSalary();
                        employee01.SetBonus();

                        employee01.GetInfoEmployee();

                        Console.WriteLine("-------------------------------");
                        break;
                    case 3:
                        
                        break;
                        


                }

            }


        }
    }
    
}
