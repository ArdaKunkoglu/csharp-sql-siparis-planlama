# C# ve SQL Server ile Siparis Planlama Uygulamasi

Bu proje, bir üretim tesisinin (örnek olarak ayakkabı/bot üretimi) aldığı siparişlere göre malzeme ihtiyaçlarını, teslimat tarihlerini ve hedeflenen süreye yetişmek için gereken işçi sayısını hesaplayan ve verileri SQL Server üzerinde saklayan bir Windows Forms masaüstü uygulamasıdır.

---

## Ozellikler

* **Dinamik Model Yonetimi:** Sistemde tanımlı ayakkabı modellerini, birim malzeme tüketimlerini ve üretim sürelerini MS SQL Server veri tabanından dinamik olarak çeker.
* **Akilli Is Gucu Hesabi:** Girilen sipariş adedi ve teslim tarihine göre, pazar günlerini hesaba katarak hedeflenen sürede üretimin tamamlanması için gereken minimum çalışan sayısını hesaplar.
* **Malzeme Ihtiyac Analizi:** Sipariş miktarına bağlı olarak gerekli toplam deri (m²), taban, iplik ve etiket miktarlarını otomatik olarak listeler.
* **Veritabanı Kayit Sistemi:** Hesaplanan tüm planlama verilerini, müşteri ve sipariş detaylarıyla birlikte ilişkisel veri tabanına kalıcı olarak kaydeder.

---

## Teknolojiler

* **Dil:** C# (.NET Framework)
* **Arayuz:** Windows Forms
* **Veritabani:** Microsoft SQL Server (ADO.NET)

---

## Kurulum ve Calistirma

### 1. Veritabani Kurulumu
1. SQL Server Management Studio (SSMS) programını açın.
2. Proje klasörü içinde yer alan `.sql` uzantılı veri tabanı yedek dosyasını SSMS ile açın.
3. Kodu çalıştırarak (Execute) `AyakkabiDB` veri tabanını, gerekli tabloları ve hazır model verilerini yerel sisteminize otomatik olarak kurun.

### 2. Proje Ayarlari
1. Proje dosyalarını bilgisayarınıza indirin ve Visual Studio ile `.sln` uzantılı dosyayı açın.
2. `Form1.cs` dosyası içerisindeki `connectionString` alanını kendi SQL Server yerel sunucu adresinize göre güncelleyin:
   ```csharp
   private string connectionString = @"Server=YOUR_SERVER_NAME;Database=AyakkabiDB;Trusted_Connection=True;";
