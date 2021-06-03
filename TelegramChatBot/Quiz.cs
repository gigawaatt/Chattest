using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramChatBot
{
    public class Quiz
    {
        public Quiz(string path = "data.txt")
        {
            var lines = File.ReadAllLines(path);
            var questions = lines.
                Select(line => line.Split('|')).
                Select(line => (line[0], line[1])).
                ToList();

            var random = new Random();
            var count = questions.Count;

            var score = 0;

        }
    }
}
