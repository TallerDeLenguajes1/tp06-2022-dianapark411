﻿// See https://aka.ms/new-console-template for more information
using System.Globalization;

Console.WriteLine("\nIngrese la cantidad de empleados: ");
int cantEmpleados = Convert.ToInt32(Console.ReadLine());
Empleado[] emp = new Empleado[cantEmpleados];

CultureInfo provider = CultureInfo.InvariantCulture;
string format = "MM/dd/yyyy";

for (int i = 0; i < cantEmpleados; i++){
    emp[i] = new Empleado();
    Console.WriteLine($"\nIngrese los datos del empleado {i+1}");
    Console.WriteLine("Ingrese el nombre: ");
    emp[i].Nombre = Console.ReadLine();
    Console.WriteLine("Ingrese el apellido: ");
    emp[i].Apellido = Console.ReadLine();
    Console.WriteLine("Ingrese la fecha de nacimiento (formato mm/dd/aaaa): ");
    emp[i].FechaNacimiento = DateTime.ParseExact(Console.ReadLine(), format, provider);
    Console.WriteLine("Ingrese el estado civil  (C: casado, S:soltero): ");
    emp[i].EstadoCivil = Convert.ToChar(Console.ReadLine());
    Console.WriteLine("Ingrese el genero (F: femenino, M: masculino): ");
    emp[i].Genero = Convert.ToChar(Console.ReadLine());
    Console.WriteLine("Ingrese la fecha de ingreso en la empresa (formato mm/dd/aaaa): ");
    emp[i].FechaIngreso = DateTime.ParseExact(Console.ReadLine(), format, provider);
    Console.WriteLine("Ingrese el sueldo: ");
    emp[i].Sueldo = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("El cargo se genero aleatoriamente ");

    Random rnd = new Random();
    int caso = rnd.Next(1,5);

    switch (caso){
        case 1:
            emp[i].cargo = cargo.Auxiliar;
            break;
        case 2:
            emp[i].cargo = cargo.Administrativo;
            break;
        case 3:
            emp[i].cargo = cargo.Ingeniero;
            break;
        case 4:
            emp[i].cargo = cargo.Especialista;
            break;
        case 5:
            emp[i].cargo = cargo.Investigador;
            break;
        default:
            break;
    }
}

for (int i = 0; i < cantEmpleados; i++){

    Console.WriteLine($"\n-----Datos del empleado {i+1}-----");
    Console.WriteLine($"Nombre: {emp[i].Nombre}");
    Console.WriteLine($"Apellido: {emp[i].Apellido}");
    Console.WriteLine($"Fecha de nacimiento: {emp[i].FechaNacimiento.ToShortDateString()}"); 
    //.ToShortDateString() para que solo muestre la fecha y no la hora que se agrega por defecto a medianoche
    Console.WriteLine($"Genero (F: femenino, M: masculino): {emp[i].Genero}");
    Console.WriteLine($"Estado civil (C: casado, S:soltero): {emp[i].EstadoCivil}");
    Console.WriteLine($"Fecha de ingreso en la empresa: {emp[i].FechaIngreso.ToShortDateString()}");
    Console.WriteLine($"Sueldo: {emp[i].Sueldo}");
    Console.WriteLine($"Cargo: {emp[i].cargo}");
    
    int edad = emp[i].calcularEdad(emp[i].FechaNacimiento);
    Console.WriteLine($"Edad: {edad}");
    int antiguedad = emp[i].calcularAntiguedad(emp[i].FechaIngreso);
    Console.WriteLine($"Antiguedad: {antiguedad}");
    int falta = emp[i].calcularAñosAJubilarse(emp[i].Genero);
    Console.WriteLine($"Años que faltan para jubilarse: {falta}");
}
