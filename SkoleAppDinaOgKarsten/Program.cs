using SkoleAppDinaOgKarsten.Skole;
using System;

namespace SkoleAppDinaOgKarsten
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Tenk videregående skole. Lærer, elev, klasse og fag. Lag en applikasjon for påmelding av elev til kurs: 
             *      - Hvert klasse har en lærer. 
             *      - Hvert fag har ukentlige timer - inkl. hvilket rom. 
             * 
             * Lag kode som kan produsere timeplan for en elev og for en lærer. 
             * Lag lister over elev for hvert fag - og for hver klasse. Noen fag er felles for en klasse - andre fag har elever fra forskjellige klasser. 
             
             
            Timeplan:
            Tidspunkt - 4 tidspunkt.
            Hvilket fat i hvilket rom når?
            Klasserom
            - Hvem er her (lærer/elev), når er de her og hvilket fag?
            Skole
            -Hele sullamitten, reine dynamitten.
            Elev
            -Fag
            -Egen timeplan.
            -Klasserom de skal til og når.
            Lærer
            -Fag
            -Egen timeplan.
            -Klasserom.
            Fag
            -Må vite klasserom og tidspunkt.
            -Må vite hvilket fag.

            Kl     Mandag            Tirsdag           Onsdag        Torsdag     og   Fredag.
            09     Norsk             Matte             Norsk          It              Gym
            10     It                Norsk             It             Norsk           Gym
            11     Matte             It                Fransk/Tysk    Samfunn         It
            12     Samfunnsfag       Fransk/Tysk       Gym            Matte           It
             */

            Console.WriteLine("Dette er en test for timeplan");
        }
    }
}
