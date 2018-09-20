using System;
using System.Linq;

namespace LichtApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Functie voor een extra whitespace
            void WhiteSpace()
            {
                Console.WriteLine("");
            }

            //Titel
            Console.WriteLine("Lichtknop");
            WhiteSpace();

            //Lichtknoppen
            LichtKnop lichtknop1 = new LichtKnop(1, "uit");
            LichtKnop lichtknop2 = new LichtKnop(2, "uit");
            Console.WriteLine("lichtknop " + lichtknop1.GetID() + " is " + lichtknop1.GetStatus());
            Console.WriteLine("lichtknop " + lichtknop2.GetID() + " is " + lichtknop2.GetStatus());
            Console.ReadKey();


            //Lampen van Lichtknop 1
            Lamp lamp1 = new Lamp(1, "rood", "uit");
            Lamp lamp2 = new Lamp(2, "groen", "uit");
            Lamp lamp3 = new Lamp(3, "blauw", "uit");
            Lamp lamp4 = new Lamp(4, "geel", "uit");
            Lamp lamp5 = new Lamp(5, "wit", "uit");
            Lamp lamp6 = new Lamp(6, "roze", "uit");
            lichtknop1.VoegLampToe(lamp1);
            lichtknop1.VoegLampToe(lamp2);
            lichtknop1.VoegLampToe(lamp3);
            lichtknop1.VoegLampToe(lamp4);
            lichtknop1.VoegLampToe(lamp5);
            lichtknop1.VoegLampToe(lamp6);

            //Lampen van Lichtknop 2
            Lamp lamp7 = new Lamp(7, "paars", "uit");
            Lamp lamp8 = new Lamp(8, "ijs wit", "uit");
            Lamp lamp9 = new Lamp(9, "turquoise", "uit");
            lichtknop2.VoegLampToe(lamp7);
            lichtknop2.VoegLampToe(lamp8);
            lichtknop2.VoegLampToe(lamp9);
            Stroboscoop stroboscoop1 = new Stroboscoop(10, "wit", "uit", 5);
            lichtknop2.VoegLampToe(stroboscoop1);

            //Lijst weergeven voor lichtknop 1
            WhiteSpace();
            for (int i = 0; i < lichtknop1.LampenSet.Count(); i++)
            {
                Console.WriteLine("Lichtknop " + lichtknop1.GetID() + " heeft lamp " + lichtknop1.LampenSet[i].GetID() + " met kleur " + lichtknop1.LampenSet[i].GetKleur() + " en status " + lichtknop1.LampenSet[i].GetStatus());
            }
            Console.ReadKey();

            //Lijst weergeven voor lichtknop 2
            WhiteSpace();
            for (int i = 0; i < lichtknop2.LampenSet.Count(); i++)
            {
                Console.WriteLine("Lichtknop " + lichtknop2.GetID() + " heeft lamp " + lichtknop2.LampenSet[i].GetID() + " met kleur " + lichtknop2.LampenSet[i].GetKleur() + " en status " + lichtknop2.LampenSet[i].GetStatus());
            }
            Console.ReadKey();

            //Status veranderen van Lichtknop 1
            
            //Status veranderen van Lichtknop 2
            lichtknop2.LichtKnopSwitch();
            WhiteSpace();
            for (int i = 0; i < lichtknop2.LampenSet.Count(); i++)
            {
                Console.WriteLine("Lichtknop " + lichtknop2.GetID() + " heeft lamp " + lichtknop2.LampenSet[i].GetID() + " met kleur " + lichtknop2.LampenSet[i].GetKleur() + " en status " + lichtknop2.LampenSet[i].GetStatus());
            }
            Console.ReadKey();
        }
    }
}

