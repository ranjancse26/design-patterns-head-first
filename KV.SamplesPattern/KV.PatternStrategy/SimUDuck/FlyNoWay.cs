﻿using System;

namespace KV.PatternStrategy.SimUDuck
{
    public class FlyNoWay : FlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Faz nada!");
        }
    }
}