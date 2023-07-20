using System;
using Infrastructure.Data.Postgres.Entities.Base;
//using Infrastructure.Data.Postgres.Entities.Infrastructure.Data.Postgres.Entities;

namespace Infrastructure.Data.Postgres.Entities;

public class Animal : Entity<int>
{

    public string animal_name { get; set; } = default!;
    public string animal_year { get; set; } = default!;
    public bool animal_vaccine { get; set; }
    public bool animal_chip { get; set; }
    public string animal_sex { get; set; } = default!;
    public string animal_type { get; set; } = default!;
    public bool animal_passion { get; set; }
    public byte[] animal_img { get; set; }

    public int advert_id { get; set; }

    public Advert? Advert { get; set; }



}


