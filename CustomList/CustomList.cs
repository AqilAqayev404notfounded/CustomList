using System.Collections;
using System.Text.RegularExpressions;
namespace CustomList;

public class CustomList<T> : IEnumerable<T>
{
    public T[] ListCustom;
    public T this[int index]
    {
        get { return ListCustom[index]; }
        set { ListCustom[index] = value; }
    }
    public CustomList()
    {
        ListCustom = new T[0];
    }
    public void Add(T item)
    {
        Array.Resize(ref ListCustom, ListCustom.Length + 1);
        ListCustom[ListCustom.Length - 1] = item;
    }
    public T Find(Predicate<T> predicate)
    {
        if (predicate == null)
        {
            throw new ArgumentNullException();
            Console.WriteLine();
        }
        for (int i = 0; i < ListCustom.Length; i++)
        {
            if (predicate(ListCustom[i]))
            {
                return ListCustom[i];
            }
        }

        return default(T);

    }
    public void Remove(T item)
    {
        for (int i = 0;i< ListCustom.Length; i++)
        {
            if (ListCustom[i].Equals(item))
            {
                for (int j = i; j < ListCustom.Length - 1; j++)
                {
                    ListCustom[j] = ListCustom[j + 1];
                }
                Array.Resize(ref ListCustom, ListCustom.Length - 1);
                
            }

        }
    }
    public void RemoveAll()
    {
        Array.Resize(ref ListCustom, 0);
    }
    public T[] FindAll(T item)
    {
        return Array.FindAll(ListCustom, a=> a.Equals(item));
    }

    public IEnumerator<T> GetEnumerator()
    {

        foreach (T item in ListCustom)
        {
            yield return item;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        foreach (T item in ListCustom)
        {
            yield return item;
        }
    }
}
