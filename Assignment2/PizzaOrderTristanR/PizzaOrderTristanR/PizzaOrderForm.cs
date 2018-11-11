/*
* Created by: Tristan Royer
* Created on: 19-10-18
* Created for: ICS3U Programming
* Assignment #5b - Pizza Order
* This program calculates an order for the user.
*/
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
			// Hides the student discount price label
			lblStudentPriceAnswer.Hide();

		}

		private void btnCalculate_Click(object sender, EventArgs e)
		{
			// declare all the variables
			double tax,costOfSize,costOfToppings, costOfPizza, numberOfToppings, costOfDrinks, costOfFries, discountPrice, subtotal,total,HST, 
			studentDiscount , numberOfDrinks,numberOfPizzas , numberOfFries;
			const Double ONE_TOPPING = 0.75;
			const Double TWO_TOPPINGS = 1.35;
			const Double THREE_TOPPINGS = 2.15;
			const Double FOUR_TOPPINGS = 2.75;
			const Double LARGE = 10.00;
			const Double EXTRA_LARGE = 13.00;
			const Double QUEBEC = 0.15;
			const Double ONTARIO = 0.13;


			// assign values to variables 
			numberOfDrinks = (double)(nudDrinks.Value);
			numberOfToppings = (double)(nudToppings.Value);
			numberOfPizzas = (double)(nudNumberOfPizzas.Value);
			numberOfFries = (double)(nudFries.Value);
			costOfDrinks = numberOfDrinks * 2;
			costOfFries = numberOfFries * 3;
			costOfToppings = 0;
			tax = 0;
			costOfSize = 0;

			// changes the cost of the toppings depending on the amount of toppings asked for.
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
			
			// Calculates the cost of the size depending on the size selected
			if (this.radL.Checked == true )
			{
				costOfSize = costOfSize + LARGE;
				

			}
			else if (this.radXL.Checked == true )
			{
				costOfSize = costOfSize + EXTRA_LARGE;
				

			}

			// displays the student discount if the answer is yes and keeps it hidden if no.
			if (this.radYesStudent.Checked == true)
			{
				lblStudentPriceAnswer.Show();

				lblError3.Text = "--";
			

			}
			else if (this.radNoStudent.Checked == true)
			{
				
				lblError3.Text = "--";
				

			}
			else
			{
				lblError3.Text = "Please state whether you are a student or not";
			}

			// changes the tax depending on the province chosen
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
				// displays an error if the user does not select a province
				lblError2.Text = "Please enter your province";
			}
			// calculates all the totals
			costOfDrinks = 2 * numberOfDrinks;


			costOfPizza = costOfSize + costOfToppings;

			subtotal = costOfPizza * numberOfPizzas + costOfDrinks + costOfFries;
			lblSubtotalAnswer.Text = String.Format("CA${0:0.00}", subtotal);
			HST = subtotal * tax;
			lblHSTAnswer.Text = String.Format("CA${0:0.00}", HST);
			total = subtotal + HST;
			lblTotalAnswer.Text = String.Format("CA${0:0.00}", total);
			studentDiscount = total * 0.25;
			discountPrice = total - studentDiscount;
			lblStudentPriceAnswer.Text = String.Format("CA${0:0.00}", discountPrice);





		}

		private void PizzaOrderForm_Load(object sender, EventArgs e)
		{

		}

		private void nudDrinks_ValueChanged(object sender, EventArgs e)
		{

		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// closes the program
			this.Close();
		}

		private void lblError2_Click(object sender, EventArgs e)
		{

		}
	}
}
