using System.Collections.Generic;

namespace MobileClient
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
            
            if (ChangeList.Count == 1)
            {
                FullBuffer(ChangeList);
                ChangeList.Clear();
            }
        }
    }
}
