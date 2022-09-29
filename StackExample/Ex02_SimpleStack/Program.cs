// const int size = 5;

// char[] storage = new char[size];
// int top = 0;
// void PUSH(char x, char[] S) => S[top++] = x;
// char POP(char[] S) => S[--top];

// // Демонстрация работы
// PUSH('t', storage);
// char item = POP(storage);
// Console.WriteLine($"item: {item}");

const int size = 5;

char[] stack = new char[size];
int top = 0;
void PUSH(char x) => stack[top++] = x;
char POP() => stack[--top];

// Демонстрация работы
PUSH('t');
char item = POP();
Console.WriteLine($"item: {item}");
