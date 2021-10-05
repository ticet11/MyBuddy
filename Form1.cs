using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using DoubleAgent.AxControl;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace MyBuddy
{
    public partial class FormDashboard : Form
    {
        AxControl newAgent;
        string[] Scopes = { GmailService.Scope.GmailSend };
        string ApplicationName = "MyBuddy";

        public FormDashboard()
        {
            InitializeComponent();
        }

        private void CmdShow_Click(object sender, EventArgs e)
        {
            newAgent.Characters["MyBuddy"].Show();
            newAgent.Characters["MyBuddy"].Speak("Hey, thanks for inviting me to this party!");
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            newAgent = new AxControl();
            newAgent.CreateControl();
            newAgent.Characters.Load("MyBuddy", "E:\\Coding Projects\\MyBuddy\\pikachu.acs");
        }

        private void CmdHide_Click(object sender, EventArgs e)
        {
            newAgent.Characters["MyBuddy"].Hide();
        }

        private void CmdSpeak_Click(object sender, EventArgs e)
        {
            newAgent.Characters["MyBuddy"].Speak(txtSpeak.Text);
        }

        private void CmdMove_Click(object sender, EventArgs e)
        {
            short screenWidth = (short)(Screen.PrimaryScreen.Bounds.Width - 180);
            short screenHeight = (short)(Screen.PrimaryScreen.Bounds.Height - 175);

            Random rnd = new Random();
            int direction = rnd.Next(1, 5);

            switch (direction)
            {
                // Top Left
                case 1:
                    newAgent.Characters["MyBuddy"].MoveTo(0, 0);
                    break;
                // Top Right
                case 2:
                    newAgent.Characters["MyBuddy"].MoveTo(screenWidth, 0);
                    break;
                // Bottom Left
                case 3:
                    newAgent.Characters["MyBuddy"].MoveTo(0, screenHeight);
                    break;
                // Bottom Right
                case 4:
                    newAgent.Characters["MyBuddy"].MoveTo(screenWidth, screenHeight);
                    break;
            }

        }

        string Base64UrlEncode(string input)
        {
            var data = Encoding.UTF8.GetBytes(input);
            return Convert.ToBase64String(data).Replace("+", "-").Replace("/", "_").Replace("=", "");
        }

        private void CmdSend_Click(object sender, EventArgs e)
        {
            UserCredential userCred;
            // read credentials file
            using (FileStream stream = new FileStream(Application.StartupPath + @"/credentials.json", FileMode.Open, FileAccess.Read))
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                path = Path.Combine(path, ".credentials/gmail-dotnet-quickstart.json");
                userCred = GoogleWebAuthorizationBroker.AuthorizeAsync(GoogleClientSecrets.FromStream(stream).Secrets, Scopes, "user", CancellationToken.None, new FileDataStore(path, true)).Result;
            }

            string message = $"To: {TBTo.Text}\r\nSubject: {TBSubject.Text}\r\nContent-Type: text/html;charset=utf-8\r\n\r\n<h1>{TBMessage.Text}</h1>";
            // call Gmail service
            var service = new GmailService(new BaseClientService.Initializer() { HttpClientInitializer = userCred, ApplicationName = ApplicationName });
            var msg = new Google.Apis.Gmail.v1.Data.Message();
            msg.Raw = Base64UrlEncode(message.ToString());
            service.Users.Messages.Send(msg, "me").Execute();
            newAgent.Characters["MyBuddy"].Speak("I sent the e-mail. Anything else I can do for you, Dad?");
        }
    }
}
