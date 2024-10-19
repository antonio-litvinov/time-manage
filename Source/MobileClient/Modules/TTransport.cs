using System;
//using System.Runtime.InteropServices;
//using System.Threading;
//using System.Reflection;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using WinToolZone.CSLMail;
//using System.Net;
//using System.Net.Sockets;

namespace MobileClient
{
    public class TTransport
    {
        TStorage Storage;
        TSettings Settings;
        ListBox Log;

        public TTransport() { }

        public TTransport(ref TStorage Storage, ref TSettings Settings, ref ListBox Log)
        {
            this.Storage = Storage;
            this.Settings = Settings;
            this.Log = Log;
        }

        /*----------------------------------------------------------------------------*/
        /* Отправка сообщений                                                         */

        private String ToBase64(String S)
        {
            return Convert.ToBase64String(Encoding.Unicode.GetBytes(S));
        }

        private String FromBase64(String S)
        {
            return new string(Encoding.Unicode.GetChars(Convert.FromBase64String(S)));
        }

        public void SendChangeList(List<TChange> ChangeList)
        {
            SendMessage("ChangeList", (new TMessage(ChangeList)).ClassToString());
        }

        public void SendMessage(String Subject, String Body)
        {
            try
            {
                Log.Items.Add("Подключение");
                Log.Update();
                SMTP Mail = new SMTP();

                Mail.SMTPServer = Settings.Server;
                Mail.SMTPPort = Settings.SMTP;
                Mail.From = Settings.From;
                Mail.To = Settings.To;

                Mail.Subject = Subject;
                Mail.Message = ToBase64(Body);
                Log.Items.Add("Отправка");
                Log.Update();
                Mail.SendMail();
                Log.Items.Add("Ожидание");
                Log.Update();
            }
            catch
            {
                Log.Items.Add("Информация об изменениях не отправлена");
            }
        }

        /*----------------------------------------------------------------------------*/
        /* Чтение сообщений                                                           */

        public void ReadMessages()
        {
            Log.Items.Add("Подключение");
            Log.Update();

            POP3 Mail = new POP3();

            String Body = null;
            String Type = null;
            String FileName = null;

            Mail.Server = Settings.Server;
            Mail.Port = Settings.POP;
            Mail.Username = Settings.Login;
            Mail.Password = Settings.Password;
            if (!Mail.Connect())
                Log.Items.Add("Не удалось подключиться");
            if (!Mail.Login())
                Log.Items.Add("Не удалось авторизоваться");

            Mail.GetMailboxDetails();

            Log.Items.Add("Получение изменений");
            Log.Update();
            for (int Index = 1; Index <= Mail.TotalMailCount; Index++)
            {
                Mail.FetchEmail(Index);
                Mail.GetMailSection(1, ref Body, ref Type, ref FileName);

                Body = Body.Remove(Body.LastIndexOf("."), 1);
                Body = FromBase64(Body);

                Analis(Mail.Subject, Body);

                Mail.DeleteEmail(Index);
            }
            Mail.Close();
            Log.Items.Add("Ожидание");
            Log.Update();
        }

        private void Analis(String Subject, String Body)
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
                if (Change.ID != Settings.LastChange)
                    Storage.SubmitChange(Change);
            }

            if (Message.ChangeList.Count > 0)
                Settings.LastChange = Message.ChangeList[Message.ChangeList.Count - 1].ID;

            Log.Items.Add("Принято " + Message.ChangeList.Count.ToString() + " изменений");
            Log.Update();
        }
    }
}
