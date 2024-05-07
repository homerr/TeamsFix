namespace TeamsFix
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.fixup = new System.Windows.Forms.Button();
            this.teamsgrab = new System.Windows.Forms.Button();
            this.installteams = new System.Windows.Forms.Button();
            this.logBox = new System.Windows.Forms.RichTextBox();
            this.quit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fixup
            // 
            this.fixup.BackColor = System.Drawing.Color.Tomato;
            this.fixup.Location = new System.Drawing.Point(100, 47);
            this.fixup.Name = "fixup";
            this.fixup.Size = new System.Drawing.Size(111, 31);
            this.fixup.TabIndex = 10;
            this.fixup.Text = "Fix Teams";
            this.fixup.UseVisualStyleBackColor = false;
            this.fixup.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // teamsgrab
            // 
            this.teamsgrab.Location = new System.Drawing.Point(100, 159);
            this.teamsgrab.Name = "teamsgrab";
            this.teamsgrab.Size = new System.Drawing.Size(111, 26);
            this.teamsgrab.TabIndex = 11;
            this.teamsgrab.Text = "Grab New teams";
            this.teamsgrab.UseVisualStyleBackColor = true;
            this.teamsgrab.Click += new System.EventHandler(this.teamsgrab_Click);
            // 
            // installteams
            // 
            this.installteams.Location = new System.Drawing.Point(100, 205);
            this.installteams.Name = "installteams";
            this.installteams.Size = new System.Drawing.Size(111, 27);
            this.installteams.TabIndex = 12;
            this.installteams.Text = "Teams Install";
            this.installteams.UseVisualStyleBackColor = true;
            this.installteams.Click += new System.EventHandler(this.installteams_Click);
            // 
            // logBox
            // 
            this.logBox.Location = new System.Drawing.Point(341, 53);
            this.logBox.Name = "logBox";
            this.logBox.Size = new System.Drawing.Size(563, 279);
            this.logBox.TabIndex = 13;
            this.logBox.Text = "";
            // 
            // quit
            // 
            this.quit.BackColor = System.Drawing.Color.LightSkyBlue;
            this.quit.Location = new System.Drawing.Point(100, 264);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(111, 29);
            this.quit.TabIndex = 14;
            this.quit.Text = "Quit";
            this.quit.UseVisualStyleBackColor = false;
            this.quit.Click += new System.EventHandler(this.quit_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(940, 384);
            this.Controls.Add(this.quit);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.installteams);
            this.Controls.Add(this.teamsgrab);
            this.Controls.Add(this.fixup);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button quit;

        private System.Windows.Forms.RichTextBox logBox;

        private System.Windows.Forms.Button installteams;

        private System.Windows.Forms.Button teamsgrab;

        private System.Windows.Forms.Button fixup;

        #endregion
    }
}