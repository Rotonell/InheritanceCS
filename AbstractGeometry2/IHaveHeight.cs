using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractGeometry2
{
	interface IHaveHeight
	{
		double GetHeigth();
		void DrawHeigth(System.Windows.Forms.PaintEventArgs e);
	}
}
