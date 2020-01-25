using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk2
{
	public partial class MainMenu : Form
	{
		public MainMenu()
		{
			InitializeComponent();
		}

		private void AddNewQuoteButton_Click(object sender, EventArgs e)
		{
			AddQuote addQuote = new AddQuote();
			addQuote.Show();
			Hide();
		}

		private void ViewQuotesButton_Click(object sender, EventArgs e)
		{
			ViewAllQuotes viewAllQuotes = new ViewAllQuotes();
			viewAllQuotes.Show();
			Hide();
		}

		private void SearchQuotesButton_Click(object sender, EventArgs e)
		{
			SearchQuotes searchQuotes = new SearchQuotes();
			searchQuotes.Show();
			Hide();
		}

		private void ExitButton_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}