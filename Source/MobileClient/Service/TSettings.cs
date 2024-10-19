using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.IO;

namespace MobileClient
{
    public class TSettings
    {
        public String FileName;

        public String Server;

        public String From;
        public String To;

        public String Login;
        public String Password;

        public short SMTP;
        public short POP;

        public Guid LastChange;

        public static TSettings Default()
        {
            TSettings Settings = new TSettings();

            Settings.Server = "dev.iu7.bmstu.ru";

            Settings.From = "mbox355-01@dev.iu7.bmstu.ru";
            Settings.To = "mbox355-00@dev.iu7.bmstu.ru";

            Settings.Login = "mbox355-01@dev.iu7.bmstu.ru";
            Settings.Password = "rRmB5";

            Settings.SMTP = 10025;
            Settings.POP = 10110;

            Settings.LastChange = Guid.Empty;

            return Settings;
        }

        public static TSettings Load(String FileName)
        {
            TSettings Settings;

            if (File.Exists(FileName))
            {
                TextReader Reader = new StreamReader(FileName);
                XmlSerializer Serializer = new XmlSerializer(typeof(TSettings));

                Settings = (TSettings)Serializer.Deserialize(Reader);
                Reader.Close();
            }
            else
            {
                Settings = Default();
            }

            Settings.FileName = FileName;

            return Settings;
        }

        public void Save()
        {
            XmlSerializer Serializer = new XmlSerializer(typeof(TSettings));

            TextWriter Writer = new StreamWriter(this.FileName);
            Serializer.Serialize(Writer, this);
            Writer.Close();
        }
    }
}
