using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractGeometry2
{
	internal class IsoscelesTriangle : Triangle
	{
		double @base;
		double side;
		public double Base
		{
			get => @base;
			set => @base = FilterSize(value);
		}
		public double Side
		{
			get => side;
			set => side = FilterSize(value);
		}
		public IsoscelesTriangle(double @base, double side, int startX, int startY, int lineWidth, Color color) 
			:base(startX, startY,lineWidth, color)
		{
			Base = @base;
			Side = side;
		}
		public override double GetHeigth()
		{
			return Math.Sqrt(Math.Pow(Side,2) - Math.Pow(Base/2,2));
		}
		public override double GetArea()
		{
			return Base * GetHeigth()/2;
		}
		public override double GetPerimeter()
		{
			return 2 * side + Base;
		}
		public override void Draw(PaintEventArgs e)
		{
			Pen pen = new Pen(Color, LineWidth);
			Point[] vertices = new Point[]
			{
				new Point(StartX,StartY + (int)GetHeigth()),
				new Point(StartX + (int)Base, StartY + (int)GetHeigth()),
				new Point(StartX + (int)Base/2, StartY)
			};
			e.Graphics.DrawPolygon(pen, vertices);
		}
		public override void Info(PaintEventArgs e)
		{
			Console.WriteLine($"Основание: {Base}");
			Console.WriteLine($"Сторона: {Side}");
			base.Info(e);
		}
	}
}
