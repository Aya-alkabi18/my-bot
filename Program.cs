using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;

 
namespace ConsoleApp1
{
    class Program
    {
        static string token = "5022859840:AAEmzkzA1kpG4eCKc3OUdWyEm859JRqzeAc";
       // static string key = "de064bb611b410e64a3c9f87c36d91d3 ";
        


        static Telegram.Bot.TelegramBotClient bot =new TelegramBotClient(token);

        static void Main(string[] args)
        {
            
            int offset = 0;
            while(true)
            {
                Telegram.Bot.Types.Update[] updates = bot.GetUpdatesAsync(offset).Result;
                try
                {
                    foreach (var Update in updates)
                    {
                        offset = Update.Id + 1;
                        if (Update.Message != null)
                        {
                            long Id = Update.Message.From.Id;
                            string Txt = Update.Message.Text;
                            string username = Update.Message.From.Username;
                            string firstname = Update.Message.From.FirstName;
                            string lastname = Update.Message.From.LastName;

                            if (Txt == "/start")
                            {
                                bot.SendTextMessageAsync(Id, "hello");
                                Console.WriteLine(Id);
                                Console.WriteLine(Txt);
                                Console.WriteLine(username);
                                Console.WriteLine(firstname);
                                Console.WriteLine(lastname);

                            }
                            else if (Txt == "what are you serving")
                            {
                                bot.SendTextMessageAsync(Id, "software information ");
                            }
                            else if (Txt == ("whose you"))
                            {
                                bot.SendTextMessageAsync(Id, "aya& ahmade");
                            }

                        }

                    }


                }
                catch (Exception exp)
                {
                    Console.WriteLine("the following error has occurred:");
                    Console.WriteLine(exp.Message);
                }
            }

        }
    }
}



