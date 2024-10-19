using System;
using System.Data.Linq.Mapping;

namespace Classes
{
    [Table(Name = "Categories")]
    public class TCategory
    {
        [Column(IsPrimaryKey = true)]
        public Guid ID;

        [Column]
        public Guid GroupID;

        [Column]
        public String Name;

        public TCategory() { }

        public TCategory(String Name, Guid GroupID)
        {
            this.ID = Guid.NewGuid();
            this.Name = Name;
            this.GroupID = GroupID;
        }
    }
}