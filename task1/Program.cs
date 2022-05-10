Console.WriteLine("Введите числов а: ");

int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите числов b: ");

int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
  {
     int max = a;
     int min = b;
    Console.WriteLine(max);
    Console.WriteLine(min);
  }

else 
  {
    int max = b;
    int min = a;
   Console.WriteLine(max); Console.WriteLine(min);
  }



