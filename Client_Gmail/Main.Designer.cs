namespace Client_Gmail
{
    partial class frmMain
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
            this.btnSend = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbGmail = new System.Windows.Forms.TextBox();
            this.tbSubject = new System.Windows.Forms.TextBox();
            this.rtbContent = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(600, 518);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(207, 81);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gmail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Subject";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Content";
            // 
            // tbGmail
            // 
            this.tbGmail.Location = new System.Drawing.Point(177, 37);
            this.tbGmail.Name = "tbGmail";
            this.tbGmail.Size = new System.Drawing.Size(630, 31);
            this.tbGmail.TabIndex = 4;
            this.tbGmail.Text = "Gmail \'s Receiver";
            this.tbGmail.Click += new System.EventHandler(this.tbGmail_Click);
            this.tbGmail.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbSubject
            // 
            this.tbSubject.Location = new System.Drawing.Point(177, 95);
            this.tbSubject.Name = "tbSubject";
            this.tbSubject.Size = new System.Drawing.Size(630, 31);
            this.tbSubject.TabIndex = 5;
            this.tbSubject.Text = "Put your Subject here";
            this.tbSubject.Click += new System.EventHandler(this.tbSubject_Click);
            this.tbSubject.TextChanged += new System.EventHandler(this.tbSubject_TextChanged);
            // 
            // rtbContent
            // 
            this.rtbContent.Location = new System.Drawing.Point(183, 171);
            this.rtbContent.Name = "rtbContent";
            this.rtbContent.Size = new System.Drawing.Size(623, 329);
            this.rtbContent.TabIndex = 6;
            this.rtbContent.Text = "";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 643);
            this.Controls.Add(this.rtbContent);
            this.Controls.Add(this.tbSubject);
            this.Controls.Add(this.tbGmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSend);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gmail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbGmail;
        private System.Windows.Forms.TextBox tbSubject;
        private System.Windows.Forms.RichTextBox rtbContent;
    }
}

