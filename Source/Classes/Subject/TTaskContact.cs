using System;
using System.Data.Linq.Mapping;

namespace Classes
{
    [Table(Name = "TaskContact")]
    public class TTaskContact
    {
        [Column(IsPrimaryKey = true)]
        public Guid ID;

        [Column]
        public Guid TaskID;

        [Column]
        public Guid ContactID;

        public TTaskContact() { }

        public TTaskContact(Guid TaskID, Guid ContactID)
        {
            this.ID = Guid.NewGuid();
            this.TaskID = TaskID;
            this.ContactID = ContactID;
        }
    }
}