using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace comeagua.Tables
{

    public class Operation
    {
        public int ID { get; set; }
        public DateTime StartHour { get; set; }
        public DateTime EndHour { get; set; }

        public int WeekID { get; set; }
        public int PubID { get; set; }
    }

    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime DateBirth { get; set; }

        public int ReviewID { get; set; }

        public virtual List<Event> Events { get; set; }
        public virtual List<Photo> Photos { get; set; }
        public virtual List<Guest> Guests { get; set; }

    }

    public class Pub
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public int Tag_PubID { get; set; }

        public int ReviewID { get; set; }

        public virtual List<Photo> Photos { get; set; }
        public virtual List<Address> Adresses { get; set; }
        public virtual List<Operation> Operations { get; set; }
        public virtual List<Event> Events { get; set; }

    }

    public class Address
    {
        public int ID { get; set; }
        public int X { get; set; }
        public int y { get; set; }

        public int PubID { get; set; }
    }

    public class Holiday
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }

    }

    public class Photo
    {
        public int ID { get; set; }
        public byte[] Image { get; set; }//sera bit ou string 

        public int UserID { get; set; }

        //----------- or --------------------- // regra de negocio

        public int PubID { get; set; }
    }

    public class Event
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool Private { get; set; }

        public int PubID { get; set; }
        public int UserID { get; set; }

        public virtual List<Guest> Guests { get; set; }
    }

    public class Guest
    {
        public int ID { get; set; }
        public Boolean Status { get; set; }

        public int EventID { get; set; }
        public int UserID { get; set; }

    }

    public class Review
    {
        public int ID { get; set; }
        public int MyProperty { get; set; }
        public string Commentary { get; set; }
        public int Record { get; set; }

        public virtual List<User> Users { get; set; }
        public virtual List<Pub> Pubs { get; set; }
    }

    public class Tag
    {
        public int ID { get; set; }
        public string Description { get; set; }

        public int Tag_PubID { get; set; }

    }

    public class Tag_Pub
    {
        public int ID { get; set; }

        public virtual List<Pub> Pubs { get; set; }
        public virtual List<Tag> Tags { get; set; }

    }

    public class Week
    {
        public int ID { get; set; }
        public string Description { get; set; }

        public virtual List<Operation> Operations { get; set; }
    }

}