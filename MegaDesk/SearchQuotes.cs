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
	public partial class SearchQuotes : Form
	{
		private static readonly QuoteFileManager _quoteFileManager = new QuoteFileManager();

		public SearchQuotes()
		{
			InitializeComponent();
			surfaceMaterialComboBox.DataSource = Enum.GetValues(typeof(DesktopMaterial));
			surfaceMaterialComboBox.SelectedIndex = -1;
			searchQuotesGridView.DataSource = _quoteFileManager.GetSavedQuotes()
			.Select(p => new
			{
				p.CustomerName,
				p.Desk.depth,
				p.Desk.width,
				p.Desk.numberOfDrawers,
				p.Desk.SurfaceMaterial,
				p.RushOrderType,
				Date = p.Date.ToShortDateString(),
				Price = p.QuotePrice.ToString("C")
			})
			.OrderByDescending(p => p.Date).ToList();
		}

	

		private void SurfaceMaterialComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (surfaceMaterialComboBox.SelectedIndex > -1)
			{
				DesktopMaterial selectedMaterial = (DesktopMaterial)surfaceMaterialComboBox.SelectedValue;
				searchQuotesGridView.DataSource = _quoteFileManager.GetSavedQuotes()
					.Select(p => new
					{
						p.CustomerName,
						p.Desk.depth,
						p.Desk.width,
						p.Desk.numberOfDrawers,
						p.Desk.SurfaceMaterial,
						p.RushOrderType,
						Date = p.Date.ToShortDateString(),
						Price = p.QuotePrice.ToString("C")
					}).ToList()
					.Where(p => p.SurfaceMaterial == selectedMaterial)
					.OrderByDescending(p => p.Date).ToList();
			}
		}

		private void MainMenuReturn_Click(object sender, EventArgs e)
		{
			MainMenu mainMenu = new MainMenu();
			mainMenu.Show();
		}
	}
}