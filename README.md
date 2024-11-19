# MongoDB Nedir? Temel Bilgiler ve Kullanım Alanları 
MongoDB, modern veri yönetimi için tasarlanmış, açık kaynaklı ve NoSQL bir veritabanıdır. Geleneksel ilişkisel veritabanlarının sunduğu tablo ve satır yapılarını terk eder ve verileri dokümanlar şeklinde depolar. Bu, daha esnek ve ölçeklenebilir bir veri yapısı sağlar. Peki, MongoDB'yi diğer veritabanlarından ayıran özellikler nelerdir? Hadi birlikte keşfedelim. 
## NoSQL Nedir? MongoDB Nerede Kullanılır? 
Veritabanı türleri arasında NoSQL (Not Only SQL) terimi, verilerin geleneksel ilişkisel veritabanı sistemlerinden farklı bir şekilde organize edilmesini ifade eder. MongoDB de NoSQL veritabanlarından biridir. MongoDB, özellikle büyük veri, hızlı okuma/yazma gereksinimleri ve esnek veri yapıları arayan projeler için tercih edilir.

### Genel olarak, MongoDB şu tür projelerde yaygın olarak kullanılır:

- Büyük ölçekli web uygulamaları (örneğin, sosyal medya platformları)
- E-ticaret siteleri ve sağlık verisi yönetimi gibi veri çeşitliliği yüksek uygulamalar
- IoT uygulamaları, log verisi yönetimi ve gerçek zamanlı analizler

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
