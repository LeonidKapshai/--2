Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number > -1000 && number < 1000)
{
    number = (number % 100) / 10;
    Console.WriteLine (number);
}
else 
{
    Console.WriteLine ("Число не трехзначное");
}