using System;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Collections.Generic;

class Program {

    static void Main() {
        
        string BotName = "SumBot: ";
        Console.WriteLine($"{BotName}Olá! É um prazer conhecê lo!");
        Thread.Sleep(2000);
        Console.WriteLine($"{BotName}Minha função é calcular a soma de todos os números inteiros de 1 até o número que você digitar.");
        Thread.Sleep(2000);
        Console.WriteLine($"{BotName}Exemplo Voce diz 5 eu vou soma (1+2+3+4+5 = 15). Pronto?");
        Thread.Sleep(3000);
        Console.WriteLine($"{BotName}Pode dizer!");

        while (true) {
            string? Input = Console.ReadLine();
            int Num1; 
            if (int.TryParse(Input, out Num1)) {

                Calculo(Num1, BotName);
                break;

            }
            else {

                Console.WriteLine($"{BotName}Diga um número válido!");


            }   
        }
    }

    static void Calculo(int Num1, string BotName) {
        int NumFinal = 0;
        int Somador = 0;
        List<String> Somas = new List<string>(); 
        while (true) { 
            

            if (Num1 == Somador) {
                
                Somas.Add($" = {NumFinal}");
                Console.WriteLine($"{BotName}Pronto! Resutaltado = {NumFinal} A soma ficou assim {String.Join(",", Somas)} Tchau!");
                break;

            }

            else {
                
                Somador += 1;
                NumFinal += Somador;
                Somas.Add($" + {Somador}");
                

            }
        }
    }
}

// data de inicio 28/01/25 18:40
// data de termino xx/01/25 xx:xx