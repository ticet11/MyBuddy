
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
            this.SuspendLayout();
            // 
            // CmdShow
            // 
            this.CmdShow.Location = new System.Drawing.Point(100, 61);
            this.CmdShow.Name = "CmdShow";
            this.CmdShow.Size = new System.Drawing.Size(100, 40);
            this.CmdShow.TabIndex = 0;
            this.CmdShow.Text = "Show";
            this.CmdShow.UseVisualStyleBackColor = true;
            this.CmdShow.Click += new System.EventHandler(this.CmdShow_Click);
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 163);
            this.Controls.Add(this.CmdShow);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDashboard";
            this.Text = "MyBuddy Control Board";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CmdShow;
    }
}

