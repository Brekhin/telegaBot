using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        private static String API_KEY = "690981863:AAGvU_8M89Rq9JW85jQ1gHTcNhNZJsQ_SGw";
        private static readonly Telegram.Bot.TelegramBotClient  Bot = new Telegram.Bot.TelegramBotClient(API_KEY);

        static void Main(string[] args)
        {
            var me = Bot.GetMeAsync().Result;
            Console.Title = me.Username;

            Bot.StartReceiving();
            Console.ReadLine();
            Bot.StopReceiving();
        }
    }
}
