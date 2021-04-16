using System;
using System.Collections.Generic;
using System.Text;

namespace HomeMovieRent.Models
{
    public class Movie
    {
        public string Owner { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
       
        public int Price { get; set; }

        public Movie()
        {
                
        }

        public Movie(string title, string description, int year)
        {
            Title = title;
            Description = description;
            Year = year;
            Price = SetPrice();


        }
        public void Rent()
        {
            Console.WriteLine("Pick your movie to rent");
            int choise = int.Parse(Console.ReadLine());
            switch (choise)
            {
                case 1:
                    Console.WriteLine("Fast and Furious");
                    Title = "Fast and Furious";
                    Year = 2004;
                    Price = 2100;
                    break;
                case 2:
                    Console.WriteLine("Fast and Furious 2");
                    Title = "Fast and Furious 2";
                    Year = 2007;
                    Price = 3100;
                    break;
                case 3:
                    Console.WriteLine("Fast and Furious 3");
                    Title = "Fast and Furious 3";
                    Year = 2008;
                    Price = 900;
                    break;
                case 4:
                    Console.WriteLine("Fast and Furious 4");
                    Title = "Fast and Furious 4";
                    Year = 2010;
                    Price = 800;
                    break;
                case 5:
                    Console.WriteLine("Fast and Furious 5");
                    Title = "Fast and Furious 5";
                    Year = 2011;
                    Price = 100;
                    break;
                default:
                    Console.WriteLine("Try again");
                    break;
            }
        }
        public int SetPrice()
        {
            int price = 0;
            Random random = new Random();
            price = Year < 2000 ? random.Next(100, 200) : Year >= 2000 || Year < 2010 ? random.Next(200, 300) : random.Next(300, 500);
            return price;
        }

        public void Info()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Price: {Price}$");
            Console.WriteLine("Enjoy your movie ");
        }

    }
    

}
