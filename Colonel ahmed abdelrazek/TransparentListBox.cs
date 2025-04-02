using System;
using System.Drawing;
using System.Windows.Forms;

public class TransparentListBox : ListBox
{
    public TransparentListBox()
    {
        // Enable transparency
        this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        this.BackColor = Color.Transparent;
    }

    protected override void OnPaintBackground(PaintEventArgs pevent)
    {
        // Prevent default background painting
        if (this.Parent != null)
        {
            pevent.Graphics.FillRectangle(new SolidBrush(this.Parent.BackColor), this.ClientRectangle);
        }
    }
}
