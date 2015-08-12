namespace TTR.UserControls
{
    public class CodeInputText : InputTextBox
    {
        protected override string GetDefaultText()
        {
            return this.DefaultText + "\r\n\r\nNote: If unchanged, this text will not be compiled";
        }
        
    }
}