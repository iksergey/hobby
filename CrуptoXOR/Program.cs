using System.Text;
using static System.Console;

string Enigma(string text, int key)
{
  StringBuilder sb = new();
  int len = text.Length;
  for (int i = 0; i < len; i++)
  {
    int code = text[i];
    sb.Append((char)(code ^ key));
  }
  return sb.ToString();
}


string text = "Привет, мир!";
string encrypted = Enigma(text, 4);

string deciphered = Enigma(encrypted, 4);
Console.WriteLine($"text: {text}");
Console.WriteLine($"encrypted: {encrypted}");
Console.WriteLine($"deciphered: {deciphered}");

for (int key = 0; key < 10; key++)
{
  WriteLine($"key {key}: {Enigma(encrypted, key)}");
}


// byte b = (byte)0b0011;
// Console.WriteLine($"b₂: {Convert.ToString(b, toBase: 2)}");
// Console.WriteLine($"b₁₀: {Convert.ToString(b, toBase: 10)}");
// Console.WriteLine($"not b₂: {Convert.ToString(~b, toBase: 2)}");
// Console.WriteLine($"not b₁₀: {Convert.ToString(~b, toBase: 10)}");

// Console.WriteLine($"(2022 ^ 21): {(2022 ^ 21)}");
// Console.WriteLine($"((2022 ^ 21) ^ 21): {((2022 ^ 21) ^ 21)}");