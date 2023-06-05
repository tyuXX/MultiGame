﻿namespace MultiGame.Components;

internal partial class AnimatedBitmap16x : Control
{
    internal List<Point> Start = new() { };
    internal List<Point> End = new() { };
    internal Point StartingPoint;
    internal Color color;
    internal const int max = 256;
    internal int until;
    internal AnimatedBitmap16x()
    {
        StartingPoint = new(0, 0);
        color = Color.Black;
        until = max;
    }
    int GetDrawingSize() => Size.Height / 16;
    protected override void OnPaint(PaintEventArgs e)
    {
        if (until > max)
        {
            until -= max;
        }
        int DrawingSize = GetDrawingSize();
        SolidBrush brush = new(color);
        bool disable = false;
        int done = 0;
        for (int Y = 0; Y < 16; Y++)
        {
            if (done >= until)
            {
                break;
            }
            for (int X = 0; X < 16; X++)
            {
                if (done >= until)
                {
                    break;
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
                done++;
            }
        }
    }
}
