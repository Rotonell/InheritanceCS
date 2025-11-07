using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractGeometry
{
	 class Rectangle : Shape
	{
		protected double width, heigth;

		public Rectangle(double width, double heigth, int start_x, int start_y, int line_width, ConsoleColor color)
			:base(start_x, start_y, line_width, color)
		{
			set_width(width);
			set_heigth(heigth);
		}

		public double get_width() { return width; }
		public double get_height() { return heigth; }

		public void set_width(double width)
		{
			this.width = filter_size((int)width);
		}
		public void set_heigth(double heigth)
		{
			this.heigth = filter_size((int)heigth);
		}
		public override double get_area()
		{
			return width * heigth;
		}

		public override double get_perimeter()
		{
			return 2 * (width + heigth);
		}

		public override void draw()
		{
			Console.ForegroundColor = color;

			int originalLeft = Console.CursorLeft;
			int originalTop = Console.CursorTop;

			for (int i = 0; i < heigth; i++)
			{
				Console.SetCursorPosition(start_x, start_y + i);
				for (int j = 0; j < width; j++)
				{
					Console.Write("* ");
				}
			}

			Console.SetCursorPosition(originalLeft, originalTop + (int)heigth + 2);
			Console.ResetColor();
		}

		public override void info()
		{
			base.info();
		}
	}
}
