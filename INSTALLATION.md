# Kurulum Rehberi

## Sistem Gereksinimleri
- Unity 2021 veya üzeri
- Android Studio (APK için)
- ARCore destekli Android cihaz (AR için)
- Minimum 2GB RAM

## Kurulum Adımları
1. Bu repository'yi bilgisayarınıza klonlayın:
   ```
   git clone https://github.com/kullaniciadi/proje-adi.git
   ```
2. Unity ile açın.
3. Gerekli paketler otomatik yüklenecektir. Eksik olursa:
   - Window > Package Manager > Gerekli paketleri yükleyin (AR Foundation, TextMesh Pro, vs.)
4. Build Settings > Platform: Android olarak ayarlayın.
5. APK oluşturmak için Build alın.

## Troubleshooting
- **Build Hatası:** Unity versiyonunu ve paketleri kontrol edin.
- **AR Çalışmıyor:** Cihazınızın ARCore desteklediğinden emin olun.
- **APK Yüklenmiyor:** Güvenlik ayarlarını ve cihaz uyumluluğunu kontrol edin.

Daha fazla yardım için lütfen [USER_MANUAL.md](USER_MANUAL.md) dosyasına bakınız. 