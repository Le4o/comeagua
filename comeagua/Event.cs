using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comeagua
{
    class Event
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool Private { get; set; }

        public int PubID { get; set; }
        public virtual Pub Pub { get; set; }

        public int UserID { get; set; }
        public virtual User User { get; set; }

        public virtual ICollection<Guest>Guests { get; set; }
    }
}
