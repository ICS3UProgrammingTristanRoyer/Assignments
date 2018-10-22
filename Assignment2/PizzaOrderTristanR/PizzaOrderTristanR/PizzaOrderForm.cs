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
			double costOfSize, costOfToppings, costOfDrinks, costOfFries, discountPrice, subtotal,total,HST, studentDiscount;
			studentDiscount = total * 0.25;
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
				lblSubtotalAnswer.Text = "Enter a valid size";
			}
			if (this.radYesStudent.Checked == true)
			{ discountPrice = total - studentDiscount;
			}
			else
			{ lblStudentPriceAnswer.Text = "n/a;";
			}

			subtotal = ()

			

		}
	}
}
