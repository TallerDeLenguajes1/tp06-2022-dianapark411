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

    //METODOS

    DateTime fechaActual = DateTime.Today;
    public int edad = 0, antiguedad  = 0, falta = 0;

    public int calcularEdad(DateTime fechaNac){
        edad = fechaActual.Year - fechaNac.Year;
        if(fechaNac.Month > fechaActual.Month){
            edad = edad-1;
        }
        return edad;
    }
    
    public int calcularAntiguedad(DateTime fechaIn){
        int antiguedad = fechaActual.Year - fechaIn.Year;
        if(fechaIn.Month > fechaActual.Month){
            antiguedad = antiguedad-1;
        }
        return antiguedad;
    }

    public int calcularAñosAJubilarse(char genero){
        if(Char.ToLower(genero)=='f'){      //convierto a minuscula para que no haya errores si el usuario ingreso con mayusculas
            falta = 60 - edad;  //las mujeres se jubilan a los 60 años
        }else{
            falta = 65 - edad;  //los varones se jubilan a los 65 años
        }
        return falta;
    }
    

    public void calcularSalario(float sueldo, string cargo, char estadoCivil){
        float salario  = 0 , adicional = 0;

        salario = sueldo + adicional;
    }
}
