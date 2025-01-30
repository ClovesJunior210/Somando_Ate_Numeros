using System;
using System.Numerics;
using System.Runtime.InteropServices; // Not sure if this is useful or not, but VS Code added it.
using System.Collections.Generic;

class Program {

    static void Main() {
        
        Console.Clear(); // To clear the console
        string BotName = "SumBot: "; // Sets the bot's name
        Console.WriteLine($"{BotName}Hello! It's a pleasure to meet you!");
        Thread.Sleep(2000);
        Console.WriteLine($"{BotName}My function is to calculate the sum of all the integers from 1 to the number you enter.");
        Thread.Sleep(2000);
        Console.WriteLine($"{BotName}Example: you say 5, and I will sum (1+2+3+4+5 = 15). Ready?");
        Thread.Sleep(3000);

        bool PlayAgain = true;
        while (PlayAgain) {
            while (true) {

                Console.WriteLine($"{BotName}Go ahead!");
                Console.Write("You: ");
                string? Input = Console.ReadLine();
                int Num1; 
                if (int.TryParse(Input, out Num1)) {

                    Calculo(Num1, BotName, PlayAgain);
                    break;

                }
                else {

                    Console.WriteLine($"{BotName}Please enter a valid number!");

                }   
            }
        }
    }

    static void Calculo(int Num1, string BotName, bool PlayAgain) {
        int NumFinal = 0;
        List<String> Somas = new List<string>(); // I learned to use lists (kind of)
        for (int Somador = 1; Somador <= Num1; Somador++)
        {
            NumFinal += Somador;
            Somas.Add($" + {Somador}");
        }
        
        Somas.Add($" = {NumFinal}");
        Console.WriteLine($"{BotName}Done! The result was {NumFinal}. The sum looked like this: {String.Join(" ", Somas)}. If you want to try again, just type 'again'. ");
        Console.Write("You: ");
        bool InputNull = true;
        while(InputNull) {

            InputNull = false;    
            string? RepetirInput = Console.ReadLine();
            if(RepetirInput != null) {
            
                RepetirInput = RepetirInput.ToLower().Trim();
                if (RepetirInput == "again") {

                    PlayAgain = true;

                }

            }

            else {

                Console.WriteLine("Invalid answer");
                InputNull = true;

            }
        }
    }
}

// Start date: 28/01/25 18:40
// End date: 30/01/25 10:45
// I realized that I didn't have many syntax issues this time, because I switched to a new code editor. Now I use VS Code. I had more bugs, but I think I've fixed them all. Now I'll study as much as I can to move beyond the basics. ;)
