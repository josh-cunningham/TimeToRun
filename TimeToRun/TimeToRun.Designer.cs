namespace TimeToRun
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
            this.inputText = new System.Windows.Forms.TextBox();
            this.OutputText = new System.Windows.Forms.TextBox();
            this.compileButton = new System.Windows.Forms.Button();
            this.usingStatementsText = new System.Windows.Forms.TextBox();
            this.codeToTimeGroupBox = new System.Windows.Forms.GroupBox();
            this.initializationGroupBox = new System.Windows.Forms.GroupBox();
            this.initializationText = new System.Windows.Forms.TextBox();
            this.variablesText = new System.Windows.Forms.TextBox();
            this.runButton = new System.Windows.Forms.Button();
            this.sourceCodeText = new System.Windows.Forms.TextBox();
            this.codeToTimeGroupBox.SuspendLayout();
            this.initializationGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputText
            // 
            this.inputText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.inputText.Location = new System.Drawing.Point(6, 19);
            this.inputText.Multiline = true;
            this.inputText.Name = "inputText";
            this.inputText.Size = new System.Drawing.Size(233, 231);
            this.inputText.TabIndex = 0;
            this.inputText.Text = "Code to time";
            // 
            // OutputText
            // 
            this.OutputText.BackColor = System.Drawing.SystemColors.Control;
            this.OutputText.Enabled = false;
            this.OutputText.Location = new System.Drawing.Point(516, 31);
            this.OutputText.Multiline = true;
            this.OutputText.Name = "OutputText";
            this.OutputText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.OutputText.Size = new System.Drawing.Size(233, 231);
            this.OutputText.TabIndex = 1;
            // 
            // compileButton
            // 
            this.compileButton.Location = new System.Drawing.Point(18, 279);
            this.compileButton.Name = "compileButton";
            this.compileButton.Size = new System.Drawing.Size(368, 45);
            this.compileButton.TabIndex = 2;
            this.compileButton.Text = "Compile";
            this.compileButton.UseVisualStyleBackColor = true;
            this.compileButton.Click += new System.EventHandler(this.CompileButton_Click);
            // 
            // usingStatementsText
            // 
            this.usingStatementsText.Location = new System.Drawing.Point(6, 19);
            this.usingStatementsText.Multiline = true;
            this.usingStatementsText.Name = "usingStatementsText";
            this.usingStatementsText.Size = new System.Drawing.Size(233, 73);
            this.usingStatementsText.TabIndex = 3;
            this.usingStatementsText.Text = "Using Statements";
            // 
            // codeToTimeGroupBox
            // 
            this.codeToTimeGroupBox.Controls.Add(this.inputText);
            this.codeToTimeGroupBox.Location = new System.Drawing.Point(263, 12);
            this.codeToTimeGroupBox.Name = "codeToTimeGroupBox";
            this.codeToTimeGroupBox.Size = new System.Drawing.Size(247, 261);
            this.codeToTimeGroupBox.TabIndex = 4;
            this.codeToTimeGroupBox.TabStop = false;
            this.codeToTimeGroupBox.Text = "Code To Time";
            // 
            // initializationGroupBox
            // 
            this.initializationGroupBox.Controls.Add(this.initializationText);
            this.initializationGroupBox.Controls.Add(this.variablesText);
            this.initializationGroupBox.Controls.Add(this.usingStatementsText);
            this.initializationGroupBox.Location = new System.Drawing.Point(12, 12);
            this.initializationGroupBox.Name = "initializationGroupBox";
            this.initializationGroupBox.Size = new System.Drawing.Size(245, 261);
            this.initializationGroupBox.TabIndex = 5;
            this.initializationGroupBox.TabStop = false;
            this.initializationGroupBox.Text = "Code Initialization";
            // 
            // initializationText
            // 
            this.initializationText.Location = new System.Drawing.Point(6, 177);
            this.initializationText.Multiline = true;
            this.initializationText.Name = "initializationText";
            this.initializationText.Size = new System.Drawing.Size(233, 73);
            this.initializationText.TabIndex = 5;
            this.initializationText.Text = "Variable Initialization";
            // 
            // variablesText
            // 
            this.variablesText.Location = new System.Drawing.Point(6, 98);
            this.variablesText.Multiline = true;
            this.variablesText.Name = "variablesText";
            this.variablesText.Size = new System.Drawing.Size(233, 73);
            this.variablesText.TabIndex = 4;
            this.variablesText.Text = "Variable Declaration";
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(392, 279);
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
            this.sourceCodeText.Location = new System.Drawing.Point(18, 330);
            this.sourceCodeText.Multiline = true;
            this.sourceCodeText.Name = "sourceCodeText";
            this.sourceCodeText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.sourceCodeText.Size = new System.Drawing.Size(368, 217);
            this.sourceCodeText.TabIndex = 7;
            // 
            // TimeToRun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(762, 568);
            this.Controls.Add(this.sourceCodeText);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.OutputText);
            this.Controls.Add(this.initializationGroupBox);
            this.Controls.Add(this.codeToTimeGroupBox);
            this.Controls.Add(this.compileButton);
            this.Name = "TimeToRun";
            this.Text = "Time To Run C# v0.002";
            this.codeToTimeGroupBox.ResumeLayout(false);
            this.codeToTimeGroupBox.PerformLayout();
            this.initializationGroupBox.ResumeLayout(false);
            this.initializationGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputText;
        private System.Windows.Forms.TextBox OutputText;
        private System.Windows.Forms.Button compileButton;
        private System.Windows.Forms.TextBox usingStatementsText;
        private System.Windows.Forms.GroupBox codeToTimeGroupBox;
        private System.Windows.Forms.GroupBox initializationGroupBox;
        private System.Windows.Forms.TextBox initializationText;
        private System.Windows.Forms.TextBox variablesText;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.TextBox sourceCodeText;
    }
}

