Console.Write("Введите трехзначное число: number = ");
int number = int.Parse(Console.ReadLine());
int secondDigit = ((number % 100)/10);
Console.Write($"Вторая цифра числа {number} равна "+secondDigit);