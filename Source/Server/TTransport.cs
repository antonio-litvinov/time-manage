using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using WinToolZone.CSLMail;
using Server.Properties;
using Classes;

namespace Server
{
    public delegate void TransportEvent(String Message);

    public class TTransport
    {
        TStorage Storage = new TStorage(Settings.Default.Database);

        public event TransportEvent Updated;

        /*----------------------------------------------------------------------------*/
        /* Отправка сообщений                                                         */

        private String ToBase64(String S)
        {
            return Convert.ToBase64String(Encoding.Unicode.GetBytes(S));
        }

        private String FromBase64(String S)
        {
            try
            {
                return new string(Encoding.Unicode.GetChars(Convert.FromBase64String(S)));
            }
            catch
            {
                return String.Empty;
            }
        }

        public void SendChangeList(List<TChange> ChangeList)
        {
            SendMessage("ChangeList", (new TMessage(ChangeList)).ClassToString());
        }

        public void SendMessage(String Subject, String Body)
        {
            SMTP Mail = new SMTP();

            Mail.SMTPServer = Settings.Default.Server;
            Mail.SMTPPort = Settings.Default.SMTP;
            Mail.From = Settings.Default.From;
            Mail.To = Settings.Default.To;

            Mail.Subject = Subject;
            Mail.Message = ToBase64(Body);

            if (Mail.SendMail() == false)
                Updated("Невозможно подключиться к серверу");
        }

        /*----------------------------------------------------------------------------*/
        /* Чтение сообщений                                                           */

        public void ReadMessages()
        {
            POP3 Mail = new POP3();

            String Body = String.Empty;
            String FileName = String.Empty;
            String MessageType = String.Empty;

            Mail.Server = Settings.Default.Server;
            Mail.Port = Settings.Default.POP;
            Mail.Username = Settings.Default.Login;
            Mail.Password = Settings.Default.Password;

            if (!Mail.Connect())
            {
                Updated("Невозможно подключиться к серверу");
                return;
            }

            if (!Mail.Login())
            {
                Updated("Невозможно авторизоваться");
                return;
            }

            Updated("Подключено");

            Mail.GetMailboxDetails();

            int Count = Mail.TotalMailCount;

            for (int Index = 1; Index <= Count; Index++)
            {
                Mail.FetchEmail(Index);
                Mail.GetMailSection(1, ref Body, ref MessageType, ref FileName);

                Body = Body.Remove(Body.LastIndexOf("."));
                Body = FromBase64(Body);

                Analisys(Mail.Subject, Body);

                Mail.DeleteEmail(Index);
            }
            Mail.Close();
        }

        /*----------------------------------------------------------------------------*/
        /* Анализ сообщений                                                           */

        private void Analisys(String Subject, String Body)
        {
            if (Subject == "ID")
            {
                Updated("Получен запрос от клиента");

                List<TChangeItem> ChangeItemList = Storage.GetChangeList(new Guid(Body));

                if ((ChangeItemList != null) && (ChangeItemList.Count > 0))
                {
                    List<TChange> ChangeList = new List<TChange>();

                    foreach (TChangeItem ChangeItem in ChangeItemList)
                    {
                        TChange Change = (TChange)Activator.CreateInstance(ChangeItem.ChangeType());
                        StringToClass(ChangeItem.ChangeText, ref Change);
                        ChangeList.Add(Change);
                    }
                    SendChangeList(ChangeList);
                }
                Updated("Отправлено " + ChangeItemList.Count + " изменений");
            }

            if (Subject == "ChangeList")
            {
                TMessage Message = new TMessage();

                StringToClass(Body, ref Message);
                ParseMessage(Message);
            }
        }

        public void ParseMessage(TMessage Message)
        {
            Updated("Получено " + Message.ChangeList.Count.ToString() + " изменений");

            foreach (TChange Change in Message.ChangeList)
            {
                TChangeItem Item = new TChangeItem();
                Item.ID = Change.ID;

                
                Item.ChangeText = ClassToString(Change);
                Item.Type = Change.GetType().ToString();

                Storage.SubmitChange(new TAddChangeItem(Item));
            }
        }

        /*----------------------------------------------------------------------------*/
        /* Сериализация                                                               */

        public String ClassToString<T>(T Class)
        {

            XmlSerializer Serializer = new XmlSerializer(Class.GetType());
            StringBuilder Builder = new StringBuilder();

            StringWriter Writer = new StringWriter(Builder);
            Serializer.Serialize(Writer, Class);

            return Builder.ToString();
        }

        public void StringToClass<T>(String XML, ref T Class)
        {
            StringReader Reader = new StringReader(XML.Trim());
            XmlSerializer Serializer = new XmlSerializer(Class.GetType());

            Class = (T)Serializer.Deserialize(Reader);
        }
    }
}
