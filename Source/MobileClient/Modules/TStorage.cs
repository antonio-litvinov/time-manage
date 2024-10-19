using System;
using System.Collections.Generic;
using MobileClient.Properties;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace MobileClient
{
    public class TStorage
    {
        public List<TTask> Tasks;
        public List<TGroup> Groups;
        public List<TCategory> Categories;
        public List<TTaskCategory> TaskCategories;

        public TStorage()
        {
            Tasks = new List<TTask>();
            Groups = new List<TGroup>();
            Categories = new List<TCategory>();
            TaskCategories = new List<TTaskCategory>();
        }

        public void SubmitChange(TChange Change)
        {

            if (Change.GetType() == typeof(TAddTask))
            {
                var Task = Tasks.Find(p => p.ID == ((TAddTask)Change).Task.ID);
                if (Task == null)
                    Tasks.Add(((TAddTask)Change).Task);
            }

            if (Change.GetType() == typeof(TAddGroup))
            {
                var Group = Groups.Find(p => p.ID == ((TAddGroup)Change).Group.ID);
                if (Group == null)
                    Groups.Add(((TAddGroup)Change).Group);
            }

            if (Change.GetType() == typeof(TAddCategory))
            {
                var Category = Categories.Find(p => p.ID == ((TAddCategory)Change).Category.ID);
                if (Category == null)
                    Categories.Add(((TAddCategory)Change).Category);
            }

            if (Change.GetType() == typeof(TAddTaskCategory))
            {
                var TaskCategory = TaskCategories.Find(p => p.ID == ((TAddTaskCategory)Change).TaskCategory.ID);
                if (TaskCategory == null)
                    TaskCategories.Add(((TAddTaskCategory)Change).TaskCategory);
            }

            if (Change.GetType() == typeof(TDeleteTask))
            {
                var Task = Tasks.Find(p => p.ID == ((TDeleteTask)Change).TaskID);
                if (Task != null)
                    Tasks.Remove(Task);
            }

            if (Change.GetType() == typeof(TDeleteGroup))
            {
                var Group = Groups.Find(p => p.ID == ((TDeleteGroup)Change).GroupID);
                if (Group != null)
                    Groups.Remove(Group);
            }

            if (Change.GetType() == typeof(TDeleteCategory))
            {
                var Category = Categories.Find(p => p.ID == ((TDeleteCategory)Change).CategoryID);
                if (Category != null)
                    Categories.Remove(Category);
            }

            if (Change.GetType() == typeof(TDeleteTaskCategory))
            {
                var TaskCategory = TaskCategories.Find(p => p.CategoryID == ((TDeleteTaskCategory)Change).CategoryID);
                if (TaskCategory != null)
                    TaskCategories.Remove(TaskCategory);
            }

            if (Change.GetType() == typeof(TEditName))
            {
                var Task = Tasks.Find(p => p.ID == ((TEditName)Change).TaskID);
                if (Task != null)
                    Task.Name = ((TEditName)Change).Value;
                
            }

            if (Change.GetType() == typeof(TEditText))
            {
                var Task = Tasks.Find(p => p.ID == ((TEditText)Change).TaskID);
                if (Task != null)
                    Task.Text = ((TEditText)Change).Value;
            }

            if (Change.GetType() == typeof(TEditStart))
            {
                var Task = Tasks.Find(p => p.ID == ((TEditStart)Change).TaskID);
                if (Task != null)
                    Task.Start = ((TEditStart)Change).Value;
            }

            if (Change.GetType() == typeof(TEditFinish))
            {
                var Task = Tasks.Find(p => p.ID == ((TEditFinish)Change).TaskID);
                if (Task != null)
                    Task.Finish = ((TEditFinish)Change).Value;
            }
        }

        public TTask GetTask(Guid ID)
        {
            try
            {
                var Task = Tasks.Find(p => p.ID == ID);
                return Task;
            }
            catch { return null; }
        }

        public TGroup GetGroup(Guid ID)
        {
            try
            {
                var Group = Groups.Find(p => p.ID == ID);
                return Group;
            }
            catch { return null; }
        }

        public TCategory GetCategory(Guid ID)
        {
            try
            {
                var Category = Categories.Find(p => p.ID == ID);
                return Category;
            }
            catch { return null; }
        }
        
        public List<TTask> GetTaskList()
        {
            return Tasks;
        }

        public List<TTask> GetTaskList(TCategory Category)
        {
            List<TTask> Temp = new List<TTask>();
            var Query = TaskCategories.FindAll(p => p.CategoryID == Category.ID);

            foreach (TTaskCategory TaskCategory in Query.ToArray())
            {
                var Task = Tasks.Find(p => p.ID == TaskCategory.TaskID);
                Temp.Add(Task);
            }
            return Temp;
        }

        public List<TGroup> GetGroupList()
        {
            return Groups;
        }

        public TCategory[] GetCategoryList(TGroup Group)
        {
            var Category = Categories.FindAll(p => p.GroupID == Group.ID);
            return Category.ToArray();
        }

        public static TStorage LoadStorage(String FileName)
        {
            TStorage Storage = new TStorage();

            TextReader Reader = new StreamReader(FileName);
            XmlSerializer Serializer = new XmlSerializer(typeof(TStorage));

            Storage = (TStorage)Serializer.Deserialize(Reader);
            Reader.Close();

            return Storage;
        }

        public void SaveStorage(String FileName)
        {
            XmlSerializer Serializer = new XmlSerializer(typeof(TStorage));

            TextWriter Writer = new StreamWriter(FileName);
            Serializer.Serialize(Writer, this);
            Writer.Close();
        }
    }
}