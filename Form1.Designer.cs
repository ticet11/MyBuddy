
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDashboard));
            this.CmdShow = new System.Windows.Forms.Button();
            this.CmdHide = new System.Windows.Forms.Button();
            this.CmdSpeak = new System.Windows.Forms.Button();
            this.txtSpeak = new System.Windows.Forms.TextBox();
            this.CmdMove = new System.Windows.Forms.Button();
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
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 163);
            this.Controls.Add(this.CmdMove);
            this.Controls.Add(this.txtSpeak);
            this.Controls.Add(this.CmdSpeak);
            this.Controls.Add(this.CmdHide);
            this.Controls.Add(this.CmdShow);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDashboard";
            this.Text = "MyBuddy Control Board";
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
    }
}

