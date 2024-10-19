namespace MobileClient
{
    partial class FormMain
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu MenuMain;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс  следует удалить; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.MenuMain = new System.Windows.Forms.MainMenu();
            this.MenuExit = new System.Windows.Forms.MenuItem();
            this.MenuMenu = new System.Windows.Forms.MenuItem();
            this.MenuSync = new System.Windows.Forms.MenuItem();
            this.MenuReceive = new System.Windows.Forms.MenuItem();
            this.MenuUpdate = new System.Windows.Forms.MenuItem();
            this.TabMain = new System.Windows.Forms.TabControl();
            this.PageTasks = new System.Windows.Forms.TabPage();
            this.LabelInfo = new System.Windows.Forms.Label();
            this.LabelDelete = new System.Windows.Forms.Label();
            this.ButtonInfo = new System.Windows.Forms.PictureBox();
            this.ButtonDelete = new System.Windows.Forms.PictureBox();
            this.LabelTasks = new System.Windows.Forms.Label();
            this.ButtonAdd = new System.Windows.Forms.PictureBox();
            this.TextTaskName = new System.Windows.Forms.TextBox();
            this.LabelTaskName = new System.Windows.Forms.Label();
            this.LabelTaskCaption = new System.Windows.Forms.Label();
            this.ListTasks = new System.Windows.Forms.ListView();
            this.Images = new System.Windows.Forms.ImageList();
            this.LabelBackTasks = new System.Windows.Forms.PictureBox();
            this.PageTask = new System.Windows.Forms.TabPage();
            this.TextText = new System.Windows.Forms.TextBox();
            this.LabelText = new System.Windows.Forms.Label();
            this.TextName = new System.Windows.Forms.TextBox();
            this.LabelName = new System.Windows.Forms.Label();
            this.LabelTaskInfo = new System.Windows.Forms.Label();
            this.BackTask = new System.Windows.Forms.PictureBox();
            this.PageCategories = new System.Windows.Forms.TabPage();
            this.LabelCategorySelect = new System.Windows.Forms.Label();
            this.ButtonCategorySelect = new System.Windows.Forms.PictureBox();
            this.LabelCategories = new System.Windows.Forms.Label();
            this.LabelCategoriesCaption = new System.Windows.Forms.Label();
            this.TreeCategories = new System.Windows.Forms.TreeView();
            this.BackCategories = new System.Windows.Forms.PictureBox();
            this.PageLogs = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ListLogs = new System.Windows.Forms.ListBox();
            this.BackHistory = new System.Windows.Forms.PictureBox();
            this.PageSettings = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LabelSettings = new System.Windows.Forms.Label();
            this.TextFrom = new System.Windows.Forms.TextBox();
            this.LabelFrom = new System.Windows.Forms.Label();
            this.TextSMTP = new System.Windows.Forms.TextBox();
            this.LabelSMTP = new System.Windows.Forms.Label();
            this.TextPassword = new System.Windows.Forms.TextBox();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.TextLogin = new System.Windows.Forms.TextBox();
            this.LabelLogin = new System.Windows.Forms.Label();
            this.TextTo = new System.Windows.Forms.TextBox();
            this.LabelTo = new System.Windows.Forms.Label();
            this.TextPOP = new System.Windows.Forms.TextBox();
            this.LabelPOP = new System.Windows.Forms.Label();
            this.TextServer = new System.Windows.Forms.TextBox();
            this.LabelServer = new System.Windows.Forms.Label();
            this.BackSettings = new System.Windows.Forms.PictureBox();
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.MenuShowAll = new System.Windows.Forms.MenuItem();
            this.TabMain.SuspendLayout();
            this.PageTasks.SuspendLayout();
            this.PageTask.SuspendLayout();
            this.PageCategories.SuspendLayout();
            this.PageLogs.SuspendLayout();
            this.PageSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuMain
            // 
            this.MenuMain.MenuItems.Add(this.MenuExit);
            this.MenuMain.MenuItems.Add(this.MenuMenu);
            // 
            // MenuExit
            // 
            this.MenuExit.Text = "Выход";
            this.MenuExit.Click += new System.EventHandler(this.MenuExit_Click);
            // 
            // MenuMenu
            // 
            this.MenuMenu.MenuItems.Add(this.MenuSync);
            this.MenuMenu.MenuItems.Add(this.MenuReceive);
            this.MenuMenu.MenuItems.Add(this.MenuUpdate);
            this.MenuMenu.MenuItems.Add(this.MenuShowAll);
            this.MenuMenu.Text = "Меню";
            // 
            // MenuSync
            // 
            this.MenuSync.Text = "Синхронизировать";
            this.MenuSync.Click += new System.EventHandler(this.MenuSync_Click);
            // 
            // MenuReceive
            // 
            this.MenuReceive.Text = "Принять";
            this.MenuReceive.Click += new System.EventHandler(this.MenuReceive_Click);
            // 
            // MenuUpdate
            // 
            this.MenuUpdate.Text = "Обновить";
            this.MenuUpdate.Click += new System.EventHandler(this.MenuUpdate_Click);
            // 
            // TabMain
            // 
            this.TabMain.Controls.Add(this.PageTasks);
            this.TabMain.Controls.Add(this.PageTask);
            this.TabMain.Controls.Add(this.PageCategories);
            this.TabMain.Controls.Add(this.PageLogs);
            this.TabMain.Controls.Add(this.PageSettings);
            this.TabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabMain.Location = new System.Drawing.Point(0, 0);
            this.TabMain.Name = "TabMain";
            this.TabMain.SelectedIndex = 0;
            this.TabMain.Size = new System.Drawing.Size(240, 340);
            this.TabMain.TabIndex = 0;
            // 
            // PageTasks
            // 
            this.PageTasks.BackColor = System.Drawing.Color.Transparent;
            this.PageTasks.Controls.Add(this.LabelInfo);
            this.PageTasks.Controls.Add(this.LabelDelete);
            this.PageTasks.Controls.Add(this.ButtonInfo);
            this.PageTasks.Controls.Add(this.ButtonDelete);
            this.PageTasks.Controls.Add(this.LabelTasks);
            this.PageTasks.Controls.Add(this.ButtonAdd);
            this.PageTasks.Controls.Add(this.TextTaskName);
            this.PageTasks.Controls.Add(this.LabelTaskName);
            this.PageTasks.Controls.Add(this.LabelTaskCaption);
            this.PageTasks.Controls.Add(this.ListTasks);
            this.PageTasks.Controls.Add(this.LabelBackTasks);
            this.PageTasks.Location = new System.Drawing.Point(0, 0);
            this.PageTasks.Name = "PageTasks";
            this.PageTasks.Size = new System.Drawing.Size(240, 317);
            this.PageTasks.Text = "Задачи";
            // 
            // LabelInfo
            // 
            this.LabelInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelInfo.BackColor = System.Drawing.Color.White;
            this.LabelInfo.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Underline);
            this.LabelInfo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LabelInfo.Location = new System.Drawing.Point(5, 228);
            this.LabelInfo.Name = "LabelInfo";
            this.LabelInfo.Size = new System.Drawing.Size(52, 14);
            this.LabelInfo.Text = "Показать";
            this.LabelInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LabelDelete
            // 
            this.LabelDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelDelete.BackColor = System.Drawing.Color.White;
            this.LabelDelete.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Underline);
            this.LabelDelete.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LabelDelete.Location = new System.Drawing.Point(5, 287);
            this.LabelDelete.Name = "LabelDelete";
            this.LabelDelete.Size = new System.Drawing.Size(52, 14);
            this.LabelDelete.Text = "Удалить";
            this.LabelDelete.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ButtonInfo
            // 
            this.ButtonInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonInfo.Image = ((System.Drawing.Image)(resources.GetObject("ButtonInfo.Image")));
            this.ButtonInfo.Location = new System.Drawing.Point(15, 195);
            this.ButtonInfo.Name = "ButtonInfo";
            this.ButtonInfo.Size = new System.Drawing.Size(32, 32);
            this.ButtonInfo.Click += new System.EventHandler(this.ButtonInfo_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonDelete.Image = ((System.Drawing.Image)(resources.GetObject("ButtonDelete.Image")));
            this.ButtonDelete.Location = new System.Drawing.Point(15, 254);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(32, 32);
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // LabelTasks
            // 
            this.LabelTasks.BackColor = System.Drawing.Color.White;
            this.LabelTasks.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.LabelTasks.ForeColor = System.Drawing.Color.DimGray;
            this.LabelTasks.Location = new System.Drawing.Point(62, 81);
            this.LabelTasks.Name = "LabelTasks";
            this.LabelTasks.Size = new System.Drawing.Size(100, 14);
            this.LabelTasks.Text = "Задачи";
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Image = ((System.Drawing.Image)(resources.GetObject("ButtonAdd.Image")));
            this.ButtonAdd.Location = new System.Drawing.Point(201, 50);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(32, 32);
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // TextTaskName
            // 
            this.TextTaskName.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
            this.TextTaskName.Location = new System.Drawing.Point(62, 55);
            this.TextTaskName.Name = "TextTaskName";
            this.TextTaskName.Size = new System.Drawing.Size(133, 23);
            this.TextTaskName.TabIndex = 6;
            // 
            // LabelTaskName
            // 
            this.LabelTaskName.BackColor = System.Drawing.Color.White;
            this.LabelTaskName.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.LabelTaskName.ForeColor = System.Drawing.Color.DimGray;
            this.LabelTaskName.Location = new System.Drawing.Point(62, 38);
            this.LabelTaskName.Name = "LabelTaskName";
            this.LabelTaskName.Size = new System.Drawing.Size(100, 14);
            this.LabelTaskName.Text = "Название";
            // 
            // LabelTaskCaption
            // 
            this.LabelTaskCaption.BackColor = System.Drawing.Color.White;
            this.LabelTaskCaption.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.LabelTaskCaption.Location = new System.Drawing.Point(62, 12);
            this.LabelTaskCaption.Name = "LabelTaskCaption";
            this.LabelTaskCaption.Size = new System.Drawing.Size(100, 14);
            this.LabelTaskCaption.Text = "Задачи";
            // 
            // ListTasks
            // 
            this.ListTasks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ListTasks.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
            this.ListTasks.Location = new System.Drawing.Point(62, 98);
            this.ListTasks.Name = "ListTasks";
            this.ListTasks.Size = new System.Drawing.Size(171, 205);
            this.ListTasks.SmallImageList = this.Images;
            this.ListTasks.TabIndex = 1;
            this.ListTasks.View = System.Windows.Forms.View.List;
            this.ListTasks.SelectedIndexChanged += new System.EventHandler(this.ListTasks_SelectedIndexChanged);
            this.Images.Images.Clear();
            this.Images.Images.Add(((System.Drawing.Image)(resources.GetObject("resource"))));
            this.Images.Images.Add(((System.Drawing.Image)(resources.GetObject("resource1"))));
            this.Images.Images.Add(((System.Drawing.Image)(resources.GetObject("resource2"))));
            this.Images.Images.Add(((System.Drawing.Image)(resources.GetObject("resource3"))));
            // 
            // LabelBackTasks
            // 
            this.LabelBackTasks.Image = ((System.Drawing.Image)(resources.GetObject("LabelBackTasks.Image")));
            this.LabelBackTasks.Location = new System.Drawing.Point(0, 0);
            this.LabelBackTasks.Name = "LabelBackTasks";
            this.LabelBackTasks.Size = new System.Drawing.Size(240, 320);
            // 
            // PageTask
            // 
            this.PageTask.Controls.Add(this.TextText);
            this.PageTask.Controls.Add(this.LabelText);
            this.PageTask.Controls.Add(this.TextName);
            this.PageTask.Controls.Add(this.LabelName);
            this.PageTask.Controls.Add(this.LabelTaskInfo);
            this.PageTask.Controls.Add(this.BackTask);
            this.PageTask.Location = new System.Drawing.Point(0, 0);
            this.PageTask.Name = "PageTask";
            this.PageTask.Size = new System.Drawing.Size(232, 314);
            this.PageTask.Text = "Подробности";
            // 
            // TextText
            // 
            this.TextText.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
            this.TextText.Location = new System.Drawing.Point(62, 98);
            this.TextText.Multiline = true;
            this.TextText.Name = "TextText";
            this.TextText.Size = new System.Drawing.Size(171, 135);
            this.TextText.TabIndex = 12;
            // 
            // LabelText
            // 
            this.LabelText.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.LabelText.ForeColor = System.Drawing.Color.DimGray;
            this.LabelText.Location = new System.Drawing.Point(62, 81);
            this.LabelText.Name = "LabelText";
            this.LabelText.Size = new System.Drawing.Size(60, 15);
            this.LabelText.Text = "Описание";
            // 
            // TextName
            // 
            this.TextName.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
            this.TextName.Location = new System.Drawing.Point(62, 55);
            this.TextName.Name = "TextName";
            this.TextName.Size = new System.Drawing.Size(171, 23);
            this.TextName.TabIndex = 9;
            // 
            // LabelName
            // 
            this.LabelName.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.LabelName.ForeColor = System.Drawing.Color.DimGray;
            this.LabelName.Location = new System.Drawing.Point(62, 38);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(60, 15);
            this.LabelName.Text = "Название";
            // 
            // LabelTaskInfo
            // 
            this.LabelTaskInfo.BackColor = System.Drawing.Color.White;
            this.LabelTaskInfo.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.LabelTaskInfo.Location = new System.Drawing.Point(62, 12);
            this.LabelTaskInfo.Name = "LabelTaskInfo";
            this.LabelTaskInfo.Size = new System.Drawing.Size(100, 14);
            this.LabelTaskInfo.Text = "Подробности";
            // 
            // BackTask
            // 
            this.BackTask.Image = ((System.Drawing.Image)(resources.GetObject("BackTask.Image")));
            this.BackTask.Location = new System.Drawing.Point(0, 0);
            this.BackTask.Name = "BackTask";
            this.BackTask.Size = new System.Drawing.Size(240, 320);
            // 
            // PageCategories
            // 
            this.PageCategories.Controls.Add(this.LabelCategorySelect);
            this.PageCategories.Controls.Add(this.ButtonCategorySelect);
            this.PageCategories.Controls.Add(this.LabelCategories);
            this.PageCategories.Controls.Add(this.LabelCategoriesCaption);
            this.PageCategories.Controls.Add(this.TreeCategories);
            this.PageCategories.Controls.Add(this.BackCategories);
            this.PageCategories.Location = new System.Drawing.Point(0, 0);
            this.PageCategories.Name = "PageCategories";
            this.PageCategories.Size = new System.Drawing.Size(232, 314);
            this.PageCategories.Text = "Категории";
            // 
            // LabelCategorySelect
            // 
            this.LabelCategorySelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelCategorySelect.BackColor = System.Drawing.Color.White;
            this.LabelCategorySelect.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Underline);
            this.LabelCategorySelect.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LabelCategorySelect.Location = new System.Drawing.Point(1, 284);
            this.LabelCategorySelect.Name = "LabelCategorySelect";
            this.LabelCategorySelect.Size = new System.Drawing.Size(60, 14);
            this.LabelCategorySelect.Text = "Показать";
            this.LabelCategorySelect.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ButtonCategorySelect
            // 
            this.ButtonCategorySelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonCategorySelect.Image = ((System.Drawing.Image)(resources.GetObject("ButtonCategorySelect.Image")));
            this.ButtonCategorySelect.Location = new System.Drawing.Point(15, 251);
            this.ButtonCategorySelect.Name = "ButtonCategorySelect";
            this.ButtonCategorySelect.Size = new System.Drawing.Size(32, 32);
            this.ButtonCategorySelect.Click += new System.EventHandler(this.ButtonCategorySelect_Click);
            // 
            // LabelCategories
            // 
            this.LabelCategories.BackColor = System.Drawing.Color.White;
            this.LabelCategories.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.LabelCategories.ForeColor = System.Drawing.Color.DimGray;
            this.LabelCategories.Location = new System.Drawing.Point(62, 38);
            this.LabelCategories.Name = "LabelCategories";
            this.LabelCategories.Size = new System.Drawing.Size(100, 14);
            this.LabelCategories.Text = "Категории";
            // 
            // LabelCategoriesCaption
            // 
            this.LabelCategoriesCaption.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.LabelCategoriesCaption.Location = new System.Drawing.Point(62, 12);
            this.LabelCategoriesCaption.Name = "LabelCategoriesCaption";
            this.LabelCategoriesCaption.Size = new System.Drawing.Size(100, 14);
            this.LabelCategoriesCaption.Text = "Категории";
            // 
            // TreeCategories
            // 
            this.TreeCategories.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.TreeCategories.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
            this.TreeCategories.ImageIndex = 0;
            this.TreeCategories.ImageList = this.Images;
            this.TreeCategories.Indent = 23;
            this.TreeCategories.Location = new System.Drawing.Point(62, 55);
            this.TreeCategories.Name = "TreeCategories";
            this.TreeCategories.SelectedImageIndex = 0;
            this.TreeCategories.Size = new System.Drawing.Size(163, 240);
            this.TreeCategories.TabIndex = 13;
            // 
            // BackCategories
            // 
            this.BackCategories.Image = ((System.Drawing.Image)(resources.GetObject("BackCategories.Image")));
            this.BackCategories.Location = new System.Drawing.Point(0, 0);
            this.BackCategories.Name = "BackCategories";
            this.BackCategories.Size = new System.Drawing.Size(240, 320);
            // 
            // PageLogs
            // 
            this.PageLogs.Controls.Add(this.label1);
            this.PageLogs.Controls.Add(this.label2);
            this.PageLogs.Controls.Add(this.ListLogs);
            this.PageLogs.Controls.Add(this.BackHistory);
            this.PageLogs.Location = new System.Drawing.Point(0, 0);
            this.PageLogs.Name = "PageLogs";
            this.PageLogs.Size = new System.Drawing.Size(232, 314);
            this.PageLogs.Text = "История";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(62, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 14);
            this.label1.Text = "История изменений";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(62, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 14);
            this.label2.Text = "История";
            // 
            // ListLogs
            // 
            this.ListLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ListLogs.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.ListLogs.Location = new System.Drawing.Point(62, 55);
            this.ListLogs.Name = "ListLogs";
            this.ListLogs.Size = new System.Drawing.Size(163, 223);
            this.ListLogs.TabIndex = 1;
            // 
            // BackHistory
            // 
            this.BackHistory.Image = ((System.Drawing.Image)(resources.GetObject("BackHistory.Image")));
            this.BackHistory.Location = new System.Drawing.Point(0, 0);
            this.BackHistory.Name = "BackHistory";
            this.BackHistory.Size = new System.Drawing.Size(240, 320);
            // 
            // PageSettings
            // 
            this.PageSettings.Controls.Add(this.label3);
            this.PageSettings.Controls.Add(this.pictureBox1);
            this.PageSettings.Controls.Add(this.LabelSettings);
            this.PageSettings.Controls.Add(this.TextFrom);
            this.PageSettings.Controls.Add(this.LabelFrom);
            this.PageSettings.Controls.Add(this.TextSMTP);
            this.PageSettings.Controls.Add(this.LabelSMTP);
            this.PageSettings.Controls.Add(this.TextPassword);
            this.PageSettings.Controls.Add(this.LabelPassword);
            this.PageSettings.Controls.Add(this.TextLogin);
            this.PageSettings.Controls.Add(this.LabelLogin);
            this.PageSettings.Controls.Add(this.TextTo);
            this.PageSettings.Controls.Add(this.LabelTo);
            this.PageSettings.Controls.Add(this.TextPOP);
            this.PageSettings.Controls.Add(this.LabelPOP);
            this.PageSettings.Controls.Add(this.TextServer);
            this.PageSettings.Controls.Add(this.LabelServer);
            this.PageSettings.Controls.Add(this.BackSettings);
            this.PageSettings.Location = new System.Drawing.Point(0, 0);
            this.PageSettings.Name = "PageSettings";
            this.PageSettings.Size = new System.Drawing.Size(232, 314);
            this.PageSettings.Text = "Настройка";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Underline);
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(1, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 14);
            this.label3.Text = "Сохранить";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 255);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.Click += new System.EventHandler(this.ButtonSaveSettings_Click);
            // 
            // LabelSettings
            // 
            this.LabelSettings.BackColor = System.Drawing.Color.White;
            this.LabelSettings.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.LabelSettings.Location = new System.Drawing.Point(62, 12);
            this.LabelSettings.Name = "LabelSettings";
            this.LabelSettings.Size = new System.Drawing.Size(100, 14);
            this.LabelSettings.Text = "Настройки";
            // 
            // TextFrom
            // 
            this.TextFrom.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
            this.TextFrom.Location = new System.Drawing.Point(62, 191);
            this.TextFrom.Name = "TextFrom";
            this.TextFrom.Size = new System.Drawing.Size(160, 23);
            this.TextFrom.TabIndex = 24;
            // 
            // LabelFrom
            // 
            this.LabelFrom.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.LabelFrom.ForeColor = System.Drawing.Color.DimGray;
            this.LabelFrom.Location = new System.Drawing.Point(62, 173);
            this.LabelFrom.Name = "LabelFrom";
            this.LabelFrom.Size = new System.Drawing.Size(50, 15);
            this.LabelFrom.Text = "Адрес";
            // 
            // TextSMTP
            // 
            this.TextSMTP.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
            this.TextSMTP.Location = new System.Drawing.Point(144, 101);
            this.TextSMTP.Name = "TextSMTP";
            this.TextSMTP.Size = new System.Drawing.Size(77, 23);
            this.TextSMTP.TabIndex = 21;
            // 
            // LabelSMTP
            // 
            this.LabelSMTP.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.LabelSMTP.ForeColor = System.Drawing.Color.DimGray;
            this.LabelSMTP.Location = new System.Drawing.Point(145, 83);
            this.LabelSMTP.Name = "LabelSMTP";
            this.LabelSMTP.Size = new System.Drawing.Size(66, 15);
            this.LabelSMTP.Text = "Порт SMTP";
            // 
            // TextPassword
            // 
            this.TextPassword.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
            this.TextPassword.Location = new System.Drawing.Point(62, 281);
            this.TextPassword.Name = "TextPassword";
            this.TextPassword.Size = new System.Drawing.Size(159, 23);
            this.TextPassword.TabIndex = 18;
            // 
            // LabelPassword
            // 
            this.LabelPassword.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.LabelPassword.ForeColor = System.Drawing.Color.DimGray;
            this.LabelPassword.Location = new System.Drawing.Point(62, 263);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(53, 15);
            this.LabelPassword.Text = "Пароль";
            // 
            // TextLogin
            // 
            this.TextLogin.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
            this.TextLogin.Location = new System.Drawing.Point(62, 236);
            this.TextLogin.Name = "TextLogin";
            this.TextLogin.Size = new System.Drawing.Size(159, 23);
            this.TextLogin.TabIndex = 15;
            // 
            // LabelLogin
            // 
            this.LabelLogin.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.LabelLogin.ForeColor = System.Drawing.Color.DimGray;
            this.LabelLogin.Location = new System.Drawing.Point(62, 218);
            this.LabelLogin.Name = "LabelLogin";
            this.LabelLogin.Size = new System.Drawing.Size(50, 15);
            this.LabelLogin.Text = "Логин";
            // 
            // TextTo
            // 
            this.TextTo.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
            this.TextTo.Location = new System.Drawing.Point(62, 146);
            this.TextTo.Name = "TextTo";
            this.TextTo.Size = new System.Drawing.Size(160, 23);
            this.TextTo.TabIndex = 12;
            // 
            // LabelTo
            // 
            this.LabelTo.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.LabelTo.ForeColor = System.Drawing.Color.DimGray;
            this.LabelTo.Location = new System.Drawing.Point(62, 128);
            this.LabelTo.Name = "LabelTo";
            this.LabelTo.Size = new System.Drawing.Size(77, 15);
            this.LabelTo.Text = "Адрес сервера";
            // 
            // TextPOP
            // 
            this.TextPOP.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
            this.TextPOP.Location = new System.Drawing.Point(62, 101);
            this.TextPOP.Name = "TextPOP";
            this.TextPOP.Size = new System.Drawing.Size(77, 23);
            this.TextPOP.TabIndex = 9;
            // 
            // LabelPOP
            // 
            this.LabelPOP.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.LabelPOP.ForeColor = System.Drawing.Color.DimGray;
            this.LabelPOP.Location = new System.Drawing.Point(62, 83);
            this.LabelPOP.Name = "LabelPOP";
            this.LabelPOP.Size = new System.Drawing.Size(66, 15);
            this.LabelPOP.Text = "Порт POP";
            // 
            // TextServer
            // 
            this.TextServer.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
            this.TextServer.Location = new System.Drawing.Point(62, 56);
            this.TextServer.Name = "TextServer";
            this.TextServer.Size = new System.Drawing.Size(160, 23);
            this.TextServer.TabIndex = 7;
            // 
            // LabelServer
            // 
            this.LabelServer.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.LabelServer.ForeColor = System.Drawing.Color.DimGray;
            this.LabelServer.Location = new System.Drawing.Point(62, 38);
            this.LabelServer.Name = "LabelServer";
            this.LabelServer.Size = new System.Drawing.Size(50, 15);
            this.LabelServer.Text = "Сервер";
            // 
            // BackSettings
            // 
            this.BackSettings.Image = ((System.Drawing.Image)(resources.GetObject("BackSettings.Image")));
            this.BackSettings.Location = new System.Drawing.Point(0, 0);
            this.BackSettings.Name = "BackSettings";
            this.BackSettings.Size = new System.Drawing.Size(240, 320);
            // 
            // MenuShowAll
            // 
            this.MenuShowAll.Text = "Показать все задачи";
            this.MenuShowAll.Click += new System.EventHandler(this.MenuShowAll_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 340);
            this.Controls.Add(this.TabMain);
            this.KeyPreview = true;
            this.Menu = this.MenuMain;
            this.Name = "FormMain";
            this.Text = "Управление делами";
            this.Closed += new System.EventHandler(this.FormMain_Closed);
            this.TabMain.ResumeLayout(false);
            this.PageTasks.ResumeLayout(false);
            this.PageTask.ResumeLayout(false);
            this.PageCategories.ResumeLayout(false);
            this.PageLogs.ResumeLayout(false);
            this.PageSettings.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabMain;
        private System.Windows.Forms.TabPage PageTasks;
        private System.Windows.Forms.TabPage PageTask;
        private System.Windows.Forms.MenuItem MenuExit;
        private System.Windows.Forms.MenuItem MenuMenu;
        private System.Windows.Forms.ImageList Images;
        private System.Windows.Forms.ListView ListTasks;
        private System.Windows.Forms.MenuItem MenuSync;
        private System.Windows.Forms.MenuItem MenuReceive;
        private System.Windows.Forms.TabPage PageLogs;
        private System.Windows.Forms.ListBox ListLogs;
        private System.Windows.Forms.MenuItem MenuUpdate;
        private System.Windows.Forms.TabPage PageCategories;
        private System.Windows.Forms.TreeView TreeCategories;
        private System.Windows.Forms.PictureBox BackCategories;
        private System.Windows.Forms.TabPage PageSettings;
        private System.Windows.Forms.PictureBox BackSettings;
        private System.Windows.Forms.TextBox TextServer;
        private System.Windows.Forms.Label LabelServer;
        private System.Windows.Forms.TextBox TextFrom;
        private System.Windows.Forms.Label LabelFrom;
        private System.Windows.Forms.TextBox TextSMTP;
        private System.Windows.Forms.Label LabelSMTP;
        private System.Windows.Forms.TextBox TextPassword;
        private System.Windows.Forms.Label LabelPassword;
        private System.Windows.Forms.TextBox TextLogin;
        private System.Windows.Forms.Label LabelLogin;
        private System.Windows.Forms.TextBox TextTo;
        private System.Windows.Forms.Label LabelTo;
        private System.Windows.Forms.TextBox TextPOP;
        private System.Windows.Forms.Label LabelPOP;
        private System.Windows.Forms.PictureBox BackHistory;
        private System.Windows.Forms.Label LabelCategoriesCaption;
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.Label LabelTaskCaption;
        private System.Windows.Forms.PictureBox LabelBackTasks;
        private System.Windows.Forms.TextBox TextTaskName;
        private System.Windows.Forms.Label LabelTaskName;
        private System.Windows.Forms.Label LabelTasks;
        private System.Windows.Forms.PictureBox ButtonAdd;
        private System.Windows.Forms.PictureBox ButtonInfo;
        private System.Windows.Forms.PictureBox ButtonDelete;
        private System.Windows.Forms.Label LabelDelete;
        private System.Windows.Forms.Label LabelInfo;
        private System.Windows.Forms.Label LabelCategorySelect;
        private System.Windows.Forms.PictureBox ButtonCategorySelect;
        private System.Windows.Forms.Label LabelCategories;
        private System.Windows.Forms.TextBox TextName;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label LabelTaskInfo;
        private System.Windows.Forms.PictureBox BackTask;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LabelSettings;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TextText;
        private System.Windows.Forms.Label LabelText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuItem MenuShowAll;

    }
}

