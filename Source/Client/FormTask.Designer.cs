namespace Client
{
    partial class FormTask
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTask));
            this.DateFinish = new System.Windows.Forms.DateTimePicker();
            this.TabControlTask = new System.Windows.Forms.TabControl();
            this.PageText = new System.Windows.Forms.TabPage();
            this.TextText = new System.Windows.Forms.TextBox();
            this.PageDate = new System.Windows.Forms.TabPage();
            this.TextComplete = new System.Windows.Forms.ComboBox();
            this.LabelComplete = new System.Windows.Forms.Label();
            this.TextImportance = new System.Windows.Forms.ComboBox();
            this.LabelImportance = new System.Windows.Forms.Label();
            this.CheckFinish = new System.Windows.Forms.CheckBox();
            this.CheckStart = new System.Windows.Forms.CheckBox();
            this.DateStart = new System.Windows.Forms.DateTimePicker();
            this.PageCategory = new System.Windows.Forms.TabPage();
            this.ListCategories = new System.Windows.Forms.ListView();
            this.ColumnName = new System.Windows.Forms.ColumnHeader();
            this.ColumnCategory = new System.Windows.Forms.ColumnHeader();
            this.Images = new System.Windows.Forms.ImageList(this.components);
            this.MenuCategories = new System.Windows.Forms.ToolStrip();
            this.ButtonCategoryAdd = new System.Windows.Forms.ToolStripDropDownButton();
            this.ButtonCategoryDelete = new System.Windows.Forms.ToolStripButton();
            this.PageContact = new System.Windows.Forms.TabPage();
            this.ListContacts = new System.Windows.Forms.ListView();
            this.ColumnContactName = new System.Windows.Forms.ColumnHeader();
            this.ColumnMobile = new System.Windows.Forms.ColumnHeader();
            this.ColumnHome = new System.Windows.Forms.ColumnHeader();
            this.ColumnMail = new System.Windows.Forms.ColumnHeader();
            this.MenuContacts = new System.Windows.Forms.ToolStrip();
            this.ButtonContactAdd = new System.Windows.Forms.ToolStripDropDownButton();
            this.ButtonContactDelete = new System.Windows.Forms.ToolStripButton();
            this.PageDocument = new System.Windows.Forms.TabPage();
            this.ListDocuments = new System.Windows.Forms.ListView();
            this.ColumnFile = new System.Windows.Forms.ColumnHeader();
            this.MenuDocuments = new System.Windows.Forms.ToolStrip();
            this.ButtonDocumentAdd = new System.Windows.Forms.ToolStripButton();
            this.ButtonFolderAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ButtonDocumentDelete = new System.Windows.Forms.ToolStripButton();
            this.ButtonDocumentOpen = new System.Windows.Forms.ToolStripButton();
            this.StatusTask = new System.Windows.Forms.StatusStrip();
            this.MenuMain = new System.Windows.Forms.MenuStrip();
            this.ButtonSave = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.GroupCommon = new System.Windows.Forms.GroupBox();
            this.CheckDone = new System.Windows.Forms.CheckBox();
            this.TextName = new System.Windows.Forms.TextBox();
            this.DialogFile = new System.Windows.Forms.OpenFileDialog();
            this.DialogFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.TabControlTask.SuspendLayout();
            this.PageText.SuspendLayout();
            this.PageDate.SuspendLayout();
            this.PageCategory.SuspendLayout();
            this.MenuCategories.SuspendLayout();
            this.PageContact.SuspendLayout();
            this.MenuContacts.SuspendLayout();
            this.PageDocument.SuspendLayout();
            this.MenuDocuments.SuspendLayout();
            this.MenuMain.SuspendLayout();
            this.GroupCommon.SuspendLayout();
            this.SuspendLayout();
            // 
            // DateFinish
            // 
            this.DateFinish.Enabled = false;
            this.DateFinish.Location = new System.Drawing.Point(71, 127);
            this.DateFinish.Name = "DateFinish";
            this.DateFinish.Size = new System.Drawing.Size(137, 20);
            this.DateFinish.TabIndex = 1;
            // 
            // TabControlTask
            // 
            this.TabControlTask.Controls.Add(this.PageText);
            this.TabControlTask.Controls.Add(this.PageDate);
            this.TabControlTask.Controls.Add(this.PageCategory);
            this.TabControlTask.Controls.Add(this.PageContact);
            this.TabControlTask.Controls.Add(this.PageDocument);
            this.TabControlTask.Location = new System.Drawing.Point(3, 84);
            this.TabControlTask.Name = "TabControlTask";
            this.TabControlTask.SelectedIndex = 0;
            this.TabControlTask.Size = new System.Drawing.Size(466, 191);
            this.TabControlTask.TabIndex = 7;
            // 
            // PageText
            // 
            this.PageText.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PageText.BackgroundImage")));
            this.PageText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PageText.Controls.Add(this.TextText);
            this.PageText.Location = new System.Drawing.Point(4, 22);
            this.PageText.Name = "PageText";
            this.PageText.Padding = new System.Windows.Forms.Padding(3);
            this.PageText.Size = new System.Drawing.Size(458, 165);
            this.PageText.TabIndex = 0;
            this.PageText.Text = "Описание";
            this.PageText.UseVisualStyleBackColor = true;
            // 
            // TextText
            // 
            this.TextText.Location = new System.Drawing.Point(55, 51);
            this.TextText.Multiline = true;
            this.TextText.Name = "TextText";
            this.TextText.Size = new System.Drawing.Size(395, 108);
            this.TextText.TabIndex = 0;
            // 
            // PageDate
            // 
            this.PageDate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PageDate.BackgroundImage")));
            this.PageDate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PageDate.Controls.Add(this.TextComplete);
            this.PageDate.Controls.Add(this.LabelComplete);
            this.PageDate.Controls.Add(this.TextImportance);
            this.PageDate.Controls.Add(this.LabelImportance);
            this.PageDate.Controls.Add(this.CheckFinish);
            this.PageDate.Controls.Add(this.CheckStart);
            this.PageDate.Controls.Add(this.DateFinish);
            this.PageDate.Controls.Add(this.DateStart);
            this.PageDate.Location = new System.Drawing.Point(4, 22);
            this.PageDate.Name = "PageDate";
            this.PageDate.Padding = new System.Windows.Forms.Padding(3);
            this.PageDate.Size = new System.Drawing.Size(458, 165);
            this.PageDate.TabIndex = 2;
            this.PageDate.Text = "Сроки";
            this.PageDate.UseVisualStyleBackColor = true;
            // 
            // TextComplete
            // 
            this.TextComplete.FormattingEnabled = true;
            this.TextComplete.Items.AddRange(new object[] {
            "0%",
            "25%",
            "50%",
            "75%",
            "100%"});
            this.TextComplete.Location = new System.Drawing.Point(240, 130);
            this.TextComplete.Name = "TextComplete";
            this.TextComplete.Size = new System.Drawing.Size(121, 21);
            this.TextComplete.TabIndex = 12;
            // 
            // LabelComplete
            // 
            this.LabelComplete.AutoSize = true;
            this.LabelComplete.Location = new System.Drawing.Point(237, 108);
            this.LabelComplete.Name = "LabelComplete";
            this.LabelComplete.Size = new System.Drawing.Size(80, 13);
            this.LabelComplete.TabIndex = 11;
            this.LabelComplete.Text = "% завершения";
            // 
            // TextImportance
            // 
            this.TextImportance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TextImportance.FormattingEnabled = true;
            this.TextImportance.Items.AddRange(new object[] {
            "Низкая",
            "Обычная",
            "Высокая"});
            this.TextImportance.Location = new System.Drawing.Point(240, 75);
            this.TextImportance.Name = "TextImportance";
            this.TextImportance.Size = new System.Drawing.Size(121, 21);
            this.TextImportance.TabIndex = 10;
            // 
            // LabelImportance
            // 
            this.LabelImportance.AutoSize = true;
            this.LabelImportance.Location = new System.Drawing.Point(237, 59);
            this.LabelImportance.Name = "LabelImportance";
            this.LabelImportance.Size = new System.Drawing.Size(57, 13);
            this.LabelImportance.TabIndex = 9;
            this.LabelImportance.Text = "Важность";
            // 
            // CheckFinish
            // 
            this.CheckFinish.AutoSize = true;
            this.CheckFinish.Location = new System.Drawing.Point(55, 104);
            this.CheckFinish.Name = "CheckFinish";
            this.CheckFinish.Size = new System.Drawing.Size(51, 17);
            this.CheckFinish.TabIndex = 8;
            this.CheckFinish.Text = "Срок";
            this.CheckFinish.UseVisualStyleBackColor = true;
            this.CheckFinish.CheckedChanged += new System.EventHandler(this.CheckFinish_CheckedChanged);
            // 
            // CheckStart
            // 
            this.CheckStart.AutoSize = true;
            this.CheckStart.Location = new System.Drawing.Point(55, 55);
            this.CheckStart.Name = "CheckStart";
            this.CheckStart.Size = new System.Drawing.Size(63, 17);
            this.CheckStart.TabIndex = 7;
            this.CheckStart.Text = "Начало";
            this.CheckStart.UseVisualStyleBackColor = true;
            this.CheckStart.CheckedChanged += new System.EventHandler(this.CheckStart_CheckedChanged);
            // 
            // DateStart
            // 
            this.DateStart.Enabled = false;
            this.DateStart.Location = new System.Drawing.Point(71, 78);
            this.DateStart.Name = "DateStart";
            this.DateStart.Size = new System.Drawing.Size(137, 20);
            this.DateStart.TabIndex = 2;
            // 
            // PageCategory
            // 
            this.PageCategory.Controls.Add(this.ListCategories);
            this.PageCategory.Controls.Add(this.MenuCategories);
            this.PageCategory.Location = new System.Drawing.Point(4, 22);
            this.PageCategory.Name = "PageCategory";
            this.PageCategory.Padding = new System.Windows.Forms.Padding(3);
            this.PageCategory.Size = new System.Drawing.Size(458, 165);
            this.PageCategory.TabIndex = 1;
            this.PageCategory.Text = "Категории";
            this.PageCategory.UseVisualStyleBackColor = true;
            // 
            // ListCategories
            // 
            this.ListCategories.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnName,
            this.ColumnCategory});
            this.ListCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListCategories.FullRowSelect = true;
            this.ListCategories.GridLines = true;
            this.ListCategories.Location = new System.Drawing.Point(3, 28);
            this.ListCategories.MultiSelect = false;
            this.ListCategories.Name = "ListCategories";
            this.ListCategories.Size = new System.Drawing.Size(452, 134);
            this.ListCategories.SmallImageList = this.Images;
            this.ListCategories.TabIndex = 1;
            this.ListCategories.UseCompatibleStateImageBehavior = false;
            this.ListCategories.View = System.Windows.Forms.View.Details;
            // 
            // ColumnName
            // 
            this.ColumnName.Text = "Название";
            this.ColumnName.Width = 65;
            // 
            // ColumnCategory
            // 
            this.ColumnCategory.Text = "Категория";
            this.ColumnCategory.Width = 68;
            // 
            // Images
            // 
            this.Images.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Images.ImageStream")));
            this.Images.TransparentColor = System.Drawing.Color.Transparent;
            this.Images.Images.SetKeyName(0, "Contact.png");
            this.Images.Images.SetKeyName(1, "Document.png");
            this.Images.Images.SetKeyName(2, "Category.png");
            // 
            // MenuCategories
            // 
            this.MenuCategories.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.MenuCategories.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ButtonCategoryAdd,
            this.ButtonCategoryDelete});
            this.MenuCategories.Location = new System.Drawing.Point(3, 3);
            this.MenuCategories.Name = "MenuCategories";
            this.MenuCategories.Size = new System.Drawing.Size(452, 25);
            this.MenuCategories.TabIndex = 0;
            this.MenuCategories.Text = "toolStrip1";
            // 
            // ButtonCategoryAdd
            // 
            this.ButtonCategoryAdd.Image = global::Client.Properties.Resources.CategoryAdd;
            this.ButtonCategoryAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonCategoryAdd.Name = "ButtonCategoryAdd";
            this.ButtonCategoryAdd.Size = new System.Drawing.Size(88, 22);
            this.ButtonCategoryAdd.Text = "Добавить";
            // 
            // ButtonCategoryDelete
            // 
            this.ButtonCategoryDelete.Image = global::Client.Properties.Resources.CategoryDelete;
            this.ButtonCategoryDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonCategoryDelete.Name = "ButtonCategoryDelete";
            this.ButtonCategoryDelete.Size = new System.Drawing.Size(71, 22);
            this.ButtonCategoryDelete.Text = "Удалить";
            this.ButtonCategoryDelete.Click += new System.EventHandler(this.ButtonCategoryDelete_Click);
            // 
            // PageContact
            // 
            this.PageContact.Controls.Add(this.ListContacts);
            this.PageContact.Controls.Add(this.MenuContacts);
            this.PageContact.Location = new System.Drawing.Point(4, 22);
            this.PageContact.Name = "PageContact";
            this.PageContact.Padding = new System.Windows.Forms.Padding(3);
            this.PageContact.Size = new System.Drawing.Size(458, 165);
            this.PageContact.TabIndex = 3;
            this.PageContact.Text = "Контакты";
            this.PageContact.UseVisualStyleBackColor = true;
            // 
            // ListContacts
            // 
            this.ListContacts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnContactName,
            this.ColumnMobile,
            this.ColumnHome,
            this.ColumnMail});
            this.ListContacts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListContacts.FullRowSelect = true;
            this.ListContacts.GridLines = true;
            this.ListContacts.Location = new System.Drawing.Point(3, 28);
            this.ListContacts.MultiSelect = false;
            this.ListContacts.Name = "ListContacts";
            this.ListContacts.Size = new System.Drawing.Size(452, 134);
            this.ListContacts.SmallImageList = this.Images;
            this.ListContacts.TabIndex = 3;
            this.ListContacts.UseCompatibleStateImageBehavior = false;
            this.ListContacts.View = System.Windows.Forms.View.Details;
            // 
            // ColumnContactName
            // 
            this.ColumnContactName.Text = "ФИО";
            this.ColumnContactName.Width = 65;
            // 
            // ColumnMobile
            // 
            this.ColumnMobile.Text = "Мобильный";
            this.ColumnMobile.Width = 68;
            // 
            // ColumnHome
            // 
            this.ColumnHome.Text = "Домашний";
            // 
            // ColumnMail
            // 
            this.ColumnMail.Text = "Почта";
            // 
            // MenuContacts
            // 
            this.MenuContacts.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.MenuContacts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ButtonContactAdd,
            this.ButtonContactDelete});
            this.MenuContacts.Location = new System.Drawing.Point(3, 3);
            this.MenuContacts.Name = "MenuContacts";
            this.MenuContacts.Size = new System.Drawing.Size(452, 25);
            this.MenuContacts.TabIndex = 2;
            // 
            // ButtonContactAdd
            // 
            this.ButtonContactAdd.Image = global::Client.Properties.Resources.ContactAdd;
            this.ButtonContactAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonContactAdd.Name = "ButtonContactAdd";
            this.ButtonContactAdd.Size = new System.Drawing.Size(88, 22);
            this.ButtonContactAdd.Text = "Добавить";
            // 
            // ButtonContactDelete
            // 
            this.ButtonContactDelete.Image = global::Client.Properties.Resources.ContactDelete;
            this.ButtonContactDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonContactDelete.Name = "ButtonContactDelete";
            this.ButtonContactDelete.Size = new System.Drawing.Size(71, 22);
            this.ButtonContactDelete.Text = "Удалить";
            this.ButtonContactDelete.Click += new System.EventHandler(this.ButtonContactDelete_Click);
            // 
            // PageDocument
            // 
            this.PageDocument.Controls.Add(this.ListDocuments);
            this.PageDocument.Controls.Add(this.MenuDocuments);
            this.PageDocument.Location = new System.Drawing.Point(4, 22);
            this.PageDocument.Name = "PageDocument";
            this.PageDocument.Padding = new System.Windows.Forms.Padding(3);
            this.PageDocument.Size = new System.Drawing.Size(458, 165);
            this.PageDocument.TabIndex = 4;
            this.PageDocument.Text = "Документы";
            this.PageDocument.UseVisualStyleBackColor = true;
            // 
            // ListDocuments
            // 
            this.ListDocuments.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnFile});
            this.ListDocuments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListDocuments.FullRowSelect = true;
            this.ListDocuments.GridLines = true;
            this.ListDocuments.Location = new System.Drawing.Point(3, 28);
            this.ListDocuments.MultiSelect = false;
            this.ListDocuments.Name = "ListDocuments";
            this.ListDocuments.Size = new System.Drawing.Size(452, 134);
            this.ListDocuments.SmallImageList = this.Images;
            this.ListDocuments.TabIndex = 3;
            this.ListDocuments.UseCompatibleStateImageBehavior = false;
            this.ListDocuments.View = System.Windows.Forms.View.Details;
            this.ListDocuments.DoubleClick += new System.EventHandler(this.ListDocuments_DoubleClick);
            // 
            // ColumnFile
            // 
            this.ColumnFile.Text = "Путь к файлу";
            this.ColumnFile.Width = 65;
            // 
            // MenuDocuments
            // 
            this.MenuDocuments.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.MenuDocuments.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ButtonDocumentAdd,
            this.ButtonFolderAdd,
            this.toolStripSeparator1,
            this.ButtonDocumentDelete,
            this.ButtonDocumentOpen});
            this.MenuDocuments.Location = new System.Drawing.Point(3, 3);
            this.MenuDocuments.Name = "MenuDocuments";
            this.MenuDocuments.Size = new System.Drawing.Size(452, 25);
            this.MenuDocuments.TabIndex = 2;
            // 
            // ButtonDocumentAdd
            // 
            this.ButtonDocumentAdd.Image = global::Client.Properties.Resources.DocumentAdd;
            this.ButtonDocumentAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonDocumentAdd.Name = "ButtonDocumentAdd";
            this.ButtonDocumentAdd.Size = new System.Drawing.Size(111, 22);
            this.ButtonDocumentAdd.Text = "Добавить файл";
            this.ButtonDocumentAdd.Click += new System.EventHandler(this.ButtonDocumentAdd_Click);
            // 
            // ButtonFolderAdd
            // 
            this.ButtonFolderAdd.Image = global::Client.Properties.Resources.GroupAdd;
            this.ButtonFolderAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonFolderAdd.Name = "ButtonFolderAdd";
            this.ButtonFolderAdd.Size = new System.Drawing.Size(114, 22);
            this.ButtonFolderAdd.Text = "Добавить папку";
            this.ButtonFolderAdd.Click += new System.EventHandler(this.ButtonFolderAdd_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // ButtonDocumentDelete
            // 
            this.ButtonDocumentDelete.Image = global::Client.Properties.Resources.DocumentDelete;
            this.ButtonDocumentDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonDocumentDelete.Name = "ButtonDocumentDelete";
            this.ButtonDocumentDelete.Size = new System.Drawing.Size(71, 22);
            this.ButtonDocumentDelete.Text = "Удалить";
            // 
            // ButtonDocumentOpen
            // 
            this.ButtonDocumentOpen.Image = global::Client.Properties.Resources.Document;
            this.ButtonDocumentOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonDocumentOpen.Name = "ButtonDocumentOpen";
            this.ButtonDocumentOpen.Size = new System.Drawing.Size(74, 22);
            this.ButtonDocumentOpen.Text = "Открыть";
            this.ButtonDocumentOpen.Click += new System.EventHandler(this.ButtonDocumentOpen_Click);
            // 
            // StatusTask
            // 
            this.StatusTask.Location = new System.Drawing.Point(0, 279);
            this.StatusTask.Name = "StatusTask";
            this.StatusTask.Size = new System.Drawing.Size(469, 22);
            this.StatusTask.TabIndex = 8;
            this.StatusTask.Text = "statusStrip1";
            // 
            // MenuMain
            // 
            this.MenuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ButtonSave,
            this.ButtonCancel});
            this.MenuMain.Location = new System.Drawing.Point(0, 0);
            this.MenuMain.Name = "MenuMain";
            this.MenuMain.Size = new System.Drawing.Size(469, 24);
            this.MenuMain.TabIndex = 11;
            this.MenuMain.Text = "menuStrip1";
            // 
            // ButtonSave
            // 
            this.ButtonSave.Image = global::Client.Properties.Resources.Save;
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(93, 20);
            this.ButtonSave.Text = "Сохранить";
            this.ButtonSave.Click += new System.EventHandler(this.ToolSave_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Image = global::Client.Properties.Resources.Exit;
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(89, 20);
            this.ButtonCancel.Text = "Отменить";
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // GroupCommon
            // 
            this.GroupCommon.Controls.Add(this.CheckDone);
            this.GroupCommon.Controls.Add(this.TextName);
            this.GroupCommon.Location = new System.Drawing.Point(3, 27);
            this.GroupCommon.Name = "GroupCommon";
            this.GroupCommon.Size = new System.Drawing.Size(462, 51);
            this.GroupCommon.TabIndex = 12;
            this.GroupCommon.TabStop = false;
            this.GroupCommon.Text = "Общее";
            // 
            // CheckDone
            // 
            this.CheckDone.AutoSize = true;
            this.CheckDone.Location = new System.Drawing.Point(371, 22);
            this.CheckDone.Name = "CheckDone";
            this.CheckDone.Size = new System.Drawing.Size(83, 17);
            this.CheckDone.TabIndex = 1;
            this.CheckDone.Text = "Выполнено";
            this.CheckDone.UseVisualStyleBackColor = true;
            // 
            // TextName
            // 
            this.TextName.Location = new System.Drawing.Point(9, 19);
            this.TextName.Name = "TextName";
            this.TextName.Size = new System.Drawing.Size(356, 20);
            this.TextName.TabIndex = 0;
            // 
            // DialogFile
            // 
            this.DialogFile.FileName = "openFileDialog1";
            // 
            // FormTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(469, 301);
            this.Controls.Add(this.GroupCommon);
            this.Controls.Add(this.StatusTask);
            this.Controls.Add(this.MenuMain);
            this.Controls.Add(this.TabControlTask);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormTask";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сведения о задаче";
            this.Shown += new System.EventHandler(this.FormTask_Shown);
            this.TabControlTask.ResumeLayout(false);
            this.PageText.ResumeLayout(false);
            this.PageText.PerformLayout();
            this.PageDate.ResumeLayout(false);
            this.PageDate.PerformLayout();
            this.PageCategory.ResumeLayout(false);
            this.PageCategory.PerformLayout();
            this.MenuCategories.ResumeLayout(false);
            this.MenuCategories.PerformLayout();
            this.PageContact.ResumeLayout(false);
            this.PageContact.PerformLayout();
            this.MenuContacts.ResumeLayout(false);
            this.MenuContacts.PerformLayout();
            this.PageDocument.ResumeLayout(false);
            this.PageDocument.PerformLayout();
            this.MenuDocuments.ResumeLayout(false);
            this.MenuDocuments.PerformLayout();
            this.MenuMain.ResumeLayout(false);
            this.MenuMain.PerformLayout();
            this.GroupCommon.ResumeLayout(false);
            this.GroupCommon.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DateFinish;
        private System.Windows.Forms.TabControl TabControlTask;
        private System.Windows.Forms.TabPage PageText;
        private System.Windows.Forms.TabPage PageCategory;
        private System.Windows.Forms.ListView ListCategories;
        private System.Windows.Forms.ToolStrip MenuCategories;
        private System.Windows.Forms.ToolStripDropDownButton ButtonCategoryAdd;
        private System.Windows.Forms.ToolStripButton ButtonCategoryDelete;
        private System.Windows.Forms.StatusStrip StatusTask;
        private System.Windows.Forms.ColumnHeader ColumnName;
        private System.Windows.Forms.ColumnHeader ColumnCategory;
        private System.Windows.Forms.TabPage PageDate;
        private System.Windows.Forms.CheckBox CheckFinish;
        private System.Windows.Forms.CheckBox CheckStart;
        private System.Windows.Forms.TextBox TextText;
        private System.Windows.Forms.MenuStrip MenuMain;
        private System.Windows.Forms.ToolStripMenuItem ButtonSave;
        private System.Windows.Forms.ToolStripMenuItem ButtonCancel;
        private System.Windows.Forms.GroupBox GroupCommon;
        private System.Windows.Forms.CheckBox CheckDone;
        private System.Windows.Forms.TextBox TextName;
        private System.Windows.Forms.DateTimePicker DateStart;
        private System.Windows.Forms.ComboBox TextImportance;
        private System.Windows.Forms.Label LabelImportance;
        private System.Windows.Forms.ComboBox TextComplete;
        private System.Windows.Forms.Label LabelComplete;
        private System.Windows.Forms.TabPage PageContact;
        private System.Windows.Forms.ListView ListContacts;
        private System.Windows.Forms.ColumnHeader ColumnContactName;
        private System.Windows.Forms.ColumnHeader ColumnMobile;
        private System.Windows.Forms.ToolStrip MenuContacts;
        private System.Windows.Forms.ToolStripDropDownButton ButtonContactAdd;
        private System.Windows.Forms.ToolStripButton ButtonContactDelete;
        private System.Windows.Forms.TabPage PageDocument;
        private System.Windows.Forms.ListView ListDocuments;
        private System.Windows.Forms.ColumnHeader ColumnFile;
        private System.Windows.Forms.ToolStrip MenuDocuments;
        private System.Windows.Forms.ToolStripButton ButtonDocumentDelete;
        private System.Windows.Forms.ToolStripButton ButtonDocumentAdd;
        private System.Windows.Forms.OpenFileDialog DialogFile;
        private System.Windows.Forms.FolderBrowserDialog DialogFolder;
        private System.Windows.Forms.ColumnHeader ColumnHome;
        private System.Windows.Forms.ColumnHeader ColumnMail;
        private System.Windows.Forms.ImageList Images;
        private System.Windows.Forms.ToolStripButton ButtonDocumentOpen;
        private System.Windows.Forms.ToolStripButton ButtonFolderAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}