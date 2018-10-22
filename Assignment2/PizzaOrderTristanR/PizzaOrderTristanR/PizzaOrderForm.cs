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
			double costOfSize, costOfToppings, costOfDrinks, costOfFries, discountPrice, subtotal,total,HST, studentDiscount , tax , numberOfDrinks,numberOfPizzas , numberOfToppings;

			numberOfDrinks = (double)(nudDrinks.Value);
			numberOfToppings = (double)(nudToppings.Value);
			numberOfPizzas = (double)(nudToppings.Value);

			costOfDrinks = numberOfDrinks * 2;
			if (numberOfToppings == 0)
			{ costOfToppings = 0;
			}
			else if (numberOfToppings == 1)
			{ costOfToppings = 0.75;
			}
			else if (numberOfToppings == 2)
			{
				costOfToppings = 1.35;
			}
			else if (numberOfToppings == 3)
			{
				costOfToppings = 2.15;
			}
			else if (numberOfToppings == 4)
			{
				costOfToppings = 2.75;
			}
			

			if (this.radL.Checked == true )
			{
				costOfSize = 10.00;  
			}
			else if (this.radXL.Checked == true )
			{
				costOfSize = 13.00;
			}
			else
			{
				lblError1.Text = "Enter a valid size";
			}
			if (this.radYesStudent.Checked == true)
			{ discountPrice = total - studentDiscount;
			}
			else
			{ lblStudentPriceAnswer.Text = "n/a";
			}
			if (this.radQuebec.Checked == true)
			{
				tax = 0.15;
			}
			else if (this.radOntario.Checked == true)
			{
				tax = 0.13;
			}
			else
			{
				lblError2.Text = "Please enter your province";
			}
			costOfDrinks =

			subtotal = (costOfSize + costOfToppings) * nudNumberOfPizzas + costOfDrinks + costOfFries;
			studentDiscount = total * 0.25;



		}

		private void PizzaOrderForm_Load(object sender, EventArgs e)
		{

		}

		private void nudDrinks_ValueChanged(object sender, EventArgs e)
		{

		}
	}
}
