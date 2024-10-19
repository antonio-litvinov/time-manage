namespace Server
{
    partial class FormMain
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.TimerMain = new System.Windows.Forms.Timer(this.components);
            this.LabelStatus = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Notify = new System.Windows.Forms.NotifyIcon(this.components);
            this.MenuNotify = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ButtonExit = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.MenuNotify.SuspendLayout();
            this.SuspendLayout();
            // 
            // TimerMain
            // 
            this.TimerMain.Enabled = true;
            this.TimerMain.Interval = 3000;
            this.TimerMain.Tick += new System.EventHandler(this.TimerMain_Tick);
            // 
            // LabelStatus
            // 
            this.LabelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelStatus.Location = new System.Drawing.Point(80, 22);
            this.LabelStatus.Name = "LabelStatus";
            this.LabelStatus.Size = new System.Drawing.Size(120, 32);
            this.LabelStatus.TabIndex = 1;
            this.LabelStatus.Text = "Сервер запущен";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.LabelStatus);
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 64);
            this.panel1.TabIndex = 2;
            // 
            // Notify
            // 
            this.Notify.ContextMenuStrip = this.MenuNotify;
            this.Notify.Icon = ((System.Drawing.Icon)(resources.GetObject("Notify.Icon")));
            this.Notify.Text = "Сервер";
            this.Notify.Visible = true;
            // 
            // MenuNotify
            // 
            this.MenuNotify.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ButtonExit});
            this.MenuNotify.Name = "ContextMenu";
            this.MenuNotify.Size = new System.Drawing.Size(153, 48);
            // 
            // ButtonExit
            // 
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(152, 22);
            this.ButtonExit.Text = "Выход";
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(220, 84);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сервер";
            this.panel1.ResumeLayout(false);
            this.MenuNotify.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer TimerMain;
        private System.Windows.Forms.Label LabelStatus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NotifyIcon Notify;
        private System.Windows.Forms.ContextMenuStrip MenuNotify;
        private System.Windows.Forms.ToolStripMenuItem ButtonExit;
    }
}

