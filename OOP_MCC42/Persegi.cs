using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_MCC42
{
    class Persegi : BangunDatar
    {
        private double p_sisi;

        public double Sisi
        {
            get { return p_sisi; }
            set { p_sisi = value; }
        }

        public override double hitungLuas()
        {
            bd_hitung = p_sisi * p_sisi;
            return bd_hitung;
        }
    }
}
