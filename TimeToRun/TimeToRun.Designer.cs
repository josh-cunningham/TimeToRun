namespace TTR
{
    partial class TimeToRun
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
            this.OutputText = new System.Windows.Forms.TextBox();
            this.compileButton = new System.Windows.Forms.Button();
            this.codeToTimeGroupBox = new System.Windows.Forms.GroupBox();
            this.inputTextCodeToTime = new TTR.UserControls.CodeInputText();
            this.initializationGroupBox = new System.Windows.Forms.GroupBox();
            this.inputTextVarDeclaration = new TTR.UserControls.CodeInputText();
            this.inputTextVarInitialization = new TTR.UserControls.CodeInputText();
            this.inputTextUsingStatements = new TTR.UserControls.CodeInputText();
            this.runButton = new System.Windows.Forms.Button();
            this.sourceCodeText = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.waitCalibrationExampleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.quickLoadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quickSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportABugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutTimeToRunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.inputTextCodeName = new TTR.UserControls.InputTextBox();
            this.codeToTimeGroupBox.SuspendLayout();
            this.initializationGroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OutputText
            // 
            this.OutputText.BackColor = System.Drawing.SystemColors.Control;
            this.OutputText.Enabled = false;
            this.OutputText.Location = new System.Drawing.Point(513, 81);
            this.OutputText.Multiline = true;
            this.OutputText.Name = "OutputText";
            this.OutputText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.OutputText.Size = new System.Drawing.Size(233, 231);
            this.OutputText.TabIndex = 1;
            // 
            // compileButton
            // 
            this.compileButton.Location = new System.Drawing.Point(15, 329);
            this.compileButton.Name = "compileButton";
            this.compileButton.Size = new System.Drawing.Size(368, 45);
            this.compileButton.TabIndex = 2;
            this.compileButton.Text = "Compile";
            this.compileButton.UseVisualStyleBackColor = true;
            this.compileButton.Click += new System.EventHandler(this.CompileButton_Click);
            // 
            // codeToTimeGroupBox
            // 
            this.codeToTimeGroupBox.Controls.Add(this.inputTextCodeToTime);
            this.codeToTimeGroupBox.Location = new System.Drawing.Point(260, 62);
            this.codeToTimeGroupBox.Name = "codeToTimeGroupBox";
            this.codeToTimeGroupBox.Size = new System.Drawing.Size(247, 261);
            this.codeToTimeGroupBox.TabIndex = 4;
            this.codeToTimeGroupBox.TabStop = false;
            this.codeToTimeGroupBox.Text = "Code To Time";
            // 
            // inputTextCodeToTime
            // 
            this.inputTextCodeToTime.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.inputTextCodeToTime.DefaultText = "Enter the code you want to be timed here";
            this.inputTextCodeToTime.Location = new System.Drawing.Point(6, 19);
            this.inputTextCodeToTime.Name = "inputTextCodeToTime";
            this.inputTextCodeToTime.Size = new System.Drawing.Size(235, 236);
            this.inputTextCodeToTime.TabIndex = 18;
            // 
            // initializationGroupBox
            // 
            this.initializationGroupBox.Controls.Add(this.inputTextVarDeclaration);
            this.initializationGroupBox.Controls.Add(this.inputTextVarInitialization);
            this.initializationGroupBox.Controls.Add(this.inputTextUsingStatements);
            this.initializationGroupBox.Location = new System.Drawing.Point(9, 62);
            this.initializationGroupBox.Name = "initializationGroupBox";
            this.initializationGroupBox.Size = new System.Drawing.Size(245, 261);
            this.initializationGroupBox.TabIndex = 5;
            this.initializationGroupBox.TabStop = false;
            this.initializationGroupBox.Text = "Code Initialization";
            // 
            // inputTextVarDeclaration
            // 
            this.inputTextVarDeclaration.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.inputTextVarDeclaration.DefaultText = "Declare you variables here";
            this.inputTextVarDeclaration.Location = new System.Drawing.Point(6, 100);
            this.inputTextVarDeclaration.Name = "inputTextVarDeclaration";
            this.inputTextVarDeclaration.Size = new System.Drawing.Size(233, 74);
            this.inputTextVarDeclaration.TabIndex = 19;
            // 
            // inputTextVarInitialization
            // 
            this.inputTextVarInitialization.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.inputTextVarInitialization.DefaultText = "Initialise your variables here";
            this.inputTextVarInitialization.Location = new System.Drawing.Point(6, 180);
            this.inputTextVarInitialization.Name = "inputTextVarInitialization";
            this.inputTextVarInitialization.Size = new System.Drawing.Size(233, 75);
            this.inputTextVarInitialization.TabIndex = 20;
            // 
            // inputTextUsingStatements
            // 
            this.inputTextUsingStatements.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.inputTextUsingStatements.DefaultText = "Enter \'Using\' statements here";
            this.inputTextUsingStatements.Location = new System.Drawing.Point(6, 19);
            this.inputTextUsingStatements.Name = "inputTextUsingStatements";
            this.inputTextUsingStatements.Size = new System.Drawing.Size(233, 75);
            this.inputTextUsingStatements.TabIndex = 17;
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(389, 329);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(357, 45);
            this.runButton.TabIndex = 6;
            this.runButton.Text = "Run";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // sourceCodeText
            // 
            this.sourceCodeText.BackColor = System.Drawing.SystemColors.Control;
            this.sourceCodeText.Location = new System.Drawing.Point(15, 380);
            this.sourceCodeText.Multiline = true;
            this.sourceCodeText.Name = "sourceCodeText";
            this.sourceCodeText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.sourceCodeText.Size = new System.Drawing.Size(731, 217);
            this.sourceCodeText.TabIndex = 7;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 24);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 609);
            this.splitter1.TabIndex = 8;
            this.splitter1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(758, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator3,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator2,
            this.quickLoadToolStripMenuItem,
            this.quickSaveToolStripMenuItem,
            this.toolStripSeparator4,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.waitCalibrationExampleToolStripMenuItem,
            this.toolStripSeparator1,
            this.fileToolStripMenuItem1});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // waitCalibrationExampleToolStripMenuItem
            // 
            this.waitCalibrationExampleToolStripMenuItem.Name = "waitCalibrationExampleToolStripMenuItem";
            this.waitCalibrationExampleToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.waitCalibrationExampleToolStripMenuItem.Text = "WaitUntil Example";
            this.waitCalibrationExampleToolStripMenuItem.Click += new System.EventHandler(this.waitCalibrationStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(167, 6);
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(170, 22);
            this.fileToolStripMenuItem1.Text = "File...";
            this.fileToolStripMenuItem1.Click += new System.EventHandler(this.fileToolStripMenuItem1_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(149, 6);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // quickLoadToolStripMenuItem
            // 
            this.quickLoadToolStripMenuItem.Name = "quickLoadToolStripMenuItem";
            this.quickLoadToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.quickLoadToolStripMenuItem.Text = "Quick Load";
            this.quickLoadToolStripMenuItem.Click += new System.EventHandler(this.quickLoadToolStripMenuItem_Click);
            // 
            // quickSaveToolStripMenuItem
            // 
            this.quickSaveToolStripMenuItem.Name = "quickSaveToolStripMenuItem";
            this.quickSaveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.quickSaveToolStripMenuItem.Text = "Quick Save";
            this.quickSaveToolStripMenuItem.Click += new System.EventHandler(this.quickSaveToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportABugToolStripMenuItem,
            this.aboutTimeToRunToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // reportABugToolStripMenuItem
            // 
            this.reportABugToolStripMenuItem.Name = "reportABugToolStripMenuItem";
            this.reportABugToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.reportABugToolStripMenuItem.Text = "Report a Bug";
            // 
            // aboutTimeToRunToolStripMenuItem
            // 
            this.aboutTimeToRunToolStripMenuItem.Name = "aboutTimeToRunToolStripMenuItem";
            this.aboutTimeToRunToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.aboutTimeToRunToolStripMenuItem.Text = "About TimeToRun";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Gainsboro;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(3, 611);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(755, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(72, 17);
            this.statusLabel.Text = "Time to Run";
            // 
            // inputTextCodeName
            // 
            this.inputTextCodeName.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.inputTextCodeName.DefaultText = "Enter a name for your code here";
            this.inputTextCodeName.Location = new System.Drawing.Point(12, 35);
            this.inputTextCodeName.Name = "inputTextCodeName";
            this.inputTextCodeName.Size = new System.Drawing.Size(284, 21);
            this.inputTextCodeName.TabIndex = 12;
            // 
            // TimeToRun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(758, 633);
            this.Controls.Add(this.inputTextCodeName);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.sourceCodeText);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.OutputText);
            this.Controls.Add(this.initializationGroupBox);
            this.Controls.Add(this.codeToTimeGroupBox);
            this.Controls.Add(this.compileButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TimeToRun";
            this.Text = "Time To Run C#";
            this.codeToTimeGroupBox.ResumeLayout(false);
            this.initializationGroupBox.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox OutputText;
        private System.Windows.Forms.Button compileButton;
        private System.Windows.Forms.GroupBox codeToTimeGroupBox;
        private System.Windows.Forms.GroupBox initializationGroupBox;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.TextBox sourceCodeText;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportABugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutTimeToRunToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem waitCalibrationExampleToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private TTR.UserControls.InputTextBox inputTextCodeName;
        private TTR.UserControls.CodeInputText inputTextUsingStatements;
        private TTR.UserControls.CodeInputText inputTextCodeToTime;
        private TTR.UserControls.CodeInputText inputTextVarDeclaration;
        private TTR.UserControls.CodeInputText inputTextVarInitialization;
        private System.Windows.Forms.ToolStripMenuItem quickSaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem quickLoadToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    }
}

