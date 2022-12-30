//--------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace Library
{
    
    public class Program
    {
        public static void Main(string[] args)
        {
        Gate_and and1 = new Gate_and("and1");
        Gate_or or2 = new Gate_or("or2");
        Gate_not not3 = new Gate_not("not3");

        IInput logicInput1 = new LogicInput(false);
        IInput logicInput2 = new LogicInput(true);
        IInput logicInput3 = new LogicInput(false);

        and1.AddInput(logicInput1);
        and1.AddInput(logicInput2);
        or2.AddInput(logicInput1);
        or2.AddInput(and1);
        not3.AddInput(or2);

        Console.WriteLine($"El resultado es {or2.Calculate()}");
        }
    }
}