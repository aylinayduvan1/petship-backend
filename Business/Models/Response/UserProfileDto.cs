using Infrastructure.Data.Postgres.Entities;

namespace Business.Models.Response;

public class UserProfileDto
{
    public int Id { get; set; } = default!;
    public string UserName { get; set; } = default!;
    public string user_surname { get; set; } = default!;
    public string user_sex { get; set; } = default!;

    public string user_bdate { get; set; } = default!;

    public bool animal_history { get; set; } = default!;

    public bool animal_exist { get; set; } = default!;

    public string Email { get; set; } = default!;
    public UserType UserType { get; set; }
}

