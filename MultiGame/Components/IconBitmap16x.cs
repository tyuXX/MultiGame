namespace MultiGame.Components;

internal partial class IconBitmap16x : Control
{
    public List<Point> Start = new() { };
    public List<Point> End = new() { };
    public Point StartingPoint;
    public Color color;
    public IconBitmap16x()
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
        bool disable = false;
        for (int Y = 0; Y < 16; Y++)
        {
            for (int X = 0; X < 16; X++)
            {
                if (!disable && Start.Contains(new(X, Y)))
                {
                    disable = true;
                }
                if (disable && End.Contains(new(X, Y)))
                {
                    disable = false;
                }
                if (!disable)
                {
                    e.Graphics.FillRectangle(brush, new(new(StartingPoint.X + DrawingSize * X, StartingPoint.Y + DrawingSize * Y), new(DrawingSize, DrawingSize)));
                }
            }
        }
    }
}
