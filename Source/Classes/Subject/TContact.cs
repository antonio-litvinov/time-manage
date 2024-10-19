using System;
using System.Data.Linq.Mapping;

namespace Classes
{
    [Table(Name = "Contacts")]
    public class TContact
    {
        [Column(IsPrimaryKey = true)]
        public Guid ID;

        [Column]
        public String Name;

        [Column]
        public String Mobile;

        [Column]
        public String Home;

        [Column]
        public String Work;

        [Column]
        public String Address;

        [Column]
        public String Email;

        public TContact() { }

        public TContact(String Name)
        {
            this.ID = Guid.NewGuid();
            this.Name = Name;
        }
    }
}