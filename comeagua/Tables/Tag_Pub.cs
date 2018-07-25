using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comeagua.Infra.Tables
{ 
    class Tag_Pub
    {
        public int ID { get; set; }

        public virtual  ICollection<Pub> Pubs { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }


    }
}
