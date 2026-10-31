using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace SmartHomeIoT
{
    public enum SmartIconKind
    {
        None,
        Plug,
        Refresh,
        Thermometer,
        WaterDrop,
        AirConditioner,
        LightBulb,
        Firebase,
        Clock
    }

    public class RoundedPanel : Panel
    {
        public RoundedPanel()
        {
            BorderRadius = 8;
            BorderColor = Color.FromArgb(225, 225, 225);
            BorderThickness = 1;
            BackColor = Color.White;
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.UserPaint, true);
        }

        public int BorderRadius { get; set; }
        public Color BorderColor { get; set; }
        public int BorderThickness { get; set; }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            Rectangle rect = new Rectangle(0, 0, Width - 1, Height - 1);
            using (GraphicsPath path = DrawingHelper.CreateRoundRect(rect, BorderRadius))
            using (SolidBrush fillBrush = new SolidBrush(BackColor))
            using (Pen borderPen = new Pen(BorderColor, BorderThickness))
            {
                e.Graphics.FillPath(fillBrush, path);
                e.Graphics.DrawPath(borderPen, path);
            }
        }
    }

    public class GradientButton : Button
    {
        public GradientButton()
        {
            StartColor = Color.FromArgb(45, 178, 72);
            EndColor = Color.FromArgb(23, 145, 48);
            BorderColor = Color.FromArgb(21, 123, 42);
            IconKind = SmartIconKind.None;
            BorderRadius = 7;
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            ForeColor = Color.White;
            Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            Cursor = Cursors.Hand;
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.UserPaint, true);
        }

        public Color StartColor { get; set; }
        public Color EndColor { get; set; }
        public Color BorderColor { get; set; }
        public int BorderRadius { get; set; }
        public SmartIconKind IconKind { get; set; }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            Graphics g = pevent.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = new Rectangle(0, 0, Width - 1, Height - 1);
            Color start = StartColor;
            Color end = EndColor;

            if (MouseButtons == MouseButtons.Left && ClientRectangle.Contains(PointToClient(Cursor.Position)))
            {
                start = ControlPaint.Dark(StartColor);
                end = ControlPaint.Dark(EndColor);
            }

            using (GraphicsPath path = DrawingHelper.CreateRoundRect(rect, BorderRadius))
            using (LinearGradientBrush brush = new LinearGradientBrush(rect, start, end, LinearGradientMode.Vertical))
            using (Pen pen = new Pen(BorderColor))
            {
                g.FillPath(brush, path);
                g.DrawPath(pen, path);
            }

            if (IconKind != SmartIconKind.None)
            {
                Rectangle iconRect = new Rectangle(22, (Height - 26) / 2, 26, 26);
                SmartIconRenderer.Draw(g, IconKind, iconRect, Color.White);
            }

            TextRenderer.DrawText(
                g,
                Text,
                Font,
                ClientRectangle,
                ForeColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.SingleLine);
        }
    }

    public class SmartIconView : Control
    {
        public SmartIconView()
        {
            Kind = SmartIconKind.None;
            IconColor = Color.FromArgb(29, 132, 219);
            BackColor = Color.White;
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.UserPaint, true);
        }

        public SmartIconKind Kind { get; set; }
        public Color IconColor { get; set; }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            SmartIconRenderer.Draw(e.Graphics, Kind, ClientRectangle, IconColor);
        }
    }

    internal static class SmartIconRenderer
    {
        public static void Draw(Graphics g, SmartIconKind kind, Rectangle bounds, Color color)
        {
            Rectangle r = DrawingHelper.Pad(bounds, 3);

            switch (kind)
            {
                case SmartIconKind.Plug:
                    DrawPlug(g, r, color);
                    break;
                case SmartIconKind.Refresh:
                    DrawRefresh(g, r, color);
                    break;
                case SmartIconKind.Thermometer:
                    DrawThermometer(g, r, color);
                    break;
                case SmartIconKind.WaterDrop:
                    DrawWaterDrop(g, r, color);
                    break;
                case SmartIconKind.AirConditioner:
                    DrawAirConditioner(g, r);
                    break;
                case SmartIconKind.LightBulb:
                    DrawLightBulb(g, r);
                    break;
                case SmartIconKind.Firebase:
                    DrawFirebase(g, r);
                    break;
                case SmartIconKind.Clock:
                    DrawClock(g, r, color);
                    break;
            }
        }

        private static void DrawPlug(Graphics g, Rectangle r, Color color)
        {
            using (Pen pen = new Pen(color, Math.Max(2, r.Width / 11)))
            using (SolidBrush brush = new SolidBrush(color))
            {
                pen.StartCap = LineCap.Round;
                pen.EndCap = LineCap.Round;
                g.DrawLine(pen, r.Left + r.Width / 4, r.Bottom - r.Height / 4, r.Right - r.Width / 4, r.Top + r.Height / 4);
                g.FillRectangle(brush, r.Left + r.Width / 2, r.Top + r.Height / 4, r.Width / 4, r.Height / 4);
                g.DrawLine(pen, r.Left + r.Width / 2, r.Top + r.Height / 5, r.Left + r.Width / 2, r.Top);
                g.DrawLine(pen, r.Left + r.Width * 3 / 4, r.Top + r.Height / 5, r.Left + r.Width * 3 / 4, r.Top);
            }
        }

        private static void DrawRefresh(Graphics g, Rectangle r, Color color)
        {
            using (Pen pen = new Pen(color, Math.Max(2, r.Width / 9)))
            using (SolidBrush brush = new SolidBrush(color))
            {
                pen.StartCap = LineCap.Round;
                pen.EndCap = LineCap.Round;
                g.DrawArc(pen, r.Left + 2, r.Top + 2, r.Width - 4, r.Height - 4, 35, 285);
                Point[] arrow =
                {
                    new Point(r.Right - r.Width / 6, r.Top + r.Height / 4),
                    new Point(r.Right - r.Width / 2, r.Top + r.Height / 4),
                    new Point(r.Right - r.Width / 4, r.Top)
                };
                g.FillPolygon(brush, arrow);
            }
        }

        private static void DrawThermometer(Graphics g, Rectangle r, Color color)
        {
            int tubeWidth = Math.Max(12, r.Width / 5);
            Rectangle tube = new Rectangle(r.Left + (r.Width - tubeWidth) / 2, r.Top + 8, tubeWidth, r.Height - r.Width / 3 - 12);
            Rectangle bulb = new Rectangle(r.Left + r.Width / 4, r.Bottom - r.Width / 2, r.Width / 2, r.Width / 2);

            using (Pen pen = new Pen(color, 4))
            using (SolidBrush light = new SolidBrush(Color.FromArgb(228, 243, 255)))
            using (SolidBrush fill = new SolidBrush(color))
            {
                g.FillEllipse(light, bulb);
                g.DrawEllipse(pen, bulb);
                g.DrawRectangle(pen, tube);
                g.FillEllipse(fill, DrawingHelper.Pad(bulb, bulb.Width / 4));
                g.FillRectangle(fill, tube.Left + tube.Width / 3, tube.Top + tube.Height / 3, tube.Width / 3, tube.Height);
            }
        }

        private static void DrawWaterDrop(Graphics g, Rectangle r, Color color)
        {
            using (GraphicsPath path = new GraphicsPath())
            using (Pen pen = new Pen(color, 4))
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(232, 246, 255)))
            using (SolidBrush dot = new SolidBrush(color))
            {
                path.AddBezier(
                    r.Left + r.Width / 2, r.Top,
                    r.Left + r.Width / 10, r.Top + r.Height / 2,
                    r.Left + r.Width / 8, r.Bottom,
                    r.Left + r.Width / 2, r.Bottom);
                path.AddBezier(
                    r.Left + r.Width / 2, r.Bottom,
                    r.Right - r.Width / 8, r.Bottom,
                    r.Right - r.Width / 10, r.Top + r.Height / 2,
                    r.Left + r.Width / 2, r.Top);
                g.FillPath(brush, path);
                g.DrawPath(pen, path);
                g.FillEllipse(dot, r.Left + r.Width / 2, r.Top + r.Height * 3 / 5, r.Width / 5, r.Width / 5);
            }
        }

        private static void DrawAirConditioner(Graphics g, Rectangle r)
        {
            Rectangle unit = new Rectangle(r.Left + 8, r.Top + 8, r.Width - 16, r.Height / 2);
            Rectangle vent = new Rectangle(unit.Left + 12, unit.Bottom - unit.Height / 4, unit.Width - 24, unit.Height / 7);

            using (LinearGradientBrush unitBrush = new LinearGradientBrush(unit, Color.White, Color.FromArgb(218, 218, 218), LinearGradientMode.Vertical))
            using (GraphicsPath unitPath = DrawingHelper.CreateRoundRect(unit, 10))
            using (Pen border = new Pen(Color.FromArgb(160, 160, 160), 2))
            using (Pen ventPen = new Pen(Color.FromArgb(65, 65, 65), 3))
            using (Pen airPen = new Pen(Color.FromArgb(182, 229, 247), 4))
            {
                g.FillPath(unitBrush, unitPath);
                g.DrawPath(border, unitPath);
                g.DrawRectangle(ventPen, vent);

                for (int i = 0; i < 5; i++)
                {
                    int x = unit.Left + 45 + i * 27;
                    g.DrawBezier(airPen, x, unit.Bottom + 8, x - 2, unit.Bottom + 25, x - 12, unit.Bottom + 38, x - 18, unit.Bottom + 55);
                }
            }
        }

        private static void DrawLightBulb(Graphics g, Rectangle r)
        {
            int bulbSize = Math.Min(r.Width, r.Height * 2 / 3);
            Rectangle bulb = new Rectangle(r.Left + (r.Width - bulbSize) / 2, r.Top + r.Height / 8, bulbSize, bulbSize);
            Rectangle baseRect = new Rectangle(bulb.Left + bulb.Width / 3, bulb.Bottom - 2, bulb.Width / 3, r.Height / 5);

            using (LinearGradientBrush bulbBrush = new LinearGradientBrush(bulb, Color.FromArgb(255, 245, 115), Color.FromArgb(255, 185, 35), LinearGradientMode.ForwardDiagonal))
            using (Pen yellowPen = new Pen(Color.FromArgb(250, 210, 38), 4))
            using (Pen rayPen = new Pen(Color.FromArgb(255, 214, 43), 3))
            using (SolidBrush baseBrush = new SolidBrush(Color.FromArgb(95, 95, 95)))
            using (Pen basePen = new Pen(Color.FromArgb(70, 70, 70), 2))
            {
                g.FillEllipse(bulbBrush, bulb);
                g.DrawEllipse(yellowPen, bulb);

                g.DrawLine(rayPen, bulb.Left - 10, bulb.Top + bulb.Height / 2, bulb.Left - 28, bulb.Top + bulb.Height / 2);
                g.DrawLine(rayPen, bulb.Right + 10, bulb.Top + bulb.Height / 2, bulb.Right + 28, bulb.Top + bulb.Height / 2);
                g.DrawLine(rayPen, bulb.Left + bulb.Width / 2, bulb.Top - 10, bulb.Left + bulb.Width / 2, bulb.Top - 28);
                g.DrawLine(rayPen, bulb.Left + 10, bulb.Top + 10, bulb.Left - 8, bulb.Top - 8);
                g.DrawLine(rayPen, bulb.Right - 10, bulb.Top + 10, bulb.Right + 8, bulb.Top - 8);

                g.FillRectangle(baseBrush, baseRect);
                g.DrawRectangle(basePen, baseRect);
                g.DrawLine(basePen, baseRect.Left - 2, baseRect.Top + 6, baseRect.Right + 2, baseRect.Top + 6);
                g.DrawLine(basePen, baseRect.Left - 2, baseRect.Top + 13, baseRect.Right + 2, baseRect.Top + 13);
            }
        }

        private static void DrawFirebase(Graphics g, Rectangle r)
        {
            Point[] left =
            {
                new Point(r.Left + r.Width / 6, r.Bottom),
                new Point(r.Left + r.Width / 2, r.Top + r.Height / 8),
                new Point(r.Left + r.Width / 2, r.Bottom)
            };
            Point[] center =
            {
                new Point(r.Left + r.Width / 3, r.Bottom),
                new Point(r.Left + r.Width * 2 / 3, r.Top + r.Height / 5),
                new Point(r.Right - r.Width / 8, r.Bottom)
            };
            Point[] right =
            {
                new Point(r.Left + r.Width / 2, r.Bottom),
                new Point(r.Right - r.Width / 4, r.Top + r.Height / 3),
                new Point(r.Right - r.Width / 12, r.Bottom)
            };

            using (SolidBrush orange = new SolidBrush(Color.FromArgb(255, 152, 0)))
            using (SolidBrush amber = new SolidBrush(Color.FromArgb(255, 193, 7)))
            using (SolidBrush yellow = new SolidBrush(Color.FromArgb(255, 213, 79)))
            {
                g.FillPolygon(orange, left);
                g.FillPolygon(amber, center);
                g.FillPolygon(yellow, right);
            }
        }

        private static void DrawClock(Graphics g, Rectangle r, Color color)
        {
            using (Pen pen = new Pen(color, 3))
            using (Pen handPen = new Pen(color, 3))
            {
                g.DrawEllipse(pen, r);
                Point center = new Point(r.Left + r.Width / 2, r.Top + r.Height / 2);
                g.DrawLine(handPen, center, new Point(center.X, r.Top + r.Height / 4));
                g.DrawLine(handPen, center, new Point(r.Right - r.Width / 4, center.Y + r.Height / 5));
            }
        }
    }

    internal static class DrawingHelper
    {
        public static GraphicsPath CreateRoundRect(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int d = Math.Max(1, radius * 2);

            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
            path.CloseFigure();

            return path;
        }

        public static Rectangle Pad(Rectangle rect, int padding)
        {
            return new Rectangle(rect.Left + padding, rect.Top + padding, Math.Max(1, rect.Width - padding * 2), Math.Max(1, rect.Height - padding * 2));
        }
    }
}
