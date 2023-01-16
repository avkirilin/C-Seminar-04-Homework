//Напишите программу, которая задает массивиз 8 элементов и выводит их на экран
void FillArray(int[] newArray)
{
    int lenght = newArray.Length;
    int index = 0;
    Random random = new Random();
    while (index < lenght)
    {
        newArray[index] = random.Next(1, 100);
        index++;
    }
}
void ShowArray(int[] anotherArray)
{
    int count = anotherArray.Length;
    int place = 0;
    while (place < count)
    {
        Console.Write($"{anotherArray[place]} ");
        place++;
    }
}
int[] array = new int[8];
FillArray(array);
ShowArray(array);
