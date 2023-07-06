using Infrastructure.Data.Postgres.Entities;

namespace Business.Models.Request.Functional;

public class RegisterDto
{
    public string Email { get; set; } = default!;
    public string UserName { get; set; } = default!;
    public string Password { get; set; } = default!;

    public string user_surname { get; set; } = default!;
    public string user_bdate { get; set; } = default!;
    public string user_adress { get; set; } = default!;
    public char[] user_sex { get; set; } = default!;
    public string user_gsm { get; set; } = default!;
    public bool animal_history { get; set; }
    public bool animal_exist { get; set; }
    public UserType UserType { get; set; }

}