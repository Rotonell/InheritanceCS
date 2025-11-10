using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractGeometry2
{
	abstract class Triangle : Shape
	{
		public abstract double GetHeigth();

		public Triangle(int startX, int startY, int lineWidth, Color color):
			base(startX, startY, lineWidth, color){ }

		public override void Info(PaintEventArgs e)
		{
			Console.WriteLine($"Высота треугольника: {GetHeigth()}");
			base.Info(e);
		}
	}
}
