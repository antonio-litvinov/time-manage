using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Client.Properties;
using Classes;

namespace Client
{
    public partial class FormMain
    {
        private void Sync()
        {
            if (!LocalMode)
                Transport.SendID(Settings.Default.LastChange);
        }

        private void ShowSettings()
        {
            TextServer.Text = Settings.Default.Server;

            TextFrom.Text = Settings.Default.From;
            TextTo.Text = Settings.Default.To;
            
            TextLogin.Text = Settings.Default.Login;
            TextPassword.Text = Settings.Default.Password;

            TextPOP.Text = Settings.Default.POP.ToString();
            TextSMTP.Text = Settings.Default.SMTP.ToString();
        }

        private void SaveSettings()
        {
            Settings.Default.Server = TextServer.Text;

            Settings.Default.From = TextFrom.Text;
            Settings.Default.To = TextTo.Text;

            Settings.Default.Login = TextLogin.Text;
            Settings.Default.Password = TextPassword.Text;

            Settings.Default.POP = short.Parse(TextPOP.Text);
            Settings.Default.SMTP = short.Parse(TextSMTP.Text);

            Settings.Default.Save();
        }

        private void LoadView()
        {
            ListTasks.Columns.Clear();
            ListTasks.Columns.Add("Название");

            if (CurrentView.Text)
                ListTasks.Columns.Add("Описание");
            if (CurrentView.Done)
                ListTasks.Columns.Add("Выполнено");
            if (CurrentView.Start)
                ListTasks.Columns.Add("Начало");
            if (CurrentView.Finish)
                ListTasks.Columns.Add("Срок");
            if (CurrentView.Importance)
                ListTasks.Columns.Add("Важность");
            if (CurrentView.Complete)
                ListTasks.Columns.Add("Завершено");

            LabelViewName.Text = CurrentView.Caption;
            Settings.Default.CurrentView = CurrentView.ID;
            ResizeColumns();
        }

        private void EditView()
        {
            if (CurrentView != null)
            {
                TView View = new TView();
                View.ID = CurrentView.ID;

                if (ListColumns.Items["Описание"].Checked)
                    View.Text = true;

                if (ListColumns.Items["Выполнено"].Checked)
                    View.Done = true;

                if (ListColumns.Items["Начало"].Checked)
                    View.Start = true;

                if (ListColumns.Items["Срок"].Checked)
                    View.Finish = true;

                if (ListColumns.Items["Важность"].Checked)
                    View.Importance = true;

                if (ListColumns.Items["Завершено"].Checked)
                    View.Complete = true;

                Storage.SubmitChange(new TEditView(View));
            }
        }

        private void EditContact()
        {
            if (CurrentContact != null)
            {
                TContact Contact = new TContact();
                Contact.ID = CurrentContact.ID;

                Contact.Address = TextAddress.Text;
                Contact.Email = TextEmail.Text;
                Contact.Home = TextHome.Text;
                Contact.Mobile = TextMobile.Text;
                Contact.Name = TextName.Text;
                Contact.Work = TextWork.Text;

                TChange Change = new TEditContact(Contact);
                Storage.SubmitChange(Change);
                ChangeManager.AddChange(Change);
            }
        }

        private void FillViewList()
        {
            ListViews.Items.Clear();

            List<TView> ViewList = Storage.GetViewList();

            if (ViewList != null)
            {
                foreach (TView View in ViewList)
                {
                    ListViewItem Item = new ListViewItem(View.Caption, 0);
                    Item.Tag = View;

                    ListViews.Items.Add(Item);
                }
            }
        }

        private void AddToList(Boolean Checked, String Caption)
        {
            ListViewItem Item = new ListViewItem(Caption);
            Item.Name = Caption;
            Item.Checked = Checked;
            ListColumns.Items.Add(Item);
        }

        private void ShowView()
        {
            ListColumns.Items.Clear();

            if (CurrentView != null)
            {
                LabelSelectedView.Text = CurrentView.Caption;

                AddToList(CurrentView.Text, "Описание");
                AddToList(CurrentView.Done, "Выполнено");
                AddToList(CurrentView.Start, "Начало");
                AddToList(CurrentView.Finish, "Срок");
                AddToList(CurrentView.Importance, "Важность");
                AddToList(CurrentView.Complete, "Завершено");
            }
            else
            {
                LabelSelectedView.Text = "Выберите представление";
            }
        }

        private void ShowContact()
        {
            if (CurrentContact != null)
            {
                TextName.Text = CurrentContact.Name;
                TextMobile.Text = CurrentContact.Mobile;
                TextHome.Text = CurrentContact.Home;
                TextWork.Text = CurrentContact.Work;
                TextAddress.Text = CurrentContact.Address;
                TextEmail.Text = CurrentContact.Email;
                LabelSelectedContact.Text = CurrentContact.Name;
            }
            else
            {
                TextName.Text = String.Empty;
                TextMobile.Text = String.Empty;
                TextHome.Text = String.Empty;
                TextWork.Text = String.Empty;
                TextAddress.Text = String.Empty;
                TextEmail.Text = String.Empty;
                LabelSelectedContact.Text = "Выберите контакт";
            }
        }

        private void AddView()
        {
            if (TextViewName.Text.Trim().Length > 0)
            {
                TAddView Change = new TAddView(new TView(TextViewName.Text));
                Storage.SubmitChange(Change);

                TextViewName.Clear();
                TextViewName.Focus();

                ListColumns.Items.Clear();
            }
        }

        private void AddTask()
        {
            if (TextTaskName.Text.Trim().Length > 0)
            {
                TAddTask Change = new TAddTask(new TTask(TextTaskName.Text));
                Storage.SubmitChange(Change);
                ChangeManager.AddChange(Change);

                TextTaskName.Clear();
                TextTaskName.Focus();
            }
        }

        private void AddContact()
        {
            if (TextContactName.Text.Trim().Length > 0)
            {
                TAddContact Change = new TAddContact(new TContact(TextContactName.Text));
                Storage.SubmitChange(Change);
                ChangeManager.AddChange(Change);

                TextContactName.Clear();
                TextContactName.Focus();
            }
        }

        private void AddGroup()
        {
            if (TextGroupName.Text.Trim().Length > 0)
            {
                TAddGroup Change = new TAddGroup(new TGroup(TextGroupName.Text));
                Storage.SubmitChange(Change);
                ChangeManager.AddChange(Change);
 
                TextGroupName.Clear();
                TextGroupName.Focus();

                ListCategories.Items.Clear();
            }
        }

        private void AddCategory()
        {
            if ((TextCategoryName.Text.Trim().Length > 0) && (CurrentGroup != null))
            {
                TAddCategory Change = new TAddCategory(new TCategory(TextCategoryName.Text, CurrentGroup.ID));
                Storage.SubmitChange(Change);
                ChangeManager.AddChange(Change);

                TextCategoryName.Clear();
                TextCategoryName.Focus();
            }
        }

        private void DeleteView()
        {
            if (CurrentView != null)
            {
                TDeleteView Change = new TDeleteView(CurrentView.ID);
                Storage.SubmitChange(Change);
                ListColumns.Items.Clear();
                CurrentView = TView.Default();
                LabelSelectedView.Text = "Выберите представление";
            }
        }

        private void DeleteTask()
        {
            if (CurrentTask != null)
            {
                TDeleteTask Change = new TDeleteTask(CurrentTask.ID);
                Storage.SubmitChange(Change);
                ChangeManager.AddChange(Change);
                CurrentTask = null;
            }
        }

        private void DeleteContact()
        {
            if (CurrentContact != null)
            {
                TDeleteContact Change = new TDeleteContact(CurrentContact.ID);
                Storage.SubmitChange(Change);
                ChangeManager.AddChange(Change);
                CurrentContact = null;
            }
        }

        private void DeleteGroup()
        {
            if (CurrentGroup != null)
            {
                TDeleteGroup Change = new TDeleteGroup(CurrentGroup.ID);
                Storage.SubmitChange(Change);
                ChangeManager.AddChange(Change);

                ListCategories.Items.Clear();
                CurrentGroup = null;
                LabelSelectedGroup.Text = "Выберите группу";
            }
        }

        private void DeleteCategory()
        {
            if (CurrentCategory != null)
            {
                TDeleteCategory Change = new TDeleteCategory(CurrentCategory.ID);
                Storage.SubmitChange(Change);
                ChangeManager.AddChange(Change);
                CurrentCategory = null;
            }
        }

        private void EditTask()
        {
            if (CurrentTask != null)
            {
                FormTask Task = new FormTask(Storage, ChangeManager, CurrentTask);
                Task.FormClosed += new FormClosedEventHandler(Task_FormClosed);
                Task.ShowDialog();
            }
        }

        private void AddTaskToList(TTask Task, String Group)
        {
            ListViewItem Item = ListTasks.Items.Add(Task.Name, 0);
            Item.Group = ListTasks.Groups[Group];
            Item.Tag = Task;

            if (Task.Done)
            {
                Item.Font = new System.Drawing.Font(Item.Font, System.Drawing.FontStyle.Strikeout);
                Item.ForeColor = System.Drawing.Color.Gray;
            }
          
            if (CurrentView.Text)
                Item.SubItems.Add(Task.Text);

            if (CurrentView.Done)
            {
                if (Task.Done) Item.SubItems.Add("Да");
                else Item.SubItems.Add("Нет");
            }

            if (CurrentView.Start)
                Item.SubItems.Add(Task.Start);

            if (CurrentView.Finish)
                Item.SubItems.Add(Task.Finish);

            if (CurrentView.Importance)
                Item.SubItems.Add(Task.Importance);

            if (CurrentView.Complete)
                Item.SubItems.Add(Task.Complete);
        }

        private void FillTaskList(TCategory Category)
        {
            List<TTask> TaskList;

            ListTasks.Items.Clear();
            ListTasks.Groups.Clear();

            LabelGroupName.Text = "Нет";

            if (Category == null)
            {
                TaskList = Storage.GetTaskList();
                LabelCategoryName.Text = "Нет";
            }
            else
            {
                TaskList = Storage.GetTaskList(Category);
                LabelCategoryName.Text = Category.Name;
            }

            if (TaskList != null)
            {
                foreach (TTask Task in TaskList)
                {
                    AddTaskToList(Task, String.Empty);
                }
            }
        }

        private void FillTaskList(TGroup Group)
        {
            List<TCategory> CategoryList;
            List<TTaskCategory> TaskCategoryList;

            ListTasks.Items.Clear();
            ListTasks.Groups.Clear();

            LabelCategoryName.Text = "Нет";

            if (Group == null)
            {
                LabelGroupName.Text = "Нет";
                CategoryList = Storage.GetCategoryList();
                TaskCategoryList = Storage.GetTaskCategoryList();
            }
            else
            {
                LabelGroupName.Text = Group.Name;
                CategoryList = Storage.GetCategoryList(Group);
                TaskCategoryList = Storage.GetTaskCategoryList(Group);
            }

            if (CategoryList != null)
            {
                foreach (TCategory Category in CategoryList)
                    ListTasks.Groups.Add(Category.ID.ToString(), Category.Name);
            }

            if (TaskCategoryList != null)
            {
                foreach (TTaskCategory TaskCategory in TaskCategoryList)
                {
                    TTask Task = Storage.GetTask(TaskCategory.TaskID);
                    TCategory Category = Storage.GetCategory(TaskCategory.CategoryID);

                    AddTaskToList(Task, Category.ID.ToString());
                }
            }
        }

        private void FillContactList()
        {
            ListContacts.Items.Clear();

            List<TContact> ContactList = Storage.GetContactList();

            if (ContactList != null)
            {
                foreach (TContact Contact in ContactList)
                {
                    ListViewItem Item = ListContacts.Items.Add(Contact.Name, 4);
                    Item.SubItems.Add(Contact.Mobile);
                    Item.SubItems.Add(Contact.Home);
                    Item.SubItems.Add(Contact.Email);
                    Item.Tag = Contact;
                }
            }
        }

        private void FillGroupList()
        {
            ListGroups.Items.Clear();

            List<TGroup> GroupList = Storage.GetGroupList();

            if (GroupList != null)
            {
                foreach (TGroup Group in GroupList)
                {
                    ListViewItem Item = ListGroups.Items.Add(Group.Name, 1);
                    Item.Tag = Group;
                }
            }
        }

        private void FillCategoryList()
        {
            ListCategories.Items.Clear();

            List<TCategory> CategoryList = Storage.GetCategoryList(CurrentGroup);

            if (CategoryList != null)
            {
                foreach (TCategory Category in CategoryList)
                {
                    ListViewItem Item = ListCategories.Items.Add(Category.Name, 2);
                    Item.Tag = Category;
                }
            }
        }

        private void FillViewMenu()
        {
            ButtonView.DropDownItems.Clear();

            List<TView> ViewList = Storage.GetViewList();

            if (ViewList != null)
            {
                foreach (TView View in ViewList)
                {
                    ToolStripMenuItem Item = new ToolStripMenuItem(View.Caption);
                    Item.Tag = View;
                    Item.Image = Resources.View;
                    Item.Click += new EventHandler(ButtonViewClick);
                    ButtonView.DropDownItems.Add(Item);
                }
            }

            if (ButtonView.DropDownItems.Count == 0)
            {
                ToolStripMenuItem Item = new ToolStripMenuItem("Нет представлений");
                Item.Enabled = false;
                ButtonView.DropDownItems.Add(Item);
            }
        }

        private void ButtonViewClick(object sender, EventArgs e)
        {
            CurrentView = (TView)((ToolStripMenuItem)sender).Tag;
            Settings.Default.CurrentView = CurrentView.ID;

            LoadView();
            FillTaskList(CurrentCategory);
        }

        private void FillGroupMenu()
        {
            ButtonGroup.DropDownItems.Clear();
        
            List<TGroup> GroupList = Storage.GetGroupList();

            if (GroupList != null)
            {
                foreach (TGroup Group in GroupList)
                {
                    ToolStripMenuItem Item = new ToolStripMenuItem(Group.Name);
                    Item.Tag = Group;
                    Item.Image = Resources.Group;
                    Item.Click += new EventHandler(ButtonGroupClick);
                    ButtonGroup.DropDownItems.Add(Item);
                }
            }
            

            if (ButtonGroup.DropDownItems.Count > 0)
            {
                ButtonGroup.DropDownItems.Add(new ToolStripSeparator());

                ToolStripMenuItem MenuShowAll = new ToolStripMenuItem("Показать все группы");
                MenuShowAll.Tag = null;
                MenuShowAll.Click += new EventHandler(ButtonGroupClick);
                ButtonGroup.DropDownItems.Add(MenuShowAll);

                ToolStripMenuItem MenuHideAll = new ToolStripMenuItem("Скрыть группы");
                MenuHideAll.Tag = null;
                MenuHideAll.Click += new EventHandler(ButtonHideGroups);
                ButtonGroup.DropDownItems.Add(MenuHideAll);
            }
            else
            {
                ToolStripMenuItem Item = new ToolStripMenuItem("Нет групп");
                Item.Enabled = false;
                ButtonGroup.DropDownItems.Add(Item);
            }
        }

        private void ButtonGroupClick(object sender, EventArgs e)
        {
            CurrentGroup = (TGroup)((ToolStripMenuItem)sender).Tag;
            CurrentCategory = null;

            FillCategoryMenu();
            FillTaskList(CurrentGroup);
        }

        void ButtonHideGroups(object sender, EventArgs e)
        {
            CurrentGroup = null;
            CurrentCategory = null;

            FillCategoryMenu();
            FillTaskList(CurrentCategory);
        }

        private void FillCategoryMenu()
        {
            List<TCategory> CategoryList;

            ButtonCategory.DropDownItems.Clear();

            if (CurrentGroup == null)
            {
                CategoryList = Storage.GetCategoryList();
            }
            else
            {
                CategoryList = Storage.GetCategoryList(CurrentGroup);
            }
            

            if (CategoryList != null)
            {
                foreach (TCategory Category in CategoryList)
                {
                    ToolStripMenuItem Item = new ToolStripMenuItem(Category.Name);
                    Item.Tag = Category;
                    Item.Image = Resources.Category;
                    Item.Click += new EventHandler(ButtonCategoryClick);
                    ButtonCategory.DropDownItems.Add(Item);
                }
            }

            if (ButtonCategory.DropDownItems.Count == 0)
            {
                ToolStripMenuItem Item = new ToolStripMenuItem("Нет категорий");
                Item.Enabled = false;
                ButtonCategory.DropDownItems.Add(Item);
            }
        }

        private void ButtonCategoryClick(object sender, EventArgs e)
        {
            FillTaskList((TCategory)((ToolStripMenuItem)sender).Tag);
        }

        private void FillContextCategory()
        {
            MenuContext.Items.Clear();

            if (CurrentTask != null)
            {
                List<TGroup> GroupList = Storage.GetGroupList();

                if (GroupList != null)
                {
                    foreach (TGroup Group in GroupList)
                    {
                        ToolStripMenuItem Item = new ToolStripMenuItem(Group.Name);
                        Item.Tag = Group;
                        Item.Image = Resources.Group;
                        MenuContext.Items.Add(Item);

                        List<TCategory> CategoryList = Storage.GetCategoryList(Group);

                        if (CategoryList != null)
                        {
                            foreach (TCategory Category in CategoryList)
                            {
                                ToolStripMenuItem SubItem = new ToolStripMenuItem(Category.Name);
                                SubItem.Tag = Category;
                                SubItem.Image = Resources.Category;
                                SubItem.Click += new EventHandler(SubItem_Click);
                                Item.DropDownItems.Add(SubItem);
                            }
                        }
                    }
                }

                List<TCategory> ExistCategoryList = Storage.GetCategoryList(CurrentTask);

                if ((ExistCategoryList != null) && (ExistCategoryList.Count > 0))
                {

                    MenuContext.Items.Add(new ToolStripSeparator());

                    ToolStripMenuItem ItemDelete = new ToolStripMenuItem("Удалить");
                    MenuContext.Items.Add(ItemDelete);

                    foreach (TCategory Category in ExistCategoryList)
                    {
                        ToolStripMenuItem Item = new ToolStripMenuItem(Category.Name);
                        Item.Tag = Category.ID;
                        Item.Click += new EventHandler(MenuCategoryDelete);
                        ItemDelete.DropDownItems.Add(Item);
                    }
                }
            }
        }

        private void MenuCategoryDelete(object sender, EventArgs e)
        {

            TDeleteTaskCategory Change = new TDeleteTaskCategory(CurrentTask.ID, (Guid)((ToolStripMenuItem)sender).Tag);
            Storage.SubmitChange(Change);
            ChangeManager.AddChange(Change);
            
            FillTaskList(CurrentCategory);
        }

        private void SubItem_Click(object sender, EventArgs e)
        {
            TCategory Category = (TCategory)(sender as ToolStripMenuItem).Tag;

            TAddTaskCategory Change = new TAddTaskCategory(new TTaskCategory(CurrentTask.ID, Category.ID, Category.GroupID));
            Storage.SubmitChange(Change);
            ChangeManager.AddChange(Change);
            FillTaskList(CurrentCategory);
        }

        private static TTask Temp = new TTask();

        private static bool Condition(TTask Task)
        {
            if (
                (Task.Name.ToLower().Contains(Temp.Name.ToLower())) &&
                (Task.Text.ToLower().Contains(Temp.Text.ToLower())) &&
                (Task.Importance.ToLower().Contains(Temp.Importance.ToLower())) &&
                (Task.Complete.ToLower().Contains(Temp.Complete.ToLower()))
                )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Find()
        {
            Temp.Name = TextSearchName.Text;
            Temp.Text = TextText.Text;
            Temp.Complete = TextComplete.Text;
            Temp.Importance = TextImportance.Text;

            List<TTask> Tasks = Storage.GetTaskList().FindAll(Condition);

            ListTasks.Items.Clear();
            foreach (TTask Task in Tasks)
            {
                AddTaskToList(Task, String.Empty);
            }
        }


    }
}