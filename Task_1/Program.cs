Console.WriteLine("Введите трёхзначное число");
bool check = false;
int number = 0;

while (check == false)
{
    string text = Console.ReadLine();
    if (int.TryParse(text, out int n))
    {
        number = Convert.ToInt32(text);
        while (check == false)
        {
            
            if (number >= 100 && number <= 999 || number >= -999 && number <= -100)
            {
                check = true;
            }
            else
            {
                Console.WriteLine("Попробуйте ещё раз");
                break;
            }
        }
    }
    else
    {
        Console.WriteLine("Не удалось распознать число, поробуйте ещё раз");
    }
}


int result = (number % 100) / 10;
if (result < 0)
{
    result = result * -1;
}

Console.WriteLine($"Вторая цифра числа {number} - {result}");


