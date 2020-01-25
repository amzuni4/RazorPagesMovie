using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk
{
	public partial class ViewAllQuotes : Form
	{
		private readonly QuoteFileManager _quoteFileManager = new QuoteFileManager();
		public ViewAllQuotes()
		{
			InitializeComponent();
			allQuotesGridView.DataSource = _quoteFileManager.GetSavedQuotes()
				.Select(p =>
				new {
					p.CustomerName,
					p.Desk.depth,
					p.Desk.width,
					p.Desk.numberOfDrawers,
					p.Desk.SurfaceMaterial,
					p.RushOrderType,
					Date = p.Date.ToShortDateString(),
					Price = p.QuotePrice.ToString("C")
				}).OrderByDescending(p => p.Date).ToList();
		}

	
		private void backToMain_Click(object sender, EventArgs e)
		{
			MainMenu mainMenu = new MainMenu();
			mainMenu.Show();
		}
	}
}
