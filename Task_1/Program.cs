Console.WriteLine("Введите трёхзначное число");
bool check = false;
int number = 0;
while (check == false)
{
    number = Convert.ToInt32(Console.ReadLine());
    if (number >= 100 && number <= 999 || number >= -999 && number <= -100)
    {
        check = true;
    }
    else
    {
        Console.WriteLine("Попробуйте ещё раз");
    }
}

int result = (number % 100) / 10;
if (result < 0)
{
    result = result * -1;
}

Console.WriteLine($"Вторая цифра числа {number} - {result}");


