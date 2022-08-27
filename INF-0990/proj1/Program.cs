// See https://aka.ms/new-console-template for more information


int Max(int a, int b)
{
  return (a > b) ? a : b;
}
int a = 3;
int b = 2;

Max(a, b);   // 3
Max(b, a);   // 3

// Alteracao realizada por andrey

Console.WriteLine($"Max value between {a} and {b} is {Max(a, b)}");