**Kullanılan Teknolojiler:**
- .Net 7 MVC
- JavaScript, CSS ve HTML
- MSSQL

**Uygulama Hakkında:**
- Clean Architecture yapısı kullanıldı.
- Uygulama açılışında Dummy veriler (Room, Table, Seat ve User) otomatik oluşturulur. Swagger ile yeni veriler eklenebilir.
  **Kullanıcılar:**
    - Kullanıcı Adı: Deneme Şifre: Deneme
    - Kullanıcı Adı: Deneme1 Şifre: Deneme1
- Giriş işlemleri için basit bir Session yapısı kuruldu.
- Rezervasyon işlemlerinde kütüphanenin açık olma ve aynı kullanıcının daha önce 2 kez rezervasyon yapma durumu kontrol edilmektedir.
- SignalR kütüphanesi dahil edilerek tüm istemcilerde senkronize bir şekilde işlemlerin yapılabilmesi sağlandı. Bir yerde yapılan rezervasyon veya iptal işlemi diğer istemcilere yansımaktadır.
