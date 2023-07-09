using System;
using Infrastructure.Data.Postgres.Entities.Base;
//using Infrastructure.Data.Postgres.Entities.Infrastructure.Data.Postgres.Entities;


namespace Infrastructure.Data.Postgres.Entities
{

	public class Contact : Entity<int>
	{
		public string Adress { get; set; }
		public string gsm { get; set; }
        

    }
}