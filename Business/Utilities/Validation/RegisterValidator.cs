using Business.Models.Request.Functional;
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
        RuleFor(x => x.user_bdate).NotEmpty().WithName("Doğum Günü").MinimumLength(1);



        //RuleFor(x => x.user_bdate)
        //.NotEmpty().WithMessage("Doğum tarihi boş olamaz.")
        //.Must(x => DateTime.TryParseExact(x, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
        //.WithMessage("Geçersiz doğum tarihi formatı.")
        //.WithName("user_bdate");


        RuleFor(x => x.user_gsm).NotEmpty().WithName("Telefon Numarası").MinimumLength(8);

        RuleFor(x => x.user_sex).NotNull().WithName("user_sex");

        RuleFor(x => x.animal_history)
            .NotNull()
            .WithName( "animal_history");

        RuleFor(x => x.animal_exist)
            .NotNull()
            .WithName("animal_exist");




    }
}