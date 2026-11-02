using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace SzenzorApp
{
    public class Szenzor
    {
        public string Azonosito { get; set; }
        protected int fogyasztasmW;
        private static int osszesSzenzorSzama = 0;
        public int FogyasztasmW
        {
            get
            {
                return fogyasztasmW;
            }
            set
            {
                if (value <= 0)
                {
                    fogyasztasmW = 50;
                }
                else
                {
                    fogyasztasmW = value;
                }
            }
        }
        public static int OsszesSzenzorSzama
        {
            get
            {
                return osszesSzenzorSzama;
            }
        }
        public Szenzor(string azonosito, int fogyasztas)
        {
            Azonosito = azonosito;
            FogyasztasmW = fogyasztas;

            osszesSzenzorSzama++;
        }
        public virtual int NapiEnergiaIgeny(int orakSzama)
        {
            return FogyasztasmW * orakSzama;
        }
        public override string ToString()
        {
            return $"Szenzor {Azonosito}  Fogyasztás: {FogyasztasmW} mW";
        }
    }
}
