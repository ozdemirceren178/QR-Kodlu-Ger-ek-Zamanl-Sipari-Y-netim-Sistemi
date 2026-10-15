# 🍽️ QR Kodlu Restoran Sipariş ve Yönetim Sistemi

ASP.NET Core teknolojileri kullanılarak geliştirilen bu proje, restoranların ürün ve sepet süreçlerini yönetmeyi ve SignalR ile gerçek zamanlı iletişim sağlamayı amaçlayan bir web uygulamasıdır.

Proje kapsamında RESTful API tüketimi, DTO kullanımı, dinamik arayüz geliştirme ve SignalR tabanlı mesajlaşma uygulamaları geliştirilmiştir.

## 🚀 Özellikler

- **Ürün ve Menü Yönetimi:** API üzerinden alınan ürünlerin ad, açıklama, görsel ve fiyat bilgileriyle listelenmesi.
- **Sepet Yönetimi:** Ürünleri sepete ekleme, sepet içeriğini görüntüleme ve ürünleri sepetten silme.
- **Tutar Hesaplama:** Sepet toplamının ve vergi eklenmiş tutarın hesaplanması.
- **Gerçek Zamanlı Mesajlaşma:** SignalR ile mesajların sunucu üzerinden iletilmesi ve istemci arayüzünde görüntülenmesi.
- **RESTful API Entegrasyonu:** `IHttpClientFactory` kullanılarak API servislerinden veri alınması.
- **DTO Kullanımı:** API'den gelen ürün ve sepet verilerinin DTO nesneleriyle işlenmesi.
- **Dinamik Arayüz:** ASP.NET Core MVC, Razor View, JavaScript, jQuery ve AJAX kullanımı.

## 🛠️ Kullanılan Teknolojiler

| Teknoloji | Kullanım Amacı |
|---|---|
| C# | Backend geliştirme |
| ASP.NET Core MVC | Web arayüzü ve MVC yapısı |
| ASP.NET Core Web API | HTTP üzerinden veri sunumu |
| SignalR | Gerçek zamanlı istemci-sunucu iletişimi |
| Entity Framework Core | Veritabanı işlemleri |
| Microsoft SQL Server | İlişkisel veritabanı |
| DTO | Veri transferi |
| IHttpClientFactory | API servislerini tüketme |
| JavaScript & jQuery | İstemci tarafı işlemler |
| AJAX | Asenkron HTTP istekleri |
| HTML5 & CSS3 | Sayfa yapısı ve stillendirme |
| Bootstrap | Responsive arayüz geliştirme |

## 🏗️ Teknik Mimari

### API Entegrasyonu

`IHttpClientFactory` aracılığıyla API servislerine HTTP istekleri gönderilir. Örneğin, ürün listesi `GET /api/Product` endpoint'i üzerinden alınır ve JSON formatındaki yanıt `ResultProductDto` nesnelerine dönüştürülerek arayüzde görüntülenir.

### SignalR ile Gerçek Zamanlı İletişim

SignalR istemcisi, sunucudaki Hub bağlantısını `HubConnectionBuilder` ile oluşturur.

Mesajlaşma sürecinde:

1. `connection.start()` ile bağlantı başlatılır.
2. `connection.on("ReceiveMessage", ...)` ile sunucudan gelen mesajlar dinlenir.
3. `connection.invoke("SendMessage", user, message)` ile mesaj sunucuya iletilir.
4. Gelen mesajlar kullanıcı adı ve saat bilgisiyle mesaj listesine eklenir.
5. Bağlantı kurulana kadar gönderme butonu devre dışı tutulur.

Bu yapı, mesajların sayfa yenilemesi gerektirmeden istemci tarafında görüntülenmesini sağlar.

### Sepet İşlemleri

Ürünler AJAX isteği aracılığıyla sepet işlemini gerçekleştiren MVC action'ına gönderilir. Sepet sayfasında ürün adı, adet, fiyat ve toplam fiyat bilgileri listelenir. Ayrıca sepet toplamı ve vergi eklenmiş tutar hesaplanır.


 
**Ana Sayfa ve Menü**

<img width="700" alt="image" src="https://github.com/user-attachments/assets/8a5362f2-8292-4f1c-b026-71932dc5e481" />

**Sepet Yönetimi**

<img width="700" alt="Ekran görüntüsü 2026-10-07 221203" src="https://github.com/user-attachments/assets/1bac70a7-78f4-4827-9484-6d7f1b52f403" />

**İstatistikler**

<img width="700"  alt="dashboard" src="https://github.com/user-attachments/assets/bade2a86-786a-4ae2-9fa2-3b562a281e79" />

**Gerçek Zamanlı Mesajlaşma**

<img width="700"  alt="anlık mesaj29" src="https://github.com/user-attachments/assets/0093770c-6867-4c7e-ae51-1b35a3dbda4b" />

**QR CODE**

<img width="300" alt="qr" src="https://github.com/user-attachments/assets/9d75f2ea-a11e-421a-a343-9b72fd4f37c9" />


