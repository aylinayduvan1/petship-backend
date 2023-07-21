using Infrastructure.Data.Postgres.Entities;

namespace Business.Models.Request.Functional;

public class RegisterDto
{
    public string Email { get; set; } = default!;
    public string UserName { get; set; } = default!;
    public string Password { get; set; } = default!;

    public string User_surname { get; set; } = default!;
    public string User_bdate { get; set; } = default!;
    public string Adress { get; set; } = default!;
    public string User_sex { get; set; } = default!;
    public string Gsm { get; set; } = default!;
    public bool Animal_history { get; set; }
    public bool Animal_exist { get; set; }
    public UserType UserType { get; set; }

}