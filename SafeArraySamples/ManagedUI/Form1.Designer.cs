namespace ManagedUI
{
    partial class FormMain
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
            this.groupTests = new System.Windows.Forms.GroupBox();
            this.groupOutput = new System.Windows.Forms.GroupBox();
            this.buttonTestByteSA = new System.Windows.Forms.Button();
            this.buttonTestStringSA = new System.Windows.Forms.Button();
            this.listBoxOutput = new System.Windows.Forms.ListBox();
            this.labelInfo = new System.Windows.Forms.Label();
            this.linkLabelBlog = new System.Windows.Forms.LinkLabel();
            this.groupTests.SuspendLayout();
            this.groupOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupTests
            // 
            this.groupTests.Controls.Add(this.buttonTestStringSA);
            this.groupTests.Controls.Add(this.buttonTestByteSA);
            this.groupTests.Location = new System.Drawing.Point(12, 20);
            this.groupTests.Name = "groupTests";
            this.groupTests.Size = new System.Drawing.Size(261, 259);
            this.groupTests.TabIndex = 0;
            this.groupTests.TabStop = false;
            this.groupTests.Text = "Tests";
            // 
            // groupOutput
            // 
            this.groupOutput.Controls.Add(this.listBoxOutput);
            this.groupOutput.Location = new System.Drawing.Point(296, 20);
            this.groupOutput.Name = "groupOutput";
            this.groupOutput.Size = new System.Drawing.Size(263, 259);
            this.groupOutput.TabIndex = 1;
            this.groupOutput.TabStop = false;
            this.groupOutput.Text = "Output";
            // 
            // buttonTestByteSA
            // 
            this.buttonTestByteSA.Location = new System.Drawing.Point(17, 45);
            this.buttonTestByteSA.Name = "buttonTestByteSA";
            this.buttonTestByteSA.Size = new System.Drawing.Size(217, 65);
            this.buttonTestByteSA.TabIndex = 0;
            this.buttonTestByteSA.Text = "Test Safe Array of Bytes";
            this.buttonTestByteSA.UseVisualStyleBackColor = true;
            this.buttonTestByteSA.Click += new System.EventHandler(this.buttonTestByteSA_Click);
            // 
            // buttonTestStringSA
            // 
            this.buttonTestStringSA.Location = new System.Drawing.Point(17, 146);
            this.buttonTestStringSA.Name = "buttonTestStringSA";
            this.buttonTestStringSA.Size = new System.Drawing.Size(216, 69);
            this.buttonTestStringSA.TabIndex = 1;
            this.buttonTestStringSA.Text = "Test Safe Array of Strings";
            this.buttonTestStringSA.UseVisualStyleBackColor = true;
            this.buttonTestStringSA.Click += new System.EventHandler(this.buttonTestStringSA_Click);
            // 
            // listBoxOutput
            // 
            this.listBoxOutput.FormattingEnabled = true;
            this.listBoxOutput.Location = new System.Drawing.Point(13, 34);
            this.listBoxOutput.Name = "listBoxOutput";
            this.listBoxOutput.Size = new System.Drawing.Size(236, 212);
            this.listBoxOutput.TabIndex = 0;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(16, 327);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(192, 13);
            this.labelInfo.TabIndex = 2;
            this.labelInfo.Text = "Safe Array Tests -- by Giovanni Dicanio";
            // 
            // linkLabelBlog
            // 
            this.linkLabelBlog.AutoSize = true;
            this.linkLabelBlog.Location = new System.Drawing.Point(205, 327);
            this.linkLabelBlog.Name = "linkLabelBlog";
            this.linkLabelBlog.Size = new System.Drawing.Size(113, 13);
            this.linkLabelBlog.TabIndex = 3;
            this.linkLabelBlog.TabStop = true;
            this.linkLabelBlog.Text = "msmvps.com/gdicanio";
            this.linkLabelBlog.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelBlog_LinkClicked);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 365);
            this.Controls.Add(this.linkLabelBlog);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.groupOutput);
            this.Controls.Add(this.groupTests);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "C# Application Calling into a Native DLL";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupTests.ResumeLayout(false);
            this.groupOutput.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupTests;
        private System.Windows.Forms.Button buttonTestStringSA;
        private System.Windows.Forms.Button buttonTestByteSA;
        private System.Windows.Forms.GroupBox groupOutput;
        private System.Windows.Forms.ListBox listBoxOutput;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.LinkLabel linkLabelBlog;
    }
}

