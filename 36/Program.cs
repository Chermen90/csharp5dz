int [] array = GetRandomArray(5, -100, 100);

Console.WriteLine($"[{String.Join(",", array)}]");



int[] GetRandomArray(int size,int minValue,int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
    result[i] = new Random().Next(minValue,maxValue);
    }

    return result;
}

int UnevenSum(int [] arr)
{
    int sum = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(i % 2 != 0)
        {
            sum += arr[i];
        }
    }
    return sum;
}

int result = UnevenSum(array);
Console.WriteLine(result);
