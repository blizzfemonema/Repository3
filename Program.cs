using System;

public class Student
{
    public string Nume { get; set; }
    public int Varsta { get; set; }
    public string Specializare { get; set; }

    public Student(string nume, int varsta, string specializare)
    {
        Nume = nume;
        Varsta = varsta;
        Specializare = specializare;
    }
    
    public Student(Student copie)
    {
        Nume = copie.Nume;
        Varsta = copie.Varsta;
        Specializare = copie.Specializare;
    }

    public void AfisareDetalii()
    {
        Console.WriteLine($"Nume: {Nume}");
        Console.WriteLine($"Varsta: {Varsta}");
        Console.WriteLine($"Specializare: {Specializare}");
    }
}