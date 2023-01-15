//Напишите программу, которая задает массивиз 8 элементови выводит их на экран
void CreateArray(int[] newArray)
{
    int lenght = newArray.Length;
    int index = 0;
    while (index < lenght)
    {
        newArray[index] = new Random().Next(1, 100);
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
CreateArray(array);
ShowArray(array);
