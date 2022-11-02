// Написать программу копирования массива
int[] array = new int[7];
int arrayCop;

Console.Write("Original ");
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 30);
    Console.Write(array[i]);
}
Console.WriteLine();
Console.Write("CopyPast ");
for (int i = 0; i < array.Length; i++)
{
    arrayCop = array[i];
    Console.Write(array[i]);
}
