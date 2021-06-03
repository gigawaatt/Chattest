using System;
using Telegram.Bot;

namespace TelegramChatBot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string token = "870171424:AAG8yCjqyc0fimQN7P6-iOth4gNhsoc6tBs";
            var bot = new TelegramBotClient(token);
            bot.OnMessage += Bot_OnMessage;
            bot.StartReceiving();
            Console.ReadKey();
        }

        private static void Bot_OnMessage(object sender, Telegram.Bot.Args.MessageEventArgs e)
        {

        }
    }
}
