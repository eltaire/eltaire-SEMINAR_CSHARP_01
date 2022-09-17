Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
int M = N*(-1);
while(M <= N) 
{
    Console.Write(" " + M+ " ");
    M ++;
}