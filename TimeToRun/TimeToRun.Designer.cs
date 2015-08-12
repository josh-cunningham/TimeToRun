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
            this.textOutput = new JCDCustomStyle.UserControls.OutputTextBox();
            this.runButton = new JCDCustomStyle.CustomStyleControls.CustomStyleButton();
            this.compileButton = new JCDCustomStyle.CustomStyleControls.CustomStyleButton();
            this.ttrUserMenuStrip = new TTR.UserControls.TTRUserMenuStrip();
            this.ttrTool = new TTR.UserControls.TTRTool();
            this.inputTextCodeName = new JCDCustomStyle.UserControls.InputTextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.initializationGroupBox = new System.Windows.Forms.GroupBox();
            this.inputTextVarDeclaration = new TTR.UserControls.CodeInputText();
            this.inputTextVarInitialization = new TTR.UserControls.CodeInputText();
            this.inputTextUsingStatements = new TTR.UserControls.CodeInputText();
            this.codeToTimeGroupBox = new System.Windows.Forms.GroupBox();
            this.inputTextCodeToTime = new TTR.UserControls.CodeInputText();
            this.initializationGroupBox.SuspendLayout();
            this.codeToTimeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // textOutput
            // 
            this.textOutput.Location = new System.Drawing.Point(108, 329);
            this.textOutput.Name = "textOutput";
            this.textOutput.Size = new System.Drawing.Size(512, 108);
            this.textOutput.TabIndex = 18;
            this.textOutput.Enabled = true;
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(9, 386);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(93, 51);
            this.runButton.TabIndex = 17;
            this.runButton.Text = "Run";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // compileButton
            // 
            this.compileButton.Location = new System.Drawing.Point(9, 329);
            this.compileButton.Name = "compileButton";
            this.compileButton.Size = new System.Drawing.Size(93, 51);
            this.compileButton.TabIndex = 16;
            this.compileButton.Text = "Compile";
            this.compileButton.UseVisualStyleBackColor = true;
            this.compileButton.Click += new System.EventHandler(this.CompileButton_Click);
            // 
            // ttrUserMenuStrip
            // 
            this.ttrUserMenuStrip.Dock = System.Windows.Forms.DockStyle.Top;
            this.ttrUserMenuStrip.Location = new System.Drawing.Point(3, 0);
            this.ttrUserMenuStrip.Name = "ttrUserMenuStrip";
            this.ttrUserMenuStrip.Size = new System.Drawing.Size(630, 24);
            this.ttrUserMenuStrip.TabIndex = 15;
            // 
            // ttrTool
            // 
            this.ttrTool.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ttrTool.Location = new System.Drawing.Point(3, 444);
            this.ttrTool.Name = "ttrTool";
            this.ttrTool.Size = new System.Drawing.Size(630, 25);
            this.ttrTool.TabIndex = 14;
            this.ttrTool.Text = "ttrTool1";
            // 
            // inputTextCodeName
            // 
            this.inputTextCodeName.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.inputTextCodeName.DefaultText = "Enter a name for your code here";
            this.inputTextCodeName.Location = new System.Drawing.Point(12, 35);
            this.inputTextCodeName.Name = "inputTextCodeName";
            this.inputTextCodeName.Size = new System.Drawing.Size(614, 21);
            this.inputTextCodeName.TabIndex = 12;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 469);
            this.splitter1.TabIndex = 8;
            this.splitter1.TabStop = false;
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
            // codeToTimeGroupBox
            // 
            this.codeToTimeGroupBox.Controls.Add(this.inputTextCodeToTime);
            this.codeToTimeGroupBox.Location = new System.Drawing.Point(260, 62);
            this.codeToTimeGroupBox.Name = "codeToTimeGroupBox";
            this.codeToTimeGroupBox.Size = new System.Drawing.Size(366, 261);
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
            this.inputTextCodeToTime.Size = new System.Drawing.Size(354, 242);
            this.inputTextCodeToTime.TabIndex = 18;
            // 
            // TimeToRun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 469);
            this.Controls.Add(this.textOutput);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.compileButton);
            this.Controls.Add(this.ttrUserMenuStrip);
            this.Controls.Add(this.ttrTool);
            this.Controls.Add(this.inputTextCodeName);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.initializationGroupBox);
            this.Controls.Add(this.codeToTimeGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TimeToRun";
            this.Text = "Time To Run C#";
            this.initializationGroupBox.ResumeLayout(false);
            this.codeToTimeGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox codeToTimeGroupBox;
        private System.Windows.Forms.GroupBox initializationGroupBox;
        private System.Windows.Forms.Splitter splitter1;
        private JCDCustomStyle.UserControls.InputTextBox inputTextCodeName;
        private TTR.UserControls.CodeInputText inputTextUsingStatements;
        private TTR.UserControls.CodeInputText inputTextCodeToTime;
        private TTR.UserControls.CodeInputText inputTextVarDeclaration;
        private TTR.UserControls.CodeInputText inputTextVarInitialization;
        private UserControls.TTRTool ttrTool;
        private UserControls.TTRUserMenuStrip ttrUserMenuStrip;
        private JCDCustomStyle.CustomStyleControls.CustomStyleButton compileButton;
        private JCDCustomStyle.CustomStyleControls.CustomStyleButton runButton;
        private JCDCustomStyle.UserControls.OutputTextBox textOutput;
    }
}

