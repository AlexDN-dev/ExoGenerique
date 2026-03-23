using exoGenerique.Interfaces;

namespace exoGenerique.Entities;

public class DepotProduit<T> : Depot<T> where T : IProduit
{
    public double PrixTotal()
    {
        double total = 0;
        foreach (T produit in stock)
        {
            total += produit.Prix;
        }

        return total;
    }
}