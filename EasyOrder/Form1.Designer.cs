namespace EasyOrder
{
    partial class Form1
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpSize = new System.Windows.Forms.GroupBox();
            this.rdLarg = new System.Windows.Forms.RadioButton();
            this.rdMed = new System.Windows.Forms.RadioButton();
            this.rdSmall = new System.Windows.Forms.RadioButton();
            this.grpCrust = new System.Windows.Forms.GroupBox();
            this.rdCheesy = new System.Windows.Forms.RadioButton();
            this.rdThin = new System.Windows.Forms.RadioButton();
            this.grpTopping = new System.Windows.Forms.GroupBox();
            this.chkChicken = new System.Windows.Forms.CheckBox();
            this.chkMeat = new System.Windows.Forms.CheckBox();
            this.chkPepper = new System.Windows.Forms.CheckBox();
            this.chkOlives = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.chkTomatoes = new System.Windows.Forms.CheckBox();
            this.chkMushroom = new System.Windows.Forms.CheckBox();
            this.chkExtraCheese = new System.Windows.Forms.CheckBox();
            this.grpWhereToEat = new System.Windows.Forms.GroupBox();
            this.rdTakeAway = new System.Windows.Forms.RadioButton();
            this.rdDineIn = new System.Windows.Forms.RadioButton();
            this.grpOrderSummary = new System.Windows.Forms.GroupBox();
            this.lblTotalPriceValue = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lbLine = new System.Windows.Forms.Label();
            this.lblWhereToEatValue = new System.Windows.Forms.Label();
            this.lblWhereToEat = new System.Windows.Forms.Label();
            this.lblCrustValue = new System.Windows.Forms.Label();
            this.lblCrustType = new System.Windows.Forms.Label();
            this.lblToppings = new System.Windows.Forms.Label();
            this.lblSizeValue = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblToppingsValue = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.grpSize.SuspendLayout();
            this.grpCrust.SuspendLayout();
            this.grpTopping.SuspendLayout();
            this.grpWhereToEat.SuspendLayout();
            this.grpOrderSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.Font = new System.Drawing.Font("Segoe Print", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTitle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTitle.Location = new System.Drawing.Point(263, -2);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(393, 100);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Easy Order ";
            // 
            // grpSize
            // 
            this.grpSize.Controls.Add(this.rdLarg);
            this.grpSize.Controls.Add(this.rdMed);
            this.grpSize.Controls.Add(this.rdSmall);
            this.grpSize.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSize.Location = new System.Drawing.Point(93, 128);
            this.grpSize.Margin = new System.Windows.Forms.Padding(2);
            this.grpSize.Name = "grpSize";
            this.grpSize.Padding = new System.Windows.Forms.Padding(2);
            this.grpSize.Size = new System.Drawing.Size(150, 147);
            this.grpSize.TabIndex = 1;
            this.grpSize.TabStop = false;
            this.grpSize.Text = "Size";
            // 
            // rdLarg
            // 
            this.rdLarg.AutoSize = true;
            this.rdLarg.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdLarg.Location = new System.Drawing.Point(21, 95);
            this.rdLarg.Margin = new System.Windows.Forms.Padding(2);
            this.rdLarg.Name = "rdLarg";
            this.rdLarg.Size = new System.Drawing.Size(73, 27);
            this.rdLarg.TabIndex = 2;
            this.rdLarg.TabStop = true;
            this.rdLarg.Tag = "10";
            this.rdLarg.Text = "Large";
            this.rdLarg.UseVisualStyleBackColor = true;
            this.rdLarg.CheckedChanged += new System.EventHandler(this.rdLarg_CheckedChanged);
            // 
            // rdMed
            // 
            this.rdMed.AutoSize = true;
            this.rdMed.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdMed.Location = new System.Drawing.Point(21, 61);
            this.rdMed.Margin = new System.Windows.Forms.Padding(2);
            this.rdMed.Name = "rdMed";
            this.rdMed.Size = new System.Drawing.Size(91, 27);
            this.rdMed.TabIndex = 1;
            this.rdMed.TabStop = true;
            this.rdMed.Tag = "7";
            this.rdMed.Text = "Meduim";
            this.rdMed.UseVisualStyleBackColor = true;
            this.rdMed.CheckedChanged += new System.EventHandler(this.rdMed_CheckedChanged);
            // 
            // rdSmall
            // 
            this.rdSmall.AutoSize = true;
            this.rdSmall.Checked = true;
            this.rdSmall.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdSmall.Location = new System.Drawing.Point(21, 26);
            this.rdSmall.Margin = new System.Windows.Forms.Padding(2);
            this.rdSmall.Name = "rdSmall";
            this.rdSmall.Size = new System.Drawing.Size(68, 27);
            this.rdSmall.TabIndex = 0;
            this.rdSmall.TabStop = true;
            this.rdSmall.Tag = "5";
            this.rdSmall.Text = "Small";
            this.rdSmall.UseVisualStyleBackColor = true;
            this.rdSmall.CheckedChanged += new System.EventHandler(this.rdSmall_CheckedChanged);
            // 
            // grpCrust
            // 
            this.grpCrust.Controls.Add(this.rdCheesy);
            this.grpCrust.Controls.Add(this.rdThin);
            this.grpCrust.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCrust.Location = new System.Drawing.Point(93, 288);
            this.grpCrust.Margin = new System.Windows.Forms.Padding(2);
            this.grpCrust.Name = "grpCrust";
            this.grpCrust.Padding = new System.Windows.Forms.Padding(2);
            this.grpCrust.Size = new System.Drawing.Size(150, 107);
            this.grpCrust.TabIndex = 3;
            this.grpCrust.TabStop = false;
            this.grpCrust.Text = "Crust Type";
            // 
            // rdCheesy
            // 
            this.rdCheesy.AutoSize = true;
            this.rdCheesy.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdCheesy.Location = new System.Drawing.Point(21, 61);
            this.rdCheesy.Margin = new System.Windows.Forms.Padding(2);
            this.rdCheesy.Name = "rdCheesy";
            this.rdCheesy.Size = new System.Drawing.Size(83, 27);
            this.rdCheesy.TabIndex = 1;
            this.rdCheesy.TabStop = true;
            this.rdCheesy.Tag = "2";
            this.rdCheesy.Text = "Cheesy";
            this.rdCheesy.UseVisualStyleBackColor = true;
            this.rdCheesy.CheckedChanged += new System.EventHandler(this.rdCheesy_CheckedChanged);
            // 
            // rdThin
            // 
            this.rdThin.AutoSize = true;
            this.rdThin.Checked = true;
            this.rdThin.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdThin.Location = new System.Drawing.Point(21, 26);
            this.rdThin.Margin = new System.Windows.Forms.Padding(2);
            this.rdThin.Name = "rdThin";
            this.rdThin.Size = new System.Drawing.Size(114, 27);
            this.rdThin.TabIndex = 0;
            this.rdThin.TabStop = true;
            this.rdThin.Tag = "0";
            this.rdThin.Text = "Thin Crust";
            this.rdThin.UseVisualStyleBackColor = true;
            this.rdThin.CheckedChanged += new System.EventHandler(this.rdThin_CheckedChanged);
            // 
            // grpTopping
            // 
            this.grpTopping.Controls.Add(this.chkChicken);
            this.grpTopping.Controls.Add(this.chkMeat);
            this.grpTopping.Controls.Add(this.chkPepper);
            this.grpTopping.Controls.Add(this.chkOlives);
            this.grpTopping.Controls.Add(this.chkOnion);
            this.grpTopping.Controls.Add(this.chkTomatoes);
            this.grpTopping.Controls.Add(this.chkMushroom);
            this.grpTopping.Controls.Add(this.chkExtraCheese);
            this.grpTopping.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTopping.Location = new System.Drawing.Point(280, 128);
            this.grpTopping.Margin = new System.Windows.Forms.Padding(2);
            this.grpTopping.Name = "grpTopping";
            this.grpTopping.Padding = new System.Windows.Forms.Padding(2);
            this.grpTopping.Size = new System.Drawing.Size(184, 267);
            this.grpTopping.TabIndex = 4;
            this.grpTopping.TabStop = false;
            this.grpTopping.Tag = "0";
            this.grpTopping.Text = "Toppings";
            // 
            // chkChicken
            // 
            this.chkChicken.AutoSize = true;
            this.chkChicken.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkChicken.Location = new System.Drawing.Point(21, 236);
            this.chkChicken.Margin = new System.Windows.Forms.Padding(2);
            this.chkChicken.Name = "chkChicken";
            this.chkChicken.Size = new System.Drawing.Size(94, 27);
            this.chkChicken.TabIndex = 7;
            this.chkChicken.Tag = ".25";
            this.chkChicken.Text = "Chicken";
            this.chkChicken.UseVisualStyleBackColor = true;
            this.chkChicken.CheckedChanged += new System.EventHandler(this.chkChicken_CheckedChanged);
            // 
            // chkMeat
            // 
            this.chkMeat.AutoSize = true;
            this.chkMeat.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMeat.Location = new System.Drawing.Point(21, 210);
            this.chkMeat.Margin = new System.Windows.Forms.Padding(2);
            this.chkMeat.Name = "chkMeat";
            this.chkMeat.Size = new System.Drawing.Size(72, 27);
            this.chkMeat.TabIndex = 6;
            this.chkMeat.Tag = ".25";
            this.chkMeat.Text = "Meat";
            this.chkMeat.UseVisualStyleBackColor = true;
            this.chkMeat.CheckedChanged += new System.EventHandler(this.chkMeat_CheckedChanged);
            // 
            // chkPepper
            // 
            this.chkPepper.AutoSize = true;
            this.chkPepper.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPepper.Location = new System.Drawing.Point(21, 182);
            this.chkPepper.Margin = new System.Windows.Forms.Padding(2);
            this.chkPepper.Name = "chkPepper";
            this.chkPepper.Size = new System.Drawing.Size(143, 27);
            this.chkPepper.TabIndex = 5;
            this.chkPepper.Tag = ".2";
            this.chkPepper.Text = "Green Peppers";
            this.chkPepper.UseVisualStyleBackColor = true;
            this.chkPepper.CheckedChanged += new System.EventHandler(this.chkPepper_CheckedChanged);
            // 
            // chkOlives
            // 
            this.chkOlives.AutoSize = true;
            this.chkOlives.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOlives.Location = new System.Drawing.Point(22, 151);
            this.chkOlives.Margin = new System.Windows.Forms.Padding(2);
            this.chkOlives.Name = "chkOlives";
            this.chkOlives.Size = new System.Drawing.Size(76, 27);
            this.chkOlives.TabIndex = 4;
            this.chkOlives.Tag = ".2";
            this.chkOlives.Text = "Olives";
            this.chkOlives.UseVisualStyleBackColor = true;
            this.chkOlives.CheckedChanged += new System.EventHandler(this.chkOlives_CheckedChanged);
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOnion.Location = new System.Drawing.Point(22, 121);
            this.chkOnion.Margin = new System.Windows.Forms.Padding(2);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(77, 27);
            this.chkOnion.TabIndex = 3;
            this.chkOnion.Tag = ".2";
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = true;
            this.chkOnion.CheckedChanged += new System.EventHandler(this.chkOnion_CheckedChanged);
            // 
            // chkTomatoes
            // 
            this.chkTomatoes.AutoSize = true;
            this.chkTomatoes.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTomatoes.Location = new System.Drawing.Point(22, 89);
            this.chkTomatoes.Margin = new System.Windows.Forms.Padding(2);
            this.chkTomatoes.Name = "chkTomatoes";
            this.chkTomatoes.Size = new System.Drawing.Size(107, 27);
            this.chkTomatoes.TabIndex = 2;
            this.chkTomatoes.Tag = ".1";
            this.chkTomatoes.Text = "Tomatoes";
            this.chkTomatoes.UseVisualStyleBackColor = true;
            this.chkTomatoes.CheckedChanged += new System.EventHandler(this.chkTomatoes_CheckedChanged);
            // 
            // chkMushroom
            // 
            this.chkMushroom.AutoSize = true;
            this.chkMushroom.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMushroom.Location = new System.Drawing.Point(22, 58);
            this.chkMushroom.Margin = new System.Windows.Forms.Padding(2);
            this.chkMushroom.Name = "chkMushroom";
            this.chkMushroom.Size = new System.Drawing.Size(120, 27);
            this.chkMushroom.TabIndex = 1;
            this.chkMushroom.Tag = ".2";
            this.chkMushroom.Text = "Mushrooms";
            this.chkMushroom.UseVisualStyleBackColor = true;
            this.chkMushroom.CheckedChanged += new System.EventHandler(this.chkMushroom_CheckedChanged);
            // 
            // chkExtraCheese
            // 
            this.chkExtraCheese.AutoSize = true;
            this.chkExtraCheese.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkExtraCheese.Location = new System.Drawing.Point(22, 27);
            this.chkExtraCheese.Margin = new System.Windows.Forms.Padding(2);
            this.chkExtraCheese.Name = "chkExtraCheese";
            this.chkExtraCheese.Size = new System.Drawing.Size(135, 27);
            this.chkExtraCheese.TabIndex = 0;
            this.chkExtraCheese.Tag = ".1";
            this.chkExtraCheese.Text = "Extra Cheese";
            this.chkExtraCheese.UseVisualStyleBackColor = true;
            this.chkExtraCheese.CheckedChanged += new System.EventHandler(this.chkExtraCheese_CheckedChanged);
            // 
            // grpWhereToEat
            // 
            this.grpWhereToEat.Controls.Add(this.rdTakeAway);
            this.grpWhereToEat.Controls.Add(this.rdDineIn);
            this.grpWhereToEat.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpWhereToEat.Location = new System.Drawing.Point(93, 401);
            this.grpWhereToEat.Margin = new System.Windows.Forms.Padding(2);
            this.grpWhereToEat.Name = "grpWhereToEat";
            this.grpWhereToEat.Padding = new System.Windows.Forms.Padding(2);
            this.grpWhereToEat.Size = new System.Drawing.Size(371, 64);
            this.grpWhereToEat.TabIndex = 4;
            this.grpWhereToEat.TabStop = false;
            this.grpWhereToEat.Text = "Where to Eat";
            // 
            // rdTakeAway
            // 
            this.rdTakeAway.AutoSize = true;
            this.rdTakeAway.Checked = true;
            this.rdTakeAway.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdTakeAway.Location = new System.Drawing.Point(21, 33);
            this.rdTakeAway.Margin = new System.Windows.Forms.Padding(2);
            this.rdTakeAway.Name = "rdTakeAway";
            this.rdTakeAway.Size = new System.Drawing.Size(115, 27);
            this.rdTakeAway.TabIndex = 1;
            this.rdTakeAway.TabStop = true;
            this.rdTakeAway.Text = "Take Away";
            this.rdTakeAway.UseVisualStyleBackColor = true;
            this.rdTakeAway.CheckedChanged += new System.EventHandler(this.rdTakeAway_CheckedChanged);
            // 
            // rdDineIn
            // 
            this.rdDineIn.AutoSize = true;
            this.rdDineIn.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdDineIn.Location = new System.Drawing.Point(166, 33);
            this.rdDineIn.Margin = new System.Windows.Forms.Padding(2);
            this.rdDineIn.Name = "rdDineIn";
            this.rdDineIn.Size = new System.Drawing.Size(86, 27);
            this.rdDineIn.TabIndex = 0;
            this.rdDineIn.Tag = "2";
            this.rdDineIn.Text = "Dine In";
            this.rdDineIn.UseVisualStyleBackColor = true;
            this.rdDineIn.CheckedChanged += new System.EventHandler(this.rdDineIn_CheckedChanged);
            // 
            // grpOrderSummary
            // 
            this.grpOrderSummary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.grpOrderSummary.Controls.Add(this.lblTotalPriceValue);
            this.grpOrderSummary.Controls.Add(this.lblTotalPrice);
            this.grpOrderSummary.Controls.Add(this.lbLine);
            this.grpOrderSummary.Controls.Add(this.lblWhereToEatValue);
            this.grpOrderSummary.Controls.Add(this.lblWhereToEat);
            this.grpOrderSummary.Controls.Add(this.lblCrustValue);
            this.grpOrderSummary.Controls.Add(this.lblCrustType);
            this.grpOrderSummary.Controls.Add(this.lblToppings);
            this.grpOrderSummary.Controls.Add(this.lblSizeValue);
            this.grpOrderSummary.Controls.Add(this.lblSize);
            this.grpOrderSummary.Controls.Add(this.lblToppingsValue);
            this.grpOrderSummary.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpOrderSummary.Location = new System.Drawing.Point(482, 140);
            this.grpOrderSummary.Margin = new System.Windows.Forms.Padding(2);
            this.grpOrderSummary.Name = "grpOrderSummary";
            this.grpOrderSummary.Padding = new System.Windows.Forms.Padding(2);
            this.grpOrderSummary.Size = new System.Drawing.Size(315, 325);
            this.grpOrderSummary.TabIndex = 5;
            this.grpOrderSummary.TabStop = false;
            this.grpOrderSummary.Text = "Order Summary";
            // 
            // lblTotalPriceValue
            // 
            this.lblTotalPriceValue.AutoSize = true;
            this.lblTotalPriceValue.Font = new System.Drawing.Font("Kristen ITC", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPriceValue.ForeColor = System.Drawing.Color.Tomato;
            this.lblTotalPriceValue.Location = new System.Drawing.Point(137, 241);
            this.lblTotalPriceValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalPriceValue.Name = "lblTotalPriceValue";
            this.lblTotalPriceValue.Size = new System.Drawing.Size(73, 65);
            this.lblTotalPriceValue.TabIndex = 10;
            this.lblTotalPriceValue.Text = "$5";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(11, 241);
            this.lblTotalPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(122, 23);
            this.lblTotalPrice.TabIndex = 9;
            this.lblTotalPrice.Text = "Total Price :";
            // 
            // lbLine
            // 
            this.lbLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbLine.Location = new System.Drawing.Point(13, 232);
            this.lbLine.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbLine.Name = "lbLine";
            this.lbLine.Size = new System.Drawing.Size(298, 2);
            this.lbLine.TabIndex = 8;
            // 
            // lblWhereToEatValue
            // 
            this.lblWhereToEatValue.AutoSize = true;
            this.lblWhereToEatValue.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhereToEatValue.Location = new System.Drawing.Point(152, 104);
            this.lblWhereToEatValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWhereToEatValue.Name = "lblWhereToEatValue";
            this.lblWhereToEatValue.Size = new System.Drawing.Size(97, 23);
            this.lblWhereToEatValue.TabIndex = 7;
            this.lblWhereToEatValue.Text = "Take Away";
            // 
            // lblWhereToEat
            // 
            this.lblWhereToEat.AutoSize = true;
            this.lblWhereToEat.Location = new System.Drawing.Point(8, 104);
            this.lblWhereToEat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWhereToEat.Name = "lblWhereToEat";
            this.lblWhereToEat.Size = new System.Drawing.Size(144, 23);
            this.lblWhereToEat.TabIndex = 6;
            this.lblWhereToEat.Text = "Where To Eat :";
            // 
            // lblCrustValue
            // 
            this.lblCrustValue.AutoSize = true;
            this.lblCrustValue.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrustValue.Location = new System.Drawing.Point(127, 70);
            this.lblCrustValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCrustValue.Name = "lblCrustValue";
            this.lblCrustValue.Size = new System.Drawing.Size(96, 23);
            this.lblCrustValue.TabIndex = 5;
            this.lblCrustValue.Text = "Thin Crust";
            // 
            // lblCrustType
            // 
            this.lblCrustType.AutoSize = true;
            this.lblCrustType.Location = new System.Drawing.Point(8, 70);
            this.lblCrustType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCrustType.Name = "lblCrustType";
            this.lblCrustType.Size = new System.Drawing.Size(119, 23);
            this.lblCrustType.TabIndex = 4;
            this.lblCrustType.Text = "Crust Type :";
            // 
            // lblToppings
            // 
            this.lblToppings.AutoSize = true;
            this.lblToppings.Location = new System.Drawing.Point(8, 138);
            this.lblToppings.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(99, 23);
            this.lblToppings.TabIndex = 2;
            this.lblToppings.Text = "Toppings: ";
            // 
            // lblSizeValue
            // 
            this.lblSizeValue.AutoSize = true;
            this.lblSizeValue.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSizeValue.Location = new System.Drawing.Point(69, 36);
            this.lblSizeValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSizeValue.Name = "lblSizeValue";
            this.lblSizeValue.Size = new System.Drawing.Size(50, 23);
            this.lblSizeValue.TabIndex = 1;
            this.lblSizeValue.Text = "Small";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(11, 36);
            this.lblSize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(57, 23);
            this.lblSize.TabIndex = 0;
            this.lblSize.Text = "Size :";
            // 
            // lblToppingsValue
            // 
            this.lblToppingsValue.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToppingsValue.Location = new System.Drawing.Point(11, 162);
            this.lblToppingsValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblToppingsValue.Name = "lblToppingsValue";
            this.lblToppingsValue.Size = new System.Drawing.Size(298, 69);
            this.lblToppingsValue.TabIndex = 3;
            this.lblToppingsValue.Text = " No Topping";
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.Coral;
            this.btnOrder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOrder.Location = new System.Drawing.Point(640, 34);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(157, 45);
            this.btnOrder.TabIndex = 6;
            this.btnOrder.Text = "Order Pizza 🍕";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Gainsboro;
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnReset.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReset.Location = new System.Drawing.Point(93, 34);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(166, 45);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset Form";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 507);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.grpWhereToEat);
            this.Controls.Add(this.grpTopping);
            this.Controls.Add(this.grpCrust);
            this.Controls.Add(this.grpSize);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grpOrderSummary);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpSize.ResumeLayout(false);
            this.grpSize.PerformLayout();
            this.grpCrust.ResumeLayout(false);
            this.grpCrust.PerformLayout();
            this.grpTopping.ResumeLayout(false);
            this.grpTopping.PerformLayout();
            this.grpWhereToEat.ResumeLayout(false);
            this.grpWhereToEat.PerformLayout();
            this.grpOrderSummary.ResumeLayout(false);
            this.grpOrderSummary.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpSize;
        private System.Windows.Forms.RadioButton rdLarg;
        private System.Windows.Forms.RadioButton rdMed;
        private System.Windows.Forms.RadioButton rdSmall;
        private System.Windows.Forms.GroupBox grpCrust;
        private System.Windows.Forms.RadioButton rdCheesy;
        private System.Windows.Forms.RadioButton rdThin;
        private System.Windows.Forms.GroupBox grpTopping;
        private System.Windows.Forms.CheckBox chkExtraCheese;
        private System.Windows.Forms.CheckBox chkTomatoes;
        private System.Windows.Forms.CheckBox chkMushroom;
        private System.Windows.Forms.CheckBox chkPepper;
        private System.Windows.Forms.CheckBox chkOlives;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.GroupBox grpWhereToEat;
        private System.Windows.Forms.RadioButton rdTakeAway;
        private System.Windows.Forms.RadioButton rdDineIn;
        private System.Windows.Forms.GroupBox grpOrderSummary;
        private System.Windows.Forms.CheckBox chkChicken;
        private System.Windows.Forms.CheckBox chkMeat;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblSizeValue;
        private System.Windows.Forms.Label lblToppings;
        private System.Windows.Forms.Label lblToppingsValue;
        private System.Windows.Forms.Label lblCrustType;
        private System.Windows.Forms.Label lblCrustValue;
        private System.Windows.Forms.Label lblWhereToEatValue;
        private System.Windows.Forms.Label lblWhereToEat;
        private System.Windows.Forms.Label lbLine;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblTotalPriceValue;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnReset;
    }
}

