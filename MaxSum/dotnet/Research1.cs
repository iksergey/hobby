public static class Research1
{
  public static int MaxSum(int[] data)
  {
    int result = 0;
    int count = data.Length;
    for (int i = 0; i < count; i++)
    {
      for (int j = i; j < count; j++)
      {
        int currentSum = 0;
        for (int k = i; k <= j; k++)
        {
          currentSum += data[k];
        }
        result = Math.Max(result, currentSum);
      }
    }
    return result;
  }
}