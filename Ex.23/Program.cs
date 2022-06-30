/*
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

int GetNumber(string message)
{
    int result = 0;
    string errorMessage = "Вы не ввели натуральное число";

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result))
            break;
        else
        {
            Console.Clear();
            Console.WriteLine(errorMessage);
        }
    }
    return result;
}

void Trd (int number)
{
    for (int i = 1; i<=number; i++)
    {
        Console.WriteLine ($"куб числа {i} равен {Math.Pow(i,3)}");
    }
}
int number = GetNumber("Введите натуральное число");
Trd(number);