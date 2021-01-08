using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_MCC42
{
    class Segitiga : BangunDatar
    {
        private double st_alas;
        private double st_tinggi;

        public double Alas
        {
            get { return st_alas; }
            set { st_alas = value; }
        }

        public double Tinggi
        {
            get { return st_tinggi; }
            set { st_tinggi = value; }
        }

        public override double hitungLuas()
        {
            bd_hitung = 0.5 * (st_alas * st_tinggi);
            return bd_hitung;
        }
    }
}
