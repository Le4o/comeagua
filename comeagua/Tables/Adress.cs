using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comeagua.Infra.Tables
{
    class Adress
    {
        public int ID { get; set; }
        public int X { get; set; }
        public int y { get; set; }

        public int PubID { get; set; }
        public virtual Pub Pub { get; set; }

    }
}
