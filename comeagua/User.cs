using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comeagua

{
    class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime DateBirth { get; set; }

        public int ReviewID { get; set; }
        public virtual Review Review { get; set; }

        public virtual ICollection<Event>Events { get; set; }
        public virtual ICollection<Photo>Photos { get; set; }
        public virtual ICollection<Guest>Guests { get; set; }

    }
}
