using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comeagua
{
    class Pub
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public int Tag_PubID { get; set; }
        public virtual Tag_Pub Tag_Pub { get; set; }

        public int ReviewID { get; set; }
        public virtual Review Review { get; set; }

        public virtual ICollection<Photo>Photos { get; set; }
        public virtual ICollection<Adress>Adresses { get; set; }
        public virtual ICollection<Operation>Operations { get; set; }
        public virtual ICollection<Event>Events { get; set; }

    }
}
