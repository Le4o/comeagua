using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comeagua.Infra.Tables
{
    class Tag
    {
        public int ID { get; set; }
        public string Description { get; set; }

        public int Tag_PubID { get; set; }
        public virtual Tag_Pub Tag_Pub { get; set; }
    }
}
