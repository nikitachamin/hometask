Console.WriteLine("Введите число N: ");

int N = Convert.ToInt32(Console.ReadLine());

int i = 0;

for (i = 1; i <= N; i++)
{
    if (i % 2 == 0)
 {
  Console.Write(i + " ");
 }
}