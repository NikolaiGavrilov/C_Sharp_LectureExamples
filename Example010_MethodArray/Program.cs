int[] array = {1, 21, 23, 4, 54, 65, 43, 76, 88, 43};
int n = array.Length;
int find = 43;
int index = 0;
while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
   index++;    
}