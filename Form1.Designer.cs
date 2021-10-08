
namespace MyBuddy
{
    partial class FormDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDashboard));
            this.CmdShow = new System.Windows.Forms.Button();
            this.CmdHide = new System.Windows.Forms.Button();
            this.CmdSpeak = new System.Windows.Forms.Button();
            this.txtSpeak = new System.Windows.Forms.TextBox();
            this.CmdMove = new System.Windows.Forms.Button();
            this.LabelTo = new System.Windows.Forms.Label();
            this.TBTo = new System.Windows.Forms.TextBox();
            this.TBSubject = new System.Windows.Forms.TextBox();
            this.LabelSubject = new System.Windows.Forms.Label();
            this.TBMessage = new System.Windows.Forms.TextBox();
            this.LabelMessage = new System.Windows.Forms.Label();
            this.CmdSend = new System.Windows.Forms.Button();
            this.CmdOpenProgram = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // CmdShow
            // 
            this.CmdShow.Location = new System.Drawing.Point(153, 12);
            this.CmdShow.Name = "CmdShow";
            this.CmdShow.Size = new System.Drawing.Size(100, 40);
            this.CmdShow.TabIndex = 0;
            this.CmdShow.Text = "Show";
            this.CmdShow.UseVisualStyleBackColor = true;
            this.CmdShow.Click += new System.EventHandler(this.CmdShow_Click);
            // 
            // CmdHide
            // 
            this.CmdHide.Location = new System.Drawing.Point(47, 12);
            this.CmdHide.Name = "CmdHide";
            this.CmdHide.Size = new System.Drawing.Size(100, 40);
            this.CmdHide.TabIndex = 1;
            this.CmdHide.Text = "Hide";
            this.CmdHide.UseVisualStyleBackColor = true;
            this.CmdHide.Click += new System.EventHandler(this.CmdHide_Click);
            // 
            // CmdSpeak
            // 
            this.CmdSpeak.Location = new System.Drawing.Point(47, 107);
            this.CmdSpeak.Name = "CmdSpeak";
            this.CmdSpeak.Size = new System.Drawing.Size(100, 40);
            this.CmdSpeak.TabIndex = 2;
            this.CmdSpeak.Text = "Speak";
            this.CmdSpeak.UseVisualStyleBackColor = true;
            this.CmdSpeak.Click += new System.EventHandler(this.CmdSpeak_Click);
            // 
            // txtSpeak
            // 
            this.txtSpeak.Location = new System.Drawing.Point(47, 68);
            this.txtSpeak.Name = "txtSpeak";
            this.txtSpeak.Size = new System.Drawing.Size(206, 20);
            this.txtSpeak.TabIndex = 3;
            this.txtSpeak.Text = "Hi! Nice to see you!";
            // 
            // CmdMove
            // 
            this.CmdMove.Location = new System.Drawing.Point(153, 107);
            this.CmdMove.Name = "CmdMove";
            this.CmdMove.Size = new System.Drawing.Size(100, 40);
            this.CmdMove.TabIndex = 4;
            this.CmdMove.Text = "Move";
            this.CmdMove.UseVisualStyleBackColor = true;
            this.CmdMove.Click += new System.EventHandler(this.CmdMove_Click);
            // 
            // LabelTo
            // 
            this.LabelTo.AutoSize = true;
            this.LabelTo.Location = new System.Drawing.Point(84, 279);
            this.LabelTo.Name = "LabelTo";
            this.LabelTo.Size = new System.Drawing.Size(23, 13);
            this.LabelTo.TabIndex = 5;
            this.LabelTo.Text = "To:";
            // 
            // TBTo
            // 
            this.TBTo.Location = new System.Drawing.Point(135, 276);
            this.TBTo.Name = "TBTo";
            this.TBTo.Size = new System.Drawing.Size(154, 20);
            this.TBTo.TabIndex = 6;
            this.TBTo.Text = "example@example.com";
            // 
            // TBSubject
            // 
            this.TBSubject.Location = new System.Drawing.Point(135, 302);
            this.TBSubject.Name = "TBSubject";
            this.TBSubject.Size = new System.Drawing.Size(154, 20);
            this.TBSubject.TabIndex = 8;
            // 
            // LabelSubject
            // 
            this.LabelSubject.AutoSize = true;
            this.LabelSubject.Location = new System.Drawing.Point(83, 305);
            this.LabelSubject.Name = "LabelSubject";
            this.LabelSubject.Size = new System.Drawing.Size(46, 13);
            this.LabelSubject.TabIndex = 7;
            this.LabelSubject.Text = "Subject:";
            // 
            // TBMessage
            // 
            this.TBMessage.Location = new System.Drawing.Point(135, 328);
            this.TBMessage.Multiline = true;
            this.TBMessage.Name = "TBMessage";
            this.TBMessage.Size = new System.Drawing.Size(154, 53);
            this.TBMessage.TabIndex = 10;
            // 
            // LabelMessage
            // 
            this.LabelMessage.AutoSize = true;
            this.LabelMessage.Location = new System.Drawing.Point(83, 331);
            this.LabelMessage.Name = "LabelMessage";
            this.LabelMessage.Size = new System.Drawing.Size(53, 13);
            this.LabelMessage.TabIndex = 9;
            this.LabelMessage.Text = "Message:";
            // 
            // CmdSend
            // 
            this.CmdSend.Location = new System.Drawing.Point(189, 387);
            this.CmdSend.Name = "CmdSend";
            this.CmdSend.Size = new System.Drawing.Size(100, 40);
            this.CmdSend.TabIndex = 11;
            this.CmdSend.Text = "Send Email";
            this.CmdSend.UseVisualStyleBackColor = true;
            this.CmdSend.Click += new System.EventHandler(this.CmdSend_Click);
            // 
            // CmdOpenProgram
            // 
            this.CmdOpenProgram.Location = new System.Drawing.Point(47, 166);
            this.CmdOpenProgram.Name = "CmdOpenProgram";
            this.CmdOpenProgram.Size = new System.Drawing.Size(100, 40);
            this.CmdOpenProgram.TabIndex = 12;
            this.CmdOpenProgram.Text = "Open Program";
            this.CmdOpenProgram.UseVisualStyleBackColor = true;
            this.CmdOpenProgram.Click += new System.EventHandler(this.CmdOpenProgram_Click);
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 439);
            this.Controls.Add(this.CmdOpenProgram);
            this.Controls.Add(this.CmdSend);
            this.Controls.Add(this.TBMessage);
            this.Controls.Add(this.LabelMessage);
            this.Controls.Add(this.TBSubject);
            this.Controls.Add(this.LabelSubject);
            this.Controls.Add(this.TBTo);
            this.Controls.Add(this.LabelTo);
            this.Controls.Add(this.CmdMove);
            this.Controls.Add(this.txtSpeak);
            this.Controls.Add(this.CmdSpeak);
            this.Controls.Add(this.CmdHide);
            this.Controls.Add(this.CmdShow);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDashboard";
            this.Text = "MyBuddy Control Board";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormDashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdShow;
        private System.Windows.Forms.Button CmdHide;
        private System.Windows.Forms.Button CmdSpeak;
        private System.Windows.Forms.TextBox txtSpeak;
        private System.Windows.Forms.Button CmdMove;
        private System.Windows.Forms.Label LabelTo;
        private System.Windows.Forms.TextBox TBTo;
        private System.Windows.Forms.TextBox TBSubject;
        private System.Windows.Forms.Label LabelSubject;
        private System.Windows.Forms.TextBox TBMessage;
        private System.Windows.Forms.Label LabelMessage;
        private System.Windows.Forms.Button CmdSend;
        private System.Windows.Forms.Button CmdOpenProgram;
        private System.Windows.Forms.Timer timer1;
    }
}

