using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Creare una classe Rettangolo con due attributi interi: baseRettangolo e altezzaRettangolo.
//Aggiungere un opportuno costruttore con parametri.
//Aggiungere due metodi: calcolaArea e calcolaPerimetro che calcolano e restituiscono, rispettivamente, l’area e il perimetro del rettangolo.

namespace csharp_geometria
{
    internal class Rettangolo
    {
        public int baseRettangolo;
        public int altezzaRettangolo;

        public Rettangolo(int baseRettangolo, int altezzaRettangolo)
        {
            this.baseRettangolo = baseRettangolo;
            this.altezzaRettangolo = altezzaRettangolo;
        }

        public int calcolaPerimetro()
        {
            int perimetro = (baseRettangolo + altezzaRettangolo) * 2;
            return perimetro;
        }

        public int calcolaArea()
        {
            int area = baseRettangolo * altezzaRettangolo;
            return area;
        }

        public void stampaRettangolo()
        {
            Console.Write("—— Rettangolo ——");
            Console.Write("");
            Console.Write($"base: {baseRettangolo} cm");
            Console.Write($"altezza: {altezzaRettangolo} cm");
            Console.Write($"perimetro: {calcolaPerimetro()} cm");
            Console.Write($"area: {calcolaArea()} cm2");
        }

    }

}
