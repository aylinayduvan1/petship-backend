using System;
using Infrastructure.Data.Postgres.Entities.Base;
using Infrastructure.Data.Postgres.Entities.Infrastructure.Data.Postgres.Entities;

namespace Infrastructure.Data.Postgres.Entities;

public class User : Entity<int>
{
    
    public string user_name { get; set; } = default!;
    public string user_surname { get; set; } = default!;
    public string user_bdate { get; set; } = default!;
    public string user_adress { get; set; } = default!;
    public char[] user_sex { get; set; } = default!;
    public string user_mail { get; set; } = default!;
    public string user_gsm { get; set; } = default!;
    public bool animal_history { get; set; };
    public bool animal_exist { get; set; };
    public int animal_id { get; set; } = default!;
    public int advert_id { get; set; } = default!;
    public int chat_id { get; set; } = default!;

    public byte[] PasswordSalt { get; set; } = default!;
    public byte[] PasswordHash { get; set; } = default!;
    public UserType UserType { get; set; }
    public Animal? Animal { get; set; }
    public Advert? Advert { get; set; }
    public Message? Message { get; set; }
}

public enum UserType
{
    Admin,
    User, 
}