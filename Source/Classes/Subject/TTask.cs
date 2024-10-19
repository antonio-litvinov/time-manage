using System;
using System.Data.Linq.Mapping;

namespace Classes
{
    [Table(Name = "Tasks")]
    public class TTask
    {
        [Column(IsPrimaryKey = true)]
        public Guid ID;

        [Column]
        public String Name;

        [Column]
        public String Text;

        [Column]
        public Boolean Done;

        [Column]
        public String Start;
        
        [Column]
        public String Finish;

        [Column]
        public String Complete;

        [Column]
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