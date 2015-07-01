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
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.OutputTextBox = new System.Windows.Forms.TextBox();
            this.CompileBtn = new System.Windows.Forms.Button();
            this.usingStatementsTextBox = new System.Windows.Forms.TextBox();
            this.codeToTimeGroupBox = new System.Windows.Forms.GroupBox();
            this.initializationGroupBox = new System.Windows.Forms.GroupBox();
            this.initializationTextBox = new System.Windows.Forms.TextBox();
            this.variablesTextBox = new System.Windows.Forms.TextBox();
            this.codeToTimeGroupBox.SuspendLayout();
            this.initializationGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputTextBox
            // 
            this.inputTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.inputTextBox.Location = new System.Drawing.Point(6, 19);
            this.inputTextBox.Multiline = true;
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(326, 183);
            this.inputTextBox.TabIndex = 0;
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Enabled = false;
            this.OutputTextBox.Location = new System.Drawing.Point(338, 19);
            this.OutputTextBox.Multiline = true;
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.Size = new System.Drawing.Size(332, 183);
            this.OutputTextBox.TabIndex = 1;
            // 
            // CompileBtn
            // 
            this.CompileBtn.Location = new System.Drawing.Point(18, 400);
            this.CompileBtn.Name = "CompileBtn";
            this.CompileBtn.Size = new System.Drawing.Size(664, 45);
            this.CompileBtn.TabIndex = 2;
            this.CompileBtn.Text = "Compile";
            this.CompileBtn.UseVisualStyleBackColor = true;
            this.CompileBtn.Click += new System.EventHandler(this.CompileBtn_Click);
            // 
            // usingStatementsTextBox
            // 
            this.usingStatementsTextBox.Location = new System.Drawing.Point(6, 19);
            this.usingStatementsTextBox.Multiline = true;
            this.usingStatementsTextBox.Name = "usingStatementsTextBox";
            this.usingStatementsTextBox.Size = new System.Drawing.Size(205, 139);
            this.usingStatementsTextBox.TabIndex = 3;
            // 
            // codeToTimeGroupBox
            // 
            this.codeToTimeGroupBox.Controls.Add(this.OutputTextBox);
            this.codeToTimeGroupBox.Controls.Add(this.inputTextBox);
            this.codeToTimeGroupBox.Location = new System.Drawing.Point(12, 186);
            this.codeToTimeGroupBox.Name = "codeToTimeGroupBox";
            this.codeToTimeGroupBox.Size = new System.Drawing.Size(676, 208);
            this.codeToTimeGroupBox.TabIndex = 4;
            this.codeToTimeGroupBox.TabStop = false;
            this.codeToTimeGroupBox.Text = "Code To Time";
            // 
            // initializationGroupBox
            // 
            this.initializationGroupBox.Controls.Add(this.initializationTextBox);
            this.initializationGroupBox.Controls.Add(this.variablesTextBox);
            this.initializationGroupBox.Controls.Add(this.usingStatementsTextBox);
            this.initializationGroupBox.Location = new System.Drawing.Point(12, 12);
            this.initializationGroupBox.Name = "initializationGroupBox";
            this.initializationGroupBox.Size = new System.Drawing.Size(676, 164);
            this.initializationGroupBox.TabIndex = 5;
            this.initializationGroupBox.TabStop = false;
            this.initializationGroupBox.Text = "Code Initialization";
            // 
            // initializationTextBox
            // 
            this.initializationTextBox.Location = new System.Drawing.Point(459, 19);
            this.initializationTextBox.Multiline = true;
            this.initializationTextBox.Name = "initializationTextBox";
            this.initializationTextBox.Size = new System.Drawing.Size(211, 139);
            this.initializationTextBox.TabIndex = 5;
            // 
            // variablesTextBox
            // 
            this.variablesTextBox.Location = new System.Drawing.Point(217, 19);
            this.variablesTextBox.Multiline = true;
            this.variablesTextBox.Name = "variablesTextBox";
            this.variablesTextBox.Size = new System.Drawing.Size(236, 139);
            this.variablesTextBox.TabIndex = 4;
            // 
            // TimeToRun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 457);
            this.Controls.Add(this.initializationGroupBox);
            this.Controls.Add(this.codeToTimeGroupBox);
            this.Controls.Add(this.CompileBtn);
            this.Name = "TimeToRun";
            this.Text = "Time To Run C# v0.002";
            this.codeToTimeGroupBox.ResumeLayout(false);
            this.codeToTimeGroupBox.PerformLayout();
            this.initializationGroupBox.ResumeLayout(false);
            this.initializationGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.TextBox OutputTextBox;
        private System.Windows.Forms.Button CompileBtn;
        private System.Windows.Forms.TextBox usingStatementsTextBox;
        private System.Windows.Forms.GroupBox codeToTimeGroupBox;
        private System.Windows.Forms.GroupBox initializationGroupBox;
        private System.Windows.Forms.TextBox initializationTextBox;
        private System.Windows.Forms.TextBox variablesTextBox;
    }
}

