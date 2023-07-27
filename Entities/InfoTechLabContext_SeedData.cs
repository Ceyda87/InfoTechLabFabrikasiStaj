using Microsoft.EntityFrameworkCore;


namespace InfoTechLabProjeFabrikasi.Data
{
    public partial class InfoTechLabContext
    {
        private static void SeedCustomer(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(
                new Customer { Id = 1, Name = "Zeynep Bilgiç", EMail = "zeynepbilgic@gmail.com" },
                new Customer { Id = 2, Name = "Mehmet Tan", EMail = "mehmettan@gmail.com" }
                );
        }
        private static void SeedExpert(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Expert>().HasData(
                new Expert { Id = 1, Name = "Yusuf", MiddleName = "Ali", Surname = "Kurt", EMail = "yusufali@gmail.com", PhoneNumber = "05553462133", ServiceArea = "Su Tesisatı" },
                new Expert { Id = 2, Name = "Gökhan", MiddleName = "Murat", Surname = "Karaca", EMail = "g.muratkaraca@gmail.com", PhoneNumber = "05553462133", ServiceArea = "Kombi Tesisatı" },
                new Expert { Id = 3, Name = "Emir", Surname = "Alioğlu", EMail = "a.cankısa@gmail.com", PhoneNumber = "05323698520", ServiceArea = "Kombi Tesisatı" },
                new Expert { Id = 4, Name = "Yasin", Surname = "Nuroğlu", EMail = "yasinnnuroglu@gmail.com", PhoneNumber = "05362314578", ServiceArea = "Su Tesisatı" },
                new Expert { Id = 5, Name = "Mustafa", MiddleName = "Rıza", Surname = "Yurttaş", EMail = "m.rıza@gmail.com", PhoneNumber = "05356231459", ServiceArea = "Ev Nakliyat" },
                new Expert { Id = 6, Name = "Emin", Surname = "Karaoğlu", EMail = "eminkaraoglu@gmail.com", PhoneNumber = "05355632147", ServiceArea = "Ev Nakliyat" },
                new Expert { Id = 7, Name = "Abdullah", MiddleName = "Can", Surname = "Kısa", EMail = "a.cankısa@gmail.com", PhoneNumber = "05348963214", ServiceArea = "Ev Nakliyat" },
                new Expert { Id = 8, Name = "İhsan", Surname = "Uzun", EMail = "ıhsanuzun@gmail.com", PhoneNumber = "05389632314", ServiceArea = "Ev Boya Tadilat" },
                new Expert { Id = 9, Name = "Nuri", MiddleName = "Rıza", Surname = "Balaban", EMail = "n.rızabalaban@gmail.com", PhoneNumber = "05321369654", ServiceArea = "Ev Boya Tadilat" },
                new Expert { Id = 10, Name = "Fehmi", Surname = "Gürsoy", EMail = "fehmigursoy@gmail.com", PhoneNumber = "05367894512", ServiceArea = "Ev Banyo Tadilat" },
                new Expert { Id = 11, Name = "Haydar", Surname = "Dirican", EMail = "haydardirican@gmail.com", PhoneNumber = "05346987436", ServiceArea = "Ev Banyo Tadilat" },
                new Expert { Id = 12, Name = "Fatma", Surname = "Parlak", EMail = "fatmaparlak@gmail.com", PhoneNumber = "05342365897", ServiceArea = "Ev Temizlik" },
                new Expert { Id = 13, Name = "Ayşe", MiddleName = "Nur", Surname = "Korkmaz", EMail = "aysenurkorkmaz@gmail.com", PhoneNumber = "05325632147", ServiceArea = "Ev Temizlik" },
                new Expert { Id = 14, Name = "Esra", Surname = "Haktan", EMail = "esrahaktan@gmail.com", PhoneNumber = "05378963215", ServiceArea = "Ev Temizlik" },
                new Expert { Id = 15, Name = "Yusuf", MiddleName = "Ali", Surname = "Kurt", EMail = "yusufali@gmail.com", PhoneNumber = "05553462133", ServiceArea = "Su Tesisatı" },
                new Expert { Id = 16, Name = "Leyla", Surname = "Kara", EMail = "leylakara@gmail.com", PhoneNumber = "05478562314", ServiceArea = "Matematik Özel Ders" },
                new Expert { Id = 17, Name = "Ayhan", Surname = "Dönmez", EMail = "ayhandonmez@gmail.com", PhoneNumber = "05362696321", ServiceArea = "Matematik Özel Ders" },
                new Expert { Id = 18, Name = "Ebru", Surname = "Yurtseven", EMail = "ebruyurtseven@gmail.com", PhoneNumber = "05562314569", ServiceArea = "Matematik Özel Ders" },
                new Expert { Id = 19, Name = "Nurdan", Surname = "Dertli", EMail = "nurdandertli@gmail.com", PhoneNumber = "05312659874", ServiceArea = "Fizik Özel Ders" },
                new Expert { Id = 20, Name = "Aslı", Surname = "Sever", EMail = "aslısever@gmail.com", PhoneNumber = "05326987546", ServiceArea = "Fizik Özel Ders" },
                new Expert { Id = 21, Name = "Murat", Surname = "Karaman", EMail = "muratkaraman@gmail.com", PhoneNumber = "05369875632", ServiceArea = "Türkçe Özel Ders" },
                new Expert { Id = 22, Name = "Nilgün", Surname = "Vatansever", EMail = "nilgunvatansever@gmail.com", PhoneNumber = "05336952314", ServiceArea = "Türkçe Özel Ders" },
                new Expert { Id = 23, Name = "Nalan", MiddleName = "Ayşe", Surname = "Yılmaz", EMail = "n.ayseyılmaz@gmail.com", PhoneNumber = "05426312369", ServiceArea = "İngilizce Özel Ders" },
                new Expert { Id = 24, Name = "Ali", MiddleName = "Kemal", Surname = "Candan", EMail = "alikemalcandan@gmail.com", PhoneNumber = "05352698741", ServiceArea = "İngilizce Özel Ders" }

                );

        }
        private static void SeedCategories(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Temizlik" },
                new Category { Id = 2, Name = "Tesisat" },
                new Category { Id = 3, Name = "Nakliyat" },
                new Category { Id = 4, Name = "Özel Ders" },
                new Category { Id = 5, Name = "Tadilat" }
                );
        }
        private static void SeedCities(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>().HasData(
                new City { Id = 1, CityCode = 01, Name = "ADANA" },
                new City { Id = 2, CityCode = 02, Name = "ADIYAMAN" },
                new City { Id = 3, CityCode = 03, Name = "AFYONKARAHİSAR" },
                new City { Id = 4, CityCode = 04, Name = "AĞRI" },
                new City { Id = 5, CityCode = 05, Name = "AMASYA" },
                new City { Id = 6, CityCode = 06, Name = "ANKARA" },
                new City { Id = 7, CityCode = 07, Name = "ANTALYA" },
                new City { Id = 8, CityCode = 08, Name = "ARTVİN" },
                new City { Id = 9, CityCode = 09, Name = "AYDIN" },
                new City { Id = 10, CityCode = 10, Name = "BALIKESİR" },
                new City { Id = 11, CityCode = 11, Name = "BİLECİK" },
                new City { Id = 12, CityCode = 12, Name = "BİNGÖL" },
                new City { Id = 13, CityCode = 13, Name = "BİTLİS" },
                new City { Id = 14, CityCode = 14, Name = "BOLU" },
                new City { Id = 15, CityCode = 15, Name = "BURDUR" },
                new City { Id = 16, CityCode = 16, Name = "BURSA" },
                new City { Id = 17, CityCode = 17, Name = "ÇANAKKALE" },
                new City { Id = 18, CityCode = 18, Name = "ÇANKIRI" },
                new City { Id = 19, CityCode = 19, Name = "ÇORUM" },
                new City { Id = 20, CityCode = 20, Name = "DENİZLİ" },
                new City { Id = 21, CityCode = 21, Name = "DİYARBAKIR" },
                new City { Id = 22, CityCode = 22, Name = "EDİRNE" },
                new City { Id = 23, CityCode = 23, Name = "ELAZIĞ" },
                new City { Id = 24, CityCode = 24, Name = "ERZİNCAN" },
                new City { Id = 25, CityCode = 25, Name = "ERZURUM" },
                new City { Id = 26, CityCode = 26, Name = "ESKİŞEHİR" },
                new City { Id = 27, CityCode = 27, Name = "GAZİANTEP" },
                new City { Id = 28, CityCode = 28, Name = "GİRESUN" },
                new City { Id = 29, CityCode = 29, Name = "GÜMÜŞHANE" },
                new City { Id = 30, CityCode = 30, Name = "HAKKARİ" },
                new City { Id = 31, CityCode = 31, Name = "HATAY" },
                new City { Id = 32, CityCode = 32, Name = "ISPARTA" },
                new City { Id = 33, CityCode = 33, Name = "MERSİN" },
                new City { Id = 34, CityCode = 34, Name = "İSTANBUL" },
                new City { Id = 35, CityCode = 35, Name = "İZMİR" },
                new City { Id = 36, CityCode = 36, Name = "KARS" },
                new City { Id = 37, CityCode = 37, Name = "KASTAMONU" },
                new City { Id = 38, CityCode = 38, Name = "KAYSERİ" },
                new City { Id = 39, CityCode = 39, Name = "KIRKLARELİ" },
                new City { Id = 40, CityCode = 40, Name = "KIRŞEHİR" },
                new City { Id = 41, CityCode = 41, Name = "KOCAELİ" },
                new City { Id = 42, CityCode = 42, Name = "KONYA" },
                new City { Id = 43, CityCode = 43, Name = "KÜTAHYA" },
                new City { Id = 44, CityCode = 44, Name = "MALATYA" },
                new City { Id = 45, CityCode = 45, Name = "MANİSA" },
                new City { Id = 46, CityCode = 46, Name = "KAHRAMANMARAŞ" },
                new City { Id = 47, CityCode = 47, Name = "MARDİN" },
                new City { Id = 48, CityCode = 48, Name = "MUĞLA" },
                new City { Id = 49, CityCode = 49, Name = "MUŞ" },
                new City { Id = 50, CityCode = 50, Name = "NEVŞEHİR" },
                new City { Id = 51, CityCode = 51, Name = "NİĞDE" },
                new City { Id = 52, CityCode = 52, Name = "ORDU" },
                new City { Id = 53, CityCode = 53, Name = "RİZE" },
                new City { Id = 54, CityCode = 54, Name = "SAKARYA" },
                new City { Id = 55, CityCode = 55, Name = "SAMSUN" },
                new City { Id = 56, CityCode = 56, Name = "SİİRT" },
                new City { Id = 57, CityCode = 57, Name = "SİNOP" },
                new City { Id = 58, CityCode = 58, Name = "SİVAS" },
                new City { Id = 59, CityCode = 59, Name = "TEKİRDAĞ" },
                new City { Id = 60, CityCode = 60, Name = "TOKAT" },
                new City { Id = 61, CityCode = 61, Name = "TRABZON" },
                new City { Id = 62, CityCode = 62, Name = "TUNCELİ" },
                new City { Id = 63, CityCode = 63, Name = "ŞANLIURFA" },
                new City { Id = 64, CityCode = 64, Name = "UŞAK" },
                new City { Id = 65, CityCode = 65, Name = "VAN" },
                new City { Id = 66, CityCode = 66, Name = "YOZGAT" },
                new City { Id = 67, CityCode = 67, Name = "ZONGULDAK" },
                new City { Id = 68, CityCode = 68, Name = "AKSARAY" },
                new City { Id = 69, CityCode = 69, Name = "BAYBURT" },
                new City { Id = 70, CityCode = 70, Name = "KARAMAN" },
                new City { Id = 71, CityCode = 71, Name = "KIRIKKALE" },
                new City { Id = 72, CityCode = 72, Name = "BATMAN" },
                new City { Id = 73, CityCode = 73, Name = "ŞIRNAK" },
                new City { Id = 74, CityCode = 74, Name = "BARTIN" },
                new City { Id = 75, CityCode = 75, Name = "ARDAHAN" },
                new City { Id = 76, CityCode = 76, Name = "IĞDIR" },
                new City { Id = 77, CityCode = 77, Name = "YALOVA" },
                new City { Id = 78, CityCode = 78, Name = "KARABÜK" },
                new City { Id = 79, CityCode = 79, Name = "KİLİS" },
                new City { Id = 80, CityCode = 80, Name = "OSMANİYE" },
                new City { Id = 81, CityCode = 81, Name = "DÜZCE" }
                );


        }
    }
}