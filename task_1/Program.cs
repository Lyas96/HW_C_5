/* Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2 */
int[] GetRandomArray(int size, int minValue, int maxValue)
{
  int[] result = new int[size];
  for(int i = 0; i <size; i++)
  {
    result[i] = new Random().Next(minValue, maxValue +1);
  }
  return result;
}

int AmountEvenNumbers(int [] array)
{
  int count = 0;
  foreach(int elem in array)
  {
    count += elem % 2 == 0 ? 1 :0; 
  }
  return count;
}

Console.Clear();
int[] numbers = GetRandomArray(10, 100, 999);
Console.WriteLine(String.Join("_", numbers));
Console.WriteLine($"Количество четных чисел равно: {AmountEvenNumbers(numbers)}");