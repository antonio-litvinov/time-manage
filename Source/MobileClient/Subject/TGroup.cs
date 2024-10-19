using System;


namespace MobileClient
{
    public class TGroup
    {
        public Guid ID;

        public String Name;

        public TGroup() { }

        public TGroup(String Name)
        {
            this.ID = Guid.NewGuid();
            this.Name = Name;
        }
    }
}