namespace Pizzeria
{
    partial class MainDishForm
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
            this.dishPriceLabel = new System.Windows.Forms.Label();
            this.addDishButton = new System.Windows.Forms.Button();
            this.decreaseQuantityButton = new System.Windows.Forms.Button();
            this.quantityTextbox = new System.Windows.Forms.TextBox();
            this.increaseQuantityButton = new System.Windows.Forms.Button();
            this.dishNameLabel = new System.Windows.Forms.Label();
            this.saladCheckbox = new System.Windows.Forms.CheckBox();
            this.saucesCheckbox = new System.Windows.Forms.CheckBox();
            this.extrasLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dishPriceLabel
            // 
            this.dishPriceLabel.AutoSize = true;
            this.dishPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.dishPriceLabel.Location = new System.Drawing.Point(209, 189);
            this.dishPriceLabel.Name = "dishPriceLabel";
            this.dishPriceLabel.Size = new System.Drawing.Size(37, 25);
            this.dishPriceLabel.TabIndex = 21;
            this.dishPriceLabel.Text = "0zł";
            // 
            // addDishButton
            // 
            this.addDishButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.addDishButton.Location = new System.Drawing.Point(70, 233);
            this.addDishButton.Name = "addDishButton";
            this.addDishButton.Size = new System.Drawing.Size(204, 50);
            this.addDishButton.TabIndex = 20;
            this.addDishButton.Text = "Dodaj";
            this.addDishButton.UseVisualStyleBackColor = true;
            this.addDishButton.Click += new System.EventHandler(this.addDishButton_Click);
            // 
            // decreaseQuantityButton
            // 
            this.decreaseQuantityButton.Location = new System.Drawing.Point(55, 194);
            this.decreaseQuantityButton.Name = "decreaseQuantityButton";
            this.decreaseQuantityButton.Size = new System.Drawing.Size(20, 20);
            this.decreaseQuantityButton.TabIndex = 19;
            this.decreaseQuantityButton.Text = "-";
            this.decreaseQuantityButton.UseVisualStyleBackColor = true;
            this.decreaseQuantityButton.Click += new System.EventHandler(this.decreaseQuantityButton_Click);
            // 
            // quantityTextbox
            // 
            this.quantityTextbox.Location = new System.Drawing.Point(81, 194);
            this.quantityTextbox.Name = "quantityTextbox";
            this.quantityTextbox.Size = new System.Drawing.Size(46, 20);
            this.quantityTextbox.TabIndex = 18;
            this.quantityTextbox.Text = "1";
            this.quantityTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.quantityTextbox.TextChanged += new System.EventHandler(this.quantityTextbox_TextChanged);
            this.quantityTextbox.Leave += new System.EventHandler(this.quantityTextbox_Leave);
            // 
            // increaseQuantityButton
            // 
            this.increaseQuantityButton.Location = new System.Drawing.Point(133, 194);
            this.increaseQuantityButton.Name = "increaseQuantityButton";
            this.increaseQuantityButton.Size = new System.Drawing.Size(20, 20);
            this.increaseQuantityButton.TabIndex = 17;
            this.increaseQuantityButton.Text = "+";
            this.increaseQuantityButton.UseVisualStyleBackColor = true;
            this.increaseQuantityButton.Click += new System.EventHandler(this.increaseQuantityButton_Click);
            // 
            // dishNameLabel
            // 
            this.dishNameLabel.AutoSize = true;
            this.dishNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.dishNameLabel.Location = new System.Drawing.Point(10, 32);
            this.dishNameLabel.MaximumSize = new System.Drawing.Size(300, 0);
            this.dishNameLabel.Name = "dishNameLabel";
            this.dishNameLabel.Size = new System.Drawing.Size(100, 25);
            this.dishNameLabel.TabIndex = 16;
            this.dishNameLabel.Text = "dish_label";
            // 
            // saladCheckbox
            // 
            this.saladCheckbox.AutoSize = true;
            this.saladCheckbox.Location = new System.Drawing.Point(167, 146);
            this.saladCheckbox.Name = "saladCheckbox";
            this.saladCheckbox.Size = new System.Drawing.Size(117, 17);
            this.saladCheckbox.TabIndex = 15;
            this.saladCheckbox.Text = "bar sałatkowy - 5zł";
            this.saladCheckbox.UseVisualStyleBackColor = true;
            this.saladCheckbox.CheckedChanged += new System.EventHandler(this.checkboxCheckedChanged);
            // 
            // saucesCheckbox
            // 
            this.saucesCheckbox.AutoSize = true;
            this.saucesCheckbox.Location = new System.Drawing.Point(25, 146);
            this.saucesCheckbox.Name = "saucesCheckbox";
            this.saucesCheckbox.Size = new System.Drawing.Size(116, 17);
            this.saucesCheckbox.TabIndex = 14;
            this.saucesCheckbox.Text = "zestaw sosów - 6zł";
            this.saucesCheckbox.UseVisualStyleBackColor = true;
            this.saucesCheckbox.CheckedChanged += new System.EventHandler(this.checkboxCheckedChanged);
            // 
            // extrasLabel
            // 
            this.extrasLabel.AutoSize = true;
            this.extrasLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.extrasLabel.Location = new System.Drawing.Point(11, 105);
            this.extrasLabel.Name = "extrasLabel";
            this.extrasLabel.Size = new System.Drawing.Size(64, 20);
            this.extrasLabel.TabIndex = 12;
            this.extrasLabel.Text = "Dodatki";
            // 
            // MainDishForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 315);
            this.Controls.Add(this.dishPriceLabel);
            this.Controls.Add(this.addDishButton);
            this.Controls.Add(this.decreaseQuantityButton);
            this.Controls.Add(this.quantityTextbox);
            this.Controls.Add(this.increaseQuantityButton);
            this.Controls.Add(this.dishNameLabel);
            this.Controls.Add(this.saladCheckbox);
            this.Controls.Add(this.saucesCheckbox);
            this.Controls.Add(this.extrasLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainDishForm";
            this.Text = "MainDishForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dishPriceLabel;
        private System.Windows.Forms.Button addDishButton;
        private System.Windows.Forms.Button decreaseQuantityButton;
        private System.Windows.Forms.TextBox quantityTextbox;
        private System.Windows.Forms.Button increaseQuantityButton;
        private System.Windows.Forms.Label dishNameLabel;
        private System.Windows.Forms.CheckBox saladCheckbox;
        private System.Windows.Forms.CheckBox saucesCheckbox;
        private System.Windows.Forms.Label extrasLabel;
    }
}