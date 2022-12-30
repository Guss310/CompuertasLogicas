using System;
using System.Collections.Generic;

namespace Library;

/// <summary>
/// Clase Gate_not que hereda de la clase Gate
/// </summary>

public class Gate_not : Gate
{
    public Gate_not(string name) : base(name)
    {
        
    }
    /// <summary>
    /// implementamos el metodo "Calculate", en base a lo que necesita la clase Gate_not
    /// </summary>
    public override bool Calculate()
    {
        ///<summary>
        /// Se genera una exepción cuando no hay un imput en la compuerta
        ///<summary>
        if (Inputs.Count != 1)
        {
            throw new IndexOutOfRangeException("ES NECESARIO UN INPUT");
        }
        return !this.Inputs[0].Calculate(); // Negamos el primer elemento (el input) 
    }
}