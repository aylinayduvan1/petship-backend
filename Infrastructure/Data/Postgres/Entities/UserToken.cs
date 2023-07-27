namespace Infrastructure.Data.Postgres.Entities;

public class UserToken 
{
    public string Token { get; set; }
    public int UserId { get; set; }
    public DateTime ValidUntil { get; set; }

    public int UserType { get; set; } // Add a new property for UserType

    public virtual User? User { get; set; }

    

    public UserToken(int userId, DateTime validUntil)
    {
        Token = Guid.NewGuid().ToString();
        UserId = userId;
        ValidUntil = validUntil;
        UserType = 1;
    }
}