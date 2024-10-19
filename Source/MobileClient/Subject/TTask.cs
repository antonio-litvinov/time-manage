using System;

namespace MobileClient
{
    public class TTask
    {
        public Guid ID;

        public String Name;

        public String Text;

        public Boolean Done;

        public String Start;

        public String Finish;

        public String Complete;

        public String Importance;

        public TTask() { }

        public TTask(String Name)
        {
            this.ID = Guid.NewGuid();
            this.Name = Name;
            this.Text = String.Empty;
            this.Start = String.Empty;
            this.Finish = String.Empty;
            this.Complete = String.Empty;
            this.Importance = String.Empty;
        }

        public TTask(String Name, String Text, Boolean Done, String Start, String Finish, String Complete, String Importance)
        {
            this.ID = Guid.NewGuid();
            
            this.Name = Name;
            this.Text = Text;
            this.Done = Done;

            this.Start = Start;
            this.Finish = Finish;

            this.Complete = Complete;
            this.Importance = Importance;
        }
    }
}