using Infrastructure.Data.Postgres.Entities;

namespace Business.Models.Response;

public class UserProfileDto
{
    public int Id { get; set; } = default!;
    public string UserName { get; set; } = default!;
    public string User_surname { get; set; } = default!;
    public string User_sex { get; set; } = default!;

    public string User_bdate { get; set; } = default!;

    public bool Animal_history { get; set; } = default!;

    public bool Animal_exist { get; set; } = default!;
    
    public string Gsm { get; set;} = default!;  

    public string Email { get; set; } = default!;
    public UserType UserType { get; set; }
}

