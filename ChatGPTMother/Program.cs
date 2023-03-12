using System;

namespace ChatGPTMother
{
    class Program
    {
        static void Main(string[] args)
        {

            bool isExit = false;

            while (!isExit)
            {
                Console.WriteLine("Ask me a question: ");
                string question = Console.ReadLine();

                switch (question.ToLower())
                {
                    case "what is your name?":
                        Console.WriteLine("My name is ChatGPTMother.");
                        break;
                    case "what is the weather like today?":
                        Console.WriteLine("I don't know.");
                        break;
                    case "what time is it?":
                        Console.WriteLine("Its the time that it tells in your clock.");
                        break;
                    case "what is the meaning of life?":
                        Console.WriteLine("Would'nt you like to know...");
                        break;
                    case "exit":
                        isExit = true;
                        break;
                    default:
                        Console.WriteLine("I'm sorry, I don't know the answer to that question.");
                        break;
                }
            }



        }
    }
}
