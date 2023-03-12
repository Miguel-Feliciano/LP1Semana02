using System;

namespace GranpaPatternSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variáveis auxiliares
            string question, response;

            // Colocar questão ao utilizador
            Console.Write("Place your question? ");
            question = Console.ReadLine();
            //sintaxe por padrões
            string response = question switch 
            {
                "How are you?" => "I'm fine, thank you",
                "What's your name?" => "Gran'pa",
                "What's your mission?" => "Destroy mankind!",
                _ => "You got me, I'm not THAT smart!",  
            };
            Console.WriteLine(response);

            
        }
    }
}
