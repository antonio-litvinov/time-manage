using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MobileClient.Properties;
using WinToolZone.CSLMail;
using System.Net;
using System.IO;
using System.Xml.Serialization;

namespace MobileClient
{
    public partial class FormMain : Form
    {
        TStorage Storage;
        TChangeManager ChangeManager;
        TTransport Transport;
        TTask CurrentTask;
        TCategory CurrentCategory;
        TSettings Settings;

        public FormMain()
        {
            InitializeComponent();

            Settings = TSettings.Load("Settings.xml");

            if (File.Exists("Storage.xml"))
                Storage = TStorage.LoadStorage("Storage.xml");
            else
                Storage = new TStorage();

            Transport = new TTransport(ref Storage, ref Settings, ref ListLogs);
            ChangeManager = new TChangeManager();
            ChangeManager.FullBuffer += new ChangeEvent(ChangeManager_FullBuffer);
            FillTaskList(CurrentCategory);
            FillCategoryMenu();
            ShowSettings();
        }
        
        void ChangeManager_FullBuffer(List<TChange> ChangeList)
        {
            Transport.SendChangeList(ChangeList);
        }

        private void ShowSettings()
        {
            TextServer.Text = Settings.Server;

            TextFrom.Text = Settings.From;
            TextTo.Text = Settings.To;

            TextLogin.Text = Settings.Login;
            TextPassword.Text = Settings.Password;

            TextPOP.Text = Settings.POP.ToString();
            TextSMTP.Text = Settings.SMTP.ToString();

            Settings.Save();
        }

        private void SaveSettings()
        {
            Settings.Server = TextServer.Text;

            Settings.From = TextFrom.Text;
            Settings.To = TextTo.Text;

            Settings.Login = TextLogin.Text;
            Settings.Password = TextPassword.Text;

            Settings.POP = short.Parse(TextPOP.Text);
            Settings.SMTP = short.Parse(TextSMTP.Text);

            Settings.Save();
        }

        private void Sync()
        {
            Transport.SendMessage("ID", Settings.LastChange.ToString());
        }

        private void AddTask()
        {
            if (TextTaskName.Text.Trim().Length > 0)
            {
                TAddTask Change = new TAddTask(new TTask(TextTaskName.Text));
                Storage.SubmitChange(Change);

                FillTaskList(CurrentCategory);

                ChangeManager.AddChange(Change);
                Settings.LastChange = Change.ID;

                TextTaskName.Text = String.Empty;
                TextTaskName.Focus();
            }
        }

        private void DeleteTask()
        {
            if (CurrentTask != null)
            {
                TDeleteTask Change = new TDeleteTask(CurrentTask.ID);
                Storage.SubmitChange(Change);

                FillTaskList(CurrentCategory);

                ChangeManager.AddChange(Change);
                Settings.LastChange = Change.ID;
                CurrentTask = null;
            }
        }

        private void AddTaskToList(TTask Task, String Group)
        {
            ListViewItem Item = new ListViewItem(Task.Name);
                
            Item.ImageIndex = 0;
            Item.Tag = Task;

            if (Task.Done)
                Item.ForeColor = System.Drawing.Color.Gray;
            
            ListTasks.Items.Add(Item);
        }

        private void FillTaskList(TCategory Category)
        {
            List<TTask> TaskList;

            ListTasks.Items.Clear();

            if (Category == null)
            {
                TaskList = Storage.GetTaskList();
            }
            else
            {
                TaskList = Storage.GetTaskList(Category);
            }

            if (TaskList != null)
            {
                foreach (TTask Task in TaskList)
                {
                    AddTaskToList(Task, String.Empty);
                }
            }
        }

        private void FillCategoryMenu()
        {
            TreeCategories.Nodes.Clear();
            foreach (TGroup Group in Storage.GetGroupList())
            {
                TreeNode Parent = new TreeNode(Group.Name);
                Parent.Tag = Group;
                Parent.ImageIndex = 1;
                Parent.SelectedImageIndex = 1;

                foreach (TCategory Category in Storage.GetCategoryList(Group))
                {
                    TreeNode Child = new TreeNode(Category.Name);
                    Child.Tag = Category;
                    Child.ImageIndex = 2;
                    Child.SelectedImageIndex = 2;
                    Parent.Nodes.Add(Child);
                }

                TreeCategories.Nodes.Add(Parent);
            }
        }

        private void ListTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListTasks.SelectedIndices.Count > 0)
                CurrentTask = (TTask)ListTasks.Items[ListTasks.SelectedIndices[0]].Tag;
            else
                CurrentTask = null;
        }

        private void FormMain_Closed(object sender, EventArgs e)
        {
            Settings.Save();
            Storage.SaveStorage("Storage.xml");
        }

        private void MenuExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MenuSync_Click(object sender, EventArgs e)
        {
            Sync();
        }

        private void MenuReceive_Click(object sender, EventArgs e)
        {
            Transport.ReadMessages();
            FillTaskList(CurrentCategory);
            FillCategoryMenu();
        }

        private void MenuUpdate_Click(object sender, EventArgs e)
        {
            FillTaskList(CurrentCategory);
            FillCategoryMenu();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            AddTask();
        }

        private void ButtonCategorySelect_Click(object sender, EventArgs e)
        {
            FillTaskList((TCategory)TreeCategories.SelectedNode.Tag);
            TabMain.SelectedIndex = 0;
        }

        private void ButtonSaveSettings_Click(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void ButtonInfo_Click(object sender, EventArgs e)
        {
            if (CurrentTask != null)
            {
                TextName.Text = CurrentTask.Name;
                TextText.Text = CurrentTask.Text;
                TabMain.SelectedIndex = 1;
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            DeleteTask();
        }

        private void MenuShowAll_Click(object sender, EventArgs e)
        {
            CurrentCategory = null;
            FillTaskList(CurrentCategory);
        }

    }
}