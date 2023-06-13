using Business.Models.Request;
using FluentValidation;
using System;
using System.Globalization;

namespace Business.Utilities.Validation;

public class RegisterValidator : AbstractValidator<RegisterDto>
{
    public RegisterValidator()
    {
        RuleFor(x => x.Email).NotEmpty().WithName("E-Mail").MinimumLength(8);
        RuleFor(x => x.UserName).NotEmpty().WithName("Kullanıcı Adı");
        //RuleFor(x => x.FullName).NotEmpty().WithName("İsim Soyisim").MinimumLength(5);
        RuleFor(x => x.Password).NotEmpty().WithName("Şifre").MinimumLength(8);
        RuleFor(x => x.user_surname).NotEmpty().WithName("Soyisim").MinimumLength(2);
        RuleFor(x => x.user_adress).NotEmpty().WithName("Adres").MinimumLength(1);
        RuleFor(x => x.user_bdate).NotEmpty().WithName("Adres").MinimumLength(1);



        //RuleFor(x => x.user_bdate)
        //.NotEmpty().WithMessage("Doğum tarihi boş olamaz.")
        //.Must(x => DateTime.TryParseExact(x, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
        //.WithMessage("Geçersiz doğum tarihi formatı.")
        //.WithName("user_bdate");


        RuleFor(x => x.user_gsm).NotEmpty().WithName("Telefon Numarası").MinimumLength(8);


        RuleFor(x => x.user_sex)
        .Must(x => x.Length == 1 && (x[0] == 'k' || x[0] == 'K' || x[0] == 'e' || x[0] == 'E')).WithMessage("Geçersiz cinsiyet değeri.")
        .WithName("Cinsiyet");


        RuleFor(x => x.animal_history)
         .Must(x => x == false || x == true).WithMessage("Geçersiz hayvan geçmişi değeri.")
         .WithName("animal_history");


        RuleFor(x => x.animal_exist)
          .Must(x => x == false || x == true).WithMessage("Geçersiz hayvan varlığı değeri.")
          .WithName("animal_exist");



    }
}