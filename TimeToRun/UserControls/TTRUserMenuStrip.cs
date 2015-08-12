using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTR.UserControls
{
    using JCDCustomStyle;
    using System.IO;
    using TTR.Code;
    using TTR.Common;

    using System.Runtime.InteropServices;

    public partial class TTRUserMenuStrip : UserControl
    {


        private Point start_point = new Point(0, 0);

        private Point lastMousePosition = new Point(0, 0);
        private Point lastFormLocation = new Point(0, 0);
        private Form form;


        private void MenuStrip_MouseDown(object sender, MouseEventArgs e)
        {
            FormMover.Instance.FollowMouseDownMovement(this, new MoveFormEventArgs(TimeToRun.Instance));
            /*
            this.start_point = new Point(e.X, e.Y);

            lastMousePosition = Control.MousePosition;
            form = this.GetForm();
            lastFormLocation = form.Location;
            this.form.MouseMove += this.MenuStrip_MouseMove;
            this.ttrMenu.MouseMove += this.MenuStrip_MouseMove;

            Cursor.Clip = this.form.Bounds;
             */
        }

        private void MenuStrip_MouseUp(object sender, MouseEventArgs e)
        {
            this.ttrMenu.MouseMove -= this.MenuStrip_MouseMove;

            Cursor.Clip = Rectangle.Empty;
        }

        private void MenuStrip_MouseMove(object sender, EventArgs e)
        {
            Point mouseMovement = new Point(Control.MousePosition.X - lastMousePosition.X,
                                            Control.MousePosition.Y - lastMousePosition.Y);

            form.Location = lastFormLocation = new Point(lastFormLocation.X + mouseMovement.X,
                                                         lastFormLocation.Y + mouseMovement.Y);

            lastMousePosition = Control.MousePosition;

            Cursor.Clip = this.form.Bounds;
        }









        private ICodeSnippetTextSet CodeSnippetText
        {
            get
            {
                return TimeToRun.Instance;
            }
        }

        public TTRUserMenuStrip()
        {
            InitializeComponent();

            this.ttrMenu.MouseDown += this.MenuStrip_MouseDown;
            //this.ttrMenu.MouseUp += this.MenuStrip_MouseUp;
        }

        private void exitXButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomStyleManager.Instance.ChangeStyle(CustomStyleDefaultEnum.Light);
        }

        private void darkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomStyleManager.Instance.ChangeStyle(CustomStyleDefaultEnum.Dark);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.CodeSnippetText.DisplayDefaultText();
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CodeSnippet codeSnippet;

            if (CodeSnippet.LoadFromDialog(out codeSnippet))
            {
                this.CodeSnippetText.SetCurrentCodeSnippet(codeSnippet);
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.CodeSnippetText.GetCurrentCodeSnippet().SaveAs();
        }

        private void quickLoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.CodeSnippetText.SetCurrentCodeSnippet(CodeSnippet.Load(Path.Combine(TTRPath.SavedCodePath, "TTRQuickSave.ttrx")));
        }

        private void quickSaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.CodeSnippetText.GetCurrentCodeSnippet().SaveAs("TTRQuickSave");
        }


        private void minimiseButton_Click(object sender, EventArgs e)
        {
            TimeToRun.Instance.WindowState = FormWindowState.Minimized;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ttrMenu1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
