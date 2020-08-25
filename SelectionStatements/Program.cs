using System;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            bool rightAnswer = false;
            var r = new Random();
            var magicNum = r.Next(1, 100);
            
           
            Console.WriteLine("Guess what number I'm thinking of. It's between 1 and 100.");
            
            do
            { 
                var userGuess = int.Parse(Console.ReadLine());
                if (userGuess < magicNum)
                {
                    string[] lowArray = { "Aw, too low. Try again.", "Nope, it's too low!", "Good guess, but that's too low.", "Try something higher!"};
                    var r2 = new Random();
                    string lowOutput = lowArray[r2.Next(lowArray.Length)];
                    Console.WriteLine(lowOutput);  
                }
                else if (userGuess > magicNum)
                {
                    string[] highArray = { "Nope, that's too high.", "Too high!", "Try again, that one's too high.", "Try something lower!" };
                    var r3 = new Random();
                    string highOutput = highArray[r3.Next(highArray.Length)];
                    Console.WriteLine(highOutput);
                }
                else
                {
                    string[] winArray = { $"YAY! {magicNum} WAS IT", $"You did it!!! It's {magicNum}!!!", $"Nice, you guessed {magicNum} right!", $"Hooray! You're right, it was {magicNum}!" };
                    var r4 = new Random();
                    string winOutput = winArray[r4.Next(winArray.Length)];
                    Console.WriteLine(winOutput);
                    rightAnswer = true;
                }  
            }
            while (rightAnswer == false) ;
        }
    }
}
