using System;
using System.Collections.Generic;

namespace Library;

/// <summary>
/// Clase Gate_or que hereda de la clase Gate
/// </summary>
public class Gate_or : Gate
{
    public Gate_or(string name) : base(name)
    {
        
    }
    /// <summary>
    /// implementamos el metodo "Calculate", en base a lo que necesita la clase Gate_or 
    /// </summary>
    public override bool Calculate()
    {
        if (Inputs.Count != 2)
        {
            throw new IndexOutOfRangeException("ERROR. SE NECESITAN DOS INPUTS");
        }
        bool resultado = true;
        foreach (IInput elemento in this.Inputs)
        {
            resultado = resultado || elemento.Calculate();
        }
        return resultado;
    }
}