Console.Write("x = ");
var x = Convert.ToDouble(Console.ReadLine());
Console.Write("y = ");
var y = Convert.ToDouble(Console.ReadLine());

if (y != 0)
{
  Console.WriteLine(x / y);
}
else
{
  Console.WriteLine("NaN");
}