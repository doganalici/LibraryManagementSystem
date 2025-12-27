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

  * Constructor ile güvenli nesne oluşturma

  * Ödünç verilip verilmediğini takip eder (IsBorrowed)

  * Bilgileri ekrana yazdıran DisplayInfo() metoduna sahiptir

* 👤 Member

  * Üye bilgilerini tutar

  * Constructor ile oluşturulur

  * Üye detaylarını gösteren DisplayInfo() metodu vardır

* 🔄 BorrowRecord

  * Kitap–üye ilişkisini temsil eder

  * Ödünç alma tarihi tutulur

  * İade edilene kadar IsReturned = false

  * İade edildiğinde:

    * İade tarihi atanır

    * Ekranda duruma göre farklı bilgi yazdırır

* 🧠 LibraryManager

  * Şu işlemleri yönetir:

  ✔ Kitap ekleme — aynı ID’ye izin vermez<br>
  ✔ Kitap silme<br>
  ✔ Kitap listeleme<br>

  ✔ Üye ekleme — aynı ID’ye izin vermez<br>
  ✔ Üye silme<br>
  ✔ Üye listeleme<br>
 
  ✔ Kitap ekleme / silme<br>
  ✔ Üye ekleme / silme<br>
  ✔ Kitapları ve üyeleri listeleme<br>
  ✔ Kitap ödünç verme<br>
  ✔ Kitap iade etme<br>
  ✔ Ödünç geçmişi görüntüleme<br>
<hr>

🧪 Mevcut Özellikler

  ✔ Kitap oluşturma<br>
  ✔ Kitap listeleme<br>
  ✔ Kitap silme<br>

  ✔ Üye oluşturma<br>
  ✔ Üye listeleme<br>
  ✔ Üye silme<br>

  ✔ Kitap silme<br>
  ✔ Üye silme<br>
  ✔ Kitap ödünç verme<br>
  ✔ Kitap iade etme<br>
  ✔ Ödünç geçmişini listeleme<br>

  ✔ Ödünç kayıt yapısı (BorrowRecord)<br>
  ✔ İade durumuna göre çıktı alma<br>
<hr>

🎛️ Uygulama Menüsü
Program açıldığında şu menü ile işlem yapılır:

1 - Kitap Ekle<br>
2 - Kitap Sil<br>
3 - Kitapları Listele<br>
4 - Üye Ekle<br>
5 - Üye Sil<br>
6 - Üyeleri Listele<br>
7 - Kitap Ödünç Ver<br>
8 - Kitap İade Et<br>
9 - Ödünç Geçmişi<br>
0 - Çıkış<br>

--> Her seçenek, LibraryManager içindeki ilgili metodu çalıştırır.
<hr>

🔜 Planlanan Geliştirmeler

    ⏳ Ödünç alınan kitaplar için süre takibi<br>

    ⏳ Geciken kitaplar için uyarı sistemi<br>
 
    ⏳ Daha gelişmiş arama & filtreleme (LINQ)<br>

    ⏳ Veritabanı kaydı (ADO.NET)<br>
<hr>

```
+------------------+          +------------------+
|      Book        |          |      Member      |
+------------------+          +------------------+
| Id               |          | Id              |
| Title            |          | FirstName       |
| Author           |          | LastName        |
| Category         |          | PhoneNumber     |
| IsBorrowed       |          +------------------+
+------------------+          | DisplayInfo()   |
| DisplayInfo()    |          +------------------+
+------------------+


              1                1
Book -------------------- BorrowRecord -------------------- Member
             (Book)                          (Member)
                         |
                         | 0..1
                         |
                         v
                     ReturnDate


+---------------------------+
|       BorrowRecord        |
+---------------------------+
| Id                        |
| BorrowDate                |
| ReturnDate (nullable)     |
| IsReturned                |
+---------------------------+
| DisplayInfo()             |
+---------------------------+


                  1
         +----------------------+
         |    LibraryManager    |
         +----------------------+
         | books : List<Book>   |
         | members : List<Member>|
         | borrowRecords : List<BorrowRecord> |
         +----------------------+
         | AddBook()            |
         | DeleteBook()         |
         | ShowBooks()          |
         | AddMember()          |
         | RemoveMember()       |
         | ShowMembers()        |
         | BorrowBooks()        |
         | ReturnBook()         |
         | BorrowingHistory()   |
         +----------------------+
```

📝 Notlar

Bu proje öğrenme amaçlıdır ve zamanla geliştirilecektir.
Kodlar bilinçli olarak sade tutulmuş, anlaşılabilirlik ön planda tutulmuştur.
<hr>

👨‍💻 Geliştirici

Doğan Alıcı<br>
C# öğrenme sürecinde geliştirilmiştir.
