using przeciazenie;

Produkt produkt1 = new Produkt("Coca Cola", 6, 10);
Produkt produkt2 = new Produkt("Pepsi", 5, 20);
produkt1.WyświetlInformacje();
produkt2.WyświetlInformacje();

if (produkt1 == produkt2)
{
    Console.WriteLine($"produkty mają taką samą cenę.");
}
else if (produkt1 < produkt2)
{
    Console.WriteLine($"produkt1 tańszy niz produkt2.");
}
else
{
    Console.WriteLine($"produkt1 droższy produkt2.");
}

if (produkt1 != produkt2)
{
    Console.WriteLine($"produkty sa rozne");
}

produkt1++;
produkt2--;
Console.WriteLine($"Ilość produktu1 po inkrementacji: {produkt1.Ilość}");
Console.WriteLine($"Ilość produktu2 po dekrementacji: {produkt2.Ilość}");




Magazyn magazyn = new Magazyn("Magazyn1");
magazyn.Produkty.Add(produkt1);
magazyn.Produkty.Add(produkt2);

// Wyświetlenie produktów przed sortowaniem
Console.WriteLine("Produkty przed sortowaniem:");
magazyn.WyświetlProdukty();

// Sortowanie produktów według ceny
magazyn.SortujProdukty();

// Wyświetlenie produktów po sortowaniu
Console.WriteLine("Produkty po sortowaniu:");
magazyn.WyświetlProdukty();