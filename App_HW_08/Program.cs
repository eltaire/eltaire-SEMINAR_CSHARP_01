Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
int i = 1;
if(i == 1)
{
    i += 1;
}
while(i <= a) 
{
    Console.Write(i + " ");
    i += 2;
}