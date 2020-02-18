using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatter_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> caractères = new List<string> (){ "Venal", "Indecis", "Fou", "Végétarien", "Profiteur", "Psychopathe", "Xénophobe" };
            
            
            Console.WriteLine("Entrer le caractère d'un président : ");
            string caractere = Console.ReadLine();
            while (!caractères.Contains(caractere))
            {
                Console.WriteLine("Entrer le caractère d'un président : ");
                caractere = Console.ReadLine();
            }
            President president = Factory.Create(caractere);
            Console.WriteLine(president.Slogan);

        }
    }
    abstract class President
    {
        public abstract string Caractere { get; }
        public abstract string Slogan { get; }
    }

    class LREM : President
    {
        public override string Caractere => "Venal";
        public override string Slogan => "Vive l'argent et le confort";

    }
    class Centre : President
    {
        public override string Caractere => "Indecis";
        public override string Slogan => "...";


    }
    class ExtremeGauche : President
    {
        public override string Caractere => "Fou";
        public override string Slogan => "On en a gros !";
    }
    class Ecologiste : President
    {
        public override string Caractere => "Végétarien";
        public override string Slogan => "Le brocolie, c'est la vie ! ";


    }
    class Gauche : President
    {
        public override string Caractere => "Profiteur";
        public override string Slogan => "Yo !";


    }
    class Droite : President
    {
        public override string Caractere => "Psychopathe";
        public override string Slogan => "Qu'on leur coupe la tête !!!";


    }
    class ExtremeDroite : President
    {
        public override string Caractere => "Xénophobe";
        public override string Slogan => "";

    }

    static class Factory
    {

        public static President Create(string caractere)
        {
                if (caractere == "Xénophobe")
                {
                    return new ExtremeDroite();
                }
                else if (caractere == "Fou")
                {
                    return new ExtremeGauche();
                }
                else if (caractere == "Psychopathe")
                {
                    return new Droite();
                }
                else if (caractere == "Profiteur")
                {
                    return new Gauche();
                }
                else if (caractere == "Végétarien")
                {
                    return new Ecologiste();
                }
                else if (caractere == "Fou")
                {
                    return new ExtremeGauche();
                }
                else if (caractere == "Indecis")
                {
                    return new Centre();
                }
                else if (caractere == "Venal")
                {
                    return new LREM();
                }
                throw new ArgumentException("Le caractère ne correspond à un président");
            
        }


    }

}
