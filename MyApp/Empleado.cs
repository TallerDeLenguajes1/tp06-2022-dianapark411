 public enum cargo{
    Auxiliar,
    Administrativo, 
    Ingeniero,
    Especialista, 
    Investigador
}

public class Empleado{

    //private string nombre;
    //public string Nombre { get => nombre; set => nombre = value; }
    public string Nombre {get;set;}

    //public string apellido;
    public string Apellido {get;set;}

    //public DateTime fechaNacimiento;
    public DateTime FechaNacimiento {get;set;}
    
    //public char EstadoCivil;
    public char EstadoCivil {get;set;}

    //public char Genero;
    public char Genero {get;set;}
    
    //public DateTime FechaIngreso;
    public DateTime FechaIngreso {get;set;}

    //public double sueldo;
    public double Sueldo {get;set;}

    public cargo cargo;
       
    //enum sirve para controlar que la variable no tome otro valor que no sea el declarado (Cantidad de opciones finita). Ademas explica para que sirve
    // en program -> cargo cargoEmpleado = cargo.Administrativo
}
