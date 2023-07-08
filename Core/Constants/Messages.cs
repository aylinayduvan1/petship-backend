namespace Core.Constants;

public static class Messages
{
    // META
    public const string YouCantDoThat = "Bu işlemi yapamazsınız";
    public const string Success = "İşlem başarıyla tamamlandı";
    public const string NotFound = "Kayıt bulunamadı";
    public const string Error = "Hata alındı";

    // AUTH SERVICE
    public const string RefreshTokenNotValid = "Refresh token geçerli değil";
    public const string EmailAlreadyTaken = "Bu email zaten alınmış";
    public const string UserNameAlreadyTaken = "Bu kullanıcı adı aaten alınmış";
    public const string PasswordWrong = "Kullanıcı adı veya şifre yanlış";
    public const string AdressWrong = "Adress  yanlış";
    public const string UserNameOrPasswordWrong = "Kullanıcı adı veya şifre yanlış";
    public const string BdtaWrong = "Doğum tarihi yanlış";
    public const string GsmWrong = "Numara yanlış";
    public const string UsernameWrong = "kullanıcı adı hatalı";
    public const string SexWrong = "cinsiyeti k ve e şeklinde giriniz..";
    public const string animalExistwrong = "hayvan varlığı hatalı mı ...";
    public const string animalHistoryWrong = "hayvan geçmişi hatalı..";

    // SUCCESS
    public const string SuccessfullyCreatedEntity = "Kayıt başarıyla oluşturuldu";
    public const string SuccessfullyUpdatedEntity = "Kayıt başarıyla güncellendi";
    public const string SuccessfullyDeletedEntity = "Kayıt başarıyla silindi";

    //FILE UPLOAD
    public const string InvalidFileFormat = "Geçersiz dosya türü";
}