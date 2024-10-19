using System.Collections.Generic;
using Client.Properties;
using Classes;

namespace Client
{
    public delegate void ChangeEvent(List<TChange> ChangeList);

    public class TChangeManager
    {
        public event ChangeEvent FullBuffer;

        List<TChange> ChangeList = new List<TChange>();

        public TChangeManager() { }

        public void AddChange(TChange Change)
        {
            ChangeList.Add(Change);
            Settings.Default.LastChange = Change.ID;

            if (ChangeList.Count == 1)
            {
                FullBuffer(ChangeList);
                ChangeList.Clear();
            }
        }
    }
}
