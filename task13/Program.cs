Console.Write("Введите любое число, number: ");
string number = Console.ReadLine();
if (number.Length <3)
{
    Console.Write($"В числе {number} третей цифры нет.");
}
else
{
Console.Write($"Третья цифра числа {number} равна "+number[2]+".");   
}


// Console.Write("Введите любое число, number: ");
// int number = int.Parse(Console.ReadLine());
// string number1 = number.ToString();
// int [] array = new int [number1.Length];
// if (array.Length <3)
// {
//     Console.Write($"В числе {number} третей цифры нет.");
// }
// else
// {
// for (int i = 0; i < array.Length; i++)
// {

//     array[i] = int.Parse(number1[i].ToString());
// }
// Console.Write($"Третья цифра числа {number} равна "+array[2]+".");   
// }
