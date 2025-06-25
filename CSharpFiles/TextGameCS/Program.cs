namespace TextGameCS;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("You are standing in a clearing. To the north is a " +
        "trail leading into a dense forest; to the south is a blazing desert.");
        string response = Input("Go to the forest or the desert?", "F", "D");

        if (response == "f")
        {
            Console.WriteLine("You head into the overgrown forest.");

            Console.WriteLine("Up ahead is a grotto. On the side of the trail there is a tree house.");

            response = Input("Should you explore the grotto or climb the tree house?", "G", "T");

            if (response == "g")
            {
                Console.WriteLine("You enter the grotto and find a small pond.");
                Console.WriteLine("You find a family of koi fish swimming in the pond");
            }
            else
            {
                Console.WriteLine("After climbing the ladder you enter the tree house.");
                Console.WriteLine("You find a group of young boys dressed as pirates.");
                Console.WriteLine("The kids suddenly charge you with their wooden swords!");
            }


        }
        else
        {
            Console.WriteLine("You tread into the hot desert.");

            Console.WriteLine("You come across a small pyramid like structure, there is a sign" +
            "warning you not to enter it");
            response = Input("Should you enter the pyramid or walk away from it", "P", "W");

            if (response == "p")
            {
                Console.WriteLine("You bravely enter the pyramid.");
                Console.WriteLine("You see a casket and you open it " +
                "and fine a mummy inside");
                Console.WriteLine("The Mummy suddenly grabs you by the neck!");
            }
            else
            {
                Console.WriteLine("You walk past the pyramid.");
                Console.WriteLine("It is so hot and you didn't bring a water bottle.");
                Console.WriteLine("You eventually collapse from heat stroke!");
            }
        }

    }

    static String Input(string message, string o1, string o2)
    {
        bool valid;
        string response;
        do
        {
            Console.Write(message + " (" + o1 + "/" + o2 + "): ");
            response = Console.ReadLine().ToLower();

            if (response == o1.ToLower())
            {
                valid = true;
            }
            else if (response == o2.ToLower())
            {
                valid = true;
            }
            else
            {
                Console.WriteLine("That is not a valid response");
                valid = false;
            }
        } while (!valid);

        return response;
    }

}

