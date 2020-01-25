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
		

		public AddQuote()
		{
			InitializeComponent();
			nameRequiredErrorMessage.Text = string.Empty;
			materialSelect.DataSource = Enum.GetValues(typeof(DeskMaterialTypes));
			rushOrderSelect.DataSource = Enum.GetValues(typeof(DayLengths)).Cast<Enum>()
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

		

		private void GetQuoteButton_Click(object sender, EventArgs e)
		{
			if(string.IsNullOrWhiteSpace(fullNameInput.Text))
			{
				nameRequiredErrorMessage.Text = Resources.Required;
				return;
			}
			Desk desk = new Desk()
			{
				depth = (int)depthUpDown.Value,
				width = (int)widthUpDown.Value,
				numberOfDrawers = (int)numberOfDrawersUpDown.Value,
				SurfaceMaterial = (DeskMaterialTypes)materialSelect.SelectedItem
			
			};

			DeskQuote quote = new DeskQuote()
			{
				CustomerName = fullNameInput.Text,
				Desk = desk,
				DayLengths = (DayLengths)rushOrderSelect.SelectedValue,
				Date = DateTime.Now
			};

			quote.QuotePrice = quote.GetQuote();

			DisplayQuote displayQuote = new DisplayQuote(quote);
			displayQuote.ShowDialog();
		}

		private void AddQuote_Form_Click(object sender, EventArgs e)
		{
			MainMenu MainMenu = new MainMenu();
			MainMenu.Show();

		}

		private void widthUpDown_Validating(object sender, CancelEventArgs e)
		{
			ConfigurationValidatorBase validatorBase;
			IntegerValidatorAttribute intValAttr;
			intValAttr = new IntegerValidatorAttribute();

			long badValue = 97;
			int goodValue = 24;

			try
			{
				validatorBase = intValAttr.ValidatorInstance;
				validatorBase.Validate(goodValue);
			}
			catch (ArgumentException )
			{
				string msg = e.ToString();
#if DEBUG
				Console.WriteLine(msg);
#endif
			}
		}
	}
	}
