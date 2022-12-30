using System;
using System.Collections.Generic;

namespace Library;

/// <summary>
/// Clase Gate_and quehereda de la clase Gate
/// </summary>

public class Gate_and : Gate
{
    public Gate_and(string name) : base(name)
    {
        
    }

    /// <summary>
    /// implementamos el metodo "Calculate", en base a lo que necesita la clase Gate_and
    /// </summary>
    public override bool Calculate()
    {
        ///<summary>
        /// Se genera una exepción cuando no hay dos imputs en la compuerta
        ///<summary>
        
        if (Inputs.Count != 2)
        {
            throw new IndexOutOfRangeException("SON NECESARIOS DOS INPUTS");
        }
        bool resultado = true;

        foreach (IInput elemento in this.Inputs)
        {
            resultado = resultado && elemento.Calculate();
        }

        return resultado;
        
    }

}