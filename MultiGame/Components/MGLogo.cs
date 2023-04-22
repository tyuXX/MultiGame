namespace MultiGame.Components;

internal partial class MGLogo : Control
{
    public Point StartingPoint;
    public Color color;
    public MGLogo()
    {
        StartingPoint = new(0, 0);
        color = Color.Black;
    }
    int GetDrawingSize()
    {
        return Size.Height / 16;
    }
    protected override void OnPaint(PaintEventArgs e)
    {
        int DrawingSize = GetDrawingSize();
        SolidBrush brush = new(color);
        Pen pen = new Pen(brush, DrawingSize);
        //e.Graphics.DrawRectangle(pen,new(new(StartingPoint.X + DrawingSize,StartingPoint.Y + DrawingSize),new(DrawingSize*14,DrawingSize*13)));
        //e.Graphics.DrawRectangle(pen,new(new(StartingPoint.X + DrawingSize * 2,StartingPoint.Y + (DrawingSize / 2) * 6),new(DrawingSize*12,DrawingSize / 2)));
        //e.Graphics.DrawRectangle(pen,new(new(StartingPoint.X + DrawingSize * 2,StartingPoint.Y + (DrawingSize / 2) * 10),new(DrawingSize*12,DrawingSize / 2)));
        //e.Graphics.DrawRectangle(pen,new(new(StartingPoint.X + DrawingSize * 2,StartingPoint.Y + (DrawingSize / 2) * 14),new(DrawingSize*12,DrawingSize / 2)));
        //e.Graphics.DrawRectangle(pen,new(new(StartingPoint.X + DrawingSize * 2,StartingPoint.Y + (DrawingSize / 2) * 18),new(DrawingSize*12,DrawingSize / 2)));
        //e.Graphics.DrawRectangle(pen,new(new(StartingPoint.X + DrawingSize * 2,StartingPoint.Y + (DrawingSize / 2) * 22),new(DrawingSize*12,DrawingSize / 2)));
        //e.Graphics.DrawRectangle(pen,new(new(StartingPoint.X + DrawingSize * 2,StartingPoint.Y + (DrawingSize / 2) * 26),new(DrawingSize*12,DrawingSize / 2)));
        for (int ii = 0; ii < 16; ii++) // Height
        {
            if (false)
            {

            }
            else
            {
                for (int i = 0; i < 16; i++) // Width
                {
                    e.Graphics.FillRectangle(brush, new(new(StartingPoint.X + DrawingSize * i, StartingPoint.Y + DrawingSize * ii), new(DrawingSize, DrawingSize)));

                }
            }
        }
    }
}
