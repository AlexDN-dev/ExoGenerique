namespace exoGenerique.Interfaces;

public interface IDepot<T>
{
    void addItem(T p);
    void RemoveItem(int index);
    T GetItem(int index);
    int CountList();
}