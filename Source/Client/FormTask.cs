using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Classes;
using Client.Properties;
using System.IO;
using System.Diagnostics;

namespace Client
{
    public partial class FormTask : Form
    {
        TTask CurrentTask;
        TStorage Storage;
        TChangeManager ChangeManager;
        
        // Default
        public FormTask()
        {
            InitializeComponent();
        }

        // For new task
        public FormTask(TStorage Storage, TChangeManager ChangeManager)
        {
            InitializeComponent();

            MenuCategories.Hide();
            ListCategories.Hide();

            this.Storage = Storage;
            this.ChangeManager = ChangeManager;
        }

        // For exist task
        public FormTask(TStorage Storage, TChangeManager ChangeManager, TTask CurrentTask)
        {
            InitializeComponent();

            this.CurrentTask = CurrentTask;
            this.Storage = Storage;
            this.ChangeManager = ChangeManager;
            
            FillCategoryMenu();
            FillCategoryList();

            FillContactMenu();
            FillContactList();

            FillDocumentList();
        }

        private void LoadTask()
        {
            if (CurrentTask != null)
            {
                TextName.Text = CurrentTask.Name;
                TextText.Text = CurrentTask.Text;
                CheckDone.Checked = CurrentTask.Done;
                TextImportance.Text = CurrentTask.Importance;
                TextComplete.Text = CurrentTask.Complete;

                // Start date
                if ((CurrentTask.Start != String.Empty) && (CurrentTask.Start != null))
                {
                    CheckStart.Checked = true;
                    DateStart.Value = Convert.ToDateTime(CurrentTask.Start);
                }
                else  CheckStart.Checked = false;

                // Finish date
                if ((CurrentTask.Finish != String.Empty) && (CurrentTask.Finish != null))
                {
                    CheckFinish.Checked = true;
                    DateFinish.Value = Convert.ToDateTime(CurrentTask.Finish);
                }
                else CheckFinish.Checked = false;
            }
            else Close();
        }

        /*----------------------------------------------------------------------------*/
        /* Заполнение меню                                                            */

        private void FillContactMenu()
        {
            List<TContact> ContactList = Storage.GetContactList();

            if (ContactList != null)
            {
                foreach (TContact Contact in ContactList)
                {
                    ToolStripMenuItem Item = new ToolStripMenuItem(Contact.Name);
                    Item.Tag = Contact;
                    Item.Click += new EventHandler(ButtonContactClick);
                    ButtonContactAdd.DropDownItems.Add(Item);
                }
                if (ButtonContactAdd.DropDownItems.Count == 0)
                {
                    ToolStripMenuItem Item = new ToolStripMenuItem("Нет контактов");
                    Item.Enabled = false;
                    ButtonContactAdd.DropDownItems.Add(Item);
                }
            }
        }
        
        private void FillCategoryMenu()
        {
            List<TGroup> GroupList = Storage.GetGroupList();

            if (GroupList != null)
            {
                foreach (TGroup Group in GroupList)
                {
                    ToolStripMenuItem GroupItem = new ToolStripMenuItem(Group.Name);
                    GroupItem.Tag = Group;
                    ButtonCategoryAdd.DropDownItems.Add(GroupItem);

                    List<TCategory> CategoryList = Storage.GetCategoryList(Group);

                    if (CategoryList != null)
                    {
                        foreach (TCategory Category in CategoryList)
                        {
                            ToolStripMenuItem CategoryItem = new ToolStripMenuItem(Category.Name);
                            CategoryItem.Tag = Category;
                            CategoryItem.Click += new EventHandler(ButtonCategoryClick);
                            GroupItem.DropDownItems.Add(CategoryItem);
                        }
                        if (GroupItem.DropDownItems.Count == 0)
                        {
                            ToolStripMenuItem Item = new ToolStripMenuItem("Нет категорий");
                            Item.Enabled = false;
                            GroupItem.DropDownItems.Add(Item);
                        }
                    }
                }
            }

            if (ButtonCategoryAdd.DropDownItems.Count == 0)
            {
                ToolStripMenuItem Item = new ToolStripMenuItem("Нет категорий");
                Item.Enabled = false;
                ButtonCategoryAdd.DropDownItems.Add(Item);
            }
        }

        /*----------------------------------------------------------------------------*/
        /* Заполнение списков                                                         */

        private void FillContactList()
        {
            ListContacts.Items.Clear();

            List<TContact> ContactList = Storage.GetContactList(CurrentTask);

            if (ContactList != null)
            {
                foreach (TContact Contact in ContactList)
                {
                    ListViewItem Item = ListContacts.Items.Add(Contact.Name);
                    Item.ImageIndex = 0;

                    Item.SubItems.Add(Contact.Mobile);
                    Item.SubItems.Add(Contact.Home);
                    Item.SubItems.Add(Contact.Email);
                    Item.Tag = Contact.ID;
                }
            }
        }

        private void FillDocumentList()
        {
            ListDocuments.Items.Clear();

            List<TTaskDocument> DocumentList = Storage.GetDocumentList(CurrentTask);

            if (DocumentList != null)
            {
                foreach (TTaskDocument Document in DocumentList)
                {
                    ListViewItem Item = ListDocuments.Items.Add(Document.Link);
                    Item.ImageIndex = 1;

                    Item.Tag = Document.ID;
                }
            }
        }

        private void FillCategoryList()
        {
            ListCategories.Items.Clear();

            List<TCategory> CategoryList = Storage.GetCategoryList(CurrentTask);

            if (CategoryList != null)
            {
                foreach (TCategory Category in CategoryList)
                {
                    ListViewItem Item = ListCategories.Items.Add(Category.Name);

                    TGroup Group = Storage.GetGroup(Category.GroupID);
                    if (Group != null)
                        Item.SubItems.Add(Group.Name);

                    Item.ImageIndex = 2;
                    Item.Tag = Category.ID;
                }
            }
        }

        /*----------------------------------------------------------------------------*/
        /* Собственные обработчики                                                    */

        private void ButtonContactClick(object sender, EventArgs e)
        {
            TContact Contact = (TContact)((ToolStripMenuItem)sender).Tag;

            TAddTaskContact Change = new TAddTaskContact(new TTaskContact(CurrentTask.ID, Contact.ID));
            Storage.SubmitChange(Change);
            ChangeManager.AddChange(Change);

            FillContactList();
        }

        private void ButtonCategoryClick(object sender, EventArgs e)
        {
            TCategory Category = (TCategory)((ToolStripMenuItem)sender).Tag;

            TAddTaskCategory Change = new TAddTaskCategory(new TTaskCategory(CurrentTask.ID, Category.ID, Category.GroupID));
            Storage.SubmitChange(Change);
            ChangeManager.AddChange(Change);
            
            FillCategoryList();
        }


        private void AddTask()
        {
            String Start;
            String Finish;

            if (CheckStart.Checked)
                Start = DateStart.Value.Date.ToShortDateString();
            else
                Start = String.Empty;

            if (CheckFinish.Checked)
                Finish = DateFinish.Value.Date.ToShortDateString();
            else
                Finish = String.Empty;

            TTask Task = new TTask(TextName.Text, TextText.Text, CheckDone.Checked, Start, Finish, TextComplete.Text, TextImportance.Text);

            TChange Change = new TAddTask(Task);
            Storage.SubmitChange(Change);
            ChangeManager.AddChange(Change);
        }

        private void EditTask()
        {
            if (TextName.Text != CurrentTask.Name)
            {
                TChange Change = new TEditName(CurrentTask.ID, TextName.Text);
                Storage.SubmitChange(Change);
                ChangeManager.AddChange(Change);
            }

            if (TextText.Text != CurrentTask.Text)
            {
                TChange Change = new TEditText(CurrentTask.ID, TextText.Text);
                Storage.SubmitChange(Change);
                ChangeManager.AddChange(Change);
            }

            if (TextImportance.Text != CurrentTask.Importance)
            {
                TChange Change = new TEditImportance(CurrentTask.ID, TextImportance.Text);
                Storage.SubmitChange(Change);
                ChangeManager.AddChange(Change);
            }

            if (TextComplete.Text != CurrentTask.Complete)
            {
                TChange Change = new TEditComplete(CurrentTask.ID, TextComplete.Text);
                Storage.SubmitChange(Change);
                ChangeManager.AddChange(Change);
            }

            String Start;

            if (CheckStart.Checked)
                Start = DateStart.Value.Date.ToShortDateString();
            else
                Start = String.Empty;

            if (Start != CurrentTask.Start)
            {
                TChange Change = new TEditStart(CurrentTask.ID, Start);
                Storage.SubmitChange(Change);
                ChangeManager.AddChange(Change);
            }

            String Finish;

            if (CheckFinish.Checked)
                Finish = DateFinish.Value.Date.ToShortDateString();
            else
                Finish = String.Empty;

            if (Finish != CurrentTask.Start)
            {
                TChange Change = new TEditFinish(CurrentTask.ID, Finish);
                Storage.SubmitChange(Change);
                ChangeManager.AddChange(Change);
            }

            if (CheckDone.Checked != CurrentTask.Done)
            {
                TChange Change = new TEditDone(CurrentTask.ID, CheckDone.Checked);
                Storage.SubmitChange(Change);
                ChangeManager.AddChange(Change);
            }
        }

        private void ToolSave_Click(object sender, EventArgs e)
        {
            if (CurrentTask != null)
            {
                EditTask();
            }
            else
            {
                AddTask();
            }
            Close();
        }

        private void ButtonCategoryDelete_Click(object sender, EventArgs e)
        {
            if (ListCategories.SelectedItems.Count > 0)
            {
                Storage.SubmitChange(new TDeleteTaskCategory(CurrentTask.ID, (Guid)ListCategories.SelectedItems[0].Tag));
                FillCategoryList();
            }
        }

        private void FormTask_Shown(object sender, EventArgs e)
        {
            if (CurrentTask != null) LoadTask();
            ResizeColumns();
            TextName.Focus();
        }

        private void CheckStart_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckStart.Checked)
                DateStart.Enabled = true;
            else
                DateStart.Enabled = false;
        }

        private void CheckFinish_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckFinish.Checked)
                DateFinish.Enabled = true;
            else
                DateFinish.Enabled = false;
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ResizeColumns()
        {
            foreach (ColumnHeader Column in ListCategories.Columns)
            {
                Column.Width = ((ListCategories.Width - 4) / ListCategories.Columns.Count);
            }

            foreach (ColumnHeader Column in ListContacts.Columns)
            {
                Column.Width = ((ListContacts.Width - 4) / ListContacts.Columns.Count);
            }


            foreach (ColumnHeader Column in ListDocuments.Columns)
            {
                Column.Width = ((ListDocuments.Width - 4) / ListDocuments.Columns.Count);
            }
        }

        private void ButtonContactDelete_Click(object sender, EventArgs e)
        {
            if (ListContacts.SelectedItems.Count > 0)
            {
                Storage.SubmitChange(new TDeleteTaskContact(CurrentTask.ID, (Guid)ListContacts.SelectedItems[0].Tag));
                FillContactList();
            }
        }

        private void ButtonDocumentAdd_Click(object sender, EventArgs e)
        {
            if (DialogFile.ShowDialog() == DialogResult.OK)
            {
                TAddTaskDocument Change = new TAddTaskDocument(new TTaskDocument(CurrentTask.ID, DialogFile.FileName));
                Storage.SubmitChange(Change);
                FillDocumentList();
            }
        }

        private void ButtonDocumentOpen_Click(object sender, EventArgs e)
        {
            if (ListDocuments.SelectedItems.Count > 0)
            Process.Start(ListDocuments.SelectedItems[0].Text);
        }

        private void ListDocuments_DoubleClick(object sender, EventArgs e)
        {
            if (ListDocuments.SelectedItems.Count > 0)
                Process.Start(ListDocuments.SelectedItems[0].Text);
        }

        private void ButtonFolderAdd_Click(object sender, EventArgs e)
        {
            if (DialogFolder.ShowDialog() == DialogResult.OK)
            {
                TAddTaskDocument Change = new TAddTaskDocument(new TTaskDocument(CurrentTask.ID, DialogFolder.SelectedPath));
                Storage.SubmitChange(Change);
                FillDocumentList();
            }
        }

    }
}
