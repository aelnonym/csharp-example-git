// See https://aka.ms/new-console-template for more information
// Dia 28 de agosto DE 2022
// Atividade 1

int Max(int a, int b)
{
  return (a > b) ? a : b;
}

// Criando variaveis
int a = 3;
int b = 2;

Max(a, b);   // 3
Max(b, a);   // 3

Console.WriteLine($"Max value between {a} and {b} is {Max(a, b)}");