// dotnet add package telegram.bot
using Telegram.Bot;

string token = "TOKEN";
var client = new TelegramBotClient(token);

string GetAnswer(string msg)
{
  string answer = "🤝";
  if (msg.Contains("hi"))
  {
    answer = "Дратути!";
  }
  return answer;
}

client.StartReceiving(
(c, arg, _) =>
{
  // 
  // Чтобы показать ник -> Console.WriteLine(arg.Message.Chat.FirstName); и тд
  return c.SendTextMessageAsync(arg.Message.Chat.Id,
  GetAnswer(arg.Message.Text.ToLower()));
},
(_, _, _) => Task.CompletedTask

);
Console.WriteLine("StartReceiving ...");
Console.ReadLine();