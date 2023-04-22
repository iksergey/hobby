using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace Ex004_DataTemplate.Models
{
  public class SyncModel
  {
    public static readonly SyncModel Instance;
    static SyncModel() => Instance = new();
    private SyncModel() => Numbers = new();
    public ObservableCollection<int> Numbers { get; private set; }

    public void AddItems(int count = 15)
    {
      for (int i = 0; i < count; i++)
      {
        Numbers.Add(Random.Shared.Next(100, 300));
      }
    }
    public void ShuffleItems()
    {
      int size = Numbers.Count;
      for (int i = 0; i < size; i++)
      {
        int pos = Random.Shared.Next(i, size);
        int t = Numbers[i];
        Numbers[i] = Numbers[pos];
        Numbers[pos] = t;
      }
    }
    public void SelectionSort()
    {
      int size = Numbers.Count;
      for (int i = 0; i < size - 1; i++)
      {
        int index = i;
        for (int j = i; j < size; j++)
        {
          if (Numbers[j] < Numbers[index]) index = j;
        }
        int t = Numbers[i];
        Numbers[i] = Numbers[index];
        Numbers[index] = t;
      }
    }

    private void QuickSort(ObservableCollection<int> collection, int left, int right)
    {
      int i = left;
      int j = right;

      int pivot = collection[Random.Shared.Next(left, right)];
      while (i <= j)
      {
        while (collection[i] < pivot) i++;
        while (collection[j] > pivot) j--;

        if (i <= j)
        {
          int t = collection[i];
          collection[i] = collection[j];
          collection[j] = t;
          i++;
          j--;
        }
      }
      if (i < right) QuickSort(collection, i, right);
      if (left < j) QuickSort(collection, left, j);
    }

    public void QuickSort()
    {
      QuickSort(Numbers, 0, Numbers.Count - 1);
    }
    public void Clear()
    {
      Numbers.Clear();
    }
  }
}