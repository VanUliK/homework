// Задача 18: Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат 
// точек в этой четверти (x и y).

// Первый вариант

void PrintNumberOfPlane(int numberOfPlane)
{
    if (numberOfPlane == 1)
    {
        Console.WriteLine("x > 0, y > 0");
    }
    else if (numberOfPlane == 2)
    {
        Console.WriteLine("x < 0, y > 0");
    }
    else if (numberOfPlane == 3)
    {
        Console.WriteLine("x < 0, y < 0");
    }
    else if (numberOfPlane == 4)
    {
        Console.WriteLine("x > 0, y < 0");
    }
    else
        Console.WriteLine("Введен некорректный номер четверти");
}

Console.WriteLine("Номер координатной четверти");
int numberOfPlane = int.Parse(Console.ReadLine()!);
PrintNumberOfPlane(numberOfPlane);

// Второй вариант

    // Console.WriteLine("Номер координатной четверти");
    // int x = Convert.ToInt32(Console.ReadLine());
    // if (x == 1)
    // {
    //     Console.WriteLine("x > 0, y > 0");
    // }
    // else if (x == 2)
    // {
    //     Console.WriteLine("x < 0, y > 0");
    // }
    // else if (x == 3)
    // {
    //     Console.WriteLine("x < 0, y < 0");
    // }
    // else if (x == 4)
    // {
    //     Console.WriteLine("x > 0, y < 0");
    // }
    // else
    // {
    //     Console.WriteLine("Такой координатной четверти не существует");
    // }