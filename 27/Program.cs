// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.Clear();
int Summa(string str)
{
    int lenghtArray = str.Length;
    int sum = 0;
    for (int i = 0; i < lenghtArray; i++)
    {
        //Console.WriteLine($"{(int)Char.GetNumericValue(newString[i])} {sum}");
        sum = sum + (int)Char.GetNumericValue(str[i]);
    }
    return sum;
}
Console.WriteLine();
void ShowSumDigitsOfNumber(int number)
    {
        int result = 0;
        int tempNumber = number;
        while (tempNumber != 0)
        {
            result += tempNumber % 10; //result = result + tempNumber % 10
            tempNumber /= 10;          //tempNumber = tempNumber / 10
        }
        Console.WriteLine($"{number} -> {result}");
    }

Console.WriteLine("Введите любое целое число");
string newString = Console.ReadLine()!;
int number = Convert.ToInt32(newString);
// int chislo = Convert.ToInt32(newString);
Console.WriteLine($"Сумма всех чисел из заданного числа будет равна: {Summa(newString)}");
ShowSumDigitsOfNumber(number);