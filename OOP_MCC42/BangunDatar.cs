using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_MCC42
{
    abstract class BangunDatar
    {
        public double bd_hitung;

        public double Hitung
        {
            get { return bd_hitung; }
            set { bd_hitung = value; }
        }
        public abstract double hitungLuas();
    }
}
