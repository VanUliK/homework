// Задача 3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.WriteLine("Введите номер дня недели: ");
int i = Convert.ToInt32(Console.ReadLine());

// первый вариант через метод
int DayWeek(int i)
{
  if (i > 7 || i < 1) Console.WriteLine("Такого дня не существует");
  if (i == 1) Console.WriteLine("Понедельник");
  if (i == 2) Console.WriteLine("Вторник");
  if (i == 3) Console.WriteLine("Среда");
  if (i == 4) Console.WriteLine("Четверг");
  if (i == 5) Console.WriteLine("Пятница");
  if (i == 6) Console.WriteLine("Суббота");
  if (i == 7) Console.WriteLine("Воскресенье");
  return i;
}

DayWeek(i);

// вариант через switch/case

switch (i)
{
  case 1:
    Console.WriteLine("Понедельник");
    break;
  case 2:
    Console.WriteLine("Вторник");
    break;
  case 3:
    Console.WriteLine("Среда");
    break;
  case 4:
    Console.WriteLine("Четверг");
    break;
  case 5:
    Console.WriteLine("Пятница");
    break;
  case 6:
    Console.WriteLine("Суббота");
    break;
  case 7:
    Console.WriteLine("Воскресенье");
    break;
  default:
    Console.WriteLine("Такого дня не существует");
    break;
}
