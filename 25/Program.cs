//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
double Stepen (int firstNum, int secondNum)
{
    double result = Math.Pow(firstNum, secondNum);
    return result;
}
Console.WriteLine ("Введите первое число");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите второе число");
int secondNum = Convert.ToInt32(Console.ReadLine());
double stepenChisla = Stepen(firstNum, secondNum);
Console.WriteLine ($"{firstNum} в степени {secondNum} будет равно {stepenChisla}");