namespace TextPrototype;

class Program
{
    static void Main(string[] args)
    {
        int score = 0;  // Score initializer for quicktime events.
        int scoreTotal = 0; // Score total for combined scores
        int moonBoots = 0; // Value to be incremented upon collection of the moon boots
        int highExplosives = 0; // Value to be incremented upong collection of the high explosives
        int swordTaken = 0; // Value to be incremented upon collection of the sword
        int gauntletTaken = 0; // Value to be incremented upon collection of the gauntlet
        int payRespect = 0; // Value to be incremented upon paying respect at grave
        string response = "PlaceHolder"; // Placeholder value for decision inputs

        Console.WriteLine("Welcome to the text prototype of The Trecherous Cave!");
        Console.WriteLine("Press ENTER to begin your adventure!");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine("You enter into the cave crawling through the small hole at the bottom of the abandoned mineshaft.");
        Console.WriteLine("As you reach an opening and stand up suddenly the entrance collapses behind you!");
        Console.WriteLine("You realize that you have to find a way out but it won't be from going back the way you came");
        Console.WriteLine("You move forward and enter into a beautiful room full of purple crystals!");
        Console.WriteLine("Ahead of you there is a path forward past the cave");
        Console.WriteLine("Looking ahead you see a path forward deeper into the cave");
        response = Input("Do you Continue forward or Look around the crystals more?", "C", "L");

        if (response == "l")
        {
            Console.WriteLine("After looking around the cave you notice a feint glow through a crack");
            response = Input("Do you Enter the crack or Ignore it and move forward?", "E", "I");

            if (response == "e")  // Enter into the crack
            {
                Console.WriteLine("You follow the light down the hole and find a small camp with a dying fire.");
                Console.WriteLine("You come across an old man that looks like he has been here a long time.");
                Console.WriteLine("Cave Man: Who are you and why are you here?");
                Console.WriteLine("The old man makes strange incoherent sounds.");
                Console.WriteLine("Cave Man: What are you trying to say?");
                Console.WriteLine("Old Man: I've been here so long I have seen everything.");
                Console.WriteLine("Cave Man: What can you tell me about this place?");
                Console.WriteLine("Old Man: There are things in here you cannot imagine" +
                "Don't go forward, the king will not be pleased.");
                Console.WriteLine("Cave Man: Who is the king?");
                Console.WriteLine("The old man crouches down and begins to make strange sounds");
                Console.WriteLine("Cave Man: This dude has been here so long he is absolutely nuts.");
                Console.WriteLine("You head back the way you came towards the crystal cave.");
            }
            else
            {
                Console.WriteLine("You decide not to follow the light.");
            }
        }
        else   // continue forward
        {
            Console.WriteLine("You think it would be best just to move forward.");
        }
        Console.WriteLine("You press forward deeper into the cave.");
        Console.WriteLine("After a while of traversing through the cave you come across a camp " +
        "that looks desolate.");
        Console.WriteLine("You get a feeling something aweful happened here.");
        Console.WriteLine("You look around the camp and notice 2 sets of ladders leading into different holes");
        Console.WriteLine("The hole on the left you see a redish glow of what might be a fire.");
        Console.WriteLine("The hole on the right has a green glow.");
        response = Input("Do you go into the left hole or the right", "l", "r");
        if (response == "r")
        {
            Console.WriteLine("You climb the ladder on the right towards the green lights.");
            Console.WriteLine("As you reach the top of the ladder you see the glow was coming from a colony of glowing mushrooms.");
            Console.WriteLine("You wonder if you should try and pick the mushrooms but are unsure.");
            response = Input("Do you Pick the mushrooms or Leave them alone", "P", "L");
            if (response == "p")
            {
                Console.WriteLine("You start picking the mushrooms and putting them into your pocket.");
                Console.WriteLine("Suddenly the mushrooms in your hand sprout legs and begin to crawl around on you.");
                Console.WriteLine("Then the rest of the mushrooms in the cave sprout legs and begin to swarm you!");
                Console.WriteLine("You must fight back against these mushrooms or you will surely die!!!");
                Console.WriteLine("You must score a 50 or higher to survive");
                score = DartThrow(25);
                if (score <= 25)
                {
                    Console.WriteLine("The mushrooms stampede over you and you perish");
                    Environment.Exit();
                }
                else
                {
                    Console.WriteLine("You narrowly defeat the mushrooms and live to see another day!");
                }
            }
            else
            {
                Console.WriteLine("You think that it is best to leave the mushrooms alone");
            }
            Console.WriteLine("You begin to look around the glowing room.");
            Console.WriteLine("You find a futuristic looking pair of boots!");
            Console.WriteLine("You collected the Moon Boots!");
            moonBoots += 1;
            Console.WriteLine("You head back down the ladder toward the desolate camp.");
            Consol.WritLine("After returning to the camp you head up the other ladder.");
        }
        else
        {
            Console.WriteLine("You decide to head up the left ladder toward the red light.");
        }
        Console.WriteLine("You press forward through the cave and come across a horrific scene.");
        Console.WriteLine("In front of you there are skeletons scattered about.");
        Console.WriteLine("There are skeletons in cages hanging from chains attatched to the roof of the cave.");
        Console.WriteLine("Past all the skeletons you see the path forward.");
        if (moonBoots == 1)
        {
            Console.WriteLine("You notice a cliff with a glimmering glow coming from it.");
            response = Input("Do you use the Moon Boots to jump to the cliff edge?", "Y", "N");
            if (response == 'y')
            {
                Console.WriteLine("You put on the Moon Boots and feel as if gravity was lowered.");
                Console.WriteLine("You stumble using the boots until you get the hang of them.");
                Console.WriteLine("You jump up to the cliff and see a room glisening with gold!");
                Console.WriteLine("You enter into the cave and see a few skeletons on the floor with mining equipment.");
                response = Input("Do you Search the skeletons or Continue past them?", "S", "C");
                if (response == 's')
                {
                    Console.WriteLine("You search around the skeletons and find normal mining equipment.");
                    Console.WriteLine("There are helmets, lanterns, and pickaxes.");
                    Console.WriteLine("On the last skeleton you check you find a small pouch.");
                    Console.WriteLine("Inside the pouch there a bundle of dynamite!!");
                    Console.WriteLine("You collected High Explosives!!!");
                    highExplosives += 1;
                }
                Console.WriteLine("You proceed to look around the golden grove when you hear a strange noise.");
                Console.WriteLine("After looking behind a golden rock you see that insane old man from earlier!");
                Console.WriteLine("Cave Man: How are you here, this cave is a single path and you never passed me.");
                Console.WriteLine("Old Man: What are you talking about I have been here the whole time.");
                Console.WriteLine("Cave Man: Whatever, tell me more about this cave before you lose your marbles again.");
                Console.WriteLine("Old Man: The King's protector is ahead, he is the one that created the Bone Yard.");
                Console.WriteLine("Cave Man: How can I get past him, I need to leave this place!");
                Console.WriteLine("Old Man: His skin is as tough as steel.");
                Console.WriteLine("Old Man: The bones speak to me and say they are watching your progress.");
                Console.WriteLine("Cave Man: What does that even mean, how can I get past the guardian?");
                Console.WriteLine("The old man becomes unresponsive again.");
                Console.WriteLine("Cave Man: What on earth has this dude seen to lose it this bad.");
                Console.WriteLine("You head back towards the cliff.");
                Console.WriteLine("You brace yourself as you jump back down the cliff into the Bone Yard.");
            }
            else
            {
                Console.WriteLine("You end up deciding not to jump up there.");
            }
        }
        Console.WriteLine("You continue forward past all of the skeletons.");
        Console.WriteLine("As you continue forward you notice vines growing on the walls.");
        Console.WriteLine("There seems to be various kinds of vegetation growing around this area.");
        Console.WriteLine("You find the end of the tunnel has overgrown vines creating a sort of door.");
        Console.WriteLine("Upon pushing the vines to the side you enter into a beautiful grotto full of trees and flowers.");
        Console.WriteLine("Before you can fully take in the beauty you see a massive beast in front of you!");
        Console.WriteLine("The beast has large muscles and is holding a large mace of some kind.");
        Console.WriteLine("Guardian: Who dares to enter my sanctuary!");
        Console.WriteLine("Cave Man: Look man I just need to get out of here, can you let me by?");
        Console.WriteLine("Guardian: No man is allowed to witness the King, I must strike you down!");
        Console.WriteLine("Cave Man: Look man if thats how you want to be I dont mind taking you out!");
        Console.WriteLine("The Beast Charges at you and you begin to clash with him.");
        Console.WriteLine("You must score over 150 points with 5 turns to survive.");
        for (int i = 0; i < 5; i++)
        {
            int difficulty = 200;
            score = DartThrow(difficulty);
            scoreTotal += score;
            difficulty -= 30;
        }
        if (scoreTotal <= 150)
        {
            Console.WriteLine("With a swift blow to your stomach you fly backward and slam into the cave wall!");
            Console.WriteLine("You lose conciousness and perish.");
            Environment.Exit();
        }
        else
        {
            Console.WriteLine("You narrowly dodge the beast and with a swift blow to the back you bring the beast to his knees!");
            Console.WriteLine("The beast is made unconcious, you have done it!");
        }
        Console.WriteLine("You begin to look for the exit of the grotto.");
        Console.WriteLine("You see a pathway with trees on both sides leading to an opening.");
        if (highExplosives == 1)
        {
            Console.WriteLine("While walking toward the exit you notice a pile of rocks that look to be covering something.");
            response = Input("Do you use your high explosives to see what is under the pile?", "Y", "N");
            if (response == "y")
            {
                Console.WriteLine("You wedge a stick of dynamite between the rocks and light it.");
                Console.WriteLine("You quickly run behind a tree to shield yourself from the blast.");
                Console.WriteLine("With an ear ringing bang there is a cloud of dust filling the room.");
                Console.WriteLine("As the dust settles you go back to what once was the pile of rocks revleaing a passage.");
                response = Input("Do you enter the passage?", "Y", "N");
                if (response == "y")
                {
                    Console.WriteLine("You enter into the passage and find yourself in a small room.");
                    Console.WriteLine("In the center of the room there is a small grave with a sword sticking out from it.");
                    Console.WriteLine("You see at the base of the sword there is a golden gauntlet");
                    response = TripleInput("Do you take the sword, the gauntlet, or neither", "S", "G", "N");
                    if (response == "s")
                    {
                        Console.WriteLine("You take the hero's sword!");
                        swordTaken += 1;
                    }
                    else if (response == "g")
                    {
                        Console.WriteLine("You take the hero's gauntlet");
                        gauntletTaken += 1;
                    }
                    else
                    {
                        Console.WriteLine("You decide only to pay your respects and take neither.");
                        payRespect += 1;
                    }
                    Console.WriteLine("You hear a loud rumbling sound as rocks begin to collapse from the ceiling!");
                    Console.WriteLine("You rush to escape the cave in and narrowly exit the hole as it collapses behind you!");
                }
                else
                {
                    Console.WriteLine("You decide not to enter the passage.");
                }
            }
            else
            {
                Console.WriteLine("You think its best not to use explosives in this cave.");
            }
        }
        Console.WriteLine("You proceed toward the exit of the grotto admiring how plants can look so healthy in a cave.");
        Console.WriteLine("As you press forward through the passage you begin to hear squeaking noises coming from the next chamber.");
        Console.WriteLine("You enter the next chamber as you see a throne room.");
        Console.WriteLine("This surely is where the king resides.");
        Console.WriteLine("Sitting atop a golden throne you see a massive rat with glowing red eyes and a crown on his head.");
        Console.WriteLine("The rat jumps off from his throne looking at you with disgust.");
        Console.WriteLine("Cave Man: So you are the king that lunatic was blabbering about, let me leave.");
        Console.WriteLine("Rat King: No one is allowed to leave after learning about my existance.");
        Console.WriteLine("Cave Man: Well tough luck because im going to get past you and get out of here.");
        Console.WriteLine("My sanctuary must remain unknown, no one else shall expose my domain");
        Console.WriteLine("Well lets just see how much you can enjoy your santuary once you are gone.");
        Console.WriteLine("The Rat King lets out a piercing screech that echoes throughout the entire cave system.");
        Console.WriteLine("The Rat King charges at you");
        Console.WriteLine("Cave Man: GIVE IT YOUR BEST SHOT YOU GIANT VERMIN!!!");
        Console.WriteLine("You must score over 300 in 7 attempts");
        scoreTotal = 0;
        difficulty = 250;
        int multiplier = 1;
        int ExtraAttempts = 0;
        if (gauntletTaken == 1)
        {
            Console.WriteLine("Your gauntlet makes you feel protected, difficulty lowered!");
            difficulty += 100;
        }
        if (swordTaken == 1)
        {
            Console.WriteLine("Your sword gives you an edge, score doubled!");
            multiplier += 1;
        }
        if (payRespect == 1)
        {
            Console.WriteLine("You feel that the respect you payed at the grave gives you the will to fight.");
            Console.WriteLine("You are given 3 extra attempts!");
            ExtraAttempts += 3;
        }
        for (int i = 0; i < 7 + ExtraAttempts; i++)
        {
            score = DartThrow(difficulty);
            scoreTotal += score * multiplier;
            difficulty -= 30;
        }
        if (scoreTotal <= 300)
        {
            Console.WriteLine("With a swift lunge the Rat King mauls you and begins tearing you apart.");
            Console.WriteLine("You have no way of struggling futher and perish.");
            Environment.Exit();
        }
        else
        {
            Console.WriteLine("The Rat King lunges at you, But you swiftly jump over him and land on his back.");
            Console.WriteLine("You pin the Rat King down and begin giving him blow after blow until he stops moving.");
            Console.WriteLine("Cave Man: I told you that I would leave this place you dumb rodent.");
        }
        Console.WriteLine("You have done it, now all that is left to do is get out of this god forsaken cave.");
        Console.WriteLine("As you walk past the king's throne you see the hole in the wall that has a glimmer of light at the end.");
        Console.WriteLine("You push any rock that is in your way aside and once again see the light of the sun.");
        Console.WriteLine("You take a deep breath of fresh air and give a sigh of releif that this is finally over.");
        Console.WriteLine("Thank you so much for playing the text prototype for the Trecherous Cave!");
    }




    static String Input(string message, string o1, string o2)
    //  Function method for allowing choice inputs during branches
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
    static String TripleInput(string message, string o1, string o2, string o3)
    //  Function method for allowing choice inputs during branches
    {
        bool valid;
        string response;
        do
        {
            Console.Write(message + " (" + o1 + "/" + o2 + "/" + o3 + "): ");
            response = Console.ReadLine().ToLower();

            if (response == o1.ToLower())
            {
                valid = true;
            }
            else if (response == o2.ToLower())
            {
                valid = true;
            }
            else if (response == o3.ToLower())
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
    static int DartThrow(int speed) {
        int markerPosition = 0;
        bool movingRight = true;
        Console.CursorVisible = false;
        while (true) {
        Console.Clear();
        Console.WriteLine("| 25 | 50 |X| 50 | 25 |");
        for (int i = 0; i < markerPosition; i++)
            Console.Write(' ');
            Console.WriteLine('|');
        if (Console.KeyAvailable) {
            ConsoleKeyInfo key = Console.ReadKey(true);
        if (key.Key == ConsoleKey.Spacebar)
            break;
        }
        if (movingRight) {
            markerPosition++;
        if (markerPosition >= 23)
            movingRight = false;
        }
        else {
            markerPosition--;
        if (markerPosition <= 0)
            movingRight = true;
        }
        Thread.Sleep(speed);
        }
        Console.CursorVisible = true;
        if (markerPosition == 12)
        return 100;
        else if (markerPosition >= 6 && markerPosition <= 18)
        return 50;
        return 25;
}
}


