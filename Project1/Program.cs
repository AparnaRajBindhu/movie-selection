using System;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            int age, ChosenFilm, FilmLength;
            char looping = ' ';
            string[] filmNames = new string[5];

            Console.Clear();

            do
            {
                try
                {
                    Console.WriteLine("\n\n\t\t\t\t\tWelcome to our Multiplex");
                    Console.Write("\nEnter the number of films :");
                    FilmLength = int.Parse(Console.ReadLine());
                    Console.Write("\n");
                    for (int i = 0; i < FilmLength; i = i + 1)/*Reading film names from user*/
                    {
                        int displayNumber = i + 1;
                        Console.Write("Enter the name of film number " + displayNumber + " along with age limit in braces : ");
                        filmNames[i] = Console.ReadLine();

                    }



                    Console.WriteLine("\n\nWe are presently showing:");
                    //  Console.WriteLine("1. Rush (15)\n2. How I Live Now(15)\n3. Thor: The Dark World(12A)\n4. Filth(18)\n5. Planes(U)");

                    for (int i = 0; i < FilmLength; i = i + 1)
                    {
                        int displayNumber = i + 1;
                        Console.WriteLine(displayNumber + " . " + filmNames[i]);
                    }



                    /* Reading the film number*/
                    do
                    {
                        Console.Write("Enter the number of film you wish to see :");
                        ChosenFilm = int.Parse(Console.ReadLine());
                        if (ChosenFilm < 1 || ChosenFilm > FilmLength) /* checking whether film number between 1 and 5*/
                        {
                            Console.WriteLine("Film number entered is invalid....\n Enter number between 1 and " + FilmLength);

                        }
                    } while (ChosenFilm < 1 || ChosenFilm > FilmLength);

                    do
                    {
                        Console.Write("Enter your age:");
                        age = int.Parse(Console.ReadLine());
                        if (age < 5 || age > 120) /* checking whether age between 5 and 120*/
                        {
                            Console.WriteLine("Age should be between 5 and 120");

                        }

                    } while (age < 5 || age > 120);

                    ChosenFilm = ChosenFilm - 1;
                    Console.WriteLine("You selected the film " + filmNames[ChosenFilm]);
                    if (filmNames[ChosenFilm].EndsWith("(15)"))
                    {

                        Console.WriteLine("You selected the film " + filmNames[ChosenFilm]);
                        if (age < 15)
                        {
                            Console.WriteLine("Access Denied - You are too young");
                        }
                        else
                        {
                            Console.WriteLine("Enjoy the film");
                        }
                    }
                    else if (filmNames[ChosenFilm].EndsWith("(12A)"))
                    {
                        if (age < 12)
                        {
                            Console.WriteLine("Access Denied - You are too young");
                        }
                        else
                        {
                            Console.WriteLine("Enjoy the film");
                        }
                    }
                    else if (filmNames[ChosenFilm].EndsWith("(18)"))
                    {
                        if (age < 18)
                        {
                            Console.WriteLine("Access Denied - You are too young");
                        }
                        else
                        {
                            Console.WriteLine("Enjoy the film");
                        }
                    }


                    else if (filmNames[ChosenFilm].EndsWith("(U)"))
                    {
                        if (age < 4)
                        {
                            Console.WriteLine("Access Denied - You are too young");
                        }
                        else
                        {
                            Console.WriteLine("Enjoy the film");
                        }
                    }

                    else
                    {
                        Console.WriteLine("Film entered is not in format");
                    }


                    // code to process one film customer
                    Console.Write("Enter 'y' to check for another customer : ");
                    looping = char.Parse(Console.ReadLine());


                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Restart application again!!!");


                }




            } while (looping == 'Y' || looping == 'y');



        }
    }
}
