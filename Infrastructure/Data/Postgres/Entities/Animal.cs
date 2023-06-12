using Infrastructure.Data.Postgres.Entities.Base;

namespace Infrastructure.Data.Postgres.Entities;

public class Animal : Entity<int>
{

    public string animal_name { get; set; } = default!;
    public string animal_year { get; set; } = default!;
    public Boolean animal_vaccine { get; set; };
    public Boolean animal_chip { get; set; };
    public string animal_sex { get; set; } = default!;
    public string animal_type { get; set; } = default!;
    public Boolean animal_passion { get; set; };

   // deneme 




}


