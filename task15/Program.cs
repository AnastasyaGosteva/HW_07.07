Console.WriteLine("Введите цифру соответсвующую дню недели: ");
string hollyDay = Console.ReadLine();
if ((hollyDay.Equals("6")||hollyDay.Equals("7")))
{
    Console.WriteLine("Данный день является выходным днем");
}
else 
{
    Console.WriteLine("Данный день не является выходным днем");
}