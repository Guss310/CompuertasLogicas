using System;
using System.Collections.Generic;

namespace Library;

/// <summary>
/// Creamos la clase Gate para realizar la implementación de la interfaz IInput
/// </summary>
public abstract class Gate : IInput 
{
    /// <summary>
    /// Establecemos las properties
    /// </summary>
    public string Name { get; set; }
    public List<IInput> Inputs { get; set; }
    
    /// <summary>
    /// Se genera el
    /// </summary>
    public Gate(string name)
    {
        this.Name = name;
        this.Inputs = new List<IInput>();
    }
    
    /// <summary>
    /// Este método agrega el input
    /// </summary>
    public void AddInput(IInput IInput)
    {
        this.Inputs.Add(IInput);
    }
    /// <summary>
    /// Método para hacer el calculo
    /// </summary>
    public abstract bool Calculate();

}