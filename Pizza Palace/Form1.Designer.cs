namespace _3__Pizza_Project
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.rbMadium = new System.Windows.Forms.RadioButton();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.rbThin = new System.Windows.Forms.RadioButton();
            this.rbThink = new System.Windows.Forms.RadioButton();
            this.gbCrust = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkExtraChees = new System.Windows.Forms.CheckBox();
            this.chkMashrooms = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.chkgreenPappers = new System.Windows.Forms.CheckBox();
            this.chkOlives = new System.Windows.Forms.CheckBox();
            this.chkTomatoes = new System.Windows.Forms.CheckBox();
            this.gbToppings = new System.Windows.Forms.GroupBox();
            this.gbWhereToEat = new System.Windows.Forms.GroupBox();
            this.rbTakeout = new System.Windows.Forms.RadioButton();
            this.rbEatin = new System.Windows.Forms.RadioButton();
            this.btOrderPizza = new System.Windows.Forms.Button();
            this.btResetForm = new System.Windows.Forms.Button();
            this.gbOrderSummaty = new System.Windows.Forms.GroupBox();
            this.lbTextOfEatin = new System.Windows.Forms.Label();
            this.lbTextOfCrust = new System.Windows.Forms.Label();
            this.lbTextOfSize = new System.Windows.Forms.Label();
            this.lbNoToppings = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTotalPrice = new System.Windows.Forms.Label();
            this.lbWhereToEat = new System.Windows.Forms.Label();
            this.lbCrustType = new System.Windows.Forms.Label();
            this.lbToppings = new System.Windows.Forms.Label();
            this.lbSize = new System.Windows.Forms.Label();
            this.gbSize.SuspendLayout();
            this.gbCrust.SuspendLayout();
            this.gbToppings.SuspendLayout();
            this.gbWhereToEat.SuspendLayout();
            this.gbOrderSummaty.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.BackColor = System.Drawing.Color.Transparent;
            this.rbSmall.Location = new System.Drawing.Point(43, 45);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(80, 26);
            this.rbSmall.TabIndex = 0;
            this.rbSmall.Tag = "20";
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = false;
            this.rbSmall.CheckedChanged += new System.EventHandler(this.rbSamll_CheckedChanged);
            // 
            // rbMadium
            // 
            this.rbMadium.AutoSize = true;
            this.rbMadium.Checked = true;
            this.rbMadium.Location = new System.Drawing.Point(43, 106);
            this.rbMadium.Name = "rbMadium";
            this.rbMadium.Size = new System.Drawing.Size(99, 26);
            this.rbMadium.TabIndex = 1;
            this.rbMadium.TabStop = true;
            this.rbMadium.Tag = "30";
            this.rbMadium.Text = "Medium";
            this.rbMadium.UseVisualStyleBackColor = true;
            this.rbMadium.CheckedChanged += new System.EventHandler(this.rbMedium_CheckedChanged);
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.Location = new System.Drawing.Point(42, 167);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(82, 26);
            this.rbLarge.TabIndex = 2;
            this.rbLarge.Tag = "40";
            this.rbLarge.Text = "Large";
            this.rbLarge.UseVisualStyleBackColor = true;
            this.rbLarge.CheckedChanged += new System.EventHandler(this.rbLarge_CheckedChanged);
            // 
            // gbSize
            // 
            this.gbSize.BackColor = System.Drawing.Color.Transparent;
            this.gbSize.Controls.Add(this.rbSmall);
            this.gbSize.Controls.Add(this.rbLarge);
            this.gbSize.Controls.Add(this.rbMadium);
            this.gbSize.Cursor = System.Windows.Forms.Cursors.Default;
            this.gbSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSize.ForeColor = System.Drawing.Color.DarkOrange;
            this.gbSize.Location = new System.Drawing.Point(69, 271);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(240, 220);
            this.gbSize.TabIndex = 3;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Size";
            // 
            // rbThin
            // 
            this.rbThin.AutoSize = true;
            this.rbThin.Checked = true;
            this.rbThin.Location = new System.Drawing.Point(31, 53);
            this.rbThin.Name = "rbThin";
            this.rbThin.Size = new System.Drawing.Size(125, 26);
            this.rbThin.TabIndex = 4;
            this.rbThin.TabStop = true;
            this.rbThin.Tag = "0";
            this.rbThin.Text = "Thin Crust";
            this.rbThin.UseVisualStyleBackColor = true;
            this.rbThin.CheckedChanged += new System.EventHandler(this.rbThinCrust_CheckedChanged);
            // 
            // rbThink
            // 
            this.rbThink.AutoSize = true;
            this.rbThink.Location = new System.Drawing.Point(31, 101);
            this.rbThink.Name = "rbThink";
            this.rbThink.Size = new System.Drawing.Size(134, 26);
            this.rbThink.TabIndex = 5;
            this.rbThink.Tag = "10";
            this.rbThink.Text = "Thick Crust";
            this.rbThink.UseVisualStyleBackColor = true;
            this.rbThink.CheckedChanged += new System.EventHandler(this.rbThickCrust_CheckedChanged);
            // 
            // gbCrust
            // 
            this.gbCrust.BackColor = System.Drawing.Color.Transparent;
            this.gbCrust.Controls.Add(this.rbThin);
            this.gbCrust.Controls.Add(this.rbThink);
            this.gbCrust.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCrust.ForeColor = System.Drawing.Color.DarkOrange;
            this.gbCrust.Location = new System.Drawing.Point(69, 647);
            this.gbCrust.Name = "gbCrust";
            this.gbCrust.Size = new System.Drawing.Size(240, 174);
            this.gbCrust.TabIndex = 6;
            this.gbCrust.TabStop = false;
            this.gbCrust.Text = "Crust";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Pristina", 88.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(200, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(955, 193);
            this.label1.TabIndex = 7;
            this.label1.Text = "Make Your Pizza";
            // 
            // chkExtraChees
            // 
            this.chkExtraChees.AutoSize = true;
            this.chkExtraChees.Location = new System.Drawing.Point(21, 46);
            this.chkExtraChees.Name = "chkExtraChees";
            this.chkExtraChees.Size = new System.Drawing.Size(142, 26);
            this.chkExtraChees.TabIndex = 8;
            this.chkExtraChees.Tag = "5";
            this.chkExtraChees.Text = "Extra Chees";
            this.chkExtraChees.UseVisualStyleBackColor = true;
            this.chkExtraChees.CheckedChanged += new System.EventHandler(this.chkExtraChees_CheckedChanged);
            // 
            // chkMashrooms
            // 
            this.chkMashrooms.AutoSize = true;
            this.chkMashrooms.Location = new System.Drawing.Point(21, 107);
            this.chkMashrooms.Name = "chkMashrooms";
            this.chkMashrooms.Size = new System.Drawing.Size(133, 26);
            this.chkMashrooms.TabIndex = 9;
            this.chkMashrooms.Tag = "5";
            this.chkMashrooms.Text = "Mushrooms";
            this.chkMashrooms.UseVisualStyleBackColor = true;
            this.chkMashrooms.CheckedChanged += new System.EventHandler(this.chkMushrooms_CheckedChanged);
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.Location = new System.Drawing.Point(196, 46);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(85, 26);
            this.chkOnion.TabIndex = 10;
            this.chkOnion.Tag = "5";
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = true;
            this.chkOnion.CheckedChanged += new System.EventHandler(this.chkOnion_CheckedChanged);
            // 
            // chkgreenPappers
            // 
            this.chkgreenPappers.AutoSize = true;
            this.chkgreenPappers.Location = new System.Drawing.Point(196, 168);
            this.chkgreenPappers.Name = "chkgreenPappers";
            this.chkgreenPappers.Size = new System.Drawing.Size(167, 26);
            this.chkgreenPappers.TabIndex = 11;
            this.chkgreenPappers.Tag = "5";
            this.chkgreenPappers.Text = "Green Pappers";
            this.chkgreenPappers.UseVisualStyleBackColor = true;
            this.chkgreenPappers.CheckedChanged += new System.EventHandler(this.chckGreenPeppers_CheckedChanged);
            // 
            // chkOlives
            // 
            this.chkOlives.AutoSize = true;
            this.chkOlives.Location = new System.Drawing.Point(196, 107);
            this.chkOlives.Name = "chkOlives";
            this.chkOlives.Size = new System.Drawing.Size(88, 26);
            this.chkOlives.TabIndex = 12;
            this.chkOlives.Tag = "5";
            this.chkOlives.Text = "Olives";
            this.chkOlives.UseVisualStyleBackColor = true;
            this.chkOlives.CheckedChanged += new System.EventHandler(this.chkOlives_CheckedChanged);
            // 
            // chkTomatoes
            // 
            this.chkTomatoes.AutoSize = true;
            this.chkTomatoes.Location = new System.Drawing.Point(21, 168);
            this.chkTomatoes.Name = "chkTomatoes";
            this.chkTomatoes.Size = new System.Drawing.Size(120, 26);
            this.chkTomatoes.TabIndex = 13;
            this.chkTomatoes.Tag = "5";
            this.chkTomatoes.Text = "Tomatoes";
            this.chkTomatoes.UseVisualStyleBackColor = true;
            this.chkTomatoes.CheckedChanged += new System.EventHandler(this.chkTomatos_CheckedChanged);
            // 
            // gbToppings
            // 
            this.gbToppings.BackColor = System.Drawing.Color.Transparent;
            this.gbToppings.Controls.Add(this.chkOnion);
            this.gbToppings.Controls.Add(this.chkTomatoes);
            this.gbToppings.Controls.Add(this.chkExtraChees);
            this.gbToppings.Controls.Add(this.chkOlives);
            this.gbToppings.Controls.Add(this.chkMashrooms);
            this.gbToppings.Controls.Add(this.chkgreenPappers);
            this.gbToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbToppings.ForeColor = System.Drawing.Color.DarkOrange;
            this.gbToppings.Location = new System.Drawing.Point(399, 271);
            this.gbToppings.Name = "gbToppings";
            this.gbToppings.Size = new System.Drawing.Size(381, 220);
            this.gbToppings.TabIndex = 14;
            this.gbToppings.TabStop = false;
            this.gbToppings.Text = "Toppings";
            // 
            // gbWhereToEat
            // 
            this.gbWhereToEat.BackColor = System.Drawing.Color.Transparent;
            this.gbWhereToEat.Controls.Add(this.rbTakeout);
            this.gbWhereToEat.Controls.Add(this.rbEatin);
            this.gbWhereToEat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbWhereToEat.ForeColor = System.Drawing.Color.DarkOrange;
            this.gbWhereToEat.Location = new System.Drawing.Point(399, 647);
            this.gbWhereToEat.Name = "gbWhereToEat";
            this.gbWhereToEat.Size = new System.Drawing.Size(381, 174);
            this.gbWhereToEat.TabIndex = 15;
            this.gbWhereToEat.TabStop = false;
            this.gbWhereToEat.Text = "Where To Eat";
            // 
            // rbTakeout
            // 
            this.rbTakeout.AutoSize = true;
            this.rbTakeout.Location = new System.Drawing.Point(34, 101);
            this.rbTakeout.Name = "rbTakeout";
            this.rbTakeout.Size = new System.Drawing.Size(114, 26);
            this.rbTakeout.TabIndex = 1;
            this.rbTakeout.Tag = "0";
            this.rbTakeout.Text = "Take Out";
            this.rbTakeout.UseVisualStyleBackColor = true;
            this.rbTakeout.CheckedChanged += new System.EventHandler(this.rbTakeOut_CheckedChanged);
            // 
            // rbEatin
            // 
            this.rbEatin.AutoSize = true;
            this.rbEatin.Checked = true;
            this.rbEatin.Location = new System.Drawing.Point(34, 53);
            this.rbEatin.Name = "rbEatin";
            this.rbEatin.Size = new System.Drawing.Size(83, 26);
            this.rbEatin.TabIndex = 0;
            this.rbEatin.TabStop = true;
            this.rbEatin.Tag = "5";
            this.rbEatin.Text = "Eat in";
            this.rbEatin.UseVisualStyleBackColor = true;
            this.rbEatin.CheckedChanged += new System.EventHandler(this.rbEatIn_CheckedChanged);
            // 
            // btOrderPizza
            // 
            this.btOrderPizza.BackColor = System.Drawing.Color.DarkOrange;
            this.btOrderPizza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOrderPizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOrderPizza.ForeColor = System.Drawing.Color.Black;
            this.btOrderPizza.Location = new System.Drawing.Point(449, 958);
            this.btOrderPizza.Name = "btOrderPizza";
            this.btOrderPizza.Size = new System.Drawing.Size(169, 70);
            this.btOrderPizza.TabIndex = 16;
            this.btOrderPizza.Text = "Order Pizza";
            this.btOrderPizza.UseVisualStyleBackColor = false;
            this.btOrderPizza.Click += new System.EventHandler(this.btnOrderPizza_Click);
            // 
            // btResetForm
            // 
            this.btResetForm.BackColor = System.Drawing.Color.DarkOrange;
            this.btResetForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btResetForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btResetForm.ForeColor = System.Drawing.Color.Black;
            this.btResetForm.Location = new System.Drawing.Point(880, 958);
            this.btResetForm.Name = "btResetForm";
            this.btResetForm.Size = new System.Drawing.Size(169, 70);
            this.btResetForm.TabIndex = 17;
            this.btResetForm.Text = "Reset Form";
            this.btResetForm.UseVisualStyleBackColor = false;
            this.btResetForm.Click += new System.EventHandler(this.btnResetForm_Click);
            // 
            // gbOrderSummaty
            // 
            this.gbOrderSummaty.BackColor = System.Drawing.Color.Transparent;
            this.gbOrderSummaty.Controls.Add(this.lbTextOfEatin);
            this.gbOrderSummaty.Controls.Add(this.lbTextOfCrust);
            this.gbOrderSummaty.Controls.Add(this.lbTextOfSize);
            this.gbOrderSummaty.Controls.Add(this.lbNoToppings);
            this.gbOrderSummaty.Controls.Add(this.label2);
            this.gbOrderSummaty.Controls.Add(this.lbTotalPrice);
            this.gbOrderSummaty.Controls.Add(this.lbWhereToEat);
            this.gbOrderSummaty.Controls.Add(this.lbCrustType);
            this.gbOrderSummaty.Controls.Add(this.lbToppings);
            this.gbOrderSummaty.Controls.Add(this.lbSize);
            this.gbOrderSummaty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOrderSummaty.ForeColor = System.Drawing.Color.DarkOrange;
            this.gbOrderSummaty.Location = new System.Drawing.Point(869, 271);
            this.gbOrderSummaty.Name = "gbOrderSummaty";
            this.gbOrderSummaty.Size = new System.Drawing.Size(390, 550);
            this.gbOrderSummaty.TabIndex = 18;
            this.gbOrderSummaty.TabStop = false;
            this.gbOrderSummaty.Text = "Order Summary";
            // 
            // lbTextOfEatin
            // 
            this.lbTextOfEatin.AutoSize = true;
            this.lbTextOfEatin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTextOfEatin.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbTextOfEatin.Location = new System.Drawing.Point(36, 319);
            this.lbTextOfEatin.Name = "lbTextOfEatin";
            this.lbTextOfEatin.Size = new System.Drawing.Size(153, 25);
            this.lbTextOfEatin.TabIndex = 9;
            this.lbTextOfEatin.Text = "Where To Eat:";
            // 
            // lbTextOfCrust
            // 
            this.lbTextOfCrust.AutoSize = true;
            this.lbTextOfCrust.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTextOfCrust.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbTextOfCrust.Location = new System.Drawing.Point(36, 252);
            this.lbTextOfCrust.Name = "lbTextOfCrust";
            this.lbTextOfCrust.Size = new System.Drawing.Size(126, 25);
            this.lbTextOfCrust.TabIndex = 8;
            this.lbTextOfCrust.Text = "Crust Type:";
            // 
            // lbTextOfSize
            // 
            this.lbTextOfSize.AutoSize = true;
            this.lbTextOfSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTextOfSize.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbTextOfSize.Location = new System.Drawing.Point(33, 45);
            this.lbTextOfSize.Name = "lbTextOfSize";
            this.lbTextOfSize.Size = new System.Drawing.Size(62, 25);
            this.lbTextOfSize.TabIndex = 7;
            this.lbTextOfSize.Text = "Size:";
            // 
            // lbNoToppings
            // 
            this.lbNoToppings.AutoSize = true;
            this.lbNoToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNoToppings.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbNoToppings.Location = new System.Drawing.Point(33, 117);
            this.lbNoToppings.Name = "lbNoToppings";
            this.lbNoToppings.Size = new System.Drawing.Size(100, 25);
            this.lbNoToppings.TabIndex = 6;
            this.lbNoToppings.Text = "Toppings:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(42, 376);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Total Price:";
            // 
            // lbTotalPrice
            // 
            this.lbTotalPrice.AutoSize = true;
            this.lbTotalPrice.Font = new System.Drawing.Font("Segoe Print", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalPrice.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbTotalPrice.Location = new System.Drawing.Point(164, 410);
            this.lbTotalPrice.Name = "lbTotalPrice";
            this.lbTotalPrice.Size = new System.Drawing.Size(122, 105);
            this.lbTotalPrice.TabIndex = 4;
            this.lbTotalPrice.Text = "$0";
            // 
            // lbWhereToEat
            // 
            this.lbWhereToEat.AutoSize = true;
            this.lbWhereToEat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWhereToEat.ForeColor = System.Drawing.Color.White;
            this.lbWhereToEat.Location = new System.Drawing.Point(205, 319);
            this.lbWhereToEat.Name = "lbWhereToEat";
            this.lbWhereToEat.Size = new System.Drawing.Size(68, 25);
            this.lbWhereToEat.TabIndex = 3;
            this.lbWhereToEat.Text = "Eat In";
            // 
            // lbCrustType
            // 
            this.lbCrustType.AutoSize = true;
            this.lbCrustType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCrustType.ForeColor = System.Drawing.Color.White;
            this.lbCrustType.Location = new System.Drawing.Point(181, 252);
            this.lbCrustType.Name = "lbCrustType";
            this.lbCrustType.Size = new System.Drawing.Size(123, 25);
            this.lbCrustType.TabIndex = 2;
            this.lbCrustType.Text = "Thick Crust";
            // 
            // lbToppings
            // 
            this.lbToppings.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbToppings.ForeColor = System.Drawing.Color.White;
            this.lbToppings.Location = new System.Drawing.Point(86, 167);
            this.lbToppings.Name = "lbToppings";
            this.lbToppings.Size = new System.Drawing.Size(284, 70);
            this.lbToppings.TabIndex = 1;
            this.lbToppings.Text = "No Toppings.\r\n\r\n";
            // 
            // lbSize
            // 
            this.lbSize.AutoSize = true;
            this.lbSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSize.ForeColor = System.Drawing.Color.White;
            this.lbSize.Location = new System.Drawing.Point(130, 45);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(88, 25);
            this.lbSize.TabIndex = 0;
            this.lbSize.Text = "Medium";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1862, 1053);
            this.Controls.Add(this.gbOrderSummaty);
            this.Controls.Add(this.btResetForm);
            this.Controls.Add(this.btOrderPizza);
            this.Controls.Add(this.gbWhereToEat);
            this.Controls.Add(this.gbToppings);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbCrust);
            this.Controls.Add(this.gbSize);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Form1";
            this.Text = "Pizza Order";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.gbCrust.ResumeLayout(false);
            this.gbCrust.PerformLayout();
            this.gbToppings.ResumeLayout(false);
            this.gbToppings.PerformLayout();
            this.gbWhereToEat.ResumeLayout(false);
            this.gbWhereToEat.PerformLayout();
            this.gbOrderSummaty.ResumeLayout(false);
            this.gbOrderSummaty.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.RadioButton rbMadium;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.RadioButton rbThin;
        private System.Windows.Forms.RadioButton rbThink;
        private System.Windows.Forms.GroupBox gbCrust;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkExtraChees;
        private System.Windows.Forms.CheckBox chkMashrooms;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.CheckBox chkgreenPappers;
        private System.Windows.Forms.CheckBox chkOlives;
        private System.Windows.Forms.CheckBox chkTomatoes;
        private System.Windows.Forms.GroupBox gbToppings;
        private System.Windows.Forms.GroupBox gbWhereToEat;
        private System.Windows.Forms.RadioButton rbTakeout;
        private System.Windows.Forms.RadioButton rbEatin;
        private System.Windows.Forms.Button btOrderPizza;
        private System.Windows.Forms.Button btResetForm;
        private System.Windows.Forms.GroupBox gbOrderSummaty;
        private System.Windows.Forms.Label lbSize;
        private System.Windows.Forms.Label lbToppings;
        private System.Windows.Forms.Label lbWhereToEat;
        private System.Windows.Forms.Label lbCrustType;
        private System.Windows.Forms.Label lbTotalPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbNoToppings;
        private System.Windows.Forms.Label lbTextOfSize;
        private System.Windows.Forms.Label lbTextOfEatin;
        private System.Windows.Forms.Label lbTextOfCrust;
    }
}

