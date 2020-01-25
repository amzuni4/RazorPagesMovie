using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace MegaDesk
{ 
	public enum ProductionType
	{
		[Description("14-Day (Normal)")]
		FourteenDay = 0,
		[Description("3-Day")]
		ThreeDay = 1,
		[Description("5-Day")]
		FiveDay = 2,
		[Description("7-Day")]
		SevenDay = 3
	}
}
