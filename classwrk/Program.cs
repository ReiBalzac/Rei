using System;
using System.Collections.Generic;

namespace classwrk
{
    class Program
    {
        static void Main(string[] args)
        {
            var bar = new Bar() { Name = "Hyena" };
            bar.Visitors = new List<Visitor>();
            bar.Visitors.Add(new Stalker() { Name = "Hvosch"});
            bar.Visitors.Add(new Biker() { Name = "Ruslik" });
            bar.Visitors.Add(new Tolchok() { Name = "Dexter" });
         

            foreach (var visitor in bar.Visitors)
            {
                visitor.WhatHesDoing();
            }
            var bar1 = new Bar();
            var buhlo = new Drink();
            buhlo.Drinks = List<Drink>();
            buhlo.Drinks.Add(new Vodka() { Volume = 0.1 });

            foreach (var Drink in bar.Drinks);

        }
    }
}
