Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int CountDigitByString(int n)
{
    return n.ToString().Length;
}

int size = CountDigitByString(number);
Console.WriteLine(size);

// // int ThirdDigit(int number, int lenght)
//         {
//             int result = -1;
//             if (number >= 100)
//             {
//                 while (number > 999)
//                 {
//                     number = number / 10;
//                 }
//                 result = number % 10;
//             }
//             return result; 
//         }

