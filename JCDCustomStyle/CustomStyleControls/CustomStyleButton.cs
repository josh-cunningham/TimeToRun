namespace JCDCustomStyle.CustomStyleControls
{
    using System.Windows.Forms;

    public class CustomStyleButton : Button, ICustomStyleControl
    {
        public CustomStyleButton()
        {
            CustomStyleManager.Instance.RegisterControl(this);
        }
    }
}