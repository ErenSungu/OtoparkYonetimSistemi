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
* [cite_start]**Giriş/Çıkış:** Araçların plaka, model, renk ve müşteri bilgileriyle kaydı [cite: 17-18].
* [cite_start]**Otomatik Ücretlendirme:** İçeride kalınan süreye (saat) göre otomatik ücret hesaplama [cite: 17-18].
* [cite_start]**Durum Takibi:** Park alanındaki mevcut araçların ve geçmiş kayıtların listelenmesi[cite: 20].

### 2. 🏷️ Fiyatlandırma ve Kampanya Yönetimi
* [cite_start]**Kampanya Oluşturma:** Belirli tarih aralıklarında geçerli olacak, istenilen araç türüne özel indirim kampanyaları tanımlama[cite: 50].
* [cite_start]**Kampanya Kontrolü:** Oluşturulan kampanyaları manuel olarak aktif veya pasif duruma getirme[cite: 51].
* [cite_start]**Tarifeler:** Araç türlerine göre (Otomobil, Kamyon vb.) farklı saatlik ücret tarifeleri belirleme ve güncelleme[cite: 48].

### 3. 👥 Müşteri İlişkileri Modülü
* [cite_start]**Üyelik Sistemi:** Müşteri kaydı, güncelleme ve üyelik dondurma işlemleri [cite: 22-23].
* [cite_start]**Ceza Yönetimi:** Kurallara uymayan müşterilere ceza tanımlama (Sebep, Tutar, Bitiş Tarihi) ve ödeme takibi [cite: 27-29].
* [cite_start]**Destek Sistemi:** Müşteri talep ve şikayetlerine yanıt verme, talep durumunu (Açık/Kapalı) yönetme [cite: 31-34].

### 4. 👔 İnsan Kaynakları (Personel)
* [cite_start]**Personel İşlemleri:** İşe alım, kayıt oluşturma ve işten çıkarma süreçleri[cite: 37, 40].
* [cite_start]**Kariyer Yönetimi:** Pozisyon değiştirme, maaş güncelleme ve performans takibi[cite: 39].
* [cite_start]**Personel Listesi:** Aktif ve eski çalışanların filtrelenerek görüntülenmesi[cite: 41].

### 5. 💰 Finansal Yönetim ve Raporlama
* [cite_start]**Gelir Analizi:** Belirli tarihler arasındaki otopark ve ceza gelirlerinin ayrı ayrı hesaplanması [cite: 54-55].
* [cite_start]**Maaş Zam Sistemi:** Personele toplu (% oran ile) veya bireysel zam yapabilme özelliği [cite: 56-57].
* [cite_start]**Gider Takibi:** Toplam personel maliyetlerinin ve ödenmemiş cezaların raporlanması [cite: 59-60].

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
