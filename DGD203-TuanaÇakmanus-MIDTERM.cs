using System;
//I used some help from chatGPT
class Program
{
    static void Main(string[] args)
    {
        string playerName;

        Console.WriteLine("Welcome to the Harry Potter House Selection Quiz!");
        Console.Write("What's your name? ");
        playerName = Console.ReadLine();

        Console.WriteLine("\nDo you want to know which house you belong to, " + playerName + "? No? Yes? I will be happy to help you with that.");
        Console.WriteLine("I want you to answer the questions with honesty!!");

        Console.WriteLine("\nPress Enter to start...");
        Console.ReadLine();

        //Question 1
        Console.WriteLine($"\n1-{playerName}, choose one of these elements!");
        Console.WriteLine("A) Air");
        Console.WriteLine("B) Fire");
        Console.WriteLine("C) Water");
        Console.WriteLine("D) Earth");
        Console.Write("Your choice (A/B/C/D): ");
        string choice1 = GetValidInput();

        //Commentary and Questions 2 based on choices of question 1
        if (choice1 == "A")
        {
            Console.WriteLine("\nAir hm? Cool.");
            Console.WriteLine("\n2-Now now, which animal symbolizes you?");
            Console.WriteLine("A) Raven");
            Console.WriteLine("B) Lion");
            Console.WriteLine("C) Snake");
            Console.WriteLine("D) Possum");
        }
        else if (choice1 == "B")
        {
            Console.WriteLine("\nFire hm? Quite interesting.");
            Console.WriteLine("\n2-Now choose the color that fits you the most!");
            Console.WriteLine("A) Blue");
            Console.WriteLine("B) Red");
            Console.WriteLine("C) Green");
            Console.WriteLine("D) Yellow");
        }
        else if (choice1 == "C")
        {
            Console.WriteLine("\nHmm, water sounds great.");
            Console.WriteLine("\n2-Which animal would you like to have in Hogwarts?");
            Console.WriteLine("A) Owl");
            Console.WriteLine("B) Cat");
            Console.WriteLine("C) Rat");
            Console.WriteLine("D) Toad");
        }
        else if (choice1 == "D")
        {
            Console.WriteLine("\nEarth huh? Pretty cool!");
            Console.WriteLine("\n2-What is your MBTI type?");
            Console.WriteLine("A) INTP/INFJ/ISTP/INTJ");
            Console.WriteLine("B) ENTP/ENFP/ESFP/ESTP");
            Console.WriteLine("C) ENTJ/ESTJ/ISTJ/ISFJ");
            Console.WriteLine("D) ENFP/ISFP/ENFJ/ESFJ");
        }
        Console.Write("Your choice (A/B/C/D): ");
        string choice2 = GetValidInput();

        //Question 3
        Console.WriteLine($"\n3-Which fault do you notice in people that bothers you the most, {playerName}?");
        Console.WriteLine("A) Stupidity");
        Console.WriteLine("B) Cowardice");
        Console.WriteLine("C) Laziness");
        Console.WriteLine("D) Dishonesty");
        Console.Write("Your choice (A/B/C/D): ");
        string choice3 = GetValidInput();

        //Commentaries based on choices of question 3
        if (choice3 == "A")
            Console.WriteLine("\nHmm. I'm getting somewhere...");
        else if (choice3 == "B")
            Console.WriteLine("\nYes.. it's starting to make sense.");
        else if (choice3 == "C")
            Console.WriteLine("\nHmm.. I think I need to ask some more to make sure.");
        else if (choice3 == "D")
            Console.WriteLine("\nJust what I thought.");

        //Questions 4 based on choices of question 3
        if (choice3 == "A")
        {
            Console.WriteLine("\n4-Which one of those is much likely to be your flaw?");
            Console.WriteLine("A) Being insensitive");
            Console.WriteLine("B) Being reckless");
            Console.WriteLine("C) Being selfish");
            Console.WriteLine("D) Being so naive");
        }
        else if (choice3 == "B")
        {
            Console.WriteLine("\n4-Choose a movie genre to watch.");
            Console.WriteLine("A) Documentary");
            Console.WriteLine("B) Action");
            Console.WriteLine("C) Crime");
            Console.WriteLine("D) Romantic/Comedy");
        }
        else if (choice3 == "C")
        {
            Console.WriteLine("\n4-Which of these superpowers would you like to have?");
            Console.WriteLine("A) Flying");
            Console.WriteLine("B) Strength");
            Console.WriteLine("C) Invisibility");
            Console.WriteLine("D) Talking to animals");
        }
        else if (choice3 == "D")
        {
            Console.WriteLine("\n4-What would you do if someone is making fun of you?");
            Console.WriteLine("A) Ignore them");
            Console.WriteLine("B) BEAT THEM");
            Console.WriteLine("C) Revenge is the only right option");
            Console.WriteLine("D) Talk about this with my friends");
        }
        Console.Write("Your choice (A/B/C/D): ");
        string choice4 = GetValidInput();

        //Question 5
        Console.WriteLine($"\n5-Now the last one, but be honest! Which of these words describes you?");
        Console.WriteLine("A) Creative/Intelligent");
        Console.WriteLine("B) Daring/Courageous");
        Console.WriteLine("C) Determined/Ambitious");
        Console.WriteLine("D) Kind/Hardworking");
        Console.Write("Your choice (A/B/C/D): ");
        string choice5 = GetValidInput();

        //Results based on choices of the player
        if (choice1 == "A" && choice2 == "A" && choice3 == "A" && choice4 == "C" && choice5 == "A")
            Console.WriteLine($"\n{playerName}, A ready mind.. You belong in Ravenclaw! I know when I see a ravenclaw!");
        else if (choice1 == "B" && choice2 == "B" && choice3 == "B" && choice4 == "B" && choice5 == "B")
            Console.WriteLine($"\n{playerName},Gryffindor! Daring soul I see.. Better be a Gryffindor!! A soul as brave as yours is quite rare, yet easy to see!");
        else if (choice1 == "C" && choice2 == "B" && choice3 == "C" && choice4 == "A" && choice5 == "C")
            Console.WriteLine($"\n{playerName},You're a bit older..and darker..Must be a Slytherin!!");
        else
            Console.WriteLine($"\n{playerName},You sure are loyal and quite hardworking I see.. Hufflepuff!!");
    }

    //Helper method to get valid input (used help from chatgpt here)
    static string GetValidInput()
    {
        string input = Console.ReadLine().ToUpper();
        while (input != "A" && input != "B" && input != "C" && input != "D")
        {
            Console.Write("Invalid input. Please choose A, B, C, or D: ");
            input = Console.ReadLine().ToUpper();
        }
        return input;
    }
}