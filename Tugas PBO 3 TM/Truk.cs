using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_PBO_3_TM
{
    class Truk : Otomobil
    {
        public void setTruk(string merek, string warna, int tahunkeluaran)
        {
            this.merek = merek;
            this.warna = warna;
            this.tahunkeluaran = tahunkeluaran;
        }
        public (string, string, int) getTruk()
        {
            return (merek, warna, tahunkeluaran);
        }


    }
}
