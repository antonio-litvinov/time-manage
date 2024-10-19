using System;
using System.Data.Linq.Mapping;

namespace Classes
{
    [Table(Name = "TaskCategory")]
    public class TTaskCategory
    {
        [Column(IsPrimaryKey = true)]
        public Guid ID;

        [Column]
        public Guid TaskID;

        [Column]
        public Guid CategoryID;

        [Column]
        public Guid GroupID;

        public TTaskCategory() { }

        public TTaskCategory(Guid TaskID, Guid CategoryID, Guid GroupID)
        {
            this.ID = Guid.NewGuid();
            this.TaskID = TaskID;
            this.GroupID = GroupID;
            this.CategoryID = CategoryID;
        }
    }
}
