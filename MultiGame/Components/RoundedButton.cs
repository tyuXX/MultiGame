namespace MultiGame.Components;

internal partial class RoundedButton : Button
{
    internal Color EdgeColor;
    internal RoundedButton()
    {
        BackColor = Color.LightGray;
        EdgeColor = Color.Gray;
        FlatStyle = FlatStyle.Flat;
        FlatAppearance.BorderColor = Color.Black;
        FlatAppearance.BorderSize = 0;
        Width = 140;
        Height = 45;
    }
    internal int rdus = 30;
    System.Drawing.Drawing2D.GraphicsPath GetRoundPath(RectangleF Rect, int radius)
    {
        float r2 = radius / 2f;
        System.Drawing.Drawing2D.GraphicsPath GraphPath = new System.Drawing.Drawing2D.GraphicsPath();
        GraphPath.AddArc(Rect.X, Rect.Y, radius, radius, 180, 90);
        GraphPath.AddLine(Rect.X + r2, Rect.Y, Rect.Width - r2, Rect.Y);
        GraphPath.AddArc(Rect.X + Rect.Width - radius, Rect.Y, radius, radius, 270, 90);
        GraphPath.AddLine(Rect.Width, Rect.Y + r2, Rect.Width, Rect.Height - r2);
        GraphPath.AddArc(Rect.X + Rect.Width - radius, Rect.Y + Rect.Height - radius, radius, radius, 0, 90);
        GraphPath.AddLine(Rect.Width - r2, Rect.Height, Rect.X + r2, Rect.Height);
        GraphPath.AddArc(Rect.X, Rect.Y + Rect.Height - radius, radius, radius, 90, 90);
        GraphPath.AddLine(Rect.X, Rect.Height - r2, Rect.X, Rect.Y + r2);
        GraphPath.CloseFigure();
        return GraphPath;
    }
    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        RectangleF Rect = new RectangleF(0, 0, Width, Height);
        using (System.Drawing.Drawing2D.GraphicsPath GraphPath = GetRoundPath(Rect, rdus))
        {
            Region = new Region(GraphPath);
            using (Pen pen = new Pen(EdgeColor, 1.75f))
            {
                pen.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                e.Graphics.DrawPath(pen, GraphPath);
            }
        }
    }
}
