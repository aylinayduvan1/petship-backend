using Infrastructure.Data.Postgres.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.Entities
{
    public class Message: Entity <int>
    {
        public int chat_id { get; set; } = default!;
        public int send_id { get; set; } = default!;
        public int receive_id { get; set; } = default!;
        public string content { get; set; } = default!;

        //db'de date'i int girmişiz ?
        public DateTime message_date { get; set; } = default!;
        public bool message_status { get; set; }


    }
}
}
