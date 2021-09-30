using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using DoubleAgent.AxControl;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBuddy
{
    public partial class FormDashboard : Form
    {
        AxControl newAgent;
        public FormDashboard()
        {
            InitializeComponent();
        }

        private void CmdShow_Click(object sender, EventArgs e)
        {
            newAgent.Characters["MyBuddy"].Show();
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
            short screenWidth = (short)(Screen.PrimaryScreen.Bounds.Width - 100);
            short screenHeight = (short)(Screen.PrimaryScreen.Bounds.Height - 100);

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
    }
}
