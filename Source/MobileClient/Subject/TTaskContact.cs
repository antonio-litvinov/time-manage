using System;

namespace MobileClient
{
    public class TTaskContact
    {
        public Guid ID;

        public Guid TaskID;

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