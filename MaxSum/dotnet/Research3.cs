public static class Research3
{
  public static int MaxSum(int[] data)
  {
    int count = data.Length;
    int result = 0, currentSum = 0;

    for (int i = 0; i < count; i++)
    {
      currentSum = Math.Max(data[i], currentSum + data[i]);
      result = Math.Max(result, currentSum);
    }
    return result;
  }
}