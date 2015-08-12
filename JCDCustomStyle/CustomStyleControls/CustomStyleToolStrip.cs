namespace JCDCustomStyle
{
    using System.Windows.Forms;

    public class CustomStyleToolStrip : ToolStrip, ICustomStyleControl
    {
        public CustomStyleToolStrip()
        {
            CustomStyleManager.Instance.RegisterControl(this);
        }
    }
}
