using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaOrderTristanR
{
	public partial class PizzaOrderForm : Form
	{
		public PizzaOrderForm()
		{
			InitializeComponent();
		}

		private void btnCalculate_Click(object sender, EventArgs e)
		{
			double tax,costOfSize,costOfToppings,numberOfToppings, costOfDrinks, costOfFries, discountPrice, subtotal,total,HST, studentDiscount , numberOfDrinks,numberOfPizzas , numberOfFries;
			const Double ONE_TOPPING = 0.75;
			const Double TWO_TOPPINGS = 1.35;
			const Double THREE_TOPPINGS = 2.15;
			const Double FOUR_TOPPINGS = 2.75;
			const Double LARGE = 10.00;
			const Double EXTRA_LARGE = 13.00;
			const Double QUEBEC = 0.15;
			const Double ONTARIO = 0.13;



			numberOfDrinks = (double)(nudDrinks.Value);
			numberOfToppings = (double)(nudToppings.Value);
			numberOfPizzas = (double)(nudToppings.Value);
			numberOfFries = (double)(nudFries.Value);
			costOfDrinks = numberOfDrinks * 2;
			costOfFries = numberOfFries * 3;
			costOfToppings = 0;
			tax = 0;
			costOfSize = 0;


			if (numberOfToppings == 0)
			{
				
				costOfToppings = costOfToppings + 0;
			}
			else if (numberOfToppings == 1)
			{ costOfToppings = costOfToppings + ONE_TOPPING;
			}
			else if (numberOfToppings == 2)
			{
				costOfToppings = costOfToppings + TWO_TOPPINGS;
			}
			else if (numberOfToppings == 3)
			{
				costOfToppings = costOfToppings + THREE_TOPPINGS;
			}
			else if (numberOfToppings == 4)
			{
				costOfToppings = costOfToppings + FOUR_TOPPINGS;
			}
			
			
			if (this.radL.Checked == true )
			{
				costOfSize = costOfSize + LARGE;
				lblError1.Text = "--";

			}
			else if (this.radXL.Checked == true )
			{
				costOfSize = costOfSize + EXTRA_LARGE;
				lblError1.Text = "--";

			}
			else
			{
				lblError1.Text = "Enter a valid size";
			}
		
			if (this.radQuebec.Checked == true)
			{
				tax = tax + QUEBEC;
				lblError2.Text = "--";

			}
			else if (this.radOntario.Checked == true)
			{
				tax = tax + ONTARIO;
				lblError2.Text = "--";

			}
			else
			{
				lblError2.Text = "Please enter your province";
			}
			costOfDrinks = 2 * numberOfDrinks;
			
		


			subtotal = costOfSize + costOfToppings * numberOfPizzas + costOfDrinks + costOfFries;
			lblSubtotalAnswer.Text = String.Format("${0:0.00}", subtotal);
			HST = subtotal * tax;
			lblHSTAnswer.Text = String.Format("${0:0.00}", HST);
			total = subtotal + HST;
			lblTotalAnswer.Text = String.Format("${0:0.00}", total);
			studentDiscount = total * 0.25;
			discountPrice = total - studentDiscount;

			if (this.radYesStudent.Checked == true)
			{
				lblStudentPriceAnswer.Text = String.Format("${0:0.00}", discountPrice);
				lblError3.Text = "--";
			}
			else if (this.radNoStudent.Checked == true)
			{
				lblStudentPriceAnswer.Text = "n/a";
				lblError3.Text = "--";

			}
			else
			{ lblError3.Text = "Please state whether you are a student or not";
			}



		}

		private void PizzaOrderForm_Load(object sender, EventArgs e)
		{

		}

		private void nudDrinks_ValueChanged(object sender, EventArgs e)
		{

		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
