using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comeagua.Infra.Tables
{
    class Photo
    {
        public int ID { get; set; }
       // public Ima { get; set; }//sera bit ou string 

        public int UserID { get; set; }
        public virtual User User { get; set; }

        //----------- or --------------------- // regra de negocio


        public int PubID { get; set; }
        public virtual Pub Pub { get; set; }
    }
}
