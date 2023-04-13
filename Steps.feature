Feature: Steps

Controls whether expected amount to be paid is equal to real amount to be paid which was calculated by Credit Calculation Tool

@tag1
Scenario: [VakifBank Kredi Hesaplama Araci Testi]
* "https://www.vakifbank.com.tr/" sitesine giriş yapılır.
* “Bireysel” tabına tıklanır
* Açılan menüden “Bireysel Krediler” sekmesine tıklanır.
* “Hesaplama Araçları” linkinin var olduğu kontrol edilir.
* “Hesaplama Araçları” linkine tıklanır.
* "Kredi Hesaplama Aracı" alanıın ekranda yer aldığı kontrol edilir.
* Kredi Hesaplama Aracı alanındaki “Hesapla Butonuna” tıklanır
* Kredi drop box ından “TAKSİTLİ EK HESAP” seçeneği seçilir
* Vade alanına "10" yazılır
* Tutar alanı "200" olarak setli olmalıdır.
* Aynı ekrandaki Hesapla butonuna tıklanır.
* Toplam Ödenecek tutar alanında "212,29" olduğu kontrol edilir