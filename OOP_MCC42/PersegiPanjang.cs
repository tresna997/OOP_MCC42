using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_MCC42
{
    class PersegiPanjang : BangunDatar
    {
        private double pp_panjang;
        private double pp_lebar;

        public double Panjang
        {
            get { return pp_panjang; }
            set { pp_panjang = value; }
        }

        public double Lebar
        {
            get { return pp_lebar; }
            set { pp_lebar = value; }
        }

        public override double hitungLuas()
        {
            bd_hitung = pp_panjang * pp_lebar;
            return bd_hitung;
        }
    }
}
