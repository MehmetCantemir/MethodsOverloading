namespace Methods_Overloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //out parametreler
            string sayi = "999";
            bool sonuc=int.TryParse(sayi, out int outSayi);
            if (sonuc)
                Console.WriteLine("Başarılı "+outSayi);
            else
                Console.WriteLine("Başarısız ");
            Metotlar m1= new Metotlar();
            m1.Topla(4, 5, out int toplamsonucu);
            Console.WriteLine(toplamsonucu);


            //Metot Aşırı Yükleme - Overloading
            int ifade = 999;
            m1.EkranaYazdir(ifade.ToString());
            m1.EkranaYazdir(ifade);
            m1.EkranaYazdir("Mehmet", "Cantemir");
        }
    }

    class Metotlar
    {
        public void Topla(int x, int y,out int toplam) {
            toplam = x+y;
        }   

        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }

        public void EkranaYazdir(int veri)
        {
            Console.WriteLine(veri);
        }

        public void EkranaYazdir(string name , string surname)
        {
            Console.WriteLine(name+surname);
        }
    }
}