using OOP2;
//Individual
GercekMusteri musteri1 = new GercekMusteri();
musteri1.Id = 1;
musteri1.MusteriNo = "1234";
musteri1.Adi = "Berkay";
musteri1.SoyAdi = "Kiziltug";
musteri1.TcNo = "1234959";


//coorporate
TuzelMusteri musteri2 = new TuzelMusteri();
musteri2.Id = 2;
musteri2.MusteriNo = "3456";
musteri2.SirketAdi = "bokum games";
musteri2.VergiNo = "1234567890";

Musteri musteri3 = new TuzelMusteri();


CustomerManager customerManager = new CustomerManager();
customerManager.Add(musteri1);