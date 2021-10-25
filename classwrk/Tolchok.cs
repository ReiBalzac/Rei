using System;
using System.Collections.Generic;
using System.Text;

namespace classwrk
{
    public class Tolchok : Visitor
    {
       
        public override void WhatHesDoing()
        {
            Console.WriteLine($"{Name} asks \"Are you going to {GameName}?\"");
        }

    }
}
