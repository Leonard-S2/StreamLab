using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace StreamLab
{
    class Program : Dates
    {
        public static int select = 0;
        public static int listMax = 0;
        public static string selectList;
        public static string viewers = "";
        public static string likes = "";
        public static string dislikes = "";
        public static string selectListYes;
        public static List<int> list = new List<int>();
        public static List<string> titlesList = new List<string>();
        public static List<string> descriptionsList = new List<string>();
        public static List<int> viewList = new List<int>();
        public static List<int> likesList = new List<int>();
        public static List<int> dislikesList = new List<int>();
        public static string Repeat { get; set; }
        public Program()
        {
            
        }
        public Program(string titles, string descriptions, int d, int e, int f)
        {
            ID = GeneratorIDRandom();
            Title = titles;
            Description = descriptions;
            a = d;
            b = e;
            c = f;
        }

        //Method edit Varibles List
        public static void SelectListYes(int d, int e, int f)
        {

            Console.WriteLine("Select the list you want to edit by typing: id1 through id5");
            selectListYes = Console.ReadLine();

            if (selectListYes == "id1")
            {
                Console.Write("Please enter new title of the stream: ");
                titlesList[0] = Console.ReadLine();
                Console.Write("Please enter new description of the stream: ");
                descriptionsList[0] = Console.ReadLine();

                Console.WriteLine("Your post is: ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Title: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("{0}                        ID: {1}", titlesList[0], list[0]);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Description: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(descriptionsList[0]);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Views: ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine(viewList[0]);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Likes: ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine(likesList[0]);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Dislikes: ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(dislikesList[0]);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" ");
                Console.WriteLine("Press key to continue");
                Console.ReadKey();
                Console.Clear();
                InserDatesForUser(d, e, f);
            }
            else if (selectListYes == "id2")
            {
                Console.Write("Please enter new title of the stream: ");
                titlesList[1] = Console.ReadLine();
                Console.Write("Please enter new description of the stream: ");
                descriptionsList[1] = Console.ReadLine();

                Console.WriteLine("Your post is: ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Title: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("{0}                        ID: {1}", titlesList[1], list[1]);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Description: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(descriptionsList[1]);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Views: ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine(viewList[1]);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Likes: ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine(likesList[1]);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Dislikes: ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(dislikesList[1]);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" ");
                Console.WriteLine("Press key to continue");
                Console.ReadKey();
                Console.Clear();
                InserDatesForUser(d, e, f);                
            }
            else if (selectListYes == "id3")
            {
                Console.Write("Please enter new title of the stream: ");
                titlesList[2] = Console.ReadLine();
                Console.Write("Please enter new description of the stream: ");
                descriptionsList[2] = Console.ReadLine();

                Console.WriteLine("Your post is: ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Title: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("{0}                        ID: {1}", titlesList[2], list[2]);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Description: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(descriptionsList[2]);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Views: ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine(viewList[2]);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Likes: ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine(likesList[2]);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Dislikes: ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(dislikesList[2]);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" ");
                Console.WriteLine("Press key to continue");
                Console.ReadKey();
                Console.Clear();
                InserDatesForUser(d, e, f);
            }
            else if (selectListYes == "id4")
            {
                Console.Write("Please enter new title of the stream: ");
                titlesList[3] = Console.ReadLine();
                Console.Write("Please enter new description of the stream: ");
                descriptionsList[3] = Console.ReadLine();

                Console.WriteLine("Your post is: ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Title: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("{0}                        ID: {1}", titlesList[3], list[3]);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Description: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(descriptionsList[3]);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Views: ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine(viewList[3]);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Likes: ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine(likesList[3]);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Dislikes: ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(dislikesList[3]);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" ");
                Console.WriteLine("Press key to continue");
                Console.ReadKey();
                Console.Clear();
                InserDatesForUser(d, e, f);
            }
            else if (selectListYes == "id5")
            {
                Console.Write("Please enter new title of the stream: ");
                titlesList[4] = Console.ReadLine();
                Console.Write("Please enter new description of the stream: ");
                descriptionsList[4] = Console.ReadLine();

                Console.WriteLine("Your post is: ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Title: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("{0}                        ID: {1}", titlesList[4], list[4]);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Description: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(descriptionsList[4]);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Views: ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine(viewList[4]);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Likes: ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine(likesList[4]);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Dislikes: ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(dislikesList[4]);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" ");
                Console.WriteLine("Press key to continue");
                Console.ReadKey();
                Console.Clear();
                InserDatesForUser(d, e, f);
            }
            else
            {
                Console.WriteLine("Please enter a valid id");
                SelectListYes(d, e, f);
            }

        }
        //Method User input
        public static void InserDatesForUser(int d, int e, int f)
        {
            Console.WriteLine("If you want to edit a list type Y/N");
            selectList = Console.ReadLine();
            if (selectList == "Y" || selectList == "y")
            {
                SelectListYes(d, e, f);
            }
            else
            {
                Console.Write("Please enter the title of the stream: ");
                Title = Console.ReadLine();
                Console.Write("Please enter the description of the stream: ");
                Description = Console.ReadLine();
                Console.Write("Please enter the number of viewers: ");
                viewers = Console.ReadLine();
                Console.Write("Please enter the number of likes: ");
                likes = Console.ReadLine();
                Console.Write("Please enter the number of dislikes: ");
                dislikes = Console.ReadLine();

                //Conversion string to int
                View = int.TryParse(viewers, out d);
                Like = int.TryParse(likes, out e);
                Dislike = int.TryParse(dislikes, out f);

                //Get the length of an integer
                int z = viewers.Length;
                int x = likes.Length;
                int w = dislikes.Length;


                //Verification false or true view, like and dislike
                if (z > 8 && x > 8 && w > 8)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("The number of viewers, likes and dislikes is too big");
                    Console.WriteLine("Please enter a valid number, press key for restar");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadKey();
                    Console.Clear();
                    InserDatesForUser(d, e, f);
                }
                else if (z > 8)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("The number of viewers is too big");
                    Console.WriteLine("Please enter a valid number, press key for restar");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadKey();
                    Console.Clear();
                    InserDatesForUser(d, e, f);
                }
                else if (x > 8)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("The number of likes is too big");
                    Console.WriteLine("Please enter a valid number, press key for restar");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadKey();
                    Console.Clear();
                    InserDatesForUser(d, e, f);
                }
                else if (w > 8)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("The number of dislikes is too big");
                    Console.WriteLine("Please enter a valid number, press key for restar");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadKey();
                    Console.Clear();
                    InserDatesForUser(d, e, f);
                }
                else if (View == false || Like == false || Dislike == false)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter a valid number, press key for restar");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadKey();
                    Console.Clear();
                    InserDatesForUser(d, e, f);
                }
                else if (View && Like && Dislike)
                {
                    //creation Dates
                    Program dates = new Program(Title, Description, d, e, f);
                    Console.WriteLine(dates.ToString());
                    Console.WriteLine("Your strem post has been saved, do you want to generate another one?");
                    ListPostStream();
                    //Save recent list
                    ListSaveList();
                    Console.WriteLine("Press Y for yes or N for no");
                    Repeat = Console.ReadLine();
                    if (Repeat == "Y" || Repeat == "y")
                    {
                        Console.Clear();
                        ListIds();
                        SelectListIds();
                        InserDatesForUser(d, e, f);
                    }
                    else if (Repeat == "N" || Repeat == "n")
                    {
                        Console.WriteLine("Thank you for using StreamLab");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid key, press key for restar");
                        Console.ReadKey();
                        Console.Clear();
                        InserDatesForUser(d, e, f);
                    }
                }
            }
        }

        //Save all list .txt
        public static void ListSaveList()
        {
            //List posts
            File.AppendAllText(@"C:\Users\Leo\Desktop\Text\Titles.txt", "Title Post: ");
            foreach (var item2 in Title)
            {
                File.AppendAllText(@"C:\Users\Leo\Desktop\Text\Titles.txt", item2.ToString());
            }
            File.AppendAllText(@"C:\Users\Leo\Desktop\Text\Titles.txt", "\n");
            File.AppendAllText(@"C:\Users\Leo\Desktop\Text\Titles.txt", "Description Post: ");
            foreach (var item3 in Description)
            {
                File.AppendAllText(@"C:\Users\Leo\Desktop\Text\Titles.txt", item3.ToString());
            }
            File.AppendAllText(@"C:\Users\Leo\Desktop\Text\Titles.txt", "\n");
            File.AppendAllText(@"C:\Users\Leo\Desktop\Text\Titles.txt", "Viewers Post: ");
            foreach (var item4 in viewers)
            {
                File.AppendAllText(@"C:\Users\Leo\Desktop\Text\Titles.txt", item4.ToString());
            }
            File.AppendAllText(@"C:\Users\Leo\Desktop\Text\Titles.txt", "\n");
            File.AppendAllText(@"C:\Users\Leo\Desktop\Text\Titles.txt", "Likes Post: ");
            foreach (var item5 in likes)
            {
                File.AppendAllText(@"C:\Users\Leo\Desktop\Text\Titles.txt", item5.ToString());
            }
            File.AppendAllText(@"C:\Users\Leo\Desktop\Text\Titles.txt", "\n");
            File.AppendAllText(@"C:\Users\Leo\Desktop\Text\Titles.txt", "Dislikes Post: ");
            foreach (var item6 in dislikes)
            {
                File.AppendAllText(@"C:\Users\Leo\Desktop\Text\Titles.txt", item6.ToString());
            }
            File.AppendAllText(@"C:\Users\Leo\Desktop\Text\Titles.txt", "\n");
            File.AppendAllText(@"C:\Users\Leo\Desktop\Text\Titles.txt", "\n");


        }
        //Method view list post Id stream
        public static void ListIds()
        {
            //List full
            listMax = list.Count;

            Console.WriteLine("List of your posts");
            foreach (var item in list)
            {
                if (listMax > 5)
                {
                    Console.WriteLine("You can only have a limit of 5 posts, press key for restar");
                    Console.ReadKey();
                    Console.Clear();
                    SelectListIds();
                }
                else
                {
                    Console.WriteLine(item);
                }
            }
            Console.WriteLine("Press key to continue");
            Console.ReadKey();
            Console.Clear();
        }

        //Method select listIds
        public static void SelectListIds()
        {
            Console.WriteLine("Please enter the number of the post you want to see");
            select = int.Parse(Console.ReadLine());
            if (select == 1)
            {
                Console.WriteLine("Your post is: ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Title: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("{0}                        ID: {1}", titlesList[0], list[0]);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Description: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(descriptionsList[0]);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Views: ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine(viewList[0]);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Likes: ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine(likesList[0]);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Dislikes: ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(dislikesList[0]);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" ");
                Console.WriteLine("Press key to continue");
                Console.ReadKey();
                Console.Clear();
               
            }
            else if (select == 2)
            {
                Console.WriteLine("Your post is: ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Title: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("{0}                        ID: {1}", titlesList[1], list[1]);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Description: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(descriptionsList[1]);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Views: ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine(viewList[1]);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Likes: ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine(likesList[1]);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Dislikes: ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(dislikesList[1]);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" ");
                Console.WriteLine("Press key to continue");
                Console.ReadKey();
                Console.Clear();

            }
            else if (select == 3)
            {
                Console.WriteLine("Your post is: ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Title: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("{0}                        ID: {1}", titlesList[2], list[2]);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Description: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(descriptionsList[2]);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Views: ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine(viewList[2]);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Likes: ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine(likesList[2]);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Dislikes: ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(dislikesList[2]);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" ");
                Console.WriteLine("Press key to continue");
                Console.ReadKey();
                Console.Clear();

            }
            else if (select == 4)
            {
                Console.WriteLine("Your post is: ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Title: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("{0}                        ID: {1}", titlesList[3], list[3]);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Description: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(descriptionsList[3]);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Views: ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine(viewList[3]);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Likes: ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine(likesList[3]);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Dislikes: ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(dislikesList[3]);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" ");
                Console.WriteLine("Press key to continue");
                Console.ReadKey();
                Console.Clear();

            }
            else if (select == 5)
            {
                Console.WriteLine("Your post is: ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Title: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("{0}                        ID: {1}", titlesList[4], list[4]);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Description: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(descriptionsList[4]);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Views: ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine(viewList[4]);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Likes: ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine(likesList[4]);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Dislikes: ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(dislikesList[4]);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" ");
                Console.WriteLine("Press key to continue");
                Console.ReadKey();
                Console.Clear();

            }
            else
            {
                Console.WriteLine("You can only have a limit of 5 posts, press key for restar");
                Console.ReadKey();
                Console.Clear();
                SelectListIds();
            }
        }

        //Method guard list post stream
        public static void ListPostStream()
        {
            //Guard all post stream
            list.Add(GeneratorIDRandom());
            titlesList.Add(Title);
            descriptionsList.Add(Description);
            viewList.Add(a);
            likesList.Add(b);
            dislikesList.Add(c);

        }
        static void Main(string[] args)
        {
            InserDatesForUser(a,b,c);
            Console.Read();
        }
    }
}
