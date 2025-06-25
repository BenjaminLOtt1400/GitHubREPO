namespace TextGameCS;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("You are standing in a clearing. To the north is a " +
        "trail leading up a mountain; to the south is a vast lake.");
        string response = Input("Go to the mountain or the lake?", "M", "L");

        if (response == "m")
        {
            Console.WriteLine("You head for the mountains.");

            Console.WriteLine("Up ahead is a cave. Around the cave is a tall hill.");

            response = Input("Should you explore the cave or summit the hill?", "C", "H");

            if (response == 'c')
            {
                Console.WriteLine("You enter the dark, dank cave...");
                Console.WriteLine("You encounter a bear!");
            }
            else
            {
                Console.WriteLine("After much exertion, you reach the top...");
                Console.WriteLine("You encounter a snake!");
            }


        }
        else
        {
            Console.WriteLine("You go to the lake.");

            Console.WriteLine("There is a dock with a boat tied up. The boat is not yours");
            response = Input("Should you take the boat or swim across?", "B", "S");

            if (response == "b")
            {
                Console.WriteLine("You steal the boat!");
                Console.WriteLine("Half way across the lake, you are capsized by " +
                "the Loch Ness Monster!");
            }
            else
            {
                Console.WriteLine("You swim.");
                Console.WriteLine("... and are attacked by a ferocious trout!");
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

