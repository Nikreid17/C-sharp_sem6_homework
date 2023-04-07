// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

System.Console.Write("Введите несколько чисел через пробел: ");
int[] array = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
System.Console.WriteLine(array.Length);
