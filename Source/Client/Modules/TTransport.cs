using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using WinToolZone.CSLMail;
using Classes;
using Client.Properties;

namespace Client
{
    public delegate void InfoEvent(String Message);
    public delegate void UpdateEvent();

    public class TTransport
    {
        TStorage Storage = new TStorage(Settings.Default.Database);

        public event InfoEvent Info;
        public event UpdateEvent Update;
		
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
            Info("Отправка изменений");
            SendMessage("ChangeList", (new TMessage(ChangeList)).ClassToString());
        }


        public void SendID(Guid ID)
        {
            SendMessage("ID", ID.ToString());
        }

        private void SendMessage(String Subject, String Body)
        {
            SMTP Mail = new SMTP();

            Mail.SMTPServer = Settings.Default.Server;
            Mail.SMTPPort = Settings.Default.SMTP;
            Mail.From = Settings.Default.From;
            Mail.To = Settings.Default.To;

            Mail.Subject = Subject;
            Mail.Message = ToBase64(Body);

            if (Mail.SendMail() == false)
                Info("Невозможно подключиться к серверу");
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
                Info("Невозможно подключиться к серверу");
                return;
            }

            if (!Mail.Login())
            {
                Info("Невозможно авторизоваться");
                return;
            }

            Info("Подключено");

            Mail.GetMailboxDetails();

            for (int Index = 1; Index <= Mail.TotalMailCount; Index++)
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

        private void Analisys(String Subject, String Body)
        {
            if (Subject == "ChangeList")
            {
                ParseMessage(TMessage.StringToClass(Body));
            }
        }

        public void ParseMessage(TMessage Message)
        {
            foreach (TChange Change in Message.ChangeList)
            {
                if (Change.ID != Settings.Default.LastChange)
                    Storage.SubmitChange(Change);
            }

            if (Message.ChangeList.Count > 0)
                Settings.Default.LastChange = Message.ChangeList[Message.ChangeList.Count - 1].ID;

            Update();
            Info("Принято изменений: " + Message.ChangeList.Count.ToString());
        }
    }
}
