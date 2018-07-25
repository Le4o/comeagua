using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comeagua.Infra.Tables
{
    class Operation
    {
        public int ID { get; set; }
        public DateTime MyProperty { get; set; }

        public int PubID { get; set; }
        public virtual Pub Pub { get; set; }
    }
}
