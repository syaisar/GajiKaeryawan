using System;
using System.Collections.Generic;
using System.Text;
using TugasLab8.ClassAnak;
using TugasLab8.ClassInduk;

namespace TugasLab8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tugas Lab 8 : Inheritance,Polymorphism,Abstractions,Collection";


            KaryawanHarian karyawanHarian = new KaryawanHarian();
            karyawanHarian.Nama = "Akrim Tukuyoba";
            karyawanHarian.NIK = "17002129991";
            karyawanHarian.JumlahWaktuKerja = 8;
            karyawanHarian.UpahPerJam = 10000;
			
			
			KaryawanTetap karyawanTetap = new KaryawanTetap();
            karyawanTetap.Nama = "Jailani Ahmad";
            karyawanTetap.NIK = "19002129993";
            karyawanTetap.GajiBulanan = 5000000;


            Sales sales = new Sales();
            sales.Nama = "Adam maroon five";
            sales.NIK = "15002873549961";
            sales.JumlahPenjualan = 50;
            sales.Komisi = 100000;

            
            List<Karyawan> listKaryawan = new List<Karyawan>();

            listKaryawan.Add(karyawanTetap);
            listKaryawan.Add(karyawanHarian);
            listKaryawan.Add(sales);

            int nomorUrut = 1;

            foreach (Karyawan karyawan in listKaryawan)
            {
                Console.WriteLine("{0}. Nama: {1}, NIK: {2}, Gaji: {3}", nomorUrut, karyawan.NIK, karyawan.Nama, karyawan.Gaji());

                nomorUrut++;
            }

            Console.ReadLine();
        }
    }
}