/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/ 

double GetNumber(string message)
{
    double result = 0;

    while(true)
    {
        Console.Write(message);
        
        if(double.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число. Повторите ввод.");
        }
    }

    return result;
}

void IntersectionLine(double k1, double k2, double b1, double b2)
{
    double x = (b2-b1)/(k1-k2);
    double y = k1*(b2-b1)/(k1-k2)+b1;

    if(k1==k2 || b1==b2)
    {
        System.Console.WriteLine("Эти прямые не пересекаются.");
    }
    else
    {
       System.Console.WriteLine($"Эти прямые пересекутся в точке с координатами X: {x}, Y: {y}");
    }
    
}

double k1 = GetNumber("Две прямые заданы уравнениями y = k1 * x + b1, y = k2 * x + b2. Введите k1: ");
double k2 = GetNumber("Две прямые заданы уравнениями y = k1 * x + b1, y = k2 * x + b2. Введите k2: ");
double b1 = GetNumber("Две прямые заданы уравнениями y = k1 * x + b1, y = k2 * x + b2. Введите b1: ");
double b2 = GetNumber("Две прямые заданы уравнениями y = k1 * x + b1, y = k2 * x + b2. Введите b2: ");
IntersectionLine(k1, k2, b1, b2);
