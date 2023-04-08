/* Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0 */
int[] GetRandomArray(int size, int minValue, int maxValue)
{
  int[] result = new int[size];
  for (int i = 0; i < size; i++)
  {
    result[i] = new Random().Next(minValue, maxValue + 1);
  }
  return result;
}

int SearchSumElem(int[] array)
{
  int sum = 0;
  for (int i = 0; i < array.Length; i += 2) // i++;
  {
    /* if (i % 2 == 0) */
    sum += array[i];
  }
  return sum;
}

Console.Clear();
int[] numbers = GetRandomArray(8, -10, 10);

Console.WriteLine(String.Join(",", numbers));
Console.WriteLine($"Сумма элементов на нечетных позициях равна: {SearchSumElem(numbers)}");
