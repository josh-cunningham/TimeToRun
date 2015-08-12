namespace JCDCustomStyle
{
    using System.Windows.Forms;

    public class CustomStyleForm : Form, ICustomStyleControl
    {
        public CustomStyleForm()
        {
            CustomStyleManager.Instance.RegisterControl(this);
        }
    }
}