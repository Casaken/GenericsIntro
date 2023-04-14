using OOP3;
//Interface (IKrediManager) onu implemente eden (ilk örnekteki TasitKrediManager) in referans numarasını tutabilir.
//TasitKrediManager tasitKrediManager = new TasitKrediManager();(alternatif)
IKrediManager tasitKrediManager = new TasitKrediManager();
//IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();(alternatif)
IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
//KonutKrediManager konutKrediManager = new KonutKrediManager();(alternatif)
IKrediManager konutKrediManager = new KonutKrediManager();

BasvuruManager basvuruManager = new BasvuruManager();

ILoggerService dataBaseLoggerService = new DataBaseLoggerService();
ILoggerService fileLoggerService = new FileLoggerService();

basvuruManager.BasvuruYap(konutKrediManager, fileLoggerService);

List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, tasitKrediManager};

//basvuruManager.KrediOnBilgilendirmesiYap(krediler);




