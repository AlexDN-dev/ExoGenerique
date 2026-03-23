using exoGenerique.Entities;
using exoGenerique.Utils;

DepotProduit<Livre> depotLivre = new DepotProduit<Livre>();
DepotProduit<Appareil> depotAppareil = new DepotProduit<Appareil>();

Livre l1 = new Livre("Livre 1", 10);
Livre l2 = new Livre("Livre 2", 4.5);

depotLivre.addItem(l1);
depotLivre.addItem(l2);
depotLivre.addItem(new Livre("Livre 3", 5.5));

depotAppareil.addItem(new Appareil("Appareil 1", 105));
depotAppareil.addItem(new Appareil("Appareil 2", 45));
depotAppareil.addItem(new Appareil("Appareil 3", 85));

depotLivre.ShowStock();
depotAppareil.ShowStock();

Console.WriteLine(l1 + " " + l2);
OutilsDepot.SwapValue(ref l1, ref l2);
Console.WriteLine(l1 + " " + l2);

Console.WriteLine(OutilsDepot.FindValue<Livre>(depotLivre.GetStock(), l1));