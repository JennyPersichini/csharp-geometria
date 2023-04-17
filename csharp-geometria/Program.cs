// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using csharp_geometria;

//Poi, nel vostro programma principale (Program.cs) chiedete all’utente di inserire, da console, i valori di base e di altezza con cui istanziare un nuovo Rettangolo. 
//Dopo averlo istanziato, stampate a video il perimetro e l’area del rettangolo che avete costruito.

Rettangolo rettangoloPC = new Rettangolo(20, 10);

rettangoloPC.stampaRettangolo();
Console.WriteLine("");

Console.WriteLine("-------------------------------------");
Console.WriteLine("");

Console.Write("Inserisci la base del tuo rettangolo: ");
int baseRettangoloUtente = int.Parse(Console.ReadLine());

Console.Write("Inserisci l'altezza del tuo rettangolo: ");
int altezzaRettangoloUtente = int.Parse(Console.ReadLine());

Console.WriteLine("");

Rettangolo rettangoloUtente = new Rettangolo(baseRettangoloUtente, altezzaRettangoloUtente);

rettangoloUtente.stampaRettangolo();
