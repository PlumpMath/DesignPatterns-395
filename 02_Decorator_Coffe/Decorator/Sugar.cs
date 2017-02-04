﻿using System;

namespace _02_Decorator_Coffe
{
    public class Sugar : CoffeDecorator
    {
        public Sugar(Coffe coffe) 
            : base(coffe)
        {

        }
        public override void Make()
        {
            base.Make();
            Console.WriteLine("Add some sugar");
        }
    }
}
