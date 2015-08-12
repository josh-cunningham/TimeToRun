namespace JCDCustomStyle
{
    using System.Windows.Forms;

    public partial class CustomStyleMenuStrip : MenuStrip, ICustomStyleControl
    {
        public CustomStyleMenuStrip()
        {
            CustomStyleManager.Instance.RegisterControl(this);
        }
    }
}