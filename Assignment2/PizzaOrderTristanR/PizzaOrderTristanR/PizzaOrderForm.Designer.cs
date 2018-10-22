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
			this.label1 = new System.Windows.Forms.Label();
			this.btnCalculate = new System.Windows.Forms.Button();
			this.lblToppings = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.provinceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ontarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.quebecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.nud = new System.Windows.Forms.NumericUpDown();
			this.radL = new System.Windows.Forms.RadioButton();
			this.radXL = new System.Windows.Forms.RadioButton();
			this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
			this.radYes = new System.Windows.Forms.RadioButton();
			this.radNo = new System.Windows.Forms.RadioButton();
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
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nud)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudNumberOfPizzas)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 42);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(133, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "What Size Do You Want?:";
			// 
			// btnCalculate
			// 
			this.btnCalculate.Location = new System.Drawing.Point(166, 280);
			this.btnCalculate.Name = "btnCalculate";
			this.btnCalculate.Size = new System.Drawing.Size(75, 23);
			this.btnCalculate.TabIndex = 1;
			this.btnCalculate.Text = "Price";
			this.btnCalculate.UseVisualStyleBackColor = true;
			this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
			// 
			// lblToppings
			// 
			this.lblToppings.AutoSize = true;
			this.lblToppings.Location = new System.Drawing.Point(12, 112);
			this.lblToppings.Name = "lblToppings";
			this.lblToppings.Size = new System.Drawing.Size(179, 13);
			this.lblToppings.TabIndex = 2;
			this.lblToppings.Text = "How many toppings would you like?:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 138);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(167, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "How many drinks would you like?:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 191);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(108, 13);
			this.label4.TabIndex = 4;
			this.label4.Text = "Would you like fries?:";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.provinceToolStripMenuItem,
            this.fileToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
			this.menuStrip1.TabIndex = 5;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// provinceToolStripMenuItem
			// 
			this.provinceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ontarioToolStripMenuItem,
            this.quebecToolStripMenuItem});
			this.provinceToolStripMenuItem.Name = "provinceToolStripMenuItem";
			this.provinceToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
			this.provinceToolStripMenuItem.Text = "Province";
			// 
			// ontarioToolStripMenuItem
			// 
			this.ontarioToolStripMenuItem.Name = "ontarioToolStripMenuItem";
			this.ontarioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.ontarioToolStripMenuItem.Text = "Ontario";
			// 
			// quebecToolStripMenuItem
			// 
			this.quebecToolStripMenuItem.Name = "quebecToolStripMenuItem";
			this.quebecToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.quebecToolStripMenuItem.Text = "Quebec";
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
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			// 
			// nud
			// 
			this.nud.Location = new System.Drawing.Point(197, 110);
			this.nud.Name = "nud";
			this.nud.Size = new System.Drawing.Size(120, 20);
			this.nud.TabIndex = 6;
			// 
			// radL
			// 
			this.radL.AutoSize = true;
			this.radL.Checked = true;
			this.radL.Location = new System.Drawing.Point(172, 28);
			this.radL.Name = "radL";
			this.radL.Size = new System.Drawing.Size(52, 17);
			this.radL.TabIndex = 7;
			this.radL.TabStop = true;
			this.radL.Text = "Large";
			this.radL.UseVisualStyleBackColor = true;
			// 
			// radXL
			// 
			this.radXL.AutoSize = true;
			this.radXL.Location = new System.Drawing.Point(172, 51);
			this.radXL.Name = "radXL";
			this.radXL.Size = new System.Drawing.Size(79, 17);
			this.radXL.TabIndex = 8;
			this.radXL.Text = "Extra Large";
			this.radXL.UseVisualStyleBackColor = true;
			// 
			// numericUpDown2
			// 
			this.numericUpDown2.Location = new System.Drawing.Point(197, 136);
			this.numericUpDown2.Name = "numericUpDown2";
			this.numericUpDown2.Size = new System.Drawing.Size(120, 20);
			this.numericUpDown2.TabIndex = 9;
			// 
			// radYes
			// 
			this.radYes.AutoSize = true;
			this.radYes.Location = new System.Drawing.Point(166, 177);
			this.radYes.Name = "radYes";
			this.radYes.Size = new System.Drawing.Size(43, 17);
			this.radYes.TabIndex = 10;
			this.radYes.TabStop = true;
			this.radYes.Text = "Yes";
			this.radYes.UseVisualStyleBackColor = true;
			// 
			// radNo
			// 
			this.radNo.AutoSize = true;
			this.radNo.Location = new System.Drawing.Point(166, 200);
			this.radNo.Name = "radNo";
			this.radNo.Size = new System.Drawing.Size(39, 17);
			this.radNo.TabIndex = 11;
			this.radNo.TabStop = true;
			this.radNo.Text = "No";
			this.radNo.UseVisualStyleBackColor = true;
			// 
			// lblSubtotal
			// 
			this.lblSubtotal.AutoSize = true;
			this.lblSubtotal.Location = new System.Drawing.Point(12, 322);
			this.lblSubtotal.Name = "lblSubtotal";
			this.lblSubtotal.Size = new System.Drawing.Size(49, 13);
			this.lblSubtotal.TabIndex = 12;
			this.lblSubtotal.Text = "Subtotal:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 81);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(168, 13);
			this.label2.TabIndex = 13;
			this.label2.Text = "How many pizzas would you like?:";
			// 
			// nudNumberOfPizzas
			// 
			this.nudNumberOfPizzas.Location = new System.Drawing.Point(197, 79);
			this.nudNumberOfPizzas.Name = "nudNumberOfPizzas";
			this.nudNumberOfPizzas.Size = new System.Drawing.Size(120, 20);
			this.nudNumberOfPizzas.TabIndex = 14;
			// 
			// lblHST
			// 
			this.lblHST.AutoSize = true;
			this.lblHST.Location = new System.Drawing.Point(13, 358);
			this.lblHST.Name = "lblHST";
			this.lblHST.Size = new System.Drawing.Size(32, 13);
			this.lblHST.TabIndex = 15;
			this.lblHST.Text = "HST:";
			// 
			// lblStudentDiscount
			// 
			this.lblStudentDiscount.AutoSize = true;
			this.lblStudentDiscount.Location = new System.Drawing.Point(12, 418);
			this.lblStudentDiscount.Name = "lblStudentDiscount";
			this.lblStudentDiscount.Size = new System.Drawing.Size(71, 13);
			this.lblStudentDiscount.TabIndex = 16;
			this.lblStudentDiscount.Text = "StudentPrice:";
			// 
			// lblTotal
			// 
			this.lblTotal.AutoSize = true;
			this.lblTotal.Location = new System.Drawing.Point(13, 389);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(31, 13);
			this.lblTotal.TabIndex = 17;
			this.lblTotal.Text = "Total";
			// 
			// lblHSTAnswer
			// 
			this.lblHSTAnswer.AutoSize = true;
			this.lblHSTAnswer.Location = new System.Drawing.Point(189, 358);
			this.lblHSTAnswer.Name = "lblHSTAnswer";
			this.lblHSTAnswer.Size = new System.Drawing.Size(13, 13);
			this.lblHSTAnswer.TabIndex = 18;
			this.lblHSTAnswer.Text = "--";
			// 
			// lblSubtotalAnswer
			// 
			this.lblSubtotalAnswer.AutoSize = true;
			this.lblSubtotalAnswer.Location = new System.Drawing.Point(189, 322);
			this.lblSubtotalAnswer.Name = "lblSubtotalAnswer";
			this.lblSubtotalAnswer.Size = new System.Drawing.Size(13, 13);
			this.lblSubtotalAnswer.TabIndex = 19;
			this.lblSubtotalAnswer.Text = "--";
			// 
			// lblTotalAnswer
			// 
			this.lblTotalAnswer.AutoSize = true;
			this.lblTotalAnswer.Location = new System.Drawing.Point(189, 389);
			this.lblTotalAnswer.Name = "lblTotalAnswer";
			this.lblTotalAnswer.Size = new System.Drawing.Size(13, 13);
			this.lblTotalAnswer.TabIndex = 20;
			this.lblTotalAnswer.Text = "--";
			// 
			// lblStudentPriceAnswer
			// 
			this.lblStudentPriceAnswer.AutoSize = true;
			this.lblStudentPriceAnswer.Location = new System.Drawing.Point(189, 418);
			this.lblStudentPriceAnswer.Name = "lblStudentPriceAnswer";
			this.lblStudentPriceAnswer.Size = new System.Drawing.Size(13, 13);
			this.lblStudentPriceAnswer.TabIndex = 21;
			this.lblStudentPriceAnswer.Text = "--";
			// 
			// lblStudent
			// 
			this.lblStudent.AutoSize = true;
			this.lblStudent.Location = new System.Drawing.Point(16, 252);
			this.lblStudent.Name = "lblStudent";
			this.lblStudent.Size = new System.Drawing.Size(99, 26);
			this.lblStudent.TabIndex = 23;
			this.lblStudent.Text = "Are you a student?:\r\n\r\n";
			// 
			// radYesStudent
			// 
			this.radYesStudent.AutoSize = true;
			this.radYesStudent.Location = new System.Drawing.Point(166, 233);
			this.radYesStudent.Name = "radYesStudent";
			this.radYesStudent.Size = new System.Drawing.Size(43, 17);
			this.radYesStudent.TabIndex = 24;
			this.radYesStudent.TabStop = true;
			this.radYesStudent.Text = "Yes";
			this.radYesStudent.UseVisualStyleBackColor = true;
			// 
			// radNoStudent
			// 
			this.radNoStudent.AutoSize = true;
			this.radNoStudent.Location = new System.Drawing.Point(166, 257);
			this.radNoStudent.Name = "radNoStudent";
			this.radNoStudent.Size = new System.Drawing.Size(39, 17);
			this.radNoStudent.TabIndex = 25;
			this.radNoStudent.TabStop = true;
			this.radNoStudent.Text = "No";
			this.radNoStudent.UseVisualStyleBackColor = true;
			// 
			// PizzaOrderForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 465);
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
			this.Controls.Add(this.radNo);
			this.Controls.Add(this.radYes);
			this.Controls.Add(this.numericUpDown2);
			this.Controls.Add(this.radXL);
			this.Controls.Add(this.radL);
			this.Controls.Add(this.nud);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lblToppings);
			this.Controls.Add(this.btnCalculate);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "PizzaOrderForm";
			this.Text = "PizzaOrder";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nud)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudNumberOfPizzas)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnCalculate;
		private System.Windows.Forms.Label lblToppings;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem provinceToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ontarioToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem quebecToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.NumericUpDown nud;
		private System.Windows.Forms.RadioButton radL;
		private System.Windows.Forms.RadioButton radXL;
		private System.Windows.Forms.NumericUpDown numericUpDown2;
		private System.Windows.Forms.RadioButton radYes;
		private System.Windows.Forms.RadioButton radNo;
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
	}
}

