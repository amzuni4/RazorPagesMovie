using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MegaDesk
{
   public class DeskQuote
    {
		public string CustomerName { get; set; }
		public DayLengths DayLengths { get; set; }
		public Desk Desk { get; set; }
		public DateTime Date { get; set; }
		public decimal QuotePrice { get; set; }

		private const decimal BASE_DESK_PRICE = 200.00M;
		private const decimal SURFACE_AREA_RATE = 1;
		private const decimal DRAWER_RATE = 50.00M;

		public decimal GetQuote()
		{
			decimal surfaceArea = Desk.depth * Desk.width;

			return GetDeskPrice(surfaceArea) + GetRushCost(surfaceArea);
		}

		private decimal GetDeskPrice(decimal surfaceArea)
		{
			decimal deskPrice = BASE_DESK_PRICE;
			deskPrice += surfaceArea * SURFACE_AREA_RATE;
			deskPrice += Desk.numberOfDrawers * DRAWER_RATE;
			deskPrice += GetMaterialPrice();

			return deskPrice;
		}

		private decimal GetMaterialPrice()
		{
			try
			{
				switch (Desk.SurfaceMaterial)
				{
					case DeskMaterialTypes.Oak:
						return 200.00M;
					case DeskMaterialTypes.Laminate:
						return 100.00M;
					case DeskMaterialTypes.Pine:
						return 50.00M;
					case DeskMaterialTypes.Rosewood:
						return 300.00M;
					case DeskMaterialTypes.Veneer:
						return 125.00M;
					default:
						throw new Exception("You need to select the type of material for your desk");
				}
			}
			catch (Exception e)
			{
				return 50.00M;
			}
		}

		private decimal GetRushCost(decimal surfaceArea)
		{
			if (surfaceArea < 1000)
			{
				switch (DayLengths)
				{
					case DayLengths.ThreeDay:
						return 60.00M;
					case DayLengths.FiveDay:
						return 40.00M;
					case DayLengths.SevenDay:
						return 30.00M;
					default:
						return 0;
				}
			}
			else if (surfaceArea >= 1000 && surfaceArea <= 2000)
			{
				switch (DayLengths)
				{
					case DayLengths.ThreeDay:
						return 70.00M;
					case DayLengths.FiveDay:
						return 50.00M;
					case DayLengths.SevenDay:
						return 35.00M;
					default:
						return 0;
				}
			}
			else
			{
				switch (DayLengths)
				{
					case DayLengths.ThreeDay:
						return 80.00M;
					case DayLengths.FiveDay:
						return 60.00M;
					case DayLengths.SevenDay:
						return 40.00M;
					default:
						return 0;
				}
			}
		}
	}
}