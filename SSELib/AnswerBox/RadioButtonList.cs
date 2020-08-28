using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace SSELib.AnswerBox
{
    public partial class RadioButtonList : ListBox
    {
        private Size s;

        public RadioButtonList()
        {
            DrawMode = DrawMode.OwnerDrawFixed;
            using (Graphics.FromHwnd(IntPtr.Zero))
                s = RadioButtonRenderer.GetGlyphSize(Graphics.FromHwnd(IntPtr.Zero), RadioButtonState.CheckedNormal);
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            string text = (Items.Count > 0) ? GetItemText(Items[e.Index]) : Name;
            Rectangle rect = e.Bounds;
            Point point;
            TextFormatFlags flags = TextFormatFlags.Default | TextFormatFlags.NoPrefix;
            bool selected = (e.State & DrawItemState.Selected) == DrawItemState.Selected;
            RadioButtonState state = selected ?
                (Enabled ? RadioButtonState.CheckedNormal : RadioButtonState.CheckedDisabled) :
                (Enabled ? RadioButtonState.UncheckedNormal : RadioButtonState.UncheckedDisabled);

            if (RightToLeft == RightToLeft.Yes)
            {
                point = new Point(rect.Right - rect.Height + ((ItemHeight - s.Width) / 2),
                    rect.Top + ((ItemHeight - s.Height) / 2));
                rect = new Rectangle(rect.Left, rect.Top, rect.Width - rect.Height, rect.Height);
                flags |= TextFormatFlags.RightToLeft | TextFormatFlags.Right;
            }
            else
            {
                point = new Point(rect.Left + ((ItemHeight - s.Width) / 2),
                    rect.Top + ((ItemHeight - s.Height) / 2));
                rect = new Rectangle(rect.Left + rect.Height, rect.Top, rect.Width - rect.Height, rect.Height);
            }

            Color bgColor = selected ? (Enabled ? SystemColors.Highlight : SystemColors.InactiveBorder) : BackColor;
            Color fgColor = selected ? (Enabled ? SystemColors.HighlightText : SystemColors.GrayText) : ForeColor;

            using (SolidBrush brush = new SolidBrush(bgColor))
                e.Graphics.FillRectangle(brush, e.Bounds);

            RadioButtonRenderer.DrawRadioButton(e.Graphics, point, state);
            TextRenderer.DrawText(e.Graphics, text, Font, rect, fgColor, bgColor, flags);
            e.DrawFocusRectangle();
            base.OnDrawItem(e);
        }

        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override SelectionMode SelectionMode => SelectionMode.One;

        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override int ItemHeight => Font.Height + 2;

        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override DrawMode DrawMode
        {
            get => base.DrawMode;
            set => base.DrawMode = DrawMode.OwnerDrawFixed;
        }
    }
}
