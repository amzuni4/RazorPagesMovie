using MegaDesk.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
namespace MegaDesk
{
	public partial class AddQuote : Form
	{
		private readonly QuoteFileManager _quoteFileManager = new QuoteFileManager();
		private const string QUOTE_PATH =
			@"C:\admin\source\repos\CIT365_W20_AmyZuniga\MegaDesk\Data\quotes.json";

		public AddQuote()
		{
			InitializeComponent();
			nameRequiredErrorMessage.Text = string.Empty;
			materialSelect.DataSource = Enum.GetValues(typeof(DesktopMaterial));
			rushOrderSelect.DataSource = Enum.GetValues(typeof(RushOrderType)).Cast<Enum>()
				.Select(p => new
				{
					Description = (Attribute.GetCustomAttribute(p.GetType().GetField(p.ToString()), typeof(DescriptionAttribute)) as DescriptionAttribute)?.Description
								 ?? p.ToString(),
					Value = p
				}).ToList();
			rushOrderSelect.DisplayMember = "Description";
			rushOrderSelect.ValueMember = "Value";
			dateLabel.Text = DateTime.Today.ToShortDateString();
		}

		

		private void SaveQuoteButton_Click(object sender, EventArgs e)
		{
			List<DeskQuote> quotes = _quoteFileManager.GetSavedQuotes();

			if (string.IsNullOrWhiteSpace(fullNameInput.Text))
			{
				nameRequiredErrorMessage.Text = Resources.Required;
				return;
			}

			Desk desk = new Desk()
			{
				depth = (int)depthUpDown.Value,
				width = (int)widthUpDown.Value,
				numberOfDrawers = (int)numberOfDrawersUpDown.Value,
				SurfaceMaterial = (DesktopMaterial)materialSelect.SelectedItem
			};

			DeskQuote quote = new DeskQuote()
			{
				CustomerName = fullNameInput.Text,
				Desk = desk,
				RushOrderType = (RushOrderType)rushOrderSelect.SelectedValue,
				Date = DateTime.Now
			};

			quote.QuotePrice = quote.GetQuote();

			quotes.Add(quote);

			_quoteFileManager.SaveQuotes(quotes);

			DisplayQuote displayQuote = new DisplayQuote(quote);
			displayQuote.ShowDialog();
		}

		private void BackToMain_Click(object sender, EventArgs e)
		{
			MainMenu mainMenu = new MainMenu();
			mainMenu.Show();
		}
	}
}