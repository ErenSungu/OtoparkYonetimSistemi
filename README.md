# 🚗 Otopark Yönetim Sistemi

![License](https://img.shields.io/badge/Lisans-MIT-green)
![Language](https://img.shields.io/badge/Dil-C%23-blue)
![Database](https://img.shields.io/badge/Veri%20Taban%C4%B1-MSSQL-red)
![Platform](https://img.shields.io/badge/Platform-Windows%20Forms-lightgrey)

**Geliştirici:** Eren Süngü

Bu proje, araç giriş-çıkışlarını, müşteri ilişkilerini ve finansal süreçleri yöneten kapsamlı bir masaüstü otomasyon uygulamasıdır.

📄 **Proje Dokümantasyonu:** [Dokümantasyonu İndir](OtoparkYonetimSistemiProjeDokumantasyonu.pdf)

---

## 🚀 Proje Özellikleri

Proje, otopark işletmesinin tüm ihtiyaçlarını karşılayacak modüllerden oluşmaktadır:

### 1. 🅿️ Araç ve Park Yönetimi
* **Giriş/Çıkış:** Araçların plaka, model, renk ve müşteri bilgileriyle kaydı.
* **Otomatik Ücretlendirme:** İçeride kalınan süreye (saat) göre otomatik ücret hesaplama.
* **Durum Takibi:** Park alanındaki mevcut araçların ve geçmiş kayıtların listelenmesi.

### 2. 🏷️ Fiyatlandırma ve Kampanya Yönetimi
* **Kampanya Oluşturma:** Belirli tarih aralıklarında geçerli olacak, istenilen araç türüne özel indirim kampanyaları tanımlama.
* **Kampanya Kontrolü:** Oluşturulan kampanyaları manuel olarak aktif veya pasif duruma getirme.
* **Tarifeler:** Araç türlerine göre (Otomobil, Kamyon vb.) farklı saatlik ücret tarifeleri belirleme ve güncelleme.

### 3. 👥 Müşteri İlişkileri Modülü
* **Üyelik Sistemi:** Müşteri kaydı, güncelleme ve üyelik dondurma işlemleri.
* **Ceza Yönetimi:** Kurallara uymayan müşterilere ceza tanımlama (Sebep, Tutar, Bitiş Tarihi) ve ödeme takibi.
* **Destek Sistemi:** Müşteri talep ve şikayetlerine yanıt verme, talep durumunu (Açık/Kapalı) yönetme.

### 4. 👔 İnsan Kaynakları (Personel)
* **Personel İşlemleri:** İşe alım, kayıt oluşturma ve işten çıkarma süreçleri.
* **Kariyer Yönetimi:** Pozisyon değiştirme, maaş güncelleme ve performans takibi.
* **Personel Listesi:** Aktif ve eski çalışanların filtrelenerek görüntülenmesi.

### 5. 💰 Finansal Yönetim ve Raporlama
* **Gelir Analizi:** Belirli tarihler arasındaki otopark ve ceza gelirlerinin ayrı ayrı hesaplanması.
* **Maaş Zam Sistemi:** Personele toplu (% oran ile) veya bireysel zam yapabilme özelliği.
* **Gider Takibi:** Toplam personel maliyetlerinin ve ödenmemiş cezaların raporlanması.

---

## 🛠️ Kurulum ve Çalıştırma

Projenin veri tabanı bağlantısı gerektirdiği için lütfen aşağıdaki adımları izleyin:

1.  **Projeyi İndirin:** Bu depoyu (repository) bilgisayarınıza klonlayın veya ZIP olarak indirin.
2.  **Veri Tabanını Oluşturun:**
    * Proje dosyaları içindeki `OtoparkYonetimSistemiScript.sql` dosyasını indirin.
    * SQL Server Management Studio (SSMS) uygulamasını açın.
    * Script dosyasını içine sürükleyip **Execute (F5)** tuşuna basın. Veri tabanı ve tablolar otomatik oluşacaktır.
3.  **Bağlantı Ayarı:**
    * Visual Studio'da projeyi açın.
    * `App.config` dosyasındaki veya bağlantı sınıfındaki `Data Source` kısmını kendi bilgisayar adınıza göre güncelleyin.
4.  **Başlatın:** Projeyi derleyin ve çalıştırın.

---

## 💻 Kullanılan Teknolojiler (Tech Stack)

* **Programlama Dili:** C# (.NET Framework)
* **Veri Tabanı:** Microsoft SQL Server (MSSQL)
* **Veri Erişimi:** ADO.NET / Stored Procedures
* **Arayüz:** Windows Forms (WinForms)

---

## 📞 İletişim

Herhangi bir soru veya öneriniz için benimle iletişime geçebilirsiniz.
* **GitHub:** [ErenSungu](https://github.com/ErenSungu)
* **LinkedIn:** [ErenSungu](https://linkedin.com/in/erensungu/)
