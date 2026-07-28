# MyAcademy_PortfolioProject | ASP.NET Core MVC

Kişisel portfolyo sitesi ve bu siteyi yönetmek için geliştirilen, tam yetkili bir Admin Panelinden oluşan full-stack bir web uygulaması. Proje, tek sayfalık (Single-Page Layout) bir ön yüz ile modüler ve dinamik bir yönetim panelini bir araya getiriyor.

## 🛠 Teknik Altyapı

- **Framework:** ASP.NET Core 8.0 (MVC)
- **ORM:** Entity Framework Core (Code-First)
- **Veritabanı:** MS SQL Server
- **Mimari:** Tek katmanlı (Single Layer) yapı
- **Front-End:** Tek sayfalık (Single-Page) ön yüz, tüm bölümler ViewComponent'lar ile modüler olarak besleniyor
- **Kimlik Doğrulama:** Forms Authentication + Rol tabanlı yetkilendirme (Role-Based Authorization)

## 📦 Veri Modeli

Proje aşağıdaki entity'ler üzerine kuruldu:

`About`, `Admin`, `Banner`, `ContactInfo`, `Education`, `Experience`, `Project`, `ProjectTechStack`, `Service`, `Skill`, `TechStack`, `Testimonial`, `UserMessage`

`ProjectTechStack`, `Project` ve `TechStack` arasında çoktan-çoğa (many-to-many) ilişkiyi yöneten bir ara tablo olarak tasarlandı.

## ✨ Özellikler

### 🎨 Dinamik Ön Yüz
- Tüm site tek bir sayfa (Single-Page Layout) üzerinde kurgulandı.
- Hakkımda, İletişim Bilgisi, Deneyimler, Projeler gibi her bölüm, kendi verisini veritabanından bağımsız olarak çeken ayrı bir **ViewComponent** üzerinden besleniyor (`_DefaultAboutViewComponent`, `_DefaultContactInfoViewComponent`, `_DefaultUserMessageViewComponent` vb.)
- Proje kartlarında kullanılan teknolojiler, `Project` → `ProjectTechStack` → `TechStack` ilişkisi üzerinden `Include`/`ThenInclude` ile Eager Loading kullanılarak tek sorguda getirildi.

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

## 🧱 Mimari Notlar

- Controller'lar mümkün olduğunca ince (thin) tutuldu; sorgu mantığı doğrudan action içinde değil, ayrıştırılmış ve okunabilir şekilde organize edildi.
- Veritabanı sorgularında performansı gözeterek, sayım işlemleri `CountAsync()` ile veritabanı seviyesinde yapıldı; gereksiz yere tüm veri belleğe çekilmedi.
- İlişkili veriler ihtiyaç duyulan yerlerde `Include`/`ThenInclude` (Eager Loading) ile tek sorguda getirilerek N+1 query probleminden kaçınıldı.

## 🚀 Kurulum

```bash
git clone <repo-url>
cd <proje-klasörü>
dotnet restore
```

`appsettings.json` içindeki connection string'i kendi SQL Server bağlantına göre güncelle, ardından migration'ları uygula:

```bash
dotnet ef database update
```

Projeyi çalıştır:

```bash
dotnet run
```

## 📸 Ekran Görüntüleri

*(Buraya ön yüz ve admin panel ekran görüntülerini ekleyebilirsin)*

---

Bu proje, ASP.NET Core MVC, Entity Framework Core Code-First yaklaşımı, ViewComponent mimarisi ve rol tabanlı kimlik doğrulama konularında edindiğim bilgileri uçtan uca bir uygulamada bir araya getirmek amacıyla geliştirilmiştir.
