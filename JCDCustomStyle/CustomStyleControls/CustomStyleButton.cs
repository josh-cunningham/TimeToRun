namespace JCDCustomStyle
{
    using System.Windows.Forms;

    public partial class CustomStyleButton : Button, ICustomStyleControl
    {
        public CustomStyleButton()
        {
            CustomStyleManager.Instance.RegisterControl(this);
        }
    }
}