using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractGeometry2
{
	internal class Circle : Shape, IHaveDiameter
	{
		double radius;
		public double Radius
		{
			get => radius;
			set => radius = FilterSize(value);
		}

		public Circle(double radius, int startX, int startY, int lineWidth, Color color) :
			base(startX, startY, lineWidth, color)
		{
			Radius = radius;
		}
		public override double GetArea() => Math.PI * Math.Pow(Radius, 2);
		public override double GetPerimeter() => 2 * Math.PI * Radius;

		public double GetDiameter() => 2 * Radius;
		
		public override void Draw(PaintEventArgs e)
		{
			Pen pen = new Pen(Color, LineWidth);
			e.Graphics.DrawEllipse(pen, StartX, StartY, (float)(2*Radius), (float)(2*Radius));
		}
		public void DrawDiameter(System.Windows.Forms.PaintEventArgs e)
		{
			Pen pen = new Pen(Color.White, 2);

			e.Graphics.DrawLine(pen,
				StartX,                            
				StartY + (float)Radius,            
				StartX + (float)GetDiameter(),          
				StartY + (float)Radius);         
		}
		public override void Info(PaintEventArgs e)
		{
			Console.WriteLine($"{this.GetType()}");
			Console.WriteLine($"Radius:\t{Radius}");
			base.Info(e);
			DrawDiameter(e);
		}
	}
}
