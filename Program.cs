using System;

Main();

void Main()
{
    Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
    Console.WriteLine("--------------------------------------------");
    Console.WriteLine();

    // Let the moose speak!
    MooseSays("H I, I'M  E N T H U S I A S T I C !");
    MooseSays("I really am enthusiastic");

    // Ask a question
    Question();
    // EnthusiasticQuestion();
    // LoveCSharpQuestion();
    // SecretQuestion();
    // invoking the function
}
 


void Question()
{
    bool isTrue = MooseAsks("Is Canada real?");
    if (isTrue)
    {
        MooseSays("Really? It seems very unlikely.");
    }
    else
    {
        MooseSays("I  K N E W  I T !!!");
    }

    bool enthusiastic = MooseAsks("Are you enthusiastic?");
    if (enthusiastic)
    {
        MooseSays("Yay!!!");
    }
    else
    {
        MooseSays("You should try it");
    }

    bool doesLoveCSharp = MooseAsks("Do you love C# yet?");
    if (doesLoveCSharp)
    {
        MooseSays("Good job sucking up to your instructor!");
    }
    else
    {
        MooseSays("You will...oh, yes, you will...");
    }

      bool wantsSecret = MooseAsks("Do you want to know a secret?");
    if (wantsSecret)
    {
        MooseSays("ME TOO!!!! I love secrets...tell me one!");
    }
    else
    {
        MooseSays("Oh, no...secrets are the best, I love to share them!");
    }
}









  





bool MooseAsks(string question)
// this is the format for a c# function
{
    Console.Write($"{question} (Y/N): ");
    // this line writes the question to the console
    string answer = Console.ReadLine().ToLower();
    // creates a string variable and assigns to it the value of the user input, 
    // changing input all to lower case with ToLower() method

    while (answer != "y" && answer != "n")
    // this function will continue to run until user inputs answer of y/n
    {
        Console.Write($"{question} (Y/N): ");
        // this line prints the question string and the y/n answer option
        answer = Console.ReadLine().ToLower();
        // gets user input and changes it to lower case
    }

    if (answer == "y")
    // if 
    {
        return true;
    }
    else
    {
        return false;
    }
}




void MooseSays(string message)
{
    Console.WriteLine($@"
                                      _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
    ");
}