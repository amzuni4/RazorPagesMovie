using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk
{
	public class Desk
	{
		public int depth { get; set; }
		public int width { get; set; }
		public int numberOfDrawers { get; set; }
		public DesktopMaterial SurfaceMaterial { get; set; }
	}

	public enum DesktopMaterial
	{
		Oak = 0,
		Laminate = 1,
		Pine = 2,
		Rosewood = 3,
		Veneer = 4
	}
}