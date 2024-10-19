using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Classes
{
    public class TMessage
    {
        [
        XmlArrayItem("TAddTask", typeof(TAddTask)),
        XmlArrayItem("TAddGroup", typeof(TAddGroup)),
        XmlArrayItem("TAddContact", typeof(TAddContact)),
        XmlArrayItem("TAddCategory", typeof(TAddCategory)),
        XmlArrayItem("TAddTaskContact", typeof(TAddTaskContact)),
        XmlArrayItem("TAddTaskCategory", typeof(TAddTaskCategory)),
        XmlArrayItem("TDeleteTask", typeof(TDeleteTask)),
        XmlArrayItem("TDeleteGroup", typeof(TDeleteGroup)),
        XmlArrayItem("TDeleteContact", typeof(TDeleteContact)),
        XmlArrayItem("TDeleteCategory", typeof(TDeleteCategory)),
        XmlArrayItem("TDeleteTaskContact", typeof(TDeleteTaskContact)),
        XmlArrayItem("TDeleteTaskCategory", typeof(TDeleteTaskCategory)),
        XmlArrayItem("TEditContact", typeof(TEditContact)),
        XmlArrayItem("TEditName", typeof(TEditName)),
        XmlArrayItem("TEditText", typeof(TEditText)),
        XmlArrayItem("TEditStart", typeof(TEditStart)),
        XmlArrayItem("TEditFinish", typeof(TEditFinish)),
        XmlArrayItem("TEditDone", typeof(TEditDone)),
        XmlArrayItem("TEditImportance", typeof(TEditImportance)),
        XmlArrayItem("TEditComplete", typeof(TEditComplete)),
        ]
        public List<TChange> ChangeList;

        public TMessage()
        {
            ChangeList = new List<TChange>();
        }

        public TMessage(List<TChange> ChangeList)
        {
            this.ChangeList = ChangeList;
        }

        public void AddChange(TChange Change)
        {
            ChangeList.Add(Change);
        }

        public string ClassToString()
        {
            XmlSerializer Serializer = new XmlSerializer(typeof(TMessage));
            StringBuilder Builder = new StringBuilder();

            StringWriter Writer = new StringWriter(Builder);
            Serializer.Serialize(Writer, this);

            return Builder.ToString();
        }

        public static TMessage StringToClass(string XML)
        {
            StringReader Reader = new StringReader(XML.Trim());
            XmlSerializer Serializer = new XmlSerializer(typeof(TMessage));

            return (TMessage)Serializer.Deserialize(Reader);
        }
    }
}
