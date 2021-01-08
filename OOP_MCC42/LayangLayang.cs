using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_MCC42
{
    class LayangLayang : BangunDatar
    {
        private double ll_diagonal1;
        private double ll_diagonal2;

        public double LayangLayangDiagonal_1
        {
            get { return ll_diagonal1; }
            set { ll_diagonal1 = value; }
        }

        public double LayangLayangDiagonal_2
        {
            get { return ll_diagonal2; }
            set { ll_diagonal2 = value; }
        }

        public override double hitungLuas()
        {
            bd_hitung = 0.5 * (ll_diagonal1 * ll_diagonal2);
            return bd_hitung;
        }
    }
}
