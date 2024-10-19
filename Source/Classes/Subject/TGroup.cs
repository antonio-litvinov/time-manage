using System;
using System.Data.Linq.Mapping;

namespace Classes
{
    [Table(Name = "Groups")]
    public class TGroup
    {
        [Column(IsPrimaryKey = true)]
        public Guid ID;

        [Column]
        public String Name;

        public TGroup() { }

        public TGroup(String Name)
        {
            this.ID = Guid.NewGuid();
            this.Name = Name;
        }
    }
}