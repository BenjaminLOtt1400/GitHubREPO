/*
Author: Lance P. Rhodes
Title: Challenges.cs
Description: This program includes several methods that demonstrate common game
design challenges.
These methods can be freely used for educational purposes, such as
teaching, learning,
or experimenting with game design and programming. No guarantees
or warranties are
provided for the use of this code, and the author is not
responsible for any issues or
damages that may arise from its use. This code is provided "as
is," without any
implied fitness for any particular purpose.
License Agreement:
1. This code may be freely copied, distributed, or modified for
educational purposes.
2. Commercial use of this code or its derivatives is not permitted
without the author's
express permission.
3. The author is not liable for any software defects or errors
resulting from its use.
*/
using System.Diagnostics; // Required for QuickDraw, RhythmChamp, TypeRacer
using System.Text; // Required for MazeExplorer
using System.Collections; // May be required for CodeBreaker, TriviaQuiz
using System.Linq; // May be required for TriviaQuiz
using System.Threading; // May be required for ShellGame
class Challenges
{
    static void Main(string[] args)
    {
        int score = 0;
        // Commonly used challenges
        // Physical Coordination Challengesw
        // Speed and reaction time
        // QuickDraw(1000);

        // Accuracy and precision
        score = DartThrow(25);
        Console.WriteLine(score);

        // Understanding physics (the physics of the game world)


        // Timing and Rhythm
        // RhythmChamp();

        // Combos

        // Logical/Mathematical Challenges
        // Formal Logic Puzzles: should be able to be solved without outside knowledge
        // CodeBreaker(4, 10); // Length of code, number of tries
        // Math-related problems

        // Races and Time Pressure
        // race: to complete before someone else
        // time pressure: to complete for a time
        // TypeRacer("All the world is a stage...", 5000);

        // Factual Knowledge Challenges
        // int score = TriviaQuiz();

        // Memory challenges (i.e. in game memory)
        // ShellGame(5, 1000);

        // Pattern recognition challenges


        // Exploration Challenges
        //      Spatial awareness challenges (map)
        //      Locked doors (impeding obstacle that can be removed)
        //      Mazes (Typically all areas the same/similar)
        //      Illogical Spaces
        //      Teleporters (transports player from one area to another)
        //      Finding hidden objects

        // MazeExplorer();

        // Economic Challenges
        //      Accumulate resources: money, points, ect.
        //      Caring for Living Things
        // FarmSim(5);

        // Conceptual Reasoning: combine reasoning power with what you know about the puzzle
        // Lateral Thinking: think "outside the box" to solve the puzzle

        // Conflict: direct opposition of forces
        //      Strategy: planning, resources, reasoning, ect.
        //      Tactics: making a plan and executing it
        //      Logistics: managing resources
        //      Survival and Reduction of Enemy Forces
        //      Defending vulnerable items or units
        //      Stealth: the ability to move undetected
        // BattleSim("Jimbo", 50, 50);




    }
    static String Input(string message, string option1, string option2)
    {
        bool valid;
        string? response;
        do
        {
            Console.Write(message + " (" + option1 + "/" + option2 + "): ");
            response = Console.ReadLine();
            response = string.IsNullOrEmpty(response) ?
            string.Empty : response.ToLower();
            valid = response == option1.ToLower() ||
            response == option2.ToLower();
            if (!valid)
                Console.WriteLine("That is not a valid response.");
        } while (!valid);
        return response;
    }

    static bool BattleSim(string enemy, int enemyHealth, int playerHealth)
    {
        UpdateStats(enemy, enemyHealth, playerHealth);

        do
        {
            AttackBy("Player", ref enemyHealth);
            UpdateStats(enemy, enemyHealth, playerHealth);

            if (enemyHealth > 0)
            {
                AttackBy(enemy, ref playerHealth);
                UpdateStats(enemy, enemyHealth, playerHealth);
            }
        } while (playerHealth > 0 && enemyHealth > 0);
        if (playerHealth > 0)
        {
            Console.WriteLine($"\n{enemy} falls to the ground defeated.");
            return true;
        }

        Console.WriteLine("\nYou stumble to the ground in defeat.");
        return false;
    }

    static void UpdateStats(string enemy, int enemyHealth, int playerHealth)
    {
        Console.Clear();
        Console.WriteLine($"Player: {playerHealth}");
        Console.WriteLine($"{enemy}: {enemyHealth}");
    }

    static void AttackBy(string attackerName, ref int receiverHealth)
    {
        Console.Write($"\n{attackerName} prepares to attack..." +
            "(press ENTER)");
        Console.ReadLine();

        int damage = new Random().Next(10);
        Console.WriteLine($"... and strikes for {damage} damage! " +
            "(press ENTER)");
        Console.ReadLine();

        receiverHealth -= damage;
        receiverHealth = receiverHealth < 0 ? 0 : receiverHealth;
    }

static bool CodeBreaker(int n, int attempts)
    {
        int remain = attempts;
        string code = "";
        string symbols = "ABCDEF";
        List<string> boardData = [];
        Random random = new();
        for (int i = 0; i < n; i++)
            code += symbols[random.Next(symbols.Length)];
        Console.WriteLine($"Crack the {n}-digit code with " +
        $"any combination of {symbols}.");
        while (remain > 0)
        {
            string guess;
            do
            {
                Console.Write($"\nAttempt {attempts - remain + 1}: ");
                guess = (Console.ReadLine() ?? "").ToUpper();
            } while (guess.Length != n);
            int perfectMatchCount = 0;
            for (int i = 0; i < code.Length; i++)
                if (code[i] == guess[i])
                    perfectMatchCount++;
            int symbolMatchCount = 0;
            string temp = code;
            for (int i = 0; i < guess.Length; i++)
            {
                if (temp.Contains(guess[i]))
                {
                    symbolMatchCount++;
                    temp = temp.Remove(temp.IndexOf(guess[i]), 1);
                }

            }
            boardData.Add(guess +
            $" ({perfectMatchCount})({symbolMatchCount})");
            Console.Clear();
            Console.WriteLine("Code ($)(#)\n");
            foreach (string play in boardData)
                Console.WriteLine(play);
            Console.WriteLine("\n$ = Perfect Match\n# = Symbol Match");
            if (perfectMatchCount == n)
            {
                Console.WriteLine($"\nSUCCESS! Original code: {code}");
                return true;
            }
            remain--;
        }
        Console.WriteLine($"\nFAIL! The code was: {code}");
        return false;
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
if (markerPosition >= 35)
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
if (markerPosition == 17)
return 100;
else if (markerPosition >= 9 && markerPosition <= 26)
return 50;
return 25;
}
static int FarmSim(int turns) {
string[] animals = ["Horse", "Cow", "Goat"];
int[] secretFeed = new int[3];
Random random = new();
for (int i = 0; i < secretFeed.Length; i++)
secretFeed[i] = random.Next(1, 11);
int totalProduction = 0;
int feedStore = 0;
for (int turn = 1; turn <= turns; turn++) {
feedStore += 20;
int[] feedAllocated = new int[3];
Console.Clear();
Console.WriteLine($"Turn {turn} of {turns}");
Console.WriteLine($"Feed units available: {feedStore}");
Console.WriteLine($"Production units: {totalProduction}");
for (int i = 0; i < animals.Length; i++) {
int feed;
do {
Console.WriteLine($"\n{feedStore} feed units remain.");
Console.Write($"Feed units for {animals[i]}? ");
if (!int.TryParse(Console.ReadLine(), out feed) ||
feed < 0) {
Console.WriteLine("Please enter a valid number.");
feed = -1;
}
else if (feed > feedStore)
Console.WriteLine("Insufficient feed.");
} while (feed > feedStore || feed < 0);
feedAllocated[i] = feed;
feedStore -= feed;
}
Console.WriteLine();
for (int i = 0; i < animals.Length; i++) {
int distance = Math.Min(Math.Abs(feedAllocated[i] -
secretFeed[i]), 5);
int production = feedAllocated[i] > 0 ?
Math.Max(5 - distance, 1) * random.Next(10, 21) : 0;
Console.WriteLine($"{animals[i]} produced " +
$"{production} units.");
totalProduction += production;
}
Console.Write("\nPress ENTER to continue.");
Console.ReadLine();
}
int goldFromProduction = totalProduction / 10;
int goldFromFeed = feedStore / 20;
int totalGold = goldFromProduction + goldFromFeed;
Console.WriteLine("\nSUMMARY");
Console.WriteLine($"Gold from production: {goldFromProduction}");
Console.WriteLine($"Gold from remaining feed: {goldFromFeed}");
Console.WriteLine($"Total gold earned: {totalGold}");
return totalGold;
}
static bool MazeExplorer() {
string[] map = [
"+--------+-------+---+----+-----------+---+---------+",
"| T | | K | | T | | E |",
"| +----+ | | | +--+ +----+ | --+---+",
"| +---+ | | | D | |",
"| +----+ | | P | | +----+ +-----+ | |",
"| | | +---+ | | | | |",
"| | +----+ | +----+ | +-+ +---+ |",
"| | +----+ T | | | |",
"| +-------+ | +----+ +---+ | +---+",
"| | +----+ | | T |",
"| +---+ | | +----+ +---+ ---+ +--+",
"| | | +---+ | | | |",
"| | | +-----+------+ +--+--+ |",
"| | P | | T | | | |",
"+---+---+--------+---+---------+----------+---------+",
];
string[] maze = new string[map.Length];
for (int i = 0; i < maze.Length; i++)
maze[i] = new string(' ', map[i].Length);
char player = '@';
int playerRow = 1, playerCol = 2;
int key = 0;
Console.Clear();
Console.WriteLine("MESSAGE: Welcome!");
while (true) {
// Reveal surrounding area
for (int y = playerRow - 1; y <= playerRow + 1; y++) {
StringBuilder rowBuilder = new StringBuilder(maze[y]);
for (int x = playerCol - 1; x <= playerCol + 1; x++)
rowBuilder[x] = map[y][x];
maze[y] = rowBuilder.ToString();
}
// Add player and redraw map
ReplaceItem(maze, player, playerCol, playerRow);
foreach (string r in maze)
Console.WriteLine(r);
Console.Write("Move (n/s/w/e): ");
string move = (Console.ReadLine() ?? "").ToLower();
Console.Clear();
Console.Write("MESSAGE: ");
int newRow = playerRow, newCol = playerCol;
switch (move) {
case "n": newRow--; break;
case "s": newRow++; break;
case "w": newCol--; break;
case "e": newCol++; break;
default: Console.WriteLine(); continue;
}
char nextPos = map[newRow][newCol];
if (nextPos == ' ') {
Console.WriteLine();
ReplaceItem(maze, ' ', playerCol, playerRow);
playerRow = newRow;
playerCol = newCol;
}
else if (nextPos == 'K') {
Console.WriteLine("You found a key!");
ReplaceItem(map, ' ', newCol, newRow);
key = 1;
playerRow = newRow;
playerCol = newCol;
}
else if (nextPos == 'D') {
if (key >= 1) {
Console.WriteLine("You unlocked a door!");
ReplaceItem(map, ' ', newCol, newRow);
key--;
playerRow = newRow;
playerCol = newCol;
}
else
Console.WriteLine("The door is locked. Find the key.");
}
else if (nextPos == 'T') {
Console.WriteLine("You fell into a trap! Back to start.");
ReplaceItem(maze, ' ', playerCol, playerRow);
playerRow = 1;
playerCol = 2;
}
else if (nextPos == 'P') {
Console.WriteLine("You are teleported to a new location.");
ReplaceItem(maze, ' ', playerCol, playerRow);
(playerRow, playerCol) = FindTeleporter(map, newRow, newCol);
}
else if (nextPos == 'E') {
Console.WriteLine("You reached the exit!");
ReplaceItem(maze, ' ', playerCol, playerRow);
return true;
}
else
Console.WriteLine("Ouch! There is a wall!");
}
}
// Required for MazeExplorer
static void ReplaceItem(string[] maze, char item, int x, int y ) {
StringBuilder rowBuilder = new(maze[y]);
rowBuilder[x] = item;
maze[y] = rowBuilder.ToString();
}
// Required for MazeExplorer
static (int, int) FindTeleporter(string[] maze, int row, int col) {
for (int r = 0; r < maze.Length; r++)
for (int c = 0; c < maze[r].Length; c++)
if (maze[r][c] == 'P' && (r != row || c != col))
return (r, c);
return (row, col);
}
static bool QuickDraw(int speed) {
Random random = new();
Stopwatch stopwatch = new();
Console.WriteLine("Press the spacebar to draw your weapon.");
Console.WriteLine("Press ENTER when ready.");
Console.ReadLine();
int waitTime = random.Next(1000, 3000);
int elapsedTime = 0;
while (elapsedTime < waitTime) {
if (Console.KeyAvailable) {
var key = Console.ReadKey(true).Key;
if (key == ConsoleKey.Spacebar) {
Console.WriteLine("FAIL: You drew too soon!");
return false;
}

}
Thread.Sleep(10);
elapsedTime += 10;
}
Console.WriteLine("DRAW!");
stopwatch.Restart();
while (stopwatch.ElapsedMilliseconds < speed) {
if (Console.KeyAvailable) {
var key = Console.ReadKey(true).Key;
stopwatch.Stop();
if (key == ConsoleKey.Spacebar) {
Console.WriteLine("SUCCESS: Quickdraw! (" +
stopwatch.ElapsedMilliseconds + " ms)");
return true;
}
}
Thread.Sleep(10);
}
Console.WriteLine("FAIL: You have been shot.");
return false;
}
static int RhythmChamp() {
string letters = "ASDFG";
Random random = new();
int score = 0;
int speed = 1000;
Stopwatch stopwatch = new();
bool correct = true;
while (correct) {
Console.Clear();
char letter = letters[random.Next(letters.Length)];
Console.WriteLine(letter);
stopwatch.Restart();
correct = false;
while (stopwatch.ElapsedMilliseconds < speed) {
if (Console.KeyAvailable) {
char key = char.ToUpper(Console.ReadKey(true).KeyChar);
stopwatch.Stop();
if (key == letter) {
Console.WriteLine("Correct!");
score++;
correct = true;
}
else
Console.WriteLine("Fail!");
break;
}
}
speed -= 10;
Thread.Sleep(500);
}
Console.WriteLine("Finish");
Console.WriteLine($"Final Score: {score}");
return score;
}
static bool ShellGame(int swaps, int delay)
{
Random random = new();
int[] shells = [1, 2, 3];
int seedPosition = random.Next(0, 3);
Console.WriteLine("The seed is placed under shell " +
$"{shells[seedPosition]}.");
Console.WriteLine("Press ENTER when ready.");
Console.ReadLine();
for (int i = 0; i < swaps; i++) {
int shell1 = random.Next(0, 3);
int shell2;
do {
shell2 = random.Next(0, 3);
} while (shell1 == shell2);
Console.Clear();
Console.WriteLine($"Swapping shell {shells[shell1]} and " +
$"shell {shells[shell2]}.");
Thread.Sleep(delay);
(shells[shell2], shells[shell1]) =
(shells[shell1], shells[shell2]);
}
Console.Clear();
Console.WriteLine("Where is the seed now?");
Console.WriteLine("Enter your guess (1, 2, or 3):");
int guess = int.Parse(Console.ReadLine() ?? "");
if (guess == shells[seedPosition]) {
Console.WriteLine("SUCCESS! You found the seed!");
return true;
}
Console.WriteLine("FAIL! The seed was under shell " +
$"{shells[seedPosition]}.");
return false;
}
static int TriviaQuiz() {
List<Question> questions = [];
questions.Add(new Question("What was the first game with Mario?",
["Donkey Kong", "Legend of Zelda", "Metroid", "Excitebike"]));
questions.Add(new Question("Which game has Samus Aran?",
["Metroid", "Castlevania", "Mega Man", "Duck Hunt"]));
questions.Add(new Question("What game featured Simon Belmont?",
["Castlevania", "Contra", "Dragon Quest", "Punch-Out!!"]));
questions.Add(new Question("Which game was set in Hyrule?",
["Legend of Zelda", "Mario", "Kid Icarus", "Ice Climber"]));
questions.Add(new Question("Which device was used for Duck Hunt?",
["The NES Zapper", "Power Glove", "NES Advantage", "R.O.B."]));
int score = 0;
foreach (var question in questions) {
question.Display();
string playerAnswer = Console.ReadLine() ?? "";
if (question.CheckAnswer(playerAnswer)) {
Console.WriteLine("Correct!\n");
score++;
}
else
Console.WriteLine("Incorrect! The answer is: " +
$"{question.CorrectAnswer}\n");
}
return score;
}
// Required for TriviaQuiz
class Question {
public string Prompt { get; private set; }
public List<string> AnswerSet { get; private set; }
public string CorrectAnswer { get; private set; }
public Question(string prompt, List<string> answerSet) {
Prompt = prompt;
this.AnswerSet = answerSet;
CorrectAnswer = answerSet[0];
Random rand = new();
AnswerSet = [.. AnswerSet.OrderBy(x => rand.Next())];
}
public void Display() {
Console.WriteLine(Prompt);
for (int i = 0; i < AnswerSet.Count; i++)
Console.WriteLine($"{i + 1}. {AnswerSet[i]}");
}
public bool CheckAnswer(string input) {
if (int.TryParse(input, out int choice))
return choice > 0 &&
choice <= AnswerSet.Count &&
AnswerSet[choice - 1] == CorrectAnswer;
return false;
}
}
static bool TypeRacer(string phrase, int target) {
Console.WriteLine("Type the following phrase as quickly and accurately as" +
"possible:");
Console.WriteLine($"Target: {target}ms");
Stopwatch stopwatch = new();
stopwatch.Start();
string userInput;
do {
Console.WriteLine($"\n{phrase}");
userInput = Console.ReadLine() ?? "";
if (userInput != phrase)
Console.WriteLine("\nIncorrect! Try again!");
} while (userInput != phrase);
stopwatch.Stop();
int elapsedTime = (int)stopwatch.ElapsedMilliseconds;
if (elapsedTime <= target) {
Console.WriteLine($"SUCCESS: {elapsedTime}ms!");
return true;
}
else {
Console.WriteLine($"FAIL: {elapsedTime}ms");
return false;
}
}
}