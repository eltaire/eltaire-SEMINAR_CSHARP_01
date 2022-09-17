Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
if(a > b) Console.WriteLine("Первое число " + a + " максимальное из представленных двух, а второе число " + b + " минимальное");
else if(a == b) Console.WriteLine("Введенные числа равны");
else if(a < b)Console.WriteLine("Первое число " + b + " максимальное из представленных двух, а второе число " + a + " минимальное");