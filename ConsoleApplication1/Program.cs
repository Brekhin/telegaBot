using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot.Args;
using static ConsoleApplication1.JSONToEntity;

namespace ConsoleApplication1
{
    class Program
    {
        private static String API_KEY = "690981863:AAGvU_8M89Rq9JW85jQ1gHTcNhNZJsQ_SGw";
        private static readonly Telegram.Bot.TelegramBotClient Bot = new Telegram.Bot.TelegramBotClient(API_KEY);

        static void Main(string[] args)
        {
            Bot.OnMessage += BotOnTextReceived;
            var me = Bot.GetMeAsync().Result;
            Console.Title = me.Username;

            Bot.StartReceiving();
            Console.ReadLine();
            Bot.StopReceiving();
        }

        public static JObject getInfo()
        {
            WebRequest reqGet = WebRequest.Create("http://budget.gov.ru/epbs/registry/grants/data?pageSize=1000");
            WebResponse resp = reqGet.GetResponse();
            Stream stream = resp.GetResponseStream();
            StreamReader sr = new StreamReader(stream);
            string s = sr.ReadToEnd();
            JObject parsed = JObject.Parse(s);
            return parsed;
        }

        private static string parseJson(JObject parse)
        {
            string json = parse.ToString();

            RootObject info = JsonConvert.DeserializeObject<RootObject>(json);
 
            List<Plan> planN = new List<Plan>();
            List<DateTime> dateTimeM = new List<DateTime>();
            foreach (Datum dt in info.data)
            {
                foreach(Plan pl in dt.plans)
                {
                    if (pl.sumTotal >= 100000000)
                    {
                        Console.WriteLine("123");
                        DateTime date1 = dt.changes.Last().docdate;
                        Console.WriteLine(dt.changes.Last().docdate.ToString());
                        planN.Add(pl);
                        dateTimeM.Add(date1);
                    }
                }
            }
            DateTime maxDate = DateTime.MinValue;
            int j = 0;
            for (int i = 0; i < dateTimeM.Count; i++)
            {
                if(dateTimeM[i] > maxDate) {
                    maxDate = dateTimeM[i];
                    j = i;
                }
            }

            Plan z = planN[j];
            

            return "Были выделены " + z.purpose.ToLower() + " на сумму " + z.sumTotal.ToString();
        }

        private static void BotOnTextReceived(object sender, MessageEventArgs messageEventArgs)
        {
            var message = messageEventArgs.Message;
            var inn = message.Text;
            try
            {
                if (inn == "/start")
                {
                    JObject jp = getInfo();
                    string res = parseJson(jp);
                    Bot.SendTextMessageAsync(message.Chat.Id, res);
                }
            }
            catch (Exception e)
            {
                Bot.SendTextMessageAsync(message.Chat.Id, "Неверно!");
            }
        }
    }
}
