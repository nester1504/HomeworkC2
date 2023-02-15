Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int minusNumber = 0;

if (number < 0)
{
    minusNumber = number;
    number = number * -1;
}

int ThirdDigit(int n)
{
    int result = -1;
    if (n >= 100)
    {
        while (n > 999)
        {
            n = n / 10;
        }
        result = n % 10;
    }
    return result;
}
int res = ThirdDigit(number);

if (res == -1)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    if (minusNumber < 0)
    {
        Console.WriteLine($"Третья цифра числа {minusNumber} - {res}");
    }
    else
    {
        Console.WriteLine($"Третья цифра числа {number} - {res}");

    }
}




