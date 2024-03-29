﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace przeciazenie
{
    public class Magazyn
    {
        public string Nazwa { get; set; }
        public List<Produkt> Produkty { get; set; }

        public Magazyn(string nazwa)
        {
            Nazwa = nazwa;
            Produkty = new List<Produkt>();
        }

        public void WyświetlProdukty()
        {
            foreach (var produkt in Produkty)
            {
                produkt.WyświetlInformacje();
            }
        }

        public void SortujProdukty()
        {
            Produkty.Sort((a, b) => a.Cena.CompareTo(b.Cena));
        }
    }
}
