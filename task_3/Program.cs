/* Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76 */

double[] GetRandomArray(int size, int minValue, int maxValue)
{
  double[] result = new double[size];
  for (int i = 0; i < size; i++)
  {
    result[i] = new Random().Next(minValue, maxValue + 1);
  }
  return result;
}

double SearchMaxElem(double[] array)
{
  double MaxElement = array[0];
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] > MaxElement) MaxElement = array[i];
  }
  return MaxElement;
}

double SearchMinElem(double[] array)
{
  double MinElement = array[0];
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] < MinElement) MinElement = array[i];
  }
  return MinElement;
}

Console.Clear();
double[] numbers = GetRandomArray(8, -250, 0);
double result = (SearchMaxElem(numbers) - SearchMinElem(numbers));
Console.WriteLine(String.Join(",", numbers));
Console.WriteLine($"Разность между максимальным и минимальным элементами массива равна: {(result)}");
