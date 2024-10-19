using System;

namespace MobileClient
{
    public class TCategory
    {
        public Guid ID;

        public Guid GroupID;

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