using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk2
{
	public class Desk
	{
		public int depth { get; set; }
		public int width { get; set; }
		public int numberOfDrawers { get; set; }
		public DeskMaterialTypes SurfaceMaterial { get; set; }
	}

	public enum DeskMaterialTypes
	{
		Oak = 0,
		Laminate = 1,
		Pine = 2,
		Rosewood = 3,
		Veneer = 4
	}
}

