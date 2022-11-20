Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99) //number < -99)
{
    string stringnumber = number.ToString();
    Console.WriteLine(stringnumber[2]);
}

if (number < -99) 
{
    string stringnumber = number.ToString();
    Console.WriteLine(stringnumber[3]);
}
if (number < 99 && number > -99)
{
    Console.WriteLine("Нет третьей цифры");
}