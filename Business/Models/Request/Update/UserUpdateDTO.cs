namespace Business.Models.Request.Update;

public class UserUpdateDTO
{
    public string EducationSituation { get; set; } = default!;
    public string Email { get; set; } = default!;
    public string FirstName { get; set; } = default!;
    public bool Gender { get; set; } = default!;
    public string Surname { get; set; } = default!;
    public string Password { get; set; } = default!;
}