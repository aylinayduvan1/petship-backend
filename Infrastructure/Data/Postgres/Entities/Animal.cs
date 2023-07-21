using System;
using Infrastructure.Data.Postgres.Entities.Base;
//using Infrastructure.Data.Postgres.Entities.Infrastructure.Data.Postgres.Entities;

namespace Infrastructure.Data.Postgres.Entities;

public class Animal : Entity<int>
{

    public string Animal_name { get; set; } = default!;
    public string Animal_year { get; set; } = default!;
    public bool Animal_vaccine { get; set; }
    public bool Animal_chip { get; set; }
    public string Animal_sex { get; set; } = default!;
    public string Animal_type { get; set; } = default!;
    public bool Animal_passion { get; set; }
    public string Animal_img { get; set; }

    public int Advert_id { get; set; }

    public Advert? Advert { get; set; }



}


