namespace CSharpOdev1Methods
{
    public class Program
    {
        

        public static void Main()
        {
            
                TeshisYaz();
           
        }
 
        static (double boy, double kilo) BoyKiloAl()
        {
            Console.Clear();
            Console.WriteLine("Merhaba, lütfen vücut kitle endeksinizin belirlenmesi için boy ve kilo değerlerinizi giriniz.");
            Console.Write("Boy (m) : ");
            double boy = Convert.ToDouble(Console.ReadLine());
            Console.Write("Kilo (kg) : ");
            double kilo = Convert.ToDouble(Console.ReadLine());
            return (boy, kilo);
        }
        static double VKIHesapla(double boy,double kilo)
        { 
            double VKI = kilo / (boy * boy);
            return VKI;
        }
        static void TeshisYaz()
        {
            var veriler = BoyKiloAl();
            double VKI = VKIHesapla(veriler.boy,veriler.kilo);
            string teshis = TeshisKoy(VKI);
            Console.WriteLine($"Boy : {veriler.boy} , Kilo  :{veriler.kilo}, VKI : {VKI} Teşhis : {teshis}");
            DevamMi();
        }
        static string TeshisKoy(double VKI)
        {
            if (VKI < 18.49)
            {
                return "Zayıf";
            }
            else if (VKI >= 18.49 || VKI < 24.99)
            {
                return "İdeal Kiloda";
            }
            else if (VKI >= 24.99 || VKI < 29.99)
            {
                return "Hafif Kilolu";
            }
            else
            {
                return "Obez";
            }
        }
        static void DevamMi()
        {
            Console.Write("Teşhisiniz koyulmuştur.Devam edip başka işlem yapmak istiyor musunuz ? ( E/H)");
            string cevap = Console.ReadLine();

            switch (cevap)
            {

                case "E":
                case "e":
                    TeshisYaz();
                    break;
                case "H":
                case "h":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Hatalı bir seçim yaptınız!! Lütfen geçerli bir cevap giriniz,tekrar denemek için ENTER (E/H)");
                    Console.ReadLine();
                    DevamMi();
                    break;

            }
        }
    }

}