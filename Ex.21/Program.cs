/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

int GetNumber(string message)
{
    int result = 0;
    string errorMessage = "Вы ввели не корректную координату. Введите координату в виде натурального числа";

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

int x1 = GetNumber("Введите координаты X точки A");
int y1 = GetNumber("Введите координаты Y точки A");
int z1 = GetNumber("Введите координаты Z точки A");
int x2 = GetNumber("Введите координаты X точки B");
int y2 = GetNumber("Введите координаты Y точки B");
int z2 = GetNumber("Введите координаты Z точки B");

double legth = Math.Sqrt(Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2) + Math.Pow(z2-z1,2));


Console.WriteLine($"Расстояние между точкой A({x1},{y1},{z1}) и точной B({x2},{y2},{z2}) равно {legth}");