﻿Console.WriteLine("Введите трехзначное число");
int a = Convert.ToInt32(Console.ReadLine());
int b = a%10;
Console.WriteLine("Последняя цифра в Вашем числе - " + b);