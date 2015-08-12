namespace JCDCustomStyle.CustomStyleControls
{
    using System.Windows.Forms;

    public class CustomStyleMenuStrip : MenuStrip, ICustomStyleControl
    {
        public CustomStyleMenuStrip()
        {
            CustomStyleManager.Instance.RegisterControl(this);
        }
    }
}