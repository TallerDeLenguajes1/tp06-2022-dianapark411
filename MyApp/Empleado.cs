
public class Empleado{

    public string nombre;
    public string apellido;
    public DateTime fechaNacimiento;
    public char EstadoCivil;
    public char Genero;
    public DateTime FechaIngreso;
    public double sueldo;

    public enum cargo{

        Auxiliar,
        Administrativo, 
        Ingeniero,
        Especialista, 
        Investigador
    }
    //enum sirve para controlar que la variable no tome otro valor que no sea el declarado (Cantidad de opciones finita). Ademas explica para que sirve
    // en program -> cargo cargoEmpleado = cargo.Administrativo
}
