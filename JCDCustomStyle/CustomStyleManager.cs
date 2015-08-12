namespace JCDCustomStyle
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    public class CustomStyleManager : MarshalByRefObject
    {
        public static CustomStyleManager Instance 
        { 
            get; 
            private set; 
        }
        
        static CustomStyleManager()
        {
            Instance = new CustomStyleManager();
        }

        private CustomStyleManager()
        {
        }

        public void RegisterControl(ICustomStyleControl customStyleControl)
        {
            this.customControls.Add(customStyleControl);
        }

        private List<ICustomStyleControl> customControls = new List<ICustomStyleControl>();

        public void ChangeStyle(CustomStyleColorTable colorTable)
        {
            foreach (Control control in this.customControls)
            {
                SetControlStyle(control, colorTable);
            }
        }

        public void ChangeStyle(CustomStyleDefaultEnum styleDefault)
        {
            var colorTable = new CustomStyleColorTable(styleDefault);

            foreach (Control control in this.customControls)
            {
                SetControlStyle(control, colorTable);
            }
        }

        public static void SetControlStyle(Control control, CustomStyleColorTable colorTable)
        {
            if (colorTable.AllControlSettings != null)
            {
                control.ApplyCustomStyle(colorTable.AllControlSettings);
            }

            Button button = control as Button;
            if (button != null && colorTable.ButtonSettings != null)
            {
                button.ApplyCustomStyle(colorTable.ButtonSettings);
            }
            
        }
    }
}