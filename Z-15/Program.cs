Console.WriteLine("Введите цифру обозначающую день недели");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0 || number > 7)
{
    Console.WriteLine("Нет такого дня недели");
}
if (number == 6)
{
    Console.WriteLine("Выходной");
}
if (number == 7)
{
    Console.WriteLine("Выходной");
}
if (number > 0 && number < 6)
{
   Console.WriteLine("Будний");
}