namespace TTR
{
    using System;
    using TTR.Code;

    /// <summary>
    /// TimeToRun_ToolStripPartial
    ///     This partial should be used to control the form's ToolStrip
    /// </summary>
    public partial class TimeToRun
    {

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.inputTextCodeName.SetToDefaultText();
            this.inputTextUsingStatements.SetToDefaultText();
            this.inputTextVarDeclaration.SetToDefaultText();
            this.inputTextVarInitialization.SetToDefaultText();
            this.inputTextCodeToTime.SetToDefaultText();
        }

        private void waitCalibrationStripMenuItem_Click(object sender, EventArgs e)
        {
            this.SetCurrentCodeSnippet(CodeSnippet.Load(System.IO.Path.Combine(@"C:\Users\Josh\Development\github\TimeToRun\TimeToRun\bin\Debug\TTRCode\Examples", "WaitUntil.ttrx")));
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void fileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CodeSnippet codeSnippet;

            if (CodeSnippet.LoadFromDialog(out codeSnippet))
            {
                this.SetCurrentCodeSnippet(codeSnippet);
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.GetCurrentCodeSnippet().SaveAs();
        }

        private void quickLoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.SetCurrentCodeSnippet(CodeSnippet.Load(System.IO.Path.Combine(@"C:\Users\Josh\Development\github\TimeToRun\TimeToRun\bin\Debug\TTRCode", "TTRQuickSave.ttrx")));
        }

        private void quickSaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.GetCurrentCodeSnippet().SaveAs("TTRQuickSave");
        }
    }
}