using System;
using System.IO;
using System.Linq;

namespace Chattest
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = File.ReadAllLines("data.txt");
            var questions = lines.
                Select(line => line.Split('|')).
                Select(line => (line[0], line[1])).
                ToList();

            var random = new Random();
            var count = questions.Count;

            var score = 0;

           

            while(true)
            {
                var index = random.Next(count - 1);
                var question = questions[index];

                var opened = 1;

                while (opened < question.Item2.Length)
                {
                    Console.WriteLine($"{question.Item1} : {question.Item2.Length - 1} букв");


                    var tryAnswer = Console.ReadLine().ToUpperInvariant();
                    var answer = question.Item2.Substring(0, opened).PadRight(question.Item2.Length, '_');

                    Console.WriteLine($"Sub {answer}");

                    if (tryAnswer == question.Item2.ToUpperInvariant().Replace('ё' , 'e'))
                    {
                        Console.WriteLine("It is True!");
                        score++;
                        Console.WriteLine($"You score is {score}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("It is False!");
                        opened++;
                    }
                }

                if (opened + 1 == question.Item2.Length); 
                {
                    Console.WriteLine($"You are stupid. This is - {question.Item2}");
                }


               
            }
            
            //foreach ((string, string) question in questions)
            

        }
    }
}
