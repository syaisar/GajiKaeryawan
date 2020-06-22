using System;
using System.Collections.Generic;
using System.Text;
using TugasLab8.ClassInduk;


namespace TugasLab8.ClassAnak
{
    class KaryawanHarian : Karyawan
    {
        public double JumlahWaktuKerja { get; set; }
        
		ublic double UpahWaktuJam { get; set; }
        
		public override double Gaji()
        {
            return JumlahWaktuKerja * UpahPerJam;
        }
    }
}