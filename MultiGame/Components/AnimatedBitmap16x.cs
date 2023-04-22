namespace MultiGame.Components;

internal partial class AnimatedBitmap16x : Control
{
    public List<Point> Start = new() { };
    public List<Point> End = new() { };
    public Point StartingPoint;
    public Color color;
    public System.Windows.Forms.Timer timer = new();
    bool disable = false;
    int X = 0;
    int Y = 0;
    PaintEventArgs paintEventArgs;
    public AnimatedBitmap16x()
    {
        timer.Tick += new(OnTimerTick);
        timer.Interval = 100;
        StartingPoint = new(0, 0);
        color = Color.Black;
        timer.Enabled = true;
    }
    int GetDrawingSize()
    {
        return Size.Height / 16;
    }
    void OnTimerTick(object sender, EventArgs e)
    {
        Draw(paintEventArgs);
    }
    void Draw(PaintEventArgs e)
    {
        int DrawingSize = GetDrawingSize();
        SolidBrush brush = new(color);
        X++;
        if (X >= 16)
        {
            X = 0;
            Y++;
        }
        if (Y >= 16)
        {
            Y = 0;
            e.Graphics.FillRectangle(brush, new(new(StartingPoint.X, StartingPoint.Y), new(DrawingSize * 16, DrawingSize * 16)));
        }
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
    protected override void OnPaint(PaintEventArgs e)
    {
        paintEventArgs = e;
    }
}
