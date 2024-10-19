using System;
using System.Windows.Forms;
using System.Collections.Generic;
using Classes;
using Client.Properties;

namespace Client
{
    public partial class FormMain : Form
    {
        TStorage Storage;
        TTransport Transport;
        TChangeManager ChangeManager;

        TView CurrentView;
        TTask CurrentTask;
        TContact CurrentContact;
        TGroup CurrentGroup;
        TCategory CurrentCategory;

        Boolean LocalMode = false;

        public FormMain()
        {
            InitializeComponent();

            Storage = new TStorage(Settings.Default.Database);
            Transport = new TTransport();
            Transport.Info += new InfoEvent(Transport_Updated);
            Transport.Update += new UpdateEvent(Transport_Update);
            ChangeManager = new TChangeManager();
            ChangeManager.FullBuffer += new ChangeEvent(ChangeManager_FullBuffer);

            FillViewList();
            FillViewMenu();

            try
            {
                CurrentView = Storage.GetView(Settings.Default.CurrentView);
                if (CurrentView == null)
                {
                    CurrentView = TView.Default();
                }
            }
            catch
            {
                CurrentView = TView.Default();
            }

            LoadView();

            FillTaskList(CurrentCategory);

            FillGroupList();
            FillGroupMenu();

            FillCategoryMenu();

            FillContactList();

            ShowSettings();

            Sync();
        }

        void Transport_Update()
        {
            FillTaskList(CurrentCategory);

            FillGroupList();
            FillGroupMenu();

            FillCategoryMenu();

            FillContactList();
        }

        void ChangeManager_FullBuffer(List<TChange> ChangeList)
        {
            if (!LocalMode)
            Transport.SendChangeList(ChangeList);
        }

        void Transport_Updated(string Message)
        {
            LabelSync.Text = Message;
        }

        void Task_FormClosed(object sender, FormClosedEventArgs e)
        {
            FillTaskList(CurrentCategory);
        }

        private void ListTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListTasks.SelectedItems.Count > 0)
                CurrentTask = (TTask)ListTasks.SelectedItems[0].Tag;
            else
                CurrentTask = null;
        }

        private void ListViews_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListViews.SelectedItems.Count > 0)
            {
                CurrentView = (TView)ListViews.SelectedItems[0].Tag;
                ShowView();
            }
            else
            {
                CurrentView = null;
                ShowView();
            }
        }

        private void ListGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListGroups.SelectedItems.Count > 0)
            {
                CurrentGroup = (TGroup)ListGroups.SelectedItems[0].Tag;
                FillCategoryList();
                LabelSelectedGroup.Text = CurrentGroup.Name;
            }
            else
            {
                CurrentGroup = null;
                ListCategories.Items.Clear();
                LabelSelectedGroup.Text = "Выберите группу";
            }
        }

        private void ListCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListCategories.SelectedItems.Count > 0)
            {
                CurrentCategory = (TCategory)ListCategories.SelectedItems[0].Tag;
            }
            else
            {
                CurrentCategory = null;
            }
        }

        private void ButtonViewAdd_Click(object sender, EventArgs e)
        {
            AddView();
            FillViewList();
            FillViewMenu();
        }

        private void ButtonViewDelete_Click(object sender, EventArgs e)
        {
            DeleteView();
            FillViewList();
            FillViewMenu();
            LoadView();
            ShowView();
        }

         private void ButtonTaskAdd_Click(object sender, EventArgs e)
        {
            FormTask Task = new FormTask(Storage, ChangeManager);

            Task.FormClosed += new FormClosedEventHandler(Task_FormClosed);
            Task.ShowDialog();
        }

        private void ButtonTaskQuickAdd_Click(object sender, EventArgs e)
        {
            AddTask();
            FillTaskList(CurrentCategory);
        }

        private void ButtonTaskDelete_Click(object sender, EventArgs e)
        {
            DeleteTask();
            FillTaskList(CurrentCategory);
        }

        private void ButtonTaskEdit_Click(object sender, EventArgs e)
        {
            EditTask();
        }

        private void ButtonGroupAdd_Click(object sender, EventArgs e)
        {
            AddGroup();
            FillGroupList();
            FillGroupMenu();
        }

        private void ButtonGroupDelete_Click(object sender, EventArgs e)
        {
            DeleteGroup();
            FillGroupList();
            FillGroupMenu();
        }

        private void ButtonCategoryAdd_Click(object sender, EventArgs e)
        {
            AddCategory();
            FillCategoryList();
            FillCategoryMenu();
        }

        private void ButtonCategoryDelete_Click(object sender, EventArgs e)
        {
            DeleteCategory();
            FillCategoryList();
            FillCategoryMenu();
        }

        private void TextTaskName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddTask();
                FillTaskList(CurrentCategory);
            }
        }

        private void TextViewName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddView();
                FillViewList();
                FillViewMenu();
            }
        }

        private void TextGroupName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddGroup();
                FillGroupList();
                FillGroupMenu();
            }
        }

        private void TextContactName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddContact();
                FillContactList();
            }
        }

        private void TextCategoryName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddCategory();
                FillCategoryList();
                FillCategoryMenu();
            }
        }

        private void ListTasks_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DeleteTask();
                FillTaskList(CurrentCategory);
            }

            if (e.KeyCode == Keys.Enter)
            {
                EditTask();
            }
        }

        private void ListGroups_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DeleteGroup();
                FillGroupList();
                FillGroupMenu();
            }
        }

        private void ListContacts_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DeleteContact();
                FillContactList();
                ShowContact();
            }
        }

        private void ListViews_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DeleteView();
                FillViewList();
                FillViewMenu();
                LoadView();
            }
        }

        private void ListTasks_DoubleClick(object sender, EventArgs e)
        {
            EditTask();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!LocalMode)
                Transport.ReadMessages();
        }

        private void ListTasks_MouseUp(object sender, MouseEventArgs e)
        {
            FillContextCategory();
        }

        private void ButtonSync_Click(object sender, EventArgs e)
        {
            Sync();
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveSettings();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ResizeColumns()
        {
            foreach (ColumnHeader Column in ListTasks.Columns)
            {
                Column.Width = ((ListTasks.Width - 4) / ListTasks.Columns.Count);
            }

            foreach (ColumnHeader Column in ListContacts.Columns)
            {
                Column.Width = ((ListContacts.Width - 4) / ListContacts.Columns.Count);
            }
        }

        private void FormMain_Resize(object sender, EventArgs e)
        {
            ResizeColumns();
        }

        private void ListContacts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListContacts.SelectedItems.Count > 0)
            {
                CurrentContact = (TContact)ListContacts.SelectedItems[0].Tag;
                ShowContact();
            }
            else
            {
                CurrentContact = null;
                ShowContact();
            }
        }

        private void ButtonContactAdd_Click(object sender, EventArgs e)
        {
            AddContact();
            FillContactList();
            ShowContact();
        }

        private void ButtonContactDelete_Click(object sender, EventArgs e)
        {
            DeleteContact();
            FillContactList();
            ShowContact();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            EditContact();
            FillContactList();
            LabelSync.Text = "Данные о контакте сохранены";
        }

        private void ButtonSaveSettings_Click(object sender, EventArgs e)
        {
            SaveSettings();
            LabelSync.Text = "Настройки сохранены";
        }

        private void ButtonViewSave_Click(object sender, EventArgs e)
        {
            EditView();
            FillViewList();
            FillViewMenu();
            LabelSync.Text = "Настройки представления сохранены";
        }

        private void ButtonFind_Click(object sender, EventArgs e)
        {
            Find();
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            FillTaskList(CurrentCategory);
        }
    }
}