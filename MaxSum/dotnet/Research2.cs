public static class Research2
{
  public static int MaxSum(int[] data)
  {
    int result = 0;
    int count = data.Length;

    for (int i = 0; i < count; i++)
    {
      int currentSum = 0;
      for (int j = i; j < count; j++)
      {
        currentSum += data[j];
        result = Math.Max(result, currentSum);
      }
    }
    return result;
  }
}