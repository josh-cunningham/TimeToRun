namespace JCDCustomStyle.UserControls
{
    partial class OutputTextBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textOutput
            // 
            this.textOutput.BackColor = System.Drawing.SystemColors.Control;
            this.textOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textOutput.Location = new System.Drawing.Point(0, 0);
            this.textOutput.Multiline = true;
            this.textOutput.Name = "textOutput";
            this.textOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textOutput.Size = new System.Drawing.Size(406, 192);
            this.textOutput.TabIndex = 2;
            // 
            // OutputTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textOutput);
            this.Name = "OutputTextBox";
            this.Size = new System.Drawing.Size(406, 192);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textOutput;
    }
}
