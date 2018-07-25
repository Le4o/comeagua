using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comeagua
{
    class Guest
    {
        public int ID { get; set; }
        //um boolean pode comecar sendo null?
        public Boolean Status { get; set; }


        public int EventID { get; set; }
        public virtual Event Event { get; set; }

        public int UserID { get; set; }
        public virtual User User { get; set; }
    }
}
