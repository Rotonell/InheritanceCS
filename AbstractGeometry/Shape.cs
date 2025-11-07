using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AbstractGeometry
{
	public abstract class Shape
	{
		protected ConsoleColor color;
		protected int line_width;
		protected int start_x;
		protected int start_y;

		public const int MIN_START_X = 1;
		public const int MIN_START_Y = 1;
		public const int MAX_START_X = 50;
		public const int MAX_START_Y = 20;
		public const int MIN_LINE_WIDTH = 1;
		public const int MAX_LINE_WIDTH = 16;
		public const int MIN_SIZE = 3;
		public const int MAX_SIZE = 20;

		protected Shape(int start_x, int start_y, int line_width, ConsoleColor color)
		{
			this.color = color;
			set_start_x(start_x);
			set_start_y(start_y);
			set_line_width(line_width);
		}
		public void set_start_x(int start_x)
		{
			this.start_x =
				start_x<MIN_START_X ? MIN_START_X :
				start_x>MAX_START_X ? MAX_START_X :
				start_x;
		}
		public void set_start_y(int start_y)
		{
			this.start_y =
				start_y<MIN_START_Y ? MIN_START_Y :
				start_y>MAX_START_Y ? MAX_START_Y :
				start_y;
		}
		public void set_line_width(int line_width)
		{
			this.line_width =
				line_width < MIN_LINE_WIDTH ? MIN_LINE_WIDTH :
				line_width > MAX_LINE_WIDTH ? MAX_LINE_WIDTH :
				line_width;
		}
		protected int filter_size(int size)
		{
			return
				size < MIN_SIZE ? MIN_SIZE :
				size > MAX_SIZE ? MAX_SIZE :
				size;
		}
		public int get_start_x() { return start_x; }
		public int get_start_y() { return start_y; }
		public int get_line_width() { return line_width; }
		public ConsoleColor GetColor() { return color; }

		public abstract double get_area();
		public abstract double get_perimeter();
		public abstract void draw();
		public virtual void info()
		{
			Console.WriteLine($"Площадь фигуры: {get_area()}");
			Console.WriteLine($"Периметр фигуры: {get_perimeter()}");
			draw();
		}

}
}
