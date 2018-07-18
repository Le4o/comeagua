using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace comeagua
{
    public class Context : DbContext
    {
        public Context():base("comeagua")
        {

        }
    }
}