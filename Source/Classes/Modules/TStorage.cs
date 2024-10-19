using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;

namespace Classes
{
    public class TStorage
    {
        DataContext DataBase;

        Table<TView> Views;

        Table<TTask> Tasks;
        Table<TGroup> Groups;
        Table<TContact> Contacts;
        Table<TCategory> Categories;

        Table<TTaskContact> TaskContacts;
        Table<TTaskDocument> TaskDocuments;
        Table<TTaskCategory> TaskCategories;

        Table<TChangeItem> Changes;

        public TStorage() { }

        public TStorage(String Source)
        {
            try
            {
                DataBase = new DataContext(Source);

                Views = DataBase.GetTable<TView>();

                Tasks = DataBase.GetTable<TTask>();
                Contacts = DataBase.GetTable<TContact>();
                Groups = DataBase.GetTable<TGroup>();
                Categories = DataBase.GetTable<TCategory>();

                TaskContacts = DataBase.GetTable<TTaskContact>();
                TaskDocuments = DataBase.GetTable<TTaskDocument>();
                TaskCategories = DataBase.GetTable<TTaskCategory>();

                Changes = DataBase.GetTable<TChangeItem>();
            }
            catch
            {
                return;
            }
        }

        public void SubmitChange(TChange Change)
        {
            /*----------------------------------------------------------------------------*/
            /* Изменения на добавление                                                    */

            if (Change.GetType() == typeof(TAddView))
            {
                var Query = from View in Views where View.ID == ((TAddView)Change).View.ID select View;

                if (Query.Count() == 0)
                    Views.InsertOnSubmit(((TAddView)Change).View);
            }

            if (Change.GetType() == typeof(TAddTask))
            {
                var Query = from Task in Tasks where Task.ID == ((TAddTask)Change).Task.ID select Task;
                
                if (Query.Count() == 0)
                    Tasks.InsertOnSubmit(((TAddTask)Change).Task);
            }

            if (Change.GetType() == typeof(TAddContact))
            {
                var Query = from Contact in Contacts where Contact.ID == ((TAddContact)Change).Contact.ID select Contact;

                if (Query.Count() == 0)
                    Contacts.InsertOnSubmit(((TAddContact)Change).Contact);
            }

            if (Change.GetType() == typeof(TAddGroup))
            {
                var Query = from Group in Groups where Group.ID == ((TAddGroup)Change).Group.ID select Group;

                if (Query.Count() == 0)
                    Groups.InsertOnSubmit(((TAddGroup)Change).Group);
            }

            if (Change.GetType() == typeof(TAddChangeItem))
            {
                var Query = from ChangeItem in Changes where ChangeItem.ID == ((TAddChangeItem)Change).ChangeItem.ID select ChangeItem;
                
                if (Query.Count() == 0)
                    Changes.InsertOnSubmit(((TAddChangeItem)Change).ChangeItem);
            }

            if (Change.GetType() == typeof(TAddCategory))
            {
                var Query = from Category in Categories where Category.ID == ((TAddCategory)Change).Category.ID select Category;

                if (Query.Count() == 0)
                    Categories.InsertOnSubmit(((TAddCategory)Change).Category);
            }

            if (Change.GetType() == typeof(TAddTaskContact))
            {
                TTaskContact Temp = ((TAddTaskContact)Change).TaskContact;

                var Query = from TaskContact in TaskContacts where TaskContact.TaskID == Temp.TaskID where TaskContact.ContactID == Temp.ContactID select TaskContact;

                if (Query.Count() == 0)
                    TaskContacts.InsertOnSubmit(((TAddTaskContact)Change).TaskContact);
            }

            if (Change.GetType() == typeof(TAddTaskDocument))
            {
                var Query = from TaskDocument in TaskDocuments where TaskDocument.ID == ((TAddTaskDocument)Change).TaskDocument.ID select TaskDocument;

                if (Query.Count() == 0)
                    TaskDocuments.InsertOnSubmit(((TAddTaskDocument)Change).TaskDocument);
            }

            if (Change.GetType() == typeof(TAddTaskCategory))
            {
                TTaskCategory Temp = ((TAddTaskCategory)Change).TaskCategory;

                var Query = from TaskCategory in TaskCategories where TaskCategory.TaskID == Temp.TaskID where TaskCategory.CategoryID == Temp.CategoryID select TaskCategory;

                if (Query.Count() == 0)
                    TaskCategories.InsertOnSubmit(((TAddTaskCategory)Change).TaskCategory);
            }

            /*----------------------------------------------------------------------------*/
            /* Изменения на удаление                                                      */

            if (Change.GetType() == typeof(TDeleteView))
            {
                var Query = from View in Views where View.ID == ((TDeleteView)Change).ViewID select View;

                if (Query.Count() > 0)
                    Views.DeleteOnSubmit(Query.First());
            }

            if (Change.GetType() == typeof(TDeleteTask))
            {
                var Query = from Task in Tasks where Task.ID == ((TDeleteTask)Change).TaskID select Task;

                if (Query.Count() > 0)
                    Tasks.DeleteOnSubmit(Query.First());

                var DeleteTaskCategory = from TaskCategory in TaskCategories where TaskCategory.TaskID == ((TDeleteTask)Change).TaskID select TaskCategory;

                foreach (var TaskCategory in DeleteTaskCategory)
                    TaskCategories.DeleteOnSubmit(TaskCategory);

                var DeleteTaskContact = from TaskContact in TaskContacts where TaskContact.TaskID == ((TDeleteTask)Change).TaskID select TaskContact;

                foreach (var TaskContact in DeleteTaskContact)
                    TaskContacts.DeleteOnSubmit(TaskContact);

                var DeleteTaskDocument = from TaskDocument in TaskDocuments where TaskDocument.TaskID == ((TDeleteTask)Change).TaskID select TaskDocument;

                foreach (var TaskDocument in DeleteTaskDocument)
                    TaskDocuments.DeleteOnSubmit(TaskDocument);
            }

            if (Change.GetType() == typeof(TDeleteContact))
            {
                var Query = from Contact in Contacts where Contact.ID == ((TDeleteContact)Change).ContactID select Contact;

                if (Query.Count() > 0)
                    Contacts.DeleteOnSubmit(Query.First());
            }

            if (Change.GetType() == typeof(TDeleteGroup))
            {
                var Query = from Group in Groups where Group.ID == ((TDeleteGroup)Change).GroupID select Group;

                if (Query.Count() > 0)
                    Groups.DeleteOnSubmit(Query.First());

                var DeleteCategory = from Category in Categories where Category.GroupID == ((TDeleteGroup)Change).GroupID select Category;

                foreach (var Category in DeleteCategory)
                    Categories.DeleteOnSubmit(Category);
            }

            if (Change.GetType() == typeof(TDeleteCategory))
            {
                var Query = from Category in Categories where Category.ID == ((TDeleteCategory)Change).CategoryID select Category;

                if (Query.Count() > 0)
                    Categories.DeleteOnSubmit(Query.First());
            }

            if (Change.GetType() == typeof(TDeleteTaskContact))
            {
                Guid TaskID = ((TDeleteTaskContact)Change).TaskID;
                Guid ContactID = ((TDeleteTaskContact)Change).ContactID;

                var Query = from TaskContact in TaskContacts where TaskContact.TaskID == TaskID where TaskContact.ContactID == ContactID select TaskContact;

                if (Query.Count() > 0)
                    TaskContacts.DeleteOnSubmit(Query.First());
            }

            if (Change.GetType() == typeof(TDeleteTaskDocument))
            {
                var Query = from TaskDocument in TaskDocuments where TaskDocument.ID == ((TDeleteTaskDocument)Change).ID select TaskDocument;

                if (Query.Count() > 0)
                    TaskDocuments.DeleteOnSubmit(Query.First());
            }

            if (Change.GetType() == typeof(TDeleteTaskCategory))
            {
                Guid TaskID = ((TDeleteTaskCategory)Change).TaskID;
                Guid CategoryID = ((TDeleteTaskCategory)Change).CategoryID;

                var Query = from TaskCategory in TaskCategories where TaskCategory.TaskID == TaskID where TaskCategory.CategoryID == CategoryID select TaskCategory;

                if (Query.Count() > 0)
                    TaskCategories.DeleteOnSubmit(Query.First());
            }

            /*----------------------------------------------------------------------------*/
            /* Изменения на редактирование                                                */

            if (Change.GetType() == typeof(TEditView))
            {
                TView Temp = ((TEditView)Change).View;

                var Query = from View in Views where View.ID == Temp.ID select View;

                if (Query.Count() > 0)
                {
                    Query.First().Name = Temp.Name;
                    Query.First().Text = Temp.Text;
                    Query.First().Done = Temp.Done;
                    Query.First().Start = Temp.Start;
                    Query.First().Finish = Temp.Finish;
                    Query.First().Category = Temp.Category;
                    Query.First().Importance = Temp.Importance;
                    Query.First().Complete = Temp.Complete;
                }
            }

            if (Change.GetType() == typeof(TEditContact))
            {
                TContact Temp = ((TEditContact)Change).Contact;

                var Query = from Contact in Contacts where Contact.ID == Temp.ID select Contact;

                if (Query.Count() > 0)
                {
                    Query.First().Name = Temp.Name;
                    Query.First().Address = Temp.Address;
                    Query.First().Email = Temp.Email;
                    Query.First().Home = Temp.Home;
                    Query.First().Mobile = Temp.Mobile;
                    Query.First().Work = Temp.Work;
                }
            }

            if (Change.GetType() == typeof(TEditName))
            {
                var Query = from Task in Tasks where Task.ID == ((TEditName)Change).TaskID select Task;

                if (Query.Count() > 0)
                    Query.First().Name = ((TEditName)Change).Value;
            }

            if (Change.GetType() == typeof(TEditText))
            {
                var Query = from Task in Tasks where Task.ID == ((TEditText)Change).TaskID select Task;

                if (Query.Count() > 0)
                    Query.First().Text = ((TEditText)Change).Value;
            }

            if (Change.GetType() == typeof(TEditStart))
            {
                var Query = from Task in Tasks where Task.ID == ((TEditStart)Change).TaskID select Task;

                if (Query.Count() > 0)
                    Query.First().Start = ((TEditStart)Change).Value;
            }

            if (Change.GetType() == typeof(TEditFinish))
            {
                var Query = from Task in Tasks where Task.ID == ((TEditFinish)Change).TaskID select Task;

                if (Query.Count() > 0)
                    Query.First().Finish = ((TEditFinish)Change).Value;
            }

            if (Change.GetType() == typeof(TEditDone))
            {
                var Query = from Task in Tasks where Task.ID == ((TEditDone)Change).TaskID select Task;

                if (Query.Count() > 0)
                    Query.First().Done = ((TEditDone)Change).Value;
            }

            if (Change.GetType() == typeof(TEditImportance))
            {
                var Query = from Task in Tasks where Task.ID == ((TEditImportance)Change).TaskID select Task;

                if (Query.Count() > 0)
                    Query.First().Importance = ((TEditImportance)Change).Value;
            }

            if (Change.GetType() == typeof(TEditComplete))
            {
                var Query = from Task in Tasks where Task.ID == ((TEditComplete)Change).TaskID select Task;
                
                if (Query.Count() > 0)
                    Query.First().Complete = ((TEditComplete)Change).Value;
            }

            //try
            //{
                DataBase.SubmitChanges();
            //}
            //catch { return; }
        }

        /*----------------------------------------------------------------------------*/
        /* Запрос объектов                                                            */

        public TView GetView(Guid ID)
        {
            try
            {
                var Query = from View in Views where View.ID == ID select View;
                return Query.First();
            }
            catch
            {
                return null;
            }
        }

        public TTask GetTask(Guid ID)
        {
            try
            {
                var Query = from Task in Tasks where Task.ID == ID select Task;
                return Query.First();
            }
            catch
            {
                return null;
            }
        }

        public TGroup GetGroup(Guid ID)
        {
            try
            {
                var Query = from Group in Groups where Group.ID == ID select Group;
                return Query.First();
            }
            catch
            {
                return null;
            }
        }

        public TContact GetContact(Guid ID)
        {
            try
            {
                var Query = from Contact in Contacts where Contact.ID == ID select Contact;
                return Query.First();
            }
            catch
            {
                return null;
            }
        }

        public TCategory GetCategory(Guid ID)
        {
            try
            {
                var Query = from Category in Categories where Category.ID == ID select Category;
                return Query.First();
            }
            catch
            {
                return null;
            }
        }

        /*----------------------------------------------------------------------------*/
        /* Запрос списков объектов                                                    */

        public List<TView> GetViewList()
        {
            DataBase.Refresh(RefreshMode.OverwriteCurrentValues, Views);

            try
            {
                var Query = from View in Views select View;
                return Query.ToList();
            }
            catch
            {
                return null;
            }
        }

        public List<TContact> GetContactList()
        {
            DataBase.Refresh(RefreshMode.OverwriteCurrentValues, Contacts);

            try
            {
                var Query = from Contact in Contacts select Contact;
                return Query.ToList();
            }
            catch
            {
                return null;
            }
        }

        public List<TTask> GetTaskList()
        {
            DataBase.Refresh(RefreshMode.OverwriteCurrentValues, Tasks);
            
            try
            {
                var Query = from Task in Tasks select Task;
                return Query.ToList();
            }
            catch
            {
                return null;
            }
        }

        public List<TTask> GetTaskList(TCategory Category)
        {
            DataBase.Refresh(RefreshMode.OverwriteCurrentValues, Categories);

            try
            {
                var Query = from TaskCategory in TaskCategories
                            join Task in Tasks on TaskCategory.TaskID equals Task.ID
                            where TaskCategory.CategoryID == Category.ID
                            select Task;

                return Query.ToList();
            }
            catch
            {
                return null;
            }
        }

        public List<TGroup> GetGroupList()
        {
            DataBase.Refresh(RefreshMode.OverwriteCurrentValues, Groups);

            try
            {
                var Query = from Group in Groups select Group;
                return Query.ToList();
            }
            catch
            {
                return null;
            }
        }

        public List<TCategory> GetCategoryList()
        {
            DataBase.Refresh(RefreshMode.OverwriteCurrentValues, Categories);

            try
            {
                var Query = from Category in Categories select Category;
                return Query.ToList();
            }
            catch
            {
                return null;
            }
        }

        public List<TCategory> GetCategoryList(TGroup Group)
        {
            DataBase.Refresh(RefreshMode.OverwriteCurrentValues, Categories);

            try
            {
                var Query = from Category in Categories where Category.GroupID == Group.ID select Category;
                return Query.ToList();
            }
            catch
            {
                return null;
            }
        }

        public List<TCategory> GetCategoryList(TTask Task)
        {
            DataBase.Refresh(RefreshMode.OverwriteCurrentValues, Categories);

            try
            {
                var Query = from TaskCategory in TaskCategories
                            join Category in Categories on TaskCategory.CategoryID equals Category.ID
                            where TaskCategory.TaskID == Task.ID
                            select Category;

                return Query.ToList();
            }
            catch
            {
                return null;
            }
        }

        public List<TTaskCategory> GetTaskCategoryList()
        {
            DataBase.Refresh(RefreshMode.OverwriteCurrentValues, TaskCategories);

            try
            {
                var Query = from TaskCategory in TaskCategories select TaskCategory;
                return Query.ToList();
            }
            catch
            {
                return null;
            }
        }

        public List<TContact> GetContactList(TTask Task)
        {
            DataBase.Refresh(RefreshMode.OverwriteCurrentValues, Contacts);

            try
            {
                var Query = from TaskContact in TaskContacts
                            join Contact in Contacts on TaskContact.ContactID equals Contact.ID
                            where TaskContact.TaskID == Task.ID
                            select Contact;

                return Query.ToList();
            }
            catch
            {
                return null;
            }
        }

        public List<TTaskDocument> GetDocumentList(TTask Task)
        {
            DataBase.Refresh(RefreshMode.OverwriteCurrentValues, TaskDocuments);

            try
            {
                var Query = from TaskDocument in TaskDocuments where TaskDocument.TaskID == Task.ID select TaskDocument;
                return Query.ToList();
            }
            catch
            {
                return null;
            }
        }

        public List<TTaskCategory> GetTaskCategoryList(TGroup Group)
        {
            DataBase.Refresh(RefreshMode.OverwriteCurrentValues, TaskCategories);

            try
            {
                var Query = from TaskCategory in TaskCategories where TaskCategory.GroupID == Group.ID select TaskCategory;
                return Query.ToList();
            }
            catch
            {
                return null;
            }
        }

        public List<TChangeItem> GetAllChanges()
        {
            try
            {
                var Query = from Change in Changes orderby Change.Index select Change;
                return Query.ToList();
            }
            catch
            {
                return null;
            }
        }

        public int LastIndex(Guid ID)
        {
            var Query = from Change in Changes where Change.ID == ID orderby Change.Index select Change;

            if (Query.Count() > 0)
                return Query.First().Index;
            else
                return 0;
        }

        public List<TChangeItem> GetChangeList(Guid ID)
        {
            if (ID == Guid.Empty)
            {
                return GetAllChanges();
            }

            int Index = LastIndex(ID);

            if (Index == 0)
            {
                return GetAllChanges();
            }
            else
            {
                var Query = from Change in Changes where Change.Index > Index orderby Change.Index select Change;
                return Query.ToList();
            }
        }
    }
}