// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

namespace Tugas_PBO_3_TM
{
    class Akses
    {
        static void Main(string[] args)
        {
            Sedan hyundai = new Sedan();
            hyundai.setSedan("Hyundai Ioniq Electric", "Silver", 2020);
            (string, string, int) valueshyundai = hyundai.getSedan();
            string ahyundai = valueshyundai.Item1;
            string bhyundai = valueshyundai.Item2;
            int chyundai = valueshyundai.Item3;
            Console.WriteLine($"Otomobil");
            Console.WriteLine($"");
            Console.WriteLine($"Sedan");
            Console.WriteLine($"Merek           : " + ahyundai);
            Console.WriteLine($"Warna           : " + bhyundai);
            Console.WriteLine($"Keluaran Tahun  : " + chyundai);
            Console.WriteLine($"");

            Truk mitsubishi = new Truk();
            mitsubishi.setTruk("Mitsubishi Colt FE SHD", "Kuning", 2024);
            (string, string, int) valuesmitsubishi = mitsubishi.getTruk();
            string amitsubishi = valuesmitsubishi.Item1;
            string bmitsubishi = valuesmitsubishi.Item2;
            int cmitsubishi = valuesmitsubishi.Item3;
            Console.WriteLine($"Truk");
            Console.WriteLine($"Merek           : " + amitsubishi);
            Console.WriteLine($"Warna           : " + bmitsubishi);
            Console.WriteLine($"Keluaran Tahun  : " + cmitsubishi);
            Console.WriteLine($"");

            SepedaMotor vario = new SepedaMotor();
            vario.setSepedaMotor("Honda Vario 160", "Hitam", 2024);
            (string, string, int) valuesvario = vario.getSepedaMotor();
            string avario = valuesvario.Item1;
            string bvario = valuesvario.Item2;
            int cvario = valuesvario.Item3;
            Console.WriteLine($"Sepeda Motor");
            Console.WriteLine($"Merek           : " + avario);
            Console.WriteLine($"Warna           : " + bvario);
            Console.WriteLine($"Keluaran Tahun  : " + cvario);

        }
    }
}