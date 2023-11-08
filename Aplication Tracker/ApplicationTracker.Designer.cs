namespace Aplication_Tracker
{
    partial class ApplicationTracker
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
            this.label1 = new System.Windows.Forms.Label();
            this.companyName = new System.Windows.Forms.TextBox();
            this.IsLinkedIn = new System.Windows.Forms.CheckBox();
            this.IsIndeed = new System.Windows.Forms.CheckBox();
            this.isHandShake = new System.Windows.Forms.CheckBox();
            this.isSde = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.contactName = new System.Windows.Forms.TextBox();
            this.notes = new System.Windows.Forms.RichTextBox();
            this.submit = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.IsH1B = new System.Windows.Forms.CheckBox();
            this.clearbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "CompanyName";
            // 
            // companyName
            // 
            this.companyName.Location = new System.Drawing.Point(173, 32);
            this.companyName.Margin = new System.Windows.Forms.Padding(4);
            this.companyName.Name = "companyName";
            this.companyName.Size = new System.Drawing.Size(245, 22);
            this.companyName.TabIndex = 1;
            // 
            // IsLinkedIn
            // 
            this.IsLinkedIn.AutoSize = true;
            this.IsLinkedIn.Location = new System.Drawing.Point(173, 111);
            this.IsLinkedIn.Margin = new System.Windows.Forms.Padding(4);
            this.IsLinkedIn.Name = "IsLinkedIn";
            this.IsLinkedIn.Size = new System.Drawing.Size(79, 20);
            this.IsLinkedIn.TabIndex = 2;
            this.IsLinkedIn.Text = "LinkedIn";
            this.IsLinkedIn.UseVisualStyleBackColor = true;
            this.IsLinkedIn.CheckedChanged += new System.EventHandler(this.IsLinkedIn_CheckedChanged);
            // 
            // IsIndeed
            // 
            this.IsIndeed.AutoSize = true;
            this.IsIndeed.Location = new System.Drawing.Point(173, 158);
            this.IsIndeed.Margin = new System.Windows.Forms.Padding(4);
            this.IsIndeed.Name = "IsIndeed";
            this.IsIndeed.Size = new System.Drawing.Size(71, 20);
            this.IsIndeed.TabIndex = 3;
            this.IsIndeed.Text = "Indeed";
            this.IsIndeed.UseVisualStyleBackColor = true;
            this.IsIndeed.CheckedChanged += new System.EventHandler(this.IsIndeed_CheckedChanged);
            // 
            // isHandShake
            // 
            this.isHandShake.AutoSize = true;
            this.isHandShake.Location = new System.Drawing.Point(173, 203);
            this.isHandShake.Margin = new System.Windows.Forms.Padding(4);
            this.isHandShake.Name = "isHandShake";
            this.isHandShake.Size = new System.Drawing.Size(99, 20);
            this.isHandShake.TabIndex = 4;
            this.isHandShake.Text = "Handshake";
            this.isHandShake.UseVisualStyleBackColor = true;
            this.isHandShake.CheckedChanged += new System.EventHandler(this.isHandShake_CheckedChanged);
            // 
            // isSde
            // 
            this.isSde.AutoSize = true;
            this.isSde.Location = new System.Drawing.Point(173, 245);
            this.isSde.Margin = new System.Windows.Forms.Padding(4);
            this.isSde.Name = "isSde";
            this.isSde.Size = new System.Drawing.Size(138, 20);
            this.isSde.TabIndex = 5;
            this.isSde.Text = "Software Engineer";
            this.isSde.UseVisualStyleBackColor = true;
            this.isSde.CheckedChanged += new System.EventHandler(this.isSde_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Is LinkedIn?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 158);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Is Indeed?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 203);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Is HandShake?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 250);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "SDE?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 304);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Contact Person";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 354);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Notes";
            // 
            // contactName
            // 
            this.contactName.AllowDrop = true;
            this.contactName.Location = new System.Drawing.Point(173, 304);
            this.contactName.Margin = new System.Windows.Forms.Padding(4);
            this.contactName.Name = "contactName";
            this.contactName.Size = new System.Drawing.Size(245, 22);
            this.contactName.TabIndex = 12;
            this.contactName.DragDrop += new System.Windows.Forms.DragEventHandler(this.contactName_DragEnter);
            this.contactName.DragEnter += new System.Windows.Forms.DragEventHandler(this.contactName_DragEnter);
            // 
            // notes
            // 
            this.notes.Location = new System.Drawing.Point(173, 354);
            this.notes.Margin = new System.Windows.Forms.Padding(4);
            this.notes.Name = "notes";
            this.notes.Size = new System.Drawing.Size(245, 117);
            this.notes.TabIndex = 13;
            this.notes.Text = "";
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(149, 480);
            this.submit.Margin = new System.Windows.Forms.Padding(4);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(100, 28);
            this.submit.TabIndex = 14;
            this.submit.Text = "Submit/Add";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 76);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "IsH1B?";
            // 
            // IsH1B
            // 
            this.IsH1B.AutoSize = true;
            this.IsH1B.Location = new System.Drawing.Point(173, 70);
            this.IsH1B.Margin = new System.Windows.Forms.Padding(4);
            this.IsH1B.Name = "IsH1B";
            this.IsH1B.Size = new System.Drawing.Size(55, 20);
            this.IsH1B.TabIndex = 16;
            this.IsH1B.Text = "H1B";
            this.IsH1B.UseVisualStyleBackColor = true;
            this.IsH1B.CheckedChanged += new System.EventHandler(this.IsH1B_CheckedChanged);
            // 
            // clearbtn
            // 
            this.clearbtn.Location = new System.Drawing.Point(298, 483);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(75, 23);
            this.clearbtn.TabIndex = 17;
            this.clearbtn.Text = "Clear";
            this.clearbtn.UseVisualStyleBackColor = true;
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
            // 
            // ApplicationTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 522);
            this.Controls.Add(this.clearbtn);
            this.Controls.Add(this.IsH1B);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.notes);
            this.Controls.Add(this.contactName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.isSde);
            this.Controls.Add(this.isHandShake);
            this.Controls.Add(this.IsIndeed);
            this.Controls.Add(this.IsLinkedIn);
            this.Controls.Add(this.companyName);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ApplicationTracker";
            this.Text = "Application Tracker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox companyName;
        private System.Windows.Forms.CheckBox IsLinkedIn;
        private System.Windows.Forms.CheckBox IsIndeed;
        private System.Windows.Forms.CheckBox isHandShake;
        private System.Windows.Forms.CheckBox isSde;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox contactName;
        private System.Windows.Forms.RichTextBox notes;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox IsH1B;
        private System.Windows.Forms.Button clearbtn;
    }
}