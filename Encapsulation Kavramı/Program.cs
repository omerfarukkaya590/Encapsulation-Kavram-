Oğrenci oğrenci1= new Oğrenci();
oğrenci1.Isim="ömer faruk";
oğrenci1.Soyad="KAYA";
oğrenci1.Ogrencinumarası=590;
oğrenci1.Sınıf=3;

oğrenci1.OğrenciBilgileriGetir();

oğrenci1.SınıfAtlat();
oğrenci1.OğrenciBilgileriGetir();

oğrenci1.SınıfDüşür();
oğrenci1.OğrenciBilgileriGetir();

Oğrenci oğrenci2= new Oğrenci("AHMET BARAN","GÖRÇİN",123,1);

oğrenci2.SınıfDüşür();
oğrenci2.OğrenciBilgileriGetir();


class Oğrenci
{
    private string isim;
    private string soyad;
    private int ogrencinumarası;
    private int sınıf;

    public string Isim 
    {
         get {return isim;} 
         set { isim = value;}
    }
    public string Soyad { get => soyad; set => soyad = value; }
    public int Ogrencinumarası { get => ogrencinumarası; set => ogrencinumarası = value; }
    public int Sınıf 
    { get => sınıf; 
    set 
    {
           if (value<1)
           {
            System.Console.WriteLine("SINIF 1 DEN DÜŞÜK OLAMAZ!");
           }
           else
            sınıf = value; 
    }
    }

    public Oğrenci(string isim, string soyad,int ogrencinumarası, int sınıf)
    {
        Isim = isim;
        Soyad = soyad;
        Ogrencinumarası = ogrencinumarası;
        Sınıf = sınıf;
    }

    public Oğrenci(){}

    public void OğrenciBilgileriGetir()
    {
        System.Console.WriteLine("----------------ÖĞRENCİ BİLGİLERİ-----------------");
        System.Console.WriteLine("----------------ÖĞRENCİ ADI       :{0}",this.Isim);
        System.Console.WriteLine("----------------ÖĞRENCİ SOYADI    :{0}",this.Soyad);
        System.Console.WriteLine("----------------ÖĞRENCİ NUMARA    :{0}",this.Ogrencinumarası);
        System.Console.WriteLine("----------------ÖĞRENCİ SINIFI    :{0}",Sınıf);


    }

    public void SınıfAtlat()
    {
        Sınıf= Sınıf+1;
    }
     public void SınıfDüşür()
    {
        this.Sınıf= this.Sınıf-1;
    }


}