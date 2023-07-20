using System;
using Infrastructure.Data.Postgres.Entities.Base;
//using Infrastructure.Data.Postgres.Entities.Infrastructure.Data.Postgres.Entities;

namespace Infrastructure.Data.Postgres.Entities;

public class User : Entity<int>
{
    
    public string UserName { get; set; } = default!;
    public string Email { get; set; } = default!;

    public string Adress { get; set; }
    public string gsm { get; set; }
    public string Password { get; set; }
    public string user_surname { get; set; } = default!;
    public string user_bdate { get; set; }
    public string user_sex { get; set; } = default!;
    public bool animal_history { get; set; }
    public bool animal_exist { get; set; }
    
   
   

    public byte[] PasswordSalt { get; set; } = default!;
    public byte[] PasswordHash { get; set; } = default!;

    public UserType UserType { get; set; }
    
    public List <Advert?>  Advert { get; set; }
    
}

public enum UserType
{
    Admin,
    User, 
}