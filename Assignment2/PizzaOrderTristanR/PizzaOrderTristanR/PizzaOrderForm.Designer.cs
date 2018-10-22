namespace PizzaOrderTristanR
{
	partial class PizzaOrderForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PizzaOrderForm));
			this.label1 = new System.Windows.Forms.Label();
			this.btnCalculate = new System.Windows.Forms.Button();
			this.lblToppings = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.nudToppings = new System.Windows.Forms.NumericUpDown();
			this.radL = new System.Windows.Forms.RadioButton();
			this.radXL = new System.Windows.Forms.RadioButton();
			this.nudDrinks = new System.Windows.Forms.NumericUpDown();
			this.lblSubtotal = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.nudNumberOfPizzas = new System.Windows.Forms.NumericUpDown();
			this.lblHST = new System.Windows.Forms.Label();
			this.lblStudentDiscount = new System.Windows.Forms.Label();
			this.lblTotal = new System.Windows.Forms.Label();
			this.lblHSTAnswer = new System.Windows.Forms.Label();
			this.lblSubtotalAnswer = new System.Windows.Forms.Label();
			this.lblTotalAnswer = new System.Windows.Forms.Label();
			this.lblStudentPriceAnswer = new System.Windows.Forms.Label();
			this.lblStudent = new System.Windows.Forms.Label();
			this.radYesStudent = new System.Windows.Forms.RadioButton();
			this.radNoStudent = new System.Windows.Forms.RadioButton();
			this.lblProvince = new System.Windows.Forms.Label();
			this.radOntario = new System.Windows.Forms.RadioButton();
			this.radQuebec = new System.Windows.Forms.RadioButton();
			this.lblFries = new System.Windows.Forms.Label();
			this.radYesFries = new System.Windows.Forms.RadioButton();
			this.radNoFries = new System.Windows.Forms.RadioButton();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.lblError1 = new System.Windows.Forms.Label();
			this.lblError2 = new System.Windows.Forms.Label();
			this.lblError3 = new System.Windows.Forms.Label();
			this.lblError4 = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudToppings)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudDrinks)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudNumberOfPizzas)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label1.Location = new System.Drawing.Point(12, 42);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(133, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "What Size Do You Want?:";
			// 
			// btnCalculate
			// 
			this.btnCalculate.BackColor = System.Drawing.Color.Red;
			this.btnCalculate.Location = new System.Drawing.Point(8, 440);
			this.btnCalculate.Name = "btnCalculate";
			this.btnCalculate.Size = new System.Drawing.Size(75, 40);
			this.btnCalculate.TabIndex = 1;
			this.btnCalculate.Text = "Price";
			this.btnCalculate.UseVisualStyleBackColor = false;
			this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
			// 
			// lblToppings
			// 
			this.lblToppings.AutoSize = true;
			this.lblToppings.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.lblToppings.Location = new System.Drawing.Point(12, 112);
			this.lblToppings.Name = "lblToppings";
			this.lblToppings.Size = new System.Drawing.Size(179, 13);
			this.lblToppings.TabIndex = 2;
			this.lblToppings.Text = "How many toppings would you like?:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label3.Location = new System.Drawing.Point(12, 138);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(167, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "How many drinks would you like?:";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(649, 24);
			this.menuStrip1.TabIndex = 5;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			// 
			// nudToppings
			// 
			this.nudToppings.BackColor = System.Drawing.Color.Teal;
			this.nudToppings.Location = new System.Drawing.Point(197, 110);
			this.nudToppings.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
			this.nudToppings.Name = "nudToppings";
			this.nudToppings.Size = new System.Drawing.Size(120, 20);
			this.nudToppings.TabIndex = 6;
			// 
			// radL
			// 
			this.radL.AutoSize = true;
			this.radL.BackColor = System.Drawing.Color.Teal;
			this.radL.Checked = true;
			this.radL.Location = new System.Drawing.Point(172, 28);
			this.radL.Name = "radL";
			this.radL.Size = new System.Drawing.Size(52, 17);
			this.radL.TabIndex = 7;
			this.radL.TabStop = true;
			this.radL.Text = "Large";
			this.radL.UseVisualStyleBackColor = false;
			// 
			// radXL
			// 
			this.radXL.AutoSize = true;
			this.radXL.BackColor = System.Drawing.Color.Teal;
			this.radXL.Location = new System.Drawing.Point(172, 51);
			this.radXL.Name = "radXL";
			this.radXL.Size = new System.Drawing.Size(79, 17);
			this.radXL.TabIndex = 8;
			this.radXL.Text = "Extra Large";
			this.radXL.UseVisualStyleBackColor = false;
			// 
			// nudDrinks
			// 
			this.nudDrinks.BackColor = System.Drawing.Color.Teal;
			this.nudDrinks.Location = new System.Drawing.Point(197, 136);
			this.nudDrinks.Name = "nudDrinks";
			this.nudDrinks.Size = new System.Drawing.Size(120, 20);
			this.nudDrinks.TabIndex = 9;
			this.nudDrinks.ValueChanged += new System.EventHandler(this.nudDrinks_ValueChanged);
			// 
			// lblSubtotal
			// 
			this.lblSubtotal.AutoSize = true;
			this.lblSubtotal.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.lblSubtotal.Location = new System.Drawing.Point(12, 483);
			this.lblSubtotal.Name = "lblSubtotal";
			this.lblSubtotal.Size = new System.Drawing.Size(49, 13);
			this.lblSubtotal.TabIndex = 12;
			this.lblSubtotal.Text = "Subtotal:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label2.Location = new System.Drawing.Point(12, 81);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(168, 13);
			this.label2.TabIndex = 13;
			this.label2.Text = "How many pizzas would you like?:";
			// 
			// nudNumberOfPizzas
			// 
			this.nudNumberOfPizzas.BackColor = System.Drawing.Color.Teal;
			this.nudNumberOfPizzas.Location = new System.Drawing.Point(197, 79);
			this.nudNumberOfPizzas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudNumberOfPizzas.Name = "nudNumberOfPizzas";
			this.nudNumberOfPizzas.Size = new System.Drawing.Size(120, 20);
			this.nudNumberOfPizzas.TabIndex = 14;
			this.nudNumberOfPizzas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// lblHST
			// 
			this.lblHST.AutoSize = true;
			this.lblHST.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.lblHST.Location = new System.Drawing.Point(12, 514);
			this.lblHST.Name = "lblHST";
			this.lblHST.Size = new System.Drawing.Size(32, 13);
			this.lblHST.TabIndex = 15;
			this.lblHST.Text = "HST:";
			// 
			// lblStudentDiscount
			// 
			this.lblStudentDiscount.AutoSize = true;
			this.lblStudentDiscount.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.lblStudentDiscount.Location = new System.Drawing.Point(12, 576);
			this.lblStudentDiscount.Name = "lblStudentDiscount";
			this.lblStudentDiscount.Size = new System.Drawing.Size(71, 13);
			this.lblStudentDiscount.TabIndex = 16;
			this.lblStudentDiscount.Text = "StudentPrice:";
			// 
			// lblTotal
			// 
			this.lblTotal.AutoSize = true;
			this.lblTotal.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.lblTotal.Location = new System.Drawing.Point(12, 547);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(31, 13);
			this.lblTotal.TabIndex = 17;
			this.lblTotal.Text = "Total";
			// 
			// lblHSTAnswer
			// 
			this.lblHSTAnswer.AutoSize = true;
			this.lblHSTAnswer.BackColor = System.Drawing.Color.Teal;
			this.lblHSTAnswer.Location = new System.Drawing.Point(178, 514);
			this.lblHSTAnswer.Name = "lblHSTAnswer";
			this.lblHSTAnswer.Size = new System.Drawing.Size(13, 13);
			this.lblHSTAnswer.TabIndex = 18;
			this.lblHSTAnswer.Text = "--";
			// 
			// lblSubtotalAnswer
			// 
			this.lblSubtotalAnswer.AutoSize = true;
			this.lblSubtotalAnswer.BackColor = System.Drawing.Color.Teal;
			this.lblSubtotalAnswer.Location = new System.Drawing.Point(178, 483);
			this.lblSubtotalAnswer.Name = "lblSubtotalAnswer";
			this.lblSubtotalAnswer.Size = new System.Drawing.Size(13, 13);
			this.lblSubtotalAnswer.TabIndex = 19;
			this.lblSubtotalAnswer.Text = "--";
			// 
			// lblTotalAnswer
			// 
			this.lblTotalAnswer.AutoSize = true;
			this.lblTotalAnswer.BackColor = System.Drawing.Color.Teal;
			this.lblTotalAnswer.Location = new System.Drawing.Point(178, 547);
			this.lblTotalAnswer.Name = "lblTotalAnswer";
			this.lblTotalAnswer.Size = new System.Drawing.Size(13, 13);
			this.lblTotalAnswer.TabIndex = 20;
			this.lblTotalAnswer.Text = "--";
			// 
			// lblStudentPriceAnswer
			// 
			this.lblStudentPriceAnswer.AutoSize = true;
			this.lblStudentPriceAnswer.BackColor = System.Drawing.Color.Teal;
			this.lblStudentPriceAnswer.Location = new System.Drawing.Point(178, 576);
			this.lblStudentPriceAnswer.Name = "lblStudentPriceAnswer";
			this.lblStudentPriceAnswer.Size = new System.Drawing.Size(13, 13);
			this.lblStudentPriceAnswer.TabIndex = 21;
			this.lblStudentPriceAnswer.Text = "--";
			// 
			// lblStudent
			// 
			this.lblStudent.AutoSize = true;
			this.lblStudent.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.lblStudent.Location = new System.Drawing.Point(12, 195);
			this.lblStudent.Name = "lblStudent";
			this.lblStudent.Size = new System.Drawing.Size(99, 26);
			this.lblStudent.TabIndex = 23;
			this.lblStudent.Text = "Are you a student?:\r\n\r\n";
			// 
			// radYesStudent
			// 
			this.radYesStudent.AutoSize = true;
			this.radYesStudent.BackColor = System.Drawing.Color.Teal;
			this.radYesStudent.Location = new System.Drawing.Point(161, 193);
			this.radYesStudent.Name = "radYesStudent";
			this.radYesStudent.Size = new System.Drawing.Size(43, 17);
			this.radYesStudent.TabIndex = 24;
			this.radYesStudent.TabStop = true;
			this.radYesStudent.Text = "Yes";
			this.radYesStudent.UseVisualStyleBackColor = false;
			// 
			// radNoStudent
			// 
			this.radNoStudent.AutoSize = true;
			this.radNoStudent.BackColor = System.Drawing.Color.Teal;
			this.radNoStudent.Location = new System.Drawing.Point(161, 216);
			this.radNoStudent.Name = "radNoStudent";
			this.radNoStudent.Size = new System.Drawing.Size(39, 17);
			this.radNoStudent.TabIndex = 25;
			this.radNoStudent.TabStop = true;
			this.radNoStudent.Text = "No";
			this.radNoStudent.UseVisualStyleBackColor = false;
			// 
			// lblProvince
			// 
			this.lblProvince.AutoSize = true;
			this.lblProvince.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.lblProvince.Location = new System.Drawing.Point(9, 321);
			this.lblProvince.Name = "lblProvince";
			this.lblProvince.Size = new System.Drawing.Size(135, 13);
			this.lblProvince.TabIndex = 26;
			this.lblProvince.Text = "What province are you in?:";
			// 
			// radOntario
			// 
			this.radOntario.AutoSize = true;
			this.radOntario.BackColor = System.Drawing.Color.Teal;
			this.radOntario.Location = new System.Drawing.Point(161, 313);
			this.radOntario.Name = "radOntario";
			this.radOntario.Size = new System.Drawing.Size(62, 17);
			this.radOntario.TabIndex = 27;
			this.radOntario.TabStop = true;
			this.radOntario.Text = "Ontario ";
			this.radOntario.UseVisualStyleBackColor = false;
			// 
			// radQuebec
			// 
			this.radQuebec.AutoSize = true;
			this.radQuebec.BackColor = System.Drawing.Color.Teal;
			this.radQuebec.Location = new System.Drawing.Point(161, 336);
			this.radQuebec.Name = "radQuebec";
			this.radQuebec.Size = new System.Drawing.Size(63, 17);
			this.radQuebec.TabIndex = 28;
			this.radQuebec.TabStop = true;
			this.radQuebec.Text = "Quebec";
			this.radQuebec.UseVisualStyleBackColor = false;
			// 
			// lblFries
			// 
			this.lblFries.AutoSize = true;
			this.lblFries.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.lblFries.Location = new System.Drawing.Point(16, 399);
			this.lblFries.Name = "lblFries";
			this.lblFries.Size = new System.Drawing.Size(98, 13);
			this.lblFries.TabIndex = 30;
			this.lblFries.Text = "Do you want fries?:";
			// 
			// radYesFries
			// 
			this.radYesFries.AutoSize = true;
			this.radYesFries.BackColor = System.Drawing.Color.Teal;
			this.radYesFries.Location = new System.Drawing.Point(161, 380);
			this.radYesFries.Name = "radYesFries";
			this.radYesFries.Size = new System.Drawing.Size(43, 17);
			this.radYesFries.TabIndex = 31;
			this.radYesFries.TabStop = true;
			this.radYesFries.Text = "Yes";
			this.radYesFries.UseVisualStyleBackColor = false;
			// 
			// radNoFries
			// 
			this.radNoFries.AutoSize = true;
			this.radNoFries.BackColor = System.Drawing.Color.Teal;
			this.radNoFries.Location = new System.Drawing.Point(161, 403);
			this.radNoFries.Name = "radNoFries";
			this.radNoFries.Size = new System.Drawing.Size(39, 17);
			this.radNoFries.TabIndex = 32;
			this.radNoFries.TabStop = true;
			this.radNoFries.Text = "No";
			this.radNoFries.UseVisualStyleBackColor = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = global::PizzaOrderTristanR.Properties.Resources.pizza_animated_gif_21;
			this.pictureBox1.Location = new System.Drawing.Point(395, 27);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(254, 246);
			this.pictureBox1.TabIndex = 33;
			this.pictureBox1.TabStop = false;
			// 
			// lblError1
			// 
			this.lblError1.AutoSize = true;
			this.lblError1.BackColor = System.Drawing.Color.Teal;
			this.lblError1.Location = new System.Drawing.Point(320, 483);
			this.lblError1.Name = "lblError1";
			this.lblError1.Size = new System.Drawing.Size(13, 13);
			this.lblError1.TabIndex = 34;
			this.lblError1.Text = "--";
			// 
			// lblError2
			// 
			this.lblError2.AutoSize = true;
			this.lblError2.BackColor = System.Drawing.Color.Teal;
			this.lblError2.Location = new System.Drawing.Point(320, 512);
			this.lblError2.Name = "lblError2";
			this.lblError2.Size = new System.Drawing.Size(13, 13);
			this.lblError2.TabIndex = 35;
			this.lblError2.Text = "--";
			// 
			// lblError3
			// 
			this.lblError3.AutoSize = true;
			this.lblError3.BackColor = System.Drawing.Color.Teal;
			this.lblError3.Location = new System.Drawing.Point(320, 547);
			this.lblError3.Name = "lblError3";
			this.lblError3.Size = new System.Drawing.Size(13, 13);
			this.lblError3.TabIndex = 36;
			this.lblError3.Text = "--";
			// 
			// lblError4
			// 
			this.lblError4.AutoSize = true;
			this.lblError4.BackColor = System.Drawing.Color.Teal;
			this.lblError4.Location = new System.Drawing.Point(320, 576);
			this.lblError4.Name = "lblError4";
			this.lblError4.Size = new System.Drawing.Size(13, 13);
			this.lblError4.TabIndex = 37;
			this.lblError4.Text = "--";
			// 
			// PizzaOrderForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::PizzaOrderTristanR.Properties.Resources._76599be63cbb512;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(649, 624);
			this.Controls.Add(this.lblError4);
			this.Controls.Add(this.lblError3);
			this.Controls.Add(this.lblError2);
			this.Controls.Add(this.lblError1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.radNoFries);
			this.Controls.Add(this.radYesFries);
			this.Controls.Add(this.lblFries);
			this.Controls.Add(this.radQuebec);
			this.Controls.Add(this.radOntario);
			this.Controls.Add(this.lblProvince);
			this.Controls.Add(this.radNoStudent);
			this.Controls.Add(this.radYesStudent);
			this.Controls.Add(this.lblStudent);
			this.Controls.Add(this.lblStudentPriceAnswer);
			this.Controls.Add(this.lblTotalAnswer);
			this.Controls.Add(this.lblSubtotalAnswer);
			this.Controls.Add(this.lblHSTAnswer);
			this.Controls.Add(this.lblTotal);
			this.Controls.Add(this.lblStudentDiscount);
			this.Controls.Add(this.lblHST);
			this.Controls.Add(this.nudNumberOfPizzas);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lblSubtotal);
			this.Controls.Add(this.nudDrinks);
			this.Controls.Add(this.radXL);
			this.Controls.Add(this.radL);
			this.Controls.Add(this.nudToppings);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lblToppings);
			this.Controls.Add(this.btnCalculate);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "PizzaOrderForm";
			this.Text = "PizzaOrder";
			this.Load += new System.EventHandler(this.PizzaOrderForm_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudToppings)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudDrinks)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudNumberOfPizzas)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnCalculate;
		private System.Windows.Forms.Label lblToppings;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.NumericUpDown nudToppings;
		private System.Windows.Forms.RadioButton radL;
		private System.Windows.Forms.RadioButton radXL;
		private System.Windows.Forms.NumericUpDown nudDrinks;
		private System.Windows.Forms.Label lblSubtotal;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown nudNumberOfPizzas;
		private System.Windows.Forms.Label lblHST;
		private System.Windows.Forms.Label lblStudentDiscount;
		private System.Windows.Forms.Label lblTotal;
		private System.Windows.Forms.Label lblHSTAnswer;
		private System.Windows.Forms.Label lblSubtotalAnswer;
		private System.Windows.Forms.Label lblTotalAnswer;
		private System.Windows.Forms.Label lblStudentPriceAnswer;
		private System.Windows.Forms.Label lblStudent;
		private System.Windows.Forms.RadioButton radYesStudent;
		private System.Windows.Forms.RadioButton radNoStudent;
		private System.Windows.Forms.Label lblProvince;
		private System.Windows.Forms.RadioButton radOntario;
		private System.Windows.Forms.RadioButton radQuebec;
		private System.Windows.Forms.Label lblFries;
		private System.Windows.Forms.RadioButton radYesFries;
		private System.Windows.Forms.RadioButton radNoFries;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label lblError1;
		private System.Windows.Forms.Label lblError2;
		private System.Windows.Forms.Label lblError3;
		private System.Windows.Forms.Label lblError4;
	}
}

