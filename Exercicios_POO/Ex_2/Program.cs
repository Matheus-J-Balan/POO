using System;
using System.Collections.Generic;
using Ex_2.Models;

Autor a = new Autor();
a.nome = "Kleber";
a.email = "NAO";

Autor b = new Autor();
b.nome = "Giovayne";
b.email = "SIM";


Livro l = new Livro();
l.nome = "Banana creme";
l.autores = new List<Autor>();

l.autores.Add(a);
l.autores.Add(b);

foreach (var autor in l.autores)
{
    Console.WriteLine(autor.nome);
    Console.WriteLine(autor.email);

}