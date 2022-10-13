// Напишите программу, которая принимает на вход число N и выдает таблицу кубов чисел от 1 до n
void Roma(int x)
{
    for (int i = 1; i <= x; i++)
    {
        Console.Write($"{Math.Pow(i, 3)}");
        if (i != x)
        {
            Console.Write(", ");
        }
    }
}
Console.Clear();
Console.Write("Введите число: ");  
int x = int.Parse(Console.ReadLine()!);
Roma(x);
