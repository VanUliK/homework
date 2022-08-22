// очистка консоли
Console.Clear();

// вывод массива одной строкой
Console.WriteLine(string.Join(", ", arr));

// ввод целочисленного значения с клавиатуры
int number = Convert.ToInt32(Console.ReadLine())!;

// 
Console.ReadLine().Split().Select(Convert.ToInt32).ToArray();

// int number = int.Parse(Console.ReadLine());
string inputString = Console.ReadLine()!;
int number = int.Parse(inputString);

//GitHub
git remote add origin https://github.com/VanUliK/homework.git
git branch -M main
git push -u origin main

//округлить массив до 2ух символов после запятой
Console.Write($"{string.Join(", ", array.Select(x => Math.Round(x, 2)))}");



