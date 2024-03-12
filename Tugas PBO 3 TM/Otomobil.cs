using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_PBO_3_TM
{
    internal class Otomobil
    {
        public string merek;
        public string warna;
        public int tahunkeluaran;
    }

    class Sedan : Otomobil
    {
        public void setSedan(string merek, string warna, int tahunkeluaran)
        {
            this.merek = merek;
            this.warna = warna;
            this.tahunkeluaran = tahunkeluaran;
        }
        public (string, string, int) getSedan ()
        {
            return (merek, warna, tahunkeluaran);
        }
    }
}
