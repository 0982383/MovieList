using System;

namespace ConsoleApp7
{

    class Program
    {
        static void Main(string[] args)

        {
            bool showMovie = true;
            while (showMovie)
            {
                showMovie = MovieList();
            }
        }
        // Showing all the movies avalaible
        private static bool MovieList()
        {
            Console.Clear();
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Choose Movie:");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("1) Jumanji");
            Console.WriteLine("2) Harry Potter");
            Console.WriteLine("3) Ride Along 2");
            Console.WriteLine("4) Spencer Confidential");
            Console.WriteLine("5) Fast & Furious");
            Console.WriteLine("6) 6 Underground");
            Console.WriteLine("7) DeadPool 2");
            Console.WriteLine("8) Death at a Funeral");
            Console.WriteLine("9) Rush Hour 3");
            Console.WriteLine("10) The Dark Knight");
            Console.WriteLine("11) Exit");
            Console.WriteLine();
            Console.WriteLine("-------------------------------");
            Console.Write("\r\nSelect Movie: ");




            // if-statements for calling the different methodes
            switch (Console.ReadLine())
            {
                case "1":

                    Jumanji();
                    return true;
                case "2":
                    HarryPotter();
                    return true;
                case "3":
                    RideAlong2();
                    return true;
                case "4":
                    SpencerConfidential();
                    return true;
                case "5":
                    FastAndFurious();
                    return true;
                case "6":
                    SixUnderground();
                    return true;
                case "7":
                    DeadPool2();
                    return true;
                case "8":
                    Funeral();
                    return true;
                case "9":
                    RushHou3();
                    return true;
                case "10":
                    TheDarkKnight();
                    return true;
                case "11":
                    return false;
                default:
                    return true;
            }
        }
        // command line for showing the different "screens"
        private static string ShowMovie()
        {
            return Console.ReadLine();
        }

        // all the methodes for each movie 
        private static void Jumanji()
        {
            Console.Clear();
            Console.WriteLine("Jumanji");

            Console.WriteLine("120minutes");
            Console.WriteLine("Press Enter to return to MovieList");
            char[] charArray = ShowMovie().ToCharArray();

        }

        private static void HarryPotter()
        {
            Console.Clear();
            Console.WriteLine("Harry Potter");
            Console.WriteLine("120Minutes");
            Console.WriteLine("Press Enter to return to MovieList");
            char[] charArray = ShowMovie().ToCharArray();
        }

        private static void RideAlong2()
        {
            Console.Clear();
            Console.WriteLine("Ride Along 2");

            Console.WriteLine("120minutes");
            Console.WriteLine("Press Enter to return to MovieList");
            char[] charArray = ShowMovie().ToCharArray();

        }

        private static void SpencerConfidential()
        {
            Console.Clear();
            Console.WriteLine("Spencer Confidential");

            Console.WriteLine("120minutes");
            Console.WriteLine("Press Enter to return to MovieList");
            char[] charArray = ShowMovie().ToCharArray();

        }

        private static void FastAndFurious()
        {
            Console.Clear();
            Console.WriteLine("Fast & Furious");

            Console.WriteLine("120minutes");
            Console.WriteLine("Press Enter to return to MovieList");
            char[] charArray = ShowMovie().ToCharArray();

        }

        private static void SixUnderground()
        {
            Console.Clear();
            Console.WriteLine("6 underground");

            Console.WriteLine("120minutes");
            Console.WriteLine("Press Enter to return to MovieList");
            char[] charArray = ShowMovie().ToCharArray();

        }

        private static void DeadPool2()
        {
            Console.Clear();
            Console.WriteLine("DeadPool 2");

            Console.WriteLine("120minutes");
            Console.WriteLine("Press Enter to return to MovieList");
            char[] charArray = ShowMovie().ToCharArray();

        }

        private static void Funeral()
        {
            Console.Clear();
            Console.WriteLine("Dead at a Funeral");

            Console.WriteLine("120minutes");
            Console.WriteLine("Press Enter to return to MovieList");
            char[] charArray = ShowMovie().ToCharArray();

        }

        private static void RushHou3()
        {
            Console.Clear();
            Console.WriteLine("Rush Hour 3");

            Console.WriteLine("120minutes");
            Console.WriteLine("Press Enter to return to MovieList");
            char[] charArray = ShowMovie().ToCharArray();

        }

        private static void TheDarkKnight()
        {
            Console.Clear();
            Console.WriteLine("The Dark Knight");

            Console.WriteLine("120minutes");
            Console.WriteLine("Press Enter to return to MovieList");
            char[] charArray = ShowMovie().ToCharArray();

        }
    }
}