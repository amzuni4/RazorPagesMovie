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
		public RushOrderType RushOrderType { get; set; }
		public Desk Desk { get; set; }
		public DateTime Date { get; set; }
		public decimal QuotePrice { get; set; }

		private QuoteFileManager _quoteFileManager = new QuoteFileManager();
		private const decimal BASE_DESK_PRICE = 200.00M;
		private const decimal SURFACE_AREA_RATE = 1;
		private const decimal DRAWER_RATE = 50.00M;

		public decimal GetQuote()
		{
			decimal surfaceArea = Desk.depth * Desk.width;
			var test = GetRushOrderCost(surfaceArea);
			return GetDeskPrice(surfaceArea) + GetRushOrderCost(surfaceArea);
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
					case DesktopMaterial.Oak:
						return 200.00M;
					case DesktopMaterial.Laminate:
						return 100.00M;
					case DesktopMaterial.Pine:
						return 50.00M;
					case DesktopMaterial.Rosewood:
						return 300.00M;
					case DesktopMaterial.Veneer:
						return 125.00M;
					default:
						throw new Exception("No material selected.");
				}
			}
			catch (Exception e)
			{
				return 50.00M;
			}
		}

		private decimal GetRushOrderCost(decimal surfaceArea)
		{
			decimal[,] rushOrderPrices = _quoteFileManager.GetRushOrderPrices();

			if (surfaceArea < 1000)
			{
				switch (RushOrderType)
				{
					case RushOrderType.ThreeDay:
						return rushOrderPrices[0, 0];
					case RushOrderType.FiveDay:
						return rushOrderPrices[0, 1];
					case RushOrderType.SevenDay:
						return rushOrderPrices[0, 2];
					default:
						return 0;
				}
			}
			else if (surfaceArea >= 1000 && surfaceArea <= 2000)
			{
				switch (RushOrderType)
				{
					case RushOrderType.ThreeDay:
						return rushOrderPrices[1, 0];
					case RushOrderType.FiveDay:
						return rushOrderPrices[1, 1];
					case RushOrderType.SevenDay:
						return rushOrderPrices[1, 2];
					default:
						return 0;
				}
			}
			else
			{
				switch (RushOrderType)
				{
					case RushOrderType.ThreeDay:
						return rushOrderPrices[2, 0];
					case RushOrderType.FiveDay:
						return rushOrderPrices[2, 1];
					case RushOrderType.SevenDay:
						return rushOrderPrices[2, 2];
					default:
						return 0;
				}
			}
		}
	}
}