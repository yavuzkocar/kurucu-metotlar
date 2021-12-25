using System;

namespace kurucu_metotlar
{
    class Program
     {
        static void Main(string[] args)
        {
        //    söz dizimi
        //    class sinifadi
        //    {
        //        [erişim belirleyici] [veri tipi] özellikadi;
        //        [erişim belirleyici][ geri dönüş tipi] Mettotadı([parametre listesi])
        //        {
        //            //metot komutları
        //        }
        //    }
        //erişim belirleyiciler
        //* public
        //* private
        //* internal-sadece olduğu proje içerisinde erişilebilir
        //* protected- sadece tanımlandıı sınıf veya sınıftan kalıtım alan diğer sınıflarda kullanılabilir
        Console.WriteLine("*****calısan 1******");
        Calisan calisan1 = new Calisan("ayşe","yılmaz",1,"insankaynakları");
        // calisan1.ad="ayşe";
        // calisan1.soyad="yılmaz";
        // calisan1.no=1;
        // calisan1.departman="insan kaynakları";

        calisan1.calısanBilgileri();
        
        Console.WriteLine("*****calısan 2******");
        Calisan calisan2 = new Calisan();
        calisan2.ad= "deniz";
        calisan2.soyad="arda";
        calisan2.no=12;
        calisan2.departman="teknik ekip";
        calisan2.calısanBilgileri();

        Console.WriteLine("*****calısan 3******");
        Calisan calisan3 = new Calisan();
        calisan3.ad= "selin";
        calisan3.soyad="ada";

        calisan3.calısanBilgileri();

        }
    }

    class Calisan
    {
        public string ad;
        public string soyad;
        public int no;
        public string departman;

        //asagıda bir kurucu metot olusturuldu sınıf adı ile aynı
        public Calisan(string Ad, string Soyad, int No, string Departman)
        {
            this.ad= Ad;
            this.soyad= Soyad;
            this.no=No;
            this.departman=Departman;    
        }
        //asağıda kurucu metot overload edildi 
        //mevcut calısan yapıları calısmaya devam etsin diye
        public Calisan(){}

        public void calısanBilgileri()
        {
            Console.WriteLine("çalışan Adı:{0}", ad);
            Console.WriteLine("çalışan Soyadı:{0}",soyad);
            Console.WriteLine("çalışan numarası:{0}", no);
            Console.WriteLine("çalışan departmanı:{0}", departman);
        }
    }
}
