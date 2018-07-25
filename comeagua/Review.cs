using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comeagua
{
    class Review
    {
        public int ID { get; set; }
        public int MyProperty { get; set; }
        public string Commentary { get; set; }
        public int Record { get; set; }

        public virtual ICollection<User>Users { get; set; }
        public virtual ICollection<Pub>Pubs { get; set; }
    }
}
