using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AbstractGeometry2
{
	internal class Rectangle : Shape
	{
		double width;
		double height;

		public double Width
		{
			get => width;
			set => width = FilterSize(value);
		}
		public double Height
		{
			get => height;
			set => height = FilterSize(value);
		}

		public Rectangle
			(
			double width, double height,
			int startX, int startY, int lineWidth, Color color
			) :base(startX, startY, lineWidth, color )
		{
			Width = width;
			Height = height;
		}
		public override double GetArea() => Width * Height;
		public override double GetPerimeter() => 2 * (Height + Width);
		public override void Draw(System.Windows.Forms.PaintEventArgs e)
		{
			Pen pen = new Pen(Color, LineWidth);
			SolidBrush brush = new SolidBrush(Color);
			e.Graphics.DrawRectangle(pen, StartX, StartY, (float)Width, (float)Height);
			e.Graphics.FillRectangle(brush, StartX,StartY,(float)Width, (float)Height);

		}

		public override void Info(System.Windows.Forms.PaintEventArgs e)
		{
			Console.WriteLine(this.GetType().ToString().Split('.').Last()+":");
			Console.WriteLine($"Ширина:{Width}");
			Console.WriteLine($"В ысота:{Height}");
			base.Info(e);
		}
		
	}
}
