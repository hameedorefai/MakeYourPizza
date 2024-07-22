using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaProject
{
    
    public partial class PizzaOrder : Form
    {

        public PizzaOrder()
        {
            InitializeComponent();
            
        }

        float TotalPrice = 0;
        enum enToppings
        {
            enExtraCheese = 1, enOnion = 2, enMushroom = 4,
            enOlives = 8, enTomatoes = 16, enGreenPepers = 32
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        void Toppings()
        {
            string AllToppings = "";
            foreach (CheckBox checkbox in gbToppings.Controls.OfType<CheckBox>())
            {
                if (checkbox.Checked)
                {
                    AllToppings += checkbox.Text + "." + "\n";
                }
            }

            //if (chkExtraCheese.Checked == true)
            //{
            //    AllToppings += chkExtraCheese.Text + "." + "\n";
            //}
            //if (chkMushrooms.Checked == true)
            //{
            //    AllToppings += chkMushrooms.Text + "." + "\n";
            //}
            //if (chkOnion.Checked == true)
            //{
            //    AllToppings += chkOnion.Text + "." + "\n";

            //}
            //if (chkTomatoes.Checked == true)
            //{
            //    AllToppings += chkTomatoes.Text + "." + "\n";
            //}
            //if (chkOlives.Checked == true)
            //{
            //    AllToppings += chkOlives.Text + "." + "\n";

            //}
            //if (chkGreenPepers.Checked == true)
            //{
            //    AllToppings += chkGreenPepers.Text + "." + "\n";

            //}
            labelToppings.Text =  AllToppings;
        }

        private void gbSize_Enter(object sender, EventArgs e)
        {

        }

        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            if(rbSmall.Checked == true)
            {
                labelSize.Text = "Small";
                TotalPrice += 20;
            }
            else
            {
                TotalPrice -= 20;
            }
            labelPrice.Text = TotalPrice.ToString();

        }

        private void rbMedium_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMedium.Checked == true)
            {
                labelSize.Text = "Medium";
                TotalPrice += 30;
            }
            else
            {
                TotalPrice -= 30;
            }
            labelPrice.Text = TotalPrice.ToString();
        }

        private void rbLarge_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLarge.Checked == true)
            {
                labelSize.Text = "Large";
                TotalPrice += 40;
            }
            else
            {
                TotalPrice -= 40;
            }
            labelPrice.Text = TotalPrice.ToString();
        }

        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            if( rbEatIn.Checked == true) 
            {
                labelWhereToEat.Text = "In";
            }
        }

        private void rbEatOut_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEatOut.Checked == true)
            {
                labelWhereToEat.Text = "TakeOut";
            }
        }

        private void rbThin_CheckedChanged(object sender, EventArgs e)
        {
            if (rbThin.Checked == true)
            {
                labelCrustType.Text = "Thin";
            }
        }

        private void rbThink_CheckedChanged(object sender, EventArgs e)
        {
            if (rbThink.Checked == true)
            {
                labelCrustType.Text = "Think";
                TotalPrice += 10;
            }
            else
            {
                TotalPrice -= 10;
            }
            labelPrice.Text = TotalPrice.ToString();
        }

        private void gbToppings_Enter(object sender, EventArgs e)
        {

        }

        private void chkExtraCheese_CheckedChanged(object sender, EventArgs e)
        {
            if (chkExtraCheese.Checked == true)
                TotalPrice += 5;
            else
               TotalPrice -= 5;
            Toppings();
            labelPrice.Text = TotalPrice.ToString();
        }

        private void chkMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMushrooms.Checked == true)
                TotalPrice += 5;
            else
                TotalPrice -= 5;
            Toppings();
            labelPrice.Text = TotalPrice.ToString();
        }

        private void chkTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTomatoes.Checked == true)
                TotalPrice += 5;
            else
                TotalPrice -= 5;
            Toppings();
            labelPrice.Text = TotalPrice.ToString();
        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOnion.Checked == true)
                TotalPrice += 5;
            else
                TotalPrice -= 5;
            Toppings();
            labelPrice.Text = TotalPrice.ToString();
        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOlives.Checked == true)
                TotalPrice += 5;
            else
                TotalPrice -= 5;
            Toppings();
            labelPrice.Text = TotalPrice.ToString();
        }

        private void chkGreenPepers_CheckedChanged(object sender, EventArgs e)
        {
           
            if (chkGreenPepers.Checked == true)
                TotalPrice += 15; // I don't like it so it will be high price :-).
            else
                TotalPrice -= 15;
             Toppings();

            labelPrice.Text = TotalPrice.ToString();
        }

        private void labelToppings_Click(object sender, EventArgs e)
        {

        }

        private void LockScreen()
        {
            gbSize.Enabled = false;
            gbCrustType.Enabled = false;
            gbToppings.Enabled = false;
            gbWhereToEat.Enabled = false;
            btnOrderPizza.Enabled = false;
        }
        private void UnLockScreen()
        {
            gbSize.Enabled = true;
            gbCrustType.Enabled = true;
            gbToppings.Enabled = true;
            gbWhereToEat.Enabled = true;
            btnOrderPizza.Enabled = true;
        }
        private void btnOrderPizza_Click(object sender, EventArgs e)
        {
            if (labelWhereToEat.Text == "None")
            {
                MessageBox.Show("Please Fill Where To Eat", "UnCompleted Order"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Confirm Order", "Pizza Order", MessageBoxButtons.OKCancel
                  , MessageBoxIcon.Question) == DialogResult.OK)
                {
                    MessageBox.Show("Your pizza is now baking", "Pizza Order", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LockScreen();

                }
            }
        }
        void ResetgbToppings()
        {
    
            foreach (CheckBox checkbox in this.gbToppings.Controls.OfType<CheckBox>())
            {
                checkbox.Checked = false;
            }
            labelToppings.Text = "None";
        }
        void ResetgbWhereToEat()
        {
            
            foreach (RadioButton rb in this.gbWhereToEat.Controls.OfType<RadioButton>())
            {
                rb.Checked = false;
            }

            labelWhereToEat.Text = "None";
        }
        
        void ResetgbCurstType()
        {

            rbThin.Checked = true;
            labelCrustType.Text = "Thin";
            
        }
        void ResetgnSize()
        {
            rbSmall.Checked = true;
            labelSize.Text = "Small";
        }

        private void btnResetForm_Click(object sender, EventArgs e)
        {
            ResetgbToppings();
            ResetgbWhereToEat();
            ResetgbCurstType();
            ResetgnSize();
            UnLockScreen();
        }

        private void FixedlabelToppings_Click(object sender, EventArgs e)
        {

        }

        private void gbOrderSummary_Enter(object sender, EventArgs e)
        {

        }

        private void PizzaOrder_EnabledChanged(object sender, EventArgs e)
        {
            Enabled = false;
        }

        private void MainLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
