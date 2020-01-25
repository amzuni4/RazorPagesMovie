using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MegaDesk
{
    class QuoteFileManager
	{
		private const string QUOTE_PATH =
			@"C:\users\admin\source\repos\CIT365_W20_ZunigaAmy\MegaDesk\data\quotes.json";
		
		private const string RUSH_ORDER_PATH =
			@"C:\users\admin\source\repos\CIT365_W20_ZunigaAmy\MegaDesk\data\rushOrderPrices.txt";
		

		private const string EXCEPTION_LOG_PATH =
			
		@"C:\users\admin\source\repos\CIT365_W20_ZunigaAmy\MegaDesk\data\ExceptionLog.txt";

		private const int NUMBER_OF_SIZE_TIERS = 3;
		private const int NUMBER_OF_RUSH_TIERS = 3;

		/// <summary>
		/// Gets a list of all saved quotes
		/// </summary>
		public List<DeskQuote> GetSavedQuotes()
		{
			List<DeskQuote> quotes = new List<DeskQuote>();

			using (StreamReader quoteReader = new StreamReader(QUOTE_PATH))
			{
				quotes.AddRange(JsonConvert.DeserializeObject<List<DeskQuote>>(quoteReader.ReadToEnd()));
			}

			return quotes;
		}

		/// <summary>
		/// Saves a list of DeskQuotes to the quotes.json file.
		/// </summary>
		/// <param name="quotes">The lis of DeskQuotes that will be saved</param>
		public void SaveQuotes(List<DeskQuote> quotes)
		{
			using (StreamWriter file = File.CreateText(QUOTE_PATH))
			{
				var serializer = new JsonSerializer();

				serializer.Serialize(file, quotes);
			}
		}

		public decimal[,] GetRushOrderPrices()
		{
			decimal[,] rushOrderPrices = new decimal[NUMBER_OF_SIZE_TIERS, NUMBER_OF_RUSH_TIERS];

			using (StreamReader rushReader = new StreamReader(RUSH_ORDER_PATH))
			{
				try
				{
					for (int i = 0; i < NUMBER_OF_SIZE_TIERS; i++)
					{
						for (int j = 0; j < NUMBER_OF_RUSH_TIERS; j++)
						{
							if (!decimal.TryParse(
								rushReader.ReadLine(),
								NumberStyles.Any,
								new CultureInfo("en"),
								out rushOrderPrices[i, j]))
							{
								throw new Exception("Failed to parse RushOrderPrices.txt in GetRushOrderPrices()");
							}
						}
					}
				}
				catch (Exception ex)
				{
					LogException(ex);
				}
			}

			return rushOrderPrices;
		}

		public void LogException(Exception ex)
		{
			using (StreamWriter exceptionWriter = new StreamWriter(EXCEPTION_LOG_PATH))
			{
				exceptionWriter.WriteLine(ex.Message);
			}
		}
	}
}