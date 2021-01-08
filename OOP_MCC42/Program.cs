using System;

namespace OOP_MCC42
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan Sisi Persegi : ");
            string s_persegi = Console.ReadLine();
            Persegi p = new Persegi();
            p.Sisi = int.Parse(s_persegi);

            Console.WriteLine("Bangun Datar Persegi");
            Console.WriteLine("Sisi Persegi = " + p.Sisi);
            Console.WriteLine("Luas Persegi = " + p.hitungLuas() + "\n");

            Console.Write("Masukkan Sisi Panjang Persegi Panjang : ");
            string s_persegi_panjang1 = Console.ReadLine();
            Console.Write("Masukkan Sisi Lebar Persegi Panjang : ");
            string s_persegi_panjang2 = Console.ReadLine();
            PersegiPanjang pp = new PersegiPanjang();
            pp.Panjang = int.Parse(s_persegi_panjang1);
            pp.Lebar = int.Parse(s_persegi_panjang2);

            Console.WriteLine("Bangun Datar Persegi Panjang");
            Console.WriteLine("Panjang Sisi Persegi Panjang = " + pp.Panjang);
            Console.WriteLine("Lebar Sisi Persegi Panjang = " + pp.Lebar);
            Console.WriteLine("Luas Persegi Panjang = " + pp.hitungLuas() + "\n");

            Console.Write("Masukkan Alas Segitiga : ");
            string a_segiTiga = Console.ReadLine();
            Console.Write("Masukkan Tinggi Segitiga : ");
            string t_segiTiga = Console.ReadLine();
            Segitiga s = new Segitiga();
            s.Alas = int.Parse(a_segiTiga);
            s.Tinggi = int.Parse(t_segiTiga);

            Console.WriteLine("Bangun Datar Segitiga");
            Console.WriteLine("Sisi Alas Segitiga = " + s.Alas);
            Console.WriteLine("sisi Tinggi Segitiga = " + s.Tinggi);
            Console.WriteLine("Luas Segitiga = " + s.hitungLuas() + "\n");

            Console.Write("Masukkan Jari - Jari Lingkaran : ");
            string l_jari_jari = Console.ReadLine();
            Lingkaran l = new Lingkaran();
            l.JariJari = int.Parse(l_jari_jari);

            Console.WriteLine("Bangun Datar Lingkaran");
            Console.WriteLine("Panjang Jari - Jari Lingkaran = " + l.JariJari);
            Console.WriteLine("Luas Lingkaran = " + l.hitungLuas() + "\n");

            Console.Write("Masukkan Diagonal Pendek Layang - Layang : ");
            string dpe_layang_layang = Console.ReadLine();
            Console.Write("Masukkan Diagonal Panjang Layang - Layang : ");
            string dpa_layang_layang = Console.ReadLine();
            LayangLayang ll = new LayangLayang();
            ll.LayangLayangDiagonal_1 = int.Parse(dpe_layang_layang);
            ll.LayangLayangDiagonal_2 = int.Parse(dpa_layang_layang);

            Console.WriteLine("Bangun Datar Layang - Layang");
            Console.WriteLine("Panjang Diagonal 1 Layang - Layang = " + ll.LayangLayangDiagonal_1);
            Console.WriteLine("Panjang Diagonal 2 Layang - Layang = " + ll.LayangLayangDiagonal_2);
            Console.WriteLine("Luas Layang - Layang = " + ll.hitungLuas());
        }
    }
}
