/*
 * Created by: Tristan Royer
 * Created on: 27-09-2018
 * Created for: ICS3U Programming
 * Assignment #2 - Falling Objects
 * This program calculates the height of an object above the ground using the time given by the user.
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

namespace FallingObjectsTristanR
{
	public partial class FallingObjectsForm : Form
	{
		public FallingObjectsForm()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			// This provides an error message if the user does not enter a value
			if (txtTime.Text == "")
			{
				this.lblHeight.Text = "Error (enter valid value)";
			}
			else
			{
				//Declare local variables
				double time,height; 
				
				// convert the string from the text box to a double
				time = double.Parse(txtTime.Text);

				// Calculate the height above the ground
				height =   100 -  ( 0.5 *  9.81 *  Math.Pow(time, 2));
				height = Math.Round(height, 2, MidpointRounding.AwayFromZero);

				// Insert the height to it's respective label

				this.lblHeight.Text = Convert.ToString(height) + " meters";

				if (height < 1)
				{
					// if the ball has already reached the ground it will display the appropriate text.
					this.lblHeight.Text = "The ball has already eached the ground";
				}









			}
		}

			private void txtTime_TextChanged(object sender, EventArgs e)
			{


			}

			private void txtTime_KeyPress(object sender, KeyPressEventArgs e)
			{
			// allows only digits and decimals to be typed into the textbox (source : StackOverflow)
			if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
					
					e.Handled = true;


			}

		private void FallingObjectsForm_Load(object sender, EventArgs e)
		{

		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// closes the program
			this.Close();
		}
	}
	}
