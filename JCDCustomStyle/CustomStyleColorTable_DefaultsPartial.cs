namespace JCDCustomStyle
{
    using System.Drawing;
    using System.Windows.Forms;

    public partial class CustomStyleColorTable
    {
        public static implicit operator CustomStyleColorTable(CustomStyleDefaultEnum styleDefault)
        {
            return new CustomStyleColorTable(styleDefault);
        }

        private CustomStyleColorTable(CustomStyleDefaultEnum styleDefault) :
            this()
        {
            this.ButtonSettings = new ButtonStyle();
            this.ButtonSettings.BorderSize = 0;
            this.ButtonSettings.FlatStyle = FlatStyle.Flat;

            switch (styleDefault)
            {
                case CustomStyleDefaultEnum.Light:
                    this.AllControlSettings = new ControlStyle()
                        {
                            ControlBackColor = Color.WhiteSmoke
                        };
                    break;

                case CustomStyleDefaultEnum.Dark:
                    this.AllControlSettings = new ControlStyle()
                        {
                            ControlBackColor = Color.SlateGray
                        };
                    break;
            }
        }
    }

    public enum CustomStyleDefaultEnum
    {
        Light,
        Dark
    }
}