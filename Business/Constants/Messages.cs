using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductsListed = "Ürünler Listelendi";
        
        public static string ProductNameAlreadyExists = "Bu isimde zaten başka bir ürün var";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";

        public static string CategoryLimitExceded = "Kategori limiti aşıldığı için yeni ürün eklenemiyor";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün olabilir";

        public static string UserRegistered= "Kullanıcı başarıyla kaydedildi";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Sisteme giriş başarılı";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu";

        public static string MaintenanceTime = "Sistem bakımda";
        public static string AuthorizationDenied = "Yetkiniz yok";
    }
}
