using System;
using DoubleAgent.AxControl;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.Threading.Tasks;
using S22.Imap;

namespace MyBuddy
{
    public partial class FormDashboard : Form
    {
        AxControl newAgent;
        static FormDashboard f;
        private readonly string _Username;
        private readonly string _Password;

        public FormDashboard(string Username, string Password)
        {
            InitializeComponent();
            f = this;
            _Username = Username;
            _Password = Password;
        }

        private void CmdShow_Click(object sender, EventArgs e)
        {
            newAgent.Characters["MyBuddy"].Show();
            newAgent.Characters["MyBuddy"].Speak("Hey, thanks for inviting me to this party!");
            StartReceiving();
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

        private void CmdSend_Click(object sender, EventArgs e)
        {
            MailMessage message = new MailMessage(_Username, TBTo.Text)
            {
                Subject = TBSubject.Text,
                Body = TBMessage.Text
            };

            using (SmtpClient mailer = new SmtpClient("smtp.hostinger.com", 587))
            {
                mailer.Credentials = new NetworkCredential(_Username, _Password);
                mailer.EnableSsl = true;
                mailer.Timeout = 120000;
                mailer.Send(message);
            }

            TBTo.Text = String.Empty;
            TBSubject.Text = String.Empty;
            TBMessage.Text = String.Empty;

            newAgent.Characters["MyBuddy"].Speak("I sent the message. I hope they get it!");
        }

        private void StartReceiving()
        {
            Task.Run(() =>
            {
                using (ImapClient client = new ImapClient("imap.hostinger.com", 993, _Username, _Password, AuthMethod.Login, true, null))
                {
                    if (client.Supports("IDLE") == false)
                    {
                        newAgent.Characters["MyBuddy"].Speak("Server does not support IMAP IDLE");
                        return;
                    }
                    client.NewMessage += new EventHandler<IdleMessageEventArgs>(OnNewMessage);
                    while (true) ;
                }
            });
        }

        private void OnNewMessage(object sender, IdleMessageEventArgs e)
        {
            newAgent.Characters["MyBuddy"].Speak("New Message received!");
            MailMessage m = e.Client.GetMessage(e.MessageUID, FetchOptions.Normal);
            f.Invoke((MethodInvoker)delegate
            {
                newAgent.Characters["MyBuddy"].Speak($"{m.From} says something about \"{m.Subject}.\" You might want to take a look");
            });

        }
    }
}
