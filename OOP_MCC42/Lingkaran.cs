using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_MCC42
{
    class Lingkaran : BangunDatar
    {
        private double l_jari_jari;

        public double JariJari
        {
            get { return l_jari_jari; }
            set { l_jari_jari = value; }
        }

        public override double hitungLuas()
        {
            bd_hitung = 3.14 * (l_jari_jari * l_jari_jari);
            return bd_hitung;
        }
    }
}
