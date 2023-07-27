using System;
using Infrastructure.Data.Postgres.Entities.Base;
//using Infrastructure.Data.Postgres.Entities.Infrastructure.Data.Postgres.Entities;

namespace Infrastructure.Data.Postgres.Entities;

public class User : Entity<int>
{
    

    public string UserName { get; set; } = default!;
    public string Email { get; set; } = default!;

    public string Adress { get; set; }
    public string Gsm { get; set; }
    public string Password { get; set; }
    public string User_surname { get; set; } = default!;
    public string User_bdate { get; set; }
    public string User_sex { get; set; } = default!;
    public bool Animal_history { get; set; }
    public bool Animal_exist { get; set; }

    
    public byte[] PasswordSalt { get; set; } = default!;
    public byte[] PasswordHash { get; set; } = default!;


    public List <Advert?>  Advert { get; set; }
    
}

public enum UserType
{
    User,
    Admin
}