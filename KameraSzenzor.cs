using System;
using System.Collections.Generic;
using System.Text;

namespace SzenzorApp
{
    public class KameraSzenzor : Szenzor
    {
        public int FelbontasMP { get; set; }

        public KameraSzenzor(string azonosito,int fogyasztas,int felbontasMP) : base(azonosito, fogyasztas)
        {
            FelbontasMP = felbontasMP;
        }

        public override int NapiEnergiaIgeny(int orakSzama)
        {
            return FelbontasMP * 10 * orakSzama;
        }

        public override string ToString()
        {
            return base.ToString() + $" | Felbontás: {FelbontasMP} MP";
        }

    }

}    
