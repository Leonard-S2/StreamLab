using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamLab
{
    class Dates
    {
        public static bool View { get; set; }
        public static bool Like { get; set; }
        public static bool Dislike { get; set; }
        public static string Title { get; set; }
        public static string Description { get; set; }
        
        //ID stream data create
        public static int ID { get; set; }
        public static int a { get; set; }
        public static int b { get; set; }
        public static int c { get; set; }

        public Dates()
        {
            ID = GeneratorIDRandom();
            View = false;
            Like = false;
            Dislike = false;
            Title = "";
            Description = "";
            a = 0;
            b = 0;
            c = 0;
        }
        public Dates(string titles, string descriptions, int d, int e, int f)
        {
            ID = GeneratorIDRandom();
            Title = titles;
            Description = descriptions;
            a = d;
            b = e;
            c = f;
        }

        public static int GeneratorIDRandom()
        {
            //Random containing numbers with a length of 10
            Random rnd = new Random();
            string rndString = "";
            for (int i = 0; i < 8; i++)
            {
                rndString += rnd.Next(0, 7);
            }
            return Convert.ToInt32(rndString);
        }
        //Method of displaying stream information
        public override string ToString()
        {
            Console.Clear();
            //Return all information with console colors
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Title:");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("{0}                        ID: {1}",Title, GeneratorIDRandom());
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Description: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(Description);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Views: ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(a);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Likes: ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(b);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Dislikes: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(c);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" ");
            return null;
        }
    }
}
