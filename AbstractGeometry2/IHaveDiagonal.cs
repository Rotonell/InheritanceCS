using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AbstractGeometry2
{
	interface IHaveDiagonal
	{
		double GetDiagonal();
		void DrawDiagonal(System.Windows.Forms.PaintEventArgs e);
	}
}
