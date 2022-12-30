namespace Library;

/// <summary>
/// Clase creada para los inputs de valores lógicos
/// </summary>
public class LogicInput : IInput
{
    public bool Value {get; set;} 
    public LogicInput(bool value)
    {
        this.Value = value;

    }
    public bool Calculate()
    {
        return this.Value;
    }    

}