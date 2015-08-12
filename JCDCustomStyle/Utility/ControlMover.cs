namespace JCDCustomStyle
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    public class FormMover : IMessageFilter, IDisposable
    {
        private const int WM_MOUSEMOVE = 0x0200;

        private const int WM_LBUTTONUP = 0x0202;

        private Point lastMousePosition = new Point(0, 0);
        private Point lastFormLocation = new Point(0, 0);

        private Form formToMove;

        public static FormMover Instance
        {
            get;
            private set;
        }

        static FormMover()
        {
            Instance = new FormMover();
        }

        private FormMover()
        {
        }

        public bool PreFilterMessage(ref Message m)
        {
            if (m.Msg == WM_MOUSEMOVE)
            {
                MouseMove();
            }

            if (m.Msg == WM_LBUTTONUP)
            {
                this.Dispose();
            }

            // Always allow message to continue to the next filter control
            return false;
        }

        public void FollowMouseDownMovement(object sender, MoveFormEventArgs e)
        {
            Application.AddMessageFilter(this);

            formToMove = e.Form;

            lastMousePosition = Control.MousePosition;
            lastFormLocation = formToMove.Location;

            Cursor.Clip = formToMove.Bounds;
        }

        public void Dispose()
        {
            Application.RemoveMessageFilter(this);

            Cursor.Clip = Rectangle.Empty;
        }

        private void MouseMove()
        {
            Point mouseMovement = new Point(Control.MousePosition.X - lastMousePosition.X,
                                            Control.MousePosition.Y - lastMousePosition.Y);

            formToMove.Location = lastFormLocation = new Point(lastFormLocation.X + mouseMovement.X,
                                                         lastFormLocation.Y + mouseMovement.Y);

            lastMousePosition = Control.MousePosition;

            Cursor.Clip = formToMove.Bounds;
        }
    }

    public class MoveFormEventArgs : EventArgs
    {
        public Form Form
        {
            get;
            private set;
        }

        public MoveFormEventArgs(Form form)
        {
            this.Form = form;
        }
    }
}