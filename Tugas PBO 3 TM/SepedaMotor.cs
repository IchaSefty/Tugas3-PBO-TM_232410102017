using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_PBO_3_TM
{
    class SepedaMotor : Otomobil
    {
        public void setSepedaMotor(string merek, string warna, int tahunkeluaran)
        {
            this.merek = merek;
            this.warna = warna;
            this.tahunkeluaran = tahunkeluaran;
        }
        public (string, string, int) getSepedaMotor()
        {
            return (merek, warna, tahunkeluaran);
        }
    }
}
