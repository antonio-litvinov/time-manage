using System;
using System.Data.Linq.Mapping;

namespace Classes
{
    [Table(Name = "Views")]
    public class TView
    {
        [Column(IsPrimaryKey = true)]
        public Guid ID;

        [Column]
        public String Caption;

        [Column]
        public Boolean Name;

        [Column]
        public Boolean Text;

        [Column]
        public Boolean Done;

        [Column]
        public Boolean Start;

        [Column]
        public Boolean Finish;

        [Column]
        public Boolean Category;

        [Column]
        public Boolean Importance;

        [Column]
        public Boolean Complete;

        public TView() { }

        public TView(String Name)
        {
            this.ID = Guid.NewGuid();
            this.Caption = Name;
        }

        public static TView Default()
        {
            TView View = new TView();

            View.Caption = "По умолчанию";
            View.ID = Guid.Empty;
            View.Text = true;

            return View;
        }
    }
}