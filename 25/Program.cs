//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
double Stepen (int first_num, int second_num)
{
    double result = Math.Pow(first_num, second_num);
    return result;
}
Console.WriteLine ("Введите первое число");
int first_num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите второе число");
int second_num = Convert.ToInt32(Console.ReadLine());
double stepen_chisla = Stepen(first_num, second_num);
Console.WriteLine ($"{first_num} в степени {second_num} будет равно {stepen_chisla}");