using System;

namespace classwrk
{
    public class Visitor
    {
        public string Name { get; set; }

        public virtual void WhatHesDoing() 
        {
            Console.WriteLine($"{ Name } is sitting and drinking");
        }
    }
}