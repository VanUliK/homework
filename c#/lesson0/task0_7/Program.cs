// Задача 6*: Напишите программу
// , которая выводит первые заданные элемента 
// следующей последовательности: 
// -> 12
// 1 2 2 3 3 3 4 4 4 4 5 5


int Prompt(string message)
{
    System.Console.Write($"{message} >");
    return Convert.ToInt32(Console.ReadLine());
}

void Counter(int number)
{
    int index = 1;
    int index_lev1 = 1;
    while (true)
    {
        int index_counter = 1;
        int counter_lev1 = index_lev1;
        while (index_counter <= counter_lev1)
        {
            if (index <= number)
            {
                Console.Write($"{counter_lev1}, ");
                index_counter++;
                index++;
            }
            else return;
        }
        index_lev1++;
    }
}

int number = Prompt("Input number ");
Counter(number);
