using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Text;

namespace WinFormsApp1_Pogoda;

internal class DataPanel : Panel
{
    private Color panelColor = Color.FromArgb(100, 255, 255, 255);
    private int borderRadius = 30;
    private Color borderColor = Color.Transparent;
    private int borderSize = 0;

    [Category("Custom Properties")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public int BorderRadius
    {
        get => borderRadius;
        set { borderRadius = value; this.Invalidate(); }
    }

    [Category("Custom Properties")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public Color BorderColor
    {
        get => borderColor;
        set { borderColor = value; this.Invalidate(); }
    }

    [Category("Custom Properties")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public int BorderSize
    {
        get => borderSize;
        set { borderSize = value; this.Invalidate(); }
    }

    [Category("Custom Properties")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public Color PanelColor
    {
        get => panelColor;
        set { panelColor = value; this.Invalidate(); }
    }

    public DataPanel()
    {
        this.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.DoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
        this.BackColor = Color.Transparent;
    }

    private GraphicsPath GetRoundedPath(Rectangle rect, float radius)
    {
        GraphicsPath path = new GraphicsPath();
        float m = 0.5f;

        path.StartFigure();
        path.AddArc(rect.X + m, rect.Y + m, radius, radius, 180, 90);
        path.AddArc(rect.Width - radius - m, rect.Y + m, radius, radius, 270, 90);
        path.AddArc(rect.Width - radius - m, rect.Height - radius - m, radius, radius, 0, 90);
        path.AddArc(rect.X + m, rect.Height - radius - m, radius, radius, 90, 90);
        path.CloseAllFigures();

        return path;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        Graphics graphics = e.Graphics;
        graphics.SmoothingMode = SmoothingMode.AntiAlias;

        Rectangle rectSurface = this.ClientRectangle;
        Rectangle rectBorder = Rectangle.Inflate(rectSurface, -borderSize, -borderSize);

        int smoothSize = 2;
        if (borderSize > 0) smoothSize = borderSize;

        if (borderRadius > 2)
        {
            using (GraphicsPath pathSurface = GetRoundedPath(rectSurface, borderRadius))
            using (GraphicsPath pathBorder = GetRoundedPath(rectBorder, borderRadius - borderSize))
            using (SolidBrush fillBrush = new SolidBrush(panelColor))
            {
                graphics.FillPath(fillBrush, pathSurface);

                if (borderSize >= 1)
                {
                    using (Pen penBorder = new Pen(borderColor, borderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        graphics.DrawPath(penBorder, pathSurface);
                    }
                }
            }
        }
        else
        {
            using (SolidBrush fillBrush = new SolidBrush(Color.FromArgb(180, 255, 255, 255)))
            {
                graphics.FillRectangle(fillBrush, rectSurface);
            }
        }
    }
}
