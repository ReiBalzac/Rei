using System;
using System.Collections.Generic;
using System.Text;

namespace classwrk
{
    public class Stalker : Visitor
    {
        public string GroupName { get; set; }
        public override void WhatHesDoing()
        {
            Console.WriteLine($"{ Name } screams \"Let's drink for {GroupName}!\"");
        }
    }
}
