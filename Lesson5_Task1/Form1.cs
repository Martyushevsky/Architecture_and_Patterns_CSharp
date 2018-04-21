using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Lesson5_Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Random r = new Random();

            for (int i = 0; i < 50_000; i++)
            {
                DrawShape ellipse = ShapeFactory.GetShape("Ellipse");
                ellipse.Draw(new Point(r.Next(Width / 2), r.Next(Height / 2)), new Point(r.Next(Width / 2), r.Next(Height / 2)));
            }

            //for (int i = 0; i < 50_000; i++)
            //{
            //    Pen pen = Pens.Black;
            //    Graphics g = CreateGraphics();
            //    g.DrawEllipse(pen, r.Next(Width / 2), r.Next(Height / 2), r.Next(Width / 2), r.Next(Height / 2));
            //}
        }
    }

    public abstract class DrawShape
    {
        public Pen pen = Pens.Black;
        public Graphics graphics = Form.ActiveForm.CreateGraphics();

        public abstract void Draw(Point originPoint, Point dimensions);
    }

    class DrawEllipse : DrawShape
    {
        public override void Draw(Point originPoint, Point dimensions)
        {
            graphics.DrawEllipse(pen, originPoint.X, originPoint.Y, dimensions.X, dimensions.Y);
        }
    }

    class DrawRectangle : DrawShape
    {
        public override void Draw(Point originPoint, Point dimensions)
        {
            graphics.DrawRectangle(pen, originPoint.X, originPoint.Y, dimensions.X, dimensions.Y);
        }
    }

    public class ShapeFactory
    {
        static Dictionary<string, DrawShape> shapes = new Dictionary<string, DrawShape>();

        public static DrawShape GetShape(string shapeType)
        {
            switch (shapeType)
            {
                case "Ellipse":
                    if (!shapes.ContainsKey("Ellipse"))
                        shapes["Ellipse"] = new DrawEllipse();
                    return shapes["Ellipse"];
                case "Rectangle":
                    if (!shapes.ContainsKey("Rectangle"))
                        shapes["Rectangle"] = new DrawRectangle();
                    return shapes["Rectangle"];
                default:
                    break;
            }
            return null;
        }
    }
}