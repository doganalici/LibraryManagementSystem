📚 Library Management System 📚

Bu proje, C# Console Application kullanılarak geliştirilmiş basit bir Kütüphane Yönetim Sistemi uygulamasıdır.
Amaç; OOP (Nesne Yönelimli Programlama) prensiplerini kullanarak kitap, üye ve ödünç alma süreçlerini yönetebilmektir.

Proje, öğrenme sürecinde adım adım geliştirilmek üzere tasarlanmıştır.
<hr>

🚀 Projenin Amacı

* OOP kavramlarını (Class, Constructor, Encapsulation, Object ilişkileri) pekiştirmek

* Gerçek hayata yakın bir senaryo üzerinden pratik yapmak

* Console tabanlı bir uygulamada veri yönetimini öğrenmek
<hr>

🧱 Kullanılan Teknolojiler

* C#

* .NET Console Application

* Object Oriented Programming (OOP)
<hr>

🏗️ Proje Yapısı
```
LibraryManagementSystem
│
├── Book.cs
│   - Kitap bilgilerini tutar
│
├── Member.cs
│   - Üye bilgilerini tutar
│
├── BorrowRecord.cs
│   - Kitap ödünç alma ve iade kayıtlarını tutar
│
├── LibraryManager.cs
│   - Kitap, üye ve ödünç işlemlerini yöneten sınıf
│
└── Program.cs
    - Menü ve kullanıcı etkileşimleri
```
<hr>

📘 Sınıflar ve Sorumlulukları<br>
* 📖 Book

  * Kitap bilgilerini tutar

  * Ödünç durumunu kontrol eder

  * Bilgileri ekrana yazdırabilir

* 👤 Member

  * Kütüphane üyelerinin bilgilerini tutar

  * Üye bilgilerini ekrana yazdırabilir

* 🔄 BorrowRecord

  * Kitap–üye ilişkisini temsil eder

  * Ödünç alma tarihi

  * İade durumu ve iade tarihi

  * İade edilip edilmediğine göre detaylı çıktı verir

* 🧠 LibraryManager

  * Kitap ekleme / silme

  * Üye ekleme / silme

  * Kitapları ve üyeleri listeleme

  * (İleride) ödünç alma ve iade işlemleri
<hr>

🧪 Mevcut Özellikler

✔ Kitap oluşturma ve listeleme

✔ Üye oluşturma ve listeleme

✔ Ödünç kayıt yapısı (BorrowRecord)

✔ İade durumuna göre çıktı alma
<hr>

🔜 Planlanan Geliştirmeler

⏳ Kitap ödünç alma işlemi

⏳ Kitap iade etme işlemi

⏳ Aynı kitabın birden fazla kez ödünç alınmasını engelleme

⏳ LINQ kullanılarak filtreleme ve sorgular

⏳ ADO.NET ile veritabanı entegrasyonu

⏳ Hata kontrolleri ve iyileştirmeler
<hr>

📝 Notlar

Bu proje öğrenme amaçlıdır ve zamanla geliştirilecektir.
Kodlar bilinçli olarak sade tutulmuş, anlaşılabilirlik ön planda tutulmuştur.
<hr>

👨‍💻 Geliştirici

Doğan Alıcı<br>
C# öğrenme sürecinde geliştirilmiştir.
