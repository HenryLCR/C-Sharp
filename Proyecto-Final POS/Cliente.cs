public class Cliente: Persona
{
    public double Saldo { get; set; }
    public Cliente(int codigo, string nombre, string telefono, string rtn)
    {
        Codigo = codigo;
        Nombre = nombre;
        Telefono = telefono;
        Rtn= rtn;
    }
}