using System;
using System.Data.Linq.Mapping;

namespace Classes
{
    [Table(Name = "Changes")]
    public class TChangeItem
    {
        [Column(IsPrimaryKey = true)]
        public Guid ID;

        [Column(IsDbGenerated = true)]
        public int Index;

        [Column]
        public String Type;

        [Column]
        public String ChangeText;

        public TChangeItem() { }
        public TChangeItem(Guid ID, String ChangeText, String Type)
        {
            this.ID = ID;
            this.Type = Type;
            this.ChangeText = ChangeText;
        }

        public Type ChangeType()
        {
            return System.Type.GetType(Type);
        }
    }
}
