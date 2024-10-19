using System;
using System.Data.Linq.Mapping;

namespace Classes
{
    [Table(Name = "TaskDocument")]
    public class TTaskDocument
    {
        [Column(IsPrimaryKey = true)]
        public Guid ID;

        [Column]
        public Guid TaskID;

        [Column]
        public String Link;

        public TTaskDocument() { }

        public TTaskDocument(Guid TaskID, String Link)
        {
            this.ID = Guid.NewGuid();
            this.TaskID = TaskID;
            this.Link = Link;
        }
    }
}
