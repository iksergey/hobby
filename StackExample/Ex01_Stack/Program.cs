// 1. CLEAR(S).Делает стек S пустым.
// 2. PEEK(S). Возвращает элемент из вершины стека S.
// 3. POP(S). Удаляет элемент из вершины стека. 
//    Этот оператор реализуется в виде функции, 
//    возвращающей удаляемый элемент, т е x = POP(S)
// 4. PUSH(x, S).Вставляет элемент х в вершину стека S.
//    Элемент, ранее находившийся в вершине стека, 
//    становится элементом, следующим за вершиной, и т.д. 
// 5. EMPTY(S). Эта функция возвращает значение true (истина), 
//    если стек S пустой, и значение false (ложь) в противном случае.

const int size = 10;
const int emptyElement = 0;

int[] storage = new int[size];
int top = 0;

void CLEAR(int[] S)
{
  for (int i = 0; i < top; i++) S[i] = emptyElement;
  top = 0;
}

int PEEK(int[] S) => S[top - 1];

int POP(int[] S) => S[--top];

void PUSH(int x, int[] S) => S[top++] = x;

bool EMPTY(int[] S) => top == 0;

// Демонстрация работы

Console.WriteLine($"EMPTY(STACK) => {EMPTY(storage)}");

PUSH(2809, storage);
Console.WriteLine($"EMPTY(STACK) => {EMPTY(storage)}");

Console.WriteLine($"PEEK(STACK) = {PEEK(storage)}");
Console.WriteLine($"EMPTY(STACK) => {EMPTY(storage)}");
int item = POP(storage);
Console.WriteLine($"item: {item}");

Console.WriteLine($"EMPTY(STACK) => {EMPTY(storage)}");
