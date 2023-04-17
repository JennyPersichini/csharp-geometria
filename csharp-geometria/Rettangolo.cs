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
            Console.WriteLine("—— Rettangolo ——");
            Console.WriteLine("");
            Console.WriteLine($"base: {baseRettangolo} cm");
            Console.WriteLine($"altezza: {altezzaRettangolo} cm");
            Console.WriteLine($"perimetro: {calcolaPerimetro()} cm");
            Console.WriteLine($"area: {calcolaArea()} cm2");
        }

        //BONUS:
        //Aggiungere alla classe Rettangolo un metodo “disegna” che disegna in console il rettangolo con le sue dimensioni,
        //ossia tanti “—” (due trattini) orizzontali quanto è grande la sua base 
        //e tanti ‘|’ verticali quanto e grande la sua altezza.

        public void DisegnaRettangolo()
        {
            string rettangolo = " ";

            for (int i = 0; i < baseRettangolo; i++)
            {
                rettangolo += "--";
            }

            rettangolo += "\n";

            for (int i = 0; i < altezzaRettangolo; i++)
            {
                rettangolo += "|";

                for (int index = 0; index < baseRettangolo; index++)
                {
                    rettangolo += "  ";
                }

                rettangolo += ("|\n");
            }

            rettangolo += " ";

            for (int i = 0; i < baseRettangolo; i++)
            {
                rettangolo += "--";
            }

            Console.WriteLine(rettangolo);

        }

    }

}
