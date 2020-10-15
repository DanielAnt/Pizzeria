namespace Pizzeria
{
    partial class PizzaForm
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
        /// 

             

        private void InitializeComponent()
        {
            this.firstPizzaToppingCheckbox = new System.Windows.Forms.CheckBox();
            this.extrasLabel = new System.Windows.Forms.Label();
            this.secondPizzaToppingCheckbox = new System.Windows.Forms.CheckBox();
            this.thirdPizzaToppingCheckbox = new System.Windows.Forms.CheckBox();
            this.fourthPizzaToppingCheckbox = new System.Windows.Forms.CheckBox();
            this.pizzaNameLabel = new System.Windows.Forms.Label();
            this.increaseQuantityButton = new System.Windows.Forms.Button();
            this.quantityTextbox = new System.Windows.Forms.TextBox();
            this.decreaseQuantityButton = new System.Windows.Forms.Button();
            this.addPizzaButton = new System.Windows.Forms.Button();
            this.pizzaPriceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // extrasLabel
            // 
            this.extrasLabel.AutoSize = true;
            this.extrasLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.extrasLabel.Location = new System.Drawing.Point(12, 73);
            this.extrasLabel.Name = "extrasLabel";
            this.extrasLabel.Size = new System.Drawing.Size(133, 26);
            this.extrasLabel.TabIndex = 1;
            this.extrasLabel.Text = "Dodatki";
            // 
            // firstPizzaToppingCheckbox
            // 
            this.firstPizzaToppingCheckbox.AutoSize = true;
            this.firstPizzaToppingCheckbox.Location = new System.Drawing.Point(18, 120);
            this.firstPizzaToppingCheckbox.Name = "firstPizzaTopping";
            this.firstPizzaToppingCheckbox.Size = new System.Drawing.Size(40, 17);
            this.firstPizzaToppingCheckbox.TabIndex = 0;
            this.firstPizzaToppingCheckbox.Text = "firstPizzaTopping";
            this.firstPizzaToppingCheckbox.UseVisualStyleBackColor = true;
            this.firstPizzaToppingCheckbox.CheckedChanged += new System.EventHandler(this.checkbox_CheckedChanged);
            // 
            // secondPizzaToppingCheckbox
            // 
            this.secondPizzaToppingCheckbox.AutoSize = true;
            this.secondPizzaToppingCheckbox.Location = new System.Drawing.Point(18, 158);
            this.secondPizzaToppingCheckbox.Name = "secondPizzaTopping";
            this.secondPizzaToppingCheckbox.Size = new System.Drawing.Size(55, 17);
            this.secondPizzaToppingCheckbox.TabIndex = 2;
            this.secondPizzaToppingCheckbox.Text = "secondPizzaTopping";
            this.secondPizzaToppingCheckbox.UseVisualStyleBackColor = true;
            this.secondPizzaToppingCheckbox.CheckedChanged += new System.EventHandler(this.checkbox_CheckedChanged);
            // 
            // thirdPizzaToppingCheckbox
            // 
            this.thirdPizzaToppingCheckbox.AutoSize = true;
            this.thirdPizzaToppingCheckbox.Location = new System.Drawing.Point(144, 120);
            this.thirdPizzaToppingCheckbox.Name = "thirdPizzaTopping";
            this.thirdPizzaToppingCheckbox.Size = new System.Drawing.Size(59, 17);
            this.thirdPizzaToppingCheckbox.TabIndex = 3;
            this.thirdPizzaToppingCheckbox.Text = "thirdPizzaTopping";
            this.thirdPizzaToppingCheckbox.UseVisualStyleBackColor = true;
            this.thirdPizzaToppingCheckbox.CheckedChanged += new System.EventHandler(this.checkbox_CheckedChanged);
            // 
            // fourthPizzaToppingCheckbox
            // 
            this.fourthPizzaToppingCheckbox.AutoSize = true;
            this.fourthPizzaToppingCheckbox.Location = new System.Drawing.Point(144, 158);
            this.fourthPizzaToppingCheckbox.Name = "fourthPizzaTopping";
            this.fourthPizzaToppingCheckbox.Size = new System.Drawing.Size(68, 17);
            this.fourthPizzaToppingCheckbox.TabIndex = 4;
            this.fourthPizzaToppingCheckbox.Text = "fourthPizzaTopping";
            this.fourthPizzaToppingCheckbox.UseVisualStyleBackColor = true;
            this.fourthPizzaToppingCheckbox.CheckedChanged += new System.EventHandler(this.checkbox_CheckedChanged);
            // 
            // pizzaNameLabel
            // 
            this.pizzaNameLabel.AutoSize = true;
            this.pizzaNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F);
            this.pizzaNameLabel.Location = new System.Drawing.Point(12, 20);
            this.pizzaNameLabel.Name = "pizzaNameLabel";
            this.pizzaNameLabel.Size = new System.Drawing.Size(159, 32);
            this.pizzaNameLabel.TabIndex = 5;
            this.pizzaNameLabel.Text = "pizza_label";
            // 
            // increaseQuantityButton
            // 
            this.increaseQuantityButton.Location = new System.Drawing.Point(96, 210);
            this.increaseQuantityButton.Name = "increaseQuantityButton";
            this.increaseQuantityButton.Size = new System.Drawing.Size(20, 20);
            this.increaseQuantityButton.TabIndex = 6;
            this.increaseQuantityButton.Text = "+";
            this.increaseQuantityButton.UseVisualStyleBackColor = true;
            this.increaseQuantityButton.Click += new System.EventHandler(this.increaseQuantityButton_Click);
            // 
            // quantityTextbox
            // 
            this.quantityTextbox.Location = new System.Drawing.Point(44, 210);
            this.quantityTextbox.Name = "quantityTextbox";
            this.quantityTextbox.Size = new System.Drawing.Size(46, 20);
            this.quantityTextbox.TabIndex = 7;
            this.quantityTextbox.Text = "1";
            this.quantityTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.quantityTextbox.TextChanged += new System.EventHandler(this.quantityTextbox_TextChanged);
            this.quantityTextbox.Leave += new System.EventHandler(this.quantityTextbox_Leave);
            // 
            // decreaseQuantityButton
            // 
            this.decreaseQuantityButton.Location = new System.Drawing.Point(18, 210);
            this.decreaseQuantityButton.Name = "decreaseQuantityButton";
            this.decreaseQuantityButton.Size = new System.Drawing.Size(20, 20);
            this.decreaseQuantityButton.TabIndex = 8;
            this.decreaseQuantityButton.Text = "-";
            this.decreaseQuantityButton.UseVisualStyleBackColor = true;
            this.decreaseQuantityButton.Click += new System.EventHandler(this.decreaseQuantityButton_Click);
            // 
            // addPizzaButton
            // 
            this.addPizzaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.addPizzaButton.Location = new System.Drawing.Point(46, 248);
            this.addPizzaButton.Name = "addPizzaButton";
            this.addPizzaButton.Size = new System.Drawing.Size(166, 49);
            this.addPizzaButton.TabIndex = 9;
            this.addPizzaButton.Text = "Dodaj";
            this.addPizzaButton.UseVisualStyleBackColor = true;
            this.addPizzaButton.Click += new System.EventHandler(this.addPizzaButton_Click);
            // 
            // pizzaPriceLabel
            // 
            this.pizzaPriceLabel.AutoSize = true;
            this.pizzaPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.pizzaPriceLabel.Location = new System.Drawing.Point(167, 204);
            this.pizzaPriceLabel.Name = "pizzaPriceLabel";
            this.pizzaPriceLabel.Size = new System.Drawing.Size(37, 25);
            this.pizzaPriceLabel.TabIndex = 10;
            this.pizzaPriceLabel.Text = "0zł";
            // 
            // PizzaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 313);
            this.Controls.Add(this.pizzaPriceLabel);
            this.Controls.Add(this.addPizzaButton);
            this.Controls.Add(this.decreaseQuantityButton);
            this.Controls.Add(this.quantityTextbox);
            this.Controls.Add(this.increaseQuantityButton);
            this.Controls.Add(this.pizzaNameLabel);
            this.Controls.Add(this.fourthPizzaToppingCheckbox);
            this.Controls.Add(this.thirdPizzaToppingCheckbox);
            this.Controls.Add(this.secondPizzaToppingCheckbox);
            this.Controls.Add(this.extrasLabel);
            this.Controls.Add(this.firstPizzaToppingCheckbox);
            this.Name = "PizzaForm";
            this.Text = "PizzaForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox firstPizzaToppingCheckbox;
        private System.Windows.Forms.Label extrasLabel;
        private System.Windows.Forms.CheckBox secondPizzaToppingCheckbox;
        private System.Windows.Forms.CheckBox thirdPizzaToppingCheckbox;
        private System.Windows.Forms.CheckBox fourthPizzaToppingCheckbox;
        private System.Windows.Forms.Label pizzaNameLabel;
        private System.Windows.Forms.Button increaseQuantityButton;
        private System.Windows.Forms.TextBox quantityTextbox;
        private System.Windows.Forms.Button decreaseQuantityButton;
        private System.Windows.Forms.Button addPizzaButton;
        private System.Windows.Forms.Label pizzaPriceLabel;
    }
}