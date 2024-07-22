namespace PizzaProject
{
    partial class PizzaOrder
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
            this.MainLabel = new System.Windows.Forms.Label();
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.gbCrustType = new System.Windows.Forms.GroupBox();
            this.rbThink = new System.Windows.Forms.RadioButton();
            this.rbThin = new System.Windows.Forms.RadioButton();
            this.gbToppings = new System.Windows.Forms.GroupBox();
            this.chkGreenPepers = new System.Windows.Forms.CheckBox();
            this.chkExtraCheese = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.chkOlives = new System.Windows.Forms.CheckBox();
            this.chkMushrooms = new System.Windows.Forms.CheckBox();
            this.chkTomatoes = new System.Windows.Forms.CheckBox();
            this.gbWhereToEat = new System.Windows.Forms.GroupBox();
            this.rbEatOut = new System.Windows.Forms.RadioButton();
            this.rbEatIn = new System.Windows.Forms.RadioButton();
            this.gbOrderSummary = new System.Windows.Forms.GroupBox();
            this.labelToppings = new System.Windows.Forms.Label();
            this.labelCrustType = new System.Windows.Forms.Label();
            this.labelWhereToEat = new System.Windows.Forms.Label();
            this.labelSize = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.FixedDollarLogo = new System.Windows.Forms.Label();
            this.FixedlabelWhereToEat = new System.Windows.Forms.Label();
            this.FixedlabelPrice = new System.Windows.Forms.Label();
            this.FixedlabelCrustType = new System.Windows.Forms.Label();
            this.FixedlabelToppings = new System.Windows.Forms.Label();
            this.FixedLabelSize = new System.Windows.Forms.Label();
            this.btnOrderPizza = new System.Windows.Forms.Button();
            this.btnResetForm = new System.Windows.Forms.Button();
            this.gbSize.SuspendLayout();
            this.gbCrustType.SuspendLayout();
            this.gbToppings.SuspendLayout();
            this.gbWhereToEat.SuspendLayout();
            this.gbOrderSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainLabel
            // 
            this.MainLabel.AutoSize = true;
            this.MainLabel.BackColor = System.Drawing.SystemColors.Control;
            this.MainLabel.Font = new System.Drawing.Font("Showcard Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainLabel.ForeColor = System.Drawing.Color.Red;
            this.MainLabel.Location = new System.Drawing.Point(296, 18);
            this.MainLabel.Margin = new System.Windows.Forms.Padding(0);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Padding = new System.Windows.Forms.Padding(5);
            this.MainLabel.Size = new System.Drawing.Size(299, 46);
            this.MainLabel.TabIndex = 0;
            this.MainLabel.Text = "Make Your Pizza";
            this.MainLabel.Click += new System.EventHandler(this.MainLabel_Click);
            // 
            // gbSize
            // 
            this.gbSize.Controls.Add(this.rbMedium);
            this.gbSize.Controls.Add(this.rbLarge);
            this.gbSize.Controls.Add(this.rbSmall);
            this.gbSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSize.Location = new System.Drawing.Point(40, 112);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(200, 160);
            this.gbSize.TabIndex = 1;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Size";
            this.gbSize.Enter += new System.EventHandler(this.gbSize_Enter);
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.Location = new System.Drawing.Point(22, 77);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(83, 24);
            this.rbMedium.TabIndex = 6;
            this.rbMedium.TabStop = true;
            this.rbMedium.Text = "Medium";
            this.rbMedium.UseVisualStyleBackColor = true;
            this.rbMedium.CheckedChanged += new System.EventHandler(this.rbMedium_CheckedChanged);
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.Location = new System.Drawing.Point(22, 120);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(68, 24);
            this.rbLarge.TabIndex = 7;
            this.rbLarge.TabStop = true;
            this.rbLarge.Text = "Large";
            this.rbLarge.UseVisualStyleBackColor = true;
            this.rbLarge.CheckedChanged += new System.EventHandler(this.rbLarge_CheckedChanged);
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Location = new System.Drawing.Point(22, 34);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(66, 24);
            this.rbSmall.TabIndex = 5;
            this.rbSmall.TabStop = true;
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = true;
            this.rbSmall.CheckedChanged += new System.EventHandler(this.rbSmall_CheckedChanged);
            // 
            // gbCrustType
            // 
            this.gbCrustType.Controls.Add(this.rbThink);
            this.gbCrustType.Controls.Add(this.rbThin);
            this.gbCrustType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCrustType.Location = new System.Drawing.Point(40, 278);
            this.gbCrustType.Name = "gbCrustType";
            this.gbCrustType.Size = new System.Drawing.Size(200, 160);
            this.gbCrustType.TabIndex = 2;
            this.gbCrustType.TabStop = false;
            this.gbCrustType.Text = "Crust Type";
            // 
            // rbThink
            // 
            this.rbThink.AutoSize = true;
            this.rbThink.Location = new System.Drawing.Point(22, 96);
            this.rbThink.Name = "rbThink";
            this.rbThink.Size = new System.Drawing.Size(65, 24);
            this.rbThink.TabIndex = 7;
            this.rbThink.Text = "Think";
            this.rbThink.UseVisualStyleBackColor = true;
            this.rbThink.CheckedChanged += new System.EventHandler(this.rbThink_CheckedChanged);
            // 
            // rbThin
            // 
            this.rbThin.AutoSize = true;
            this.rbThin.Checked = true;
            this.rbThin.Location = new System.Drawing.Point(22, 49);
            this.rbThin.Name = "rbThin";
            this.rbThin.Size = new System.Drawing.Size(57, 24);
            this.rbThin.TabIndex = 6;
            this.rbThin.TabStop = true;
            this.rbThin.Text = "Thin";
            this.rbThin.UseVisualStyleBackColor = true;
            this.rbThin.CheckedChanged += new System.EventHandler(this.rbThin_CheckedChanged);
            // 
            // gbToppings
            // 
            this.gbToppings.Controls.Add(this.chkGreenPepers);
            this.gbToppings.Controls.Add(this.chkExtraCheese);
            this.gbToppings.Controls.Add(this.chkOnion);
            this.gbToppings.Controls.Add(this.chkOlives);
            this.gbToppings.Controls.Add(this.chkMushrooms);
            this.gbToppings.Controls.Add(this.chkTomatoes);
            this.gbToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbToppings.Location = new System.Drawing.Point(284, 112);
            this.gbToppings.Name = "gbToppings";
            this.gbToppings.Size = new System.Drawing.Size(324, 160);
            this.gbToppings.TabIndex = 3;
            this.gbToppings.TabStop = false;
            this.gbToppings.Text = "Toppings";
            this.gbToppings.Enter += new System.EventHandler(this.gbToppings_Enter);
            // 
            // chkGreenPepers
            // 
            this.chkGreenPepers.AutoSize = true;
            this.chkGreenPepers.Location = new System.Drawing.Point(174, 123);
            this.chkGreenPepers.Name = "chkGreenPepers";
            this.chkGreenPepers.Size = new System.Drawing.Size(127, 24);
            this.chkGreenPepers.TabIndex = 10;
            this.chkGreenPepers.Tag = "5";
            this.chkGreenPepers.Text = "Green Pepers";
            this.chkGreenPepers.UseVisualStyleBackColor = true;
            this.chkGreenPepers.CheckedChanged += new System.EventHandler(this.chkGreenPepers_CheckedChanged);
            // 
            // chkExtraCheese
            // 
            this.chkExtraCheese.AutoSize = true;
            this.chkExtraCheese.Location = new System.Drawing.Point(25, 45);
            this.chkExtraCheese.Name = "chkExtraCheese";
            this.chkExtraCheese.Size = new System.Drawing.Size(124, 24);
            this.chkExtraCheese.TabIndex = 5;
            this.chkExtraCheese.Tag = "5";
            this.chkExtraCheese.Text = "Extra Cheese";
            this.chkExtraCheese.UseVisualStyleBackColor = true;
            this.chkExtraCheese.CheckedChanged += new System.EventHandler(this.chkExtraCheese_CheckedChanged);
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.Location = new System.Drawing.Point(174, 45);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(70, 24);
            this.chkOnion.TabIndex = 5;
            this.chkOnion.Tag = "5";
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = true;
            this.chkOnion.CheckedChanged += new System.EventHandler(this.chkOnion_CheckedChanged);
            // 
            // chkOlives
            // 
            this.chkOlives.AutoSize = true;
            this.chkOlives.Location = new System.Drawing.Point(174, 84);
            this.chkOlives.Name = "chkOlives";
            this.chkOlives.Size = new System.Drawing.Size(70, 24);
            this.chkOlives.TabIndex = 9;
            this.chkOlives.Tag = "5";
            this.chkOlives.Text = "Olives";
            this.chkOlives.UseVisualStyleBackColor = true;
            this.chkOlives.CheckedChanged += new System.EventHandler(this.chkOlives_CheckedChanged);
            // 
            // chkMushrooms
            // 
            this.chkMushrooms.AutoSize = true;
            this.chkMushrooms.Location = new System.Drawing.Point(25, 84);
            this.chkMushrooms.Name = "chkMushrooms";
            this.chkMushrooms.Size = new System.Drawing.Size(111, 24);
            this.chkMushrooms.TabIndex = 6;
            this.chkMushrooms.Tag = "5";
            this.chkMushrooms.Text = "Mushrooms";
            this.chkMushrooms.UseVisualStyleBackColor = true;
            this.chkMushrooms.CheckedChanged += new System.EventHandler(this.chkMushrooms_CheckedChanged);
            // 
            // chkTomatoes
            // 
            this.chkTomatoes.AutoSize = true;
            this.chkTomatoes.Location = new System.Drawing.Point(25, 123);
            this.chkTomatoes.Name = "chkTomatoes";
            this.chkTomatoes.Size = new System.Drawing.Size(99, 24);
            this.chkTomatoes.TabIndex = 7;
            this.chkTomatoes.Tag = "5";
            this.chkTomatoes.Text = "Tomatoes";
            this.chkTomatoes.UseVisualStyleBackColor = true;
            this.chkTomatoes.CheckedChanged += new System.EventHandler(this.chkTomatoes_CheckedChanged);
            // 
            // gbWhereToEat
            // 
            this.gbWhereToEat.Controls.Add(this.rbEatOut);
            this.gbWhereToEat.Controls.Add(this.rbEatIn);
            this.gbWhereToEat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbWhereToEat.Location = new System.Drawing.Point(283, 278);
            this.gbWhereToEat.Name = "gbWhereToEat";
            this.gbWhereToEat.Size = new System.Drawing.Size(325, 160);
            this.gbWhereToEat.TabIndex = 3;
            this.gbWhereToEat.TabStop = false;
            this.gbWhereToEat.Text = "Where To Eat ";
            // 
            // rbEatOut
            // 
            this.rbEatOut.AutoSize = true;
            this.rbEatOut.Location = new System.Drawing.Point(122, 49);
            this.rbEatOut.Name = "rbEatOut";
            this.rbEatOut.Size = new System.Drawing.Size(53, 24);
            this.rbEatOut.TabIndex = 9;
            this.rbEatOut.TabStop = true;
            this.rbEatOut.Text = "Out";
            this.rbEatOut.UseVisualStyleBackColor = true;
            this.rbEatOut.CheckedChanged += new System.EventHandler(this.rbEatOut_CheckedChanged);
            // 
            // rbEatIn
            // 
            this.rbEatIn.AutoSize = true;
            this.rbEatIn.Location = new System.Drawing.Point(26, 49);
            this.rbEatIn.Name = "rbEatIn";
            this.rbEatIn.Size = new System.Drawing.Size(41, 24);
            this.rbEatIn.TabIndex = 8;
            this.rbEatIn.TabStop = true;
            this.rbEatIn.Text = "In";
            this.rbEatIn.UseVisualStyleBackColor = true;
            this.rbEatIn.CheckedChanged += new System.EventHandler(this.rbEatIn_CheckedChanged);
            // 
            // gbOrderSummary
            // 
            this.gbOrderSummary.Controls.Add(this.labelToppings);
            this.gbOrderSummary.Controls.Add(this.labelCrustType);
            this.gbOrderSummary.Controls.Add(this.labelWhereToEat);
            this.gbOrderSummary.Controls.Add(this.labelSize);
            this.gbOrderSummary.Controls.Add(this.labelPrice);
            this.gbOrderSummary.Controls.Add(this.FixedDollarLogo);
            this.gbOrderSummary.Controls.Add(this.FixedlabelWhereToEat);
            this.gbOrderSummary.Controls.Add(this.FixedlabelPrice);
            this.gbOrderSummary.Controls.Add(this.FixedlabelCrustType);
            this.gbOrderSummary.Controls.Add(this.FixedlabelToppings);
            this.gbOrderSummary.Controls.Add(this.FixedLabelSize);
            this.gbOrderSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOrderSummary.Location = new System.Drawing.Point(633, 112);
            this.gbOrderSummary.Name = "gbOrderSummary";
            this.gbOrderSummary.Size = new System.Drawing.Size(258, 326);
            this.gbOrderSummary.TabIndex = 4;
            this.gbOrderSummary.TabStop = false;
            this.gbOrderSummary.Text = "Order Summary";
            this.gbOrderSummary.Enter += new System.EventHandler(this.gbOrderSummary_Enter);
            // 
            // labelToppings
            // 
            this.labelToppings.AutoSize = true;
            this.labelToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelToppings.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelToppings.Location = new System.Drawing.Point(120, 109);
            this.labelToppings.Name = "labelToppings";
            this.labelToppings.Size = new System.Drawing.Size(47, 20);
            this.labelToppings.TabIndex = 10;
            this.labelToppings.Text = "None";
            this.labelToppings.Click += new System.EventHandler(this.labelToppings_Click);
            // 
            // labelCrustType
            // 
            this.labelCrustType.AutoSize = true;
            this.labelCrustType.Location = new System.Drawing.Point(133, 77);
            this.labelCrustType.Name = "labelCrustType";
            this.labelCrustType.Size = new System.Drawing.Size(39, 20);
            this.labelCrustType.TabIndex = 9;
            this.labelCrustType.Text = "Thin";
            // 
            // labelWhereToEat
            // 
            this.labelWhereToEat.AutoSize = true;
            this.labelWhereToEat.Location = new System.Drawing.Point(162, 230);
            this.labelWhereToEat.Name = "labelWhereToEat";
            this.labelWhereToEat.Size = new System.Drawing.Size(47, 20);
            this.labelWhereToEat.TabIndex = 8;
            this.labelWhereToEat.Text = "None";
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Location = new System.Drawing.Point(87, 35);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(47, 20);
            this.labelSize.TabIndex = 7;
            this.labelSize.Text = "None";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.ForeColor = System.Drawing.Color.Green;
            this.labelPrice.Location = new System.Drawing.Point(159, 262);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(36, 37);
            this.labelPrice.TabIndex = 6;
            this.labelPrice.Text = "0";
            // 
            // FixedDollarLogo
            // 
            this.FixedDollarLogo.AutoSize = true;
            this.FixedDollarLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FixedDollarLogo.ForeColor = System.Drawing.Color.Green;
            this.FixedDollarLogo.Location = new System.Drawing.Point(132, 262);
            this.FixedDollarLogo.Name = "FixedDollarLogo";
            this.FixedDollarLogo.Size = new System.Drawing.Size(36, 37);
            this.FixedDollarLogo.TabIndex = 5;
            this.FixedDollarLogo.Text = "$";
            // 
            // FixedlabelWhereToEat
            // 
            this.FixedlabelWhereToEat.AutoSize = true;
            this.FixedlabelWhereToEat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FixedlabelWhereToEat.Location = new System.Drawing.Point(27, 230);
            this.FixedlabelWhereToEat.Name = "FixedlabelWhereToEat";
            this.FixedlabelWhereToEat.Size = new System.Drawing.Size(129, 20);
            this.FixedlabelWhereToEat.TabIndex = 3;
            this.FixedlabelWhereToEat.Text = "Where To Eat :";
            // 
            // FixedlabelPrice
            // 
            this.FixedlabelPrice.AutoSize = true;
            this.FixedlabelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FixedlabelPrice.Location = new System.Drawing.Point(27, 267);
            this.FixedlabelPrice.Name = "FixedlabelPrice";
            this.FixedlabelPrice.Size = new System.Drawing.Size(99, 20);
            this.FixedlabelPrice.TabIndex = 4;
            this.FixedlabelPrice.Text = "Total Price:";
            // 
            // FixedlabelCrustType
            // 
            this.FixedlabelCrustType.AutoSize = true;
            this.FixedlabelCrustType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FixedlabelCrustType.Location = new System.Drawing.Point(27, 77);
            this.FixedlabelCrustType.Name = "FixedlabelCrustType";
            this.FixedlabelCrustType.Size = new System.Drawing.Size(100, 20);
            this.FixedlabelCrustType.TabIndex = 2;
            this.FixedlabelCrustType.Text = "Crust Type:";
            // 
            // FixedlabelToppings
            // 
            this.FixedlabelToppings.AutoSize = true;
            this.FixedlabelToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FixedlabelToppings.Location = new System.Drawing.Point(27, 109);
            this.FixedlabelToppings.Name = "FixedlabelToppings";
            this.FixedlabelToppings.Size = new System.Drawing.Size(87, 20);
            this.FixedlabelToppings.TabIndex = 1;
            this.FixedlabelToppings.Text = "Toppings:";
            this.FixedlabelToppings.Click += new System.EventHandler(this.FixedlabelToppings_Click);
            // 
            // FixedLabelSize
            // 
            this.FixedLabelSize.AutoSize = true;
            this.FixedLabelSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FixedLabelSize.Location = new System.Drawing.Point(27, 35);
            this.FixedLabelSize.Name = "FixedLabelSize";
            this.FixedLabelSize.Size = new System.Drawing.Size(54, 20);
            this.FixedLabelSize.TabIndex = 0;
            this.FixedLabelSize.Text = "Size :";
            // 
            // btnOrderPizza
            // 
            this.btnOrderPizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderPizza.Location = new System.Drawing.Point(323, 444);
            this.btnOrderPizza.Name = "btnOrderPizza";
            this.btnOrderPizza.Size = new System.Drawing.Size(124, 52);
            this.btnOrderPizza.TabIndex = 5;
            this.btnOrderPizza.Text = "Order Pizza";
            this.btnOrderPizza.UseVisualStyleBackColor = true;
            this.btnOrderPizza.Click += new System.EventHandler(this.btnOrderPizza_Click);
            // 
            // btnResetForm
            // 
            this.btnResetForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetForm.Location = new System.Drawing.Point(471, 444);
            this.btnResetForm.Name = "btnResetForm";
            this.btnResetForm.Size = new System.Drawing.Size(124, 52);
            this.btnResetForm.TabIndex = 6;
            this.btnResetForm.Text = "Reset";
            this.btnResetForm.UseVisualStyleBackColor = true;
            this.btnResetForm.Click += new System.EventHandler(this.btnResetForm_Click);
            // 
            // PizzaOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 514);
            this.Controls.Add(this.btnResetForm);
            this.Controls.Add(this.btnOrderPizza);
            this.Controls.Add(this.gbOrderSummary);
            this.Controls.Add(this.gbWhereToEat);
            this.Controls.Add(this.gbToppings);
            this.Controls.Add(this.gbCrustType);
            this.Controls.Add(this.gbSize);
            this.Controls.Add(this.MainLabel);
            this.Name = "PizzaOrder";
            this.Text = "Pizza Order";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.EnabledChanged += new System.EventHandler(this.PizzaOrder_EnabledChanged);
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.gbCrustType.ResumeLayout(false);
            this.gbCrustType.PerformLayout();
            this.gbToppings.ResumeLayout(false);
            this.gbToppings.PerformLayout();
            this.gbWhereToEat.ResumeLayout(false);
            this.gbWhereToEat.PerformLayout();
            this.gbOrderSummary.ResumeLayout(false);
            this.gbOrderSummary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.GroupBox gbCrustType;
        private System.Windows.Forms.RadioButton rbThink;
        private System.Windows.Forms.RadioButton rbThin;
        private System.Windows.Forms.GroupBox gbToppings;
        private System.Windows.Forms.GroupBox gbWhereToEat;
        private System.Windows.Forms.RadioButton rbEatOut;
        private System.Windows.Forms.RadioButton rbEatIn;
        private System.Windows.Forms.GroupBox gbOrderSummary;
        private System.Windows.Forms.CheckBox chkGreenPepers;
        private System.Windows.Forms.CheckBox chkExtraCheese;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.CheckBox chkOlives;
        private System.Windows.Forms.CheckBox chkMushrooms;
        private System.Windows.Forms.CheckBox chkTomatoes;
        private System.Windows.Forms.Label FixedlabelPrice;
        private System.Windows.Forms.Label FixedlabelWhereToEat;
        private System.Windows.Forms.Label FixedlabelCrustType;
        private System.Windows.Forms.Label FixedlabelToppings;
        private System.Windows.Forms.Label FixedLabelSize;
        private System.Windows.Forms.Button btnOrderPizza;
        private System.Windows.Forms.Button btnResetForm;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label FixedDollarLogo;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.Label labelWhereToEat;
        private System.Windows.Forms.Label labelCrustType;
        private System.Windows.Forms.Label labelToppings;
    }
}

