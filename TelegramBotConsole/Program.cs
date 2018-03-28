using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
namespace TelegramBotConsole
{
    class Program
    {
        private static readonly TelegramBotClient bot = new TelegramBotClient("485173564:AAFSlGZ-umlTG057HnUgE69TYR7EY_8iewg");
        static void Main(string[] args)
        {
            bot.OnMessage += Bot_OnMessag;
            bot.OnMessageEdited += Bot_OnMessag;
            bot.StartReceiving();
            Console.ReadLine();
            bot.StopReceiving();
        }

        private static void Bot_OnMessag(object sender, Telegram.Bot.Args.MessageEventArgs e)
        {
            /* // for bot.OnMessage += Bot_OnMessag;
            if (e.Message.Type == Telegram.Bot.Types.Enums.MessageType.TextMessage)
            {
                Console.WriteLine(e.Message.Text);
            }
            */

            if (e.Message.Type == Telegram.Bot.Types.Enums.MessageType.TextMessage)
            {
                string replyText = "Hello from X-ware :)";
                if (e.Message.Text == "c1-10")
                    replyText = "Do you want to purchase cement-01 , quantity=10 ?";
                
                bot.SendTextMessageAsync(e.Message.Chat.Id, replyText);
            }
        }
    }
}
