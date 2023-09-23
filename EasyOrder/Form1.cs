using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyOrder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Double CalculateTotalPrice()
        {
            Double _TotalPrice = 0;

            if (rdSmall.Checked)
            {
                _TotalPrice += Convert.ToSingle(rdSmall.Tag);
            }
            else if (rdMed.Checked)
            {
                _TotalPrice += Convert.ToSingle(rdMed.Tag);
            }
            else if (rdLarg.Checked)
            {
                _TotalPrice += Convert.ToSingle(rdLarg.Tag);
            }

            if (chkExtraCheese.Checked)
            {
                _TotalPrice += Convert.ToSingle(chkExtraCheese.Tag);
            }
            if (chkMushroom.Checked)
            {
                _TotalPrice += Convert.ToSingle(chkMushroom.Tag);
            }
            if (chkTomatoes.Checked)
            {
                _TotalPrice += Convert.ToSingle(chkTomatoes.Tag);
            }
            if (chkOnion.Checked)
            {
                _TotalPrice += Convert.ToSingle(chkOnion.Tag);
            }
            if (chkOlives.Checked)
            {
                _TotalPrice += Convert.ToSingle(chkOlives.Tag);
            }
            if (chkPepper.Checked)
            {
                _TotalPrice += Convert.ToSingle(chkPepper.Tag);
            }
            if (chkMeat.Checked)
            {
                _TotalPrice += Convert.ToSingle(chkMeat.Tag);
            }
            if (chkChicken.Checked)
            {
                _TotalPrice += Convert.ToSingle(chkChicken.Tag);
            }
            if (rdThin.Checked)
            {
                _TotalPrice += Convert.ToSingle(rdThin.Tag);
            }
            else if (rdCheesy.Checked)
            {
                _TotalPrice += Convert.ToSingle(rdCheesy.Tag);
            }
            if (rdDineIn.Checked)
            {
                _TotalPrice += Convert.ToSingle(rdDineIn.Tag);
            }
            else if (rdTakeAway.Checked)
            {
                _TotalPrice += Convert.ToSingle(rdTakeAway.Tag);
            }
            return Math.Round(_TotalPrice, 2);
        }
        private void UpdatePrice()
        {
            lblTotalPriceValue.Text = "$" + CalculateTotalPrice().ToString();
        }
        private void UpdateCrust()
        {
            UpdatePrice();
            if (rdThin.Checked)
            {
                lblCrustValue.Text = "Thin Crust";
            }
            else if (rdCheesy.Checked)
            {
                lblCrustValue.Text = "Cheesy Crust";
            }
        }
        private void UpdateSize()
        {
            UpdatePrice();
            if (rdSmall.Checked)
            {
                grpSize.Tag = "Small";
                lblSizeValue.Text = (grpSize.Tag).ToString();
            }
            else if (rdMed.Checked)
            {
                grpSize.Tag = "Meduim";
                lblSizeValue.Text = (grpSize.Tag).ToString();
            }
            else if (rdLarg.Checked)
            {
                grpSize.Tag = "Large";
                lblSizeValue.Text = (grpSize.Tag).ToString();
            }
        }
        private void UpdateToppings()
        {
            UpdatePrice();
            generateToppingsValue();
        }
        private void UpdateWhereToEat()
        {
            if (rdDineIn.Checked)
            {
                lblWhereToEatValue.Text = "Dine In";
            }
            else if (rdTakeAway.Checked)
            {
                lblWhereToEatValue.Text = "Take Away";
            }
        }
        private void generateToppingsValue()
        {
            string str = "";
            if (chkExtraCheese.Checked)
            {
                str = string.Concat(str, "Extra Cheese,");
            }
            if (chkMushroom.Checked)
            {
                str = string.Concat(str, "Mushroom,");
            }
            if (chkTomatoes.Checked)
            {
                str = string.Concat(str, "Tomatoes,");
            }
            if (chkOnion.Checked)
            {
                str = string.Concat(str, "Onion,");
            }
            if (chkOlives.Checked)
            {
                str = string.Concat(str, "Olives,");
            }
            if (chkPepper.Checked)
            {
                str = string.Concat(str, "Green Pepper,");
            }
            if (chkMeat.Checked)
            {
                str = string.Concat(str, "Meat,");
            }
            if (chkChicken.Checked)
            {
                str = string.Concat(str, "Chicken,");
            }
            if (str.Length > 0)
                str = str.Substring(0, str.Length - 1);
            else
                str = "No Topping";

            lblToppingsValue.Text = str;
        }
        private void rdSmall_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }
        private void rdMed_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }
        private void rdLarg_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }
        private void chkExtraCheese_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }
        private void chkMushroom_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }
        private void chkTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }
        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }
        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }
        private void chkPepper_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }
        private void chkMeat_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }
        private void chkChicken_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void rdThin_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }
        private void rdCheesy_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void rdDineIn_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }
        private void rdTakeAway_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }
        private bool ConfirmOrder()
        {
            return (MessageBox.Show("Please Confirm Your Order!", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK);
        }
        private void DisableForm()
        {
            grpCrust.Enabled = false;
            grpSize.Enabled = false;
            grpTopping.Enabled = false;
            btnOrder.Enabled = false;
            grpWhereToEat.Enabled = false;
        }
        private void LoadForm()
        {
            lblTotalPriceValue.Text = "$5";

            rdSmall.Checked = true;
            grpSize.Tag = "Small";
            lblSizeValue.Text = (grpSize.Tag).ToString();

            rdThin.Checked = true;
            grpCrust.Tag = "Thin Crust";
            lblCrustValue.Text = (grpCrust.Tag).ToString();

            rdTakeAway.Checked = true;
            grpWhereToEat.Tag = "Take Away";
            lblWhereToEatValue.Text = (grpWhereToEat.Tag).ToString();

            chkChicken.Checked = false;
            chkExtraCheese.Checked = false;
            chkMeat.Checked = false;
            chkMushroom.Checked = false;
            chkOlives.Checked = false;
            chkOnion.Checked = false;
            chkPepper.Checked = false;
            chkTomatoes.Checked = false;
        }
        private void EnableForm()
        {
            grpCrust.Enabled = true;
            grpSize.Enabled = true;
            grpTopping.Enabled = true;
            grpWhereToEat.Enabled = true;
            btnOrder.Enabled = true;

        }
        private void ResetForm()
        {
            LoadForm();
            EnableForm();
        }
        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (ConfirmOrder())
            {
                MessageBox.Show("Your Order Placed Successfuly", "Successful Order",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                DisableForm();
            }

        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
    }
}
