Console.WriteLine("Введите число от 1 до 7 - это будет день недели");

bool check = false;
int day = 0;
while (check == false)
{
    day = Convert.ToInt32(Console.ReadLine());
    if (day > 0 && day < 8)
    {
        check = true;
    }
    else
    {
        Console.WriteLine($"{day} не является днем недели, попробуйте еще раз");
    }
}

if (day == 6 || day == 7)
{
    Console.WriteLine($"{day} является выходным днем");
}
else
{
    Console.WriteLine($"{day} НЕ является выходным днем");
}