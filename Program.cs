using System;

public class Carte
{
    public string Titlu { get; set; }
    public string Autor { get; set; }
    public int AnPublicare { get; set; }
    public int NumarPagini {  get; set; }

    public Carte (string titlu, string autor, int anPublicare, int numarPagini)
    {
        Titlu = titlu;
        Autor = autor;
        AnPublicare = anPublicare;
        NumarPagini = numarPagini;
    }

    public void AfisareDetalii()
    {
        Console.WriteLine($"Titlul cartii este: {Titlu}");
        Console.WriteLine($"Autorul cartii este: {Autor}");
        Console.WriteLine($"Anul de publicare a cartii este: {AnPublicare}");
        Console.WriteLine($"Numarul de pagini este: {Autor}");
    }
}