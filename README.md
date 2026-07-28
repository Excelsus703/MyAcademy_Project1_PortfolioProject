# MyAcademy_PortfolioProject | ASP.NET Core MVC

Kişisel portfolyo sitesi ve bu siteyi yönetmek için geliştirilen, tam yetkili bir Admin Panelinden oluşan full-stack bir web uygulaması. Proje, tek sayfalık (Single-Page Layout) bir ön yüz ile modüler ve dinamik bir yönetim panelini bir araya getiriyor.
Bu projedeki nihai amacım, ASP.NET Core MVC, Entity Framework Core Code-First yaklaşımı, ViewComponent mimarisi ve rol tabanlı kimlik doğrulama konularında edindiğim bilgileri uçtan uca bir uygulamada bir araya getirmek amacıyla geliştirilmiştir.

## 🛠 Teknik Altyapı

- **Framework:** ASP.NET Core 8.0 (MVC)
- **ORM:** Entity Framework Core (Code-First)
- **Veritabanı:** MS SQL Server
- **Mimari:** Tek katmanlı (Single Layer) yapı
- **Front-End:** Tek sayfalık (Single-Page) ön yüz, tüm bölümler ViewComponent'lar ile modüler olarak besleniyor
- **Kimlik Doğrulama:** Forms Authentication

## 📦 Veri Modeli

Proje aşağıdaki entity'ler üzerine kuruldu:

`About`, `Admin`, `Banner`, `ContactInfo`, `Education`, `Experience`, `Project`, `ProjectTechStack`, `Service`, `Skill`, `TechStack`, `Testimonial`, `UserMessage`

`ProjectTechStack`, `Project` ve `TechStack` arasında çoktan-çoğa (many-to-many) ilişkiyi yöneten bir ara tablo olarak tasarlandı.

## ✨ Özellikler

### 🎨 Dinamik Ön Yüz
- Tüm site tek bir sayfa (Single-Page Layout) üzerinde kurgulandı.
- Hakkımda, İletişim Bilgisi, Deneyimler, Projeler gibi her bölüm, kendi verisini veritabanından bağımsız olarak çeken ayrı bir **ViewComponent** üzerinden besleniyor
- hazır bir template yerine Stitch (AI destekli tasarım aracı) ile sıfırdan tasarlandı.

### 🔐 Admin Paneli & Kimlik Doğrulama
- Admin paneline yalnızca yetkili kullanıcılar erişebiliyor.
- Login ekranı, hazır bir template yerine Stitch (AI destekli tasarım aracı) ile sıfırdan tasarlandı.
- Giriş yapan kullanıcı, istatistiklerin yer aldığı bir **Dashboard**'a yönlendiriliyor:
  - Toplam proje, deneyim ve gelen mesaj sayısı gibi özet istatistikler
  - Son eklenen projelerin yer aldığı hızlı bakış tablosu
- Tüm entity'ler için CRUD işlemleri tamamlandı, sidebar üzerinden ilgili sayfalara yönlendirme ve her modül için uygun ikonlandırma yapıldı.
- Component klasör yapısı ve isimlendirme standartlarına (`_AdminLayoutHeadViewComponent`, `_AdminLayoutSidebarViewComponent` vb.) sadık kalındı.

### 📬 İletişim Formu & Mesaj Yönetimi
- Sitenin iletişim formundan gelen mesajlar (`UserMessage`), Admin panelinde liste halinde görüntüleniyor.
- Bir mesajın detayına girildiği an, veritabanındaki durumu otomatik olarak **"Okundu"** durumuna güncelleniyor.
- Gelen kutusunda **"Okunanlar"** ve **"Okunmayanlar"** için ayrı filtreleme mekanizması bulunuyor, bu sayede mesajlar birbirine karışmıyor.

## 📸 Ekran Görüntüleri

Anasayfa 
---
<img width="1600" height="610" alt="Anasayafa1" src="https://github.com/user-attachments/assets/ecdd80f5-004c-4224-849e-5ddf1ddd9645" />

<img width="1600" height="589" alt="Anasayfa2" src="https://github.com/user-attachments/assets/5353aea9-6c40-45db-8215-b3e7fb8c57ca" />

<img width="1600" height="803" alt="Anasayfa3" src="https://github.com/user-attachments/assets/fb016f35-f60e-4718-b3fe-0002085e33fe" />

<img width="1600" height="463" alt="Anasayfa4" src="https://github.com/user-attachments/assets/f9b2126b-d0b2-426e-812d-8f6380e90cbc" />

<img width="1600" height="462" alt="Anasayfa5" src="https://github.com/user-attachments/assets/fffef378-3cba-4d82-8143-73c6daecefc7" />

<img width="1600" height="802" alt="Login" src="https://github.com/user-attachments/assets/736c2c97-da53-4322-a25b-f52e76195f42" />

<img width="1600" height="805" alt="Admin1" src="https://github.com/user-attachments/assets/b38e102f-92b7-480a-80a5-86306d896d71" />

<img width="1600" height="800" alt="Admin2" src="https://github.com/user-attachments/assets/d3a39619-f1d9-407e-96af-476a30b5efe8" />

<img width="1600" height="800" alt="Admin3" src="https://github.com/user-attachments/assets/e8b29f7e-b66c-49eb-81f0-99e0e0ca986c" />

<img width="1600" height="807" alt="Admin4" src="https://github.com/user-attachments/assets/58d40c5a-cff8-4f53-945a-f5bbae2ad0c7" />

---
