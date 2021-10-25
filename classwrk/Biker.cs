using System;
using System.Collections.Generic;
using System.Text;

namespace classwrk
{
    public class Biker : Visitor
    {
        public string MotorbikeName { get; set; }
        public override void WhatHesDoing()
        {
            base.WhatHesDoing();
            Console.WriteLine($"{Name} asks \"Have you ever ridden a {MotorbikeName}?\"");
        }
    }
}
