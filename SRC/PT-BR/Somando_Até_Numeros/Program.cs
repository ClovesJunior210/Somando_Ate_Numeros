using System;
using System.Numerics;
using System.Runtime.InteropServices; // Não sei se isso é útil ou não, porém o VS Code colocou.
using System.Collections.Generic;

class Program {

    static void Main() {
        
        Console.Clear(); // Para limpar o console
        string BotName = "SumBot: "; // Determina o nome do bot
        Console.WriteLine($"{BotName}Olá! É um prazer conhecê-lo!");
        Thread.Sleep(2000);
        Console.WriteLine($"{BotName}Minha função é calcular a soma de todos os números inteiros de 1 até o número que você digitar.");
        Thread.Sleep(2000);
        Console.WriteLine($"{BotName}Exemplo: você diz 5, e eu vou somar (1+2+3+4+5 = 15). Pronto?");
        Thread.Sleep(3000);

        bool PlayAgain = true;
        while (PlayAgain) {
            while (true) {

                Console.WriteLine($"{BotName}Pode dizer!");
                Console.Write("Você: ");
                string? Input = Console.ReadLine();
                int Num1; 
                if (int.TryParse(Input, out Num1)) {

                    Calculo(Num1, BotName, PlayAgain);
                    break;

                }
                else {

                    Console.WriteLine($"{BotName}Diga um número válido!");

                }   
            }
        }
    }

    static void Calculo(int Num1, string BotName, bool PlayAgain) {
        int NumFinal = 0;
        List<String> Somas = new List<string>(); // Aprendi a usar listas (mais ou menos)
        for (int Somador = 1; Somador <= Num1; Somador++)
        {
            NumFinal += Somador;
            Somas.Add($" + {Somador}");
        }
        
        Somas.Add($" = {NumFinal}");
        Console.WriteLine($"{BotName}Pronto! O resultado foi {NumFinal}. A soma ficou assim: {String.Join(" ", Somas)}. Se quiser refazer, é só digitar 'denovo'. ");
        Console.Write("Você: ");
        bool InputNull = true;
        while(InputNull) {

            InputNull = false;    
            string? RepetirInput = Console.ReadLine();
            if(RepetirInput != null) {
            
                RepetirInput = RepetirInput.ToLower().Trim();
                if (RepetirInput == "denovo") {

                    PlayAgain = true;

                }

            }

            else {

                Console.WriteLine("Resposta inválida");
                InputNull = true;

            }
        }
    }
}

// Data de início: 28/01/25 18:40
// Data de término: 30/01/25 10:45
// Percebi que eu não tive muitas dificuldades com erros de sintaxe dessa vez, porque mudei de editor de código. Agora uso o VS Code. Tive mais bugs, mas acho que resolvi todos. Agora vou estudar o máximo possível para sair do básico. ;)