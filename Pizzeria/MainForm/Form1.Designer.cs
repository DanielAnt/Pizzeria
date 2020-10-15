using System.Threading;
using System;

namespace Pizzeria
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.firstPizzaLabel = new System.Windows.Forms.Label();
            this.secondPizzaLabel = new System.Windows.Forms.Label();
            this.pizzaLabel = new System.Windows.Forms.Label();
            this.mainDishLabel = new System.Windows.Forms.Label();
            this.soupLabel = new System.Windows.Forms.Label();
            this.drinksLabel = new System.Windows.Forms.Label();
            this.thirdPizzaLabel = new System.Windows.Forms.Label();
            this.fourthPizzaLabel = new System.Windows.Forms.Label();
            this.firstMainDishLabel = new System.Windows.Forms.Label();
            this.secondMainDishLabel = new System.Windows.Forms.Label();
            this.thirdMainDishLabel = new System.Windows.Forms.Label();
            this.firstSoupLabel = new System.Windows.Forms.Label();
            this.secondSoupLabel = new System.Windows.Forms.Label();
            this.firstDrinkLabel = new System.Windows.Forms.Label();
            this.secondDrinkLabel = new System.Windows.Forms.Label();
            this.thirdDrinkLabel = new System.Windows.Forms.Label();
            this.firstPizzaButton = new System.Windows.Forms.Button();
            this.secondPizzaButton = new System.Windows.Forms.Button();
            this.thirdPizzaButton = new System.Windows.Forms.Button();
            this.fourthPizzaButton = new System.Windows.Forms.Button();
            this.firstMainDishButton = new System.Windows.Forms.Button();
            this.secondMainDishButton = new System.Windows.Forms.Button();
            this.thirdMainDishButton = new System.Windows.Forms.Button();
            this.firstSoupButton = new System.Windows.Forms.Button();
            this.secondSoupButton = new System.Windows.Forms.Button();
            this.firstDrinkButton = new System.Windows.Forms.Button();
            this.secondDrinkButton = new System.Windows.Forms.Button();
            this.thirdDrinkButton = new System.Windows.Forms.Button();
            this.basketLabel = new System.Windows.Forms.Label();
            this.commentsTextbox = new System.Windows.Forms.TextBox();
            this.commentsLabel = new System.Windows.Forms.Label();
            this.orderListbox = new System.Windows.Forms.ListBox();
            this.orderLabel = new System.Windows.Forms.Label();
            this.deleteDishButton = new System.Windows.Forms.Button();
            this.decreaseDishQuantityButton = new System.Windows.Forms.Button();
            this.increaseDishQuantityButton = new System.Windows.Forms.Button();
            this.confirmOrderButton = new System.Windows.Forms.Button();
            this.toPayLabel = new System.Windows.Forms.Label();
            this.TotalPriceLabel = new System.Windows.Forms.Label();
            this.orderHistoryButton = new System.Windows.Forms.Button();
            this.configButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstPizzaLabel
            // 
            this.firstPizzaLabel.AutoSize = true;
            this.firstPizzaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.firstPizzaLabel.Location = new System.Drawing.Point(61, 62);
            this.firstPizzaLabel.Name = "firstPizzaLabel";
            this.firstPizzaLabel.Size = new System.Drawing.Size(100, 25);
            this.firstPizzaLabel.TabIndex = 0;
            this.firstPizzaLabel.Text = "firstPizza";
            // 
            // secondPizzaLabel
            // 
            this.secondPizzaLabel.AutoSize = true;
            this.secondPizzaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.secondPizzaLabel.Location = new System.Drawing.Point(61, 97);
            this.secondPizzaLabel.Name = "secondPizzaLabel";
            this.secondPizzaLabel.Size = new System.Drawing.Size(135, 25);
            this.secondPizzaLabel.TabIndex = 4;
            this.secondPizzaLabel.Text = "secondPizza";
            // 
            // pizzaLabel
            // 
            this.pizzaLabel.AutoSize = true;
            this.pizzaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.pizzaLabel.Location = new System.Drawing.Point(32, 22);
            this.pizzaLabel.Name = "pizzaLabel";
            this.pizzaLabel.Size = new System.Drawing.Size(81, 31);
            this.pizzaLabel.TabIndex = 5;
            this.pizzaLabel.Text = "Pizza";
            // 
            // mainDishLabel
            // 
            this.mainDishLabel.AutoSize = true;
            this.mainDishLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.mainDishLabel.Location = new System.Drawing.Point(32, 209);
            this.mainDishLabel.Name = "mainDishLabel";
            this.mainDishLabel.Size = new System.Drawing.Size(178, 31);
            this.mainDishLabel.TabIndex = 6;
            this.mainDishLabel.Text = "Dania główne";
            // 
            // soupLabel
            // 
            this.soupLabel.AutoSize = true;
            this.soupLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.soupLabel.Location = new System.Drawing.Point(32, 365);
            this.soupLabel.Name = "soupLabel";
            this.soupLabel.Size = new System.Drawing.Size(75, 31);
            this.soupLabel.TabIndex = 7;
            this.soupLabel.Text = "Zupy";
            // 
            // drinksLabel
            // 
            this.drinksLabel.AutoSize = true;
            this.drinksLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.drinksLabel.Location = new System.Drawing.Point(32, 491);
            this.drinksLabel.Name = "drinksLabel";
            this.drinksLabel.Size = new System.Drawing.Size(100, 31);
            this.drinksLabel.TabIndex = 8;
            this.drinksLabel.Text = "Napoje";
            // 
            // thirdPizzaLabel
            // 
            this.thirdPizzaLabel.AutoSize = true;
            this.thirdPizzaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.thirdPizzaLabel.Location = new System.Drawing.Point(62, 135);
            this.thirdPizzaLabel.Name = "thirdPizzaLabel";
            this.thirdPizzaLabel.Size = new System.Drawing.Size(107, 25);
            this.thirdPizzaLabel.TabIndex = 9;
            this.thirdPizzaLabel.Text = "thirdPizza";
            // 
            // fourthPizzaLabel
            // 
            this.fourthPizzaLabel.AutoSize = true;
            this.fourthPizzaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.fourthPizzaLabel.Location = new System.Drawing.Point(61, 175);
            this.fourthPizzaLabel.Name = "fourthPizzaLabel";
            this.fourthPizzaLabel.Size = new System.Drawing.Size(120, 25);
            this.fourthPizzaLabel.TabIndex = 10;
            this.fourthPizzaLabel.Text = "fourthPizza";
            // 
            // firstMainDishLabel
            // 
            this.firstMainDishLabel.AutoSize = true;
            this.firstMainDishLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.firstMainDishLabel.Location = new System.Drawing.Point(61, 252);
            this.firstMainDishLabel.Name = "firstMainDishLabel";
            this.firstMainDishLabel.Size = new System.Drawing.Size(137, 25);
            this.firstMainDishLabel.TabIndex = 11;
            this.firstMainDishLabel.Text = "firstMainDish";
            // 
            // secondMainDishLabel
            // 
            this.secondMainDishLabel.AutoSize = true;
            this.secondMainDishLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.secondMainDishLabel.Location = new System.Drawing.Point(61, 288);
            this.secondMainDishLabel.Name = "secondMainDishLabel";
            this.secondMainDishLabel.Size = new System.Drawing.Size(172, 25);
            this.secondMainDishLabel.TabIndex = 12;
            this.secondMainDishLabel.Text = "secondMainDish";
            // 
            // thirdMainDishLabel
            // 
            this.thirdMainDishLabel.AutoSize = true;
            this.thirdMainDishLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.thirdMainDishLabel.Location = new System.Drawing.Point(61, 327);
            this.thirdMainDishLabel.Name = "thirdMainDishLabel";
            this.thirdMainDishLabel.Size = new System.Drawing.Size(144, 25);
            this.thirdMainDishLabel.TabIndex = 13;
            this.thirdMainDishLabel.Text = "thirdMainDish";
            // 
            // firstSoupLabel
            // 
            this.firstSoupLabel.AutoSize = true;
            this.firstSoupLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.firstSoupLabel.Location = new System.Drawing.Point(67, 410);
            this.firstSoupLabel.Name = "firstSoupLabel";
            this.firstSoupLabel.Size = new System.Drawing.Size(97, 25);
            this.firstSoupLabel.TabIndex = 14;
            this.firstSoupLabel.Text = "firstSoup";
            // 
            // secondSoupLabel
            // 
            this.secondSoupLabel.AutoSize = true;
            this.secondSoupLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.secondSoupLabel.Location = new System.Drawing.Point(67, 450);
            this.secondSoupLabel.Name = "secondSoupLabel";
            this.secondSoupLabel.Size = new System.Drawing.Size(132, 25);
            this.secondSoupLabel.TabIndex = 15;
            this.secondSoupLabel.Text = "secondSoup";
            // 
            // firstDrinkLabel
            // 
            this.firstDrinkLabel.AutoSize = true;
            this.firstDrinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.firstDrinkLabel.Location = new System.Drawing.Point(62, 534);
            this.firstDrinkLabel.Name = "firstDrinkLabel";
            this.firstDrinkLabel.Size = new System.Drawing.Size(97, 25);
            this.firstDrinkLabel.TabIndex = 16;
            this.firstDrinkLabel.Text = "firstDrink";
            // 
            // secondDrinkLabel
            // 
            this.secondDrinkLabel.AutoSize = true;
            this.secondDrinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.secondDrinkLabel.Location = new System.Drawing.Point(61, 572);
            this.secondDrinkLabel.Name = "secondDrinkLabel";
            this.secondDrinkLabel.Size = new System.Drawing.Size(132, 25);
            this.secondDrinkLabel.TabIndex = 17;
            this.secondDrinkLabel.Text = "secondDrink";
            // 
            // thirdDrinkLabel
            // 
            this.thirdDrinkLabel.AutoSize = true;
            this.thirdDrinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.thirdDrinkLabel.Location = new System.Drawing.Point(62, 606);
            this.thirdDrinkLabel.Name = "thirdDrinkLabel";
            this.thirdDrinkLabel.Size = new System.Drawing.Size(104, 25);
            this.thirdDrinkLabel.TabIndex = 18;
            this.thirdDrinkLabel.Text = "thirdDrink";
            // 
            // firstPizzaButton
            // 
            this.firstPizzaButton.Location = new System.Drawing.Point(550, 62);
            this.firstPizzaButton.Name = "firstPizzaButton";
            this.firstPizzaButton.Size = new System.Drawing.Size(32, 25);
            this.firstPizzaButton.TabIndex = 19;
            this.firstPizzaButton.Tag = "firstPizza";
            this.firstPizzaButton.Text = "+";
            this.firstPizzaButton.UseVisualStyleBackColor = true;
            this.firstPizzaButton.Click += new System.EventHandler(this.PizzaButton_Click);
            // 
            // secondPizzaButton
            // 
            this.secondPizzaButton.Location = new System.Drawing.Point(550, 97);
            this.secondPizzaButton.Name = "secondPizzaButton";
            this.secondPizzaButton.Size = new System.Drawing.Size(32, 25);
            this.secondPizzaButton.TabIndex = 20;
            this.secondPizzaButton.Tag = "secondPizza";
            this.secondPizzaButton.Text = "+";
            this.secondPizzaButton.UseVisualStyleBackColor = true;
            this.secondPizzaButton.Click += new System.EventHandler(this.PizzaButton_Click);
            // 
            // thirdPizzaButton
            // 
            this.thirdPizzaButton.Location = new System.Drawing.Point(550, 135);
            this.thirdPizzaButton.Name = "thirdPizzaButton";
            this.thirdPizzaButton.Size = new System.Drawing.Size(32, 25);
            this.thirdPizzaButton.TabIndex = 21;
            this.thirdPizzaButton.Tag = "thirdPizza";
            this.thirdPizzaButton.Text = "+";
            this.thirdPizzaButton.UseVisualStyleBackColor = true;
            this.thirdPizzaButton.Click += new System.EventHandler(this.PizzaButton_Click);
            // 
            // fourthPizzaButton
            // 
            this.fourthPizzaButton.Location = new System.Drawing.Point(550, 175);
            this.fourthPizzaButton.Name = "fourthPizzaButton";
            this.fourthPizzaButton.Size = new System.Drawing.Size(32, 25);
            this.fourthPizzaButton.TabIndex = 22;
            this.fourthPizzaButton.Tag = "fourthPizza";
            this.fourthPizzaButton.Text = "+";
            this.fourthPizzaButton.UseVisualStyleBackColor = true;
            this.fourthPizzaButton.Click += new System.EventHandler(this.PizzaButton_Click);
            // 
            // firstMainDishButton
            // 
            this.firstMainDishButton.Location = new System.Drawing.Point(550, 252);
            this.firstMainDishButton.Name = "firstMainDishButton";
            this.firstMainDishButton.Size = new System.Drawing.Size(32, 25);
            this.firstMainDishButton.TabIndex = 23;
            this.firstMainDishButton.Tag = "firstMainDish";
            this.firstMainDishButton.Text = "+";
            this.firstMainDishButton.UseVisualStyleBackColor = true;
            this.firstMainDishButton.Click += new System.EventHandler(this.MainDishButton_Click);
            // 
            // secondMainDishButton
            // 
            this.secondMainDishButton.Location = new System.Drawing.Point(550, 288);
            this.secondMainDishButton.Name = "secondMainDishButton";
            this.secondMainDishButton.Size = new System.Drawing.Size(32, 25);
            this.secondMainDishButton.TabIndex = 24;
            this.secondMainDishButton.Tag = "secondMainDish";
            this.secondMainDishButton.Text = "+";
            this.secondMainDishButton.UseVisualStyleBackColor = true;
            this.secondMainDishButton.Click += new System.EventHandler(this.MainDishButton_Click);
            // 
            // thirdMainDishButton
            // 
            this.thirdMainDishButton.Location = new System.Drawing.Point(550, 327);
            this.thirdMainDishButton.Name = "thirdMainDishButton";
            this.thirdMainDishButton.Size = new System.Drawing.Size(32, 25);
            this.thirdMainDishButton.TabIndex = 25;
            this.thirdMainDishButton.Tag = "thirdMainDish";
            this.thirdMainDishButton.Text = "+";
            this.thirdMainDishButton.UseVisualStyleBackColor = true;
            this.thirdMainDishButton.Click += new System.EventHandler(this.MainDishButton_Click);
            // 
            // firstSoupButton
            // 
            this.firstSoupButton.Location = new System.Drawing.Point(550, 410);
            this.firstSoupButton.Name = "firstSoupButton";
            this.firstSoupButton.Size = new System.Drawing.Size(32, 25);
            this.firstSoupButton.TabIndex = 26;
            this.firstSoupButton.Tag = "firstSoup";
            this.firstSoupButton.Text = "+";
            this.firstSoupButton.UseVisualStyleBackColor = true;
            this.firstSoupButton.Click += new System.EventHandler(this.SideProductButton_Click);
            // 
            // secondSoupButton
            // 
            this.secondSoupButton.Location = new System.Drawing.Point(550, 450);
            this.secondSoupButton.Name = "secondSoupButton";
            this.secondSoupButton.Size = new System.Drawing.Size(32, 25);
            this.secondSoupButton.TabIndex = 27;
            this.secondSoupButton.Tag = "secondSoup";
            this.secondSoupButton.Text = "+";
            this.secondSoupButton.UseVisualStyleBackColor = true;
            this.secondSoupButton.Click += new System.EventHandler(this.SideProductButton_Click);
            // 
            // firstDrinkButton
            // 
            this.firstDrinkButton.Location = new System.Drawing.Point(550, 534);
            this.firstDrinkButton.Name = "firstDrinkButton";
            this.firstDrinkButton.Size = new System.Drawing.Size(32, 25);
            this.firstDrinkButton.TabIndex = 28;
            this.firstDrinkButton.Tag = "firstDrink";
            this.firstDrinkButton.Text = "+";
            this.firstDrinkButton.UseVisualStyleBackColor = true;
            this.firstDrinkButton.Click += new System.EventHandler(this.SideProductButton_Click);
            // 
            // secondDrinkButton
            // 
            this.secondDrinkButton.Location = new System.Drawing.Point(550, 572);
            this.secondDrinkButton.Name = "secondDrinkButton";
            this.secondDrinkButton.Size = new System.Drawing.Size(32, 25);
            this.secondDrinkButton.TabIndex = 29;
            this.secondDrinkButton.Tag = "secondDrink";
            this.secondDrinkButton.Text = "+";
            this.secondDrinkButton.UseVisualStyleBackColor = true;
            this.secondDrinkButton.Click += new System.EventHandler(this.SideProductButton_Click);
            // 
            // thirdDrinkButton
            // 
            this.thirdDrinkButton.Location = new System.Drawing.Point(550, 606);
            this.thirdDrinkButton.Name = "thirdDrinkButton";
            this.thirdDrinkButton.Size = new System.Drawing.Size(32, 25);
            this.thirdDrinkButton.TabIndex = 30;
            this.thirdDrinkButton.Tag = "thirdDrink";
            this.thirdDrinkButton.Text = "+";
            this.thirdDrinkButton.UseVisualStyleBackColor = true;
            this.thirdDrinkButton.Click += new System.EventHandler(this.SideProductButton_Click);
            // 
            // basketLabel
            // 
            this.basketLabel.AutoSize = true;
            this.basketLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.basketLabel.Location = new System.Drawing.Point(741, 27);
            this.basketLabel.Name = "basketLabel";
            this.basketLabel.Size = new System.Drawing.Size(135, 36);
            this.basketLabel.TabIndex = 31;
            this.basketLabel.Text = "KOSZYK";
            // 
            // commentsTextbox
            // 
            this.commentsTextbox.Location = new System.Drawing.Point(654, 364);
            this.commentsTextbox.Multiline = true;
            this.commentsTextbox.Name = "commentsTextbox";
            this.commentsTextbox.Size = new System.Drawing.Size(322, 157);
            this.commentsTextbox.TabIndex = 32;
            // 
            // commentsLabel
            // 
            this.commentsLabel.AutoSize = true;
            this.commentsLabel.Location = new System.Drawing.Point(766, 348);
            this.commentsLabel.Name = "commentsLabel";
            this.commentsLabel.Size = new System.Drawing.Size(110, 13);
            this.commentsLabel.TabIndex = 33;
            this.commentsLabel.Text = "Uwagi do zamówienia";
            // 
            // orderListbox
            // 
            this.orderListbox.ColumnWidth = 2;
            this.orderListbox.FormattingEnabled = true;
            this.orderListbox.HorizontalExtent = 512;
            this.orderListbox.HorizontalScrollbar = true;
            this.orderListbox.Location = new System.Drawing.Point(654, 105);
            this.orderListbox.Name = "orderListbox";
            this.orderListbox.Size = new System.Drawing.Size(322, 173);
            this.orderListbox.TabIndex = 34;
            // 
            // orderLabel
            // 
            this.orderLabel.AutoSize = true;
            this.orderLabel.Location = new System.Drawing.Point(766, 89);
            this.orderLabel.Name = "orderLabel";
            this.orderLabel.Size = new System.Drawing.Size(87, 13);
            this.orderLabel.TabIndex = 35;
            this.orderLabel.Text = "Lista zawówienia";
            // 
            // deleteDishButton
            // 
            this.deleteDishButton.Location = new System.Drawing.Point(876, 284);
            this.deleteDishButton.Name = "deleteDishButton";
            this.deleteDishButton.Size = new System.Drawing.Size(75, 23);
            this.deleteDishButton.TabIndex = 36;
            this.deleteDishButton.Text = "Usuń";
            this.deleteDishButton.UseVisualStyleBackColor = true;
            this.deleteDishButton.Click += new System.EventHandler(this.deleteDishButton_Click);
            // 
            // decreaseDishQuantityButton
            // 
            this.decreaseDishQuantityButton.Location = new System.Drawing.Point(684, 284);
            this.decreaseDishQuantityButton.Name = "decreaseDishQuantityButton";
            this.decreaseDishQuantityButton.Size = new System.Drawing.Size(75, 23);
            this.decreaseDishQuantityButton.TabIndex = 37;
            this.decreaseDishQuantityButton.Text = "-";
            this.decreaseDishQuantityButton.UseVisualStyleBackColor = true;
            this.decreaseDishQuantityButton.Click += new System.EventHandler(this.decreaseDishQuantityButton_Click);
            // 
            // increaseDishQuantityButton
            // 
            this.increaseDishQuantityButton.Location = new System.Drawing.Point(778, 284);
            this.increaseDishQuantityButton.Name = "increaseDishQuantityButton";
            this.increaseDishQuantityButton.Size = new System.Drawing.Size(75, 23);
            this.increaseDishQuantityButton.TabIndex = 38;
            this.increaseDishQuantityButton.Text = "+";
            this.increaseDishQuantityButton.UseVisualStyleBackColor = true;
            this.increaseDishQuantityButton.Click += new System.EventHandler(this.increaseDishQuantityButton_Click);
            // 
            // confirmOrderButton
            // 
            this.confirmOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.confirmOrderButton.Location = new System.Drawing.Point(708, 588);
            this.confirmOrderButton.Name = "confirmOrderButton";
            this.confirmOrderButton.Size = new System.Drawing.Size(221, 43);
            this.confirmOrderButton.TabIndex = 39;
            this.confirmOrderButton.Text = "ZAMÓW";
            this.confirmOrderButton.UseVisualStyleBackColor = true;
            this.confirmOrderButton.Click += new System.EventHandler(this.confirmOrderButton_Click);
            // 
            // toPayLabel
            // 
            this.toPayLabel.AutoSize = true;
            this.toPayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.toPayLabel.Location = new System.Drawing.Point(703, 541);
            this.toPayLabel.Name = "toPayLabel";
            this.toPayLabel.Size = new System.Drawing.Size(110, 25);
            this.toPayLabel.TabIndex = 41;
            this.toPayLabel.Text = "Do zapłaty:";
            // 
            // TotalPriceLabel
            // 
            this.TotalPriceLabel.AutoSize = true;
            this.TotalPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.TotalPriceLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TotalPriceLabel.Location = new System.Drawing.Point(819, 541);
            this.TotalPriceLabel.Name = "TotalPriceLabel";
            this.TotalPriceLabel.Size = new System.Drawing.Size(37, 25);
            this.TotalPriceLabel.TabIndex = 42;
            this.TotalPriceLabel.Text = "0zł";
            // 
            // orderHistoryButton
            // 
            this.orderHistoryButton.Image = global::Pizzeria.Properties.Resources.list_icon2;
            this.orderHistoryButton.Location = new System.Drawing.Point(938, 46);
            this.orderHistoryButton.Name = "orderHistoryButton";
            this.orderHistoryButton.Size = new System.Drawing.Size(38, 31);
            this.orderHistoryButton.TabIndex = 44;
            this.orderHistoryButton.UseVisualStyleBackColor = true;
            this.orderHistoryButton.Click += new System.EventHandler(this.orderHistoryButton_Click);
            // 
            // configButton
            // 
            this.configButton.Image = global::Pizzeria.Properties.Resources.settings_icon1;
            this.configButton.Location = new System.Drawing.Point(938, 9);
            this.configButton.Name = "configButton";
            this.configButton.Size = new System.Drawing.Size(38, 31);
            this.configButton.TabIndex = 43;
            this.configButton.UseVisualStyleBackColor = true;
            this.configButton.Click += new System.EventHandler(this.configButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 672);
            this.Controls.Add(this.orderHistoryButton);
            this.Controls.Add(this.configButton);
            this.Controls.Add(this.TotalPriceLabel);
            this.Controls.Add(this.toPayLabel);
            this.Controls.Add(this.confirmOrderButton);
            this.Controls.Add(this.increaseDishQuantityButton);
            this.Controls.Add(this.decreaseDishQuantityButton);
            this.Controls.Add(this.deleteDishButton);
            this.Controls.Add(this.orderLabel);
            this.Controls.Add(this.orderListbox);
            this.Controls.Add(this.commentsLabel);
            this.Controls.Add(this.commentsTextbox);
            this.Controls.Add(this.basketLabel);
            this.Controls.Add(this.thirdDrinkButton);
            this.Controls.Add(this.secondDrinkButton);
            this.Controls.Add(this.firstDrinkButton);
            this.Controls.Add(this.secondSoupButton);
            this.Controls.Add(this.firstSoupButton);
            this.Controls.Add(this.thirdMainDishButton);
            this.Controls.Add(this.secondMainDishButton);
            this.Controls.Add(this.firstMainDishButton);
            this.Controls.Add(this.fourthPizzaButton);
            this.Controls.Add(this.thirdPizzaButton);
            this.Controls.Add(this.secondPizzaButton);
            this.Controls.Add(this.firstPizzaButton);
            this.Controls.Add(this.thirdDrinkLabel);
            this.Controls.Add(this.secondDrinkLabel);
            this.Controls.Add(this.firstDrinkLabel);
            this.Controls.Add(this.secondSoupLabel);
            this.Controls.Add(this.firstSoupLabel);
            this.Controls.Add(this.thirdMainDishLabel);
            this.Controls.Add(this.secondMainDishLabel);
            this.Controls.Add(this.firstMainDishLabel);
            this.Controls.Add(this.fourthPizzaLabel);
            this.Controls.Add(this.thirdPizzaLabel);
            this.Controls.Add(this.drinksLabel);
            this.Controls.Add(this.soupLabel);
            this.Controls.Add(this.mainDishLabel);
            this.Controls.Add(this.pizzaLabel);
            this.Controls.Add(this.secondPizzaLabel);
            this.Controls.Add(this.firstPizzaLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label firstPizzaLabel;
        private System.Windows.Forms.Label secondPizzaLabel;
        private System.Windows.Forms.Label pizzaLabel;
        private System.Windows.Forms.Label mainDishLabel;
        private System.Windows.Forms.Label soupLabel;
        private System.Windows.Forms.Label drinksLabel;
        private System.Windows.Forms.Label thirdPizzaLabel;
        private System.Windows.Forms.Label fourthPizzaLabel;
        private System.Windows.Forms.Label firstMainDishLabel;
        private System.Windows.Forms.Label secondMainDishLabel;
        private System.Windows.Forms.Label thirdMainDishLabel;
        private System.Windows.Forms.Label firstSoupLabel;
        private System.Windows.Forms.Label secondSoupLabel;
        private System.Windows.Forms.Label firstDrinkLabel;
        private System.Windows.Forms.Label secondDrinkLabel;
        private System.Windows.Forms.Label thirdDrinkLabel;
        private System.Windows.Forms.Button firstPizzaButton;
        private System.Windows.Forms.Button secondPizzaButton;
        private System.Windows.Forms.Button thirdPizzaButton;
        private System.Windows.Forms.Button fourthPizzaButton;
        private System.Windows.Forms.Button firstMainDishButton;
        private System.Windows.Forms.Button secondMainDishButton;
        private System.Windows.Forms.Button thirdMainDishButton;
        private System.Windows.Forms.Button firstSoupButton;
        private System.Windows.Forms.Button secondSoupButton;
        private System.Windows.Forms.Button firstDrinkButton;
        private System.Windows.Forms.Button secondDrinkButton;
        private System.Windows.Forms.Button thirdDrinkButton;
        private System.Windows.Forms.Label basketLabel;
        private System.Windows.Forms.TextBox commentsTextbox;
        private System.Windows.Forms.Label commentsLabel;
        private System.Windows.Forms.ListBox orderListbox;
        private System.Windows.Forms.Label orderLabel;
        private System.Windows.Forms.Button deleteDishButton;
        private System.Windows.Forms.Button decreaseDishQuantityButton;
        private System.Windows.Forms.Button increaseDishQuantityButton;
        private System.Windows.Forms.Button confirmOrderButton;
        private System.Windows.Forms.Label toPayLabel;
        private System.Windows.Forms.Label TotalPriceLabel;
        private System.Windows.Forms.Button configButton;
        private System.Windows.Forms.Button orderHistoryButton;
    }
}

