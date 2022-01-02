﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string Added = "Veriler Eklendi";
        public static string Updated = "Veriler Güncellendi";
        public static string Deleted = "Veriler Silindi";
        public static string Listed = "Veriler Listelendi";

        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string RegisterSuccess = "Kayıt Başarılı";
        public static string UserNotFound = "Kullanıcı Bulunamadı";
        public static string PasswordWrong = "Şifre Yanlış";
        public static string LoginSuccess = "Giriş Başarılı";
        public static string UserExists = "Kullanıcı zaten var";
        public static string TokenCreated = "Token Oluşturuldu";

        public static string UserListed = "Kullanıcı Listelendi";
        public static string MaintenanceTime = "Sistem Bakımda";
    }
}
