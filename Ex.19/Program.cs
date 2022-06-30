/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/


    int GetNumber(string message)
{
    int result = 0;
    string errorMessage = "Вы ввели не пятизначное число. Введите корректное число.";

   while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result))
         {
            if(result < 9999 || result > 100000)
            {
                Console.Clear();
                Console.WriteLine(errorMessage);
            }
            else
                break;
        }
        else
        {
            Console.Clear();
            Console.WriteLine(errorMessage);
        }
    }

    return result;
}
   

int number = GetNumber("Введите число:");
int [] numberStr = new int[5];
int i=0;
while(number>0)
{
numberStr[i]=number%10;
number=number/10;
i++;
}


if (numberStr[0]==numberStr[4] && numberStr[1]==numberStr[3])
    {
    Console.WriteLine("Число является полиндромом");
    }
else
    {
    Console.WriteLine("Число не является полиндромом");
    }