using System;

namespace MobileClient
{
    public class TChange
    {
        public Guid ID;

        public TChange() { ID = Guid.NewGuid(); }
    }

    public class TAddTask : TChange
    {
        public TTask Task;

        public TAddTask() { }
        public TAddTask(TTask Task) { this.Task = Task; }
    }

    public class TAddGroup : TChange
    {
        public TGroup Group;

        public TAddGroup() { }
        public TAddGroup(TGroup Group) { this.Group = Group; }
    }

    public class TAddContact : TChange
    {
        public TContact Contact;

        public TAddContact() { }
        public TAddContact(TContact Contact) { this.Contact = Contact; }
    }

    public class TAddCategory : TChange
    {
        public TCategory Category;

        public TAddCategory() { }
        public TAddCategory(TCategory Category) { this.Category = Category; }
    }

    public class TAddTaskContact : TChange
    {
        public TTaskContact TaskContact;

        public TAddTaskContact() { }
        public TAddTaskContact(TTaskContact TaskContact) { this.TaskContact = TaskContact; }
    }

    public class TAddTaskCategory : TChange
    {
        public TTaskCategory TaskCategory;

        public TAddTaskCategory() { }
        public TAddTaskCategory(TTaskCategory TaskCategory) { this.TaskCategory = TaskCategory; }
    }

    public class TDeleteTask : TChange
    {
        public Guid TaskID;

        public TDeleteTask() { }
        public TDeleteTask(Guid TaskID) { this.TaskID = TaskID; }
    }

    public class TDeleteGroup : TChange
    {
        public Guid GroupID;

        public TDeleteGroup() { }
        public TDeleteGroup(Guid GroupID) { this.GroupID = GroupID; }
    }

    public class TDeleteContact : TChange
    {
        public Guid ContactID;

        public TDeleteContact() { }
        public TDeleteContact(Guid ContactID) { this.ContactID = ContactID; }
    }

    public class TDeleteCategory : TChange
    {
        public Guid CategoryID;

        public TDeleteCategory() { }
        public TDeleteCategory(Guid CategoryID) { this.CategoryID = CategoryID; }
    }

    public class TDeleteTaskContact : TChange
    {
        public Guid TaskID;
        public Guid ContactID;

        public TDeleteTaskContact() { }
        public TDeleteTaskContact(Guid TaskID, Guid ContactID)
        {
            this.TaskID = TaskID;
            this.ContactID = ContactID;
        }
    }

    public class TDeleteTaskCategory : TChange
    {
        public Guid TaskID;
        public Guid CategoryID;

        public TDeleteTaskCategory() { }
        public TDeleteTaskCategory(Guid TaskID, Guid CategoryID)
        {
            this.TaskID = TaskID;
            this.CategoryID = CategoryID;
        }
    }

    public class TEditContact : TChange
    {
        public TContact Contact;

        public TEditContact() { }
        public TEditContact(TContact Contact) { this.Contact = Contact; }
    }

    public class TEditName : TChange
    {
        public Guid TaskID;
        public String Value;

        public TEditName() { }
        public TEditName(Guid TaskID, String Value)
        {
            this.TaskID = TaskID;
            this.Value = Value;
        }
    }

    public class TEditText : TChange
    {
        public Guid TaskID;
        public String Value;

        public TEditText() { }
        public TEditText(Guid TaskID, String Value)
        {
            this.TaskID = TaskID;
            this.Value = Value;
        }
    }

    public class TEditStart : TChange
    {
        public Guid TaskID;
        public String Value;

        public TEditStart() { }
        public TEditStart(Guid TaskID, String Value)
        {
            this.TaskID = TaskID;
            this.Value = Value;
        }
    }

    public class TEditFinish : TChange
    {
        public Guid TaskID;
        public String Value;

        public TEditFinish() { }
        public TEditFinish(Guid TaskID, String Value)
        {
            this.TaskID = TaskID;
            this.Value = Value;
        }
    }

    public class TEditDone : TChange
    {
        public Guid TaskID;
        public Boolean Value;

        public TEditDone() { }
        public TEditDone(Guid TaskID, Boolean Value)
        {
            this.TaskID = TaskID;
            this.Value = Value;
        }
    }

    public class TEditImportance : TChange
    {
        public Guid TaskID;
        public String Value;

        public TEditImportance() { }
        public TEditImportance(Guid TaskID, String Value)
        {
            this.TaskID = TaskID;
            this.Value = Value;
        }
    }

    public class TEditComplete : TChange
    {
        public Guid TaskID;
        public String Value;

        public TEditComplete() { }
        public TEditComplete(Guid TaskID, String Value)
        {
            this.TaskID = TaskID;
            this.Value = Value;
        }
    }
}
