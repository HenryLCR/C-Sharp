public class Cliente
{
    public double Saldo { get; set; }
    public int Codigo { get; set; }
    public string Nombre { get; set; }
    public string Telefono { get; set; }
    public string Rtn { get; set; }

    public Cliente(int codigo, string nombre, string telefono, string rtn)
    {
        Codigo = codigo;
        Nombre = nombre;
        Telefono = telefono;
        Rtn= rtn;
    }
}