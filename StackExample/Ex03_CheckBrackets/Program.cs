using static System.Console;
int size = 20;
int top = 0;

(char, int)[] storage = new (char, int)[size];

void Push((char, int) pair) => storage[top++] = pair;

(char symbol, int position) Pop() => storage[--top];

bool Empty() => top == 0;

int Check(string ex)
{
  /// перебор всех символов строки
  for (int i = 0; i < ex.Length; i++)
  {
    char current = ex[i]; // текущий символ
    if ("[({".IndexOf(current) != -1) // если символ открывающаяся скобка
    {
      Push((current, i)); // добавляем в стек
    }
    else // иначе
    {
      switch (current) // проверка оставшихся символов
      {
        // если закрывающаяся скобка проверяем пару
        // либо стек пуст, либо не пара - возвращаем позицию 
        case '}':
          if (Empty() || Pop().symbol != '{')
            return i;
          break;
        case ')':
          if (Empty() || Pop().symbol != '(')
            return i;
          break;
        case ']':
          if (Empty() || Pop().symbol != '[')
            return i;
          break;
        default: // если не скобка - игнорируем
          break;
      }
    }
  }
  if (Empty()) return -1; // если всё сошлось
  return Pop().position;  // если остался хотя бы один символ 
                          // - указываем его позицию
}

/// указание проблемного места
string Print(string s, int pos)
{
  if (pos == -1) return "yes";
  string result = $"no\n{s}";
  result += $"\n{new string(' ', pos)}^";
  return result;
}

string expression = "{[(1+2)*3]-(4*6)}";
WriteLine(Print(expression, Check(expression)));