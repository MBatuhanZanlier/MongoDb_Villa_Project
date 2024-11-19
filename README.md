# MongoDB Nedir? Temel Bilgiler ve Kullanım Alanları 
MongoDB, modern veri yönetimi için tasarlanmış, açık kaynaklı ve NoSQL bir veritabanıdır. Geleneksel ilişkisel veritabanlarının sunduğu tablo ve satır yapılarını terk eder ve verileri dokümanlar şeklinde depolar. Bu, daha esnek ve ölçeklenebilir bir veri yapısı sağlar. Peki, MongoDB'yi diğer veritabanlarından ayıran özellikler nelerdir? Hadi birlikte keşfedelim. 
## NoSQL Nedir? MongoDB Nerede Kullanılır? 
Veritabanı türleri arasında NoSQL (Not Only SQL) terimi, verilerin geleneksel ilişkisel veritabanı sistemlerinden farklı bir şekilde organize edilmesini ifade eder. MongoDB de NoSQL veritabanlarından biridir. MongoDB, özellikle büyük veri, hızlı okuma/yazma gereksinimleri ve esnek veri yapıları arayan projeler için tercih edilir.

### Genel olarak, MongoDB şu tür projelerde yaygın olarak kullanılır:

- Büyük ölçekli web uygulamaları (örneğin, sosyal medya platformları)
- E-ticaret siteleri ve sağlık verisi yönetimi gibi veri çeşitliliği yüksek uygulamalar

## MongoDB’nin Temel Özellikleri
1.Doküman Temelli Yapı
MongoDB, verileri JSON benzeri bir formatta, yani BSON (Binary JSON) olarak depolar. Her bir kayıt, bir doküman olarak kabul edilir. Dokümanlar, anahtar-değer çiftlerinden oluşur ve her biri farklı veri türlerini barındırabilir. Bu, şemayı esnek tutarak veri modelinin zaman içinde değişmesine olanak tanır.

2.Esneklik
İlişkisel veritabanlarında veriler önceden tanımlanmış tablolarda belirli bir yapıda bulunmak zorundadır. MongoDB’de ise her doküman farklı veri türleri içerebilir ve her doküman farklı alanlara sahip olabilir.

3.Yüksek Ölçeklenebilirlik
MongoDB, veri boyutu arttıkça kolayca yatayda ölçeklenebilir. Yani, veritabanını genişletmek için sadece daha fazla sunucu eklemek yeterlidir. Bu, özellikle büyük veri kümeleriyle çalışan uygulamalar için büyük bir avantaj sağlar.

### Bson Nedir? 

BSON (Binary JSON), MongoDB tarafından kullanılan ve JSON (JavaScript Object Notation) formatına benzer, ancak ikili (binary) biçimde depolanan bir veri formatıdır. JSON verilerinin daha hızlı işlenmesi, daha verimli depolanması ve genişletilmesi amacıyla BSON formatı geliştirilmiştir.

BSON'un JSON'dan farkı, veri tipi çeşitliliği, daha kompakt bir format olması ve ikili veri depolama kullanmasıdır. MongoDB, verilerini BSON formatında saklar, ancak MongoDB'ye erişim sağlarken, veriler genellikle JSON formatında görünür. 
BSON'un Özellikleri:
İkili (Binary) Format: BSON, ikili bir veri formatıdır, yani veriler byte dizileri (binary data) olarak depolanır. Bu da JSON’a kıyasla daha hızlı işleme ve daha az yer kaplama avantajı sağlar. 

Daha Fazla Veri Türü Desteği: JSON, yalnızca temel veri türlerini (string, number, boolean, array, object, null) desteklerken, BSON daha fazla veri türünü destekler:
Date: Zaman damgaları (timestamp).
Binary: Ham ikili veriler.
ObjectId: MongoDB’de her dokümanın benzersiz kimliği olarak kullanılan özel bir tür.
Regular Expressions: Düzenli ifadeler (regex).
Decimal128: Yüksek hassasiyetli sayılar.
BSON, bu veri türlerini depolamak için daha verimli bir şekilde tasarlanmıştır.

Daha Verimli Depolama: JSON’daki veriler metin tabanlıdır, yani her veri alanı için metin yazılır. BSON ise bu verileri binary formatında depolar, bu da depolama alanından tasarruf sağlar.

Hiyerarşik Yapı: BSON, JSON gibi anahtar-değer çiftleri ve dizi (array) yapıları kullanır, ancak veri daha hızlı işlenebilir ve daha karmaşık veri türleri desteklenir.

Yüksek Performans: BSON, daha kompakt bir format sunar ve ikili format kullanarak JSON’a kıyasla daha hızlı bir şekilde veri okuma ve yazma işlemleri gerçekleştirir.
BSON ve JSON Karşılaştırması:
Özellik	JSON	BSON
Format	Metin tabanlı (text-based)	İkili format (binary)
Veri Türleri	String, number, array, object, boolean, null	Daha fazla veri türü (Date, ObjectId, binary, Decimal128 vb.)
Depolama	İnsan tarafından okunabilir, daha fazla yer kaplar	Daha kompakt, hızlı işleme ve depolama sağlar
Performans	Yavaş okuma/yazma (daha büyük veri ile)	Daha hızlı okuma/yazma, daha az bellek kullanımı
Veri Türü Esnekliği	Kısıtlı türler ve esneklik	Daha fazla esneklik ve veri türü desteği 

## - MongoDb .Net Core EntityFramework Orm ile kullanılması  
Benimde bu projecede kullandığım .Net Core Entityframework ile geliştirmiş bulunmaktayım. Mongodbnin .netCore 7.0 altında sürümleri için bu kütüphane bulunmamaktadır o yüzden efcore un nimetlerinden yararlanmak  için projemi 7.0 ile projemi geliştirdim. 
Yüklediğim MongoDb Kütüphaneleri; 
1. MongoDB.Driver(2.22.0)
 -MongoDB ile etkileşim kurmak ve CRUD işlemlerini gerçekleştirmek için en temel kütüphanedir. Bu kütüphane, MongoDB veritabanlarıyla bağlantı kurmanıza, veri eklemenize, okumanıza, güncellemenize ve silmenize olanak tanır
2.MongoDB.Bson(2.22.0)
- MongoDB.Bson, MongoDB’nin BSON (Binary JSON) formatını işleyebilmek için kullanılan kütüphanedir. BSON, MongoDB'nin veritabanında kullandığı veri formatıdır ve MongoDB.Driver bu kütüphaneye dayanır.


3.MongoDB.EntityFrameworkCore(7.0) EfCore nimetlerinden faydalanmak için :)
- ** Dip Not Önemli=  MongoDb.driver ve Mongodb.Bson kütüphanelerini eklerken last Version Install olarak eklemiştim o yüzden bu iki kütüphaneyi en son sürüm olarak indirmişti  o yüzden Viewsda çalıştırdığımda  hata olarak Unnable to Connect to web server 'https' the web server is no langer running hatasını verdi  sonra  program cs de hata aldım  hatanın çözümü ise MongoDb.Bson(2.22.0) MongoDb.Driver(2.22.0) olarak versiyonlarını güncelledim. **
## Projede Repository Desing Patern kullanıldı.
## - Entity Katmanı (Class Libary)
ObjectId, MongoDB'nin her bir doküman (document) için otomatik olarak atadığı benzersiz bir kimlik (ID) türüdür. MongoDB'nin varsayılan anahtar olarak kullandığı bu tür, her bir veri kaydının benzersiz bir şekilde tanımlanmasını sağlar. ObjectId, genellikle MongoDB veritabanlarında _id alanı olarak saklanır.
MongoDb.BSON Kütüphanesi eklendi.
![Ekran Görüntüsü (235)](https://github.com/user-attachments/assets/d0ce7835-5b9c-4132-9ab9-4f7d8fa8b900)
Burada Her sınıfımda ObjectId kullanacağı için BaseEntity Sınıfını oluşturdum. ve Diğer sınıflarım BaseEntity sınıfından miras aldı.
Sınıflarımı bu katmanda yazmış oldum.
## - DataAcsessLayer katmanı (Class Libary) 
Burada Mongodb Veri tabanımıza bağlantı ayarlarını girmek için gerekli kodları yazacağız . 
Context klasörü oluşturup içine VillaContext isimli sınıfımızı oluşturuyoruz. 
Entity katmanımızı DataAcsessLayer Katmanımıza Refans veriyoruz.
DataAcsess Katmanımıza Manege Nuget Packages'dan MongoDb.EntityFrameWrokCore Kütüphanemizi indiriyoruz.
![Ekran Görüntüsü (234)](https://github.com/user-attachments/assets/a29dc54c-acc5-4295-b079-defd10e28281)
** Burada Dikkat Edilmesi gereken husus İnculude prealase kutucu işaretli olacak yoksa 7.0 sürümü gelmiyecektir (resimdeki mavi kutuyla işaretledim.) 
EntityFrameWork kütüphanemizi indiriyoruz. **
ve contex içine  veri tabımıza yansyıacak olan tablo isimlerimizi yazıyoruz. 
![Ekran Görüntüsü (236)](https://github.com/user-attachments/assets/14a35586-c43b-4bce-89ef-bb1f16bdbc63)
- DbSet<T> her bir veritabanı tablosunu temsil eder. Buradaki her DbSet, belirli bir entity (veri modeli) türünü temsil eder ve bu sayede tablodaki verilere erişim sağlanır.
- Örneğin: public DbSet<Banner> Banners { get; set; } ile Banners tablosuna karşılık gelen Banner türündeki verilere erişim sağlanır.

- OnModelCreating Metodu:Bu metod, model yapılandırması için kullanılır. Yani, veritabanı şemasının nasıl olacağına dair ek ayarlamalar yapılır.
- Örneğin: modelBuilder.Entity<Banner>().ToCollection("Banners"); komutu, Banner entity'sinin veritabanındaki tablonun adını "Banners" olarak belirler.

## - Veri tabanı Ayarı 
WebUI katmanımızdaki Appsettings.json dosyasına gidelim.  

![Ekran Görüntüsü (237)](https://github.com/user-attachments/assets/c8aa6a43-37cf-4164-a17a-83bb40e1bca5)
Bağlantı adresimizi ve veritabanımızın ismini verelim. 
![Ekran Görüntüsü (238)](https://github.com/user-attachments/assets/a62d2102-0aaa-453d-be24-6781d79bae29)
WEBUI program.cs dosyasına MongoDb nin gerekli configlerini bu şekilde yazıyoruz. 

############ Villa Project ############ 
Bu Proje MongoDb veri tabanı kullanılmıştır. .Net CORE 7.0 Kullanıp ORM olarak EntityFrameWrok kullanılmıştır. Bu projenin bir adet Admin proje sayfası olup WebUI kısmını kontrol edebilmektedir. 

## - Kullanılan teknolojiler  

1️⃣ AutoMapper
🔄 Nesne Dönüşümü (Mapping) 
Kullanım Alanı: Nesneleri kolayca dönüştürmek ve tekrar tekrar yazmaktan kaçınmak. 

2️⃣ .NET Core 7.0 

3️⃣ ASP.NET Identity
🔐 Kullanıcı Kimlik Doğrulama & Yetkilendirme

4️⃣ MongoDB
📚 NoSQL Veritabanı 
## - Projeye Ait Görseller 
## Admin Sayfası-Satılık ilanlar Listesi- Silme İşlemi SweetAlert Kullanımı - İlan Detayı 
![Ekran Görüntüsü (239)](https://github.com/user-attachments/assets/69810a6f-6e97-4a7b-8d3a-603a7b1eab2a)
![Ekran Görüntüsü (241)](https://github.com/user-attachments/assets/bd6b9f96-f764-46a0-acec-e99f8aaffd1d)
![Ekran Görüntüsü (243)](https://github.com/user-attachments/assets/94cd6b48-2a04-4b71-b621-ce0afb92c51d) 
-WEB UI Sayfası Görseller 
![Ekran Görüntüsü (245)](https://github.com/user-attachments/assets/2334765c-133b-4ab2-8e18-2044bfa73df1)
![Ekran Görüntüsü (246)](https://github.com/user-attachments/assets/106e8a7b-3766-4da8-b1d9-c5d5afe586cc)
![Ekran Görüntüsü (247)](https://github.com/user-attachments/assets/19d2d337-6dfb-48e2-ab8b-d593a257f7da)
![Ekran Görüntüsü (248)](https://github.com/user-attachments/assets/ffbfdea0-0de2-464b-8729-8988e213e173)
![Ekran Görüntüsü (249)](https://github.com/user-attachments/assets/fa24a724-4de1-4bef-8234-d3ca1b5366c5)
![Ekran Görüntüsü (250)](https://github.com/user-attachments/assets/394f6921-46e6-4c24-b036-549ff056a113)

## MongoDb 
![Ekran Görüntüsü (252)](https://github.com/user-attachments/assets/e52df141-570f-45af-a864-9657dd5ded26)
