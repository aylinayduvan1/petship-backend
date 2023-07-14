using System;
using Infrastructure.Data.Postgres.Entities.Base;
//using Infrastructure.Data.Postgres.Entities.Infrastructure.Data.Postgres.Entities;

namespace Infrastructure.Data.Postgres.Entities;

public class User : Entity<int>
{
    
    public string UserName { get; set; } = default!;
    public string Email { get; set; } = default!;
    public string Password { get; set; }
    public string user_surname { get; set; } = default!;
    public string user_bdate { get; set; }
    public string user_sex { get; set; } = default!;
    public bool animal_history { get; set; }
    public bool animal_exist { get; set; }
    public int? animal_id { get; set; } = default!;
    public int? advert_id { get; set; } = default!;
    public int? contact_id { get; set; } = default!;
   
   

    public byte[] PasswordSalt { get; set; } = default!;
    public byte[] PasswordHash { get; set; } = default!;

    public UserType UserType { get; set; }
    public Animal? Animal { get; set; }
    public List <Advert?>  Advert { get; set; }
    public Contact? Contact { get; set; }
}

public enum UserType
{
    Admin,
    User, 
}