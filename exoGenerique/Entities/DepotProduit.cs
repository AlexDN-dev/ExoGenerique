using exoGenerique.Interfaces;

namespace exoGenerique.Entities;

public class DepotProduit<T> : Depot<T> where T : IProduit
{
    public double PrixTotal()
    {
        double total = 0;

        for (int i = 0; i < CountList(); i++)
        {
            T produit = GetItem(i);
            total += produit.Prix;
        }

        return total;
    }
}