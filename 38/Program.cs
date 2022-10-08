//можем задать массив 2мя способами
double [] array = GetRandomArray(5, 0, 10);

Console.WriteLine($"[{String.Join(",", array)}]");

//1. случайный массив
double[] GetRandomArray(int size,int minValue,int maxValue)
{
    double [] result = new double[size];
    for (int i = 0; i < size; i++)
    {
    result[i] = new Random().Next(minValue,maxValue);
    }

    return result;
}

// 2. прописываем массив
 //double [] test = {11, 5, 6, 0, 8, 4, 3, -2};
//Console.WriteLine($"[{String.Join(",", test)}]");



//прописываем функцию по поиску мин значения в массиве, ищем с помощью вложенного цикла
double GetMinEL(double [] arr)
{
    double min = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        min = i;
        for(int j = 0; j < arr.Length; j++)
        {
            if(arr[j] < min)
            {
                min = arr[j];
            }

        }
    }
    return min;
}

// таким же образом ищем макс элемент
double GetMaxEl(double [] arr)
{
    double max = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        max = i;
        for(int j = 0; j < arr.Length; j++)
        {
            if(arr[j] > max)
            {
                max = arr[j];
            }

        }
    }
    return max;
}

// функция принимает рез-ты из ф-ций по поиску мин и мах и вычисляет разницу
double GetDifference(double min, double max)
{
    double result = max - min;
    return result;
}

//мин эл-т выводим для наглядности
double minResult = GetMinEL(array);
Console.WriteLine(minResult);

//макс эл-т выводим для наглядности
double maxResult = GetMaxEl(array);
Console.WriteLine(maxResult);


//выводим фин рез-т
double result = GetDifference(minResult, maxResult);
Console.WriteLine(result);
