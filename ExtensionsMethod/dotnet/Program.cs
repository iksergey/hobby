
// string ou = Prepare(Processing(NumbFrom(Console.ReadLine())));

Console.WriteLine("Введите строку");

string ou =
  Console.ReadLine()
         .NumbFrom()
         .Processing()
         .Prepare();

Console.WriteLine($"ou: {ou}");