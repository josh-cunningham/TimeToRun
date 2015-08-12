namespace JCDCustomStyle.CustomStyleControls
{
    using System.Windows.Forms;

    public class CustomStyleTextBox : TextBox, ICustomStyleControl
    {
        public CustomStyleTextBox()
        {
            CustomStyleManager.Instance.RegisterControl(this);
        }
    }
}