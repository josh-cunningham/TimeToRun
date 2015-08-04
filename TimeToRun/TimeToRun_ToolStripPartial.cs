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
        private void waitCalibrationStripMenuItem_Click(object sender, EventArgs e)
        {
            this.SetCurrentCodeSnippet(CodeSnippet.Load(System.IO.Path.Combine(@"C:\Users\Josh\Development\github\TimeToRun\TimeToRun\bin\Debug\TTRCode\Examples", "WaitUntil.ttrx")));
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.GetCurrentCodeSnippet().SaveTo("ExampleCode");
        }

        private void fileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CodeSnippet codeSnippet;
            if (CodeSnippet.LoadFromDialog(out codeSnippet))
            {
                this.SetCurrentCodeSnippet(codeSnippet);
            }
        }
    }
}