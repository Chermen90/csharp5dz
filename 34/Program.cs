int [] array = GetRandomArray(10, 1, 1000);

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

int GetEvenNumbers(int [] arr)
{
    int count = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i]% 2 == 0)
        {
            count++;
        }
    }
    return count;
}
int result = GetEvenNumbers (array);
Console.WriteLine(result);