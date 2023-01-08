namespace CSharpOdev1Methods
{
    public class Program
    {
        public static void Main()
        {
            Menu();
            
            
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Merhaba, lütfen vücut kitle endeksinizin belirlenmesi için boy ve kilo değerlerinizi giriniz.");
            TeshisYaz();
            
        }
        static (double boy, double kilo) BoyKiloAl()
        {
            Console.Write("Boy (m) : ");
            double boy = Convert.ToDouble(Console.ReadLine());
            Console.Write("Kilo (kg) : ");
            double kilo = Convert.ToDouble(Console.ReadLine());
            return (boy, kilo);
        }
        static double VKIHesapla()
        {
            var veriler = BoyKiloAl();
            double VKI = veriler.kilo / (veriler.boy * veriler.boy);
            return VKI;
        }
        static void TeshisYaz()
        {
            var VKI = VKIHesapla();
            var veriler = BoyKiloAl();

            if (VKI < 18.49)
            {
                Console.WriteLine($"Hastanın; boyu: {veriler.boy}, kilosu: {veriler.kilo}, VKI indeksi: {VKI}, Teşhis: Zayıf Hasta");
            }
            else if (VKI >= 18.49 || VKI < 24.99)
            {
                Console.WriteLine($"Hastanın; boyu: {veriler.boy}, kilosu: {veriler.kilo}, VKI indeksi: {VKI}, Teşhis: İdeal Kiloda Hasta");
            }
            else if (VKI >= 24.99 || VKI < 29.99)
            {
                Console.WriteLine($"Hastanın; boyu: {veriler.boy}, kilosu: {veriler.kilo}, VKI indeksi: {VKI}, Teşhis: Hafif Kilolu Hasta");
            }
            else
            {
                Console.WriteLine($"Hastanın; boyu: {veriler.boy}, kilosu: {veriler.kilo}, VKI indeksi: {VKI}, Teşhis: Obez Hasta");
            }
        }
    }
}