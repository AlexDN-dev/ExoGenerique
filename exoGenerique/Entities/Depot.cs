using exoGenerique.Interfaces;

namespace exoGenerique.Entities;

public class Depot<T> : IDepot<T>
{
    private List<T> stock = new List<T>();
    
    public void addItem(T p)
    {
        stock.Add(p);
    }

    public void RemoveItem(int index)
    {
        stock.RemoveAt(index);
    }

    public T GetItem(int index)
    {
        return stock[index];
    }

    public int CountList()
    {
        return stock.Count;
    }

    public void ShowStock()
    {
        foreach (var s in stock)
        {
            Console.WriteLine(s.ToString());
        }
    }
}