using System;

namespace MobileClient
{
    public class TTaskCategory
    {
        public Guid ID;

        public Guid TaskID;

        public Guid CategoryID;

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
