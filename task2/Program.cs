Console.WriteLine("Введите числов а: ");

int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите числов b: ");

int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите числов c: ");

int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if ( b > max) max = b;
if ( c > max) max = c;

Console.WriteLine(max);