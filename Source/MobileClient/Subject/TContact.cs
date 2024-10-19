using System;

namespace MobileClient
{
    public class TContact
    {
        public Guid ID;

        public String Name;

        public String Mobile;

        public String Home;

        public String Work;

        public String Address;

        public String Email;

        public TContact() { }

        public TContact(String Name)
        {
            this.ID = Guid.NewGuid();
            this.Name = Name;
        }
    }
}